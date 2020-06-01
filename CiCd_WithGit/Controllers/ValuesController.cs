using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace CiCd_WithGit.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ValuesController : ControllerBase
    {
        private readonly ILogger<ValuesController> _logger;

        public ValuesController()
        {
        }

        public ValuesController(ILogger<ValuesController> logger)
        {
            _logger = logger;
        }

        [HttpGet("{id}")]
        public ActionResult<string> Get(int id)
        {
            return "TestCiCd";
        }


        [HttpGet]
        public ActionResult<string> GetValue()
        {
            return "TestCiCd";
        }
    }
}