using Microsoft.AspNetCore.Http;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Mvc;
using Mission10;
using Mission10.data;

namespace Mission10.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class BowlerController : ControllerBase
    {
        private IBowlerRepository _repo;
        //constructor
        public BowlerController(IBowlerRepository temp) {
            _repo = temp;
        }

        [HttpGet]
        public IEnumerable<Bowler> Get()
        {
            var bowlerData = _repo.Bowlers.ToList();

            return bowlerData;
        }
    }
}

