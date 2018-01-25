using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Mvc;

namespace CityInfo.Api.Controllers
{
    [Route("api/cities")]
    public class CitiesController : Controller
    {
        [HttpGet()]
        public IActionResult GetCities()
        {
            return Ok(CitiesDataStore.Current.Cities);
        }

        [HttpGet("{cityId}")]
        public IActionResult GetCity(int cityId)
        {
            var cityToReturn = CitiesDataStore.Current.Cities.FirstOrDefault(c => c.CityId == cityId);

            if (cityToReturn == null){
                return NotFound();
            }
            return Ok(cityToReturn);
        }
    }
}
