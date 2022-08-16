using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml.Linq;

namespace nary_node3
{
    class Program
    {
        private static void FindValue(NaryNode<String> node, String targetValue)

        {
            NaryNode<String>? found = node.FindValue(targetValue);
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
            NaryNode<String> root = new NaryNode<String>("Root");
            NaryNode<String> a = new NaryNode<String>("A");
            NaryNode<String> b = new NaryNode<String>("B");
            NaryNode<String> c = new NaryNode<String>("C");
            NaryNode<String> d = new NaryNode<String>("D");
            NaryNode<String> e = new NaryNode<String>("E");
            NaryNode<String> f = new NaryNode<String>("F");
            NaryNode<String> g = new NaryNode<String>("G");
            NaryNode<String> h = new NaryNode<String>("H");
            NaryNode<String> i = new NaryNode<String>("I");

            root.AddChild(a);
            root.AddChild(b);
            root.AddChild(c);
            a.AddChild(d);
            a.AddChild(e);
            c.AddChild(f);
            d.AddChild(g);
            f.AddChild(h);
            f.AddChild(i);

            // Find some values.
            FindValue(root, "Root");
            FindValue(root, "E");
            FindValue(root, "F");
            FindValue(root, "Q");

            // Find F in the C subtree.
            FindValue(c, "F");
        }
    }
}