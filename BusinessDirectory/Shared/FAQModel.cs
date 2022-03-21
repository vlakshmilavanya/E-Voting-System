using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace BusinessDirectory.ViewModels
{
    public class FAQModel
    {
        public Int32 FaqID { get; set; }

        [Required]
        public string Question { get; set; } = string.Empty;
        [Required]
        public string Answer { get; set; } = string.Empty;
        public int BusinessId { get; set; }
    }
}
