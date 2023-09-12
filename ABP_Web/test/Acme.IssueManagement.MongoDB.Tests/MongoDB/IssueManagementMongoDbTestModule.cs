using System;
using Volo.Abp.Data;
using Volo.Abp.Modularity;
using Volo.Abp.Uow;

namespace Acme.IssueManagement.MongoDB;

[DependsOn(
    typeof(IssueManagementTestBaseModule),
    typeof(IssueManagementMongoDbModule)
    )]
public class IssueManagementMongoDbTestModule : AbpModule
{
    public override void ConfigureServices(ServiceConfigurationContext context)
    {
        Configure<AbpDbConnectionOptions>(options =>
        {
            options.ConnectionStrings.Default = MongoDbFixture.GetRandomConnectionString();
        });
    }
}
