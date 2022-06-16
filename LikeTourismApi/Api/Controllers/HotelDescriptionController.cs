using Microsoft.AspNetCore.Mvc;
using ServiceLayer.DTOs.HotelDescription;
using ServiceLayer.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Api.Controllers
{

    [ApiController]
    [Route("api/[controller]")]
    public class HotelDescriptionController : ControllerBase
    {
        private readonly IHotelDescriptionService _service;
        public HotelDescriptionController(IHotelDescriptionService service)
        {
            _service = service;
        }
        [HttpGet]
        [Route("GetAll/{id}")]
        public async Task<IActionResult> GetAll([FromRoute] int id)
        {
            return Ok(await _service.GetAllAsync(id));
        }


        [HttpPost]
        [Route("Create")]
        public async Task<IActionResult> Create([FromBody] HotelDescriptionCreateDto hotelDescription)
        {
            await _service.InsertAsync(hotelDescription);
            return Ok();
        }

        [HttpGet]
        [Route("GetById/{id}")]

        public async Task<IActionResult> GetById([FromRoute] int id)
        {
            var result = await _service.GetAsync(id);
            return Ok(result);
        }
    }
}
