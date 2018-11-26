namespace ConfigComparison.Entities
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class SiteConfigs
    {
        public int ID { get; set; }


        [StringLength(255)]
        public string SiteFolder { get; set; }

        public string Role { get; set; }

        [StringLength(255)]
        public string ProductName { get; set; }

        [StringLength(255)]
        public string FilePath { get; set; }

        [StringLength(255)]
        public string ConfigFileName { get; set; }

        [StringLength(255)]
        public string Type { get; set; }

        [StringLength(255)]
        public string SearchProviderUsed { get; set; }

        [StringLength(255)]
        public string ContentDelivery { get; set; }

        [StringLength(255)]
        public string ContentManagement { get; set; }

        [StringLength(255)]
        public string Processing { get; set; }

        [StringLength(255)]
        public string CM_And_Processing { get; set; }

        [StringLength(255)]
        public string Reporting { get; set; }

        public bool DifferentWithSite { get; set; }

        public string FileInSite { get; set; }

        public bool IsVerified { get; set; }

        public bool HasMultipleFileInSite { get; set; }
    }
}
