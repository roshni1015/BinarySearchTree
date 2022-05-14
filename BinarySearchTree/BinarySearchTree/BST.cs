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

         public void Display(BST<R> bst)
         {
             if (this.LeftTree != null)
             {
                 bst.leftCount++;
                 this.LeftTree.Display(bst);

             }
             Console.WriteLine(this.NodeData);
             if (this.RightTree != null)
             {
                 bst.rightCount++;
                 this.RightTree.Display(bst);
             }
         }
        public bool IfExists(R element, BST<R> node)
        {
            if (node == null)
            {
                result = false;
            }
            if (node.NodeData.Equals(element))
            {
                Console.WriteLine("Found the element in BST" + " " + node.NodeData);
                result = true;
            }
            else
            {
                Console.WriteLine("Current element is {0} in BST", node.NodeData);
            }
            if (element.CompareTo(node.NodeData) < 0)
            {
                IfExists(element, node.LeftTree);
            }
            if (element.CompareTo(node.NodeData) > 0)
            {
                IfExists(element, node.RightTree);
            }
            return result;
        }

        public void GetSize(BST<R> bst)
         {
             Console.WriteLine("Size" + " " + (1 + this.leftCount + this.rightCount));
         }


     }
 }
   

