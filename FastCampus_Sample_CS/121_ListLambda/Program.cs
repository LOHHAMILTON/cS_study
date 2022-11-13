using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//DESC : Lambda식, 컬렉션(List)기초

namespace _121_ListLambda
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> listdata = new List<int> { 1, 2, 3, 100, 200, 300 };

            //public delegate bool Predicate<in T>(T obj);
            //public List<T> FindALL(Predicate<T> match);

            List<int> listfindAll = listdata.FindAll((num) => { return num < 200; });

            Console.WriteLine("200보다 작은 모든 수 : ");
            foreach(int a in listfindAll)
            {
                Console.WriteLine(" a: " + a);
            }
            int findNum = listdata.Find((num) => { return num % 2 == 0; });
            Console.WriteLine("첫번째 짝수: " + findNum);
        }
    }
}
