namespace Laba1_dotnet;

public class Equipment
{
    public int Id { get; set; }
    public TypeOfEquipment TypeOfEquipment { get; set; }
    public int BrandId { get; set; }
    public int Price { get; set; }
    public int Power { get; set; }
    public int EnterpriseId { get; set; }

    public override string ToString()
    {
        return ($"Id: {Id}\t Type: {TypeOfEquipment}\t Brand: {BrandId}\t Price: {Price}\t Power: {Power}\t" +
            $"Enterprise Id: {EnterpriseId}\t");
    }
}

public enum TypeOfEquipment
{
    Computer,
    Laptop,
    Scanner,
    Printer,
    Monitor
}