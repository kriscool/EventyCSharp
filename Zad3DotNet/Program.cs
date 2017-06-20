using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zad3DotNet
{
    class Program
    {
        static void Main(string[] args)
        {

            Object obj = new Object();
            Event e = new Event();
            obj.Resize += e.ResizeEvent;
            obj.AddElement += e.AddEvent;
            obj.add(23);
            obj.add(23);
            obj.add(23);
            obj.add(23);
            Console.ReadKey();
        }
    }
}

