using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _092_property02
{
    class AA
    {
        private int num;
        private string name;

        public int NUM { get; set; }
        public string NAME { get; set; } = "NONAME";
    }
    internal class Program
    {
        static void Main(string[] args)
        {
                AA aa = new AA();
                Console.WriteLine("aa.num: {0}", aa.NUM);
                Console.WriteLine("aa.name:{0}", aa.NAME);

                aa.NUM = 100;
                aa.NAME = "Jack";
                Console.WriteLine("aa.num: {0}", aa.NUM);
                Console.WriteLine("aa.name:{0}", aa.NAME);
            }
    }
}
