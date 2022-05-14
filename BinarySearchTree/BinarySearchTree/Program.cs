// See https://aka.ms/new-console-template for more information
using BinarySearchTree;

Console.WriteLine("Welcome to Binary Search Tree(BST)");
BST<int> Tree = new(56);
Tree.Add(30);
Tree.Add(70);
Tree.Add(22);
Tree.Add(40);
Tree.Add(15);
Tree.Add(95);
Tree.Add(11);
Tree.Add(65);
Tree.Add(03);
Tree.Add(16);
Tree.Add(63);
Tree.Add(67);
Tree.Display(Tree);
Tree.GetSize(Tree);
bool result = Tree.IfExists(22, Tree);
Console.WriteLine(result);
