using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace BusinessDirectory.ViewModels
{
    public class ShareViewsModel
    {
        public Int32 ShareYourViewsId { get; set; }
        [Required]
        public string View { get; set; } = string.Empty;

        public Int32 UserId { get; set; }
    }
}
