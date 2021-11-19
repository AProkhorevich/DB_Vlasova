namespace LinqFormPMI32
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
        /// the contents of this method with the StudentId editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.openToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.workerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.salaryToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dgStudnets = new System.Windows.Forms.DataGridView();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.dgCourseWork = new System.Windows.Forms.DataGridView();
            this.btnAfter2000 = new System.Windows.Forms.Button();
            this.dgMoreThen3 = new System.Windows.Forms.DataGridView();
            this.StudentsWithSameProfessor = new System.Windows.Forms.Button();
            this.MarkBiggerThen3 = new System.Windows.Forms.Button();
            this.dgBornAfter2000 = new System.Windows.Forms.DataGridView();
            this.dgStudentsWithSameProfessor = new System.Windows.Forms.DataGridView();
            this.dgSorted = new System.Windows.Forms.DataGridView();
            this.btnSort = new System.Windows.Forms.Button();
            this.btnAvg = new System.Windows.Forms.Button();
            this.tbAvg = new System.Windows.Forms.TextBox();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgStudnets)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgCourseWork)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgMoreThen3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgBornAfter2000)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgStudentsWithSameProfessor)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgSorted)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.openToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1444, 28);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // openToolStripMenuItem
            // 
            this.openToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.workerToolStripMenuItem,
            this.salaryToolStripMenuItem});
            this.openToolStripMenuItem.Name = "openToolStripMenuItem";
            this.openToolStripMenuItem.Size = new System.Drawing.Size(59, 24);
            this.openToolStripMenuItem.Text = "Open";
            // 
            // workerToolStripMenuItem
            // 
            this.workerToolStripMenuItem.Name = "workerToolStripMenuItem";
            this.workerToolStripMenuItem.Size = new System.Drawing.Size(169, 26);
            this.workerToolStripMenuItem.Text = "Student";
            this.workerToolStripMenuItem.Click += new System.EventHandler(this.StudentToolStripMenuItem_Click);
            // 
            // salaryToolStripMenuItem
            // 
            this.salaryToolStripMenuItem.Name = "salaryToolStripMenuItem";
            this.salaryToolStripMenuItem.Size = new System.Drawing.Size(169, 26);
            this.salaryToolStripMenuItem.Text = "Сoursework";
            this.salaryToolStripMenuItem.Click += new System.EventHandler(this.SalaryToolStripMenuItem_Click);
            // 
            // dgStudnets
            // 
            this.dgStudnets.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgStudnets.Location = new System.Drawing.Point(37, 57);
            this.dgStudnets.Margin = new System.Windows.Forms.Padding(4);
            this.dgStudnets.Name = "dgStudnets";
            this.dgStudnets.RowHeadersWidth = 51;
            this.dgStudnets.Size = new System.Drawing.Size(608, 207);
            this.dgStudnets.TabIndex = 1;
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // dgCourseWork
            // 
            this.dgCourseWork.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgCourseWork.Location = new System.Drawing.Point(37, 300);
            this.dgCourseWork.Margin = new System.Windows.Forms.Padding(4);
            this.dgCourseWork.Name = "dgCourseWork";
            this.dgCourseWork.RowHeadersWidth = 51;
            this.dgCourseWork.Size = new System.Drawing.Size(608, 197);
            this.dgCourseWork.TabIndex = 2;
            // 
            // btnAfter2000
            // 
            this.btnAfter2000.Location = new System.Drawing.Point(1041, 122);
            this.btnAfter2000.Margin = new System.Windows.Forms.Padding(4);
            this.btnAfter2000.Name = "btnAfter2000";
            this.btnAfter2000.Size = new System.Drawing.Size(143, 58);
            this.btnAfter2000.TabIndex = 3;
            this.btnAfter2000.Text = "Born > 2000";
            this.btnAfter2000.UseVisualStyleBackColor = true;
            this.btnAfter2000.Click += new System.EventHandler(this.btnAfter2000_Click);
            // 
            // dgMoreThen3
            // 
            this.dgMoreThen3.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgMoreThen3.Location = new System.Drawing.Point(705, 57);
            this.dgMoreThen3.Margin = new System.Windows.Forms.Padding(4);
            this.dgMoreThen3.Name = "dgMoreThen3";
            this.dgMoreThen3.RowHeadersWidth = 51;
            this.dgMoreThen3.Size = new System.Drawing.Size(328, 207);
            this.dgMoreThen3.TabIndex = 4;
            // 
            // StudentsWithSameProfessor
            // 
            this.StudentsWithSameProfessor.Location = new System.Drawing.Point(1041, 187);
            this.StudentsWithSameProfessor.Margin = new System.Windows.Forms.Padding(4);
            this.StudentsWithSameProfessor.Name = "StudentsWithSameProfessor";
            this.StudentsWithSameProfessor.Size = new System.Drawing.Size(143, 58);
            this.StudentsWithSameProfessor.TabIndex = 5;
            this.StudentsWithSameProfessor.Text = "Count students with same professor";
            this.StudentsWithSameProfessor.UseVisualStyleBackColor = true;
            this.StudentsWithSameProfessor.Click += new System.EventHandler(this.StudentsWithSameProfessor_Click);
            // 
            // MarkBiggerThen3
            // 
            this.MarkBiggerThen3.Location = new System.Drawing.Point(1041, 57);
            this.MarkBiggerThen3.Margin = new System.Windows.Forms.Padding(4);
            this.MarkBiggerThen3.Name = "MarkBiggerThen3";
            this.MarkBiggerThen3.Size = new System.Drawing.Size(143, 58);
            this.MarkBiggerThen3.TabIndex = 6;
            this.MarkBiggerThen3.Text = "Marks > 3";
            this.MarkBiggerThen3.UseVisualStyleBackColor = true;
            this.MarkBiggerThen3.Click += new System.EventHandler(this.MarkBiggerThen3_Click);
            // 
            // dgBornAfter2000
            // 
            this.dgBornAfter2000.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgBornAfter2000.Location = new System.Drawing.Point(705, 300);
            this.dgBornAfter2000.Margin = new System.Windows.Forms.Padding(4);
            this.dgBornAfter2000.Name = "dgBornAfter2000";
            this.dgBornAfter2000.RowHeadersWidth = 51;
            this.dgBornAfter2000.Size = new System.Drawing.Size(328, 197);
            this.dgBornAfter2000.TabIndex = 7;
            // 
            // dgStudentsWithSameProfessor
            // 
            this.dgStudentsWithSameProfessor.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgStudentsWithSameProfessor.Location = new System.Drawing.Point(37, 521);
            this.dgStudentsWithSameProfessor.Margin = new System.Windows.Forms.Padding(4);
            this.dgStudentsWithSameProfessor.Name = "dgStudentsWithSameProfessor";
            this.dgStudentsWithSameProfessor.RowHeadersWidth = 51;
            this.dgStudentsWithSameProfessor.Size = new System.Drawing.Size(328, 197);
            this.dgStudentsWithSameProfessor.TabIndex = 8;
            // 
            // dgSorted
            // 
            this.dgSorted.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgSorted.Location = new System.Drawing.Point(486, 521);
            this.dgSorted.Margin = new System.Windows.Forms.Padding(4);
            this.dgSorted.Name = "dgSorted";
            this.dgSorted.RowHeadersWidth = 51;
            this.dgSorted.Size = new System.Drawing.Size(282, 197);
            this.dgSorted.TabIndex = 9;
            // 
            // btnSort
            // 
            this.btnSort.Location = new System.Drawing.Point(1041, 253);
            this.btnSort.Margin = new System.Windows.Forms.Padding(4);
            this.btnSort.Name = "btnSort";
            this.btnSort.Size = new System.Drawing.Size(143, 58);
            this.btnSort.TabIndex = 10;
            this.btnSort.Text = "Sort by name";
            this.btnSort.UseVisualStyleBackColor = true;
            this.btnSort.Click += new System.EventHandler(this.btnSort_Click);
            // 
            // btnAvg
            // 
            this.btnAvg.Location = new System.Drawing.Point(1041, 319);
            this.btnAvg.Margin = new System.Windows.Forms.Padding(4);
            this.btnAvg.Name = "btnAvg";
            this.btnAvg.Size = new System.Drawing.Size(143, 58);
            this.btnAvg.TabIndex = 12;
            this.btnAvg.Text = "Avg marks on course 3";
            this.btnAvg.UseVisualStyleBackColor = true;
            this.btnAvg.Click += new System.EventHandler(this.btnAvg_Click);
            // 
            // tbAvg
            // 
            this.tbAvg.Location = new System.Drawing.Point(1050, 384);
            this.tbAvg.Name = "tbAvg";
            this.tbAvg.Size = new System.Drawing.Size(134, 22);
            this.tbAvg.TabIndex = 14;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1444, 731);
            this.Controls.Add(this.tbAvg);
            this.Controls.Add(this.btnAvg);
            this.Controls.Add(this.btnSort);
            this.Controls.Add(this.dgSorted);
            this.Controls.Add(this.dgStudentsWithSameProfessor);
            this.Controls.Add(this.dgBornAfter2000);
            this.Controls.Add(this.MarkBiggerThen3);
            this.Controls.Add(this.StudentsWithSameProfessor);
            this.Controls.Add(this.dgMoreThen3);
            this.Controls.Add(this.btnAfter2000);
            this.Controls.Add(this.dgCourseWork);
            this.Controls.Add(this.dgStudnets);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.Text = "Form1";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgStudnets)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgCourseWork)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgMoreThen3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgBornAfter2000)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgStudentsWithSameProfessor)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgSorted)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem openToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem workerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem salaryToolStripMenuItem;
        private System.Windows.Forms.DataGridView dgStudnets;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.DataGridView dgCourseWork;
        private System.Windows.Forms.Button btnAfter2000;
        private System.Windows.Forms.DataGridView dgMoreThen3;
        private System.Windows.Forms.Button StudentsWithSameProfessor;
        private System.Windows.Forms.Button MarkBiggerThen3;
        private System.Windows.Forms.DataGridView dgBornAfter2000;
        private System.Windows.Forms.DataGridView dgStudentsWithSameProfessor;
        private System.Windows.Forms.DataGridView dgSorted;
        private System.Windows.Forms.Button btnSort;
        private System.Windows.Forms.Button btnAvg;
        private System.Windows.Forms.TextBox tbAvg;
    }
}

