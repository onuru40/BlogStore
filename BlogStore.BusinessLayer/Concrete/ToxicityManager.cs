using BlogStore.BusinessLayer.Abstract;
using Microsoft.Extensions.Configuration;
using Newtonsoft.Json;
using System.Net.Http.Headers;
using System.Text;

namespace BlogStore.BusinessLayer.Concrete
{
    public class ToxicityManager : IToxicityDetectionService
    {
        private readonly HttpClient _httpClient;
        private readonly string _huggingFaceApiToken;
        private readonly string _huggingFaceModelUrl;

        public ToxicityManager(HttpClient httpClient, IConfiguration configuration)
        {
            _httpClient = httpClient;

            _huggingFaceApiToken = configuration["HuggingFace:ApiToken"];
            _huggingFaceModelUrl = configuration["HuggingFace:ModelUrl"];

            _httpClient.DefaultRequestHeaders.Authorization =
                new AuthenticationHeaderValue("Bearer", _huggingFaceApiToken);
            _httpClient.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
        }

        public async Task<ToxicityDetectionResult> DetectToxicityAsync(string commentText)
        {
            var requestBody = new { inputs = commentText };
            var jsonContent = new StringContent(JsonConvert.SerializeObject(requestBody), Encoding.UTF8, "application/json");

            var response = await _httpClient.PostAsync(_huggingFaceModelUrl, jsonContent);

            if (response.IsSuccessStatusCode)
            {
                var responseString = await response.Content.ReadAsStringAsync();


                System.Diagnostics.Debug.WriteLine(responseString);
                var modelResponse = JsonConvert.DeserializeObject<List<List<ModelPrediction>>>(responseString);


                var topPrediction = modelResponse[0].OrderByDescending(p => p.Score).FirstOrDefault();

                if (topPrediction != null && topPrediction.Label.ToLower().Contains("toxic"))
                {
                    return new ToxicityDetectionResult
                    {
                        IsToxic = topPrediction.Score > 0.5,
                        Score = topPrediction.Score,
                        DetectedLabel = topPrediction.Label
                    };
                }
                else if (topPrediction != null)
                {

                    return new ToxicityDetectionResult
                    {
                        IsToxic = false,
                        Score = topPrediction.Score,
                        DetectedLabel = topPrediction.Label
                    };
                }
            }

            return new ToxicityDetectionResult { IsToxic = false, Score = 0, DetectedLabel = "undetected" };
        }


        private class ModelPrediction
        {
            public string Label { get; set; }
            public double Score { get; set; }
        }
    }
}