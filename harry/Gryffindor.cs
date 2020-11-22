using System;
using System.Collections.Generic;
using System.Text;

namespace harry
{
    class Gryffindor
    {
        public string HouseGhost { get; set; }
        public string Mascot { get; set; }
        public string Password { get; set; }
        public Gryffindor()
        {
            HouseGhost = "Nearly Headless Nick";
            Mascot = "Lion";
            Password = "en ensam trollkarl";
        }
    }
}
