using C_Sharp_Concepts_And_OOP.Shared.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static C_Sharp_Concepts_And_OOP.Solid._04_Dependency_Inversion_Principle;

namespace C_Sharp_Concepts_And_OOP.Solid
{
    internal class _04_Dependency_Inversion_Principle
    {
        // 5. Dependency Inversion Principle

        // High-level module should not depend on low-level module. Both should depend on abstraction.


        // Step 1 : Abstraction 
        public interface IOrganizationRepository
        {
            Task<IEnumerable<Organization>> GetAllOrganizationsAsync();
        }


        // Step 2 : High level module

        public class OrganizationService
        {
            private readonly IOrganizationRepository _repo;

            public OrganizationService(IOrganizationRepository repo)
            {
                _repo = repo;
            }

            public async Task<IEnumerable<Organization>> GetAllOrganizationsAsync() 
            {
                throw new NotImplementedException();
            }

        }

        // Step 3 : Low level module
        public class OrganizationRepository : IOrganizationRepository
        {
            private readonly EmployeeDbContext _dbContext;
            public OrganizationRepository(EmployeeDbContext dbContext)
            {
                _dbContext = dbContext;
            }

            Task<IEnumerable<Organization>> IOrganizationRepository.GetAllOrganizationsAsync()
            {
                throw new NotImplementedException();
            }
        }

        // Conclusion:

        // OrganizationService depends on IOrganizationRepository,
        // not directly on OrganizationRepository.
        

        // OrganizationService → IOrganizationRepository ← OrganizationRepository
    }
}
