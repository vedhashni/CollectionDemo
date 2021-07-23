using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CollectionDemo
{
    class Queue
    {
        public static void QueueDemo()
        {
            Queue<string> colours = new Queue<string>();

            //Adding the elements into the queue
            colours.Enqueue("Black");
            colours.Enqueue("Blue");
            colours.Enqueue("Red");

            Console.WriteLine("\nQueue elements are :\n");
            foreach (var c in colours)
            {
                Console.WriteLine(c);
            }
            Console.WriteLine("\nTotal number of values in queue : " + colours.Count);

            string dequeue = colours.Dequeue();

            Console.WriteLine("\nDequeue element are :\n" + dequeue);

            Queue<string>.Enumerator enumerator = colours.GetEnumerator();
            while (enumerator.MoveNext())
            {
                Console.WriteLine(enumerator.Current);
            }
        }
    }
}
