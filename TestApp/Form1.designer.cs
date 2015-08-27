namespace TestApp
{
	partial class Form1
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
			this.fTextBoxOriginal = new System.Windows.Forms.TextBox();
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.fTextBoxWhereClause = new System.Windows.Forms.TextBox();
			this.fTextBoxOrderBy = new System.Windows.Forms.TextBox();
			this.label3 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.fTextBoxFinal = new System.Windows.Forms.TextBox();
			this.fButtonModify = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// fTextBoxOriginal
			// 
			this.fTextBoxOriginal.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
									| System.Windows.Forms.AnchorStyles.Right)));
			this.fTextBoxOriginal.Location = new System.Drawing.Point(15, 25);
			this.fTextBoxOriginal.Multiline = true;
			this.fTextBoxOriginal.Name = "fTextBoxOriginal";
			this.fTextBoxOriginal.Size = new System.Drawing.Size(617, 126);
			this.fTextBoxOriginal.TabIndex = 1;
			this.fTextBoxOriginal.Text = resources.GetString("fTextBoxOriginal.Text");
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(12, 9);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(69, 13);
			this.label1.TabIndex = 0;
			this.label1.Text = "Original SQL:";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(12, 157);
			this.label2.Margin = new System.Windows.Forms.Padding(3, 3, 3, 0);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(126, 13);
			this.label2.TabIndex = 2;
			this.label2.Text = "Additional Where clause:";
			// 
			// fTextBoxWhereClause
			// 
			this.fTextBoxWhereClause.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
									| System.Windows.Forms.AnchorStyles.Right)));
			this.fTextBoxWhereClause.Location = new System.Drawing.Point(12, 173);
			this.fTextBoxWhereClause.Multiline = true;
			this.fTextBoxWhereClause.Name = "fTextBoxWhereClause";
			this.fTextBoxWhereClause.Size = new System.Drawing.Size(620, 61);
			this.fTextBoxWhereClause.TabIndex = 3;
			this.fTextBoxWhereClause.Text = "SALARY > 2500";
			// 
			// fTextBoxOrderBy
			// 
			this.fTextBoxOrderBy.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
									| System.Windows.Forms.AnchorStyles.Right)));
			this.fTextBoxOrderBy.Location = new System.Drawing.Point(12, 256);
			this.fTextBoxOrderBy.Multiline = true;
			this.fTextBoxOrderBy.Name = "fTextBoxOrderBy";
			this.fTextBoxOrderBy.Size = new System.Drawing.Size(620, 61);
			this.fTextBoxOrderBy.TabIndex = 5;
			this.fTextBoxOrderBy.Text = "SALARY";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(12, 240);
			this.label3.Margin = new System.Windows.Forms.Padding(3, 3, 3, 0);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(137, 13);
			this.label3.TabIndex = 4;
			this.label3.Text = "Additional Order By clause:";
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Location = new System.Drawing.Point(12, 352);
			this.label4.Margin = new System.Windows.Forms.Padding(3, 3, 3, 0);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(55, 13);
			this.label4.TabIndex = 7;
			this.label4.Text = "Final SQL:";
			// 
			// fTextBoxFinal
			// 
			this.fTextBoxFinal.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
									| System.Windows.Forms.AnchorStyles.Left)
									| System.Windows.Forms.AnchorStyles.Right)));
			this.fTextBoxFinal.Location = new System.Drawing.Point(15, 368);
			this.fTextBoxFinal.Multiline = true;
			this.fTextBoxFinal.Name = "fTextBoxFinal";
			this.fTextBoxFinal.Size = new System.Drawing.Size(620, 131);
			this.fTextBoxFinal.TabIndex = 8;
			// 
			// fButtonModify
			// 
			this.fButtonModify.Location = new System.Drawing.Point(12, 323);
			this.fButtonModify.Name = "fButtonModify";
			this.fButtonModify.Size = new System.Drawing.Size(75, 23);
			this.fButtonModify.TabIndex = 6;
			this.fButtonModify.Text = "Modify SQL";
			this.fButtonModify.UseVisualStyleBackColor = true;
			this.fButtonModify.Click += new System.EventHandler(this.fButtonModify_Click);
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(644, 511);
			this.Controls.Add(this.fButtonModify);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.fTextBoxFinal);
			this.Controls.Add(this.fTextBoxOrderBy);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.fTextBoxWhereClause);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.fTextBoxOriginal);
			this.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.Name = "Form1";
			this.Text = "Form1";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.TextBox fTextBoxOriginal;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.TextBox fTextBoxWhereClause;
		private System.Windows.Forms.TextBox fTextBoxOrderBy;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.TextBox fTextBoxFinal;
		private System.Windows.Forms.Button fButtonModify;
	}
}

