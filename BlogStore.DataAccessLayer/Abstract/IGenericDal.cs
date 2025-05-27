﻿namespace BlogStore.DataAccessLayer.Abstract
{
    // Repository Design Pattern yaklaşımı ile CRUD işlemlerini tek bir merkezden yapıyoruz.
    public interface IGenericDal<T> where T : class
    {
        void Insert(T entity);
        void Delete(int id);
        void Update(T entity);
        List<T> GetAll();
        T GetById(int id);
    }
}
