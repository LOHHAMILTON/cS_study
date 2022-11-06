using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _110_Dictionary // 키값과 값을 저장함 해쉬테이블과 비슷
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, int> dictionary = new Dictionary<string, int>();
            dictionary.Add("10", 10);
            dictionary.Add("20", 20);
            dictionary["30"] = 30;

            foreach(var key in dictionary.Keys) //dictionary.Keys 가 중요하다.
            {
                Console.WriteLine("key : {0}   Data :   {1}",  key,  dictionary[key]);
            }

            Console.WriteLine("");

        }
    }
}
