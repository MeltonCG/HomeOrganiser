using HomeOrganiser.Core.Entities;
using HomeOrganiser.Core.Enums;

namespace HomeOrganiser.Core.Interfaces
{
    public interface IUtilityService
    {

        Task<Utility> GetSingleUtilityById(Guid id);

        Task<List<Utility>> GetAllUtilities();

        Task<List<Utility>> GetAllUtilitiesByType(EUtilityType utilityType);

    }
}
