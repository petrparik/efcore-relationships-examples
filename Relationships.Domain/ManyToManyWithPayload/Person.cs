using System.Collections.Generic;

namespace Relationships.Domain.ManyToManyWithPayload
{
    public class Person
    {
        public int PersonID { get; set; }
        public string PersonName { get; set; }
        public IEnumerable<Position> Positions { get; set; }
    }
}