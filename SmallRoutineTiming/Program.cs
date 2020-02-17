using AutoMapper;
using SmallRoutineTiming.Automapper;
using SmallRoutineTiming.DateModel;
using SmallRoutineTiming.Implement;
using SmallRoutineTiming.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
namespace SmallRoutineTiming
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                OperateClass operateClass = new OperateClass();
                SmallRoutineMapper smallRoutineMapper = new SmallRoutineMapper();
            
                var context = new ToolFactory();
                var timecontext = context.getDbContext();
                var mysqlcontext = context.getMysqlDbContext();
                var gwh_qyrkxxList = mysqlcontext.gwh_qyrkxx.ToList();
                var whiteLists = timecontext.whiteList.ToList();
                var UserLists = timecontext.UserInfo.ToList();

            
                    operateClass.MysqltoSqlServer(gwh_qyrkxxList, whiteLists, timecontext);
                
         
                    var whiteListsSecond = timecontext.whiteList.ToList();
                    operateClass.outputValide(whiteListsSecond, UserLists, timecontext);
              

              

            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
          

           
            Console.WriteLine("执行成功");

            Console.ReadLine();
        }




    }
}
