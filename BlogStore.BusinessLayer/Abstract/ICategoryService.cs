using BlogStore.DataAccessLayer.Dtos;
using BlogStore.EntityLayer.Entities;

namespace BlogStore.BusinessLayer.Abstract
{
    public interface ICategoryService : IGenericService<Category>
    {
        public List<CategoryWithArticleCountDto> TGetCategoryWithArticleCount();
    }
}
