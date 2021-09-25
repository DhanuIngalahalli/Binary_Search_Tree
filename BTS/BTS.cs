using System;
using System.Collections.Generic;
using System.Text;

namespace BST
{
    class BST<T> where T : IComparable<T>
    {
        public T NodeData { get; set; }
        public BST<T> LeftTree { get; set; }
        public BST<T> RightTree { get; set; }

        //define constructor
        public BST(T nodeData)
        {
            this.NodeData = nodeData;
            this.RightTree = null;
            this.LeftTree = null;
        }
        /// <summary>
        /// to add data in BST 
        /// </summary>
        /// <param name="item"></param>
        public void Insert(T item)
        {
            T currentNodeValue = this.NodeData;
            if ((currentNodeValue.CompareTo(item)) > 0)
            {
                if (this.LeftTree == null)
                    this.LeftTree = new BST<T>(item);
                else
                    this.LeftTree.Insert(item);
            }
            else
            {
                if (this.RightTree == null)
                    this.RightTree = new BST<T>(item);
                else
                    this.RightTree.Insert(item);
            }
        }
        private int leftCount = 0, rightCount = 0;
        /// <summary>
        /// to display data
        /// </summary>
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