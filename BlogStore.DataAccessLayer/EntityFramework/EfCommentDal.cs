using BlogStore.DataAccessLayer.Abstract;
using BlogStore.DataAccessLayer.Context;
using BlogStore.DataAccessLayer.Repositories;
using BlogStore.EntityLayer.Entities;
using Microsoft.EntityFrameworkCore;

namespace BlogStore.DataAccessLayer.EntityFramework
{
    public class EfCommentDal : GenericRepository<Comment>, ICommentDal
    {
        private readonly BlogContext _context; // Değiştirilemez yapıyoruz. 
        public EfCommentDal(BlogContext context) : base(context)
        {
            _context = context;
        }

        public List<Comment> GetCommentsByArticle(int id)
        {
            var values = _context.Comments.Include(x => x.AppUser).Include(y => y.Article).Where(z => z.ArticleId == id).ToList();
            return values;
        }

        public List<Comment> GetLast3CommentByUserArticle(string id)
        {
            var values = _context.Comments.Include(x => x.AppUser).Include(x => x.Article)
                .Where(x => x.Article.AppUserId == id && x.IsValid == true).OrderByDescending(x => x.CommentDate).Take(3).ToList();
            return values;
        }
    }
}
