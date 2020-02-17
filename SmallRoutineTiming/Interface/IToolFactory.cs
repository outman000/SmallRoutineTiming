using SmallRoutineTiming.DateModel;
using System;
using System.Collections.Generic;
using System.Text;

namespace SmallRoutineTiming.Interface
{
     public  interface IToolFactory 
    {
         TimeDbContext getDbContext();
         MysqlContext getMysqlDbContext();
    }
}
