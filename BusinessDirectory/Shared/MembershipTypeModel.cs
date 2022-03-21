using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessDirectory.ViewModels
{
    public class MembershipTypeModel
    {
        public int MembershipTypeID { get; set; }
        public string MembershipName { get; set; } = "";
        public double MembershipCost { get; set; }
    }
}
