using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BL.Contracts.User
{
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
}
