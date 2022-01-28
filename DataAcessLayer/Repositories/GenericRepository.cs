using DataAcessLayer.Abstract;
using DataAcessLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace DataAcessLayer.Repositories
{
    public class GenericRepository<T> : IGenericDal<T> where T : class
    {
        Context _c = new Context(); 
        public void Delete(T t)
        {
            _c.Remove(t);
            _c.SaveChanges();
        }

        public T GetByID(int id)
        {
            return _c.Set<T>().Find(id);
        }

        public List<T> GetListAll()
        {
            return _c.Set<T>().ToList(); //Direk gelmediği için set şeklinde dedim.Entityi dışarıdan alabilmek için
        }

        public void Insert(T t)
        {
            _c.Add(t);
            _c.SaveChanges();
        }

        public List<T> GetListAll(Expression<Func<T, bool>> filter)
        {
            return _c.Set<T>().Where(filter).ToList();
        }

        public void Update(T t)
        {
            _c.Update(t);
            _c.SaveChanges();
        }
    }
}
