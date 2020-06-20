namespace Day22_GUI_DB
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
            this.listView = new System.Windows.Forms.ListView();
            this.btnOpen = new System.Windows.Forms.Button();
            this.tbName = new System.Windows.Forms.TextBox();
            this.tbSurname = new System.Windows.Forms.TextBox();
            this.tbJobId = new System.Windows.Forms.TextBox();
            this.lblName = new System.Windows.Forms.Label();
            this.lblSurname = new System.Windows.Forms.Label();
            this.lblJobId = new System.Windows.Forms.Label();
            this.tbMin = new System.Windows.Forms.TextBox();
            this.lblMin = new System.Windows.Forms.Label();
            this.tbMax = new System.Windows.Forms.TextBox();
            this.lblMax = new System.Windows.Forms.Label();
            this.btnAdd = new System.Windows.Forms.Button();
            this.tbSalary = new System.Windows.Forms.TextBox();
            this.lblSalary = new System.Windows.Forms.Label();
            this.tbDepartmentId = new System.Windows.Forms.TextBox();
            this.lblDepartment = new System.Windows.Forms.Label();
            this.btnRemove = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // listView
            // 
            this.listView.HideSelection = false;
            this.listView.Location = new System.Drawing.Point(12, 85);
            this.listView.Name = "listView";
            this.listView.Size = new System.Drawing.Size(238, 405);
            this.listView.TabIndex = 0;
            this.listView.UseCompatibleStateImageBehavior = false;
            this.listView.View = System.Windows.Forms.View.List;
            this.listView.DoubleClick += new System.EventHandler(this.listView_DoubleClick);
            // 
            // btnOpen
            // 
            this.btnOpen.Location = new System.Drawing.Point(12, 33);
            this.btnOpen.Name = "btnOpen";
            this.btnOpen.Size = new System.Drawing.Size(238, 32);
            this.btnOpen.TabIndex = 1;
            this.btnOpen.Text = "Refresh";
            this.btnOpen.UseVisualStyleBackColor = true;
            this.btnOpen.Click += new System.EventHandler(this.btnOpen_Click);
            // 
            // tbName
            // 
            this.tbName.Location = new System.Drawing.Point(362, 93);
            this.tbName.Name = "tbName";
            this.tbName.Size = new System.Drawing.Size(211, 20);
            this.tbName.TabIndex = 2;
            // 
            // tbSurname
            // 
            this.tbSurname.Location = new System.Drawing.Point(362, 119);
            this.tbSurname.Name = "tbSurname";
            this.tbSurname.Size = new System.Drawing.Size(211, 20);
            this.tbSurname.TabIndex = 3;
            // 
            // tbJobId
            // 
            this.tbJobId.Location = new System.Drawing.Point(362, 145);
            this.tbJobId.Name = "tbJobId";
            this.tbJobId.Size = new System.Drawing.Size(211, 20);
            this.tbJobId.TabIndex = 4;
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(271, 96);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(35, 13);
            this.lblName.TabIndex = 5;
            this.lblName.Text = "Name";
            // 
            // lblSurname
            // 
            this.lblSurname.AutoSize = true;
            this.lblSurname.Location = new System.Drawing.Point(271, 122);
            this.lblSurname.Name = "lblSurname";
            this.lblSurname.Size = new System.Drawing.Size(49, 13);
            this.lblSurname.TabIndex = 6;
            this.lblSurname.Text = "Surname";
            // 
            // lblJobId
            // 
            this.lblJobId.AutoSize = true;
            this.lblJobId.Location = new System.Drawing.Point(271, 148);
            this.lblJobId.Name = "lblJobId";
            this.lblJobId.Size = new System.Drawing.Size(38, 13);
            this.lblJobId.TabIndex = 7;
            this.lblJobId.Text = "Job ID";
            // 
            // tbMin
            // 
            this.tbMin.Location = new System.Drawing.Point(362, 197);
            this.tbMin.Name = "tbMin";
            this.tbMin.Size = new System.Drawing.Size(211, 20);
            this.tbMin.TabIndex = 8;
            // 
            // lblMin
            // 
            this.lblMin.AutoSize = true;
            this.lblMin.Location = new System.Drawing.Point(271, 200);
            this.lblMin.Name = "lblMin";
            this.lblMin.Size = new System.Drawing.Size(77, 13);
            this.lblMin.TabIndex = 9;
            this.lblMin.Text = "Minimum wage";
            // 
            // tbMax
            // 
            this.tbMax.Location = new System.Drawing.Point(362, 226);
            this.tbMax.Name = "tbMax";
            this.tbMax.Size = new System.Drawing.Size(211, 20);
            this.tbMax.TabIndex = 10;
            // 
            // lblMax
            // 
            this.lblMax.AutoSize = true;
            this.lblMax.Location = new System.Drawing.Point(271, 226);
            this.lblMax.Name = "lblMax";
            this.lblMax.Size = new System.Drawing.Size(80, 13);
            this.lblMax.TabIndex = 11;
            this.lblMax.Text = "Maximum wage";
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(309, 317);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(238, 32);
            this.btnAdd.TabIndex = 12;
            this.btnAdd.Text = "Add Employee";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // tbSalary
            // 
            this.tbSalary.Location = new System.Drawing.Point(362, 252);
            this.tbSalary.Name = "tbSalary";
            this.tbSalary.Size = new System.Drawing.Size(211, 20);
            this.tbSalary.TabIndex = 13;
            // 
            // lblSalary
            // 
            this.lblSalary.AutoSize = true;
            this.lblSalary.Location = new System.Drawing.Point(271, 255);
            this.lblSalary.Name = "lblSalary";
            this.lblSalary.Size = new System.Drawing.Size(36, 13);
            this.lblSalary.TabIndex = 14;
            this.lblSalary.Text = "Salary";
            // 
            // tbDepartmentId
            // 
            this.tbDepartmentId.Location = new System.Drawing.Point(362, 171);
            this.tbDepartmentId.Name = "tbDepartmentId";
            this.tbDepartmentId.Size = new System.Drawing.Size(211, 20);
            this.tbDepartmentId.TabIndex = 15;
            // 
            // lblDepartment
            // 
            this.lblDepartment.AutoSize = true;
            this.lblDepartment.Location = new System.Drawing.Point(271, 174);
            this.lblDepartment.Name = "lblDepartment";
            this.lblDepartment.Size = new System.Drawing.Size(76, 13);
            this.lblDepartment.TabIndex = 16;
            this.lblDepartment.Text = "Department ID";
            // 
            // btnRemove
            // 
            this.btnRemove.Location = new System.Drawing.Point(309, 355);
            this.btnRemove.Name = "btnRemove";
            this.btnRemove.Size = new System.Drawing.Size(238, 32);
            this.btnRemove.TabIndex = 17;
            this.btnRemove.Text = "Delete";
            this.btnRemove.UseVisualStyleBackColor = true;
            this.btnRemove.Click += new System.EventHandler(this.btnRemove_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(607, 511);
            this.Controls.Add(this.btnRemove);
            this.Controls.Add(this.lblDepartment);
            this.Controls.Add(this.tbDepartmentId);
            this.Controls.Add(this.lblSalary);
            this.Controls.Add(this.tbSalary);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.lblMax);
            this.Controls.Add(this.tbMax);
            this.Controls.Add(this.lblMin);
            this.Controls.Add(this.tbMin);
            this.Controls.Add(this.lblJobId);
            this.Controls.Add(this.lblSurname);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.tbJobId);
            this.Controls.Add(this.tbSurname);
            this.Controls.Add(this.tbName);
            this.Controls.Add(this.btnOpen);
            this.Controls.Add(this.listView);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView listView;
        private System.Windows.Forms.Button btnOpen;
        private System.Windows.Forms.TextBox tbName;
        private System.Windows.Forms.TextBox tbSurname;
        private System.Windows.Forms.TextBox tbJobId;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblSurname;
        private System.Windows.Forms.Label lblJobId;
        private System.Windows.Forms.TextBox tbMin;
        private System.Windows.Forms.Label lblMin;
        private System.Windows.Forms.TextBox tbMax;
        private System.Windows.Forms.Label lblMax;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.TextBox tbSalary;
        private System.Windows.Forms.Label lblSalary;
        private System.Windows.Forms.TextBox tbDepartmentId;
        private System.Windows.Forms.Label lblDepartment;
        private System.Windows.Forms.Button btnRemove;
    }
}

