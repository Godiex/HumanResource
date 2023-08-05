namespace Entity;

public class Departamento
{
private int DepartamentId { get; set; }
public string  DepartamentName { get; set; }
public int ManagerId { get; set; }
public int LocationId { get; set; }

public Departamento (int departamentId, string departamentName,int managerId, int locationId)
{
    departamentId = DepartamentId;
    departamentName = DepartamentName;
    managerId = ManagerId;
    locationId = LocationId;
}

}
