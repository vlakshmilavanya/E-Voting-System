using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;

namespace OnlineVotingSystem.Areas.Identity.Data;

// Add profile data for application users by adding properties to the OnlineVotingSystemUser class
public class OnlineVotingSystemUser : IdentityUser
{
    public string Name { get; set; }

    public Int64 Mobile { get; set; }
    public DateTime DateOfBirth { get; set; }
    public string State { get; set; }
    public string City { get; set; }
    public string Address { get; set; }
    public bool IsVoter { get; set; }
    public string ProfileImage { get; set; }


}

