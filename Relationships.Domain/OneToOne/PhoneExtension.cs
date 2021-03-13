namespace Relationships.Domain.OneToOne
{
    public class PhoneExtension
    {
        public int PhoneExtensionID { get; set; }
        public int PhoneExtensionNumber { get; set; }
        public int? EmployeeID { get; set; }
    }
}