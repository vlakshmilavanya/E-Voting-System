using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessDirectory.DB.Models
{
    [Table("tblShareYourViews")]
    public class ShareYourViews
    {
        [Key]
        public Int32 ShareYourViewsId { get; set; }
        [ForeignKey("tblUsers")]
        public Int32 UserId { get; set; }

        public User? User { get; set; } 
        public string View { get; set; } = "";
        public DateTime ViewsTimestamp { get; set; }
    }
}
