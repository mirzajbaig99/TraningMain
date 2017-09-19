using System;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Mirza09112017.com.week20;
using Moq;

namespace UnitTestProject1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void NotifyAllEmployeesTest()
        {
            MockRepository mocks = new MockRepository(MockBehavior.Strict);
            //Mock the Email class. No setup required.
            var mockedEmailClass = mocks.Create<IEmail>();
            //which function to bypass // no need of this
            // if we just want to bypass the code
            mockedEmailClass.Setup(x => x.SendEmail(It.IsAny<string>())).Returns<string>(x => x);
            //mockedEmailClass.Setup(x => x.SendEmail(It.IsAny<List<string>>())).Returns(() => true);
            //mockedEmailClass.Setup(x => x.SendEmail()).Returns(() => true);
            mockedEmailClass.Setup(x => x.SendEmail(It.IsAny<string>(), It.IsAny<int>())).Returns<string, int>((x, y) => x + y);

            //The class to be tested
            Employee emps = new Employee(mockedEmailClass.Object);
            emps.EmpId = 10;
            emps.Name = "Jack";
            //Pass to the method the mock object to be used.
            //notice syntax ".Object" in objEmail.Object
            string actualResult = emps.NotifyEmployeeReturn();
            Assert.AreEqual(emps.Name + emps.EmpId,actualResult);
        }
        
}
}
