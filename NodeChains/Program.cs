using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NodeChains
{
    public class Node
    {
        public int Value { get; set; }
        public Node Next { get; set; }
    }
    class Program
    {
        static int count = 1;
        static void Main(string[] args)
        {
            Node first = new Node { Value = 3 };

            Node middle = new Node { Value = 5};
            first.Next = middle;

            Node last = new Node { Value = 7 };
            middle.Next = last;

            PrintList(first);
        }
        static void PrintList(Node node)
        {
            while(node !=null)
            {
                Console.WriteLine($"Value {count} in list is {node.Value}");
                node = node.Next;
                count++;
            }
            Console.WriteLine("List finished!");
            Console.ReadKey();
        }
    }
}
