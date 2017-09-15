namespace WindowsFormsApp4
{
	partial class frmAddSmall
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
			this.lblScore = new System.Windows.Forms.Label();
			this.txtAddScore = new System.Windows.Forms.TextBox();
			this.btnAddScore = new System.Windows.Forms.Button();
			this.btnCancel = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// lblScore
			// 
			this.lblScore.AutoSize = true;
			this.lblScore.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblScore.Location = new System.Drawing.Point(12, 60);
			this.lblScore.Name = "lblScore";
			this.lblScore.Size = new System.Drawing.Size(64, 20);
			this.lblScore.TabIndex = 0;
			this.lblScore.Text = "Score:";
			// 
			// txtAddScore
			// 
			this.txtAddScore.Location = new System.Drawing.Point(100, 57);
			this.txtAddScore.Name = "txtAddScore";
			this.txtAddScore.Size = new System.Drawing.Size(100, 22);
			this.txtAddScore.TabIndex = 1;
			// 
			// btnAddScore
			// 
			this.btnAddScore.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnAddScore.Location = new System.Drawing.Point(12, 104);
			this.btnAddScore.Name = "btnAddScore";
			this.btnAddScore.Size = new System.Drawing.Size(94, 36);
			this.btnAddScore.TabIndex = 2;
			this.btnAddScore.Text = "Add";
			this.btnAddScore.UseVisualStyleBackColor = true;
			this.btnAddScore.Click += new System.EventHandler(this.btnAddScore_Click);
			// 
			// btnCancel
			// 
			this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
			this.btnCancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnCancel.Location = new System.Drawing.Point(112, 104);
			this.btnCancel.Name = "btnCancel";
			this.btnCancel.Size = new System.Drawing.Size(88, 36);
			this.btnCancel.TabIndex = 3;
			this.btnCancel.Text = "Cancel";
			this.btnCancel.UseVisualStyleBackColor = true;
			this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
			// 
			// frmAddSmall
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(253, 183);
			this.ControlBox = false;
			this.Controls.Add(this.btnCancel);
			this.Controls.Add(this.btnAddScore);
			this.Controls.Add(this.txtAddScore);
			this.Controls.Add(this.lblScore);
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "frmAddSmall";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
			this.Text = "Add Score";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label lblScore;
		private System.Windows.Forms.TextBox txtAddScore;
		private System.Windows.Forms.Button btnAddScore;
		private System.Windows.Forms.Button btnCancel;
	}
}