namespace WindowsFormsApp4
{
	partial class frmUpdateSmall
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
			this.btnCancel = new System.Windows.Forms.Button();
			this.btnUpdate = new System.Windows.Forms.Button();
			this.txtUpdateScore = new System.Windows.Forms.TextBox();
			this.lblUpdateScore = new System.Windows.Forms.Label();
			this.SuspendLayout();
			// 
			// btnCancel
			// 
			this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
			this.btnCancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnCancel.Location = new System.Drawing.Point(119, 90);
			this.btnCancel.Name = "btnCancel";
			this.btnCancel.Size = new System.Drawing.Size(95, 41);
			this.btnCancel.TabIndex = 3;
			this.btnCancel.Text = "Cancel";
			this.btnCancel.UseVisualStyleBackColor = true;
			this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
			// 
			// btnUpdate
			// 
			this.btnUpdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnUpdate.Location = new System.Drawing.Point(29, 90);
			this.btnUpdate.Name = "btnUpdate";
			this.btnUpdate.Size = new System.Drawing.Size(87, 41);
			this.btnUpdate.TabIndex = 2;
			this.btnUpdate.Text = "Update";
			this.btnUpdate.UseVisualStyleBackColor = true;
			this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
			// 
			// txtUpdateScore
			// 
			this.txtUpdateScore.Location = new System.Drawing.Point(102, 42);
			this.txtUpdateScore.Name = "txtUpdateScore";
			this.txtUpdateScore.Size = new System.Drawing.Size(100, 22);
			this.txtUpdateScore.TabIndex = 1;
			// 
			// lblUpdateScore
			// 
			this.lblUpdateScore.AutoSize = true;
			this.lblUpdateScore.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblUpdateScore.Location = new System.Drawing.Point(25, 42);
			this.lblUpdateScore.Name = "lblUpdateScore";
			this.lblUpdateScore.Size = new System.Drawing.Size(64, 20);
			this.lblUpdateScore.TabIndex = 4;
			this.lblUpdateScore.Text = "Score:";
			// 
			// frmUpdateSmall
			// 
			this.AcceptButton = this.btnUpdate;
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.CancelButton = this.btnCancel;
			this.ClientSize = new System.Drawing.Size(241, 143);
			this.Controls.Add(this.btnCancel);
			this.Controls.Add(this.btnUpdate);
			this.Controls.Add(this.txtUpdateScore);
			this.Controls.Add(this.lblUpdateScore);
			this.Name = "frmUpdateSmall";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Update Score";
			this.Load += new System.EventHandler(this.frmUpdateSmall_Load);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Button btnCancel;
		private System.Windows.Forms.Button btnUpdate;
		private System.Windows.Forms.TextBox txtUpdateScore;
		private System.Windows.Forms.Label lblUpdateScore;
	}
}