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
using System.Security.Cryptography.X509Certificates;

namespace Rust_Calculator
{
	public partial class CraftingCalc : Form
	{
		Thread thread;

		public int MetalNeeded;
		public int RopeNeeded;
		public int SulfurNeeded;
		public int CharcoalNeeded;
		public int ClothNeeded;
		public int WoodNeeded;
		public int AnimalFatNeeded;
		public int PipesNeeded;

		public CraftingCalc()
		{
			InitializeComponent();
		}

		private void CraftingCalc_Load(object sender, EventArgs e)
		{
			this.comboBox1.DropDownStyle = ComboBoxStyle.DropDownList;
		}

		private void smeltingcalc(object obj)
		{
			Application.Run(new Form2());
		}

		private void DecayCalc(object obj)
		{
			Application.Run(new Form1());
		}

		private void decayCalculatorToolStripMenuItem_Click(object sender, EventArgs e)
		{
			this.Close();
			thread = new Thread(DecayCalc);
			thread.SetApartmentState(ApartmentState.STA);
			thread.Start();
		}

		private void smeltingCalculatorToolStripMenuItem_Click(object sender, EventArgs e)
		{
			this.Close();
			thread = new Thread(smeltingcalc);
			thread.SetApartmentState(ApartmentState.STA);
			thread.Start();
		}

