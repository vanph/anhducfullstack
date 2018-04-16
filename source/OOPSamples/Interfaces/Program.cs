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
           var bird = new Bird();
           // bird.Fly();

            var plane = new Plane();
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

            var lst2 = new List<IFlyable>();
            lst2.Add(plane);
            lst2.Add(bird);

            foreach (var item in lst2)
            {
                item.Fly();
            }

            Console.Read();

        }

      
    }
}
