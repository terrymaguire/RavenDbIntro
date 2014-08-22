using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Raven.HelloWorld
{
    public class Customer : INamedDocument
    {
        public string Id { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }
        public string EmailAddress { get; set; }
    }
}
