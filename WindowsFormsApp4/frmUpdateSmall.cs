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
	public partial class frmUpdateSmall : Form
	{

		private int scoreToUpdate = -1;
		private bool isChanged = false;

		public int score
		{
			get
			{
				return scoreToUpdate;
			}

			set
			{
				scoreToUpdate = value;
			}
		}

		public frmUpdateSmall()
		{
			InitializeComponent();
		}

		public int UpdateScore()
		{
			this.Text = "Update Score";
			btnUpdate.Text = "Update";
			this.ShowDialog();
			return score;
		}

		public int GetNewScore()
		{
			this.Text = "Add New Score";
			btnUpdate.Text = "Add";
			this.ShowDialog();
			return score;
		}

		private void btnUpdate_Click(object sender, EventArgs e)
		{
			score = Convert.ToInt32(txtUpdateScore.Text);
			isChanged = false;
			this.Close();
		}

		private void btnCancel_Click(object sender, EventArgs e)
		{
			this.Close();
		}

		private void frmUpdateSmall_Load(object sender, EventArgs e)
		{
			txtUpdateScore.Text = score.ToString();
			txtUpdateScore.SelectAll();
			txtUpdateScore.Focus();
		}
	}
}
