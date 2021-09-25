using System;

namespace BST
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to binary search tree");
            BST<int> binarySearch = new BST<int>(56);
            binarySearch.Insert(30);
            binarySearch.Insert(70);
            binarySearch.Display();
        }
    }
}
