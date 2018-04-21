using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListExample
{
    class Program
    {
        static void StudyList()
        {
            // cấp phát bộ nhớ để sử dụng đối tượng List
            List<string> list = new List<string>();
            // thêm phần tử vào danh sách:
            list.Add("An");
            list.Add("Bình");
            list.Add("Hạnh");
            list.Add("Phúc");
            list.Insert(2,"Giải thoát");
            list.Remove("Bình");
            list.RemoveAt(0);
            Console.WriteLine("Danh sách các phần tử trong List là:");
            for (int i = 0; i < list.Count; i++)
            {
                string v = list[i];
                Console.WriteLine(v);
            }
        }

        static void StudyList2()
        {
            List<int> list = new List<int>();
            Random rd = new Random();
            for (int i = 0; i < 10; i++)
            
                list.Add(rd.Next(100));
                Console.WriteLine("\nCác phần tử trong danh sách gốc là :");
                foreach (int x in list)
                {
                    Console.Write(x + "\t");
                }
                list.Sort();
                Console.WriteLine("\nCác phần tử trong danh sách sắp xếp là :");
                foreach (int x in list)
                {
                    Console.Write(x + "\t");
                }
            int k;
            Console.WriteLine("\n Mời bạn nhập vào số muốn tìm :");
            k = Convert.ToInt32(Console.ReadLine());
            int rs = list.IndexOf(k);
            if (rs < 0)
            {
                Console.WriteLine($"Không tìm thấy {k} trong danh sách");
            }
            else
            {
                Console.WriteLine($"Tìm thấy {k} tại vị trí {rs}");
            }

        } 

        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            //StudyList();
            StudyList2();
            Console.ReadLine();
        }
    }
}
