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

        public void NewAVLTree()
        {
            root = null;
        }

        public void DestroyNode(AVLNode node, int value)
        {
            if (node.left == null && node.right == null && node.value == value)
            {

            }
        }

        public AVLNode FindMin(AVLNode node)
        {
            while (node.left != null)
                node = node.left;
            return node;
        }

        public AVLNode FindMax(AVLNode node)
        {
            while (node.right != null)
                node = node.right;
            return node;
        }

        public int GetHeight(AVLNode node)
        {
            if (node != null)
            {
                int leftHeight = GetHeight(node.left);
                int rightHeight = GetHeight(node.right);
                return Math.Max(leftHeight, rightHeight) + 1;
            }
            else
                return 0;
        }

        public int GetWeight(AVLNode node)
        {
            if (node != null)
            {
                return GetWeight(node.left) + 1 + GetWeight(node.right);
            }
            else
                return 0;
        }

    }
}
