using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _096_Queue
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Queue queue = new Queue();

            queue.Enqueue("a");
            queue.Enqueue("b");
            queue.Enqueue("c");

            for (int i = 0; i < 10; i++)
            {
                queue.Enqueue(i);
            }
            Console.WriteLine("queue data:{0}", queue.Peek());

            while(queue.Count>0)
            {
                Console.WriteLine("queue data:{0}, count:{1}",queue.Dequeue(),queue.Count);
            }
        }
    }
}
