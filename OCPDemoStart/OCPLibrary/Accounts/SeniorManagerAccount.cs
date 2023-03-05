using OCPLibrary.Users;

namespace OCPLibrary.Accounts
{
    public class SeniorManagerAccount : IAccount
    {
        public EmployeeModel Create(IApplicantModel person)
        {
            EmployeeModel employee = new EmployeeModel();

            employee.FirstName = person.FirstName;
            employee.LastName = person.LastName;
            employee.EmailAddress = $"{ person.FirstName}{person.LastName}@acme-sm.com";

            employee.IsSeniorManager = true;

            return employee;
        }
    }
}
