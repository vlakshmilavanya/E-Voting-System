using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessDirectory.DB.Models
{
    [Table("tblUsers")]
    public class User
    {
        [Key]
        public Int32 UserId { get; set; }
        public string FirstName { get; set; } = "";
        public string LastName { get; set; } = "";
        public string EmailAddress { get; set; } = "";
        public Int64 MobileNumber { get; set; } = 0;
        [ForeignKey("tblAddresses")]
        public int AddressID { get; set; } = 0;
        public Address? Address { get; set; } 
        public bool IsActive { get; set; }
        public DateTime UserTimestamp { get; set; }
        public DateTime UpdateTimestamp { get; set; }
        public int UpdatedBy { get; set; }
        public bool IsVoter { get; set; } = false;
        public bool IsCandidate { get; set; } = false;
        public int numberOfVotes { get; set; } = 0;
    }
}
