using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CatalogAPI.Controllers
{
    [ApiController]
    [Route("[Controller]")]
    public class defaultController : ControllerBase
    {

        private readonly ILogger<defaultController> _logger;

        public defaultController(ILogger<defaultController> logger)
        {
            _logger = logger;
        }

        [HttpGet]
        public string Get()
        {
            return "Running.... Default";
        }
    }
}
