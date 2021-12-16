using Bogus;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using VogCodeChallenge.API.Entities;

namespace VogCodeChallenge.API.Services
{
    public class EmployeesService : IEmployeesService
    {
        public IEnumerable<Employee> GetAll()
        {
            IEnumerable<Employee> employees = Enumerable.Empty<Employee>();
            var random = new Random();
            List<Department> departments = GenerateDepartments();
            Faker<Employee> fakeEmployees = GenerateEmployeeRules();

            foreach (var employee in fakeEmployees.Generate(3).ToList())
            {
                int index = random.Next(departments.Count);
                employee.Department = departments[index];
                employee.DepartmentId = departments[index].Id;
                employees.Append(employee);
            }

            return employees;
        }

        public IList<Employee> ListAll()
        {
            IList<Employee> employees = new List<Employee>();
            var random = new Random();
            List<Department> departments = GenerateDepartments();
            Faker<Employee> fakeEmployees = GenerateEmployeeRules();

            foreach (var employee in fakeEmployees.Generate(3).ToList())
            {
                int index = random.Next(departments.Count);
                employee.Department = departments[index];
                employee.DepartmentId = departments[index].Id;
                employees.Add(employee);
            }

            return employees;
        }

        public Faker<Employee> GenerateEmployeeRules()
        {
            int nextId = 1;
            Faker<Employee> fakeEmployees = new Faker<Employee>()
                                    .RuleFor(x => x.Id, nextId++)
                                    .RuleFor(x => x.Name, f => f.Name.FirstName())
                                    .RuleFor(x => x.LastName, f => f.Name.LastName())
                                    .RuleFor(x => x.MailingAddress, f => f.Address.FullAddress())
                                    .RuleFor(x => x.JobTitle, f => f.Lorem.Locale);

            return fakeEmployees;
        }

        public List<Department> GenerateDepartments()
        {
            int nextId = 1;
            Faker<Department> fakeDepartment = new Faker<Department>()
                                    .RuleFor(x => x.Id, nextId++)
                                    .RuleFor(x => x.Name, f => f.Name.FirstName())
                                    .RuleFor(x => x.Address, f => f.Address.FullAddress());
            List<Department> departments = fakeDepartment.Generate(3).ToList();

            return departments;
        }
    }
}
