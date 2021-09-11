using AbastFacto.App.Shared;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AbastFacto.App.Services
{
    public interface IFactorDataService
    {
        Task<IEnumerable<CharacterizationFactor>> GetAllFactors();
        Task<CharacterizationFactor> GetFactorDetails(int factorId);
        Task<CharacterizationFactor> AddFactor(CharacterizationFactor factor);
        Task UpdateFactor(CharacterizationFactor factor);
        Task DeleteFactor(int factorId);
    }
}