		private void craftingCalculatorToolStripMenuItem_Click(object sender, EventArgs e)
		{
			MessageBox.Show("This window is already open.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
		}

		private void infoToolStripMenuItem_Click(object sender, EventArgs e)
		{
			MessageBox.Show("Developer: Jeesus Krisostoomus#7737.\nSpecial thanks to Dubys#3047 for help. \n\nDecay times are accurate for only vanilla decay rates.\n\nFurnace smelting times are accurate for only vanilla smelting rates.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
		}

		private void button1_Click(object sender, EventArgs e)
		{
			if (textBox1.Text != "")
			{
				int Amount = Convert.ToInt32(textBox1.Text);
				if (comboBox1.SelectedItem == "Satchel")
				{
					label2.Text = "It Takes:\n- Metal: " + MetalNeeded * Amount + "\n- Rope: " + RopeNeeded * Amount + "\n- Sulfur: " + SulfurNeeded * Amount + "\n- Charcoal: " + CharcoalNeeded * Amount + "\n- Cloth: " + ClothNeeded * Amount + "\nTo Craft " + textBox1.Text + " " + comboBox1.SelectedItem + "'s";
				}
				else if (comboBox1.SelectedItem == "Hatchet")
				{
					label2.Text = "It Takes:\n- Metal: " + MetalNeeded * Amount + "\n- Wood: " + WoodNeeded * Amount  + "\nTo Craft " + textBox1.Text + " " + comboBox1.SelectedItem + "'s";
				}
				else if (comboBox1.SelectedItem == "Pickaxe")
				{
					label2.Text = "It Takes:\n- Metal: " + MetalNeeded * Amount + "\n- Wood: " + WoodNeeded * Amount + "\nTo Craft " + textBox1.Text + " " + comboBox1.SelectedItem + "'s";
				}
				else if (comboBox1.SelectedItem == "Explosives")
				{
					label2.Text = "It Takes:\n- Metal: " + MetalNeeded * Amount + "\n- Sulfur: " + SulfurNeeded * Amount + "\n- Charcoal: " + CharcoalNeeded * Amount + "\n- Cloth: " + ClothNeeded * Amount + "\n- Animal Fat: " + AnimalFatNeeded * Amount + "\nTo Craft " + textBox1.Text + " " + comboBox1.SelectedItem + "'s";
				}
				else if (comboBox1.SelectedItem == "Gun Powder")
				{
					label2.Text = "It Takes:\n- Sulfur: " + SulfurNeeded * Amount + "\n- Charcoal: " + CharcoalNeeded * Amount + "\nTo Craft " + textBox1.Text + " " + comboBox1.SelectedItem + "'s";
				}
				else if (comboBox1.SelectedItem == "Low Grade Fuel")
				{
					label2.Text = "It Takes:\n- Animal Fat: " + AnimalFatNeeded * Amount + "\n- Cloth: " + ClothNeeded * Amount + "\nTo Craft " + textBox1.Text + " " + comboBox1.SelectedItem + "'s";
				}
				else if (comboBox1.SelectedItem == "Pistol Bullet")
				{
					label2.Text = "It Takes:\n- Metal: " + MetalNeeded * Amount + "\n- Sulfur: " + SulfurNeeded * Amount + "\n- Charcoal: " + CharcoalNeeded * Amount + "\nTo Craft " + textBox1.Text + " " + comboBox1.SelectedItem + "'s";
				}
				else if (comboBox1.SelectedItem == "5.56 Rifle Ammo")
				{
					label2.Text = "It Takes:\n- Metal: " + MetalNeeded * Amount + "\n- Sulfur: " + SulfurNeeded * Amount + "\n- Charcoal: " + CharcoalNeeded * Amount + "\nTo Craft " + textBox1.Text + " " + comboBox1.SelectedItem + "'s";
				}
				else if (comboBox1.SelectedItem == "Explosive 5.56 Rifle Ammo")
				{
					label2.Text = "It Takes:\n- Metal: " + MetalNeeded * Amount + "\n- Sulfur: " + SulfurNeeded * Amount + "\n- Charcoal: " + CharcoalNeeded * Amount + "\nTo Craft " + textBox1.Text + " " + comboBox1.SelectedItem + "'s";
				}
				else if (comboBox1.SelectedItem == "HV 5.56 Rifle Ammo")
				{
					label2.Text = "It Takes:\n- Metal: " + MetalNeeded * Amount + "\n- Sulfur: " + SulfurNeeded * Amount + "\n- Charcoal: " + CharcoalNeeded * Amount + "\nTo Craft " + textBox1.Text + " " + comboBox1.SelectedItem + "'s";
				}
				else if (comboBox1.SelectedItem == "Incendiary 5.56 Rifle Ammo")
				{
					label2.Text = "It Takes:\n- Metal: " + MetalNeeded * Amount + "\n- Sulfur: " + SulfurNeeded * Amount + "\n- Charcoal: " + CharcoalNeeded * Amount + "\n- Cloth: " + ClothNeeded * Amount + "\n- Animal Fat: " + AnimalFatNeeded * Amount + "\nTo Craft " + textBox1.Text + " " + comboBox1.SelectedItem + "'s";
				}
				else if (comboBox1.SelectedItem == "Rocket")
				{
					label2.Text = "It Takes:\n- Metal: " + MetalNeeded * Amount + "\n- Metal Pipes: " + PipesNeeded * Amount + "\n- Sulfur: " + SulfurNeeded * Amount + "\n- Charcoal: " + CharcoalNeeded * Amount + "\n- Cloth: " + ClothNeeded * Amount + "\n- Animal Fat: " + AnimalFatNeeded * Amount + "\nTo Craft " + textBox1.Text + " " + comboBox1.SelectedItem + "'s";
				}
				else if (comboBox1.SelectedItem == "High Velocity Rocket")
				{
					label2.Text = "It Takes:\n- Pipes: " + PipesNeeded * Amount + "\n- Sulfur: " + SulfurNeeded * Amount + "\n- Charcoal: " + CharcoalNeeded * Amount + "\nTo Craft " + textBox1.Text + " " + comboBox1.SelectedItem + "'s";
				}
				else if (comboBox1.SelectedItem == "Incendiary Rocket")
				{
					label2.Text = "It Takes:\n- Metal: " + MetalNeeded * Amount + "\n- Pipes: " + PipesNeeded * Amount + "\n- Sulfur: " + SulfurNeeded * Amount + "\n- Charcoal: " + CharcoalNeeded * Amount + "\n- Cloth: " + ClothNeeded * Amount + "\n- Animal Fat: " + AnimalFatNeeded * Amount + "\nTo Craft " + textBox1.Text + " " + comboBox1.SelectedItem + "'s";
				}
				else
				{
					//High Velocity Rocket
					MessageBox.Show("Combo box can't be empty!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
				}
			}
			else
			{
				MessageBox.Show("Amount field cant be empty!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}

		private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
		{
			if (comboBox1.SelectedItem == "Satchel")
			{
				MetalNeeded = 80;
				RopeNeeded = 1;
				SulfurNeeded = 480;
				CharcoalNeeded = 720;
				ClothNeeded = 10;
			}
			else if (comboBox1.SelectedItem == "Hatchet")
			{
				WoodNeeded = 100;
				MetalNeeded = 75;
			}
			else if (comboBox1.SelectedItem == "Pickaxe")
			{
				WoodNeeded = 100;
				MetalNeeded = 125;
			}
			else if (comboBox1.SelectedItem == "Explosives")
			{
				MetalNeeded = 10;
				SulfurNeeded = 110;
				CharcoalNeeded = 150;
				ClothNeeded = 1;
				AnimalFatNeeded = 3;
			}
			else if (comboBox1.SelectedItem == "Gun Powder")
			{
				CharcoalNeeded = 30;
				SulfurNeeded = 20;
			}
			else if (comboBox1.SelectedItem == "Low Grade Fuel")
			{
				AnimalFatNeeded = 3;
				ClothNeeded = 1;
			}
			else if (comboBox1.SelectedItem == "Pistol Bullet")
			{
				MetalNeeded = 10;
				SulfurNeeded = 20;
				CharcoalNeeded = 30;
			}
			else if (comboBox1.SelectedItem == "5.56 Rifle Ammo")
			{
				MetalNeeded = 10;
				SulfurNeeded = 20;
				CharcoalNeeded = 30;
			}
			else if (comboBox1.SelectedItem == "Explosive 5.56 Rifle Ammo")
			{
				MetalNeeded = 10;
				SulfurNeeded = 50;
				CharcoalNeeded = 60;
			}
			else if (comboBox1.SelectedItem == "HV 5.56 Rifle Ammo")
			{
				MetalNeeded = 10;
				SulfurNeeded = 40;
				CharcoalNeeded = 60;
			}
			else if (comboBox1.SelectedItem == "Incendiary 5.56 Rifle Ammo")
			{
				MetalNeeded = 10;
				SulfurNeeded = 45;
				CharcoalNeeded = 60;
				ClothNeeded = 1;
				AnimalFatNeeded = 3;
			}
			else if (comboBox1.SelectedItem == "Rocket")
			{
				MetalNeeded = 100;
				PipesNeeded = 2;
				SulfurNeeded = 1400;
				CharcoalNeeded = 1950;
				ClothNeeded = 8;
				AnimalFatNeeded = 24;
			}
			else if (comboBox1.SelectedItem == "High Velocity Rocket")
			{
				PipesNeeded = 1;
				SulfurNeeded = 200;
				CharcoalNeeded = 300;
			}
			else if (comboBox1.SelectedItem == "Incendiary Rocket")
			{
				MetalNeeded = 10;
				PipesNeeded = 2;
				SulfurNeeded = 610;
				CharcoalNeeded = 900;
				ClothNeeded = 64;
				AnimalFatNeeded = 192;
			}
		}

		private void label2_Click(object sender, EventArgs e)
		{

		}
	}
}
