using HomeOrganiser.Core.Entities;
using HomeOrganiser.Core.Interfaces.Repositories;

namespace HomeOrganiser.Data.Repositories.UtilityRepo
{
    public class UtilityRepository : RepositoryBase, IUtilityRepository
    {
        private readonly ApplicationDbContext _context;

        public UtilityRepository(ApplicationDbContext context)
            : base(context)
        {
            _context = context;
        }

        public async Task<IReadOnlyList<Utility>> GetAllUtilities()
        {
            return await ListAll<Utility>();
        }
    }
}
