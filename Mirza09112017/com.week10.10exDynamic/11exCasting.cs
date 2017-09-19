using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mirza09112017.com.week10._10exDynamic
{
    class A
    {
        virtual public void MethodA()
        {
            Console.WriteLine("A.MethodA");
        }
        
    }

    class B : A
    {
        override public void MethodA()
        {
            Console.WriteLine("B.MethodA");
        }
        public void MethodB()
        {
            Console.WriteLine("B.MethodB");
        }
        
    }
    class TestCasting
    {
        static void Main()
        {
            A a = new A();
            a.MethodA();

            B b = new B();
            b.MethodA();
            b.MethodB();

            A bobj = new B();
            bobj.MethodA();

            // ((B)bobj).MethodB(); //ok But don't do it
            Console.WriteLine("-------------");
            B b2 = bobj as B;
            b2.MethodA();
            b2.MethodB();

            B b3 = a as B;
            if(b3 == null)
            {
                Console.WriteLine("b3 is null as cast failed");
            }

            // ((B)a).MethodB(); // Runtime Exception
            // B b2 = new A(); // Not Possible

            Console.ReadKey();
        }
    }
}
