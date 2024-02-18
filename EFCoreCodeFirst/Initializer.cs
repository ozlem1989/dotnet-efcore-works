using Microsoft.Extensions.Configuration;

namespace EFCoreCodeFirst
{
    public class Initializer
    {
        public static IConfigurationRoot Configuration { get; set; }

        public static void Build()
        {
            var builder = new ConfigurationBuilder()
                          .SetBasePath(Directory.GetCurrentDirectory())
                          .AddJsonFile("appsettings.json", optional: true, reloadOnChange: true);

            Configuration =  builder.Build(); 
        }
    }
}
