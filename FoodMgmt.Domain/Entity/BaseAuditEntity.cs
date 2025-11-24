using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FoodMgmt.Domain.Entity
{
    public class BaseAuditEntity
    {
        public bool IsActive { get; set; }
        public long CreatedBy { get; set; }
       public long ModifiedBy { get; set; }
        public DateTime CreatedOn { get; set; }
        public DateTime ModifiedOn { get; set; }
    }
}
