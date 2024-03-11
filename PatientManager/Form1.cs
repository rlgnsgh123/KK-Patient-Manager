using Microsoft.VisualBasic.ApplicationServices;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using PatientLibrary;

namespace KKPatientManger
{
	public partial class Form1 : Form
	{
		// Declare list for patientList
		List<Patient> patientList = new List<Patient>();

		const string regexBP = @"([bB][pP][:]?\s\d{2,3}(/)\d{2,3})";

		public Form1()
		{
			InitializeComponent();
		}
		private void Form1_Load(object sender, EventArgs e)
		{
			// making file to store patient info
			ParentsTextData.MakingFile();
			awaitingNoteMode();
			lblStatus.Text = string.Empty;
			try
			{
				// formating date
				dateTimePicker.Format = DateTimePickerFormat.Custom;
				dateTimePicker.CustomFormat = "dd MMM yyyy";
				lblStatus.Text = string.Empty;
				showPatientList();
			}
			catch (DirectoryNotFoundException)
			{
				// error catch for wrong logPath
				lblStatus.Text = "Please enter logPath correctly";
				lblStatus.ForeColor = Color.Red;
			}
			catch (Exception ex)
			{
				lblStatus.ForeColor = Color.Red;
				lblStatus.Text = ex.Message;
			}
			listBoxProblem.Items.Clear();
		}

		// awaitingMode
		private void awaitingNoteMode()
		{
			btnStartNote.Enabled = true;
			btnAddNote.Enabled = false;
			btnAddProblem.Enabled = false;
			btnUpdateNote.Enabled = false;
			btnDeleteNote.Enabled = false;
			txtBoxID.Enabled = false;
			txtName.Enabled = false;
			dateTimePicker.Enabled = false;
			txtBoxProblem.Enabled = false;
			rTxtBoxNote.Enabled = false;




		}

		private void editMode()
		{
			btnStartNote.Enabled = true;
			btnAddNote.Enabled = false;
			btnDeleteNote.Enabled = true;
			btnAddProblem.Enabled = true;
			btnUpdateNote.Enabled = true;
			btnDeleteNote.Enabled = true;
			txtName.Enabled = true;
			dateTimePicker.Enabled = true;
			txtBoxProblem.Enabled = true;
			rTxtBoxNote.Enabled = true;
		}

		private void addMode()
		{
			btnStartNote.Enabled = true;
			btnAddNote.Enabled = true;
			btnAddProblem.Enabled = true;
			btnUpdateNote.Enabled = false;
			btnDeleteNote.Enabled = false;
			txtName.Enabled = true;
			dateTimePicker.Enabled = true;
			txtBoxProblem.Enabled = true;
			rTxtBoxNote.Enabled = true;

		}
		// Show patient List on the reft side
		private void showPatientList()
		{
			listBoxPatient.Items.Clear();
			// get some data from txt file
			patientList = ParentsTextData.LoadPatientData();
			foreach (Patient patient in patientList)
			{
				// formating showing
				listBoxPatient.Items.Add($"{patient.name}(Note:{patient.id})");
			}
		}


		private void btnStartNote_Click(object sender, EventArgs e)
		{
			// restrict some function
			addMode();
			// Clear all of textfile
			lblStatus.Text = String.Empty;
			listBoxProblem.Items.Clear();
			listBoxBP.Items.Clear();
			txtName.Text = string.Empty;
			txtBoxProblem.Text = string.Empty;
			rTxtBoxNote.Text = string.Empty;
			try
			{
				// making unique ID
				int id = 1;
				int lastIndex = patientList.Count - 1;
				if (patientList.Count != 0)
				{
					id = patientList[lastIndex].id + 1;
				}

				txtBoxID.Text = id.ToString();

			}
			catch (Exception ex)
			{
				lblStatus.ForeColor = Color.Red;
				lblStatus.Text = ex.Message;
			}

		}
		// Function for selecting left side patient info
		private void listBoxPatient_SelectedIndexChanged(object sender, EventArgs e)
		{
			// accroding to the index show differnt infor like name, problem
			lblStatus.Text = string.Empty;
			editMode();
			int index = listBoxPatient.SelectedIndex;
			// restrict index -1
			if (index != -1)
			{
				listBoxProblem.Items.Clear();
				listBoxBP.Items.Clear();
				txtBoxID.Text = Convert.ToString(patientList[index].id);
				txtName.Text = patientList[index].name;

			}
			// split problem and add in listbox
			var tempProblems = patientList[index].problem.Split(";");

			foreach (var problem in tempProblems)
			{
				if (!string.IsNullOrEmpty(problem))
				{
					listBoxProblem.Items.Add(problem);
				}
			}
			// only extract BP
			var tempBPs = Regex.Matches(patientList[index].clinicalNote, regexBP);
			foreach (var item in tempBPs)
			{
				string tempBP = item.ToString();
				string[] splitBP = tempBP.Split(" ");
				listBoxBP.Items.Add(splitBP[1]);
			}

			var richNote = patientList[index].clinicalNote.Replace(";", "\n");

			rTxtBoxNote.Text = richNote;



		}
		// validation whether null or not
		private void btnAddProblem_Click(object sender, EventArgs e)
		{
			lblStatus.Text = string.Empty;
			if (!string.IsNullOrEmpty(txtBoxProblem.Text))
			{
				listBoxProblem.Items.Add(txtBoxProblem.Text);
				txtBoxProblem.Text = string.Empty;
				lblStatus.Text = "Problem is added successfully";
			}
			else
			{
				lblStatus.Text = "If you want to add Problem, you should fill out";
			}
		}

