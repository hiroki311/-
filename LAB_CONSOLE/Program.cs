using LAB_FORMS;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LAB_CONSOLE
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("hello 請輸入姓名  ");
            String NAME = Console.ReadLine();
            Console.WriteLine(NAME + "你好");
            Console.WriteLine("請輸入身分證");
            String ID = Console.ReadLine();
            Console.WriteLine(NAME + ID + "無誤");

            class1 cs = new class1();
            cs.method06();

            Console.ReadKey();
            
            
            
        }
    }
}
