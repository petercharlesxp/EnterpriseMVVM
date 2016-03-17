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
        public void AddNewCustomer_ThrowsExpection_WhenEmailIsNull()
        {
            using (BusinessContext bc = new BusinessContext())
            {
                var customer = new Customer
                {
                    Email = null,
                    FirstName = "David",
                    LastName = "Anderson"
                };

                bc.AddNewCustomer(customer);
            }
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void AddNewCustomer_ThrowsExpetion_WhenEmailIsEmpty()
        {
            using (var bc = new BusinessContext())
            {
                var customer = new Customer
                {
                    Email = "",
                    FirstName = "David",
                    LastName = "Anderson"
                };

                bc.AddNewCustomer(customer);
            }
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException))]
        public void AddNewCustomer_ThrowsExpection_WhenFirstNameIsNull()
        {
            using (BusinessContext bc = new BusinessContext())
            {
                var customer = new Customer
                {
                    Email = "customer@northwind.comn",
                    FirstName = null,
                    LastName = "Anderson"
                };

                bc.AddNewCustomer(customer);
            }
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void AddNewCustomer_ThrowsExpetion_WhenFirstNameIsEmpty()
        {
            using (var bc = new BusinessContext())
            {
                var customer = new Customer
                {
                    Email = "customer@northwind.comn",
                    FirstName = "",
                    LastName = "Anderson"
                };

                bc.AddNewCustomer(customer);
            }
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException))]
        public void AddNewCustomer_ThrowsExpection_WhenLastNameIsNull()
        {
            using (BusinessContext bc = new BusinessContext())
            {
                var customer = new Customer
                {
                    Email = "customer@northwind.comn",
                    FirstName = "David",
                    LastName = null
                };

                bc.AddNewCustomer(customer);
            }
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void AddNewCustomer_ThrowsExpetion_WhenLastNameIsEmpty()
        {
            using (var bc = new BusinessContext())
            {
                var customer = new Customer
                {
                    Email = "customer@northwind.comn",
                    FirstName = "David",
                    LastName = ""
                };

                bc.AddNewCustomer(customer);
            }
        }


    }
}
