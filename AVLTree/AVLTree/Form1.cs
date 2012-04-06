using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace AVLTree
{
    public partial class Form1 : Form
    {
        Methods AVL = new Methods();
        
        int x = 400, y = 20;

        public Form1()
        {
            InitializeComponent();
        }

        private void buttonAddNode_Click(object sender, EventArgs e)
        {
            int value = int.Parse(textBoxNode.Text);

            if (AVL.root != null)
            {
                AVL.AddNode(AVL.root, value);
            }
            else
            {
                AVL.AddRoot(value);
            }
        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = this.CreateGraphics();
            RefreshAVLTree(g);
        }

        private void RefreshAVLTree(Graphics g)
        {
            AVLNode aux = AVL.root;
            RefreshAVLTreeHelper(x, y, aux, g, 110);
        }

        private void RefreshAVLTreeHelper(int x, int y, AVLNode aux, Graphics g, int factor)
        {
            Pen mypen = new Pen(System.Drawing.Color.RoyalBlue);
            if (aux == null)
                return;
            else
            {
                g.DrawEllipse(mypen, x, y, 15, 15);
                RefreshAVLTreeHelper(x - factor, y +30, aux.left, g, factor / 2);
                RefreshAVLTreeHelper(x + factor, y +30, aux.right, g, factor / 2);
                if (aux.left != null)
                    g.DrawLine(mypen, x + 7, y + 15, x - factor + 7, y + 30);
                if (aux.right != null)
                    g.DrawLine(mypen, x + 7, y + 15, x + factor + 7, y + 30);
            }
        }

    }
}
