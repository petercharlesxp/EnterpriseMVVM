using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EnterpriseMVVM.Data.Tests.UnitTests
{
    [TestClass]
    public class BusinessContextTests
    {
        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException))]
        public void AddNewCustomer_ThrowsExpection_WhenFirstNameIsNull()
        {
            using (BusinessContext bc = new BusinessContext())
            {
                bc.AddNewCustomer(null, "Anderson");
            }
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void AddNewCustomer_ThrowsExpetion_WhenFirstNameIsEmpty()
        {
            using (var bc = new BusinessContext())
            {
                bc.AddNewCustomer("", "Anderson");
            }
        }
    }
}
