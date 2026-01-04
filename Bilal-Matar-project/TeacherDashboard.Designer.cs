namespace Bilal_Matar_project
{
    partial class TeacherDashboard
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
            txt_id = new TextBox();
            label1 = new Label();
            cb_student = new ComboBox();
            label2 = new Label();
            label3 = new Label();
            nd_grade = new NumericUpDown();
            btn_grade = new Button();
            dgv_students = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)nd_grade).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgv_students).BeginInit();
            SuspendLayout();
            // 
            // txt_id
            // 
            txt_id.Location = new Point(139, 13);
            txt_id.Name = "txt_id";
            txt_id.Size = new Size(172, 27);
            txt_id.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 16);
            label1.Name = "label1";
            label1.Size = new Size(79, 20);
            label1.TabIndex = 1;
            label1.Text = "Teacher ID";
            // 
            // cb_student
            // 
            cb_student.FormattingEnabled = true;
            cb_student.Location = new Point(139, 64);
            cb_student.Name = "cb_student";
            cb_student.Size = new Size(172, 28);
            cb_student.TabIndex = 2;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 67);
            label2.Name = "label2";
            label2.Size = new Size(114, 20);
            label2.TabIndex = 1;
            label2.Text = "Select a student";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(12, 121);
            label3.Name = "label3";
            label3.Size = new Size(101, 20);
            label3.TabIndex = 1;
            label3.Text = "Update grade";
            // 
            // nd_grade
            // 
            nd_grade.Location = new Point(139, 119);
            nd_grade.Name = "nd_grade";
            nd_grade.Size = new Size(172, 27);
            nd_grade.TabIndex = 3;
            // 
            // btn_grade
            // 
            btn_grade.Location = new Point(328, 117);
            btn_grade.Name = "btn_grade";
            btn_grade.Size = new Size(94, 29);
            btn_grade.TabIndex = 4;
            btn_grade.Text = "Update";
            btn_grade.UseVisualStyleBackColor = true;
            btn_grade.Click += btn_grade_Click;
            // 
            // dgv_students
            // 
            dgv_students.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgv_students.Location = new Point(12, 171);
            dgv_students.Name = "dgv_students";
            dgv_students.RowHeadersWidth = 51;
            dgv_students.Size = new Size(767, 267);
            dgv_students.TabIndex = 5;
            // 
            // TeacherDashboard
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(dgv_students);
            Controls.Add(btn_grade);
            Controls.Add(nd_grade);
            Controls.Add(cb_student);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(txt_id);
            Name = "TeacherDashboard";
            Text = "TeacherDashboard";
            Load += TeacherDashboard_Load;
            ((System.ComponentModel.ISupportInitialize)nd_grade).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgv_students).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txt_id;
        private Label label1;
        private ComboBox cb_student;
        private Label label2;
        private Label label3;
        private NumericUpDown nd_grade;
        private Button btn_grade;
        private DataGridView dgv_students;
    }
}