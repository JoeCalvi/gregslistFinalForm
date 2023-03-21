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

        [HttpPost]
        public ActionResult<Car> Create([FromBody] Car carData)
        {
            try 
            {
              Car car = _carsService.Create(carData);
              return Ok(car);
            }
            catch (Exception e)
            {
              return BadRequest(e.Message);
            }
        }

        [HttpPut("{id}")]
        public ActionResult<Car> Update(int id, [FromBody] Car updateData)
        {
            try 
            {
              updateData.Id = id;
              Car car = _carsService.Update(updateData);
              return Ok(car);
            }
            catch (Exception e)
            {
              return BadRequest(e.Message);
            }
        }

        [HttpDelete("{id}")]
        public ActionResult<string> Remove(int id)
        {
          try 
          {
            string message = _carsService.Remove(id);
            return Ok(message);
          }
          catch (Exception e)
          {
            return BadRequest(e.Message);
          }
        }
    }
}