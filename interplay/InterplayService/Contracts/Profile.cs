using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterplayService.Contracts
{
    public class Self
    {
        public string href { get; set; }
    }

    public class Templates
    {
        public string href { get; set; }
    }

    public class PUsers
    {
        public string href { get; set; }
    }

    public class Employees
    {
        public string href { get; set; }
    }

    public class Links
    {
        public Self self { get; set; }
        public Templates templates { get; set; }
        public PUsers users { get; set; }
        public Employees employees { get; set; }
    }

    public class Profile
    {
        public Links _links { get; set; }
    }
}
