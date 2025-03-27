namespace ScholarshipApp
{
    partial class Form1  // This should match the class name in Form1.cs
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

        private void InitializeComponent()
        {
            txtStudentName = new TextBox();
            txtStudentScore = new TextBox();
            btnAddStudent = new Button();
            btnShowScholarships = new Button();
            lstScholarships = new ListBox();
            SuspendLayout();
            // 
            // txtStudentName
            // 
            txtStudentName.Location = new Point(12, 12);
            txtStudentName.Name = "txtStudentName";
            txtStudentName.PlaceholderText = "Enter student name";
            txtStudentName.Size = new Size(150, 27);
            txtStudentName.TabIndex = 0;
            // 
            // txtStudentScore
            // 
            txtStudentScore.Location = new Point(168, 12);
            txtStudentScore.Name = "txtStudentScore";
            txtStudentScore.PlaceholderText = "Enter student score";
            txtStudentScore.Size = new Size(144, 35);
            txtStudentScore.TabIndex = 1;
            // 
            // btnAddStudent
            // 
            btnAddStudent.Location = new Point(25, 71);
            btnAddStudent.Name = "btnAddStudent";
            btnAddStudent.Size = new Size(260, 43);
            btnAddStudent.TabIndex = 2;
            btnAddStudent.Text = "Add Student";
            btnAddStudent.UseVisualStyleBackColor = true;
            btnAddStudent.Click += btnAddStudent_Click;
            // 
            // btnShowScholarships
            // 
            btnShowScholarships.Location = new Point(25, 133);
            btnShowScholarships.Name = "btnShowScholarships";
            btnShowScholarships.Size = new Size(260, 48);
            btnShowScholarships.TabIndex = 3;
            btnShowScholarships.Text = "Show Scholarship Recipients";
            btnShowScholarships.UseVisualStyleBackColor = true;
            btnShowScholarships.Click += btnShowScholarships_Click;
            // 
            // lstScholarships
            // 
            lstScholarships.FormattingEnabled = true;
            lstScholarships.Location = new Point(25, 201);
            lstScholarships.Name = "lstScholarships";
            lstScholarships.Size = new Size(260, 144);
            lstScholarships.TabIndex = 4;
            // 
            // Form1
            // 
            ClientSize = new Size(500, 357);
            Controls.Add(lstScholarships);
            Controls.Add(btnShowScholarships);
            Controls.Add(btnAddStudent);
            Controls.Add(txtStudentScore);
            Controls.Add(txtStudentName);
            Name = "Form1";
            Text = "Scholarship Program";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.TextBox txtStudentName;
        private System.Windows.Forms.TextBox txtStudentScore;
        private System.Windows.Forms.Button btnAddStudent;
        private System.Windows.Forms.Button btnShowScholarships;
        private System.Windows.Forms.ListBox lstScholarships;
    }
}
