namespace Laba1_dotnet;

public class Data
{
    public static List<Employee> EmployeesList = new List<Employee>()
    {
        new Employee
        {
            Id = 1,
            Surname = "Kramar",
            Name = "Anna",
            Gender = Gender.Female,
            BirthDate = Convert.ToDateTime("15.01.2003"),
            Salary = 65000,
            WorkExperience = 3,
            EnterpriseId = 1
        },
        new Employee
        {
            Id = 2,
            Surname = "Tarasov",
            Name = "Vladyslav",
            Gender = Gender.Male,
            BirthDate = Convert.ToDateTime("05.12.2002"),
            Salary = 98000,
            WorkExperience = 4,
            EnterpriseId = 1
        },
        new Employee
        {
            Id = 3,
            Surname = "Bulbotka",
            Name = "Nadiia",
            Gender = Gender.Female,
            BirthDate = Convert.ToDateTime("01.10.2002"),
            Salary = 43000,
            WorkExperience = 2,
            EnterpriseId = 2
        },
        new Employee
        {
            Id = 4,
            Surname = "Vorona",
            Name = "Olexandr",
            Gender = Gender.Male,
            BirthDate = Convert.ToDateTime("04.07.2003"),
            Salary = 87000,
            WorkExperience = 4,
            EnterpriseId = 3
        },
        new Employee
        {
            Id = 5,
            Surname = "Glavatskiy",
            Name = "Orest",
            Gender = Gender.Male,
            BirthDate = Convert.ToDateTime("12.10.2003"),
            Salary = 110000,
            WorkExperience = 3,
            EnterpriseId = 4
        },
        new Employee
        {
            Id = 6,
            Surname = "Kovalenko",
            Name = "Maksym",
            Gender = Gender.Male,
            BirthDate = Convert.ToDateTime("04.02.2003"),
            Salary = 63500,
            WorkExperience = 2,
            EnterpriseId = 4
        },
        new Employee
        {
            Id = 7,
            Surname = "Linchuk",
            Name = "Anastasiia",
            Gender = Gender.Female,
            BirthDate = Convert.ToDateTime("03.05.2003"),
            Salary = 62000,
            WorkExperience = 3,
            EnterpriseId = 5
        },
        new Employee
        {
            Id = 8,
            Surname = "Filimonenkov",
            Name = "Vladyslav",
            Gender = Gender.Male,
            BirthDate = Convert.ToDateTime("12.07.2003"),
            Salary = 93500,
            WorkExperience = 5,
            EnterpriseId = 5
        },
        new Employee
        {
            Id = 9,
            Surname = "Khropost",
            Name = "Denys",
            Gender = Gender.Male,
            BirthDate = Convert.ToDateTime("02.10.2002"),
            Salary = 55000,
            WorkExperience = 1,
            EnterpriseId = 6
        },
        new Employee
        {
            Id = 10,
            Surname = "Chernenko",
            Name = "Olexandr",
            Gender = Gender.Male,
            BirthDate = Convert.ToDateTime("27.01.2003"),
            Salary = 94500,
            WorkExperience = 4,
            EnterpriseId = 6
        }
    };

    public static List<Enterprise> EnterprisesList = new List<Enterprise>()
    {
        new Enterprise
        {
            Id = 1,
            Name = "Google",
            Income = 105000
        },
        new Enterprise
        {
            Id = 2,
            Name = "Facebook",
            Income = 236000
        },
        new Enterprise
        {
            Id = 3,
            Name = "Amazon",
            Income = 638000
        },
        new Enterprise
        {
            Id = 4,
            Name = "Twitter",
            Income = 12000
        },
        new Enterprise
        {
            Id = 5,
            Name = "LinkedIn",
            Income = 43290
        },
        new Enterprise
        {
            Id = 6,
            Name = "PayPal",
            Income = 524000
        }
    };

    public static List<Brand> BrandsList = new List<Brand>()
    {
        new Brand
        {
            Id = 1,
            Name = "Apple",
        },
        new Brand
        {
            Id = 2,
            Name = "Samsung",
        },
        new Brand
        {
            Id = 3,
            Name = "HP",
        },
        new Brand
        {
            Id = 4,
            Name = "Lenovo",
        },
    };

