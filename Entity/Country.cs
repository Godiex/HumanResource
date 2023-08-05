namespace Entity;

public class Country
{
    public string Id {get;set;}
    public string Name {get;set;}

    

    public Country(string countryId, string countryName)
    {
        Id = countryId;
        Name = countryName;
       
    }
}
