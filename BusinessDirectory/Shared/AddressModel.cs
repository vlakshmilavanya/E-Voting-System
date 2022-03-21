using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessDirectory.ViewModels
{
    public class AddressModel
    {
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
