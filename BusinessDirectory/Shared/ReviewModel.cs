using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessDirectory.ViewModels
{
    public class ReviewModel
    {
        public int Rating { get; set; }
        public string ReviewText { get; set; } = string.Empty;
        public int ServiceId { get; set; }
        public int UserId { get; set; }
    }
}
