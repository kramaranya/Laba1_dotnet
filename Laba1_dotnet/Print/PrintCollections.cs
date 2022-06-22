using System;
using System.Linq;

using Laba1_dotnet;
public class PrintCollections
{
    public static void PrintAllCollections()
    {
        Console.WriteLine("\nEmployee:\n");
        foreach (var item in Data.EmployeesList)
        {
            Console.WriteLine(item);
        }

        Console.WriteLine("\nEnterprise:\n");
        foreach (var item in Data.EnterprisesList)
        {
            Console.WriteLine(item);
        }

        Console.WriteLine("\nEquipment:\n");
        foreach (var item in Data.EquipmentList)
        {
            Console.WriteLine(item);
        }

        Console.WriteLine("\nBrand:\n");
        foreach (var item in Data.BrandsList)
        {
            Console.WriteLine(item);
        }

        Console.WriteLine("\nConnection:\n");
        foreach (var item in Data.Connections)
        {
            Console.WriteLine(item);
        }
    }
}