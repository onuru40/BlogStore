﻿using BlogStore.BusinessLayer.Abstract;
using BlogStore.DataAccessLayer.Abstract;
using BlogStore.EntityLayer.Entities;

namespace BlogStore.BusinessLayer.Concrete
{
    public class ArticleManager : IArticleService
    {
        private readonly IArticleDal _articleDal;

        public ArticleManager(IArticleDal articleDal)
        {
            _articleDal = articleDal;
        }

        public void TDelete(int id)
        {
            _articleDal.Delete(id);
        }

        public List<Article> TGetAll()
        {
            return _articleDal.GetAll();
        }

        public Article TGetById(int id)
        {
            return _articleDal.GetById(id);
        }

        public void TInsert(Article entity)
        {
            if (entity.Title.Length >= 10 && entity.Title.Length <= 100 && entity.Description != "" && entity.ImageUrl.Contains("a"))
            {
                _articleDal.Insert(entity);
            }
            else
            {
                // hata mesajı
            }
        }

        public void TUpdate(Article entity)
        {
            _articleDal.Update(entity);
        }
    }
}
