using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Alburan1
{
    public partial class Form1 : Form
    {
        // Lists to store student data
        private List<string> StudentIds = new List<string>();
        private List<string> FirstNames = new List<string>();
        private List<string> LastNames = new List<string>();

        public Form1()
        {
            InitializeComponent();
        }

        
        private void SubmitButton_Click(object sender, EventArgs e)
        {
            string studentID = StudentId.Text;
            string firstName = FirstName.Text;
            string lastName = LastName.Text;

             
            if (string.IsNullOrEmpty(studentID) || string.IsNullOrEmpty(firstName) || string.IsNullOrEmpty(lastName))
            {
                MessageBox.Show("Please fill in all the fields marked with *");
                return;
            }

            
            StudentIds.Add(studentID);
            FirstNames.Add(firstName);
            LastNames.Add(lastName);

            
            StudentId.Clear();
            FirstName.Clear();
            LastName.Clear();

            
            UpdateListBoxes();
        }

        
        private void UpdateListBoxes()
        {
            // Clear existing items
            ListStudentId.Items.Clear();
            ListFirstName.Items.Clear();
            ListLastName.Items.Clear();

            
            for (int i = 0; i < StudentIds.Count; i++)
            {
                ListStudentId.Items.Add(StudentIds[i]);
                ListFirstName.Items.Add(FirstNames[i]);
                ListLastName.Items.Add(LastNames[i]);
            }
        }

    }
}