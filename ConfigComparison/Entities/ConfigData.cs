namespace ConfigComparison.Entities
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class ConfigData : DbContext
    {
        public ConfigData()
            : base("name=ConfigData")
        {
        }

        public virtual DbSet<Standard826_827> Standard826_827 { get; set; }

        public virtual DbSet<SiteConfigs> SiteConfigs { get; set; }

        public virtual DbSet<SiteInstanceConfigs> SiteInstanceConfigs { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
        }
    }
}
