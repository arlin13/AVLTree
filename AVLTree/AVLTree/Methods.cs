using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AVLTree
{
    class Methods
    {
        public AVLNode root = null;

        public Methods()
        {

        }

        public void AddRoot(int value)
        {
            root = new AVLNode(value);
        }

        public void AddNode(AVLNode node, int value)
        {
            // Goes to right
            if (value > node.value)
            {
                if (node.right == null)
                    node.right = new AVLNode(value);
                else
                    AddNode(node.right, value);
            }
            // Goes to left
            else if (value < node.value)
            {
                if (node.left == null)
                    node.left = new AVLNode(value);
                else
                    AddNode(node.left, value);
            }
        }

        //public void DestroyNode(AVLNode node, int value)
        //{
        //    if (node.left == null && node.right == null && node.value == value)
        //    { 

        //    }

        //}

    }
}
