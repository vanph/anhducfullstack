using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CodeFirstFromDb.DataAccess;

namespace CodeFirstFromDb
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Starting");
            var dbContext = new StudentManagementEntities();
            //var classes = dbContext.LopHocs.ToList();
            var classes = (from e in dbContext.LopHocs select e).ToList();
            PrintClasses(classes);

            Console.ReadLine();
        }


        private static void PrintClasses(IEnumerable<LopHoc> classes)
        {
            foreach (var cl in classes)
            {
                Console.WriteLine($"{cl.MaLop} - {cl.TenLop}");
            }
        }
    }
}
