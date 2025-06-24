using BlogStore.EntityLayer.Entities;

namespace BlogStore.BusinessLayer.Abstract
{
    public interface ICommentService : IGenericService<Comment>
    {
        public List<Comment> TGetCommentsByArticle(int id);
    }
}
