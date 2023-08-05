namespace Entity
{
    public class Region
    {
        public int Id { get; private set; }
        public string Name {get; set;}

        public Region(int id, string name) 
        {
            Id = id;
            Name = name;
        }
    }


}
