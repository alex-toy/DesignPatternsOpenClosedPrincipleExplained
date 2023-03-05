using OCPLibrary.Users;

namespace OCPLibrary.Accounts
{
    public class ManagerAccount : IAccount
    {
        public EmployeeModel Create(IApplicantModel person)
        {
            EmployeeModel employee = new EmployeeModel();

            employee.FirstName = person.FirstName;
            employee.LastName = person.LastName;
            employee.EmailAddress = $"{ person.FirstName.Substring(0, 1) }{person.LastName}@acmecorp.com";

            employee.IsManager = true;

            return employee;
        }
    }
}
