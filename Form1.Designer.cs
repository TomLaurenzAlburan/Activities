namespace Alburan1
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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            StudentId = new TextBox();
            LastName = new TextBox();
            FirstName = new TextBox();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            ListStudentId = new ListBox();
            ListFirstName = new ListBox();
            ListLastName = new ListBox();
            SubmitButton = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(86, 43);
            label1.Name = "label1";
            label1.Size = new Size(102, 21);
            label1.TabIndex = 0;
            label1.Text = "Student ID *";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(413, 43);
            label2.Name = "label2";
            label2.Size = new Size(101, 21);
            label2.TabIndex = 1;
            label2.Text = "Last Name *";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(745, 43);
            label3.Name = "label3";
            label3.Size = new Size(103, 21);
            label3.TabIndex = 2;
            label3.Text = "First Name *";
            // 
            // StudentId
            // 
            StudentId.Location = new Point(24, 78);
            StudentId.Name = "StudentId";
            StudentId.Size = new Size(224, 23);
            StudentId.TabIndex = 3;
   
            // 
            // LastName
            // 
            LastName.Location = new Point(334, 78);
            LastName.Name = "LastName";
            LastName.Size = new Size(250, 23);
            LastName.TabIndex = 4;
      
            // 
            // FirstName
            // 
            FirstName.Location = new Point(666, 78);
            FirstName.Name = "FirstName";
            FirstName.Size = new Size(252, 23);
            FirstName.TabIndex = 5;
         
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(74, 189);
            label4.Name = "label4";
            label4.Size = new Size(125, 21);
            label4.TabIndex = 6;
            label4.Text = "Student ID List ";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.Location = new Point(401, 189);
            label5.Name = "label5";
            label5.Size = new Size(122, 21);
            label5.TabIndex = 7;
            label5.Text = "First Name List";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.Location = new Point(728, 189);
            label6.Name = "label6";
            label6.Size = new Size(120, 21);
            label6.TabIndex = 8;
            label6.Text = "Last Name List";
         
            // 
            // ListStudentId
            // 
            ListStudentId.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            ListStudentId.FormattingEnabled = true;
            ListStudentId.ItemHeight = 15;
            ListStudentId.Location = new Point(12, 230);
            ListStudentId.Name = "ListStudentId";
            ListStudentId.Size = new Size(253, 244);
            ListStudentId.TabIndex = 9;
         
            // 
            // ListFirstName
            // 
            ListFirstName.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            ListFirstName.FormattingEnabled = true;
            ListFirstName.ItemHeight = 15;
            ListFirstName.Location = new Point(334, 230);
            ListFirstName.Name = "ListFirstName";
            ListFirstName.Size = new Size(263, 244);
            ListFirstName.TabIndex = 10;
          
            // 
            // ListLastName
            // 
            ListLastName.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            ListLastName.FormattingEnabled = true;
            ListLastName.ItemHeight = 15;
            ListLastName.Location = new Point(666, 230);
            ListLastName.Name = "ListLastName";
            ListLastName.Size = new Size(270, 244);
            ListLastName.TabIndex = 11;
         
            // 
            // SubmitButton
            // 
            SubmitButton.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            SubmitButton.Location = new Point(806, 125);
            SubmitButton.Name = "SubmitButton";
            SubmitButton.Size = new Size(148, 32);
            SubmitButton.TabIndex = 12;
            SubmitButton.Text = "Submit";
            SubmitButton.UseVisualStyleBackColor = true;
            SubmitButton.Click += SubmitButton_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(980, 559);
            Controls.Add(SubmitButton);
            Controls.Add(ListLastName);
            Controls.Add(ListFirstName);
            Controls.Add(ListStudentId);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(FirstName);
            Controls.Add(LastName);
            Controls.Add(StudentId);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox StudentId;
        private TextBox LastName;
        private TextBox FirstName;
        private Label label4;
        private Label label5;
        private Label label6;
        private ListBox ListStudentId;
        private ListBox ListFirstName;
        private ListBox ListLastName;
        private Button SubmitButton;
    }
}
