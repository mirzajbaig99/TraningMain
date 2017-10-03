using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Mirza09112017.AccountBuilder;

namespace UnitTestProject1
{
    [TestClass]
    public class AccountBuilderTest
    {
        [TestMethod]
        public void TestAccountBuilderChecking()
       {
            Account checking = AccountBuilderOrchestrator.Build("Checking 2001 Alex MD Overdraft");

            Assert.AreEqual(checking.Name, "Alex");
            Assert.AreEqual(checking.Year, 2001);
            Assert.AreEqual(checking.State, "MD");
            Assert.IsInstanceOfType(checking, typeof(Checking));
            Assert.AreEqual(((Checking)checking).HasOverDraft, true);
        }

        [TestMethod]
        public void TestAccountBuilderSaving()
        {
            Account saving = AccountBuilderOrchestrator.Build("Savings 2011 Lynda VA");

            Assert.AreEqual(saving.Name, "Lynda");
            Assert.AreEqual(saving.Year, 2011);
            Assert.AreEqual(saving.State, "VA");
            Assert.AreEqual(((Saving)saving).HasLowBalance, false);
            Assert.IsInstanceOfType(saving, typeof(Saving));
       }

    }
}
