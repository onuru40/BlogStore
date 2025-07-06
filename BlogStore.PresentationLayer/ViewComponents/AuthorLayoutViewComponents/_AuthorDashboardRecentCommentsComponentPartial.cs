using BlogStore.BusinessLayer.Abstract;
using BlogStore.EntityLayer.Entities;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

namespace BlogStore.PresentationLayer.ViewComponents.AuthorLayoutViewComponents
{
    public class _AuthorDashboardRecentCommentsComponentPartial : ViewComponent
    {
        private readonly ICommentService _commentService;
        private readonly UserManager<AppUser> _userManager;

        public _AuthorDashboardRecentCommentsComponentPartial(ICommentService commentService, UserManager<AppUser> userManager)
        {
            _commentService = commentService;
            _userManager = userManager;
        }

        public async Task<IViewComponentResult> InvokeAsync()
        {
            var app = await _userManager.FindByNameAsync(User.Identity.Name);
            var comments = _commentService.TGetLast3CommentByUserArticle(app.Id);
            return View(comments);
        }
    }
}
