using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyBanker
{
    public class Owner : IOwner
    {
        public string Firstname { get; set; }
        public string Lastname { get; set; }
        public Owner(string _firstname, string _lastname)
        {
            this.Firstname = _firstname;
            this.Lastname = _lastname;
        }
    }
}
