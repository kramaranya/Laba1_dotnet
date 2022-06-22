namespace Laba1_dotnet;
public class EquipmentAllowedForEmployee
{
    public int EnterpriseId { get; set; }
    public Equipment Equipment { get; set; }
    public IEnumerable<Employee> EmployeesAllowed { get; set; }
}