using HomeOrganiser.Core.Entities;
using HomeOrganiser.Core.Enums;
using HomeOrganiser.Core.Interfaces;

namespace HomeOrganiser.Core.Services
{
    public class UtilityService : IUtilityService
    {
        public UtilityService()
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
