using OCPLibrary.Accounts;

namespace OCPLibrary.Users
{
    public interface IApplicantModel
    {
        string FirstName { get; set; }
        string LastName { get; set; }
        IAccount AccountProcessor { get; set; }
    }
}