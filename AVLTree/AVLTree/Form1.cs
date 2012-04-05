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
            //else
            //{
            //    AVL.AddRoot(value);
            //    //AVL.root = new AVLNode(value);
            //}
        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            System.Drawing.Graphics graphicObject;
            graphicObject = this.CreateGraphics();

            Pen mypen = new Pen(System.Drawing.Color.LawnGreen, 3);
            mypen.Color = System.Drawing.Color.RoyalBlue;

            //mypen.DashStyle = System.Drawing.Drawing2D.DashStyle.DashDot;
            //mypen.Width = 3;
            //graphicObject.DrawLine(mypen, 20, 20, 200, 210);
            //graphicObject.DrawRectangle(mypen, 10, 10, 200, 210);
            //graphicObject.DrawEllipse(mypen, new Rectangle(10, 10, 200, 210));
            //graphicObject.DrawString("Dibujando en C#", new System.Drawing.Font("Helvetica", 40, FontStyle.Underline), new SolidBrush(System.Drawing.Color.Red), 900, 5);
            //Rectangle rectangle = new Rectangle(10, 10, 200, 210);
            //graphicObject.DrawRectangle(mypen, rectangle);
        }

    }
}
