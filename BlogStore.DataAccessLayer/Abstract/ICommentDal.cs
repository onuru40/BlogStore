﻿using BlogStore.EntityLayer.Entities;

namespace BlogStore.DataAccessLayer.Abstract
{
    public interface ICommentDal : IGenericDal<Comment>
    {
        List<Comment> GetCommentsByArticle(int id);
    }
}
