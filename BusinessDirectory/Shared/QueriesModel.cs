using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace BusinessDirectory.ViewModels
{
    public class QueriesModel
    {
        public Int32 QueryId { get; set; }
        [Required]
        public string QueryDescription { get; set; } = string.Empty;
        public Int32 UserId { get; set; }
    }
}
