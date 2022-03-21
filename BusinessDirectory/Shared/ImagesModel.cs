using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessDirectory.ViewModels
{
    public class ImagesModel
    {
        public int ID { get; set; }
        public int BusinessID { get; set; }

        [Required]
        public string Img1 { get; set; } = string.Empty;
    }
}
