using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Raven.HelloWorld
{
    public interface INamedDocument
    {
        string Id { get; set; }
        string Name { get; set; }
    }
}
