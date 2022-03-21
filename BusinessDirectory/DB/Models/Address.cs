using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessDirectory.DB.Models
{
    [Table("tblAddress")]
    public class Address
    {
        [Key]
        public Int32 AddressID { get; set; } = 0;
        public string Building { get; set; } = "";
        public string Street { get; set; } = "";
        public string Landmark { get; set; } = "";
        public string Area { get; set; } = "";
        public string City { get; set; } = "";
        public Int64 Pincode { get; set; } = 0;
        [ForeignKey("tblState")]
        public Int32 StateId { get; set; } = 0;
        public State? State { get; set; } 
        [ForeignKey("tblCountry")]
        public Int32 CountryId { get; set; } = 0;
        public Country? Country { get; set; } 
        public DateTime AddressTimestamp { get; set; } 
        public DateTime UpdateDate { get; set; }
    }
}
