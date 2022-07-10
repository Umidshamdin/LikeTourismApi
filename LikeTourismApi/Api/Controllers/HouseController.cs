using Microsoft.AspNetCore.Mvc;
using ServiceLayer.DTOs.House;
using ServiceLayer.Services.Interfaces;
using System.Threading.Tasks;

namespace Api.Controllers
{

    [ApiController]
    [Route("api/[controller]")]
    public class HouseController : ControllerBase
    {
        private readonly IHouseService _service;
        public HouseController(IHouseService service)
        {
            _service = service;
        }
        [HttpGet]
        [Route("GetAll")]
        public async Task<IActionResult> GetAll()
        {
            var res = await _service.GetAllAsync();
            return Ok(res);
        }

        [HttpPost]
        [Route("Create")]
        public async Task<IActionResult> Create([FromBody] HouseCreateDto house)
        {
            await _service.InsertAsync(house);
            return Ok();
        }
    }
}
