using OCPLibrary.Accounts;

namespace OCPLibrary.Users
{
    public class ManagerModel : IApplicantModel
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public IAccount AccountProcessor { get; set; } = new ManagerAccount();
    }
}
