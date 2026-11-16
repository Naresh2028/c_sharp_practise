using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Sharp_Concepts_And_OOP.Shared.Model
{
    public class Organization
    {
        public int Id { get; set; }
        public required string Name { get; set; }
        //spublic ICollection<Department> Departments { get; set; } = new List<Department>();
        public DateTime CreatedAt { get; set; }
        public DateTime? ModifiedAt { get; set; }
    }
}
