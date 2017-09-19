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
        public Employee(IEmail email)
        {
            this.EmailService = email;
        }
        public bool NotifyEmployee()
        {
            return EmailService.SendEmail();
        }

        public string NotifyEmployeeReturn()
        {
            return EmailService.SendEmail(this.Name,this.EmpId);
        }
    }
}
