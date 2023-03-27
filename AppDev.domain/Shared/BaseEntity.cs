using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppDev.Domain.Shared
{
    public abstract class BaseEntity
    {
        public DateTime createdTime { get; set; }
        public DateTime updatedTime { get; set; }
        public DateTime deletedTime { get; set; }
        public int CreatedBy { get; set; }
        public int UpdatedBy { get; set;}
        public int DeletedBy { get; set;}
        public int isDeleted { get; set; }
    }
}
