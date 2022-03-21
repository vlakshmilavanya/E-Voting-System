using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessDirectory.DB.Models
{
    [Table("tblVotes")]
    public class Vote
    {
        [Key]
        public Int32 VoteId { get; set; }

        public int Id { get; set; }
        [ForeignKey("tblUsers")]
        public int UserId { get; set; } = 0;
        public User? User { get; set; }
        public bool IsActive { get; set; } = false;
    }
}
