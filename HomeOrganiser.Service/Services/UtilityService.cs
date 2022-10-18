using HomeOrganiser.Core.Entities;
using HomeOrganiser.Core.Enums;
using HomeOrganiser.Data.Repositories.UtilityRepo;
using HomeOrganiser.Service.Interfaces;

namespace HomeOrganiser.Service.Services
{
    public class UtilityService : IUtilityService
    {
        public UtilityService(IUtilityRepository utilityRepo)
        {

        }

        public async Task<List<Utility>> GetAllUtilities()
        {
            return new List<Utility>();
        }

        public async Task<List<Utility>> GetAllUtilitiesByType(EUtilityType utilityType)
        {
            throw new NotImplementedException();
        }

        public async Task<Utility> GetSingleUtilityById(Guid id)
        {
            throw new NotImplementedException();
        }
    }
}
