using AutoMapper;
using SmallRoutineTiming.DateModel;
using SmallRoutineTiming.Interface;
using System;
using System.Collections.Generic;
using System.Text;

namespace SmallRoutineTiming.Implement
{
    public class ResporityWhiteList : IResporityWhiteList
    {
        public void aaaa(List<whiteList> whiteLists)
        {
            var CompanyList = Mapper.Map<List<whiteList>, List<GirdInfo>>(whiteLists);
            var GirdList = Mapper.Map<List<whiteList>, List<GirdInfo>>(whiteLists);
        }



    }
}
