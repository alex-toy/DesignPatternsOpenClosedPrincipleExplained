using OCPLibrary.Users;

namespace OCPLibrary.Accounts
{
    public interface IAccount
    {
        EmployeeModel Create(IApplicantModel person);
    }
}