using Dapper.Contrib.Extensions;
using System;

namespace App.Data.Entities
{
    public class BaseEntity
    {
        public BaseEntity()
        {
            CreatedOn = DateTime.Now;
            IsActive = false;
            RowGuid = Guid.NewGuid();
        }

        public int Id { get; set; }
        [ExplicitKey]
        public Guid RowGuid { get; set; }
        public DateTime CreatedOn { get; set; }
        public bool IsActive { get; set; }
    }
}
