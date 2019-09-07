using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using s3Innovate.Services.Interfaces;

namespace s3Innovate.Controllers
{
    [Produces("application/json")]
    [Route("api/Chart")]
    [EnableCors("CorsPolicy")]
    public class ChartController : Controller
    {

        private readonly IChartService _chartService;
        
        public ChartController(IChartService chartService)
        {
            _chartService = chartService;

        }

        [HttpGet]
        [Route("GetSampleChart")]
        public async Task<IActionResult> GetSampleChart()
        {

            var data = await _chartService.GetSampleChart();
            return Ok(data);

        }
    }
}