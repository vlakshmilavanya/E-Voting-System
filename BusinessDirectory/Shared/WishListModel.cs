using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessDirectory.ViewModels
{
    public class WishListModel
    {
        public Int32 WishListId { get; set; }
        public Int32 UserId { get; set; }
        public Int32 ServicesServiceID { get; set; }
    }
}
