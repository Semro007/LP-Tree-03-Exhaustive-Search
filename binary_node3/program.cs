using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml.Linq;

namespace binary_node3
{
    class Program
    {
        private static void FindValue(BinaryNode<String> node, String targetValue)
            
        {
            BinaryNode<String>? found = node.FindValue(targetValue);
            if (found != null)
            {
                Console.WriteLine($"Found {targetValue}");
            }
            else
            {
                Console.WriteLine($"Value {targetValue} not found");
            }
        }

        static void Main(string[] args)
        {
            // Test NaryNode class
            BinaryNode<String> root = new BinaryNode<String>("Root");
            BinaryNode<String> a = new BinaryNode<String>("A");
            BinaryNode<String> b = new BinaryNode<String>("B");
            BinaryNode<String> c = new BinaryNode<String>("C");
            BinaryNode<String> d = new BinaryNode<String>("D");
            BinaryNode<String> e = new BinaryNode<String>("E");
            BinaryNode<String> f = new BinaryNode<String>("F");

            root.AddLeft(a);
            root.AddRight(b);
            a.AddLeft(c);
            a.AddRight(d);
            b.AddRight(e);
            e.AddLeft(f);

            // Find some values.
            FindValue(root, "Root");
            FindValue(root, "E");
            FindValue(root, "F");
            FindValue(root, "Q");

            // Find F in the B subtree.
            FindValue(b, "F");
        }

    }
}