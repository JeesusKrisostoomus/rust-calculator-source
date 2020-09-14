using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;

namespace Rust_Calculator
{
	public partial class Form2 : Form
	{
		Thread thread;
		public Form2()
		{
			InitializeComponent();
		}

		private void decayCalculatorToolStripMenuItem_Click_1(object sender, EventArgs e)
		{
			this.Close();
			thread = new Thread(DecayCalc);
			thread.SetApartmentState(ApartmentState.STA);
			thread.Start();
		}

		private void smeltingCalculatorToolStripMenuItem_Click_1(object sender, EventArgs e)
		{
			MessageBox.Show("This window is already open.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
		}

		private void DecayCalc(object obj)
		{
			Application.Run(new Form1());
		}

		private void craftingcalc(object obj)
		{
			Application.Run(new CraftingCalc());
		}

		private void infoToolStripMenuItem_Click(object sender, EventArgs e)
		{
			MessageBox.Show("Developer: Jeesus Krisostoomus#7737.\nSpecial thanks to Dubys#3047 for help. \n\nDecay times are accurate for only vanilla decay rates.\n\nFurnace smelting times are accurate for only vanilla smelting rates.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
		}

		private void button1_Click(object sender, EventArgs e)
		{
			int TextboxConents = Convert.ToInt32(textBox1.Text);
			string ComboBoxItemString = comboBox2.Text;
			int comboBoxItem = Convert.ToInt32(ComboBoxItemString);
			TimeSpan timeMetal = TimeSpan.FromSeconds(10 * TextboxConents / comboBoxItem);
			TimeSpan timeSulfur = TimeSpan.FromSeconds(2.5 * TextboxConents / comboBoxItem);
			TimeSpan timeHQM = TimeSpan.FromSeconds(20 * TextboxConents / comboBoxItem);
			TimeSpan timeCrude = TimeSpan.FromSeconds(10 * TextboxConents / comboBoxItem);


			if (comboBox1.SelectedItem == "Metal Ore" && TextboxConents > 0)
			{
				smeltingInfo.Text = "Wood needed to smelt: "+ TextboxConents / comboBoxItem * 5 +"\nTime needed to smelt: "+ timeMetal.ToString(@"hh\hmm\mss\s") + "\nMetal Output: " + Convert.ToInt32(textBox1.Text);
			}
			else if (comboBox1.SelectedItem == "Sulfur Ore" && TextboxConents > 0)
			{
				smeltingInfo.Text = "Wood needed to smelt: " + TextboxConents / comboBoxItem * 2.5 + "\nTime needed to smelt: " + timeSulfur.ToString(@"hh\hmm\mss\s") + "\nSulfur Output: " + Convert.ToInt32(textBox1.Text);
			}
			else if (comboBox1.SelectedItem == "High Quality Metal Ore" && TextboxConents > 0)
			{
				smeltingInfo.Text = "Wood needed to smelt: " + TextboxConents / comboBoxItem * 10 + "\nTime needed to smelt: " + timeHQM.ToString(@"hh\hmm\mss\s") + "\nHigh Quality Metal Output: " + Convert.ToInt32(textBox1.Text);
			}
			else if (comboBox1.SelectedItem == "Crude Oil" && TextboxConents > 0)
			{
				smeltingInfo.Text = "Wood needed to smelt: " + Math.Round(TextboxConents / comboBoxItem * 6.67) + "\nTime needed to smelt: " + timeCrude.ToString(@"hh\hmm\mss\s") + "\nLow Grade Fuel Output: " + Convert.ToInt32(textBox1.Text) * 3;
			}
			else
			{
				MessageBox.Show("Amount table cannot be empty or 0.", "error", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}

		private void Form2_Load(object sender, EventArgs e)
		{
			this.comboBox1.DropDownStyle = ComboBoxStyle.DropDownList;
			this.comboBox2.DropDownStyle = ComboBoxStyle.DropDownList;
		}

		private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
		{

		}

		private void craftingCalculatorToolStripMenuItem_Click(object sender, EventArgs e)
		{
			this.Close();
			thread = new Thread(craftingcalc);
			thread.SetApartmentState(ApartmentState.STA);
			thread.Start();
		}
	}
}

/*
	Wood: ?
	Metal Ore: 1000
	Furnace Slots: 4
	Smelt Ratio: 1:1
	Time Per Smelt: 10s
	Wood Burns at a rate of 30 wood per minute, or one wood every 2 seconds.

	== 1000/4*5

*/
