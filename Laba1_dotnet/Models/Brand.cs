namespace Laba1_dotnet;

public class Brand
{
    public int Id { get; set; }
    public string Name { get; set; }

    public override string ToString()
    {
        return ($"Id: {Id}\t Name: {Name}\t");
    }
}