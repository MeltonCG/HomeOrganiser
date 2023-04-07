using AutoMapper;
using HomeOrganiser.Core.Entities;
using HomeOrganiser.Models;

namespace HomeOrganiser.Mappers
{
    public class UtilityProfile: Profile
    {
        public UtilityProfile()
        {
            CreateMap<UtilityModel, Utility>();
            CreateMap<Utility, UtilityModel>();
        }
    }
}
