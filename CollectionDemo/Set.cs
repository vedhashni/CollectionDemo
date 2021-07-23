using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CollectionDemo
{
    class Set
    {
        public static void SetDemo()
        {

            HashSet<string> myhash1 = new HashSet<string>();

            // Add the elements in HashSet
            // Using Add method
            
            myhash1.Add("C#");
            myhash1.Add("Java");
            myhash1.Add("Ruby");

            Console.WriteLine("\nAdding elements to first hashset\n");
            foreach (var ele in myhash1)
            {
                Console.WriteLine(ele);
            }

            HashSet<string> myhash2 = new HashSet<string>();

            // Add the elements in HashSet
            // Using Add method
            myhash2.Add("PHP");
            myhash2.Add("C++");
            myhash2.Add("Perl");
            myhash2.Add("Java");

            Console.WriteLine("\nAdding elements to second hashset\n");
            foreach (var ele in myhash2)
            {
                Console.WriteLine(ele);
            }

            // Using UnionWith method
            Console.WriteLine("\nAfter combining both hashsets\n");
            myhash1.UnionWith(myhash2);

            foreach (var ele in myhash1)
            {
                Console.WriteLine(ele);
            }
        }
    }
}
