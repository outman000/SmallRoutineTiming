using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace SmallRoutineTiming.DateModel
{
    public class MysqlContext : DbContext
    {
        public MysqlContext()
        {
        }



        public MysqlContext(DbContextOptions<MysqlContext> options)
            : base(options)
        {

        }
        public DbQuery<gwh_qyrkxx> gwh_qyrkxx { get; set; }


    }
}
