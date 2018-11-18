
using FE_Lab_Beckend.Data.Interface;
using Microsoft.EntityFrameworkCore;
using System;
using System.Linq;

namespace FE_Lab_Beckend.Data
{
    public class Repository<T> : IRepository<T>
        where T : class
    {
        private readonly UniversityContext _context = new UniversityContext();
        private DbSet<T> _entities;
        string _errorMessage = string.Empty;

        public T GetById(object id)
        {
            return Entities.Find(id);
        }

        public void Insert(T entity)
        {
            try
            {
                if (entity == null)
                {
                    throw new ArgumentNullException(nameof(entity));
                }
                Entities.Add(entity);
                _context.SaveChanges();
            }
            catch (Exception dbEx)
            {
                throw new Exception(_errorMessage, dbEx);
            }
        }

        public void Update(T entity)
        {
            try
            {
                if (entity == null)
                {
                    throw new ArgumentNullException(nameof(entity));
                }
                _context.SaveChanges();
            }
            catch (Exception dbEx)
            {
                throw new Exception(_errorMessage, dbEx);
            }
        }

        public void Delete(T entity)
        {
            try
            {
                if (entity == null)
                {
                    throw new ArgumentNullException(nameof(entity));
                }

                Entities.Remove(entity);
                _context.SaveChanges();
            }
            catch (Exception dbEx)
            {
                throw new Exception(_errorMessage, dbEx);
            }
        }

        public virtual IQueryable<T> Table => Entities;

        private DbSet<T> Entities => _entities ?? (_entities = _context.Set<T>());

        public void Dispose()
        {
            _context?.Dispose();
        }
    }
}
