using ConfigComparison.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConfigComparison
{
    public class DataHelper
    {
        public static List<SiteInstanceView> GetSiteInstanceConfigs(string siteFolder)
        {
            List<SiteInstanceView> list = new List<SiteInstanceView>();

            using (var context = new Entities.ConfigData())
            {
                var configs = context.SiteInstanceConfigs.Where(s=>s.SiteFolder == siteFolder);

                foreach(var config in configs)
                {
                    SiteInstanceView view = new SiteInstanceView();
                    view.Role = Constants.CM_ROLE;
                    view.SiteFolder = config.SiteFolder;
                    view.ConfigFileFullName = config.ConfigFileFullName;
                    view.ConfigID = config.ConfigID;

                    list.Add(view);
                }
            }

            return list ;
        }
    }
}
