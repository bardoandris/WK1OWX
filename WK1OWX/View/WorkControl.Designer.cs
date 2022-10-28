namespace WK1OWX
{
	partial class WorkControl
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

		#region Component Designer generated code

		/// <summary> 
		/// Required method for Designer support - do not modify 
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.WorkNameLabel = new System.Windows.Forms.Label();
			this.MaterialCostLabel = new System.Windows.Forms.Label();
			this.TimeLabel = new System.Windows.Forms.Label();
			this.SelectBox = new System.Windows.Forms.CheckBox();
			this.WorkTimeCost = new System.Windows.Forms.Label();
			this.SuspendLayout();
			// 
			// WorkNameLabel
			// 
			this.WorkNameLabel.AutoSize = true;
			this.WorkNameLabel.Location = new System.Drawing.Point(3, 12);
			this.WorkNameLabel.Name = "WorkNameLabel";
			this.WorkNameLabel.Size = new System.Drawing.Size(38, 15);
			this.WorkNameLabel.TabIndex = 0;
			this.WorkNameLabel.Text = "label1";
			// 
			// MaterialCostLabel
			// 
			this.MaterialCostLabel.AutoSize = true;
			this.MaterialCostLabel.Location = new System.Drawing.Point(174, 13);
			this.MaterialCostLabel.Name = "MaterialCostLabel";
			this.MaterialCostLabel.Size = new System.Drawing.Size(38, 15);
			this.MaterialCostLabel.TabIndex = 1;
			this.MaterialCostLabel.Text = "label1";
			// 
			// TimeLabel
			// 
			this.TimeLabel.AutoSize = true;
			this.TimeLabel.Location = new System.Drawing.Point(246, 13);
			this.TimeLabel.Name = "TimeLabel";
			this.TimeLabel.Size = new System.Drawing.Size(38, 15);
			this.TimeLabel.TabIndex = 2;
			this.TimeLabel.Text = "label1";
			// 
			// SelectBox
			// 
			this.SelectBox.AutoSize = true;
			this.SelectBox.Location = new System.Drawing.Point(339, 14);
			this.SelectBox.Name = "SelectBox";
			this.SelectBox.Size = new System.Drawing.Size(15, 14);
			this.SelectBox.TabIndex = 3;
			this.SelectBox.UseVisualStyleBackColor = true;
			this.SelectBox.CheckedChanged += new System.EventHandler(this.SelectBox_CheckedChanged);
			// 
			// WorkTimeCost
			// 
			this.WorkTimeCost.AutoSize = true;
			this.WorkTimeCost.Location = new System.Drawing.Point(414, 14);
			this.WorkTimeCost.Name = "WorkTimeCost";
			this.WorkTimeCost.Size = new System.Drawing.Size(38, 15);
			this.WorkTimeCost.TabIndex = 4;
			this.WorkTimeCost.Text = "label1";
			// 
			// WorkControl
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.Controls.Add(this.WorkTimeCost);
			this.Controls.Add(this.SelectBox);
			this.Controls.Add(this.TimeLabel);
			this.Controls.Add(this.MaterialCostLabel);
			this.Controls.Add(this.WorkNameLabel);
			this.Name = "WorkControl";
			this.Size = new System.Drawing.Size(522, 40);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private Label WorkNameLabel;
		private Label MaterialCostLabel;
		private Label TimeLabel;
		private CheckBox SelectBox;
		private Label WorkTimeCost;
	}
}
