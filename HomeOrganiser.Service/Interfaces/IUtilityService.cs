using HomeOrganiser.Core.Entities;
using HomeOrganiser.Core.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeOrganiser.Service.Interfaces
{
    public interface IUtilityService
    {

        Task<Utility> GetSingleUtilityById(Guid id);

        Task<List<Utility>> GetAllUtilities();

        Task<List<Utility>> GetAllUtilitiesByType(EUtilityType utilityType);

    }
}
