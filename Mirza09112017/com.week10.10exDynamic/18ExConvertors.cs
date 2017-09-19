using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mirza09112017.com.week10._10exDynamic
{
    public class ExConvertors
    {
        public delegate int tempFunctionPointer(string strParameter, int intParamater);

        public class DelegateSample
        {
            public int FirstTestFunction(string strParameter, int intParamater)
            {
                Console.WriteLine("First Test Function Execution");
                Console.WriteLine(strParameter);
                return intParamater;
            }

            public int SecondTestFunction(string strParameter, int intParamater)
            {
                Console.WriteLine("Second Test Function Execution");
                Console.WriteLine(strParameter);
                return intParamater;
            }

            public void ThirdTestFunction(string strParameter, int intParamater)
            {
                Console.WriteLine("Third Test Function Execution");
                Console.WriteLine(strParameter);
            }

            public bool FourthTestFunction(Employee employee)
            {
                return employee.Age < 27;
            }

            public XEmployee FifthTestFunction(Employee employee)
            {
                return new XEmployee() { Name = employee.Name, Age = employee.Age, ExEmployee = true };
            }

            public int SixTestFunction(Employee strParameter1, Employee strParamater2)
            {
                return strParameter1.Age.CompareTo(strParamater2.Age);
            }


            public static void Main()
            {
                /*
                Delegate is a pointer to a method. 
                Delegate can be passed as a parameter to a method. 
                We can change the method implementation dynamically at run-time
                */
                DelegateSample tempObj = new DelegateSample();
                //tempFunctionPointer funcPointer = tempObj.FirstTestFunction;
                //funcPointer("hello", 1);
                //Console.ReadKey();
                //funcPointer = tempObj.SecondTestFunction;
                //funcPointer("hello", 1);
                //Console.ReadKey();

                /* Different Flavors of Delegate */
                /*
                Func<TParameter, TOutput>

                Func is logically similar to base delegate implementation.
                The difference is in the way we declare. 
                At the time of declaration, we need to provide the signature parameter & its return type.
                First two parameters are the method input parameters. 
                3rd parameter (always the last parameter) is the out parameter which 
                should be the output return type of the method.
                Func is always used when you have return object or type from method. 
                If you have void method, you should be using Action.
                */
                Func<string, int, int> tempFuncPointer = tempObj.FirstTestFunction;
                int value = tempFuncPointer("hello", 3);
                Console.WriteLine("Value = " + 3);
                Console.ReadKey();
                //a pointer to a method that takes two nt and returns a double.
                //the method should divide and return
                Func<int, int, double> fun = (x, y) => (double)x / y;
                Console.WriteLine("fun = " + fun(5, 2));

                /*
    Action<TParameter>

    Action is used when we do not have any return type from method. 
    Method with void signature is being used with Action delegate.
    */
                Action<string, int> tempActionPointer = tempObj.ThirdTestFunction;
                tempActionPointer("hello", 4);
                Console.ReadKey();
                Console.WriteLine("----end action------");
                Employee emp1 = new Employee() { Name = "John", Age = 31 };

                Employee[] lstEmployee = (new Employee[]
                {
               new Employee(){ Name = "John", Age = 31},
               new Employee(){ Name = "Sara", Age = 25},
               new Employee(){ Name = "Alex", Age = 22},
               new Employee(){ Name = "Lynda", Age = 29},
                });

                /*
                    Predicate<in T>
                    Predicate is a function pointer for method which returns boolean value. 
                    They are commonly used for iterating a collection or to verify 
                    if the value does already exist. 
                */
                //Predicate<Employee> tempPredicatePointer = tempObj.FourthTestFunction;
                Predicate<Employee> tempPredicatePointer = (obj) => obj.Age < 27;
                Console.WriteLine(tempPredicatePointer(emp1));

                Console.WriteLine("----end pred------");
                Console.ReadKey();

                Employee[] tempEmployee = Array.FindAll(lstEmployee, tempPredicatePointer);
                foreach (var item in tempEmployee)
                {
                    Console.WriteLine("Person below 27 age :" + item.Name);
                }
                Console.WriteLine("----end find all------");

                Console.ReadKey();

                /*Converter<TInput, TOutput>

                Convertor delegate is used when you need to migrate or
                convert one collection into another by using some algorithm. 
                Object A gets converted into Object B.
                */

                Converter<Employee, XEmployee> tempConvertorPointer
                    = tempObj.FifthTestFunction;
                
                XEmployee[] xEmployee = Array.ConvertAll(lstEmployee, tempConvertorPointer);
                foreach (var item in xEmployee)
                {
                    Console.WriteLine("emp name :" + item.Name + " exemp " + item.IsExEmployee);
                }
                Console.WriteLine("----end convert all------");
                Console.ReadKey();
                /*
                Comparison<T>
                Comparison delegate is used to sort or order the data inside a collection.
                It takes two parameters as generic input type and return type should always be int. 
                This is how we can declare Comparison delegate.
                In this sample, Employee Name is used to Sort the order. 
                All the entity inside the collection will be processed using SixthTestFunction 
                which contains the logic for processing / sorting the data as per our requirement.
                */

                Comparison<Employee> tempComparisonPointer = tempObj.SixTestFunction;
                //no need = new Comparison<Employee>(tempObj.SixTestFunction);
                Array.Sort(lstEmployee, tempComparisonPointer);

                foreach (var item in lstEmployee)
                {
                    Console.WriteLine("emp name :" + item.Name + " age " + item.Age);
                }

                Console.WriteLine("----end sort------");

            }
        }

        public class Employee
        {
            public string Name { get; set; }
            public int Age { get; set; }
        }

        public class XEmployee
        {
            public string Name { get; set; }
            public int Age { get; set; }

            public bool ExEmployee { get; set; }
            public bool IsExEmployee
            {
                get { return ExEmployee; }
            }
        }


}
}
