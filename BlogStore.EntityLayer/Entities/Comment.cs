namespace BlogStore.EntityLayer.Entities
{
    public class Comment
    {
        public int CommentId { get; set; }
        public string UserNameSurname { get; set; }
        public DateTime CommentDate { get; set; }
        public string CommentDetail { get; set; }
        public bool IsValid { get; set; }
    }
}
