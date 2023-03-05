using NotOCPLibrary.Types;

namespace NotOCPLibrary
{
    public class Accounts
    {
        public EmployeeModel Create(PersonModel person)
        {
            EmployeeModel employee = new EmployeeModel();

            employee.FirstName = person.FirstName;
            employee.LastName = person.LastName;
            employee.EmailAddress = $"{ person.FirstName.Substring(0, 1) }{person.LastName}@acme.com";

            switch (person.EmployeeType)
            {
                case EmployeeType.Staff: break;
                case EmployeeType.Manager: employee.IsManager = true; break;
                case EmployeeType.SeniorManager: employee.IsSeniorManager = true; break;
                case EmployeeType.Executive: employee.IsExecutive = true; break;
            }

            return employee;
        }
    }
}
