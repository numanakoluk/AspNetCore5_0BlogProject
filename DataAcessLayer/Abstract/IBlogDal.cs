using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAcessLayer.Abstract
{
    public interface IBlogDal : IGenericDal<Blog>
    {
        List<Blog> GetListWithCategory(); //Bu method sadece Bloklara özel olduğu için burada tanımlıyorum.Bunu EfBlogRep' de implemente etmem gerekir.
    }
}
