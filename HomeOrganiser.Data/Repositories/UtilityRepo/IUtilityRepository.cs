using HomeOrganiser.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeOrganiser.Data.Repositories.UtilityRepo
{
    public interface IUtilityRepository
    {
        Task<IReadOnlyList<Utility>> GetAllUtilities();
    }
}
