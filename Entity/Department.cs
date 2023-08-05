namespace Entity;

public class Department
{
public int Id { get; private set; }
public string  Name { get; set; }
public int ManagerId { get; set; }
public Location Location { get; set; }


public Department (int id, string name,int managerId)
{
    Id = id;
    Name = name;
    ManagerId = managerId;   
}
}
