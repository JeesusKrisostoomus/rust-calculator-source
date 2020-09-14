namespace Rust_Calculator
{
	partial class CraftingCalc
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CraftingCalc));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.calculatorsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.infoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.decayCalculatorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.smeltingCalculatorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.craftingCalculatorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.button1 = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.label4 = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.calculatorsToolStripMenuItem,
            this.infoToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(313, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // calculatorsToolStripMenuItem
            // 
            this.calculatorsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.decayCalculatorToolStripMenuItem,
            this.smeltingCalculatorToolStripMenuItem,
            this.craftingCalculatorToolStripMenuItem});
            this.calculatorsToolStripMenuItem.Name = "calculatorsToolStripMenuItem";
            this.calculatorsToolStripMenuItem.Size = new System.Drawing.Size(78, 20);
            this.calculatorsToolStripMenuItem.Text = "Calculators";
            // 
            // infoToolStripMenuItem
            // 
            this.infoToolStripMenuItem.Name = "infoToolStripMenuItem";
            this.infoToolStripMenuItem.Size = new System.Drawing.Size(40, 20);
            this.infoToolStripMenuItem.Text = "Info";
            this.infoToolStripMenuItem.Click += new System.EventHandler(this.infoToolStripMenuItem_Click);
            // 
            // decayCalculatorToolStripMenuItem
            // 
            this.decayCalculatorToolStripMenuItem.Name = "decayCalculatorToolStripMenuItem";
            this.decayCalculatorToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.decayCalculatorToolStripMenuItem.Text = "Decay Calculator";
            this.decayCalculatorToolStripMenuItem.Click += new System.EventHandler(this.decayCalculatorToolStripMenuItem_Click);
            // 
            // smeltingCalculatorToolStripMenuItem
            // 
            this.smeltingCalculatorToolStripMenuItem.Name = "smeltingCalculatorToolStripMenuItem";
            this.smeltingCalculatorToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.smeltingCalculatorToolStripMenuItem.Text = "Smelting Calculator";
            this.smeltingCalculatorToolStripMenuItem.Click += new System.EventHandler(this.smeltingCalculatorToolStripMenuItem_Click);
            // 
            // craftingCalculatorToolStripMenuItem
            // 
            this.craftingCalculatorToolStripMenuItem.Name = "craftingCalculatorToolStripMenuItem";
            this.craftingCalculatorToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.craftingCalculatorToolStripMenuItem.Text = "Crafting Calculator";
            this.craftingCalculatorToolStripMenuItem.Click += new System.EventHandler(this.craftingCalculatorToolStripMenuItem_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(12, 63);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "Calculate";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(193, 39);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 2;
            this.textBox1.Text = "1";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(219, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Amount";
            this.toolTip1.SetToolTip(this.label1, "Enter the amount of items you want to craft");
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "-----Tools-----",
            "Hatchet",
            "Pickaxe",
            "Satchel",
            "-----Resources-----",
            "Explosives",
            "Gun Powder",
            "Low Grade Fuel",
            "-----Ammunition-----",
            "Pistol Bullet",
            "5.56 Rifle Ammo",
            "Explosive 5.56 Rifle Ammo",
            "HV 5.56 Rifle Ammo",
            "Incendiary 5.56 Rifle Ammo",
            "Rocket",
            "High Velocity Rocket",
            "Incendiary Rocket"});
            this.comboBox1.Location = new System.Drawing.Point(12, 39);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(155, 21);
            this.comboBox1.TabIndex = 4;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(100, 68);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Crafting Info:";
            this.toolTip1.SetToolTip(this.label2, "This will only show raw materials needed to craft this item");
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(60, 24);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(27, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Item";
            this.toolTip1.SetToolTip(this.label3, "Select the item, you want to craft");
            // 
            // toolTip1
            // 
            this.toolTip1.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            this.toolTip1.ToolTipTitle = "Tip";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.Color.Blue;
            this.label4.Location = new System.Drawing.Point(12, 190);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(172, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Hover over the labels for more info!";
            // 
            // CraftingCalc
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(313, 212);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "CraftingCalc";
            this.Text = "Crafting Calculator";
            this.Load += new System.EventHandler(this.CraftingCalc_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.MenuStrip menuStrip1;
		private System.Windows.Forms.ToolStripMenuItem calculatorsToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem decayCalculatorToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem smeltingCalculatorToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem craftingCalculatorToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem infoToolStripMenuItem;
		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.TextBox textBox1;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.ComboBox comboBox1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.ToolTip toolTip1;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label4;
	}
}