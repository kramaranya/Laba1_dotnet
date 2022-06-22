using System;
using System.Linq;

using Laba1_dotnet;
public class PrintQueries
{
    public static void PrintAllQueries()
    {
        QueriesExecutor queriesExecutor = new QueriesExecutor();

        Console.WriteLine("\nHigh Paid Male Employee:\n");
        var highpaidmaleemployee = queriesExecutor.GetHighPaidMaleEmployee(Data.EmployeesList);
        foreach (var item in highpaidmaleemployee)
        {
            Console.WriteLine(item);
        }
        

        Console.WriteLine("\nAmount Of Equipment In Each Company\n");
        var amountofequipment = queriesExecutor.GetAmountOfEquipmentsInCompany(Data.EquipmentList);
        foreach (var item in amountofequipment)
        {
            Console.WriteLine($"Enterprise: {item.EnterpriseID}  Amount of equipment: {item.AmountOfEquipment}");
        }
        

        Console.WriteLine("\n Sorted Employees Which Were Born In Some Year\n");
        var employeesbirthyearorderbysurname = queriesExecutor.GetSortedEmployeeBornInSomeYear
            (Data.EmployeesList, 2003);
        foreach (var item in employeesbirthyearorderbysurname)
        {
            Console.WriteLine(item);
        }
        

        Console.WriteLine("\nAll Equipment In Companies\n");
        var brandwithequipment = queriesExecutor.GetAllEquipmentInCompanies(Data.EquipmentList, 
            Data.EnterprisesList, Data.BrandsList);
        foreach (var item in brandwithequipment)
        {
            Console.WriteLine($"Enterprise: {item.EnterpriseName}  Brand: {item.BrandName}  " +
                $"Type: {item.TypeOfEquipment}");
        }
        

        Console.WriteLine("\n Equipment Allowed For Employees\n");
        var equipmentandworkers = queriesExecutor.GetEquipmentAllowedForEmployee
            (Data.EquipmentList, Data.EmployeesList);
        foreach (var item in equipmentandworkers)
        {
            Console.WriteLine(item.EnterpriseId);
            Console.WriteLine(item.Equipment);
            foreach (var employee in item.EmployeesAllowed)
            {
                Console.WriteLine(employee);
            }
            Console.WriteLine();
        }
        

        Console.WriteLine("\n The Youngest Employee\n");
        var youngestemployee = queriesExecutor.GetYoungestEmployee(Data.EmployeesList);
        Console.WriteLine(youngestemployee);
        

        Console.WriteLine("\n Equipment And Amount Of Employee\n");
        var amountofworkersforeachequipment = queriesExecutor.GetEquipmentAndAmountOfEmployees
            (Data.EquipmentList, Data.Connections, Data.BrandsList);
        foreach (var item in amountofworkersforeachequipment)
        {
            Console.WriteLine($"№: {item.EquipmentId}\t - {item.TypeOfEquipment}\t  " +
                $"Brand: {item.BrandName}\t amount of workers: {item.AmountOfEmployees}\t");
        }
        

        Console.WriteLine("\nNumber Of Equipment Per Employee\n");
        var amountofequipments = queriesExecutor.GetNumberOfEquipmentPerEmployees
            (Data.Connections, Data.EmployeesList);
        foreach (var item in amountofequipments)
        {
            Console.WriteLine($"№: {item.EmployeeId}\t {item.EmployeeName} " +
                $"{item.EmployeeSurname} - {item.AmountOfEquipment}\t");
        }
        

        Console.WriteLine("\nThe History Of Using Of Equipment\n");
        var useofequipment = queriesExecutor.GetUseOfEquipment
            (Data.Connections, Data.EquipmentList);
        foreach (var item in useofequipment)
        {
            Console.WriteLine($"№: {item.ConnectionId}\t equipment №{item.EquipmentId}\t Price: " +
                $"{item.PriceOfEquipment}\t Brand: {item.BrandName}\t");
        }
        

        Console.WriteLine("\nHigh Income Company And Employees\n");
        var highencomecompanyandemployees = queriesExecutor.GetHighIncomeCompanyAndEmployees(Data.EnterprisesList);
        foreach (var item in highencomecompanyandemployees)
        {
            Console.WriteLine($"№: {item.Employee}\t Company: {item.Enterprisename}\t  " +
                $"Income: {item.Income}\t");
        }
        
        
        Console.WriteLine("\nSorted Employees Which Were Born In Some Month\n");
        var employeebirninsomemonth = queriesExecutor.GetSortedEmployeeBornInSomeMonth(Data.EmployeesList, 10);
        foreach (var item in employeebirninsomemonth)
        {
            Console.WriteLine(item);
        }
        

        Console.WriteLine("\nSorted Employee And Companies\n");
        var enterpriseandemployee = queriesExecutor.GetSortedEmployeeAndCompanies
            (Data.EmployeesList, Data.EnterprisesList);
        foreach (var item in enterpriseandemployee)
        {
            Console.WriteLine($"№: {item.Employee}\t Enterprise: {item.Enterprisename}\t");
        }
        

        Console.WriteLine("\nAvarage Income\n");
        var averageincome = queriesExecutor.GetAverageIncome(Data.EnterprisesList);
        Console.WriteLine(averageincome);
        

        Console.WriteLine("\nAmount Of Equipment On Brand\n");
        var brandandamountofequipment = queriesExecutor.GetAmountOfEquipmentOnBrand
            (Data.BrandsList, Data.EquipmentList);
        foreach (var item in brandandamountofequipment)
        {
            Console.WriteLine($"Brand: {item.EnterpriseId}  amount of equipments: {item.AmountOfEquipment}");
        }


        Console.WriteLine("\nAll Laptops And Computers\n");
        var alllaptopsandcomputers = queriesExecutor.GetLaptopsAndComputers
            (Data.EquipmentList);
        foreach (var item in alllaptopsandcomputers)
        {
            Console.WriteLine(item);
        }
    }
}