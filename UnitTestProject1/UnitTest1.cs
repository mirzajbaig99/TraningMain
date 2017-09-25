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
        [ExpectedException(typeof(ArgumentException))]
        public void NotifyAllEmployeesTest()
        {
            MockRepository mocks = new MockRepository(MockBehavior.Loose);
            //Mock the Email class. No setup required.
            var mockedEmailClass = mocks.Create<IEmail>();
            var mockedIConsole = mocks.Create<IConsoleInterface>();
            //which function to bypass // no need of this
            // if we just want to bypass the code
            //mockedEmailClass.Setup(x => x.SendEmail(It.IsAny<string>())).Returns<string>(x => x);
            //mockedEmailClass.Setup(x => x.SendEmail(It.IsAny<List<string>>())).Returns(() => true);
            //mockedEmailClass.Setup(x => x.SendEmail()).Returns(() => true);
            mockedEmailClass.Setup(x => x.SendEmail(It.IsAny<string>(), It.IsAny<int>())).Returns<string, int>((x, y) => x + y)
                .Callback<string,int>((s,i) => {
                    if(string.IsNullOrWhiteSpace(s))
                    {
                        throw new ArgumentException();
                    }
                    });

            //The class to be tested
            Employee emps = new Employee(mockedEmailClass.Object, mockedIConsole.Object);
            emps.EmpId = 10;
            emps.Name = "Jack";
            //Pass to the method the mock object to be used.
            //notice syntax ".Object" in objEmail.Object
            string actualResult = emps.NotifyEmployeeReturn();

            Assert.AreEqual(emps.Name + emps.EmpId,actualResult);

            mockedEmailClass.Verify(x => x.SendEmail(It.IsAny<string>(), It.IsAny<int>()), Times.Once);
            mockedEmailClass.Verify(x => x.SendEmail(It.IsAny<string>()), Times.Never);

            emps.Name = "";
            emps.NotifyEmployeeReturn();
        }

        [TestMethod]
        public void NotifyAllEmployeesTestCallback()
        {
            MockRepository mocks = new MockRepository(MockBehavior.Loose);
            //Mock the Email class. No setup required.
            var mockedEmailClass = mocks.Create<IEmail>();
            //which function to bypass // no need of this
            // if we just want to bypass the code
            List<string> output = new List<string>();
            var mockedIConsole = mocks.Create<IConsoleInterface>();
            mockedEmailClass.Setup(x => x.SendEmailReturnNothing(It.IsAny<Employee>()))
                .Callback((Employee obj) =>
                {
                    obj.Name = obj.Name.Substring(0, 1);
                });

            mockedIConsole.Setup(m => m.ReadLine())
                .Returns(new Queue<string>(new [] {"10","Jack" } ).Dequeue);
            mockedIConsole.Setup(m => m.WriteLine(It.IsAny<string>()))
                .Callback((string s) => output.Add(s));
            //The class to be tested
            Employee emps = new Employee(mockedEmailClass.Object, mockedIConsole.Object);
            emps.EmpId = 10;
            emps.Name = "Jack";
            //Pass to the method the mock object to be used.
            //notice syntax ".Object" in objEmail.Object
            string actualResult = emps.NotifyEmployeeReturnEmployeeName();

            Assert.AreEqual(actualResult, "J");
            Assert.AreEqual(emps.Name, "J");
        }

        [TestMethod]
        public void NotifyAllEmployeesTestCallbackUsingItIs()
        {
            MockRepository mocks = new MockRepository(MockBehavior.Loose);
            var mockedIConsole = mocks.Create<IConsoleInterface>();
            //Mock the Email class. No setup required.
            var mockedEmailClass = mocks.Create<IEmail>();
            //which function to bypass // no need of this
            // if we just want to bypass the code
            mockedEmailClass.Setup(x => 
                x.SendEmail(It.Is<string>(y => !string.IsNullOrWhiteSpace(y)), It.IsAny<int>()))
                .Returns<string, int>((x, y) => x + y);

            //The class to be tested
            Employee emps = new Employee(mockedEmailClass.Object, mockedIConsole.Object);
            emps.EmpId = 10;
            emps.Name = "";
            //Pass to the method the mock object to be used.
            //notice syntax ".Object" in objEmail.Object
            string actualResult = emps.NotifyEmployeeReturn();

            mockedEmailClass.Verify(x => x.SendEmail(It.IsAny<string>(), It.IsAny<int>()), Times.Once);

        }
    }
}
