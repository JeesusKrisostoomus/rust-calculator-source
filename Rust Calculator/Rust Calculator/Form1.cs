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
    public partial class Form1 : Form
    {
		Thread thread;
		public int DecaysIn;
		public int MinimumValue = 0;

		public Form1()
        {
            InitializeComponent();
        }

		private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
		{

		}

		private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
		{

		}

		private void textBox1_TextChanged(object sender, EventArgs e)
		{

		}

		private void button1_Click(object sender, EventArgs e)
		{
			int selectedIndex = comboBox1.SelectedIndex;
			Object selectedItem = comboBox1.SelectedItem;
			int CurrentHealth = Convert.ToInt32(textBox1.Text);


			if (selectedItem == "Twig")
			{
				if (CurrentHealth < MinimumValue)
				{
					MessageBox.Show("Health Cannot Be Less Than 0", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
				}
				else
				{
					DecaysIn = CurrentHealth * 1 / 5;
					decayLabel.Text = "Decays in: " + DecaysIn.ToString() + " Minutes.";
				}
			}
			else if (selectedItem == "Wood")
			{
				if (CurrentHealth < MinimumValue)
				{
					MessageBox.Show("Health Cannot Be Less Than 0", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
				}
				else
				{
					DecaysIn = CurrentHealth * 2 / 5;
					decayLabel.Text = "Decays in: " + DecaysIn.ToString() + " Minutes.";
				}
			}
			else if (selectedItem == "Stone")
			{
				if (CurrentHealth < MinimumValue)
				{
					MessageBox.Show("Health Cannot Be Less Than 0", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
				}
				else
				{
					DecaysIn = CurrentHealth * 3 / 5;
					decayLabel.Text = "Decays in: " + DecaysIn.ToString() + " Minutes.";
				}
			}
			else if (selectedItem == "Metal")
			{
				if (CurrentHealth < MinimumValue)
				{
					MessageBox.Show("Health Cannot Be Less Than 0", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
				}
				else
				{
					DecaysIn = CurrentHealth * 4 / 5;
					decayLabel.Text = "Decays in: " + DecaysIn.ToString() + " Minutes.";
				}
			}
			else if (selectedItem == "Armored")
			{
				if (CurrentHealth < MinimumValue)
				{
					MessageBox.Show("Health Cannot Be Less Than 0", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
				}
				else
				{
					DecaysIn = CurrentHealth * 5 / 5;
					decayLabel.Text = "Decays in: " + DecaysIn.ToString() + " Minutes.";
				}
			}
		}

		private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
		{

		}

		private void Form1_Load(object sender, EventArgs e)
		{
			this.comboBox1.DropDownStyle = ComboBoxStyle.DropDownList;
		}

		private void label3_Click(object sender, EventArgs e)
		{

		}


		private void smeltingCalculatorToolStripMenuItem_Click_1(object sender, EventArgs e)
		{
			this.Close();
			thread = new Thread(smeltingcalc);
			thread.SetApartmentState(ApartmentState.STA);
			thread.Start();
		}

		private void decayCalculatorToolStripMenuItem_Click_1(object sender, EventArgs e)
		{
			MessageBox.Show("This window is already open.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
		}
		private void smeltingcalc(object obj)
		{
			Application.Run(new Form2());
		}
		private void craftingcalc(object obj)
		{
			Application.Run(new CraftingCalc());
		}


		private void infoToolStripMenuItem_Click(object sender, EventArgs e)
		{
			MessageBox.Show("Developer: Jeesus Krisostoomus#7737.\nSpecial thanks to Dubys#3047 for help. \n\nDecay times are accurate for only vanilla decay rates.\n\nFurnace smelting times are accurate for only vanilla smelting rates.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
