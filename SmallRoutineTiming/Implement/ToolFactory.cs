using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using SmallRoutineTiming.DateModel;
using SmallRoutineTiming.Interface;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace SmallRoutineTiming.Implement
{
    public  class ToolFactory :IToolFactory
    {
        public TimeDbContext getDbContext() {

            var optionsBuilder = new DbContextOptionsBuilder<TimeDbContext>();
          
           var   configuration = new ConfigurationBuilder().SetBasePath(Directory.GetCurrentDirectory()).AddJsonFile("appsettings.json").Build();

            optionsBuilder.UseSqlServer(configuration.GetConnectionString("SqlServerConnection"));


            return new TimeDbContext(optionsBuilder.Options);
        }

        public MysqlContext getMysqlDbContext()
        {
            var optionsBuilder = new DbContextOptionsBuilder<MysqlContext>();

            var configuration = new ConfigurationBuilder().SetBasePath(Directory.GetCurrentDirectory()).AddJsonFile("appsettings.json").Build();

            optionsBuilder.UseMySQL(configuration.GetConnectionString("MysqlConnection"));


            return new MysqlContext(optionsBuilder.Options);
        }
    }
}
