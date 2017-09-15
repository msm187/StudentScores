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
	public partial class frmAddStudent : Form
	{
		private Student currentStudent = new Student();
		List<int> TotalScores = new List<int>();


		public frmAddStudent()
		{
			InitializeComponent();
		}

		public Student AddStudent()
		{
			this.ShowDialog();
			return currentStudent;
		}

		private void frmAddStudent_Load(object sender, EventArgs e)
				{
					txtName.Focus();
				}


		private void btnAddScore_Click(object sender, EventArgs e)
		{
			if (txtName.Text != "" && txtScore.Text != null)
			{

				int num = 0;
				if (Int32.TryParse(txtScore.Text, out num))
				{
					if (num <= 100 && num >= 0)
					{
						TotalScores.Add(Convert.ToInt32(txtScore.Text));
						txtAllScore.Text += (txtScore.Text + " | ");
						txtScore.Text = "";
						txtScore.Focus();
					}
					else
					{
						MessageBox.Show("Score must be between 0 and 100");
					}
				}
			}
			
			
		
		}

		private void btnClearScore_Click(object sender, EventArgs e)
		{
			txtAllScore.Clear();
			txtName.Text = "";
			txtScore.Text = "";
			txtName.Focus();
		}

		public Student showInfo(Student s)
		{
			currentStudent = s;
			this.ShowDialog();
			return currentStudent;
		}

		private void btnOk_Click(object sender, EventArgs e)
		{
			if (txtName.Text != "" && txtAllScore.Text != null)
			{
				currentStudent = new Student(txtName.Text, TotalScores);
				this.Close();
			}
			else
			{
				MessageBox.Show("You must enter a name to continue.");
			}
		}

		
		private void btnCancel_Click(object sender, EventArgs e)
		{
			
			this.Close();
		}
	}
}
