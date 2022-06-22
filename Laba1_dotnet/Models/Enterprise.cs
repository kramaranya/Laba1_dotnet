namespace Laba1_dotnet;

public class Enterprise
{
    public int Id { get; set; }
    public string Name { get; set; }
    public int Income { get; set; }

    public override string ToString()
    {
        return ($"Id: {Id}\t Name: {Name}\t Income: {Income}\t");
    }
}