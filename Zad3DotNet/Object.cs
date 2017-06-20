using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zad3DotNet
{
    class ArgsEv : EventArgs
    {
        public int sizeArg ;
        public int[] tabArg;
    }

    class Object
    {
        public int size;
        public int newSize;
        public int currentIndex = 0;
        public int[] tab;
        public event EventHandler<ArgsEv> AddElement;
        public event EventHandler<ArgsEv> Resize;

        public Object()
        {
            this.size = 3;
            this.tab = new int[size];
        }
    

        public void addOnIndex(int index, int val)
        {
            if (index < size)
            {
                tab[index] = val;
                OnNewElement();
            }
            else
            {
                ResizeArray();
                size = index;
                tab[index] = val;

            }
            
        }

        public void add(int val)
        {

            if (currentIndex < size)
            {
                
            }else
            {
                ResizeArray();
            }
            tab[currentIndex] = val;
            OnNewElement();
            currentIndex++;


        }

        private void ResizeArray()
        {
            newSize = size * 2;
            size = newSize;
            //if (newSize.Length != arr.Rank)
            //    throw new ArgumentException("arr must have the same number of dimensions " +
            //                               "as there are elements in newSizes", "newSizes");

            var temp = Array.CreateInstance(tab.GetType().GetElementType(), newSize);
            int length = tab.Length <= temp.Length ? tab.Length : temp.Length;
            Array.ConstrainedCopy(tab, 0, temp, 0, length);
            this.tab = (int[])temp;
            OnNewSize();
        }
        public void odczyt(int indexVal)
        {
            try
            {
                Console.WriteLine(tab[indexVal]);
            }
            catch
            {
                Console.WriteLine("Jesteś poza tablica!");
            }
        }

        public void odczytAll()
        {
            int i = 0;
            foreach (int T in tab)
            {
                Console.WriteLine(tab[i]);
                i++;
            }
        }

        public virtual void OnNewSize()
        {
            if (Resize != null)
                Resize(this, new ArgsEv() { sizeArg = size });
        }

        public virtual void OnNewElement()
        {
            if (AddElement != null)
                AddElement(this, new ArgsEv() { sizeArg = currentIndex, tabArg = tab });
        }
    }
}
