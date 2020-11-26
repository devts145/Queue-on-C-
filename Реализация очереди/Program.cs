using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Реализация_очереди
{
    class Program
    {
        static void Main(string[] args)
        {
            _Queue<int> queue = new _Queue<int>();

            queue.Enqueue(1);
            queue.Enqueue(2);
            queue.Enqueue(3);
            queue.Enqueue(4);
            queue.Enqueue(5);
            //Console.WriteLine("DSDJL");
            //queue.printQueue();
            //Console.WriteLine("asjcbjasbjckbajsk");
            Console.WriteLine(queue.Dequeue());
            Console.WriteLine(queue.Peek());
            Console.WriteLine(queue.Dequeue());

            queue.Enqueue(124);
            queue.Enqueue(777);

            Console.WriteLine(queue.Dequeue());
            queue.Clear();
            //Console.WriteLine("AJKCKJBASJKBCJKAS");
            Console.WriteLine(queue.Peek());
            Console.ReadLine();
        }
    }
}
