namespace Day14_GUILists
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
            this.components = new System.ComponentModel.Container();
            this.list = new System.Windows.Forms.ListView();
            this.btnClick = new System.Windows.Forms.Button();
            this.textBox = new System.Windows.Forms.TextBox();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.RedText = new System.Windows.Forms.Label();
            this.btnUndo = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // list
            // 
            this.list.HideSelection = false;
            this.list.Location = new System.Drawing.Point(16, 31);
            this.list.Name = "list";
            this.list.Size = new System.Drawing.Size(192, 397);
            this.list.TabIndex = 0;
            this.toolTip1.SetToolTip(this.list, "Doubleclick to delete element");
            this.list.UseCompatibleStateImageBehavior = false;
            this.list.View = System.Windows.Forms.View.List;
            this.list.MouseClick += new System.Windows.Forms.MouseEventHandler(this.list_MouseClick);
            this.list.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.list_MouseDoubleClick);
            // 
            // btnClick
            // 
            this.btnClick.Location = new System.Drawing.Point(317, 77);
            this.btnClick.Name = "btnClick";
            this.btnClick.Size = new System.Drawing.Size(104, 25);
            this.btnClick.TabIndex = 1;
            this.btnClick.Text = "Submit";
            this.btnClick.UseVisualStyleBackColor = true;
            this.btnClick.Click += new System.EventHandler(this.btnClick_Click);
            // 
            // textBox
            // 
            this.textBox.Location = new System.Drawing.Point(237, 31);
            this.textBox.Name = "textBox";
            this.textBox.Size = new System.Drawing.Size(184, 20);
            this.textBox.TabIndex = 2;
            // 
            // RedText
            // 
            this.RedText.AutoSize = true;
            this.RedText.ForeColor = System.Drawing.Color.DarkRed;
            this.RedText.Location = new System.Drawing.Point(277, 54);
            this.RedText.Name = "RedText";
            this.RedText.Size = new System.Drawing.Size(0, 13);
            this.RedText.TabIndex = 3;
            // 
            // btnUndo
            // 
            this.btnUndo.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnUndo.Location = new System.Drawing.Point(317, 108);
            this.btnUndo.Name = "btnUndo";
            this.btnUndo.Size = new System.Drawing.Size(104, 25);
            this.btnUndo.TabIndex = 4;
            this.btnUndo.Text = "Undo";
            this.btnUndo.UseVisualStyleBackColor = true;
            this.btnUndo.Click += new System.EventHandler(this.btnUndo_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnDelete.Location = new System.Drawing.Point(317, 139);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(104, 25);
            this.btnDelete.TabIndex = 5;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.list);
            this.groupBox1.Controls.Add(this.RedText);
            this.groupBox1.Controls.Add(this.btnDelete);
            this.groupBox1.Controls.Add(this.textBox);
            this.groupBox1.Controls.Add(this.btnClick);
            this.groupBox1.Controls.Add(this.btnUndo);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(445, 445);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Data input";
            // 
            // Form1
            // 
            this.AcceptButton = this.btnClick;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(469, 469);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView list;
        private System.Windows.Forms.Button btnClick;
        private System.Windows.Forms.TextBox textBox;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.Label RedText;
        private System.Windows.Forms.Button btnUndo;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}

