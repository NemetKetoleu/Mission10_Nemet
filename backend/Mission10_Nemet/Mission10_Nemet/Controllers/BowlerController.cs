using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Mission10_Nemet.Model;
using System.Collections.Generic;
using System.Linq;

namespace Mission10_Nemet.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class BowlerController : ControllerBase
    {
        private BowlingDbContext _bowlercontext;
        public BowlerController(BowlingDbContext temp)
        {
            _bowlercontext = temp;
        }

        [HttpGet(Name = "GetBowler")]
        public IEnumerable<Model.Bowler> Get()
        {
            var bowlerlist = _bowlercontext.Bowlers
                .Include(b => b.Team)
                .Where(b => b.Team.TeamName == "Marlins" || b.Team.TeamName == "Sharks")
                .ToList();
            return bowlerlist;
        }
    }
}