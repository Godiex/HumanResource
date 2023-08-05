namespace Entity;

public class Job
{
    public string Id {get; private set;}
    public string Title {get;set;}

    public decimal Min_Salary {get; set;}
    public decimal Max_Salary {get; set;}

    public Job(string id, string title, decimal min_Salary, decimal max_Salary)
    {
        Id = id;
        Title = title;
        Min_Salary = min_Salary;
        Max_Salary = max_Salary;
    }

}
