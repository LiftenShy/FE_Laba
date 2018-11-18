﻿using System.Linq;

namespace FE_Lab_Beckend.Data.Interface
{
    public interface IRepository<T>
        where T : class
    {
        T GetById(object id);
        void Insert(T entity);
        void Update(T entity);
        void Delete(T entity);
        IQueryable<T> Table { get; }
    }
}
