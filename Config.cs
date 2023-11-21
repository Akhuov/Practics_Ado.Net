using System.Configuration;

namespace Practics__001_Ado.Net;

public class Config
{
    public void SafeToConfigConnectionString()
    {
        try
        {
            var setting = new ConnectionStringSettings
            {
                Name = "ConString",
                ConnectionString =
                    @"Server = WIN-F7NIMF7A3VO;
                        Database = BootCamp_N7;
                        Trusted_Connection = True;
                        TrustServerCertificate = true;
                        Pooling = True"
            };
            Configuration configuration;
            configuration = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);
            configuration.ConnectionStrings.ConnectionStrings.Add(setting);
            configuration.Save();
        }
        catch
        {
            Console.WriteLine("Error!!");
        }
    }
}

