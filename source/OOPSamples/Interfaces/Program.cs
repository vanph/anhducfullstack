using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaces
{
    class Program
    {
        static void Main(string[] args)
        {
           var bird = new Bird(){Name = "Chim se"};
           // bird.Fly();

            var plane = new Plane(){Brand = "VN Airlines"};
           // p.Fly();

            //var lst = new List<object>();
            //lst.Add(plane);
            //lst.Add(bird);
           

            //foreach (var item in lst)
            //{
            //    if (item is Bird)
            //    {
            //        //option 1
            //        var b = (Bird) item;
            //        b.Fly();
            //    }
            //    else
            //    {
            //        var p = item as Plane;
            //        if (p != null)
            //        {
            //            p.Fly();
            //        }
            //    }
            //}

            var listObjects = new List<IFlyable>();
            listObjects.Add(plane);
            listObjects.Add(bird);

            foreach (var item in listObjects)
            {
                item.Fly();
            }

            Console.Read();

        }

      
    }
}
