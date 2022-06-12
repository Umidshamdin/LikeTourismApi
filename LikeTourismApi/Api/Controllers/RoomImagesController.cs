using Microsoft.AspNetCore.Mvc;
using ServiceLayer.DTOs.RoomImages;
using ServiceLayer.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Api.Controllers
{

    [ApiController]
    [Route("api/[controller]")]
    public class RoomImagesController : ControllerBase
    {
        private readonly IRoomImagesService _service;
        public RoomImagesController(IRoomImagesService service)
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
        public async Task<IActionResult> Create([FromBody] CreateRoomImageDto roomImageDto)
        {
            await _service.InsertAsync(roomImageDto);
            return Ok();
        }
    }
}
