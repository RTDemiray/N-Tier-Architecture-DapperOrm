using App.Core.Abstract;
using App.Data.Entities;
using Dapper;
using System.Collections.Generic;
using System.Data;
using System.Threading.Tasks;

namespace App.Core.Concrete
{
    public class ProductService : Service<Products>, IProductService
    {
        public ProductService(IDbConnection dbConnection) : base(dbConnection)
        {
        }

        public async Task<IEnumerable<Categories>> GetProductsWithCategories(int Id)
        {
            return await _dbConnection.QueryAsync<Categories>("select * from product inner join category on product.Id = category.Id where product.Id=@Id", new { Id = Id });
        }
    }
}
