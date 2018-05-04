namespace ExcelIntegration
{
	partial class ItemMarkingForm
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
			this.btnTest = new System.Windows.Forms.Button();
			this.dgvLotGrid = new System.Windows.Forms.DataGridView();
			this.tbSerial = new System.Windows.Forms.TextBox();
			this.lblSerial = new System.Windows.Forms.Label();
			this.btnAddSerial = new System.Windows.Forms.Button();
			this.btnSetLot = new System.Windows.Forms.Button();
			this.lblSetLot = new System.Windows.Forms.Label();
			this.tbLot = new System.Windows.Forms.TextBox();
			this.lblActiveLot = new System.Windows.Forms.Label();
			this.btnPublishReport = new System.Windows.Forms.Button();
			((System.ComponentModel.ISupportInitialize)(this.dgvLotGrid)).BeginInit();
			this.SuspendLayout();
			// 
			// btnTest
			// 
			this.btnTest.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.btnTest.Location = new System.Drawing.Point(366, 423);
			this.btnTest.Name = "btnTest";
			this.btnTest.Size = new System.Drawing.Size(75, 23);
			this.btnTest.TabIndex = 0;
			this.btnTest.Text = "Test Excel";
			this.btnTest.UseVisualStyleBackColor = true;
			this.btnTest.Click += new System.EventHandler(this.btnTest_Click);
			// 
			// dgvLotGrid
			// 
			this.dgvLotGrid.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.dgvLotGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dgvLotGrid.Location = new System.Drawing.Point(12, 112);
			this.dgvLotGrid.Name = "dgvLotGrid";
			this.dgvLotGrid.Size = new System.Drawing.Size(429, 305);
			this.dgvLotGrid.TabIndex = 1;
			// 
			// tbSerial
			// 
			this.tbSerial.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.tbSerial.Location = new System.Drawing.Point(341, 23);
			this.tbSerial.Name = "tbSerial";
			this.tbSerial.Size = new System.Drawing.Size(100, 20);
			this.tbSerial.TabIndex = 2;
			// 
			// lblSerial
			// 
			this.lblSerial.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.lblSerial.AutoSize = true;
			this.lblSerial.Location = new System.Drawing.Point(299, 28);
			this.lblSerial.Name = "lblSerial";
			this.lblSerial.Size = new System.Drawing.Size(36, 13);
			this.lblSerial.TabIndex = 3;
			this.lblSerial.Text = "Serial:";
			// 
			// btnAddSerial
			// 
			this.btnAddSerial.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.btnAddSerial.Location = new System.Drawing.Point(366, 49);
			this.btnAddSerial.Name = "btnAddSerial";
			this.btnAddSerial.Size = new System.Drawing.Size(75, 23);
			this.btnAddSerial.TabIndex = 4;
			this.btnAddSerial.Text = "Add Serial";
			this.btnAddSerial.UseVisualStyleBackColor = true;
			this.btnAddSerial.Click += new System.EventHandler(this.btnAddSerial_Click);
			// 
			// btnSetLot
			// 
			this.btnSetLot.Location = new System.Drawing.Point(67, 49);
			this.btnSetLot.Name = "btnSetLot";
			this.btnSetLot.Size = new System.Drawing.Size(75, 23);
			this.btnSetLot.TabIndex = 7;
			this.btnSetLot.Text = "Set Lot";
			this.btnSetLot.UseVisualStyleBackColor = true;
			this.btnSetLot.Click += new System.EventHandler(this.btnSetLot_Click);
			// 
			// lblSetLot
			// 
			this.lblSetLot.AutoSize = true;
			this.lblSetLot.Location = new System.Drawing.Point(11, 28);
			this.lblSetLot.Name = "lblSetLot";
			this.lblSetLot.Size = new System.Drawing.Size(25, 13);
			this.lblSetLot.TabIndex = 6;
			this.lblSetLot.Text = "Lot:";
			// 
			// tbLot
			// 
			this.tbLot.Location = new System.Drawing.Point(42, 25);
			this.tbLot.Name = "tbLot";
			this.tbLot.Size = new System.Drawing.Size(100, 20);
			this.tbLot.TabIndex = 5;
			// 
			// lblActiveLot
			// 
			this.lblActiveLot.AutoSize = true;
			this.lblActiveLot.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblActiveLot.Location = new System.Drawing.Point(12, 89);
			this.lblActiveLot.Name = "lblActiveLot";
			this.lblActiveLot.Size = new System.Drawing.Size(32, 20);
			this.lblActiveLot.TabIndex = 8;
			this.lblActiveLot.Text = "Lot";
			// 
			// btnPublishReport
			// 
			this.btnPublishReport.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.btnPublishReport.Location = new System.Drawing.Point(12, 423);
			this.btnPublishReport.Name = "btnPublishReport";
			this.btnPublishReport.Size = new System.Drawing.Size(94, 23);
			this.btnPublishReport.TabIndex = 9;
			this.btnPublishReport.Text = "Publish Report";
			this.btnPublishReport.UseVisualStyleBackColor = true;
			this.btnPublishReport.Click += new System.EventHandler(this.btnPublishReport_Click);
			// 
			// ItemMarkingForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(453, 456);
			this.Controls.Add(this.btnPublishReport);
			this.Controls.Add(this.lblActiveLot);
			this.Controls.Add(this.btnSetLot);
			this.Controls.Add(this.lblSetLot);
			this.Controls.Add(this.tbLot);
			this.Controls.Add(this.btnAddSerial);
			this.Controls.Add(this.lblSerial);
			this.Controls.Add(this.tbSerial);
			this.Controls.Add(this.dgvLotGrid);
			this.Controls.Add(this.btnTest);
			this.MinimumSize = new System.Drawing.Size(318, 251);
			this.Name = "ItemMarkingForm";
			this.Text = "ItemMarkingForm";
			((System.ComponentModel.ISupportInitialize)(this.dgvLotGrid)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Button btnTest;
		private System.Windows.Forms.DataGridView dgvLotGrid;
		private System.Windows.Forms.TextBox tbSerial;
		private System.Windows.Forms.Label lblSerial;
		private System.Windows.Forms.Button btnAddSerial;
		private System.Windows.Forms.Button btnSetLot;
		private System.Windows.Forms.Label lblSetLot;
		private System.Windows.Forms.TextBox tbLot;
		private System.Windows.Forms.Label lblActiveLot;
		private System.Windows.Forms.Button btnPublishReport;
	}
}

