using App.Core.Abstract;
using App.Data.Entities;
using Dapper;
using System.Collections.Generic;
using System.Data;
using System.Threading.Tasks;

namespace App.Core.Concrete
{
    public class CategoryService : Service<Categories>, ICategoryService
    {
        public CategoryService(IDbConnection dbConnection) : base(dbConnection)
        {
        }

        public async Task<IEnumerable<Products>> GetCategoryWithProducts(int Id)
        {
            return await _dbConnection.QueryAsync<Products>("select * from category inner join product on category.Id = product.Id where category.Id=@Id", new { Id = Id });
        }
    }
}
