namespace Entity;

public class Employees
{
    public int Id {get; private set;}
    public string FirstName {get; private set;} = string.Empty;
    public string LastName {get; private set} = string.Empty;
    public string Email {get; private set;} = string.Empty;
    public string PhoneNumber {get; private set;} = string.Empty;
    public DateTime HireDate {get; private set;}
    public int JobId {get; private set;}
    public decimal Salary {get; private set;}
    public decimal Comission {get; private set;}
    public int Manager {get; private set;}
    public int DepartmentId {get; private set;}

    public Employees(int id, string firstName, string lastName, string email, string phoneNumber, 
    DateTime hireDate, int jobId, decimal salary, decimal comission, int manager, int departmentId)
    {
        Id = id;
        FirstName = firstName;
        LastName = lastName;
        Email = email;
        PhoneNumber = phoneNumber;
        HireDate = hireDate;
        JobId = jobId;
        Salary = salary;
        Comission = comission;
        Manager = manager;
        DepartmentId = departmentId;   
    }

}
