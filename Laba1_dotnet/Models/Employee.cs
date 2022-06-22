namespace Laba1_dotnet;
public class Employee
{
    public int Id { get; set; }
    public string Surname { get; set; }
    public string Name { get; set; }
    public Gender Gender { get; set; }
    public DateTime BirthDate { get; set; }
    public int Salary { get; set; }
    public int WorkExperience { get; set; }
    public int EnterpriseId { get; set; }

    public override string ToString()
    {
        return ($"Id: {Id}\t Surname: {Surname}\t Name: {Name}\t Date Of Birth: {BirthDate:d}\t" +
                $"Salary: {Salary}\t Work Experience: {WorkExperience}\t Enterprise Id: {EnterpriseId}\t");
    }
}
public enum Gender
{
    Male,
    Female,
    Other,
    Unknown
}