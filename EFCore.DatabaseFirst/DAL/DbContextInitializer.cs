﻿using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;

namespace EFCore.DatabaseFirst.DAL
{
    public class DbContextInitializer
    {
        public static IConfigurationRoot Configuration;

        public static DbContextOptionsBuilder<AppDbContext> OptionsBuilder; 
       
        public static void Build()
        {
            var builder = new ConfigurationBuilder().SetBasePath(Directory.GetCurrentDirectory()).AddJsonFile("appsettings.json", optional: true, reloadOnChange: true);
            Configuration = builder.Build();

            // 2. yol: 
            //OptionsBuilder = new DbContextOptionsBuilder<AppDbContext>(); 
            //OptionsBuilder.UseSqlServer(Configuration.GetConnectionString("SqlCon")!); 
        }

    }
}
