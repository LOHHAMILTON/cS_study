using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _100_Indexer02
{
    class AA
    {
        ArrayList arraylist =new ArrayList();

        public string this[int index]
        {
            get
            {
                if (index >= 0 && index < arraylist.Count)
                    return (string)arraylist[index];
                else
                    return null;
            }
            set
            {
                if (index >= 0 && index < arraylist.Count)
                    arraylist[index] = value;
                else if(index == arraylist.Count)
                    arraylist.Add(value);
            }

        }
        public int count
        {
            get { return arraylist.Count; }
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            AA aa = new AA();
            for(int i = 0; i < 10; i++)
            {
                aa[i] = String.Format("{0}", i);
            }
            aa[0] = "Hello";
            aa[1] = "World";
            aa[10] = "!!!!";

            for(int i = 0; i<aa.count; i++)
            {
                Console.WriteLine("aa : " + aa[i]);
            }
        }
    }
}
