using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessDirectory.ViewModels
{
    public class VoteModel
    {
        public Int32 VoteId { get; set; }
        public int Id { get; set; }
        public Int32 UserID { get; set; }
        public string FirstName { get; set; } = string.Empty;
        public bool IsActive { get; set; }
    }
}
