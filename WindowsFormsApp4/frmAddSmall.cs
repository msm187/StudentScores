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
	public partial class frmAddSmall : Form
	{
		private int newScore;

		public frmAddSmall()
		{
			InitializeComponent();
		}

		public int AddScore()
		{
			this.ShowDialog();
			return newScore;
		}

		private void btnAddScore_Click(object sender, EventArgs e)
		{
			int num = 0;
			if (Int32.TryParse(txtAddScore.Text, out num))
			{
				if (num <= 100 && num >= 0)
				{
					newScore = Convert.ToInt32(txtAddScore.Text);
					this.Close();
				}
				else
				{
					MessageBox.Show("Score must be 0-100.  Please correct the score and try again.");
				}
			}
		}

		private void btnCancel_Click(object sender, EventArgs e)
		{
			newScore = -1;
			this.Close();
		}
	}
}
