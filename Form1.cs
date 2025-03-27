using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace ScholarshipApp
{
    public partial class Form1 : Form
    {
        // List to store student names
        private List<string> studentNames = new List<string>();
        // List to store student scores
        private List<int> studentScores = new List<int>();

        public Form1()
        {
            InitializeComponent();
        }

        // Method to add student name and score to the lists
        private void AddStudent(string name, int score)
        {
            studentNames.Add(name);
            studentScores.Add(score);
        }

        // Method to check and display students who qualify for the scholarship
        private void DisplayScholarships()
        {
            lstScholarships.Items.Clear();  // Clear the ListBox before displaying

            for (int i = 0; i < studentNames.Count; i++)
            {
                if (studentScores[i] >= 85)  // Scholarship eligibility condition (score >= 85)
                {
                    lstScholarships.Items.Add(studentNames[i] + " - Score: " + studentScores[i]);
                }
            }
        }

        // Method to handle the "Add Student" button click event
        private void btnAddStudent_Click(object sender, EventArgs e)
        {
            string name = txtStudentName.Text;
            if (int.TryParse(txtStudentScore.Text, out int score)) // Check if score is a valid number
            {
                AddStudent(name, score);  // Add student to the list
                txtStudentName.Clear();  // Clear the text boxes
                txtStudentScore.Clear();
            }
            else
            {
                MessageBox.Show("Please enter a valid score.");
            }
        }

        // Method to handle the "Show Scholarship Recipients" button click event
        private void btnShowScholarships_Click(object sender, EventArgs e)
        {
            DisplayScholarships();  // Display the scholarship recipients
        }
    }
}
