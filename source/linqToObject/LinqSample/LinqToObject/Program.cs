using System;
using System.CodeDom;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinqToObject
{
    class Program
    {
        static void Main(string[] args)
        {
            var students = GetStudents();

            PrintStudents(students);

           // Console.WriteLine("Display name of students:");
            //var names = from e in students select e.FullName;
            //var names = students.Select(x=> x.FullName);

            Console.WriteLine("List students order by fullname:");
            PrintStudents(students.OrderBy(a => a.FullName));
            Console.WriteLine("List students order by mark decending");
            PrintStudents(students.OrderByDescending(a => a.Mark));

            Console.WriteLine("Display the oldest students (age = max(age)):");
            var maxAge = students.Max(x => x.Age);
            var maxAgeStudents = students.Where(x => x.Age == maxAge);
            PrintStudents(maxAgeStudents);

            Console.WriteLine("Display students that have min mark");
            var minMark = students.Min(x => x.Mark);
            var minMarkStudents = students.Where(m => m.Mark == minMark);
            PrintStudents(minMarkStudents);

            Console.WriteLine("Display students that have duplicated age 1");
            //Option 1
            var duplicatedAgeStudents = new List<Student>();

            foreach (var item in students)
            {
                if(students.Any(x=> x.Id != item.Id && x.Age == item.Age))
                {
                    duplicatedAgeStudents.Add(item);
                }
            }

            PrintStudents(duplicatedAgeStudents.OrderByDescending(x=> x.Age));

            Console.WriteLine("Display students that have duplicated age 2 (Group)");
            //option 2
            var grouped = students.GroupBy(x => x.Age);
            foreach (var grp in grouped)
            {
                //check duplicated age
                if (grp.Count() > 1)
                {
                    Console.WriteLine("Group:");
                    PrintStudents(grp);
                }
            }

            //option 2
            Console.WriteLine("Display students that have duplicated age 3 (Group + SelectMany)");
            var duplicatedAgeStudent3 = students.GroupBy(x => x.Age).Where(g=> g.Count()>1).SelectMany(x => x);
            PrintStudents(duplicatedAgeStudent3);

            //homework where  + select 


            Console.ReadLine();
        }

        private static List<Student> GetStudents()
        {

            var student1 = new Student
            {
                Id = 1,
                FullName = "ngo anh duc",
                Age = 36,
                Mark = 7.5m
            };
            var student2 = new Student
            {
                Id = 2,
                FullName = "hoang tuan dat",
                Age = 30,
                Mark = 8
            };
            var student3 = new Student
            {
                Id = 3,
                FullName = "nguyen van manh",
                Age = 36,
                Mark = 6.5m
            };
            var student4 = new Student
            {
                Id = 4,
                FullName = "bui to khoa",
                Age = 32,
                Mark = 5
            };
            var student5 = new Student
            {
                Id = 5,
                FullName = "nguyen minh ngoc",
                Age = 28,
                Mark = 9
            };

            var student6 = new Student
            {
                Id = 6,
                FullName = "ho van ngoc",
                Age = 28,
                Mark = 7
            };
            var student7 = new Student
            {
                Id = 7,
                FullName = "chu quang bo",
                Age = 36,
                Mark = 9
            };

            var result = new List<Student> { student1, student2, student3, student4, student5, student6, student7 };

            return result;
        }

        private static void PrintStudents(IEnumerable<Student> students)
        {
            foreach (var student in students)
            {
                Console.WriteLine($"Id: {student.Id} - Fullname: {student.FullName} - Age: {student.Age} - Mark: {student.Mark}");
            }
        }
    }
}
