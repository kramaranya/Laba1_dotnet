namespace Laba1_dotnet;

 public class EmployeeEquipmentConnection
 {
    public int Id { get; set; }
    public int EmployeeId { get; set; }
    public int EquipmentId { get; set; }
    public override string ToString()
    {
        return ($"Id: {Id}\t Employee: {EmployeeId}\t Equipment: {EquipmentId}\t");
    }
}