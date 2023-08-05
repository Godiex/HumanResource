namespace Entity;

public class Job_History
{
    public string Id {get;set;}
    public DateTime StarDate {get; set;}
    public DateTime EndDate { get; set;}

    public string JobId { get; set;}
    public string DepartmentId { get; set;}

    public Job_History(string id, DateTime startDate, DateTime endDate, string jobId, string departmentId)
    {
        Id = id;
        StarDate = startDate;
        EndDate = endDate;
        JobId = jobId;
        DepartmentId = departmentId;

    }
}
