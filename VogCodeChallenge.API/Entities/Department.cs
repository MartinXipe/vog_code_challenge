using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace VogCodeChallenge.API.Entities
{
    public class Department:Entity
    {
        [Required]
        public string Name { get; set; }
        [Required]
        public string Address { get; set; }

        public virtual List<Employee> Employees { get; set; }
    }
}
