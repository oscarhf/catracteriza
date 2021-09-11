
using System.ComponentModel.DataAnnotations; 
using System.ComponentModel.DataAnnotations.Schema; 

using AbastFacto.App.Shared;

namespace AbastFacto.App.Shared
{
   public class CharacterizationFactor
    {
        [Key]
        public int FactorId {get;set;}
        [Required]
        public string ShortName {get;set;}
        [StringLength(50, ErrorMessage = "Long name is too long.")]
        public string LongName {get;set;}
        public string Metric {get;set;}
        public string InputData {get;set;}
        public string InfoType{get;set;}
        public string Source {get;set;}
         [StringLength(500, ErrorMessage = "Notes length can't exceed 500 characters.")]
        public string Notes {get;set;}
        public  FactorType FactorType {get;set;}

    }
}