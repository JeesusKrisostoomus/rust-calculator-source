namespace Rust_Calculator
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.decayLabel = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.calculatorsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.decayCalculatorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.smeltingCalculatorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.infoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.craftingCalculatorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.comboBox1.Items.AddRange(new object[] {
            "Twig",
            "Wood",
            "Stone",
            "Metal",
            "Armored"});
            this.comboBox1.Location = new System.Drawing.Point(10, 45);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 21);
            this.comboBox1.TabIndex = 0;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(160, 46);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 2;
            this.textBox1.Text = "0";
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(36, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Material Type";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.toolTip1.SetToolTip(this.label1, "The material of which the building object is made of.");
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(175, 30);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(75, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Current Health";
            this.label3.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.toolTip1.SetToolTip(this.label3, "Current health the building object has");
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // decayLabel
            // 
            this.decayLabel.AutoSize = true;
            this.decayLabel.Location = new System.Drawing.Point(157, 88);
            this.decayLabel.Name = "decayLabel";
            this.decayLabel.Size = new System.Drawing.Size(67, 13);
            this.decayLabel.TabIndex = 6;
            this.decayLabel.Text = "Decays In: ?";
            this.decayLabel.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(18, 83);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 8;
            this.button1.Text = "Calculate";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.calculatorsToolStripMenuItem,
            this.infoToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(295, 24);
            this.menuStrip1.TabIndex = 10;
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
            // toolTip1
            // 
            this.toolTip1.ToolTipTitle = "Tip";
            // 
            // craftingCalculatorToolStripMenuItem
            // 
            this.craftingCalculatorToolStripMenuItem.Name = "craftingCalculatorToolStripMenuItem";
            this.craftingCalculatorToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.craftingCalculatorToolStripMenuItem.Text = "Crafting Calculator";
            this.craftingCalculatorToolStripMenuItem.Click += new System.EventHandler(this.craftingCalculatorToolStripMenuItem_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(295, 122);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.decayLabel);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.comboBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Decay Calculator";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

		#endregion

		private System.Windows.Forms.ComboBox comboBox1;
		private System.Windows.Forms.TextBox textBox1;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label decayLabel;
		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.MenuStrip menuStrip1;
		private System.Windows.Forms.ToolStripMenuItem calculatorsToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem decayCalculatorToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem smeltingCalculatorToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem infoToolStripMenuItem;
		private System.Windows.Forms.ToolTip toolTip1;
		private System.Windows.Forms.ToolStripMenuItem craftingCalculatorToolStripMenuItem;
	}
}

