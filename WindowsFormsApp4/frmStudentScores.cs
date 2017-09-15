using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp4
{
	public partial class frmStudentScores : Form
	{
		Student scoreStudent;
		frmAddStudent fas = new frmAddStudent();
		List<Student> allStudents = new List<Student>();
		

		public frmStudentScores()
		{
			InitializeComponent();
		}

		private void frmStudentScores_Load(object sender, EventArgs e)
		{
			//Example Students
			allStudents.Add(new Student("Keith Moon", new List<int> { 20, 30, 50 }));
			allStudents.Add(new Student("Rodger Daltry", new List<int> { 25, 50, 45}));
			allStudents.Add(new Student("Jon Entwhistle", new List<int> { 69, 72, 81 }));
			allStudents.Add(new Student("Pete Townshend", new List<int> { 50, 60, 70 }));
			AddToListbox();
		}

		private void ClearAverage()
		{
			txtScoreTotal.Text = "";
			txtScoreCount.Text = "";
			txtAverage.Text = "";
		}

		//Totals, averages, and counts grades
		private void GetAverage()
		{
			int index = lstStudents.SelectedIndex;
			int total = 0;
			List<int> grades = allStudents[index].Grades;
			if (grades != null && grades.Count > 0)
			{
				foreach (int grade in grades)
				{
					total += grade;
				}

				int average = total / grades.Count;

				txtAverage.Text = average.ToString();
				txtScoreCount.Text = grades.Count.ToString();
				txtScoreTotal.Text = total.ToString();
			}
			else
			{
				ClearAverage();
			}
		}

		private void lstStudents_SelectedIndexChanged(object sender, EventArgs e)
		{
			GetAverage();
		}

		//New Method to clear and fill listbox
		private void AddToListbox()
		{
			lstStudents.Items.Clear();
			foreach (Student student in allStudents)
			{
				lstStudents.Items.Add(student.GetDisplayText());

			}
			lstStudents.SelectedIndex = -1;
			ClearAverage();
		}
		
		private void btnAddNew_Click(object sender, EventArgs e)
		{
			frmAddStudent addNewStudent = new frmAddStudent();
			Student updatedStudent = addNewStudent.AddStudent();
			if (updatedStudent != null)
			{
				allStudents.Add(updatedStudent);
				//call method
				this.AddToListbox();
			}
		}

		private void btnUpdate_Click(object sender, EventArgs e)
		{
			if (lstStudents.SelectedIndex == -1)
			{
				SelectionError();
			}

			else
			{
				frmUpdateStudentScores newUpdateScores = new frmUpdateStudentScores();
				newUpdateScores.updatingStudent(allStudents[lstStudents.SelectedIndex]);
				this.AddToListbox();
			}
		}

		private void btnExit_Click(object sender, EventArgs e)
		{
			DialogResult result = MessageBox.Show("Are you sure you want to exit?", "Confirm Exit", MessageBoxButtons.YesNo, MessageBoxIcon.Question);


			if (result == DialogResult.Yes)
			{
				this.Close();
			}
		}

		private void btnDelete_Click(object sender, EventArgs e)
		{
			if (lstStudents.SelectedIndex == -1)
			{
				SelectionError();
			}
			else
			{
				DialogResult result = MessageBox.Show("Are you sure you want to delete: " + allStudents[lstStudents.SelectedIndex].Name,
					"Confirm Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
				if (result == DialogResult.Yes)
				{
					allStudents.RemoveAt(lstStudents.SelectedIndex);
					AddToListbox();
				}
			}
		}

		

		private void SelectionError()
		{
			MessageBox.Show("Please select a student before performing this action", "Action Needed");
		}
	}
}
