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
        Color nodeColor = Color.Black;
        Color lineColor = Color.Black;
        int x = 400, y = 50, size = 15;

        public Form1()
        {
            InitializeComponent();
        }

        #region Controles
        private void buttonNew_Click(object sender, EventArgs e)
        {
            AVL.NewAVLTree();
            panelAVLTree.Refresh();
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
                panelAVLTree.Refresh();
            }
            catch (Exception e)
            {
                MessageBox.Show("Ingrese solo numeros");
            }
        }
        #endregion Controles

        #region Methods
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
        #endregion Methods

        #region Menu
        // FILE
        private void newToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AVL.NewAVLTree();
            panelAVLTree.Refresh();
        }
        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
        private void closeToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        // EDIT -> COlOR -> NODE
        private void blackToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            nodeColor = Color.Black;
            panelAVLTree.Refresh();
        }
        private void blueToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            nodeColor = Color.DodgerBlue;
            panelAVLTree.Refresh();
        }
        private void greenToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            nodeColor = Color.ForestGreen;
            panelAVLTree.Refresh();
        }
        private void purpleToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            nodeColor = Color.DarkMagenta;
            panelAVLTree.Refresh();
        }
        //EDIT -> COlOR -> Line
        private void blackToolStripMenuItem_Click(object sender, EventArgs e)
        {
            lineColor = Color.Black;
            panelAVLTree.Refresh();
        }
        private void blueToolStripMenuItem_Click(object sender, EventArgs e)
        {
            lineColor = Color.DodgerBlue;
            panelAVLTree.Refresh();
        }
        private void greenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            lineColor = Color.ForestGreen;
            panelAVLTree.Refresh();
        }
        private void purpleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            lineColor = Color.DarkMagenta;
            panelAVLTree.Refresh();
        }
        //EDIT -> SIZE
        private void smallToolStripMenuItem_Click(object sender, EventArgs e)
        {
            size = 10;
            panelAVLTree.Refresh();
        }
        private void mediumToolStripMenuItem_Click(object sender, EventArgs e)
        {
            size = 15;
            panelAVLTree.Refresh();
        }
        private void bigToolStripMenuItem_Click(object sender, EventArgs e)
        {
            size = 20;
            panelAVLTree.Refresh();
        }
        #endregion Menu

        #region Paint
        private void panelAVLTree_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            RefreshAVLTree(g);
        }
        private void RefreshAVLTree(Graphics g)
        {
            AVLNode aux = AVL.root;
            RefreshAVLTreeHelper(x, y, aux, g, 200);
        }
        private void RefreshAVLTreeHelper(int x, int y, AVLNode aux, Graphics g, int factor)
        {
            Pen nodePen = new Pen(nodeColor);
            Pen linePen = new Pen(lineColor);
            if (aux == null)
                return;
            else
            {
                string value = aux.value.ToString();
                Font font = new Font("Arial", 8);
                SolidBrush solidbrush = new SolidBrush(nodeColor);

                g.DrawEllipse(nodePen, x, y, size, size);
                //g.FillEllipse(solidbrush, x, y, size, size);
                g.DrawString(value, font, solidbrush, x, y - size);

                RefreshAVLTreeHelper(x - factor, y + 30, aux.left, g, factor / 2);
                RefreshAVLTreeHelper(x + factor, y + 30, aux.right, g, factor / 2);
                if (aux.left != null)
                    g.DrawLine(linePen, x + 7, y + size, x - factor + 7, y + 30);
                if (aux.right != null)
                    g.DrawLine(linePen, x + 7, y + size, x + factor + 7, y + 30);
            }
        }
        #endregion Paint
    }
}
