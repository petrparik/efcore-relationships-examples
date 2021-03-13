using System;

namespace Relationships.Domain.ManyToManyWithPayload
{
    public class PersonPosition
    {
        public int PersonID { get; set; }
        public int PositionID { get; set; }
        public DateTime DateStart { get; set; }
        public DateTime? DateEnd { get; set; }
    }
}