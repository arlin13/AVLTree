using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AVLTree
{
    class AVLNode
    {
        public int value;
        public AVLNode left;
        public AVLNode right;

        public AVLNode(int value)
        {
            this.value = value;
            this.left = null;
            this.right = null;
        }
    }
}
