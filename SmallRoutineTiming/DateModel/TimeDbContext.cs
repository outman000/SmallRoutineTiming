using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;


namespace SmallRoutineTiming.DateModel
{
    public  class TimeDbContext : DbContext
    {

        public TimeDbContext()
        {
        }



        public TimeDbContext(DbContextOptions<TimeDbContext> options)
            : base(options)
        {
          
        }


        public DbSet<UserInfo> UserInfo { get; set; }
        public DbSet<whiteList> whiteList { get; set; }
    }
}
