using System.Collections.Generic;
using System.Linq;
using AbastFacto.App.Shared;

namespace AbastFacto.App.Api.Models
{
    public class FactorRepository : IFactorRepository
    {

        private readonly AppDbContext _appDbContext;
        
        
        public FactorRepository(AppDbContext appDbContext)
        {
            _appDbContext = appDbContext;
        }

        CharacterizationFactor IFactorRepository.AddFactor(CharacterizationFactor factor)
        {
            var addedEntity = _appDbContext.Factors.Add(factor);
            _appDbContext.SaveChanges();
            return addedEntity.Entity;
        }

        void IFactorRepository.DeleteFactor(int factorId)
        {
            var foundFactor = _appDbContext.Factors.FirstOrDefault(e => e.FactorId == factorId);
            if (foundFactor == null) return;

            _appDbContext.Factors.Remove(foundFactor);
            _appDbContext.SaveChanges();
        }

        IEnumerable<CharacterizationFactor> IFactorRepository.GetAllFactors()
        {
            return _appDbContext.Factors;
        }

        CharacterizationFactor IFactorRepository.GetFactorById(int factorId)
        {
             return _appDbContext.Factors.FirstOrDefault(c => c.FactorId == factorId);
        }

        CharacterizationFactor IFactorRepository.UpdateFactor(CharacterizationFactor factor)
        {
            var foundFactor = _appDbContext.Factors.FirstOrDefault(e => e.FactorId == factor.FactorId);

            if (foundFactor != null)
            {
                foundFactor.ShortName=factor.ShortName;
                foundFactor.LongName= factor.LongName;
                foundFactor.Metric=factor.Metric;
                foundFactor.InputData=factor.InputData;
                foundFactor.InfoType=factor.InfoType;
                foundFactor.Source=factor.Source;
                foundFactor.Notes=factor.Notes;
                foundFactor.FactorType=factor.FactorType;

                _appDbContext.SaveChanges();
                return foundFactor;
            }

            return null;
        }
    }

}