using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Phanes.Api.Models;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Phanes.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SampleDataController : ControllerBase
    {
        //private readonly ILogger<SampleDataController> _logger;
        //public SampleDataController()
        //{

        //}
        private static string[] Summaries = new[]
        {
            "Freezing", "Bracing", "Chilly", "Cool", "Mild", "Warm", "Balmy", "Hot", "Sweltering", "Scorching"
        };

        [HttpGet]
        [ProducesResponseType(200, Type = typeof(IEnumerable<WeatherForecast>))]
        public IActionResult Get()
        {
            var rng = new Random();
            return Ok(Enumerable.Range(1, 5).Select(index => new WeatherForecast
            {
                DateFormatted = DateTime.Now.AddDays(index).ToString("d"),
                TemperatureC = rng.Next(-20, 55),
                Summary = Summaries[rng.Next(Summaries.Length)]
            }));
        }

        [HttpPost]
        [ProducesResponseType(200, Type = typeof(IEnumerable<WeatherForecast>))]
        public IActionResult Post()
        {
            throw new Exception();
            //var rng = new Random();
            //return Ok(Enumerable.Range(1, 5).Select(index => new WeatherForecast
            //{
            //    DateFormatted = DateTime.Now.AddDays(index).ToString("d"),
            //    TemperatureC = rng.Next(-20, 55),
            //    Summary = Summaries[rng.Next(Summaries.Length)]
            //}));
        }
    }
}
