using NotOCPLibrary.Types;

namespace NotOCPLibrary
{
    public class PersonModel
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public EmployeeType EmployeeType { get; set; } = EmployeeType.Staff;
    }
}
