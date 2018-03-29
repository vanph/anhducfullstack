using System;
using System.CodeDom;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DBFirst
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Starting");
            var dbContext = new QLHocSinhEntities();
            var classes = dbContext.LopHocs.ToList();
            PrintClasses(classes);

            Console.WriteLine("Press any key to add new class");
            Console.ReadKey();
            Console.WriteLine("Add new class");
            var lopHoc = new LopHoc {MaLop = "CL002", TenLop = "Java Tutorial", SoLuong = 1};
            dbContext.LopHocs.Add(lopHoc);
            dbContext.SaveChanges();
            PrintClasses(dbContext.LopHocs.ToList());
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
