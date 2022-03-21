using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessDirectory.DB.Models
{
    [Table("tblRoles")]
    public class Roles
    {
        [Key]
        public Int32 RoleID { get; set; }
        [ForeignKey("tblUsers")]
        public Int32 UserID { get; set; }
        public User? User { get; set; }
        [ForeignKey("tblRoleTypes")]
        public Int32 RoleTypeID { get; set; }
        public RoleType? RoleType { get; set; }
        public bool IsActive { get; set; }
        [ForeignKey("tblUsers")]
        public Int32 CreatedBy { get; set; }
        public DateTime RolesTimestamp { get; set; }
        public DateTime UpdateDate { get; set; }
    }
}
