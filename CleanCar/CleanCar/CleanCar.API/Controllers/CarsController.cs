using AutoMapper;
using CleanCar.API.Models;
using CleanCar.Core;
using CleanCar.Core.DTOs;
using CleanCar.Core.Models;
using CleanCar.Core.Services;
using CleanCar.Service;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace CleanCar.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CarsController : ControllerBase
    {
        private readonly ICarsService _carsService;
        private readonly IMapper _mapper;


        public CarsController(ICarsService carsService, IMapper mapper)
        {
            _carsService = carsService;
            _mapper = mapper;
        }

        // GET all the Cars
        [HttpGet]
        public IEnumerable<Cars> Get()
        {
            return _carsService.GetAll();
        }



        // GET by Id
        [HttpGet("{id}")]
        public ActionResult<CarDTO> Get(int id)
        {
            var car = _carsService.GetById(id);
            if (car == null)
            {
                return NotFound();
            }

            var carDto = _mapper.Map<CarDTO>(car);

            return Ok(carDto);
        }


        // POST add car
        [HttpPost]
        public async Task<ActionResult> PostAsync([FromBody] CarsPostModel car)//כעקרון גם פה אפשר להשתמש בmapping אבל למען הסדר של הלימוד אשאיר את זה 
        {
            var carToAdd = new Cars { Id  = car.Id , Color = car.Color, Company = car.Company, Model = car.Model, Num_Seats = car.Num_Seats, Type_Car = car.Type_Car};
            return Ok(await _carsService.AddAsync(carToAdd));
        }

        // PUT By car and By Id
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] Cars car)
        {
            _carsService.Update(car, id);
        }

        // DELETE By Id
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            _carsService.Delete(id);
        }
    }
}
