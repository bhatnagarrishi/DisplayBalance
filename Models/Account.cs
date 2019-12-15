using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AccountBalance.Models
{
    public class Account
    {
        public string AccountId { get; set; }
        public string OwnerId { get; set; }
        public string Balance { get; set; }
    }
}
