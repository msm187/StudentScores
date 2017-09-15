namespace WindowsFormsApp4
{
	partial class frmStudentScores
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
			this.lstStudents = new System.Windows.Forms.ListBox();
			this.btnAddNew = new System.Windows.Forms.Button();
			this.btnUpdate = new System.Windows.Forms.Button();
			this.btnDelete = new System.Windows.Forms.Button();
			this.lblStudents = new System.Windows.Forms.Label();
			this.lblScoreTotal = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.txtScoreTotal = new System.Windows.Forms.TextBox();
			this.txtScoreCount = new System.Windows.Forms.TextBox();
			this.txtAverage = new System.Windows.Forms.TextBox();
			this.btnExit = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// lstStudents
			// 
			this.lstStudents.FormattingEnabled = true;
			this.lstStudents.ItemHeight = 16;
			this.lstStudents.Location = new System.Drawing.Point(13, 57);
			this.lstStudents.Name = "lstStudents";
			this.lstStudents.Size = new System.Drawing.Size(386, 180);
			this.lstStudents.TabIndex = 0;
			this.lstStudents.TabStop = false;
			this.lstStudents.SelectedIndexChanged += new System.EventHandler(this.lstStudents_SelectedIndexChanged);
			// 
			// btnAddNew
			// 
			this.btnAddNew.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnAddNew.Location = new System.Drawing.Point(419, 56);
			this.btnAddNew.Name = "btnAddNew";
			this.btnAddNew.Size = new System.Drawing.Size(106, 28);
			this.btnAddNew.TabIndex = 1;
			this.btnAddNew.Text = "Add New...";
			this.btnAddNew.UseVisualStyleBackColor = true;
			this.btnAddNew.Click += new System.EventHandler(this.btnAddNew_Click);
			// 
			// btnUpdate
			// 
			this.btnUpdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnUpdate.Location = new System.Drawing.Point(419, 107);
			this.btnUpdate.Name = "btnUpdate";
			this.btnUpdate.Size = new System.Drawing.Size(106, 28);
			this.btnUpdate.TabIndex = 2;
			this.btnUpdate.Text = "Update...";
			this.btnUpdate.UseVisualStyleBackColor = true;
			this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
			// 
			// btnDelete
			// 
			this.btnDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnDelete.Location = new System.Drawing.Point(419, 163);
			this.btnDelete.Name = "btnDelete";
			this.btnDelete.Size = new System.Drawing.Size(106, 28);
			this.btnDelete.TabIndex = 3;
			this.btnDelete.Text = "Delete";
			this.btnDelete.UseVisualStyleBackColor = true;
			this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
			// 
			// lblStudents
			// 
			this.lblStudents.AutoSize = true;
			this.lblStudents.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblStudents.Location = new System.Drawing.Point(13, 22);
			this.lblStudents.Name = "lblStudents";
			this.lblStudents.Size = new System.Drawing.Size(89, 20);
			this.lblStudents.TabIndex = 4;
			this.lblStudents.Text = "Students:";
			// 
			// lblScoreTotal
			// 
			this.lblScoreTotal.AutoSize = true;
			this.lblScoreTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblScoreTotal.ImageAlign = System.Drawing.ContentAlignment.BottomLeft;
			this.lblScoreTotal.Location = new System.Drawing.Point(187, 259);
			this.lblScoreTotal.Name = "lblScoreTotal";
			this.lblScoreTotal.Size = new System.Drawing.Size(112, 20);
			this.lblScoreTotal.TabIndex = 5;
			this.lblScoreTotal.Text = "Score Total:";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label3.ImageAlign = System.Drawing.ContentAlignment.BottomLeft;
			this.label3.Location = new System.Drawing.Point(187, 283);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(119, 20);
			this.label3.TabIndex = 6;
			this.label3.Text = "Score Count:";
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label4.ImageAlign = System.Drawing.ContentAlignment.BottomLeft;
			this.label4.Location = new System.Drawing.Point(187, 307);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(83, 20);
			this.label4.TabIndex = 7;
			this.label4.Text = "Average:";
			// 
			// txtScoreTotal
			// 
			this.txtScoreTotal.Location = new System.Drawing.Point(299, 255);
			this.txtScoreTotal.Name = "txtScoreTotal";
			this.txtScoreTotal.ReadOnly = true;
			this.txtScoreTotal.Size = new System.Drawing.Size(100, 22);
			this.txtScoreTotal.TabIndex = 8;
			this.txtScoreTotal.TabStop = false;
			// 
			// txtScoreCount
			// 
			this.txtScoreCount.Location = new System.Drawing.Point(299, 279);
			this.txtScoreCount.Name = "txtScoreCount";
			this.txtScoreCount.ReadOnly = true;
			this.txtScoreCount.Size = new System.Drawing.Size(100, 22);
			this.txtScoreCount.TabIndex = 9;
			this.txtScoreCount.TabStop = false;
			// 
			// txtAverage
			// 
			this.txtAverage.Location = new System.Drawing.Point(299, 303);
			this.txtAverage.Name = "txtAverage";
			this.txtAverage.ReadOnly = true;
			this.txtAverage.Size = new System.Drawing.Size(100, 22);
			this.txtAverage.TabIndex = 10;
			this.txtAverage.TabStop = false;
			// 
			// btnExit
			// 
			this.btnExit.DialogResult = System.Windows.Forms.DialogResult.Cancel;
			this.btnExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnExit.Location = new System.Drawing.Point(419, 297);
			this.btnExit.Name = "btnExit";
			this.btnExit.Size = new System.Drawing.Size(106, 28);
			this.btnExit.TabIndex = 4;
			this.btnExit.Text = "Exit";
			this.btnExit.UseVisualStyleBackColor = true;
			this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
			// 
			// frmStudentScores
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.AutoSize = true;
			this.CancelButton = this.btnExit;
			this.ClientSize = new System.Drawing.Size(557, 347);
			this.Controls.Add(this.btnExit);
			this.Controls.Add(this.txtAverage);
			this.Controls.Add(this.txtScoreCount);
			this.Controls.Add(this.txtScoreTotal);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.lblScoreTotal);
			this.Controls.Add(this.lblStudents);
			this.Controls.Add(this.btnDelete);
			this.Controls.Add(this.btnUpdate);
			this.Controls.Add(this.btnAddNew);
			this.Controls.Add(this.lstStudents);
			this.Name = "frmStudentScores";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Student Scores";
			this.Load += new System.EventHandler(this.frmStudentScores_Load);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.ListBox lstStudents;
		private System.Windows.Forms.Button btnAddNew;
		private System.Windows.Forms.Button btnUpdate;
		private System.Windows.Forms.Button btnDelete;
		private System.Windows.Forms.Label lblStudents;
		private System.Windows.Forms.Label lblScoreTotal;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.TextBox txtScoreTotal;
		private System.Windows.Forms.TextBox txtScoreCount;
		private System.Windows.Forms.TextBox txtAverage;
		private System.Windows.Forms.Button btnExit;
	}
}

