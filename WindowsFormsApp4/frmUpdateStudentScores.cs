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
	

		public partial class frmUpdateStudentScores : Form
		{

		private Student updatedStudent;
		public static int selected;
		private List<int> grades = new List<int>();


		public frmUpdateStudentScores()
		{
			InitializeComponent();
		}

		private void frmUpdateStudentScores_Load(object sender, EventArgs e)
		{
			txtName.Text = updatedStudent.Name;

			foreach (int grade in updatedStudent.Grades)
			{
				grades.Add(grade);
			}
			FillListBox();
		}

		public Student updatingStudent(Student Student)
		{
			updatedStudent = Student;
			this.ShowDialog();
			return updatedStudent;
		}

		private void btnAdd_Click(object sender, EventArgs e)
		{
			
			frmAddSmall addStudentScore = new frmAddSmall();
			int newScore = addStudentScore.AddScore();
			if (newScore != -1)
			{
				grades.Add(newScore);
				this.FillListBox();
			}
		}

		

		private void btnUpdate_Click(object sender, EventArgs e)
		{
			if (lstScores.SelectedIndex == -1)
			{
				SelectionError();
			}
			else
			{
				frmUpdateSmall score = new frmUpdateSmall();
				score.score = grades[lstScores.SelectedIndex];
				grades[lstScores.SelectedIndex] = score.UpdateScore();
				FillListBox();
			}
		}
private void FillListBox()
		{
			lstScores.Items.Clear();
			foreach (int grade in grades)
			{
				lstScores.Items.Add(grade);
			}
			lstScores.SelectedIndex = -1;
		}
		private void btnOK_Click(object sender, EventArgs e)
		{

			updatedStudent.Grades = grades;
			this.Close();
		}

		private void btnCancel_Click(object sender, EventArgs e)
		{
			this.Close();
		}

		private void SelectionError()
		{
			MessageBox.Show("Please select a score to update.", "Action Needed");
		}

		private void btnRemove_Click(object sender, EventArgs e)
		{
			grades.RemoveAt(lstScores.SelectedIndex);
			FillListBox();
		}

		private void btnClear_Click(object sender, EventArgs e)
		{
			grades.Clear();
			lstScores.Items.Clear();
		
		}
	}
}
