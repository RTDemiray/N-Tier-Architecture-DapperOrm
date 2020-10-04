using Dapper.Contrib.Extensions;

namespace App.Data.Entities
{
    [Table("Category")]
    public class Categories : BaseEntity
    {
        public string Name { get; set; }
    }
}
