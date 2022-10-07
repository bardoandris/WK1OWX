namespace WK1OWX
{
	partial class Form1
	{
		/// <summary>
		///  Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		///  Clean up any resources being used.
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
		///  Required method for Designer support - do not modify
		///  the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.components = new System.ComponentModel.Container();
			this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
			this.Menu = new System.Windows.Forms.MenuStrip();
			this.FileMenuButton = new System.Windows.Forms.ToolStripMenuItem();
			this.munkalapToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.fizetésToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.névjegyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.kilépésToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.Menu.SuspendLayout();
			this.SuspendLayout();
			// 
			// contextMenuStrip1
			// 
			this.contextMenuStrip1.Name = "contextMenuStrip1";
			this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
			// 
			// Menu
			// 
			this.Menu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.FileMenuButton,
            this.munkalapToolStripMenuItem,
            this.fizetésToolStripMenuItem,
            this.névjegyToolStripMenuItem,
            this.kilépésToolStripMenuItem});
			this.Menu.Location = new System.Drawing.Point(0, 0);
			this.Menu.Name = "Menu";
			this.Menu.Size = new System.Drawing.Size(800, 24);
			this.Menu.TabIndex = 2;
			this.Menu.Text = "menuStrip1";
			// 
			// FileMenuButton
			// 
			this.FileMenuButton.Name = "FileMenuButton";
			this.FileMenuButton.Size = new System.Drawing.Size(101, 20);
			this.FileMenuButton.Text = "Fájl Megnyitása";
			this.FileMenuButton.Click += new System.EventHandler(this.fájlMegnyitásaToolStripMenuItem_Click);
			// 
			// munkalapToolStripMenuItem
			// 
			this.munkalapToolStripMenuItem.Enabled = false;
			this.munkalapToolStripMenuItem.Name = "munkalapToolStripMenuItem";
			this.munkalapToolStripMenuItem.Size = new System.Drawing.Size(81, 20);
			this.munkalapToolStripMenuItem.Text = "Munkalap...";
			this.munkalapToolStripMenuItem.Click += new System.EventHandler(this.munkalapToolStripMenuItem_Click);
			// 
			// fizetésToolStripMenuItem
			// 
			this.fizetésToolStripMenuItem.Enabled = false;
			this.fizetésToolStripMenuItem.Name = "fizetésToolStripMenuItem";
			this.fizetésToolStripMenuItem.Size = new System.Drawing.Size(63, 20);
			this.fizetésToolStripMenuItem.Text = "Fizetés...";
			this.fizetésToolStripMenuItem.Click += new System.EventHandler(this.fizetésToolStripMenuItem_Click);
			// 
			// névjegyToolStripMenuItem
			// 
			this.névjegyToolStripMenuItem.Name = "névjegyToolStripMenuItem";
			this.névjegyToolStripMenuItem.Size = new System.Drawing.Size(71, 20);
			this.névjegyToolStripMenuItem.Text = "Névjegy...";
			this.névjegyToolStripMenuItem.Click += new System.EventHandler(this.névjegyToolStripMenuItem_Click);
			// 
			// kilépésToolStripMenuItem
			// 
			this.kilépésToolStripMenuItem.Name = "kilépésToolStripMenuItem";
			this.kilépésToolStripMenuItem.Size = new System.Drawing.Size(65, 20);
			this.kilépésToolStripMenuItem.Text = "Kilépés...";
			this.kilépésToolStripMenuItem.Click += new System.EventHandler(this.kilépésToolStripMenuItem_Click);
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(800, 450);
			this.Controls.Add(this.Menu);
			this.Name = "Form1";
			this.Text = "Form1";
			this.Load += new System.EventHandler(this.Form1_Load);
			this.Menu.ResumeLayout(false);
			this.Menu.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private ContextMenuStrip contextMenuStrip1;
		private MenuStrip Menu;
		private ToolStripMenuItem FileMenuButton;
		private ToolStripMenuItem munkalapToolStripMenuItem;
		private ToolStripMenuItem fizetésToolStripMenuItem;
		private ToolStripMenuItem névjegyToolStripMenuItem;
		private ToolStripMenuItem kilépésToolStripMenuItem;
	}
}