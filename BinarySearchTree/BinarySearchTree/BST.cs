using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinarySearchTree
{
    public class BST<R> where R : IComparable<R>
    {
        
        public R NodeData { get; set; }
        public BST<R> LeftTree { get; set; }
        public BST<R> RightTree { get; set; }
        public BST(R nodeData)
        {
            this.NodeData = nodeData;
            this.LeftTree = LeftTree;
            this.RightTree = RightTree;
        }
        int leftCount = 0, rightCount = 0;
        bool result = false;
        public void Add(R item)
        {
            R currentNodeValue = this.NodeData;
            if (currentNodeValue.CompareTo(item) > 0)
            {
                if (this.LeftTree == null)
                    this.LeftTree = new BST<R>(item);
                else
                    this.LeftTree.Add(item);
            }
            else
            {
                if (this.RightTree == null)
                    this.RightTree = new BST<R>(item);
                else
                    this.RightTree.Add(item);
            }
        }

        public void Display()
        {
            if (this.LeftTree != null)
            {
                this.leftCount++;
                this.LeftTree.Display();

            }
            Console.WriteLine(this.NodeData.ToString());
            if (this.RightTree != null)
            {
                this.rightCount++;
                this.RightTree.Display();
            }
        }
       
        
    }
}

