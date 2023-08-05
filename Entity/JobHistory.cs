namespace Entity;

public class JobHistory
{
    public string Id {get;set;}
    public DateTime StarDate {get; set;}
    public DateTime EndDate { get; set;}

    public string JobId { get; set;}
    public string DepartmentId { get; set;}

    public JobHistory(string id, DateTime startDate, DateTime endDate, string jobId, string departmentId)
    {
        Id = id;
        StarDate = startDate;
        EndDate = endDate;
        JobId = jobId;
        DepartmentId = departmentId;

    }
}
