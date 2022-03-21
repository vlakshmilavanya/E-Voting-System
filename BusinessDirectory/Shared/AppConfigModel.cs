using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessDirectory.ViewModels
{
    public class AppConfigModel
    {
        public Int32 configId { get; set; }
        public string configName { get; set; } = "";
        public string description { get; set; } = "";
        public string configValue { get; set; } = "";
        public Int32 createdById;
        public Int32 updatedById;
    }
}
