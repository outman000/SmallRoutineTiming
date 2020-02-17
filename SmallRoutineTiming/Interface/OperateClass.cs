using AutoMapper;
using SmallRoutineTiming.DateModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SmallRoutineTiming.Interface
{
    /// <summary>
    /// 这里最好通过接口来写，这里我写的太着急了就直接用类了
    /// </summary>
    public class OperateClass
    {
       public   void MysqltoSqlServer(List<gwh_qyrkxx> gwh_s, List<whiteList> whiteLists, TimeDbContext timeDbContext)
        {

            for (int i = 0; i < gwh_s.Count; i++)
            {
                if (whiteLists.Exists(a => a.IDnumber == gwh_s[i].shenfenzhenghao.Trim()))
                {
                    continue;

                }
                else
                {
                    whiteList whiteList = new whiteList();

            

                    whiteList.PeopleName = gwh_s[i].xingming;
                    whiteList.backJinInformation = gwh_s[i].fanjinjiaotongfangshi;
                    whiteList.BackJinLDate = gwh_s[i].dijinshijian;
                    whiteList.CompanyName = gwh_s[i].danweimingcheng;
                    whiteList.ContactMethod = gwh_s[i].shoujihao;
                    whiteList.Griddepartment = gwh_s[i].suoshuwanggebumen;
                    whiteList.GriddepartmentNum = gwh_s[i].suoshuwanggebianhao;
                    whiteList.IDnumber = gwh_s[i].shenfenzhenghao;
                    whiteList.IsHot = gwh_s[i].shenti;
                    whiteList.IsHubeiOrigin = gwh_s[i].shifouhubei;

                    whiteList.IsInZone = gwh_s[i].kaifaqu;
                    whiteList.isIsolation = gwh_s[i].shifougeli;
                    whiteList.IsPassHubei = gwh_s[i].xingming;
                    whiteList.NowAddress = gwh_s[i].xianzhuzhi;
                    whiteList.RemarkSituation = gwh_s[i].beizhu;
           
             


                    timeDbContext.whiteList.Add(whiteList);
                }
            }
            timeDbContext.SaveChanges();


        }


        /// <summary>
        /// 生成用户名和密码
        /// </summary>
        /// <param name="whiteLists"></param>
        /// <param name="UserLists"></param>
        /// <param name="timecontext"></param>

        public void outputValide(List<whiteList> whiteLists, List<UserInfo> UserLists, TimeDbContext timecontext)
        {
            //如果再同步的过程中如果存在被同步的表需要取数据到第三个表的时候一定要建一个临时表暂存一下
            //因为savechange前是取不到数据库的
            //而且尽量将数据整理完之后用一个savechange导入，要不太慢了
            List<UserInfo> userInfostemp = new List<UserInfo>();//临时验证
            for (int i = 0; i < whiteLists.Count; i++)
            {
                var temp = UserLists.Exists(a => a.userid == whiteLists[i].GriddepartmentNum);
             

                var tempcompany = UserLists.Exists(a => a.userid == whiteLists[i].CompanyName);
                if (!temp)
                {
                    var tempinfo = userInfostemp.Exists(a => a.userid == whiteLists[i].GriddepartmentNum);

                    if (!tempinfo)
                    {
                        UserInfo userInfo = new UserInfo();
                        userInfo.username = "";
                        userInfo.userid = whiteLists[i].GriddepartmentNum;
                        userInfo.password = DateTime.Now.Year.ToString() + DateTime.Now.Month.ToString() + whiteLists[i].GriddepartmentNum;
                        userInfostemp.Add(userInfo);
                        timecontext.UserInfo.Add(userInfo);
                    }
                  
                }
                if (!tempcompany)
                {
                    var tempinfo = userInfostemp.Exists(a => a.userid == whiteLists[i].CompanyName);
                    if (!tempinfo)
                    {
                        UserInfo userInfo = new UserInfo();
                        userInfo.username = "";
                        userInfo.userid = whiteLists[i].CompanyName;
                        userInfo.password = DateTime.Now.Year.ToString() + DateTime.Now.Month.ToString() + whiteLists[i].id;
                        userInfostemp.Add(userInfo);
                        timecontext.UserInfo.Add(userInfo);
                    }
                      
                  
                }
             
            }
            timecontext.SaveChanges();
        }
    }
}
