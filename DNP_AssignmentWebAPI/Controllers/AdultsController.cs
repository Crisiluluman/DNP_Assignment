using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using DNP_AssignmentWebAPI.Data;
using DNP_AssignmentWebAPI.Models;


namespace DNP_AssignmentWebAPI.Controllers
{
    [ApiController]
    [Route("[controller]")]
    
    public class AdultsController: Controller
    {
        private ICloudService iCloudService;
        
        public AdultsController(ICloudService iCloudService)
        {
            this.iCloudService = iCloudService;
        }
        
        // HTTP GET Method
        [HttpGet]
        public async Task<ActionResult<IList<Adult>>> GetAdults()
        {
            try
            {
                IList<Adult> adults = await iCloudService.getAdultsAsync();
                return Ok(adults);
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                return StatusCode(500, e.Message);
                //TODO Add more exception methods 404 etc
            }
        }

        [HttpPost]
        public async Task<ActionResult<Adult>> AddAdult([FromBody] Adult adult)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            try
            { 
                Adult added = await iCloudService.addAdultAsync(adult);
                return Created($"/{added.Id}",added);
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                return StatusCode(500, e.Message);
            }
        }
        
        [HttpDelete]
        [Route("{Id:int}")]
        public async Task<ActionResult> DeleteAdult([FromRoute] int Id) {
            try {
                await iCloudService.removeAdultAsync(Id);
                return Ok();
            } catch (Exception e) {
                Console.WriteLine(e);
                return StatusCode(500, e.Message);
            }
        }
        
/*
        [HttpPatch] // Works
        [Route("{Id:int}")]
        public async Task<ActionResult<Adult>> UpdateAdultFirstname([FromBody] Adult adult) {
            try
            {
                string firstName = adult.FirstName;
                int Id = adult.Id;

                Console.WriteLine(adult.FirstName + " THe first name");
                
                Adult updatedAdult = await iCloudService.updateFirstNameAsync(Id, firstName);
                return Ok(updatedAdult); 
            } catch (Exception e) {
                Console.WriteLine(e);
                return StatusCode(500, e.Message);
            }
        }*/
        
        [HttpPatch] // In testing
        [Route("{Id:int}")]
        public async Task<ActionResult<Adult>> UpdateAdult([FromBody] Adult adult) {
            try
            {
                int Id = adult.Id;
                string firstName = adult.FirstName;
                string lastName = adult.LastName;
                string hairColor = adult.HairColor;
                string eyeColor = adult.EyeColor;
                int age = adult.Age;
                float weight = adult.Weight;
                int height = adult.Height;
                string sex = adult.Sex;

                Console.WriteLine(adult.FirstName + " THe first name");
                
                Adult updatedAdult = await iCloudService.updateAdult(Id, firstName, lastName, hairColor, eyeColor, age, weight, height, sex);
                return Ok(updatedAdult); 
            } catch (Exception e) {
                Console.WriteLine(e);
                return StatusCode(500, e.Message);
            }
        }
        
        
    }
}