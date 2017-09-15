namespace WindowsFormsApp4
{
	partial class frmAddStudent
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
			this.lblName = new System.Windows.Forms.Label();
			this.lblScore = new System.Windows.Forms.Label();
			this.lblScores = new System.Windows.Forms.Label();
			this.txtName = new System.Windows.Forms.TextBox();
			this.txtScore = new System.Windows.Forms.TextBox();
			this.txtAllScore = new System.Windows.Forms.TextBox();
			this.btnAddScore = new System.Windows.Forms.Button();
			this.btnClearScore = new System.Windows.Forms.Button();
			this.btnCancel = new System.Windows.Forms.Button();
			this.btnOk = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// lblName
			// 
			this.lblName.AutoSize = true;
			this.lblName.Location = new System.Drawing.Point(13, 30);
			this.lblName.Name = "lblName";
			this.lblName.Size = new System.Drawing.Size(48, 16);
			this.lblName.TabIndex = 0;
			this.lblName.Text = "Name:";
			// 
			// lblScore
			// 
			this.lblScore.AutoSize = true;
			this.lblScore.Location = new System.Drawing.Point(13, 68);
			this.lblScore.Name = "lblScore";
			this.lblScore.Size = new System.Drawing.Size(47, 16);
			this.lblScore.TabIndex = 1;
			this.lblScore.Text = "Score:";
			// 
			// lblScores
			// 
			this.lblScores.AutoSize = true;
			this.lblScores.Location = new System.Drawing.Point(13, 114);
			this.lblScores.Name = "lblScores";
			this.lblScores.Size = new System.Drawing.Size(54, 16);
			this.lblScores.TabIndex = 2;
			this.lblScores.Text = "Scores:";
			// 
			// txtName
			// 
			this.txtName.Location = new System.Drawing.Point(102, 24);
			this.txtName.Name = "txtName";
			this.txtName.Size = new System.Drawing.Size(233, 22);
			this.txtName.TabIndex = 0;
			// 
			// txtScore
			// 
			this.txtScore.Location = new System.Drawing.Point(102, 68);
			this.txtScore.Name = "txtScore";
			this.txtScore.Size = new System.Drawing.Size(100, 22);
			this.txtScore.TabIndex = 1;
			// 
			// txtAllScore
			// 
			this.txtAllScore.Location = new System.Drawing.Point(102, 111);
			this.txtAllScore.Name = "txtAllScore";
			this.txtAllScore.ReadOnly = true;
			this.txtAllScore.Size = new System.Drawing.Size(233, 22);
			this.txtAllScore.TabIndex = 5;
			this.txtAllScore.TabStop = false;
			// 
			// btnAddScore
			// 
			this.btnAddScore.Location = new System.Drawing.Point(208, 68);
			this.btnAddScore.Name = "btnAddScore";
			this.btnAddScore.Size = new System.Drawing.Size(127, 23);
			this.btnAddScore.TabIndex = 2;
			this.btnAddScore.Text = "Add Score";
			this.btnAddScore.UseVisualStyleBackColor = true;
			this.btnAddScore.Click += new System.EventHandler(this.btnAddScore_Click);
			// 
			// btnClearScore
			// 
			this.btnClearScore.Location = new System.Drawing.Point(208, 139);
			this.btnClearScore.Name = "btnClearScore";
			this.btnClearScore.Size = new System.Drawing.Size(127, 25);
			this.btnClearScore.TabIndex = 7;
			this.btnClearScore.Text = "Clear Scores";
			this.btnClearScore.UseVisualStyleBackColor = true;
			this.btnClearScore.Click += new System.EventHandler(this.btnClearScore_Click);
			// 
			// btnCancel
			// 
			this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
			this.btnCancel.Location = new System.Drawing.Point(260, 189);
			this.btnCancel.Name = "btnCancel";
			this.btnCancel.Size = new System.Drawing.Size(75, 23);
			this.btnCancel.TabIndex = 4;
			this.btnCancel.Text = "Cancel";
			this.btnCancel.UseVisualStyleBackColor = true;
			this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
			// 
			// btnOk
			// 
			this.btnOk.Location = new System.Drawing.Point(166, 189);
			this.btnOk.Name = "btnOk";
			this.btnOk.Size = new System.Drawing.Size(75, 23);
			this.btnOk.TabIndex = 3;
			this.btnOk.Text = "OK";
			this.btnOk.UseVisualStyleBackColor = true;
			this.btnOk.Click += new System.EventHandler(this.btnOk_Click);
			// 
			// frmAddStudent
			// 
			this.AcceptButton = this.btnOk;
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.CancelButton = this.btnCancel;
			this.ClientSize = new System.Drawing.Size(362, 237);
			this.Controls.Add(this.btnOk);
			this.Controls.Add(this.btnCancel);
			this.Controls.Add(this.btnClearScore);
			this.Controls.Add(this.btnAddScore);
			this.Controls.Add(this.txtAllScore);
			this.Controls.Add(this.txtScore);
			this.Controls.Add(this.txtName);
			this.Controls.Add(this.lblScores);
			this.Controls.Add(this.lblScore);
			this.Controls.Add(this.lblName);
			this.Name = "frmAddStudent";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Add New Student";
			this.Load += new System.EventHandler(this.frmAddStudent_Load);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label lblName;
		private System.Windows.Forms.Label lblScore;
		private System.Windows.Forms.Label lblScores;
		private System.Windows.Forms.TextBox txtName;
		private System.Windows.Forms.TextBox txtScore;
		private System.Windows.Forms.TextBox txtAllScore;
		private System.Windows.Forms.Button btnAddScore;
		private System.Windows.Forms.Button btnClearScore;
		private System.Windows.Forms.Button btnCancel;
		private System.Windows.Forms.Button btnOk;
	}
}