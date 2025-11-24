using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FoodMgmt.Domain.Entity
{
    public class Brand : BaseAuditEntity
    {
        public int BrandId { get; set; }
        public string BrandName { get; set; } = null;
        public string DisplayName { get; set; } = null;
        public string Description { get; set; }
    }
}
