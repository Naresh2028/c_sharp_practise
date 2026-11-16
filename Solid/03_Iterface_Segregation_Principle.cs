using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Sharp_Concepts_And_OOP.Solid
{
    // 4. Interface Segregation Principle (ISP)
    // A class should not be forced to depened on methods it does not use.

    // Step 01: Create a Employee Interface
    public interface IEmployee
    {
        void GetById();
        void GelAll();
        void Create();
        void Update();
        void Delete();
    }

    // Step 2: EmployeeService only needs Create() and Delete().
    public class EmployeeService : IEmployee
    {
        public void Create()
        {
            // Create Employee
        }

        public void Delete()
        {
            // Delete Employee
        }

        // Step 3: ISP violation — EmployeeService is forced to implement
        // methods it does not need.
        public void GelAll()
        {
            throw new NotImplementedException();
        }
        // Step 04 : Throw an exception, if comment the 43 line.
        // This process emphasis forcing Employee service to implement even if you are not used.
        public void GetById()
        {
            throw new NotImplementedException();
        }

        public void Update()
        {
            throw new NotImplementedException();
        }
    }
}
