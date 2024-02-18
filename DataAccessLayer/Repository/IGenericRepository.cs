using DataAccessLayer.Abstract;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Repository
{
    public class IGenericRepository<T> : IGenericDal<T> where T : class
    {
        Context DbContext=new Context();
        DbSet<T> _object;
        public IGenericRepository()
        {
            _object=DbContext.Set<T>();
        }
        void IGenericDal<T>.Delete(T entity)
        {            
            _object.Remove(entity);
            DbContext.SaveChanges();
        }

        T IGenericDal<T>.GetByID(int id)
        {
            return _object.Find(id);
        }

        void IGenericDal<T>.Insert(T entity)
        {
            _object.Add(entity);
            DbContext.SaveChanges();
        }

        List<T> IGenericDal<T>.List()
        {
            return _object.ToList();
        }

        List<T> IGenericDal<T>.List1(Expression<Func<T, bool>> filter)
        {
            throw new NotImplementedException();
        }

        void IGenericDal<T>.Update(T entity)
        {
            DbContext.SaveChanges();
        }
    }
}
