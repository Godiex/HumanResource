namespace Entity;

public class Departamento
{
public int Id { get; private set; }
public string  Name { get; set; }
public int ManagerId { get; set; }
public Location Location { get; set; }


public Departamento (int id, string name,int managerId)
{
    Id = id;
    Name = name;
    ManagerId = managerId;   
}
}