    public static List<Equipment> EquipmentList = new List<Equipment>()
    {
        new Equipment
        {
            Id = 1,
            TypeOfEquipment = TypeOfEquipment.Laptop,
            BrandId = 2,
            Price = 3000,
            Power = 70,
            EnterpriseId = 1
        },
        new Equipment
        {
            Id = 2,
            TypeOfEquipment = TypeOfEquipment.Monitor,
            BrandId = 1,
            Price = 2500,
            Power = 60,
            EnterpriseId = 1
        },
        new Equipment
        {
            Id = 3,
            TypeOfEquipment = TypeOfEquipment.Printer,
            BrandId = 3,
            Price = 4500,
            Power = 64,
            EnterpriseId = 1
        },
        new Equipment
        {
            Id = 4,
            TypeOfEquipment = TypeOfEquipment.Laptop,
            BrandId = 1,
            Price = 2700,
            Power = 98,
            EnterpriseId = 2
        },
        new Equipment
        {
            Id = 5,
            TypeOfEquipment = TypeOfEquipment.Computer,
            BrandId = 4,
            Price = 1300,
            Power = 87,
            EnterpriseId = 2
        },
        new Equipment
        {
            Id = 6,
            TypeOfEquipment = TypeOfEquipment.Scanner,
            BrandId = 2,
            Price = 7600,
            Power = 90,
            EnterpriseId = 2
        },
        new Equipment
        {
            Id = 7,
            TypeOfEquipment = TypeOfEquipment.Monitor,
            BrandId = 3,
            Price = 4300,
            Power = 64,
            EnterpriseId = 3
        },
        new Equipment
        {
            Id = 8,
            TypeOfEquipment = TypeOfEquipment.Computer,
            BrandId = 1,
            Price = 2500,
            Power = 75,
            EnterpriseId = 3
        },
        new Equipment
        {
            Id = 9,
            TypeOfEquipment = TypeOfEquipment.Scanner,
            BrandId = 4,
            Price = 6700,
            Power = 71,
            EnterpriseId = 4
        },
        new Equipment
        {
            Id = 10,
            TypeOfEquipment = TypeOfEquipment.Printer,
            BrandId = 2,
            Price = 3100,
            Power = 88,
            EnterpriseId = 4
        },
        new Equipment
        {
            Id = 11,
            TypeOfEquipment = TypeOfEquipment.Laptop,
            BrandId = 3,
            Price = 3400,
            Power = 82,
            EnterpriseId = 4
        },
        new Equipment
        {
            Id = 12,
            TypeOfEquipment = TypeOfEquipment.Monitor,
            BrandId = 1,
            Price = 2800,
            Power = 63,
            EnterpriseId = 4
        },
        new Equipment
        {
            Id = 13,
            TypeOfEquipment = TypeOfEquipment.Computer,
            BrandId = 4,
            Price = 1600,
            Power = 92,
            EnterpriseId = 5
        },
        new Equipment
        {
            Id = 14,
            TypeOfEquipment = TypeOfEquipment.Printer,
            BrandId = 3,
            Price = 4600,
            Power = 77,
            EnterpriseId = 5
        },
        new Equipment
        {
            Id = 15,
            TypeOfEquipment = TypeOfEquipment.Scanner,
            BrandId = 2,
            Price = 4300,
            Power = 53,
            EnterpriseId = 6
        },
        new Equipment
        {
            Id = 16,
            TypeOfEquipment = TypeOfEquipment.Computer,
            BrandId = 1,
            Price = 7600,
            Power = 86,
            EnterpriseId = 6
        },
        new Equipment
        {
            Id = 17,
            TypeOfEquipment = TypeOfEquipment.Laptop,
            BrandId = 3,
            Price = 4300,
            Power = 68,
            EnterpriseId = 6
        }
    };

    public static List<EmployeeEquipmentConnection> Connections = new List<EmployeeEquipmentConnection>()
    {
        new EmployeeEquipmentConnection
        {
            Id = 1,
            EmployeeId = 1,
            EquipmentId = 1,
        },
        new EmployeeEquipmentConnection
        {
            Id = 2,
            EmployeeId = 2,
            EquipmentId = 1,
        },
        new EmployeeEquipmentConnection
        {
            Id = 3,
            EmployeeId = 2,
            EquipmentId = 2,
        },
        new EmployeeEquipmentConnection
        {
            Id = 4,
            EmployeeId = 1,
            EquipmentId = 3,
        },
        new EmployeeEquipmentConnection
        {
            Id = 5,
            EmployeeId = 3,
            EquipmentId = 4,
        },
        new EmployeeEquipmentConnection
        {
            Id = 6,
            EmployeeId = 4,
            EquipmentId = 7,
        },
        new EmployeeEquipmentConnection
        {
            Id = 7,
            EmployeeId = 5,
            EquipmentId = 9,
        },
        new EmployeeEquipmentConnection
        {
            Id = 8,
            EmployeeId = 6,
            EquipmentId = 9,
        },
        new EmployeeEquipmentConnection
        {
            Id = 9,
            EmployeeId = 5,
            EquipmentId = 10,
        },
        new EmployeeEquipmentConnection
        {
            Id = 10,
            EmployeeId = 5,
            EquipmentId = 11,

        },
        new EmployeeEquipmentConnection
        {
            Id = 11,
            EmployeeId = 7,
            EquipmentId = 13,

        },
        new EmployeeEquipmentConnection
        {
            Id = 12,
            EmployeeId = 8,
            EquipmentId = 13,

        },
        new EmployeeEquipmentConnection
        {
            Id = 13,
            EmployeeId = 7,
            EquipmentId = 14,

        },
        new EmployeeEquipmentConnection
        {
            Id = 14,
            EmployeeId = 8,
            EquipmentId = 14,

        },
        new EmployeeEquipmentConnection
        {
            Id = 15,
            EmployeeId = 9,
            EquipmentId = 15,

        },
        new EmployeeEquipmentConnection
        {
            Id = 16,
            EmployeeId = 9,
            EquipmentId = 16,

        },
        new EmployeeEquipmentConnection
        {
            Id = 17,
            EmployeeId = 10,
            EquipmentId = 16,

        },
        new EmployeeEquipmentConnection
        {
            Id = 18,
            EmployeeId = 10,
            EquipmentId = 17,

        },
    };
}