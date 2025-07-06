using BlogStore.DataAccessLayer.Abstract;
using BlogStore.DataAccessLayer.Context;
using BlogStore.DataAccessLayer.Dtos;
using BlogStore.DataAccessLayer.Repositories;
using BlogStore.EntityLayer.Entities;
using Microsoft.EntityFrameworkCore;
using System.Linq.Expressions;

namespace BlogStore.DataAccessLayer.EntityFramework
{
    public class EfArticleDal : GenericRepository<Article>, IArticleDal
    {
        private readonly BlogContext _context;
        public EfArticleDal(BlogContext context) : base(context)
        {
            _context = context;
        }

        public AppUser GetAppUserByArticleId(int id)
        {
            var userId = _context.Articles.Where(x => x.ArticleId == id).Select(y => y.AppUserId).FirstOrDefault();
            var userValue = _context.Users.Where(x => x.Id == userId).FirstOrDefault();
            return userValue;
        }

        public List<CategoryArticleCountDto> GetArticleCountByCategory()
        {
            var result = _context.Articles
              .Include(a => a.Category)
              .GroupBy(a => a.Category.CategoryName)
              .Select(b => new CategoryArticleCountDto
              {
                  CategoryName = b.Key,
                  ArticleCount = b.Count()
              })
              .ToList();

            return result;
        }

        public List<Article> GetArticlesByAppUser(string id)
        {
            return _context.Articles.Where(x => x.AppUserId == id).ToList();
        }

        public List<Article> GetArticlesWithCategories()
        {
            return _context.Articles.Include(x => x.Category).ToList();
        }

        public List<Article> GetArticlesWithCategoriesAll()
        {
            return _context.Articles
                    .Include(a => a.Category)
                    .ToList();
        }

        public List<Article> GetLast5ArticleByUser(string id)
        {
            return _context.Articles
                .Where(x => x.AppUserId == id)
                .OrderByDescending(x => x.CreatedDate)
                .Take(5)
                .ToList();
        }

        public List<Article> GetListByFilter(Expression<Func<Article, bool>> filter)
        {
            return _context.Articles.Where(filter).ToList();
        }

        public List<Article> GetTop3PopularArticles()
        {
            var values = _context.Articles.OrderByDescending(x => x.ArticleId).Take(3).ToList();
            return values;
        }
    }
}
