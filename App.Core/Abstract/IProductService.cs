using App.Data.Entities;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace App.Core.Abstract
{
    public interface IProductService : IService<Products> //IService içinde ki methodlarıda içeriyor.
    {
        //Ürünler servisine özel methodlar.
        Task<IEnumerable<Categories>> GetProductsWithCategories(int Id);
    }
}
