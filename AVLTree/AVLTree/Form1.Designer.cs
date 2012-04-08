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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.buttonDo = new System.Windows.Forms.Button();
            this.textBoxNode = new System.Windows.Forms.TextBox();
            this.radioButtonAdd = new System.Windows.Forms.RadioButton();
            this.radioButtonDestroy = new System.Windows.Forms.RadioButton();
            this.radioButtonShowHeight = new System.Windows.Forms.RadioButton();
            this.radioButtonShowWeight = new System.Windows.Forms.RadioButton();
            this.buttonNew = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.newToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.closeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.colorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lineToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.blackToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.blueToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.greenToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.purpleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.nodeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.blackToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.blueToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.greenToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.purpleToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.sizeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.smallToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mediumToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.bigToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.groupBoxRadioButtons = new System.Windows.Forms.GroupBox();
            this.panelAVLTree = new System.Windows.Forms.Panel();
            this.menuStrip1.SuspendLayout();
            this.groupBoxRadioButtons.SuspendLayout();
            this.SuspendLayout();
            // 
            // buttonDo
            // 
            this.buttonDo.Location = new System.Drawing.Point(864, 202);
            this.buttonDo.Name = "buttonDo";
            this.buttonDo.Size = new System.Drawing.Size(102, 23);
            this.buttonDo.TabIndex = 0;
            this.buttonDo.Text = "Do";
            this.buttonDo.UseVisualStyleBackColor = true;
            this.buttonDo.Click += new System.EventHandler(this.buttonDo_Click);
            // 
            // textBoxNode
            // 
            this.textBoxNode.Location = new System.Drawing.Point(864, 48);
            this.textBoxNode.Name = "textBoxNode";
            this.textBoxNode.Size = new System.Drawing.Size(102, 20);
            this.textBoxNode.TabIndex = 1;
            this.textBoxNode.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxNode_KeyPress);
            // 
            // radioButtonAdd
            // 
            this.radioButtonAdd.AutoSize = true;
            this.radioButtonAdd.Location = new System.Drawing.Point(6, 19);
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
            this.radioButtonDestroy.Location = new System.Drawing.Point(6, 42);
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
            this.radioButtonShowHeight.Location = new System.Drawing.Point(6, 65);
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
            this.radioButtonShowWeight.Location = new System.Drawing.Point(6, 88);
            this.radioButtonShowWeight.Name = "radioButtonShowWeight";
            this.radioButtonShowWeight.Size = new System.Drawing.Size(89, 17);
            this.radioButtonShowWeight.TabIndex = 5;
            this.radioButtonShowWeight.TabStop = true;
            this.radioButtonShowWeight.Text = "Show Weight";
            this.radioButtonShowWeight.UseVisualStyleBackColor = true;
            // 
            // buttonNew
            // 
            this.buttonNew.Location = new System.Drawing.Point(864, 231);
            this.buttonNew.Name = "buttonNew";
            this.buttonNew.Size = new System.Drawing.Size(102, 23);
            this.buttonNew.TabIndex = 6;
            this.buttonNew.Text = "New ";
            this.buttonNew.UseVisualStyleBackColor = true;
            this.buttonNew.Click += new System.EventHandler(this.buttonNew_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.editToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(984, 24);
            this.menuStrip1.TabIndex = 7;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newToolStripMenuItem,
            this.openToolStripMenuItem,
            this.saveToolStripMenuItem,
            this.closeToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // newToolStripMenuItem
            // 
            this.newToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("newToolStripMenuItem.Image")));
            this.newToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Fuchsia;
            this.newToolStripMenuItem.Name = "newToolStripMenuItem";
            this.newToolStripMenuItem.Size = new System.Drawing.Size(103, 22);
            this.newToolStripMenuItem.Text = "New";
            this.newToolStripMenuItem.Click += new System.EventHandler(this.newToolStripMenuItem_Click);
            // 
            // openToolStripMenuItem
            // 
            this.openToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("openToolStripMenuItem.Image")));
            this.openToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Fuchsia;
            this.openToolStripMenuItem.Name = "openToolStripMenuItem";
            this.openToolStripMenuItem.Size = new System.Drawing.Size(103, 22);
            this.openToolStripMenuItem.Text = "Open";
            this.openToolStripMenuItem.Click += new System.EventHandler(this.openToolStripMenuItem_Click);
            // 
            // saveToolStripMenuItem
            // 
            this.saveToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("saveToolStripMenuItem.Image")));
            this.saveToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Fuchsia;
            this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            this.saveToolStripMenuItem.Size = new System.Drawing.Size(103, 22);
            this.saveToolStripMenuItem.Text = "Save";
            this.saveToolStripMenuItem.Click += new System.EventHandler(this.saveToolStripMenuItem_Click);
            // 
            // closeToolStripMenuItem
            // 
            this.closeToolStripMenuItem.Name = "closeToolStripMenuItem";
            this.closeToolStripMenuItem.Size = new System.Drawing.Size(103, 22);
            this.closeToolStripMenuItem.Text = "Close";
            this.closeToolStripMenuItem.Click += new System.EventHandler(this.closeToolStripMenuItem_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(103, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // editToolStripMenuItem
            // 
            this.editToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.colorToolStripMenuItem,
            this.sizeToolStripMenuItem});
            this.editToolStripMenuItem.Name = "editToolStripMenuItem";
            this.editToolStripMenuItem.Size = new System.Drawing.Size(39, 20);
            this.editToolStripMenuItem.Text = "Edit";
            // 
            // colorToolStripMenuItem
            // 
            this.colorToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.lineToolStripMenuItem,
            this.nodeToolStripMenuItem});
            this.colorToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("colorToolStripMenuItem.Image")));
            this.colorToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.colorToolStripMenuItem.Name = "colorToolStripMenuItem";
            this.colorToolStripMenuItem.Size = new System.Drawing.Size(103, 22);
            this.colorToolStripMenuItem.Text = "Color";
            // 
            // lineToolStripMenuItem
            // 
            this.lineToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.blackToolStripMenuItem,
            this.blueToolStripMenuItem,
            this.greenToolStripMenuItem,
            this.purpleToolStripMenuItem});
            this.lineToolStripMenuItem.Name = "lineToolStripMenuItem";
            this.lineToolStripMenuItem.Size = new System.Drawing.Size(103, 22);
            this.lineToolStripMenuItem.Text = "Line";
            // 
            // blackToolStripMenuItem
            // 
            this.blackToolStripMenuItem.Name = "blackToolStripMenuItem";
            this.blackToolStripMenuItem.Size = new System.Drawing.Size(108, 22);
            this.blackToolStripMenuItem.Text = "Black";
            this.blackToolStripMenuItem.Click += new System.EventHandler(this.blackToolStripMenuItem_Click);
            // 
            // blueToolStripMenuItem
            // 
            this.blueToolStripMenuItem.Name = "blueToolStripMenuItem";
            this.blueToolStripMenuItem.Size = new System.Drawing.Size(108, 22);
            this.blueToolStripMenuItem.Text = "Blue";
            this.blueToolStripMenuItem.Click += new System.EventHandler(this.blueToolStripMenuItem_Click);
            // 
            // greenToolStripMenuItem
            // 
            this.greenToolStripMenuItem.Name = "greenToolStripMenuItem";
            this.greenToolStripMenuItem.Size = new System.Drawing.Size(108, 22);
            this.greenToolStripMenuItem.Text = "Green";
            this.greenToolStripMenuItem.Click += new System.EventHandler(this.greenToolStripMenuItem_Click);
            // 
            // purpleToolStripMenuItem
            // 
            this.purpleToolStripMenuItem.Name = "purpleToolStripMenuItem";
            this.purpleToolStripMenuItem.Size = new System.Drawing.Size(108, 22);
            this.purpleToolStripMenuItem.Text = "Purple";
            this.purpleToolStripMenuItem.Click += new System.EventHandler(this.purpleToolStripMenuItem_Click);
            // 
            // nodeToolStripMenuItem
            // 
            this.nodeToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.blackToolStripMenuItem1,
            this.blueToolStripMenuItem1,
            this.greenToolStripMenuItem1,
            this.purpleToolStripMenuItem1});
            this.nodeToolStripMenuItem.Name = "nodeToolStripMenuItem";
            this.nodeToolStripMenuItem.Size = new System.Drawing.Size(103, 22);
            this.nodeToolStripMenuItem.Text = "Node";
            // 
            // blackToolStripMenuItem1
            // 
            this.blackToolStripMenuItem1.Name = "blackToolStripMenuItem1";
            this.blackToolStripMenuItem1.Size = new System.Drawing.Size(108, 22);
            this.blackToolStripMenuItem1.Text = "Black";
            this.blackToolStripMenuItem1.Click += new System.EventHandler(this.blackToolStripMenuItem1_Click);
            // 
            // blueToolStripMenuItem1
            // 
            this.blueToolStripMenuItem1.Name = "blueToolStripMenuItem1";
            this.blueToolStripMenuItem1.Size = new System.Drawing.Size(108, 22);
            this.blueToolStripMenuItem1.Text = "Blue";
            this.blueToolStripMenuItem1.Click += new System.EventHandler(this.blueToolStripMenuItem1_Click);
            // 
            // greenToolStripMenuItem1
            // 
            this.greenToolStripMenuItem1.Name = "greenToolStripMenuItem1";
            this.greenToolStripMenuItem1.Size = new System.Drawing.Size(108, 22);
            this.greenToolStripMenuItem1.Text = "Green";
            this.greenToolStripMenuItem1.Click += new System.EventHandler(this.greenToolStripMenuItem1_Click);
            // 
            // purpleToolStripMenuItem1
            // 
            this.purpleToolStripMenuItem1.Name = "purpleToolStripMenuItem1";
            this.purpleToolStripMenuItem1.Size = new System.Drawing.Size(108, 22);
            this.purpleToolStripMenuItem1.Text = "Purple";
            this.purpleToolStripMenuItem1.Click += new System.EventHandler(this.purpleToolStripMenuItem1_Click);
            // 
            // sizeToolStripMenuItem
            // 
            this.sizeToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.smallToolStripMenuItem,
            this.mediumToolStripMenuItem,
            this.bigToolStripMenuItem});
            this.sizeToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("sizeToolStripMenuItem.Image")));
            this.sizeToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Fuchsia;
            this.sizeToolStripMenuItem.Name = "sizeToolStripMenuItem";
            this.sizeToolStripMenuItem.Size = new System.Drawing.Size(103, 22);
            this.sizeToolStripMenuItem.Text = "Size";
            // 
            // smallToolStripMenuItem
            // 
            this.smallToolStripMenuItem.Name = "smallToolStripMenuItem";
            this.smallToolStripMenuItem.Size = new System.Drawing.Size(119, 22);
            this.smallToolStripMenuItem.Text = "Small";
            this.smallToolStripMenuItem.Click += new System.EventHandler(this.smallToolStripMenuItem_Click);
            // 
            // mediumToolStripMenuItem
            // 
            this.mediumToolStripMenuItem.Name = "mediumToolStripMenuItem";
            this.mediumToolStripMenuItem.Size = new System.Drawing.Size(119, 22);
            this.mediumToolStripMenuItem.Text = "Medium";
            this.mediumToolStripMenuItem.Click += new System.EventHandler(this.mediumToolStripMenuItem_Click);
            // 
            // bigToolStripMenuItem
            // 
            this.bigToolStripMenuItem.Name = "bigToolStripMenuItem";
            this.bigToolStripMenuItem.Size = new System.Drawing.Size(119, 22);
            this.bigToolStripMenuItem.Text = "Big";
            this.bigToolStripMenuItem.Click += new System.EventHandler(this.bigToolStripMenuItem_Click);
            // 
            // groupBoxRadioButtons
            // 
            this.groupBoxRadioButtons.Controls.Add(this.radioButtonAdd);
            this.groupBoxRadioButtons.Controls.Add(this.radioButtonDestroy);
            this.groupBoxRadioButtons.Controls.Add(this.radioButtonShowWeight);
            this.groupBoxRadioButtons.Controls.Add(this.radioButtonShowHeight);
            this.groupBoxRadioButtons.Location = new System.Drawing.Point(864, 74);
            this.groupBoxRadioButtons.Name = "groupBoxRadioButtons";
            this.groupBoxRadioButtons.Size = new System.Drawing.Size(102, 122);
            this.groupBoxRadioButtons.TabIndex = 8;
            this.groupBoxRadioButtons.TabStop = false;
            // 
            // panelAVLTree
            // 
            this.panelAVLTree.Location = new System.Drawing.Point(13, 28);
            this.panelAVLTree.Name = "panelAVLTree";
            this.panelAVLTree.Size = new System.Drawing.Size(831, 522);
            this.panelAVLTree.TabIndex = 9;
            this.panelAVLTree.Paint += new System.Windows.Forms.PaintEventHandler(this.panelAVLTree_Paint);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(984, 562);
            this.Controls.Add(this.panelAVLTree);
            this.Controls.Add(this.groupBoxRadioButtons);
            this.Controls.Add(this.buttonNew);
            this.Controls.Add(this.textBoxNode);
            this.Controls.Add(this.buttonDo);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "AVL Tree";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.groupBoxRadioButtons.ResumeLayout(false);
            this.groupBoxRadioButtons.PerformLayout();
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
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem colorToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sizeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem smallToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mediumToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem bigToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem newToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openToolStripMenuItem;
        private System.Windows.Forms.GroupBox groupBoxRadioButtons;
        private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem closeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem lineToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem nodeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem blackToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem blueToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem greenToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem purpleToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem blackToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem blueToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem greenToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem purpleToolStripMenuItem1;
        private System.Windows.Forms.Panel panelAVLTree;
    }
}

