namespace AVLTree
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.buttonDo = new System.Windows.Forms.Button();
            this.textBoxNode = new System.Windows.Forms.TextBox();
            this.radioButtonAdd = new System.Windows.Forms.RadioButton();
            this.radioButtonDestroy = new System.Windows.Forms.RadioButton();
            this.radioButtonShowHeight = new System.Windows.Forms.RadioButton();
            this.radioButtonShowWeight = new System.Windows.Forms.RadioButton();
            this.buttonNew = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // buttonDo
            // 
            this.buttonDo.Location = new System.Drawing.Point(863, 225);
            this.buttonDo.Name = "buttonDo";
            this.buttonDo.Size = new System.Drawing.Size(75, 23);
            this.buttonDo.TabIndex = 0;
            this.buttonDo.Text = "Do";
            this.buttonDo.UseVisualStyleBackColor = true;
            this.buttonDo.Click += new System.EventHandler(this.buttonDo_Click);
            // 
            // textBoxNode
            // 
            this.textBoxNode.Location = new System.Drawing.Point(852, 12);
            this.textBoxNode.Name = "textBoxNode";
            this.textBoxNode.Size = new System.Drawing.Size(100, 20);
            this.textBoxNode.TabIndex = 1;
            this.textBoxNode.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxNode_KeyPress);
            // 
            // radioButtonAdd
            // 
            this.radioButtonAdd.AutoSize = true;
            this.radioButtonAdd.Location = new System.Drawing.Point(877, 39);
            this.radioButtonAdd.Name = "radioButtonAdd";
            this.radioButtonAdd.Size = new System.Drawing.Size(44, 17);
            this.radioButtonAdd.TabIndex = 2;
            this.radioButtonAdd.TabStop = true;
            this.radioButtonAdd.Text = "Add";
            this.radioButtonAdd.UseVisualStyleBackColor = true;
            // 
            // radioButtonDestroy
            // 
            this.radioButtonDestroy.AutoSize = true;
            this.radioButtonDestroy.Location = new System.Drawing.Point(877, 62);
            this.radioButtonDestroy.Name = "radioButtonDestroy";
            this.radioButtonDestroy.Size = new System.Drawing.Size(61, 17);
            this.radioButtonDestroy.TabIndex = 3;
            this.radioButtonDestroy.TabStop = true;
            this.radioButtonDestroy.Text = "Destroy";
            this.radioButtonDestroy.UseVisualStyleBackColor = true;
            // 
            // radioButtonShowHeight
            // 
            this.radioButtonShowHeight.AutoSize = true;
            this.radioButtonShowHeight.Location = new System.Drawing.Point(877, 85);
            this.radioButtonShowHeight.Name = "radioButtonShowHeight";
            this.radioButtonShowHeight.Size = new System.Drawing.Size(86, 17);
            this.radioButtonShowHeight.TabIndex = 4;
            this.radioButtonShowHeight.TabStop = true;
            this.radioButtonShowHeight.Text = "Show Height";
            this.radioButtonShowHeight.UseVisualStyleBackColor = true;
            // 
            // radioButtonShowWeight
            // 
            this.radioButtonShowWeight.AutoSize = true;
            this.radioButtonShowWeight.Location = new System.Drawing.Point(877, 108);
            this.radioButtonShowWeight.Name = "radioButtonShowWeight";
            this.radioButtonShowWeight.Size = new System.Drawing.Size(89, 17);
            this.radioButtonShowWeight.TabIndex = 5;
            this.radioButtonShowWeight.TabStop = true;
            this.radioButtonShowWeight.Text = "Show Weight";
            this.radioButtonShowWeight.UseVisualStyleBackColor = true;
            // 
            // buttonNew
            // 
            this.buttonNew.Location = new System.Drawing.Point(863, 254);
            this.buttonNew.Name = "buttonNew";
            this.buttonNew.Size = new System.Drawing.Size(75, 23);
            this.buttonNew.TabIndex = 6;
            this.buttonNew.Text = "New ";
            this.buttonNew.UseVisualStyleBackColor = true;
            this.buttonNew.Click += new System.EventHandler(this.buttonNew_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(984, 562);
            this.Controls.Add(this.buttonNew);
            this.Controls.Add(this.radioButtonShowWeight);
            this.Controls.Add(this.radioButtonShowHeight);
            this.Controls.Add(this.radioButtonDestroy);
            this.Controls.Add(this.radioButtonAdd);
            this.Controls.Add(this.textBoxNode);
            this.Controls.Add(this.buttonDo);
            this.Name = "Form1";
            this.Text = "AVL Tree";
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.Form1_Paint);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonDo;
        private System.Windows.Forms.TextBox textBoxNode;
        private System.Windows.Forms.RadioButton radioButtonAdd;
        private System.Windows.Forms.RadioButton radioButtonDestroy;
        private System.Windows.Forms.RadioButton radioButtonShowHeight;
        private System.Windows.Forms.RadioButton radioButtonShowWeight;
        private System.Windows.Forms.Button buttonNew;
    }
}

