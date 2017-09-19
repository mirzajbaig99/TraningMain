using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Mirza09112017.com.week20;

namespace Moq
{
    [TestClass]
    public class MoqTest1
    {
        [TestMethod]
        public void NotifyEmployeeTest()
        {
            // Arrange
            Mock<IEmail> mockEmail = new Mock<IEmail>();
            Employee emp = new Employee(mockEmail.Object);

            // Act
            bool actual = emp.NotifyEmployee();

            // Assert
            Assert.IsTrue(actual);
        }
    }
}
