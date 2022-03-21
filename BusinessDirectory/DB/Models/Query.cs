using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessDirectory.DB.Models
{
    [Table("tblQueries")]
    public class Query
    {
        public Int32 QueryId { get; set; }
        [ForeignKey("tblUsers")]
        public Int32 UserId { get; set; }
        public User? User { get; set; }
        public string QueryDescription { get; set; } = "";
        public DateTime QueryTimestamp { get; set; }
    }
}
