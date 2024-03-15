using Microsoft.AspNetCore.Mvc;
using Mission10API.Data;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Mission10API.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class BowlerController : ControllerBase
    {
        private IBowlerRepository _bowlerRepository;

        public BowlerController(IBowlerRepository temp)
        {
            _bowlerRepository = temp;
        }

        [HttpGet]
        public IEnumerable<Bowler> Get()
        {
            var bowlerData = _bowlerRepository.GetAllBowlersWithTeams().Where(x => string.Equals(x.TeamName, "Marlins") ||
            string.Equals(x.TeamName, "Sharks")).ToArray();

            return bowlerData;
        }
    }
}
