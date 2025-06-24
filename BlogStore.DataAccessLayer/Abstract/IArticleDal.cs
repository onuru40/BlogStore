using BlogStore.EntityLayer.Entities;

namespace BlogStore.DataAccessLayer.Abstract
{
    public interface IArticleDal : IGenericDal<Article>
    {
        List<Article> GetArticlesWithCategories();
        public AppUser GetAppUserByArticleId(int id);
        List<Article> GetTop3PopularArticles();
    }
}