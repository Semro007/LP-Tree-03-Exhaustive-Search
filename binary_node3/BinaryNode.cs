using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace binary_node3
{
    internal class BinaryNode<T>
    {
        internal T Value { get; set; }
        internal BinaryNode<T>? LeftChild { get; set; }
        internal BinaryNode<T>? RightChild { get; set; }

        // Constructor
        internal BinaryNode(T pValue)
        {
            Value = pValue;
            LeftChild = null;
            RightChild = null;
        }

        internal void AddLeft(BinaryNode<T> pNewNode)
        {
            LeftChild = pNewNode;
        }

        internal void AddRight(BinaryNode<T> pNewNode)
        {
            RightChild = pNewNode;
        }

        public override String ToString()
        {
            return this.ToString("");
        }

        internal String ToString(String spaces)
        {
            String ret = $"{spaces}{Value}: \n";
            if (LeftChild != null || RightChild != null)
            {
                spaces += "  ";
                ret += (LeftChild == null ? spaces+"None\n" : LeftChild.ToString(spaces)) + (RightChild == null ? spaces+"None\n" : RightChild.ToString(spaces));
            }
            return ret;
        }
        
        internal BinaryNode<T>? FindValue(String targetValue)
        {
            BinaryNode<T>? found = null;
            
            if (Value.Equals(targetValue))
            {
                found = this;
            }
            else
            {
                if (LeftChild != null)
                {
                     found = LeftChild.FindValue(targetValue);
                }
                if (found == null && RightChild != null)
                {
                    found = RightChild.FindValue(targetValue);
                }
            }
            return found;
        }
    }
}