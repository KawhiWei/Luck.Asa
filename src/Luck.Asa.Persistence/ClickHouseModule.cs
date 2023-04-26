using Luck.Dapper.ClickHouse;
using Microsoft.Extensions.DependencyInjection;

namespace Luck.Asa.Persistence;

public class ClickHouseModule : ClickHouseBaseModule
{
    protected override void AddConnectionString(IServiceCollection service)
    {
        service.AddClickHouseDbConnectionString(x =>
        {
            x.IsCluster = false;
            x.ConnectionOptionList = new List<ConnectionStringOptions>()
            {
                new ConnectionStringOptions
                {
                    Host = "192.168.31.20",
                    Port = 9000,
                    User = "kawhi",
                    Password = "wzw0126..",
                    Database = "luck_asa",
                }
            };
        });
    }

    protected override void AddDbDriven(IServiceCollection service)
    {
        service.AddClickHouseDapperDriven();
    }
}