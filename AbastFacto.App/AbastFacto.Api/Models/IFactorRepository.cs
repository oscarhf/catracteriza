using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AbastFacto.App.Shared;

namespace AbastFacto.App.Api.Models
{
    public interface IFactorRepository
    {
        IEnumerable<CharacterizationFactor> GetAllFactors();
        CharacterizationFactor GetFactorById(int factorId);
        CharacterizationFactor AddFactor(CharacterizationFactor factor);
        CharacterizationFactor UpdateFactor(CharacterizationFactor factor);
        void DeleteFactor(int factorId);
    }
}