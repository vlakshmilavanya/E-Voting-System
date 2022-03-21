using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessDirectory.DB.Models
{
    [Table("tblRoleTypes")]
    public class RoleType
    {
        [Key]
        public Int32 RoleTypeId { get; set; }
        public string RoleTitle { get; set; } = "";
        public bool IsActive { get; set; }
    }
}
