using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
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
        // GET: api/Account/5
        [HttpGet("{id}", Name = "Get")]
        public IActionResult Get(string id)
        {
            var acc = new Account { AccountId = "fy34q9ht3", Balance = 46489.478, OwnerId = "584237y09h" };
            return Ok(JsonConvert.SerializeObject(acc));
        }
        // GET: api/Account
        [HttpGet]
        public IActionResult Get()
        {
            var accounts = new List<Account> { 
                new Account { AccountId = "78tgw7f9e", Balance = 76489.478, OwnerId = "87g9wfe" }, 
                new Account { AccountId = "fy34q9ht3", Balance = 46489.478, OwnerId = "584237y09h" } 
            };
            return Ok(JsonConvert.SerializeObject(accounts));
        }
    }
}
