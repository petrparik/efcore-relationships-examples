using System.Collections.Generic;

namespace Relationships.Domain.OneToMany
{
    public class Customer
    {
        public int CustomerID { get; set; }
        public IEnumerable<Order> Orders { get; set; }
    }
}