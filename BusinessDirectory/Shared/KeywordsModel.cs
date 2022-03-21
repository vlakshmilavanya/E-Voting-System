using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessDirectory.ViewModels
{
    public  class KeywordsModel
    {
        public Int32 CategoryId { get; set; }
        public string CategoryName { get; set; } = string.Empty;
        public Int32 SubCategoruId { get; set; }
        public string SubCategoryName { get; set; } = string.Empty;
    }
}
