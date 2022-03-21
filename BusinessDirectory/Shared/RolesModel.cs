using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessDirectory.ViewModels
{
    public class RolesModel
    {
        public Int32 RoleID { get; set; }
        public Int32 UserID { get; set; }
        public string FirstName { get; set; } = string.Empty;
        public Int32 RoleTypeID { get; set; }

        public string RoleTitle { get; set; } = string.Empty;
        public bool IsActive { get; set; }
        public Int32 CreatedBy { get; set; }
    }
}
