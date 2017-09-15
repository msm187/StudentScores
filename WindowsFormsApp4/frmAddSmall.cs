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

		private int newScore = -1;

		public frmAddSmall()
		{
			InitializeComponent();
		}

		public int AddScore()
		{
			this.ShowDialog();

			if (newScore <= 100 && newScore >= 0)
			{
				newScore = Convert.ToInt32(txtAddScore.Text);

			}
			else
			{
				newScore = -1;
			}
			return newScore;
		}

		private void btnAddScore_Click(object sender, EventArgs e)
		{

			
			this.Close();
		}

		private void btnCancel_Click(object sender, EventArgs e)
		{
			Close();
		}
	}
}
