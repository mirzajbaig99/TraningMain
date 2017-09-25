using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mirza09112017.com.week20
{
    public class Employee
    {
        public int EmpId { get; set; }
        public string Name { get; set; }
        public IEmail EmailService { get; set; }
        public IConsoleInterface ConsoleInt {get; set;}
        public Employee(IEmail email,IConsoleInterface consoleInt)
        {
            this.EmailService = email;
            this.ConsoleInt = consoleInt;
        }
        public bool NotifyEmployee()
        {
            return EmailService.SendEmail();
        }

        public string NotifyEmployeeReturn()
        {
            this.EmpId = Convert.ToInt32((ConsoleInt.ReadLine()));
            this.Name = (ConsoleInt.ReadLine());
            return EmailService.SendEmail(this.Name,this.EmpId);
        }

        public string NotifyEmployeeReturnEmployeeName()
        {
            EmailService.SendEmailReturnNothing(this);
            return this.Name;
        }
    }
}
