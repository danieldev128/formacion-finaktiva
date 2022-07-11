using App.Common.DTO;
using App.Infrastructure.Database.Entities;
using AutoMapper;



namespace App.Config.Dependecias
{
    public class AutoMapperProfile: Profile
    {
        public AutoMapperProfile()
        {
            CreateMap<LogsGeneral, LogsGeneralDTO>().ReverseMap();

        }
    }
}
