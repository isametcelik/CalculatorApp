using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CalculatorApp
{
	public partial class calculator : Form
	{
		private decimal valueFirst = 0.0m;
		private decimal valueSecond = 0.0m;
		private decimal Result = 0.0m;
		private string operators = "+";
		public calculator()
		{
			InitializeComponent();
		}

		private void sıfırbtn_Click(object sender, EventArgs e)
		{
			if (TxtBox.Text =="0")
			{
				TxtBox.Text = "0";
			}
			else
			{
				TxtBox.Text += "0";	
			}
		}

		private void vrglbtn_Click(object sender, EventArgs e)
		{
			if (!TxtBox.Text.Contains(","))
			{
				TxtBox.Text += ",";
			}
		}

		private void birbtn_Click(object sender, EventArgs e)
		{
			if (TxtBox.Text == "0")
			{
				TxtBox.Text = "1";
			}
			else
			{
				TxtBox.Text += "1";
			}
		}

		private void ikibtn_Click(object sender, EventArgs e)
		{
			if (TxtBox.Text == "0")
			{
				TxtBox.Text = "2";
			}
			else
			{
				TxtBox.Text += "2";
			}
		}

		private void ucbtn_Click(object sender, EventArgs e)
		{
			if (TxtBox.Text == "0")
			{
				TxtBox.Text = "3";
			}
			else
			{
				TxtBox.Text += "3";
			}
		}

		private void dortbtn_Click(object sender, EventArgs e)
		{
			if (TxtBox.Text == "0")
			{
				TxtBox.Text = "4";
			}
			else
			{
				TxtBox.Text += "4";
			}
		}

		private void besbtn_Click(object sender, EventArgs e)
		{
			if (TxtBox.Text == "0")
			{
				TxtBox.Text = "5";
			}
			else
			{
				TxtBox.Text += "5";
			}
		}

		private void altibtn_Click(object sender, EventArgs e)
		{
			if (TxtBox.Text == "0")
			{
				TxtBox.Text = "6";
			}
			else
			{
				TxtBox.Text += "6";
			}
		}

		private void yedibtn_Click(object sender, EventArgs e)
		{
			if (TxtBox.Text == "0")
			{
				TxtBox.Text = "7";
			}
			else
			{
				TxtBox.Text += "7";
			}
		}

		private void sekizbtn_Click(object sender, EventArgs e)
		{
			if (TxtBox.Text == "0")
			{
				TxtBox.Text = "8";
			}
			else
			{
				TxtBox.Text += "8";
			}
		}

		private void dokuzbtn_Click(object sender, EventArgs e)
		{
			if (TxtBox.Text == "0")
			{
				TxtBox.Text = "9";
			}
			else
			{
				TxtBox.Text += "9";
			}
		}

		private void artieksibtn_Click(object sender, EventArgs e)
		{
			if (TxtBox.Text.Contains("-"))
			{
				TxtBox.Text = TxtBox.Text.Trim('-');
			}
			else
			{
				TxtBox.Text = "-" + TxtBox.Text;
			}
		}

		private void eksibtn_Click(object sender, EventArgs e)
		{
			valueFirst=decimal.Parse(TxtBox.Text);
			TxtBox.Clear();
			operators = "-";
		}

		private void artibtn_Click(object sender, EventArgs e)
		{
			valueFirst = decimal.Parse(TxtBox.Text);
			TxtBox.Clear();
			operators = "+";
		}

		private void bolmebtn_Click(object sender, EventArgs e)
		{
			valueFirst = decimal.Parse(TxtBox.Text);
			TxtBox.Clear();
			operators = "/";
		}

		private void carpbtn_Click(object sender, EventArgs e)
		{
			valueFirst = decimal.Parse(TxtBox.Text);
			TxtBox.Clear();
			operators = "*";
		}

		private void yuzdebtn_Click(object sender, EventArgs e)
		{
			valueFirst = decimal.Parse(TxtBox.Text);
			TxtBox.Clear();
			operators = "%";
		}

		private void esitbtn_Click(object sender, EventArgs e)
		{
			switch (operators) 
			{
				case "-":
					valueSecond = decimal.Parse(TxtBox.Text);
					Result=valueFirst-valueSecond;
					TxtBox.Text= Result.ToString();
					break;
				case "+":
					valueSecond = decimal.Parse(TxtBox.Text);
					Result = valueFirst + valueSecond;
					TxtBox.Text = Result.ToString();
					break;
				case "*":
					valueSecond = decimal.Parse(TxtBox.Text);
					Result = valueFirst * valueSecond;
					TxtBox.Text = Result.ToString();
					break;
				case "/":
					valueSecond = decimal.Parse(TxtBox.Text);
					Result = valueFirst / valueSecond;
					TxtBox.Text = Result.ToString();
					break;
				case "%":
					valueSecond = decimal.Parse(TxtBox.Text);
					Result = valueFirst % valueSecond;
					TxtBox.Text = Result.ToString();
					break;
			}
		}

		private void temizlebtn_Click(object sender, EventArgs e)
		{
			valueFirst = 0.0m;
			valueSecond = 0.0m;
			TxtBox.Text = "0";
		}
	}
}
