using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EnterpriseMVVM.Data.Tests.FunctionalTests
{
    [TestClass]
    public class DatabaseScenarioTests
    {
        [TestMethod]
        public void CanCreateDatabase()
        {
            using (var db = new DomainContext())
            {
                db.Database.Create();
            }
        }
    }
}
