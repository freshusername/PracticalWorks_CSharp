using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using _2.Data.Models;
namespace _2.Data
{
    class Queries
    {
        SoftUniContext context = new SoftUniContext();
        DateTime dateStart = new DateTime(2001, 1, 1);
        DateTime dateEnd = new DateTime(2004, 1, 1);
        

        public void Query1()
        {


            var test = context.Employees
                       .Where(x => x.EmployeeId >= 0)
                       .Select(x => new
                       {
                           lastName = x.LastName,
                           firstName = x.FirstName,
                           middleName = x.MiddleName,
                           jobTitle = x.JobTitle,
                           salary = x.Salary
        }
                       );
            foreach (var item in test)
            {
                Console.WriteLine($"Name: {item.firstName}  {item.middleName}  {item.lastName}  -  {item.jobTitle}  - {item.salary:f2}");
            }



            var FirstName = context.Employees
                .Where(x => x.EmployeeId >= 0)
                .Select(x => x.FirstName);
            var LastName = context.Employees
                .Where(x => x.EmployeeId >= 0)
                .Select(x => x.LastName);
            var MiddleName = context.Employees
                .Where(x => x.EmployeeId >= 0)
                .Select(x => x.MiddleName);
            var JobTitle = context.Employees
                .Where(x => x.EmployeeId >= 0)
                .Select(x => x.JobTitle);
            var Salary = context.Employees
                .Where(x => x.EmployeeId >= 0)
                .Select(x => x.Salary);

            //foreach(var)

        }
        public void Query2()
        {
            var test = context.Employees
                .Where(x => x.Salary > 50000)
                .OrderBy(e => e.FirstName)
                .Select(x => new
                {
                    firstName = x.FirstName
                });
            foreach (var item in test)
            {
                Console.WriteLine($"{item.firstName}");
            }
        }
        public void Query3()
        {
            var test = context.Employees
                .Where(x => x.Department.Name == "Research and Development")
                .OrderBy(e => e.Salary)
                .ThenByDescending(i => i.FirstName)
                .Select(x => new
                {
                    firstName = x.FirstName,
                    lastName = x.LastName,
                    department = x.Department.Name,
                    salary = x.Salary

                });
            foreach (var item in test)
            {
                Console.WriteLine($"{item.firstName} {item.lastName} from {item.department} - ${item.salary:f2}");
            }
        }
        public void Query4()
        {
            var address = new Address()
            {
                AddressText = "Storozhynetska",
                TownId = 4
            };

            //CHANGE VALUES
            //(from p in context.Employees
            // where p.LastName == "Gilbert"
            // select p).ToList()
            //    .ForEach(x => x.Address = address);

            var test = context.Employees
                .Where(x => x.LastName == "Gilbert")
                .OrderByDescending(i => i.AddressId)
                .Select(x => new
                {
                    firstName = x.FirstName,
                    lastName = x.LastName,
                    department = x.Department.Name,
                    salary = x.Salary,
                    townId = x.Address.TownId,
                    addressText = x.Address.AddressText,
                    addressId = x.Address.AddressId

                });

            foreach (var item in test)
            {
                (from p in context.Addresses
                 where p.AddressId == item.addressId
                 select p).ToList().ForEach(x => x.AddressText = address.AddressText);

                (from p in context.Addresses
                 where p.AddressId == item.addressId
                 select p).ToList().ForEach(x => x.TownId = address.TownId);
            }

            foreach (var item in test)
            {
                
                Console.WriteLine($"{item.addressText} - {item.addressId}  --- {item.firstName} {item.lastName} from {item.department} - ${item.salary:f2}");
                
            }
            context.SaveChanges();
        }
        public void Query5(int minYear, int maxYear)
        {
            var test = context.Employees
                .Where(e => e.Projects.Any(p => p.StartDate.Year >= minYear) &&
                    e.Projects.Any(p => p.StartDate.Year <= maxYear))
                .Take(30)
                .Select(e => new
                {
                    fname = e.FirstName,
                    lname = e.LastName,
                    manfname = e.Manager.FirstName,
                    projs = e.Projects
                });
            
            
            
            foreach (var empl in test)
            {
                Console.WriteLine($"{empl.fname} {empl.lname} {empl.manfname}");
                Console.Write("--");
                Console.WriteLine(string.Join($"{Environment.NewLine}--", empl.projs
                    .Select(p => $"{p.Name} {p.StartDate.ToString("M/d/yyyy h:mm:ss tt", CultureInfo.InvariantCulture)} {p.EndDate?.ToString("M/d/yyyy h:mm:ss tt", CultureInfo.InvariantCulture)}")));
            }

         }
        public void Query6()
        {
            foreach (var item in context.Addresses
                .OrderByDescending(a => a.Employees.Count)
                .ThenBy(a => a.Town.Name)
                .Select(e => new {
                    addressText = e.AddressText,
                    townName = e.Town.Name,
                    emplCount = e.Employees.Count
                })
                .Take(10))
            {
                Console.WriteLine($"{item.addressText}, {item.townName} - {item.emplCount} employees");
            }
        }
        public void Query7(int employeeId)
        {
            var employee = context.Employees
               .FirstOrDefault(e => e.EmployeeId == employeeId);

            if (employee == null)
            {
                Console.WriteLine($"There is not an employee with Id {employeeId}");
                return;
            }

            Console.WriteLine($"{employee.FirstName} {employee.LastName} {employee.JobTitle}");
            var test = employee.EmployeesProjects
                .Where(e => e.EmployeeId == employeeId)
                .Select(e => new {
                    pId = e.Project.Name
                });
            foreach (var item in test)
            {
                Console.WriteLine($"{item.pId}");
            }
        }
        public void Query8()
        {
            var test = context.Departments
                .Where(d => d.Employees.Count > 5)
                .OrderBy(d => d.Employees.Count)
                .Select(d => new
                {
                    emp = d.Employees,
                    name = d.Name,
                    fname = d.Manager.FirstName
                });
                          
            foreach (var itm in test)
            {
                Console.WriteLine($"{itm.name} {itm.fname}");
                foreach (var employee in itm.emp)
                {
                    Console.WriteLine($"{employee.FirstName} {employee.LastName} {employee.JobTitle}");
                }
                Console.WriteLine();
            }
        }
        public void Query9(int numberOfProjects)
        {
            var test = context.Projects
                .OrderByDescending(p => p.StartDate)
                .Take(numberOfProjects)
                .OrderBy(p => p.Name)
                .Select(p => new
                {
                    name = p.Name,
                    descr = p.Description,
                    startd = p.StartDate,
                    endd = p.EndDate
                });

            foreach (var project in test)
            {
                Console.WriteLine($"{project.name} \n {project.descr} " + "\n" + 
                    $"{project.startd.ToString("M/d/yyyy h:mm:ss tt", CultureInfo.InvariantCulture)} " + "\n" + 
                    $"{project.endd?.ToString("M/d/yyyy h:mm:ss tt", CultureInfo.InvariantCulture)}");
            }
        }
        public void Query10()
        {
            string s = "Engineering, Tool Design, Marketing or Information Services";
            var employees = context.Employees
                .Where(e => s.Contains(e.Department.Name));

            foreach (var employee in employees)
            {
                employee.Salary *= 1.12M;
            }

            context.SaveChanges();

            foreach (var employee in employees)
            {
                Console.WriteLine($"{employee.FirstName} {employee.LastName} (${employee.Salary:F6})");
            }
        }
        public void Query11()
        {
            foreach (var employee in context.Employees
                .Where(e => e.FirstName.StartsWith("Sa")))
            {
                Console.WriteLine($"{employee.FirstName} {employee.LastName} - {employee.JobTitle} - (${employee.Salary:F4})");
            }
        }
        public void Query12()
        {

        }
        public void Query13()
        {

        }

    }
}
