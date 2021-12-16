using Bogus;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using VogCodeChallenge.API.Entities;

namespace VogCodeChallenge.API.Services
{
    public class EmployeesService: IEmployeesService
    {
        public IEnumerable<Employee> GetAll()
        {
            IEnumerable<Employee> employees = Enumerable.Empty<Employee>();
            Faker<Employee> fakeEmployees = new Faker<Employee>()
                                    .RuleFor(x => x.Name, f => f.Name.FirstName())
                                    .RuleFor(x => x.LastName, f => f.Name.LastName())
                                    .RuleFor(x => x.JobTitle, f => f.Lorem.Random.String(0, 10));
            
            foreach (var employee in fakeEmployees.Generate(3).ToList())
            {
                employees.Append(employee);
            }

            return employees;
        }

        public IList<Employee> ListAll()
        {
            IList<Employee> employees = new List<Employee>();
            Faker<Employee> fakeEmployees = new Faker<Employee>()
                                    .RuleFor(x => x.Name, f => f.Name.FirstName())
                                    .RuleFor(x => x.LastName, f => f.Name.LastName())
                                    .RuleFor(x => x.JobTitle, f => f.Lorem.Random.String(0, 10));

            foreach (var employee in fakeEmployees.Generate(3).ToList())
            {
                employees.Add(employee);
            }

            return employees;
        }
    }
}
