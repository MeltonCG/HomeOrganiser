using AutoMapper;
using HomeOrganiser.Core.Entities;

namespace HomeOrganiser.Mappers
{
    public class UtilityProfile: Profile
    {
        public UtilityProfile()
        {
            CreateMap<UtilityProfile, Utility>();
            CreateMap<Utility, UtilityProfile>();
        }
    }
}
