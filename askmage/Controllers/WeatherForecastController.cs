using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using Core;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Services.Interfaces;

namespace askmage.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class WeatherForecastController : ControllerBase
    {
        private static readonly string[] Summaries = new[]
        {
            "Freezing", "Bracing", "Chilly", "Cool", "Mild", "Warm", "Balmy", "Hot", "Sweltering", "Scorching"
        };

        private readonly ILogger<WeatherForecastController> _logger;

        IUMTProvider _umtProvider;
        private readonly UMTIDbContext _udbContext;

        public WeatherForecastController(ILogger<WeatherForecastController> logger, IUMTProvider UMTProvider, UMTIDbContext udbContext)
        {
            _logger = logger;
            this._umtProvider = UMTProvider;
            this._udbContext = udbContext;
        }

        //[HttpGet]
        //public IEnumerable<WeatherForecast> Get()
        //{
        //    var rng = new Random();
        //    string count = "";
        //    try
        //    {
        //        DataTable user = _umtProvider.GetallBylevel(null, null, null, "manager", null, null, null, null, 1, 1);
        //        count = user.Rows[0]["EmployeeCode"].ToString();
        //    }
        //    catch (Exception ex)
        //    {
        //        count = ex.Message;
        //    }

        //    return Enumerable.Range(1, 5).Select(index => new WeatherForecast
        //    {
        //        Date = DateTime.Now.AddDays(index),
        //        TemperatureC = rng.Next(-20, 55),
        //        Summary = Summaries[rng.Next(Summaries.Length)] + "new11/" + count 
        //    })
        //    .ToArray();
        //}

        //[HttpGet("[action]")]
        //public DataTable GetChannels()
        //{
        //    var rng = new Random();
        //    string count = "";
        //    try
        //    {
        //        DataTable user = _umtProvider.GetallBylevel(null, null, null, "manager", null, null, null, null, 1, 1);
        //        count = user.Rows[0]["EmployeeCode"].ToString();
        //        return user;
        //    }
        //    catch (Exception ex)
        //    {
        //        count = ex.Message;
        //    }
        //    return null;
            
        //}
    }
}
