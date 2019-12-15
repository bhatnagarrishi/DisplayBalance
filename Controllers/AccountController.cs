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
    public class AccountController : ControllerBase
    {
        TransferDbContext _tdbc;
        public AccountController(TransferDbContext tdbc)
        {
            _tdbc = tdbc;
        }
        // GET: api/Account/5
        [HttpGet("{id}", Name = "Get")]
        public IActionResult Get(string id)
        {
            var acc = _tdbc.Accounts.FirstOrDefault(a => a.AccountId == id);
            return Ok(JsonConvert.SerializeObject(acc));
        }
        // GET: api/Account
        [HttpGet]
        public IActionResult Get()
        {
            var accounts = _tdbc.Accounts;
            return Ok(JsonConvert.SerializeObject(accounts));
        }
    }
}
