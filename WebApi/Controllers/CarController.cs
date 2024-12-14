using Business.Abstract;
using Business.Requests.Car;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CarController : ControllerBase
    {
        ICarService _carService;
        public CarController(ICarService carService)
        {
            _carService = carService;
        }

        [HttpGet]
        public IActionResult Get() 
        {
            var result = _carService.GetAll();
            return StatusCode(result.Success ? 200 : 400, result);
        }
        [HttpPost]
        public IActionResult Post(CreateCarRequest request) 
        {
            var result = _carService.Add(request);
            return StatusCode(result.Success ? 200 : 400, result);
        }






    }
}
