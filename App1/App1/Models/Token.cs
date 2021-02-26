
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace App1.Droid.Models
{
    class Token
    { public int Id { get; set; }
        public string access_token { get; set;}
        public string error_description { get; set; }
        public DateTime expire_data { get; set; }
        public Token() { }

    }
}