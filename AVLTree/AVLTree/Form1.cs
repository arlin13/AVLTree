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

        #region PAINT
        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = this.CreateGraphics();
            RefreshAVLTree(g);
        }
        private void RefreshAVLTree(Graphics g)
        {
            AVLNode aux = AVL.root;
            RefreshAVLTreeHelper(x, y, aux, g, 200);
        }
        private void RefreshAVLTreeHelper(int x, int y, AVLNode aux, Graphics g, int factor)
        {
            Pen mypen = new Pen(System.Drawing.Color.RoyalBlue);
            if (aux == null)
                return;
            else
            {
                string value = aux.value.ToString();
                Font font = new Font("Arial", 8);
                SolidBrush solidbrush = new SolidBrush(Color.Black);

                g.DrawEllipse(mypen, x, y, 15, 15);
                g.DrawString(value, font, solidbrush, x, y-15);
                
                RefreshAVLTreeHelper(x - factor, y +30, aux.left, g, factor / 2);
                RefreshAVLTreeHelper(x + factor, y +30, aux.right, g, factor / 2);
                if (aux.left != null)
                    g.DrawLine(mypen, x + 7, y + 15, x - factor + 7, y + 30);
                if (aux.right != null)
                    g.DrawLine(mypen, x + 7, y + 15, x + factor + 7, y + 30);
            }
        }
        #endregion PAINT

        private void buttonNew_Click(object sender, EventArgs e)
        {
            AVL.NewAVLTree();
        }

        private void buttonDo_Click(object sender, EventArgs e)
        {
            Do();
        }

        private void textBoxNode_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)13)
                Do();
        }

        private void Do()
        {
            try
            {
                if (radioButtonAdd.Checked)
                {
                    AddNode(int.Parse(textBoxNode.Text));
                }
                else if (radioButtonDestroy.Checked)
                {
                    DestroyNode(int.Parse(textBoxNode.Text));
                }
                else if (radioButtonShowHeight.Checked)
                {
                    ShowHeight(int.Parse(textBoxNode.Text));
                }
                else if (radioButtonShowWeight.Checked)
                {
                    ShowWeight(int.Parse(textBoxNode.Text));
                }
            }
            catch (Exception e)
            {
                MessageBox.Show("Ingrese solo numeros");
            }
        }

        private void AddNode(int value)
        {
            if (AVL.root != null)
            {
                AVL.AddNode(AVL.root, value);
            }
            else
            {
                AVL.AddRoot(value);
            }
        }

        private void DestroyNode(int value)
        {
            
        }

        private void ShowHeight(int value)
        { 
            
        }

        private void ShowWeight(int value)
        {

        }
    }
}
