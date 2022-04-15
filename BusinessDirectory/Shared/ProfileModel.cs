using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessDirectory.ViewModels
{
    public class ProfileModel
    {
        public Int32 UserId { get; set; }
        public string FirstName { get; set; } = string.Empty;
        public string LastName { get; set; } = string.Empty;
        public string EmailAddress { get; set; } = string.Empty;
        public Int64 MobileNumber { get; set; }
        public Int32 AadharId { get; set; }
        public Int32 AddressID { get; set; }
        public string Building { get; set; } = "";
        public string Street { get; set; } = "";
        public string Landmark { get; set; } = "";
        public string Area { get; set; } = "";
        public string City { get; set; } = "";
        public Int64 Pincode { get; set; } = 0;
        public Int32 StateId { get; set; }
        public string StateName { get; set; } = "";
        public Int32 CountryId { get; set; }
        public string CountryName { get; set; } = "";
        
        public bool IsVoter { get; set; } = false;
        public bool IsCandidate { get; set; } = false;

        public int numberOfVotes { get; set; } = 0;

    }
}
