using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace CiCd_WithGit.Controllers
{
    [Route("api/[controller]")]
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

        [HttpGet]
        public IEnumerable<string> Get()
        {
            return new string[] { "Test", "TestAbc" };
        }

        [HttpGet("GetValue/{id}")]
        public ActionResult<string> GetString(int id)
        {
            return "TestCiCd";
        }
    }
}
