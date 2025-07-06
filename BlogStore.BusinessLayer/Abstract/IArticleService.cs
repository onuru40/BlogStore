using BlogStore.DataAccessLayer.Dtos;
using BlogStore.EntityLayer.Entities;
using System.Linq.Expressions;

namespace BlogStore.BusinessLayer.Abstract
{
    public interface IArticleService : IGenericService<Article>
    {
        public List<Article> TGetArticlesWithCategories();
        public AppUser TGetAppUserByArticleId(int id);
        public List<Article> TGetTop3PopularArticles();
        public List<Article> TGetArticlesByAppUser(string id);
        List<Article> TGetListByFilter(Expression<Func<Article, bool>> filter);
        List<Article> TGetArticlesWithCategoriesAll();
        public List<CategoryArticleCountDto> TGetArticleCountByCategory();
        List<Article> TGetLast5ArticleByUser(string id);
    }
}
