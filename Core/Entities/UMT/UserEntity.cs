using System;
using System.Collections.Generic;

namespace Core.Entities.UMT
{
    public class UserEntity : BaseEntity
    {

        public int EmployeeId { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
        public DateTime? LastLoginDate { get; set; }
        public DateTime? LastPasswordChangedDate { get; set; }
        public DateTime? LastLockoutDate { get; set; }
        public int? Status { get; set; }
        public DateTime? CreateDate { get; set; }
        public bool? IsAdmin { get; set; }

    }
}
