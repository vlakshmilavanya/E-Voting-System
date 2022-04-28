using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BusinessDirectory.DB.Models
{
    [Table("tblAadhar")]
    public class AadharAuth
    {
        [Key]
        public Int32 AadharId { get; set; }
        public string AadharNumber { get; set; } = "";
        public string VoterId { get; set; } = "";
        public Int32 Age { get; set; } = 0;
        public bool IsActive { get; set; } = false;
        public string MobileNumber { get; set; } = "";
        public string Email { get; set; } = "";

       
    }
}
