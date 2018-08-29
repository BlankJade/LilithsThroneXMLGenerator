namespace LilithsThroneXMLGenerator
{
	partial class Chooser
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Chooser));
			this.textBox1 = new System.Windows.Forms.TextBox();
			this.modChooser = new System.Windows.Forms.ComboBox();
			this.button1 = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// textBox1
			// 
			this.textBox1.Enabled = false;
			this.textBox1.Location = new System.Drawing.Point(12, 12);
			this.textBox1.Multiline = true;
			this.textBox1.Name = "textBox1";
			this.textBox1.ReadOnly = true;
			this.textBox1.Size = new System.Drawing.Size(260, 33);
			this.textBox1.TabIndex = 0;
			this.textBox1.Text = "Create new Mod\r\nChoose a mod Type";
			this.textBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			// 
			// modChooser
			// 
			this.modChooser.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.modChooser.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
			this.modChooser.FormattingEnabled = true;
			this.modChooser.Items.AddRange(new object[] {
            "Clothing",
            "Weapon",
            "Tattoo"});
			this.modChooser.Location = new System.Drawing.Point(12, 51);
			this.modChooser.Name = "modChooser";
			this.modChooser.Size = new System.Drawing.Size(260, 21);
			this.modChooser.TabIndex = 1;
			// 
			// button1
			// 
			this.button1.Location = new System.Drawing.Point(79, 126);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(127, 23);
			this.button1.TabIndex = 2;
			this.button1.Text = "Start";
			this.button1.UseVisualStyleBackColor = true;
			this.button1.Click += new System.EventHandler(this.button1_Click);
			// 
			// Chooser
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(284, 161);
			this.Controls.Add(this.button1);
			this.Controls.Add(this.modChooser);
			this.Controls.Add(this.textBox1);
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.MaximumSize = new System.Drawing.Size(300, 200);
			this.MinimumSize = new System.Drawing.Size(300, 200);
			this.Name = "Chooser";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "LTXMLGen";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.TextBox textBox1;
		private System.Windows.Forms.ComboBox modChooser;
		private System.Windows.Forms.Button button1;
	}
}