using System;
using System.Text;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace EnterpriseMVVM.Windows.Tests.UnitTests
{
    /// <summary>
    /// Summary description for ActionCommandTests
    /// </summary>
    [TestClass]
    public class ActionCommandTests
    {
        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException))]
        public void ConstructorThrowsExceptionIfActionParameteIsNull()
        {
            var command = new ActionCommand(null);
        }

        [TestMethod]
        public void ExecuteInvokesAction()
        {
            var invoked = false;

            Action<Object> action = obj => invoked = true;

            var command = new ActionCommand(action);

            command.Execute();

            Assert.IsTrue(invoked);
        }

        [TestMethod]
        public void ExecuteOverloadInvokesActionWithParameter()
        {
            var invoked = false;

            Action<Object> action = obj =>
                {
                    Assert.IsNotNull(obj);
                    invoked = true;
                };

            var command = new ActionCommand(action);

            command.Execute(action);

            Assert.IsTrue(invoked);
        }

        [TestMethod]
        public void CanExecuteIsTruebyDefault()
        {
            var command = new ActionCommand(obj => { });
            Assert.IsTrue(command.CanExecute(null));
        }

        [TestMethod]
        public void CanExecuteOverloadExecutesTruePredicate()
        {
            var command = new ActionCommand(obj => { }, obj => (int)obj == 1);
            Assert.IsTrue(command.CanExecute(1));
        }

        [TestMethod]
        public void CanExecuteOverloadExecuteFalsePredicate()
        {
            var command = new ActionCommand(obj => { }, obj => (int)obj == 1);
            Assert.IsFalse(command.CanExecute(0));
        }
    }
}
