using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Kolokwium.Model;
using Microsoft.AspNetCore.Mvc;

namespace Kolokwium.Controllers
{
    [Route("api/championships/1/teams")]
    [ApiController]
    public class ChampionshipsController : ControllerBase
    {
        private readonly MyDbContext _context;
    }

    [HttpGet("{id}")]
    public IActionResult GetChampionshipTeams(int id)
    {
        return Ok(message);
    }

}
