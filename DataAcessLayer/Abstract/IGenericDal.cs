using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace DataAcessLayer.Abstract
{
    public interface IGenericDal<T> where T: class 
    {
        void Insert(T t);
        void Delete(T t);
        void Update(T t);
        List<T> GetListAll(); //Tümünü getirecek.Parametre almalı hali LINQ sorgulu dışardan herhangi bir parametreye göre arama işlemi

        T GetByID(int id);

        List<T> GetListAll(Expression<Func<T, bool>> filter); //Şartlı sorgularda bu kullanılabilir.

    }
}
