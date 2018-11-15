using System.Linq;

namespace FE_Lab_Beckend.Data.Interface
{
    interface IRepository<T>
        where T : class
    {
        IQueryable Table { get; set; }

        void Get(int entityId);

        void Insert(T entity);

        void Update(T entity);

        void Delete(int entityId);
    }
}
