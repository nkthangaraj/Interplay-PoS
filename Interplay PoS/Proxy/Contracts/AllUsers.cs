using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace io.cloudloom.interplay.pos.Proxy.Contracts.AllUsers
{

    public class Tags
    {
    }

    public class Authority
    {
        public string authority { get; set; }
    }

    public class Self
    {
        public string href { get; set; }
    }

    public class Links
    {
        public Self self { get; set; }
    }

    public class User
    {
        public string username { get; set; }
        public string id { get; set; }
        public Tags tags { get; set; }
        public List<Authority> authorities { get; set; }
        public string ownerId { get; set; }
        public bool accountNonExpired { get; set; }
        public bool accountNonLocked { get; set; }
        public bool credentialsNonExpired { get; set; }
        public bool enabled { get; set; }
        public Links _links { get; set; }
    }

    public class Embedded
    {
        public List<User> users { get; set; }
    }

    public class RootObject
    {
        public Embedded _embedded { get; set; }
    }
}
