namespace Entity;

public class Country
{
    public string CountryId {get;set;}
    public string CountryName {get;set;}
    public int RegionId {get; private set;}

    public Country(string countryId, string countryName, int regionId)
    {
        CountryId = countryId;
        CountryName = countryName;
        RegionId = regionId;
    }
}
