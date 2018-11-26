using DocumentFormat.OpenXml.Wordprocessing;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConfigComparison.Entities
{
    public partial class SiteInstanceConfigs
    {
        [Key]
        public int ConfigID { get; set; }
        public string ConfigFileFullName { get; set; }
        public string SiteFolder { get; set; }
        public string Role { get; set; }
        
    }
}
