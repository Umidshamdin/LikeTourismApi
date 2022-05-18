using Microsoft.AspNetCore.Mvc;
using ServiceLayer.DTOs.FamousCity;
using ServiceLayer.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Api.Controllers
{
    
    public class FamousCityController : ControllerBase
    {
        private readonly IFamousCityService _service;
        public FamousCityController(IFamousCityService service)
        {
            _service = service;
        }
        

        [HttpGet]
        [Route("GetAll")]

        public async Task<IActionResult> GetAll()
        {
            return Ok(await _service.GetAllAsync());
        }


        [HttpPost]
        [Route("Create")]
        public async Task<IActionResult> Create([FromBody] FamousCityCreateDto famousCity)
        {
            await _service.InsertAsync(famousCity);
            return Ok();
        }
    }
}
