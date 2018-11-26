using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConfigComparison.ViewModel
{
    public class SiteInstanceView
    {
        public int ConfigID { get; set; }
        public string ConfigFileFullName { get; set; }
        public string SiteFolder { get; set; }
        public string Role { get; set; }

    }
}
