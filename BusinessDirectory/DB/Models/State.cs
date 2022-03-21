using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessDirectory.DB.Models
{
    [Table("tblStates")]
    public class State
    {
        [Key]
        public Int32 StateId { get; set; }
        public string StateName { get; set; } = "";
        public DateTime StateTimestamp { get; set; }
    }
}
