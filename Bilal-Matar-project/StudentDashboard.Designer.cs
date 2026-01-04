namespace Bilal_Matar_project
{
    partial class StudentDashboard
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
            dgv_grades = new DataGridView();
            txt_Id = new TextBox();
            dgv_events = new DataGridView();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            ((System.ComponentModel.ISupportInitialize)dgv_grades).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgv_events).BeginInit();
            SuspendLayout();
            // 
            // dgv_grades
            // 
            dgv_grades.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgv_grades.Location = new Point(25, 109);
            dgv_grades.Name = "dgv_grades";
            dgv_grades.RowHeadersWidth = 51;
            dgv_grades.Size = new Size(510, 329);
            dgv_grades.TabIndex = 1;
            // 
            // txt_Id
            // 
            txt_Id.Location = new Point(25, 12);
            txt_Id.Name = "txt_Id";
            txt_Id.Size = new Size(125, 27);
            txt_Id.TabIndex = 0;
            // 
            // dgv_events
            // 
            dgv_events.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgv_events.Location = new Point(588, 109);
            dgv_events.Name = "dgv_events";
            dgv_events.RowHeadersWidth = 51;
            dgv_events.Size = new Size(510, 329);
            dgv_events.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(25, 54);
            label1.Name = "label1";
            label1.Size = new Size(50, 20);
            label1.TabIndex = 2;
            label1.Text = "label1";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(25, 86);
            label2.Name = "label2";
            label2.Size = new Size(55, 20);
            label2.TabIndex = 3;
            label2.Text = "Grades";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(588, 86);
            label3.Name = "label3";
            label3.Size = new Size(51, 20);
            label3.TabIndex = 3;
            label3.Text = "Events";
            // 
            // StudentDashboard
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1110, 450);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(dgv_events);
            Controls.Add(dgv_grades);
            Controls.Add(txt_Id);
            Name = "StudentDashboard";
            Text = "StudentDashboard";
            Load += StudentDashboard_Load;
            ((System.ComponentModel.ISupportInitialize)dgv_grades).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgv_events).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dgv_grades;
        private TextBox txt_Id;
        private DataGridView dgv_events;
        private Label label1;
        private Label label2;
        private Label label3;
    }
}