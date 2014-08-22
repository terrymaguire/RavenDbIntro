using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Raven.HelloWorld
{
    public class Order
    {
        public string Id { get; set; }

        // Option 1 - Denormalized Reference
        public DenormalizedReference<Customer> Customer { get; set; }

        // Option 2 - Use Include
        //public string CustomerId { get; set; }

        private IList<OrderLine> orderLines = new List<OrderLine>();
        public IEnumerable<OrderLine> OrderLines { get { return orderLines; } set { orderLines = value.ToList(); } }

        public void AddOrderLine(OrderLine entity)
        {
            orderLines.Add(entity);
        }
    }
}
