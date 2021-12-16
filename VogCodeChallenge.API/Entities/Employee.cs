    using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace VogCodeChallenge.API.Entities
{
    public class Employee:Entity
    {
        public string Name { get; set; }
        public string LastName { get; set; }
        public string JobTitle { get; set; }
        public string MailingAddress { get; set; }
        public int DepartmentId { get; set; }
        public virtual Department Department { get; set; }
    }
}
