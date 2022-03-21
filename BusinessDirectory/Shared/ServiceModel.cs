using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessDirectory.ViewModels
{
    public class ServiceModel
    {
        public Int32 ServiceID { get; set; }
        public string ServicesType { get; set; } = string.Empty;
        public string ServiceName { get; set; } = string.Empty;
        public Int32 AddressID { get; set; }

        public Int32 CategoryID { get; set; }

        public Int32 SubCategoryId { get; set; }

        public Int32 UserID { get; set; }

        //public Int32 ReviewID { get; set; }


        public Int32 BsnServiceDetailsID { get; set; }

        public bool Verified { get; set; }

        public int VerifiedById { get; set; }
        public int TimesofAvail { get; set; }
    }
}
