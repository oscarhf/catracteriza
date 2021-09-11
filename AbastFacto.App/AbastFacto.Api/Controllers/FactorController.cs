using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using AbastFacto.App.Shared;
using AbastFacto.App.Api.Models;

namespace AbastFacto.Api.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class FactorController : ControllerBase
    {
        private readonly IFactorRepository _factorRepository;
        public FactorController(IFactorRepository factorRepository)
        {
            _factorRepository = factorRepository;
        }
        [HttpGet]
        public IActionResult GetAllFactors()
        {
            return Ok(_factorRepository.GetAllFactors());
        }
        [HttpGet("{id}")]
        public IActionResult GetFactorById(int id)
        {
            return Ok(_factorRepository.GetFactorById(id));
        }

        [HttpPost]
        public IActionResult CreateFactor([FromBody] CharacterizationFactor factor)
        {
            if (factor == null)
                return BadRequest();

            if (factor.ShortName == string.Empty )
            {
                ModelState.AddModelError("Factor Short Name", "The name of the factor shouldn't be empty");
            }

            if (!ModelState.IsValid)
                return BadRequest(ModelState);

            var createdFactor = _factorRepository.AddFactor(factor);

            return Created("factor", createdFactor);
        }

        [HttpPut]
        public IActionResult UpdateFactor([FromBody] CharacterizationFactor factor)
        {
            if (factor == null)
                return BadRequest();

            if (factor.ShortName == string.Empty)
            {
                ModelState.AddModelError("Factor Short Name", "The name of the factor shouldn't be empty");
            }

            if (!ModelState.IsValid)
                return BadRequest(ModelState);

            var factorToUpdate = _factorRepository.GetFactorById(factor.FactorId);

            if (factorToUpdate == null)
                return NotFound();

            _factorRepository.UpdateFactor(factor);

            return NoContent(); //success
        }

         [HttpDelete("{id}")]
        public IActionResult DeleteFactor(int id)
        {
            if (id == 0)
                return BadRequest();

            var factorToDelete = _factorRepository.GetFactorById(id);
            if (factorToDelete == null)
                return NotFound();

            _factorRepository.DeleteFactor(id);
            return NoContent();//success
        }


    }

}
