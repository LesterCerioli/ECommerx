

namespace ECommerx.Modules.Cms.Data
{
     public class ContactCustomModelBuilder : ICustomModelBuilder
     {
          public void Build(ModelBuilder modelBuilder)
          {
              modelBuilder.Entity<AppSetting>().HasData(
                new AppSetting("GoogleAppKey") { Module = "Contact", IsVisibleInCommonSettingPage = false, Value = "" }
            );
          }
     }

}