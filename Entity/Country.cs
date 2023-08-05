namespace Entity;

public class Country
{
    public string Id {get;private set;}
    public string Name {get;set;}

    public Region Region {get;set;}

    public Country(string countryId, string countryName)
    {
        Id = countryId;
        Name = countryName;
    }
}
