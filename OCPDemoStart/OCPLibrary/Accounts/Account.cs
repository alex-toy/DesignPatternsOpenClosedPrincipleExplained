using OCPLibrary.Accounts;
using OCPLibrary.Users;

namespace OCPLibrary
{
    public class Account : IAccount
    {
        public EmployeeModel Create(IApplicantModel person)
        {
            EmployeeModel employee = new EmployeeModel();

            employee.FirstName = person.FirstName;
            employee.LastName = person.LastName;
            employee.EmailAddress = $"{ person.FirstName.Substring(0, 1) }{person.LastName}@acme.com";

            return employee;
        }
    }
}
