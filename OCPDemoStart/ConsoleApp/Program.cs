using OCPLibrary.Users;

OCPSolution();

Console.ReadLine();



void OCPSolution()
{
    List<IApplicantModel> applicants = new List<IApplicantModel>
    {
        new PersonModel { FirstName = "Tim", LastName = "Corey" },
        new ManagerModel { FirstName = "Sue", LastName = "Storm" },
        new SeniorManagerModel { FirstName = "Nancy", LastName = "Roman" },
        new ExecutiveModel { FirstName = "Alex", LastName = "Reaktor" }
    };

    List<EmployeeModel> employees = new List<EmployeeModel>();

    foreach (var person in applicants)
    {
        employees.Add(person.AccountProcessor.Create(person));
    }

    foreach (var emp in employees)
    {
        Console.WriteLine($"{ emp.FirstName } { emp.LastName }: { emp.EmailAddress } - IsManager: { emp.IsManager } - IsSeniorManager: { emp.IsSeniorManager } - IsExecutive: { emp.IsExecutive }");
    }
}







//using NotOCPLibrary;
//using NotOCPLibrary.Types;

//NotOCPSolution();


//void NotOCPSolution()
//{
//    List<PersonModel> applicants = new List<PersonModel>
//    {
//        new PersonModel { FirstName = "Tim", LastName = "Corey" },
//        new PersonModel { FirstName = "Sue", LastName = "Storm", EmployeeType = EmployeeType.Manager },
//        new PersonModel { FirstName = "Nancy", LastName = "Roman", EmployeeType = EmployeeType.SeniorManager },
//        new PersonModel { FirstName = "Alex", LastName = "Reaktor", EmployeeType = EmployeeType.Executive }
//    };

//    List<EmployeeModel> employees = new List<EmployeeModel>();
//    Accounts accountProcessor = new Accounts();

//    foreach (var person in applicants)
//    {
//        employees.Add(accountProcessor.Create(person));
//    }

//    foreach (var emp in employees)
//    {
//        Console.WriteLine($"{ emp.FirstName } { emp.LastName }: { emp.EmailAddress } - IsManager: { emp.IsManager } - IsSeniorManager: { emp.IsSeniorManager } - IsExecutive: { emp.IsExecutive }");
//    }
//}
