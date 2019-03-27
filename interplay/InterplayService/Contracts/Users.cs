using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterplayService.Contracts
{
    public class Doc
    {
        public string format { get; set; }
        public string value { get; set; }
    }

    public class Descriptor2
    {
        public string name { get; set; }
        public string type { get; set; }
        public Doc doc { get; set; }
    }

    public class Descriptor
    {
        public string id { get; set; }
        public string href { get; set; }
        public List<Descriptor2> descriptor { get; set; }
        public string name { get; set; }
        public string type { get; set; }
        public string rt { get; set; }
    }

    public class Alps
    {
        public string version { get; set; }
        public List<Descriptor> descriptor { get; set; }
    }

    public class Users
    {
        public Alps alps { get; set; }
    }
}
