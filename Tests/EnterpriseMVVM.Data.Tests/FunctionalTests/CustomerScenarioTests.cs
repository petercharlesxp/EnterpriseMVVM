using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EnterpriseMVVM.Data.Tests.FunctionalTests
{
    [TestClass]
    public class CustomerScenarioTests : FunctionalTest
    {
        [TestMethod]
        public void AddNewCustomerIsPersisted()
        {
            //using (var dc = new DomainContext())
            using (var bc = new BusinessContext())
            {
                //Customer entity = bc.AddNewCustomer("David", "Anderson");
                var customer = new Customer
                {
                    Email = "customer@northwind.com",
                    FirstName = "David",
                    LastName = "Anderson"
                };

                bc.AddNewCustomer(customer);

                bool exists = bc.DataContext.Customers.Any(c => c.Id == customer.Id);

                Assert.IsTrue(exists);
            }
        }
    }
}
