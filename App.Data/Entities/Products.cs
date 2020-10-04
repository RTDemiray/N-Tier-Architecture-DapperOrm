using Dapper.Contrib.Extensions;

namespace App.Data.Entities
{
    [Table("Product")]
    public class Products : BaseEntity
    {
        public string Name { get; set; }
    }
}
