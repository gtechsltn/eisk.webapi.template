using Eisk.Domains.Employee;
using Eisk.EntityFrameworkCore.Setup;
using Eisk.Test.Core.TestBases;

namespace Eisk.DataServices.EntityFrameworkCore.IntegrationTests
{
    public class EmployeeDataServiceTests: DataServiceBaseIntegrationTests<Employee, int>
    {
        public EmployeeDataServiceTests():base (new EmployeeDataService(TestDbContextFactory.CreateDbContext()), x => x.Id)
        {

        }

    }
}
