using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Parser;

namespace TestApp
{
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();
		}

		private void fButtonModify_Click(object sender, EventArgs e)
		{
			if (string.IsNullOrEmpty(fTextBoxOriginal.Text.Trim()))
			{
				fTextBoxFinal.Text = string.Empty;
				return;
			}

			try
			{
				SqlParser myParser = new SqlParser();
				myParser.Parse(fTextBoxOriginal.Text);

				if (!string.IsNullOrEmpty(fTextBoxWhereClause.Text.Trim()))
				{
					string myOrginalWhereClause = myParser.WhereClause;
					if (string.IsNullOrEmpty(myOrginalWhereClause))
						myParser.WhereClause = fTextBoxWhereClause.Text;
					else
						myParser.WhereClause = string.Format("({0}) AND ({1})", myOrginalWhereClause, fTextBoxWhereClause.Text);
				}

				if (!string.IsNullOrEmpty(fTextBoxOrderBy.Text.Trim()))
				{
					string myOrginalOrderByClause = myParser.OrderByClause;

					if (string.IsNullOrEmpty(myOrginalOrderByClause))
						myParser.OrderByClause = fTextBoxOrderBy.Text;
					else
						myParser.OrderByClause = string.Format("{0}, {1}", myOrginalOrderByClause, fTextBoxOrderBy.Text);
				}

				fTextBoxFinal.Text = myParser.ToText();
			}
			catch (Exception myEx)
			{
				MessageBox.Show(myEx.Message);
			}
		}
	}
}
