using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace gregslistFinalForm.Controllers
{
    [ApiController]
    [Route("api/cars")]
    public class CarsController : ControllerBase
    {
        private readonly CarsService _carsService;

        public CarsController(CarsService carsService)
        {
            this._carsService = carsService;
        }

        [HttpGet]
        public ActionResult<List<Car>> FindAll() 
        {
            try 
            {
              List<Car> cars = _carsService.FindAll();
              return Ok(cars);
            }
            catch (Exception e)
            {
              return BadRequest(e.Message);
            }
        }

        [HttpGet("{id}")]
        public ActionResult<Car> FindOne(int id)
        {
            try 
            {
              Car car = _carsService.FindOne(id);
              return Ok(car);
            }
            catch (Exception e)
            {
              return BadRequest(e.Message);
            }
        }
    }
}