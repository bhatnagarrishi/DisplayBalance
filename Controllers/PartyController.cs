using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AccountBalance.Data;
using AccountBalance.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;

namespace AccountBalance.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PartyController : ControllerBase
    {
        TransferDbContext _tdbc;
        public PartyController(TransferDbContext tdbc)
        {
            _tdbc = tdbc;
        }
        // GET: api/Party/5
        [HttpGet("{id}", Name = "Get")]
        public IActionResult Get(string id)
        {
            var party = _tdbc.Parties.FirstOrDefault(a => a.PartyId == id);
            return Ok(JsonConvert.SerializeObject(party));
        }
        // GET: api/Party
        [HttpGet]
        public IActionResult Get()
        {
            var parties = _tdbc.Parties;
            return Ok(JsonConvert.SerializeObject(parties));
        }
    }
}
