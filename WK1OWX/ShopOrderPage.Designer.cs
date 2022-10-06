namespace WK1OWX
{
	partial class ShopOrderPage
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
			this.WorkTable = new System.Windows.Forms.TableLayoutPanel();
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.panel1 = new System.Windows.Forms.Panel();
			this.RogzitesGomb = new System.Windows.Forms.Button();
			this.panel1.SuspendLayout();
			this.SuspendLayout();
			// 
			// WorkTable
			// 
			this.WorkTable.AutoScroll = true;
			this.WorkTable.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
			this.WorkTable.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.InsetDouble;
			this.WorkTable.ColumnCount = 5;
			this.WorkTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 39.14027F));
			this.WorkTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 26.92308F));
			this.WorkTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 24.66063F));
			this.WorkTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 9.036144F));
			this.WorkTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 120F));
			this.WorkTable.Location = new System.Drawing.Point(1, 32);
			this.WorkTable.Name = "WorkTable";
			this.WorkTable.RowCount = 1;
			this.WorkTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50F));
			this.WorkTable.Size = new System.Drawing.Size(570, 238);
			this.WorkTable.TabIndex = 0;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(12, 9);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(72, 15);
			this.label1.TabIndex = 1;
			this.label1.Text = "Munka neve";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(179, 14);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(79, 15);
			this.label2.TabIndex = 2;
			this.label2.Text = "Anyagköltség";
			// 
			// panel1
			// 
			this.panel1.Controls.Add(this.RogzitesGomb);
			this.panel1.Location = new System.Drawing.Point(1, 276);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(570, 51);
			this.panel1.TabIndex = 3;
			// 
			// RogzitesGomb
			// 
			this.RogzitesGomb.Location = new System.Drawing.Point(482, 16);
			this.RogzitesGomb.Name = "RogzitesGomb";
			this.RogzitesGomb.Size = new System.Drawing.Size(75, 23);
			this.RogzitesGomb.TabIndex = 0;
			this.RogzitesGomb.Text = "Rögzítés";
			this.RogzitesGomb.UseVisualStyleBackColor = true;
			this.RogzitesGomb.Click += new System.EventHandler(this.RogzitesGomb_Click);
			// 
			// ShopOrderPage
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(570, 327);
			this.Controls.Add(this.panel1);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.WorkTable);
			this.Name = "ShopOrderPage";
			this.Text = "ShopOrderPage";
			this.panel1.ResumeLayout(false);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private TableLayoutPanel WorkTable;
		private Label label1;
		private Label label2;
		private Panel panel1;
		private Button RogzitesGomb;
	}
}