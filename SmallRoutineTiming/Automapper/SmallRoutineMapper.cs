using AutoMapper;
using SmallRoutineTiming.DateModel;
using System;
using System.Collections.Generic;
using System.Text;

namespace SmallRoutineTiming.Automapper
{
    public  class SmallRoutineMapper : Profile
    {
        public SmallRoutineMapper()
        {
            CreateMap<List<whiteList>, List<Company> >();
            CreateMap<List<whiteList>, List<whiteList> >();

            CreateMap<gwh_qyrkxx, whiteList>().ForMember(dest => dest.PeopleName,
                opts => opts.MapFrom(src => src.xingming))
                .ForMember(dest => dest.backJinInformation,
                opts => opts.MapFrom(src => src.fanjinjiaotongfangshi))
                .ForMember(dest => dest.BackJinLDate,
                opts => opts.MapFrom(src => src.dijinshijian))
                .ForMember(dest => dest.CompanyName,
                opts => opts.MapFrom(src => src.danweimingcheng))
                .ForMember(dest => dest.ContactMethod,
                opts => opts.MapFrom(src => src.TBRlianxifangshi))
                //.ForMember(dest => dest.DetailSituation,
                //opts => opts.MapFrom(src => src.xingming))
                //.ForMember(dest => dest.Duties,
                //opts => opts.MapFrom(src => src.xingming))
                //.ForMember(dest => dest.Gender,
                //opts => opts.MapFrom(src => src.xingming))
                .ForMember(dest => dest.Griddepartment,
                opts => opts.MapFrom(src => src.suoshuwanggebumen))
                .ForMember(dest => dest.GriddepartmentNum,
                opts => opts.MapFrom(src => src.suoshuwanggebianhao))
                //.ForMember(dest => dest.HuBeiLicence,
                //opts => opts.MapFrom(src => src.xingming))
                .ForMember(dest => dest.IDnumber,
                opts => opts.MapFrom(src => src.shenfenzhenghao))
                //.ForMember(dest => dest.IndustrySector,
                //opts => opts.MapFrom(src => src.xingming))
                .ForMember(dest => dest.IsHot,
                opts => opts.MapFrom(src => src.shenti))
                .ForMember(dest => dest.IsHubeiOrigin,
                opts => opts.MapFrom(src => src.shifouhubei))
                .ForMember(dest => dest.IsInZone,
                opts => opts.MapFrom(src => src.kaifaqu))
                .ForMember(dest => dest.isIsolation,
                opts => opts.MapFrom(src => src.shifougeli))
                 //.ForMember(dest => dest.IsPassHubei,
                 //opts => opts.MapFrom(src => src.xingming))
                 .ForMember(dest => dest.IsPassHubei,
                opts => opts.MapFrom(src => src.xingming))
                 // .ForMember(dest => dest.LeaveJinDate,
                 //opts => opts.MapFrom(src => src.xingming))
                 // .ForMember(dest => dest.National,
                 //opts => opts.MapFrom(src => src.xingming))
                 .ForMember(dest => dest.NowAddress,
                opts => opts.MapFrom(src => src.xianzhuzhi))
                 .ForMember(dest => dest.RemarkSituation,
                opts => opts.MapFrom(src => src.beizhu));
                // .ForMember(dest => dest.ResponsibleDepartment,
                //opts => opts.MapFrom(src => src.xingming));
  
        }
    }
}
