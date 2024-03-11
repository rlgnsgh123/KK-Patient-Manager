namespace KKPatientManger
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
			btnStartNote = new Button();
			listBoxPatient = new ListBox();
			lblStatus = new Label();
			label6 = new Label();
			label7 = new Label();
			btnAddProblem = new Button();
			btnAddNote = new Button();
			btnUpdateNote = new Button();
			btnDeleteNote = new Button();
			listBoxProblem = new ListBox();
			listBoxBP = new ListBox();
			label2 = new Label();
			label3 = new Label();
			label4 = new Label();
			label5 = new Label();
			rTxtBoxNote = new RichTextBox();
			txtBoxID = new TextBox();
			txtName = new TextBox();
			txtBoxProblem = new TextBox();
			dateTimePicker = new DateTimePicker();
			groupBox1 = new GroupBox();
			label1 = new Label();
			groupBox1.SuspendLayout();
			SuspendLayout();
			// 
			// btnStartNote
			// 
			btnStartNote.Font = new Font("Arial", 9F, FontStyle.Regular, GraphicsUnit.Point);
			btnStartNote.Location = new Point(38, 35);
			btnStartNote.Margin = new Padding(3, 4, 3, 4);
			btnStartNote.Name = "btnStartNote";
			btnStartNote.Size = new Size(146, 39);
			btnStartNote.TabIndex = 0;
			btnStartNote.Text = "Start new patient";
			btnStartNote.UseVisualStyleBackColor = true;
			btnStartNote.Click += btnStartNote_Click;
			// 
			// listBoxPatient
			// 
			listBoxPatient.Font = new Font("Arial", 9F, FontStyle.Regular, GraphicsUnit.Point);
			listBoxPatient.FormattingEnabled = true;
			listBoxPatient.ItemHeight = 17;
			listBoxPatient.Location = new Point(12, 108);
			listBoxPatient.Margin = new Padding(3, 4, 3, 4);
			listBoxPatient.Name = "listBoxPatient";
			listBoxPatient.Size = new Size(208, 497);
			listBoxPatient.TabIndex = 5;
			listBoxPatient.SelectedIndexChanged += listBoxPatient_SelectedIndexChanged;
			// 
			// lblStatus
			// 
			lblStatus.AutoSize = true;
			lblStatus.Font = new Font("Arial", 9F, FontStyle.Regular, GraphicsUnit.Point);
			lblStatus.Location = new Point(38, 626);
			lblStatus.Name = "lblStatus";
			lblStatus.Size = new Size(48, 17);
			lblStatus.TabIndex = 8;
			lblStatus.Text = "status";
			// 
			// label6
			// 
			label6.AutoSize = true;
			label6.Location = new Point(453, 22);
			label6.Name = "label6";
			label6.Size = new Size(79, 17);
			label6.TabIndex = 13;
			label6.Text = "Symtomps";
			// 
			// label7
			// 
			label7.AutoSize = true;
			label7.Location = new Point(625, 22);
			label7.Name = "label7";
			label7.Size = new Size(125, 17);
			label7.TabIndex = 14;
			label7.Text = "BP Measurement:";
			// 
			// btnAddProblem
			// 
			btnAddProblem.Location = new Point(317, 204);
			btnAddProblem.Margin = new Padding(3, 4, 3, 4);
			btnAddProblem.Name = "btnAddProblem";
			btnAddProblem.Size = new Size(115, 39);
			btnAddProblem.TabIndex = 1;
			btnAddProblem.Text = "Add Symptom";
			btnAddProblem.UseVisualStyleBackColor = true;
			btnAddProblem.Click += btnAddProblem_Click;
			// 
			// btnAddNote
			// 
			btnAddNote.Location = new Point(22, 521);
			btnAddNote.Margin = new Padding(3, 4, 3, 4);
			btnAddNote.Name = "btnAddNote";
			btnAddNote.Size = new Size(104, 39);
			btnAddNote.TabIndex = 2;
			btnAddNote.Text = "Add History";
			btnAddNote.UseVisualStyleBackColor = true;
			btnAddNote.Click += btnAddNote_Click;
			// 
			// btnUpdateNote
			// 
			btnUpdateNote.Location = new Point(161, 521);
			btnUpdateNote.Margin = new Padding(3, 4, 3, 4);
			btnUpdateNote.Name = "btnUpdateNote";
			btnUpdateNote.Size = new Size(124, 39);
			btnUpdateNote.TabIndex = 3;
			btnUpdateNote.Text = "Update History";
			btnUpdateNote.UseVisualStyleBackColor = true;
			btnUpdateNote.Click += btnUpdateNote_Click;
			// 
			// btnDeleteNote
			// 
			btnDeleteNote.Location = new Point(317, 521);
			btnDeleteNote.Margin = new Padding(3, 4, 3, 4);
			btnDeleteNote.Name = "btnDeleteNote";
			btnDeleteNote.Size = new Size(128, 39);
			btnDeleteNote.TabIndex = 4;
			btnDeleteNote.Text = "Delete History";
			btnDeleteNote.UseVisualStyleBackColor = true;
			btnDeleteNote.Click += btnDeleteNote_Click;
			// 
			// listBoxProblem
			// 
			listBoxProblem.FormattingEnabled = true;
			listBoxProblem.ItemHeight = 17;
			listBoxProblem.Location = new Point(453, 55);
			listBoxProblem.Margin = new Padding(3, 4, 3, 4);
			listBoxProblem.Name = "listBoxProblem";
			listBoxProblem.Size = new Size(157, 208);
			listBoxProblem.TabIndex = 6;
			// 
			// listBoxBP
			// 
			listBoxBP.FormattingEnabled = true;
			listBoxBP.ItemHeight = 17;
			listBoxBP.Location = new Point(625, 55);
			listBoxBP.Margin = new Padding(3, 4, 3, 4);
			listBoxBP.Name = "listBoxBP";
			listBoxBP.Size = new Size(157, 208);
			listBoxBP.TabIndex = 7;
			// 
			// label2
			// 
			label2.AutoSize = true;
			label2.Location = new Point(22, 69);
			label2.Name = "label2";
			label2.Size = new Size(75, 17);
			label2.TabIndex = 9;
			label2.Text = "Patient ID:";
			// 
			// label3
			// 
			label3.AutoSize = true;
			label3.Location = new Point(22, 119);
			label3.Name = "label3";
			label3.Size = new Size(98, 17);
			label3.TabIndex = 10;
			label3.Text = "Patient name:";
			// 
			// label4
			// 
			label4.AutoSize = true;
			label4.Location = new Point(22, 165);
			label4.Name = "label4";
			label4.Size = new Size(93, 17);
			label4.TabIndex = 11;
			label4.Text = "Date of Birth:";
			// 
			// label5
			// 
			label5.AutoSize = true;
			label5.Location = new Point(22, 212);
			label5.Name = "label5";
			label5.Size = new Size(75, 17);
			label5.TabIndex = 12;
			label5.Text = "Symptom:";
			// 
			// rTxtBoxNote
			// 
			rTxtBoxNote.Location = new Point(22, 280);
			rTxtBoxNote.Margin = new Padding(3, 4, 3, 4);
			rTxtBoxNote.Name = "rTxtBoxNote";
			rTxtBoxNote.Size = new Size(760, 216);
			rTxtBoxNote.TabIndex = 15;
			rTxtBoxNote.Text = "";
			rTxtBoxNote.TextChanged += rTxtBoxNote_TextChanged;
			// 
			// txtBoxID
			// 
			txtBoxID.Enabled = false;
			txtBoxID.Location = new Point(145, 63);
			txtBoxID.Margin = new Padding(3, 4, 3, 4);
			txtBoxID.Name = "txtBoxID";
			txtBoxID.Size = new Size(164, 25);
			txtBoxID.TabIndex = 16;
			// 
			// txtName
			// 
			txtName.Location = new Point(145, 115);
			txtName.Margin = new Padding(3, 4, 3, 4);
			txtName.Name = "txtName";
			txtName.Size = new Size(164, 25);
			txtName.TabIndex = 17;
			// 
			// txtBoxProblem
			// 
			txtBoxProblem.Location = new Point(145, 212);
			txtBoxProblem.Margin = new Padding(3, 4, 3, 4);
			txtBoxProblem.Name = "txtBoxProblem";
			txtBoxProblem.Size = new Size(164, 25);
			txtBoxProblem.TabIndex = 18;
			// 
			// dateTimePicker
			// 
			dateTimePicker.Location = new Point(145, 161);
			dateTimePicker.Margin = new Padding(3, 4, 3, 4);
			dateTimePicker.Name = "dateTimePicker";
			dateTimePicker.Size = new Size(238, 25);
			dateTimePicker.TabIndex = 19;
			// 
			// groupBox1
			// 
			groupBox1.Controls.Add(label1);
			groupBox1.Controls.Add(dateTimePicker);
			groupBox1.Controls.Add(txtBoxProblem);
			groupBox1.Controls.Add(txtName);
			groupBox1.Controls.Add(txtBoxID);
			groupBox1.Controls.Add(rTxtBoxNote);
			groupBox1.Controls.Add(label7);
			groupBox1.Controls.Add(label6);
			groupBox1.Controls.Add(label5);
			groupBox1.Controls.Add(label4);
			groupBox1.Controls.Add(label3);
			groupBox1.Controls.Add(label2);
			groupBox1.Controls.Add(listBoxBP);
			groupBox1.Controls.Add(listBoxProblem);
			groupBox1.Controls.Add(btnDeleteNote);
			groupBox1.Controls.Add(btnUpdateNote);
			groupBox1.Controls.Add(btnAddNote);
			groupBox1.Controls.Add(btnAddProblem);
			groupBox1.Font = new Font("Arial", 9F, FontStyle.Regular, GraphicsUnit.Point);
			groupBox1.Location = new Point(239, 35);
			groupBox1.Margin = new Padding(3, 4, 3, 4);
			groupBox1.Name = "groupBox1";
			groupBox1.Padding = new Padding(3, 4, 3, 4);
			groupBox1.Size = new Size(800, 577);
			groupBox1.TabIndex = 20;
			groupBox1.TabStop = false;
			groupBox1.Text = "Patient History Note";
			// 
			// label1
			// 
			label1.AutoSize = true;
			label1.Location = new Point(22, 259);
			label1.Name = "label1";
			label1.Size = new Size(98, 17);
			label1.TabIndex = 20;
			label1.Text = "Patient Detail:";
			// 
			// Form1
			// 
			AutoScaleDimensions = new SizeF(8F, 20F);
			AutoScaleMode = AutoScaleMode.Font;
			ClientSize = new Size(1071, 679);
			Controls.Add(groupBox1);
			Controls.Add(lblStatus);
			Controls.Add(listBoxPatient);
			Controls.Add(btnStartNote);
			Margin = new Padding(3, 4, 3, 4);
			Name = "Form1";
			Text = "KK Patient Manager";
			Load += Form1_Load;
			groupBox1.ResumeLayout(false);
			groupBox1.PerformLayout();
			ResumeLayout(false);
			PerformLayout();
		}

		#endregion

		private System.Windows.Forms.Button btnStartNote;
        private System.Windows.Forms.ListBox listBoxPatient;
        private System.Windows.Forms.Label lblStatus;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btnAddProblem;
        private System.Windows.Forms.Button btnAddNote;
        private System.Windows.Forms.Button btnUpdateNote;
        private System.Windows.Forms.Button btnDeleteNote;
        private System.Windows.Forms.ListBox listBoxProblem;
        private System.Windows.Forms.ListBox listBoxBP;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.RichTextBox rTxtBoxNote;
        private System.Windows.Forms.TextBox txtBoxID;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.TextBox txtBoxProblem;
        private System.Windows.Forms.DateTimePicker dateTimePicker;
        private System.Windows.Forms.GroupBox groupBox1;
		private Label label1;
	}
}

