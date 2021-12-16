using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using VogCodeChallenge.API.Entities;

namespace VogCodeChallenge.API.Services
{
    public interface IEmployeesService
    {
        public IEnumerable<Employee> GetAll();
        public IList<Employee> ListAll();

    }
}
