using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ElephantApp
{
	public partial class Form1 : Form
	{
		Dictionary<string, double> listWthStates = new Dictionary<string, double>()
		{
			{"UT", 6.85 },
			{"NV", 8.00 },
			{"TX", 6.25 },
			{"AL", 4.00 },
			{"CA", 8.25 }
		};

		public Form1()
		{
			InitializeComponent();
		}


		private void button1_Click_1(object sender, EventArgs e)
		{
			if (!Validation())
			{
				return;
			}
			var startPrice = CalculatePrice();
			lblPrice.Text = startPrice.ToString();
			var result = CalculateDiscount(startPrice);
			var statePer = GetPerByState(txtState.Text.ToUpper());
			var res = result * (decimal)((double)100 + statePer) / 100;
			lblTaxes.Text = (res - result).ToString();
			lblFinalPrice.Text = res.ToString();
		}

		private bool Validation()
		{
			if (!int.TryParse(txtCount.Text, out var txtCountRes))
			{
				if (txtCountRes <= 0)
				{
					MessageBox.Show("Count is less then 0");
					return false;
				}

				MessageBox.Show("Count is incorrect");
				return false;
			}
			
			if (!int.TryParse(txtPrice.Text, out var txtPriceRes))
			{
				if (txtPriceRes <= 0)
				{
					MessageBox.Show("Price is less then 0");
					return false;
				}
				MessageBox.Show("Price is incorrect");
				return false;
			}

			if (!listWthStates.ContainsKey(txtState.Text.ToUpper()))
			{
				MessageBox.Show("State is incorrect");
				return false;
			}

			return true;
		}

		private double GetPerByState(string state)
		{
			if (!listWthStates.TryGetValue(state, out var result))
			{
				return 0;
			}
			return result;
		}

		private decimal CalculateDiscount(decimal price)
		{
			var perCatan = 0;
			if (price >= 50000)
			{
				perCatan = 15;
			}
			else if (price >= 10000)
			{
				perCatan = 10;
			}
			else if (price >= 7000)
			{
				perCatan = 7;
			}
			else if (price >= 5000)
			{
				perCatan = 5;
			}
			else if (price >= 1000)
			{
				perCatan = 3;
			}
			else
			{
				perCatan = 0;
			}

			return price * (100 - perCatan) / 100;
		}


		private decimal CalculatePrice()
		{
			int count = 0;
			int.TryParse(txtCount.Text, out count);

			decimal price = 0;
			decimal.TryParse(txtPrice.Text, out price);
			return price * count;
		}

		private void button2_Click(object sender, EventArgs e)
		{
			txtPrice.Text = "0";
			txtCount.Text = "0";
			lblFinalPrice.Text = "0";
			lblPrice.Text = "0";
			lblTaxes.Text = "0";
			txtState.Text = "";
		}
	}
}
