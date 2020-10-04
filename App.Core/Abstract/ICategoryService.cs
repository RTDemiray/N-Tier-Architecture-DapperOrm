using App.Data.Entities;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace App.Core.Abstract
{
    public interface ICategoryService : IService<Categories> //IService içinde ki methodlarıda içeriyor.
    {
        //Kategori servisine özel methodlar.
        Task<IEnumerable<Products>> GetCategoryWithProducts(int Id);
    }
}
