﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mirza09112017.com.week20
{
    public interface IEmail
    {
        void SendEmailReturnNothing(Employee content);
        bool SendEmail();
        string SendEmail(string content);
        bool SendEmail(List<string> contents);
        string SendEmail(string content, int empid);
    }

    public class OutlookEmail : IEmail
    {
        public void SendEmailReturnNothing(Employee content)
        {
            content.Name.Substring(0, 1);
        }

        public bool SendEmail()
        {
            Console.WriteLine("Send email via smtp");
            return true;
        }

        public string SendEmail(string content)
        {
            Console.WriteLine("Send email via smtp");
            return content;
        }

        public bool SendEmail( List<string> contents)
        {
            Console.WriteLine("Send email via smtp");
            return true;
        }

        public string SendEmail(string content , int empid)
        {
            Console.WriteLine("Send email via smtp");
            return content + empid;
        }
    }

    public class WebServiceEmail : IEmail
    {
        public void SendEmailReturnNothing(Employee content)
        {
            throw new NotImplementedException("");
        }

        public bool SendEmail()
        {
            throw new NotImplementedException("");
        }

        public string SendEmail(string content)
        {
            throw new NotImplementedException("");
        }

        public bool SendEmail(List<string> contents)
        {
            throw new NotImplementedException("");
        }

        public string SendEmail(string content, int empid)
        {
            throw new NotImplementedException("");
        }
    }
}
