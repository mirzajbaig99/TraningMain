using System;
using System.Text;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Mirza09112017.com.week30;
using AutoMapper;

namespace UnitTestProject1
{
    /// <summary>
    /// Summary description for TestAutoMapper
    /// </summary>
    [TestClass]
    public class TestAutoMapper
    {
        public TestAutoMapper()
        {
            //
            // TODO: Add constructor logic here
            //
        }

        private TestContext testContextInstance;

        /// <summary>
        ///Gets or sets the test context which provides
        ///information about and functionality for the current test run.
        ///</summary>
        public TestContext TestContext
        {
            get
            {
                return testContextInstance;
            }
            set
            {
                testContextInstance = value;
            }
        }

        #region Additional test attributes
        //
        // You can use the following additional attributes as you write your tests:
        //
        // Use ClassInitialize to run code before running the first test in the class
        // [ClassInitialize()]
        // public static void MyClassInitialize(TestContext testContext) { }
        //
        // Use ClassCleanup to run code after all tests in a class have run
        // [ClassCleanup()]
        // public static void MyClassCleanup() { }
        //
        // Use TestInitialize to run code before running each test 
        // [TestInitialize()]
        // public void MyTestInitialize() { }
        //
        // Use TestCleanup to run code after each test has run
        // [TestCleanup()]
        // public void MyTestCleanup() { }
        //
        #endregion

        [TestInitialize]
        public void Setup()
        {
            //ExAutoMapper.SetupAutomapper();
        }
        
        [TestMethod]
        public void MapPersonToCustomer()
        {
            // Arrange
            var per = new Person
            {
                FirstName = "Alex",
                LastName = "Rod"
            };

            // Act
            Customer cust = Mapper.Map<Customer>(per);

            // Assert
            Assert.IsNotNull(cust);
            Assert.IsNotNull(cust.FirstName);
            Assert.IsInstanceOfType(cust, typeof(Customer));
            //Assert.AreEqual(expected, actual)
            Assert.AreEqual(per.FirstName, cust.FirstName);
            Assert.AreEqual(per.LastName, cust.LastName);
            Assert.AreEqual(0, cust.Salary);
        }


        [TestMethod]
        public void MapPersonToEmployee()
        {
            // Arrange
            var per = new Person
            {
                FirstName = "Alex",
                LastName = "Rod"
            };

            // Act
            Employee emp = Mapper.Map<Employee>(per);

            // Assert
            Assert.IsNotNull(emp);
            Assert.IsNotNull(emp.FName);
            Assert.IsInstanceOfType(emp, typeof(Employee));
            //Assert.AreEqual(expected, actual)
            Assert.AreEqual(per.FirstName, emp.FName);
            Assert.AreEqual(per.LastName, emp.LName);
            Assert.AreEqual(0, emp.Salary);
        }

        [TestMethod]
        public void MapAccountToAccountDto()
        {
            // Arrange
            // Arrange
            var account = new Account
            {
                AccountId = 100,
                Customer = new Customer() { FirstName = "Alex", LastName = "Rod", Salary = 150000},
                Year = DateTime.Parse("1/1/1980")

            };

            // Act
            var accountDto = Mapper.Map<AccountDto>(account);

            // Assert
            Assert.AreEqual(account.Customer.LastName, accountDto.LastName);
            Assert.AreEqual(account.Customer.FirstName, accountDto.FirstName);
            Assert.AreEqual(account.Customer.Salary, accountDto.Salary);
            Assert.AreEqual(account.AccountId, accountDto.AccountId);
            Assert.AreEqual(account.Year, accountDto.Year);

        }

        [TestMethod]
        public void MapAccountDtoToAccount()
        {
            // Arrange
            // Arrange
            var accountDto = new AccountDto
            {
                AccountId = 100,
                Year = DateTime.Parse("1/1/1980"),
                FirstName = "Alex",
                LastName = "Rod",
                Salary = 100000

            };

            // Act
            var account = Mapper.Map<Account>(accountDto);

            // Assert
            Assert.AreEqual(accountDto.LastName, account.Customer.LastName);
            Assert.AreEqual(accountDto.FirstName, account.Customer.FirstName);
            Assert.AreEqual(accountDto.Salary, account.Customer.Salary);
            Assert.AreEqual(accountDto.AccountId, account.AccountId);
            Assert.AreEqual(accountDto.Year, account.Year);


        }


    }
}
