using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace VogCodeChallenge.API.Entities
{
    public class Department:Entity
    {
        public string Name { get; set; }
        //[Index(IsUnique = true)]
        public string Address { get; set; }
    }
}
