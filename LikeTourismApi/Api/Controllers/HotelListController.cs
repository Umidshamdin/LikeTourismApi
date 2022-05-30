using Microsoft.AspNetCore.Mvc;
using ServiceLayer.DTOs.HotelList;
using ServiceLayer.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Api.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    
    public class HotelListController : ControllerBase
    {
        private readonly IHotelListService _service;
        public HotelListController(IHotelListService service)
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
        public async Task<IActionResult> Create([FromBody] HotelListCreateDto hotelList)
        {
            await _service.InsertAsync(hotelList);
            return Ok();
        }
    }
}
