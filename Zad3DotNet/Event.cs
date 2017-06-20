using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zad3DotNet
{
    class Event
    {
        public void ResizeEvent(object source, ArgsEv args)
        {
            Console.WriteLine(" Zmieniono rozmiar. Obecny rozmiar tablicy to: " + args.sizeArg);
        }

        public void AddEvent(object source, ArgsEv args)
        {
            Console.WriteLine(" Dodano wartość : " + args.tabArg[args.sizeArg] + " do ostatniego indeksu tablicy");
        }
    }
}
