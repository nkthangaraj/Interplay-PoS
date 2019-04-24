using System;
using System.Collections.Generic;
using System.Text;

namespace BL.Contracts.Cart
{
    public class RootObject
    {
        public Embedded _embedded { get; set; }
        public Links _links { get; set; }
    }
}
