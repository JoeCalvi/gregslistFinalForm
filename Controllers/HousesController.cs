using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace gregslistFinalForm.Controllers
{
    [ApiController]
    [Route("api/houses")]
    public class HousesController : ControllerBase
    {
        private readonly HousesService _housesService;

        public HousesController(HousesService housesService)
        {
            this._housesService = housesService;
        }

        [HttpGet]
        public ActionResult<List<House>> FindAll()
        {
            try 
            {
              List<House> houses = _housesService.FindAll();
              return Ok(houses);
            }
            catch (Exception e)
            {
              return BadRequest(e.Message);
            }
        }
    }
}