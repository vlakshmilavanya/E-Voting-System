using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessDirectory.DB.Models
{
    [Table("tblCountries")]
    public class Country
    {
        [Key]
        public Int32 CountryId { get; set; }
        public string CountryName { get; set; } = "";
        public DateTime COuntryTimeStamp { get; set; }
    }
}
