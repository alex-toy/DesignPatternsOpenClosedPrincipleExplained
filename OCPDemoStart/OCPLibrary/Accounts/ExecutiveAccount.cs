using OCPLibrary.Users;

namespace OCPLibrary.Accounts
{
    public class ExecutiveAccount : IAccount
    {
        public EmployeeModel Create(IApplicantModel person)
        {
            EmployeeModel employee = new EmployeeModel();

            employee.FirstName = person.FirstName;
            employee.LastName = person.LastName;
            employee.EmailAddress = $"{ person.FirstName}.{person.LastName}@acmecorp.com";

            employee.IsExecutive = true;

            return employee;
        }
    }
}
