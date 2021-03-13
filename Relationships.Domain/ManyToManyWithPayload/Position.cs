using System.Collections.Generic;

namespace Relationships.Domain.ManyToManyWithPayload
{
    public class Position
    {
        public int PositionID { get; set; }
        public string PositionName { get; set; }
        public IEnumerable<Person> Persons { get; set; }
    }
}