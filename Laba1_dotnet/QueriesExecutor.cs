using System;
using System.Collections.Generic;
using System.Linq;
using Laba1_dotnet;
public class QueriesExecutor
{
    public IEnumerable<Employee> GetHighPaidMaleEmployee(IEnumerable<Employee> employees)
    {
        return employees.Where(employee => employee.Gender == Gender.Male
            && employee.WorkExperience >= employees.Average(employee => employee.WorkExperience));
    }

    public IEnumerable<Employee> GetSortedEmployeeBornInSomeYear(IEnumerable<Employee> employees, int year = 2002)///
    {
        return employees.Where(employee => employee.BirthDate.Year == year).
            OrderBy(surname => surname.Surname);
    }

    public Employee? GetYoungestEmployee(IEnumerable<Employee> employees)
    {
        return employees.MinBy(daysfrobirthdate => DateTime.Today - daysfrobirthdate.BirthDate);
    }

    public IEnumerable<Employee> GetSortedEmployeeBornInSomeMonth(IEnumerable<Employee> employees, int month = 01)///
    {
        return from employee in employees
               where employee.BirthDate.Month == month
               orderby employee.BirthDate
               select employee;
    }

    public double GetAverageIncome(IEnumerable<Enterprise> enterprises)
    {
        return enterprises.Average(enterprise => enterprise.Income);
    }

    public IEnumerable<EquipmentAndCompany> GetAmountOfEquipmentsInCompany
        (IEnumerable<Equipment> equipments)
    {
        return from equipment in equipments
               group equipment by equipment.EnterpriseId
               into enterprise
               select new EquipmentAndCompany()
               {
                   EnterpriseID = enterprise.Key,
                   AmountOfEquipment = enterprise.Count(),
               };
    }

    public IEnumerable<AllEquipmentInCompany> GetAllEquipmentInCompanies(IEnumerable<Equipment> equipments,
        IEnumerable<Enterprise> enterprises, IEnumerable<Brand> brands)
    {
        return from brand in brands
               join equipment in equipments on brand.Id equals equipment.BrandId
               join enterprise in enterprises on equipment.EnterpriseId equals enterprise.Id
               orderby enterprise.Name, brand.Name, equipment.TypeOfEquipment
               select new AllEquipmentInCompany
               {
                   BrandName = brand.Name,
                   EnterpriseName = enterprise.Name,
                   TypeOfEquipment = equipment.TypeOfEquipment
               };
    }

    public IEnumerable<EquipmentAllowedForEmployee> GetEquipmentAllowedForEmployee/////enterprise
        (IEnumerable<Equipment> equipments, IEnumerable<Employee> employees)
    {
        return equipments.GroupJoin(employees,
            equipment => equipment.EnterpriseId, employee => employee.EnterpriseId,
            (equipment, employees) => new EquipmentAllowedForEmployee()
            {
                EnterpriseId = equipment.EnterpriseId,
                Equipment = equipment,
                EmployeesAllowed = employees
            });
    }

    public IEnumerable<EquipmentAndEmployee> GetEquipmentAndAmountOfEmployees(IEnumerable<Equipment> equipments,
       IEnumerable<EmployeeEquipmentConnection> connections, IEnumerable<Brand> brands)
    {
        return from equipment in equipments
               join brand in brands on equipment.BrandId equals brand.Id
               join employee in connections on equipment.Id equals employee.EquipmentId
               into amount
               select new EquipmentAndEmployee()
               {
                   EquipmentId = equipment.Id,
                   TypeOfEquipment = equipment.TypeOfEquipment,
                   BrandName = brand.Name,
                   AmountOfEmployees = amount.Count(),
               };
    }

    public IEnumerable<NumberOfEquipmentPerEmployee> GetNumberOfEquipmentPerEmployees
      (IEnumerable<EmployeeEquipmentConnection> connections, IEnumerable<Employee> employees)
    {
        return from employee in employees
               join equipment in connections on employee.Id equals equipment.EmployeeId
               into amount
               where amount.Count() > 1
               select new NumberOfEquipmentPerEmployee
               {
                   EmployeeId = employee.Id,
                   EmployeeName = employee.Name,
                   EmployeeSurname = employee.Surname,
                   AmountOfEquipment = amount.Count(),
               };
    }

    public IEnumerable<UseOfEquipment> GetUseOfEquipment
      (IEnumerable<EmployeeEquipmentConnection> connections, IEnumerable<Equipment> equipments)
    {
        return from equipment in equipments
               join connection in connections on equipment.Id equals connection.EquipmentId
               into equipgroup
               join brand in Data.BrandsList on equipment.BrandId equals brand.Id
               from item in equipgroup.DefaultIfEmpty()
               select new UseOfEquipment()
               {
                   EquipmentId = item == null ? 0 : item.EquipmentId,
                   PriceOfEquipment = item == null ? 0 : equipment.Price,
                   BrandName = item == null ? "Nothing" : brand.Name,
                   ConnectionId = item == null ? 0 : item.Id
               };
    }

    public IEnumerable<HighIncomeCompanyAndEmployee> GetHighIncomeCompanyAndEmployees
        (IEnumerable<Enterprise> enterprises)
    {
        return enterprises.
            Where(enterprise => enterprise.Income >= enterprises.Average(enterprise => enterprise.Income)).
            Join(Data.EmployeesList,
            enterprise => enterprise.Id,
            employee => employee.EnterpriseId,
            (enterprise, employee) => new HighIncomeCompanyAndEmployee()
            {
                Employee = employee,
                Enterprisename = enterprise.Name,
                Income = enterprise.Income
            });
    }

    public IEnumerable<SortedEmployeeAndCompany> GetSortedEmployeeAndCompanies
        (IEnumerable<Employee> employees, IEnumerable<Enterprise> enterprises)
    {
        return from enterprise in enterprises
               join employee in employees
               on enterprise.Id equals employee.EnterpriseId
               orderby enterprise.Id
               select new SortedEmployeeAndCompany()
               {
                   Enterprisename = enterprise.Name,
                   Employee = employee,
               };
    }

    public IEnumerable<AmountOfEquipmentOnBrand> GetAmountOfEquipmentOnBrand
      (IEnumerable<Brand> brands, IEnumerable<Equipment> equipments)
    {
        return from equipment in equipments
               join brand in brands
               on equipment.BrandId equals brand.Id
               group equipment by equipment.BrandId
               into table
               select new AmountOfEquipmentOnBrand()
               {
                   EnterpriseId = table.Key,
                   AmountOfEquipment = table.Count(),
               };
    }

    public IEnumerable<Equipment> GetLaptopsAndComputers(IEnumerable<Equipment> equipment)////concat
    {
        return equipment.Where(equipment => equipment.TypeOfEquipment == TypeOfEquipment.Laptop).
            Concat(equipment.Where(equipment => equipment.TypeOfEquipment == TypeOfEquipment.Computer)).
            OrderBy(equipment => equipment.Price);
    }
}