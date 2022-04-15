using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessDirectory.ViewModels
{
    public class AadharModel
    {
        public Int32 AadharId { get; set; }
        public string AadharNumber { get; set; }
        public string VoterId { get;set; }
        public int Age { get; set; }
        public bool IsActive { get; set; }

    }
}
