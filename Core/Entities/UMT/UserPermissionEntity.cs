using System;
using System.Collections.Generic;
using System.Text;

namespace Core.Entities.Users
{
    public class UserPermissionEntity: BaseEntity
    {
        public int UserId { get; set; }
        public int ObjectId { get; set; }
        public int ObjectType { get; set; }
        public bool IsActive { get; set; }
        public int CreatedBy { get; set; }
        public DateTime CreatedDate { get; set; }
    }
}
