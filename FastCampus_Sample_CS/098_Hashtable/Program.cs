using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _098_Hashtable
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Hashtable hashtable = new Hashtable();
            hashtable.Add("pos", 10);
            hashtable.Add("name", "Jack");
            hashtable["weight"] = 10.8f;

            foreach(object key in hashtable.Keys)
            {
                Console.WriteLine("key : {0}, data: {1}",key, hashtable[key]);
            }
            Console.WriteLine("");

            Hashtable hashtableCopy = new Hashtable()
            {
                ["pos"] = 10,
                ["name"] = "jack",
                ["weight"] = 100.8f,
            };
            foreach(object key in hashtableCopy.Keys)
            {
                Console.WriteLine("key : {0}, data : {1}", key, hashtableCopy[key]);    
            }
        }
    }
}
