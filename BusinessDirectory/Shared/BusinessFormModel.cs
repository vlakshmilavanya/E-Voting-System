using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessDirectory.ViewModels
{
    public class BusinessFormModel
    {
        public Int32 BsnServiceDetailsID { get; set; }
        [Required]
        public string LegalBusinessName { get; set; } = string.Empty;

        public int TollFreeNo { get; set; }
        public int FaxNo { get; set; }
        public string Website { get; set; } = string.Empty;
        [Required]
        public string CoverImage { get; set; } = string.Empty;
        public string Twitter { get; set; } = string.Empty;
        public string Instagram { get; set; } = string.Empty;
        [Required]
        public string Description { get; set; } = string.Empty;
        public int preListingID { get; set; }
        public int userID { get; set; }

        public Int32 AddressID { get; set; }
        [Required]
        public string Building { get; set; } = string.Empty;
        [Required]
        public string Street { get; set; } = string.Empty;
        [Required]
        public string Landmark { get; set; } = string.Empty;
        [Required]
        public string Area { get; set; } = string.Empty;
        [Required]
        public string City { get; set; } = string.Empty;
        [Required]
        public Int64 Pincode { get; set; }
        public Int32 StateId { get; set; }
        [Required]
        public string StateName { get; set; } = string.Empty;
    }
}