		private void btnAddNote_Click(object sender, EventArgs e)
		{
			// get all of info from form
			lblStatus.Text = string.Empty;
			try
			{
				int index = Convert.ToInt32(txtBoxID.Text);
				Patient patient = new Patient(index, txtName.Text, dateTimePicker.Value, txtBoxProblem.Text, rTxtBoxNote.Text);

				string tempProblem = string.Empty;
				if (listBoxProblem.Items != null)
				{
					foreach (var item in listBoxProblem.Items)
					{
						if (!string.IsNullOrEmpty(item.ToString()))
						{
							tempProblem += $"{item.ToString()};";
						}
					}
				}
				// and store info in Object
				patient.problem = tempProblem;

				//string tempClinicalNote = (rTxtBoxNote.Text).Replace("\n", "");
				//tempClinicalNote=Regex.Replace(tempClinicalNote, regexBP, "");
				//patient.clinicalNote = tempBP+tempClinicalNote;
				patient.clinicalNote = (rTxtBoxNote.Text).Replace("\n", ";");


				lblStatus.ForeColor = Color.Green;
				// store data in List
				patientList.Add(patient);
				listBoxPatient.ValueMember = "id";
				// send data to file
				ParentsTextData.AddNewPatient(patient);
				showPatientList();
				editMode();

				listBoxPatient.SelectedIndex = patientList.Count - 1;
				lblStatus.Text = "New patient " + patient.name + " added succesfully";
			}
			catch (ArgumentException errors)
			{
				lblStatus.ForeColor = Color.Red;
				lblStatus.Text = Convert.ToString(errors.Message);
			}
		}

		private void btnUpdateNote_Click(object sender, EventArgs e)
		{
			lblStatus.Text = string.Empty;
			// validation 
			try
			{
				string tempProblem = string.Empty;
				if (listBoxProblem.Items != null)
				{
					foreach (var item in listBoxProblem.Items)
					{
						tempProblem += $"{item.ToString()};";
					}
				}
				// making richtext to just oneline and split into;
				string tempclinicalNote = (rTxtBoxNote.Text).Replace("\n", ";");
				Patient patient = new Patient(Convert.ToInt32(txtBoxID.Text), txtName.Text, dateTimePicker.Value, tempProblem, tempclinicalNote);

				int index = listBoxPatient.SelectedIndex;
				ParentsTextData.EditPatient(patient, index);
				patientList[index] = patient;
				showPatientList();
				listBoxPatient.SelectedIndex = index;
				lblStatus.ForeColor = Color.Green;
				lblStatus.Text = "Updated successfully";

			}
			catch (ArgumentException errors)
			{
				lblStatus.ForeColor = Color.Red;
				lblStatus.Text = Convert.ToString(errors.Message);
			}

		}

		private void btnDeleteNote_Click(object sender, EventArgs e)
		{
			awaitingNoteMode();
			lblStatus.Text = string.Empty;
			// get a index from listBOx index
			int index = listBoxPatient.SelectedIndex;
			patientList.RemoveAt(index);
			ParentsTextData.DeletePatient(patientList, index);
			txtName.Text = string.Empty;
			txtBoxProblem.Text = string.Empty;
			txtBoxID.Text = string.Empty;
			rTxtBoxNote.Text = string.Empty;
			listBoxBP.Items.Clear();
			listBoxProblem.Items.Clear();
			lblStatus.ForeColor = Color.Green;
			lblStatus.Text = "Deleted successfully";
			showPatientList();
		}
		// automatically saving BP information on BP listBox
		private void rTxtBoxNote_TextChanged(object sender, EventArgs e)
		{
			listBoxBP.Items.Clear();

			// extract only BP data
			var tempBPs = Regex.Matches(rTxtBoxNote.Text, regexBP, RegexOptions.Multiline);
			foreach (var item in tempBPs)
			{
				string tempBP = item.ToString();
				string[] splitBP = tempBP.Split(" ");
				listBoxBP.Items.Add(splitBP[1]);
			}

		}
	}
}
