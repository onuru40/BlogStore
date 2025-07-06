using BlogStore.DataAccessLayer.Dtos;
using BlogStore.EntityLayer.Entities;
using System.Linq.Expressions;

namespace BlogStore.DataAccessLayer.Abstract
{
    public interface IArticleDal : IGenericDal<Article>
    {
        List<Article> GetArticlesWithCategories();
        public AppUser GetAppUserByArticleId(int id);
        List<Article> GetTop3PopularArticles();
        List<Article> GetArticlesByAppUser(string id);
        List<Article> GetListByFilter(Expression<Func<Article, bool>> filter);
        List<Article> GetArticlesWithCategoriesAll();
        public List<CategoryArticleCountDto> GetArticleCountByCategory();
        List<Article> GetLast5ArticleByUser(string id);
    }
}