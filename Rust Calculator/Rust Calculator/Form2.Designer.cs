namespace Rust_Calculator
{
	partial class Form2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form2));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.calculatorsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.decayCalculatorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.smeltingCalculatorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.infoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.smeltingInfo = new System.Windows.Forms.Label();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.label5 = new System.Windows.Forms.Label();
            this.craftingCalculatorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
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
            this.menuStrip1.Size = new System.Drawing.Size(381, 24);
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
            // decayCalculatorToolStripMenuItem
            // 
            this.decayCalculatorToolStripMenuItem.Name = "decayCalculatorToolStripMenuItem";
            this.decayCalculatorToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.decayCalculatorToolStripMenuItem.Text = "Decay Calculator";
            this.decayCalculatorToolStripMenuItem.Click += new System.EventHandler(this.decayCalculatorToolStripMenuItem_Click_1);
            // 
            // smeltingCalculatorToolStripMenuItem
            // 
            this.smeltingCalculatorToolStripMenuItem.Name = "smeltingCalculatorToolStripMenuItem";
            this.smeltingCalculatorToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.smeltingCalculatorToolStripMenuItem.Text = "Smelting Calculator";
            this.smeltingCalculatorToolStripMenuItem.Click += new System.EventHandler(this.smeltingCalculatorToolStripMenuItem_Click_1);
            // 
            // infoToolStripMenuItem
            // 
            this.infoToolStripMenuItem.Name = "infoToolStripMenuItem";
            this.infoToolStripMenuItem.Size = new System.Drawing.Size(40, 20);
            this.infoToolStripMenuItem.Text = "Info";
            this.infoToolStripMenuItem.Click += new System.EventHandler(this.infoToolStripMenuItem_Click);
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Metal Ore",
            "Sulfur Ore",
            "High Quality Metal Ore",
            "Crude Oil"});
            this.comboBox1.Location = new System.Drawing.Point(12, 45);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 21);
            this.comboBox1.TabIndex = 1;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(53, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(24, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Ore";
            this.toolTip1.SetToolTip(this.label1, "The item that you want to smelt.");
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(269, 45);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 3;
            this.textBox1.Text = "0";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(298, 29);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Amount";
            this.toolTip1.SetToolTip(this.label2, "Amount of the items you want to smelt.");
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(12, 73);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 5;
            this.button1.Text = "Calculate";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // comboBox2
            // 
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10",
            "11",
            "12",
            "13",
            "14",
            "15"});
            this.comboBox2.Location = new System.Drawing.Point(142, 45);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(121, 21);
            this.comboBox2.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(182, 29);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(30, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Slots";
            this.toolTip1.SetToolTip(this.label3, "Amount of slots that your items are devided over.");
            // 
            // smeltingInfo
            // 
            this.smeltingInfo.AutoSize = true;
            this.smeltingInfo.Location = new System.Drawing.Point(141, 69);
            this.smeltingInfo.Name = "smeltingInfo";
            this.smeltingInfo.Size = new System.Drawing.Size(71, 13);
            this.smeltingInfo.TabIndex = 8;
            this.smeltingInfo.Text = "Smelting Info:";
            // 
            // toolTip1
            // 
            this.toolTip1.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            this.toolTip1.ToolTipTitle = "Tip";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.Color.Blue;
            this.label5.Location = new System.Drawing.Point(81, 113);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(206, 13);
            this.label5.TabIndex = 10;
            this.label5.Text = "Hover your mouse over the labels for help.";
            // 
            // craftingCalculatorToolStripMenuItem
            // 
            this.craftingCalculatorToolStripMenuItem.Name = "craftingCalculatorToolStripMenuItem";
            this.craftingCalculatorToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.craftingCalculatorToolStripMenuItem.Text = "Crafting Calculator";
            this.craftingCalculatorToolStripMenuItem.Click += new System.EventHandler(this.craftingCalculatorToolStripMenuItem_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(381, 135);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.smeltingInfo);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.comboBox2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.HelpButton = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form2";
            this.Text = "Smelting Calculator";
            this.Load += new System.EventHandler(this.Form2_Load);
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
		private System.Windows.Forms.ToolStripMenuItem infoToolStripMenuItem;
		private System.Windows.Forms.ComboBox comboBox1;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.TextBox textBox1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.ComboBox comboBox2;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label smeltingInfo;
		private System.Windows.Forms.ToolTip toolTip1;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.ToolStripMenuItem craftingCalculatorToolStripMenuItem;
	}
}
