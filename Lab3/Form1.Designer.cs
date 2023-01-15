namespace Lab3
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.fileSystemWatcher1 = new System.IO.FileSystemWatcher();
            this.tb_Name = new System.Windows.Forms.TextBox();
            this.lb_Name = new System.Windows.Forms.Label();
            this.lb_Birth = new System.Windows.Forms.Label();
            this.tb_BirthYear = new System.Windows.Forms.TextBox();
            this.tb_Id = new System.Windows.Forms.TextBox();
            this.tb_Height = new System.Windows.Forms.TextBox();
            this.tb_Grade = new System.Windows.Forms.TextBox();
            this.tb_Subject = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.bt_Submit = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.dg_Name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dg_BirthYear = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dg_Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dg_Height = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dg_Grade = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dg_Subject = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tb_MaxGrade = new System.Windows.Forms.TextBox();
            this.tb_MinGrade = new System.Windows.Forms.TextBox();
            this.tb_CountSTD = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.fileSystemWatcher1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // fileSystemWatcher1
            // 
            this.fileSystemWatcher1.EnableRaisingEvents = true;
            this.fileSystemWatcher1.SynchronizingObject = this;
            this.fileSystemWatcher1.Changed += new System.IO.FileSystemEventHandler(this.fileSystemWatcher1_Changed);
            // 
            // tb_Name
            // 
            this.tb_Name.Location = new System.Drawing.Point(113, 41);
            this.tb_Name.Name = "tb_Name";
            this.tb_Name.Size = new System.Drawing.Size(125, 27);
            this.tb_Name.TabIndex = 0;
            this.tb_Name.TextChanged += new System.EventHandler(this.tb_Name_TextChanged);
            // 
            // lb_Name
            // 
            this.lb_Name.AutoSize = true;
            this.lb_Name.Location = new System.Drawing.Point(35, 44);
            this.lb_Name.Name = "lb_Name";
            this.lb_Name.Size = new System.Drawing.Size(49, 20);
            this.lb_Name.TabIndex = 1;
            this.lb_Name.Text = "Name";
            // 
            // lb_Birth
            // 
            this.lb_Birth.AutoSize = true;
            this.lb_Birth.Location = new System.Drawing.Point(271, 48);
            this.lb_Birth.Name = "lb_Birth";
            this.lb_Birth.Size = new System.Drawing.Size(72, 20);
            this.lb_Birth.TabIndex = 2;
            this.lb_Birth.Text = "Birth year";
            // 
            // tb_BirthYear
            // 
            this.tb_BirthYear.Location = new System.Drawing.Point(344, 41);
            this.tb_BirthYear.Name = "tb_BirthYear";
            this.tb_BirthYear.Size = new System.Drawing.Size(125, 27);
            this.tb_BirthYear.TabIndex = 3;
            // 
            // tb_Id
            // 
            this.tb_Id.Location = new System.Drawing.Point(593, 41);
            this.tb_Id.Name = "tb_Id";
            this.tb_Id.Size = new System.Drawing.Size(125, 27);
            this.tb_Id.TabIndex = 6;
            // 
            // tb_Height
            // 
            this.tb_Height.Location = new System.Drawing.Point(113, 88);
            this.tb_Height.Name = "tb_Height";
            this.tb_Height.Size = new System.Drawing.Size(125, 27);
            this.tb_Height.TabIndex = 7;
            // 
            // tb_Grade
            // 
            this.tb_Grade.Location = new System.Drawing.Point(344, 88);
            this.tb_Grade.Name = "tb_Grade";
            this.tb_Grade.Size = new System.Drawing.Size(125, 27);
            this.tb_Grade.TabIndex = 8;
            // 
            // tb_Subject
            // 
            this.tb_Subject.Location = new System.Drawing.Point(593, 88);
            this.tb_Subject.Name = "tb_Subject";
            this.tb_Subject.Size = new System.Drawing.Size(125, 27);
            this.tb_Subject.TabIndex = 9;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(523, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(22, 20);
            this.label1.TabIndex = 10;
            this.label1.Text = "Id";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(35, 91);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(54, 20);
            this.label2.TabIndex = 11;
            this.label2.Text = "Height";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(271, 91);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(49, 20);
            this.label3.TabIndex = 12;
            this.label3.Text = "Grade";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(499, 91);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(58, 20);
            this.label4.TabIndex = 13;
            this.label4.Text = "Subject";
            // 
            // bt_Submit
            // 
            this.bt_Submit.Location = new System.Drawing.Point(358, 124);
            this.bt_Submit.Name = "bt_Submit";
            this.bt_Submit.Size = new System.Drawing.Size(98, 52);
            this.bt_Submit.TabIndex = 14;
            this.bt_Submit.Text = "Submit";
            this.bt_Submit.UseVisualStyleBackColor = true;
            this.bt_Submit.Click += new System.EventHandler(this.bt_Submit_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dg_Name,
            this.dg_BirthYear,
            this.dg_Id,
            this.dg_Height,
            this.dg_Grade,
            this.dg_Subject});
            this.dataGridView1.Location = new System.Drawing.Point(25, 251);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 29;
            this.dataGridView1.Size = new System.Drawing.Size(807, 188);
            this.dataGridView1.TabIndex = 15;
            // 
            // dg_Name
            // 
            this.dg_Name.DataPropertyName = "dp_Name";
            this.dg_Name.HeaderText = "Name";
            this.dg_Name.MinimumWidth = 6;
            this.dg_Name.Name = "dg_Name";
            this.dg_Name.ReadOnly = true;
            this.dg_Name.Width = 125;
            // 
            // dg_BirthYear
            // 
            this.dg_BirthYear.DataPropertyName = "dp_BirthYear";
            this.dg_BirthYear.HeaderText = "BirthYear";
            this.dg_BirthYear.MinimumWidth = 6;
            this.dg_BirthYear.Name = "dg_BirthYear";
            this.dg_BirthYear.ReadOnly = true;
            this.dg_BirthYear.Width = 125;
            // 
            // dg_Id
            // 
            this.dg_Id.DataPropertyName = "dp_Id";
            this.dg_Id.HeaderText = "Id";
            this.dg_Id.MinimumWidth = 6;
            this.dg_Id.Name = "dg_Id";
            this.dg_Id.ReadOnly = true;
            this.dg_Id.Width = 125;
            // 
            // dg_Height
            // 
            this.dg_Height.DataPropertyName = "dp_Height";
            this.dg_Height.HeaderText = "Height";
            this.dg_Height.MinimumWidth = 6;
            this.dg_Height.Name = "dg_Height";
            this.dg_Height.ReadOnly = true;
            this.dg_Height.Width = 125;
            // 
            // dg_Grade
            // 
            this.dg_Grade.DataPropertyName = "dp_Grade";
            this.dg_Grade.HeaderText = "Grade";
            this.dg_Grade.MinimumWidth = 6;
            this.dg_Grade.Name = "dg_Grade";
            this.dg_Grade.ReadOnly = true;
            this.dg_Grade.Width = 125;
            // 
            // dg_Subject
            // 
            this.dg_Subject.DataPropertyName = "dp_Subject";
            this.dg_Subject.HeaderText = "Subject";
            this.dg_Subject.MinimumWidth = 6;
            this.dg_Subject.Name = "dg_Subject";
            this.dg_Subject.ReadOnly = true;
            this.dg_Subject.Width = 125;
            // 
            // tb_MaxGrade
            // 
            this.tb_MaxGrade.Location = new System.Drawing.Point(113, 191);
            this.tb_MaxGrade.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tb_MaxGrade.Name = "tb_MaxGrade";
            this.tb_MaxGrade.Size = new System.Drawing.Size(125, 27);
            this.tb_MaxGrade.TabIndex = 16;
            // 
            // tb_MinGrade
            // 
            this.tb_MinGrade.Location = new System.Drawing.Point(344, 191);
            this.tb_MinGrade.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tb_MinGrade.Name = "tb_MinGrade";
            this.tb_MinGrade.Size = new System.Drawing.Size(125, 27);
            this.tb_MinGrade.TabIndex = 17;
            // 
            // tb_CountSTD
            // 
            this.tb_CountSTD.Location = new System.Drawing.Point(593, 191);
            this.tb_CountSTD.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tb_CountSTD.Name = "tb_CountSTD";
            this.tb_CountSTD.Size = new System.Drawing.Size(125, 27);
            this.tb_CountSTD.TabIndex = 18;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(35, 201);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(82, 20);
            this.label5.TabIndex = 19;
            this.label5.Text = "MostGrade";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(262, 201);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(83, 20);
            this.label6.TabIndex = 20;
            this.label6.Text = "LeastGrade";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(506, 201);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(48, 20);
            this.label7.TabIndex = 21;
            this.label7.Text = "Count";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(942, 451);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.tb_CountSTD);
            this.Controls.Add(this.tb_MinGrade);
            this.Controls.Add(this.tb_MaxGrade);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.bt_Submit);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tb_Subject);
            this.Controls.Add(this.tb_Grade);
            this.Controls.Add(this.tb_Height);
            this.Controls.Add(this.tb_Id);
            this.Controls.Add(this.tb_BirthYear);
            this.Controls.Add(this.lb_Birth);
            this.Controls.Add(this.lb_Name);
            this.Controls.Add(this.tb_Name);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.fileSystemWatcher1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private FileSystemWatcher fileSystemWatcher1;
        private TextBox tb_Name;
        private TextBox tb_BirthYear;
        private Label lb_Birth;
        private Label lb_Name;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private TextBox tb_Subject;
        private TextBox tb_Grade;
        private TextBox tb_Height;
        private TextBox tb_Id;
        private Button bt_Submit;
        private DataGridView dataGridView1;
        private DataGridViewTextBoxColumn dg_Name;
        private DataGridViewTextBoxColumn dg_BirthYear;
        private DataGridViewTextBoxColumn dg_Id;
        private DataGridViewTextBoxColumn dg_Height;
        private DataGridViewTextBoxColumn dg_Grade;
        private DataGridViewTextBoxColumn dg_Subject;
        private TextBox tb_CountSTD;
        private TextBox tb_MinGrade;
        private TextBox tb_MaxGrade;
        private Label label6;
        private Label label5;
        private Label label7;
    }
}