namespace Mirza09112017.com.week10._10exDynamic
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

        class Student
        {
            public int StudentID { get; set; }
            public String StudentName { get; set; }
            public int Age { get; set; }
        }

        class Program
        {
            static void Main(string[] args)
            {
                Student[] studentArray = {
                    new Student() { StudentID = 1, StudentName = "John", Age = 18 } ,
                    new Student() { StudentID = 2, StudentName = "Steve",  Age = 20 } ,
                    new Student() { StudentID = 3, StudentName = "Bill",  Age = 25 } ,
                    new Student() { StudentID = 4, StudentName = "Sara" , Age = 20 } ,
                    new Student() { StudentID = 5, StudentName = "Lynda" , Age = 31 } ,
                    new Student() { StudentID = 6, StudentName = "Chris",  Age = 18 } ,
                    new Student() { StudentID = 7, StudentName = "Clara",Age = 19  } ,
                };

                // Use LINQ to find teenAger students
                Student[] teenAgerStudents = studentArray.Where(s => s.Age > 12 && s.Age < 20).ToArray();

                // Use LINQ to find first student whose name is Bill 
                Student bill = studentArray.Where(s => s.StudentName == "Bill").FirstOrDefault();

                // Use LINQ to find student whose StudentID is 5
                Student student5 = studentArray.Where(s => s.StudentID == 5).FirstOrDefault();

                IList<Student> studentList = new List<Student>() {
                    new Student() { StudentID = 1, StudentName = "John", Age = 18 } ,
                    new Student() { StudentID = 2, StudentName = "Steve",  Age = 21 } ,
                    new Student() { StudentID = 3, StudentName = "Bill",  Age = 25 } ,
                    new Student() { StudentID = 4, StudentName = "Sara" , Age = 20 } ,
                    new Student() { StudentID = 5, StudentName = "Lynda" , Age = 31 } ,
                    new Student() { StudentID = 6, StudentName = "Chris",  Age = 17 } ,
                    new Student() { StudentID = 7, StudentName = "Clara",Age = 19  } ,
    };
                // LINQ Method Syntax to find out teenager students
                var teenAgerStudents1 = studentList.Where(s => s.Age > 12 && s.Age < 20)
                                                  .ToList<Student>();

                //i is the index
                var filteredResult = studentList.Where((s, i) => {
                    if (i % 2 == 0) // if it is even element
                        return true;

                    return false;
                });

                foreach (var std in filteredResult)
                    Console.WriteLine(std.StudentName);


                var studentsInAscOrder = studentList.OrderBy(s => s.StudentName);
                var studentsInDescOrder = studentList.OrderByDescending(s => s.StudentName);

                var thenByResult = studentList.OrderBy(s => s.StudentName).ThenBy(s => s.Age);

                var thenByDescResult = studentList.OrderBy(s => s.StudentName).ThenByDescending(s => s.Age);

                var groupedResult = studentList.GroupBy(s => s.Age);
                foreach (var ageGroup in groupedResult)
                {
                    Console.WriteLine("Age Group: {0}", ageGroup.Key);  //Each group has a key 

                    foreach (Student s in ageGroup)  //Each group has a inner collection  
                        Console.WriteLine("Student Name: {0}", s.StudentName);
                }

                
                var selectResult = studentList.Select(s => new {
                    Name = s.StudentName,
                    Age = s.Age
                });
            }
        }

    }
