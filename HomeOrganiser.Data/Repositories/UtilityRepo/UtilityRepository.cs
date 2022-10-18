using HomeOrganiser.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
