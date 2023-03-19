using HomeOrganiser.Core.Entities;

namespace HomeOrganiser.Core.Interfaces.Repositories
{
    public interface IUtilityRepository
    {
        Task<IReadOnlyList<Utility>> GetAllUtilities();
    }
}
