namespace MechanicShop.Forms
{
    partial class frmVehicle
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
            this.gboVehicleInfo = new System.Windows.Forms.GroupBox();
            this.nudCurrentMileage = new System.Windows.Forms.NumericUpDown();
            this.btnClose = new System.Windows.Forms.Button();
            this.btnVehicleDelete = new System.Windows.Forms.Button();
            this.lblCustomer = new System.Windows.Forms.Label();
            this.lvVehicleList = new System.Windows.Forms.ListView();
            this.Year = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Make = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Model = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.VIN = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Plate = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btnSave = new System.Windows.Forms.Button();
            this.lblStatus = new System.Windows.Forms.Label();
            this.btnVINLookup = new System.Windows.Forms.Button();
            this.lblCurrentMileage = new System.Windows.Forms.Label();
            this.lblLicensePlate = new System.Windows.Forms.Label();
            this.lblYear = new System.Windows.Forms.Label();
            this.lblModel = new System.Windows.Forms.Label();
            this.lblMake = new System.Windows.Forms.Label();
            this.lblVIN = new System.Windows.Forms.Label();
            this.txtLicensePlate = new System.Windows.Forms.TextBox();
            this.txtYear = new System.Windows.Forms.TextBox();
            this.txtModel = new System.Windows.Forms.TextBox();
            this.txtMake = new System.Windows.Forms.TextBox();
            this.txtVIN = new System.Windows.Forms.TextBox();
            this.pnlHeader = new System.Windows.Forms.Panel();
            this.lblSubtitle = new System.Windows.Forms.Label();
            this.lblTitle = new System.Windows.Forms.Label();
            this.gboVehicleInfo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudCurrentMileage)).BeginInit();
            this.pnlHeader.SuspendLayout();
            this.SuspendLayout();
            // 
            // gboVehicleInfo
            // 
            this.gboVehicleInfo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(246)))), ((int)(((byte)(248)))));
            this.gboVehicleInfo.Controls.Add(this.nudCurrentMileage);
            this.gboVehicleInfo.Controls.Add(this.btnClose);
            this.gboVehicleInfo.Controls.Add(this.btnVehicleDelete);
            this.gboVehicleInfo.Controls.Add(this.lblCustomer);
            this.gboVehicleInfo.Controls.Add(this.lvVehicleList);
            this.gboVehicleInfo.Controls.Add(this.btnSave);
            this.gboVehicleInfo.Controls.Add(this.lblStatus);
            this.gboVehicleInfo.Controls.Add(this.btnVINLookup);
            this.gboVehicleInfo.Controls.Add(this.lblCurrentMileage);
            this.gboVehicleInfo.Controls.Add(this.lblLicensePlate);
            this.gboVehicleInfo.Controls.Add(this.lblYear);
            this.gboVehicleInfo.Controls.Add(this.lblModel);
            this.gboVehicleInfo.Controls.Add(this.lblMake);
            this.gboVehicleInfo.Controls.Add(this.lblVIN);
            this.gboVehicleInfo.Controls.Add(this.txtLicensePlate);
            this.gboVehicleInfo.Controls.Add(this.txtYear);
            this.gboVehicleInfo.Controls.Add(this.txtModel);
            this.gboVehicleInfo.Controls.Add(this.txtMake);
            this.gboVehicleInfo.Controls.Add(this.txtVIN);
            this.gboVehicleInfo.Font = new System.Drawing.Font("Arial", 9F);
            this.gboVehicleInfo.Location = new System.Drawing.Point(8, 68);
            this.gboVehicleInfo.Margin = new System.Windows.Forms.Padding(2);
            this.gboVehicleInfo.Name = "gboVehicleInfo";
            this.gboVehicleInfo.Padding = new System.Windows.Forms.Padding(2);
            this.gboVehicleInfo.Size = new System.Drawing.Size(414, 383);
            this.gboVehicleInfo.TabIndex = 14;
            this.gboVehicleInfo.TabStop = false;
            this.gboVehicleInfo.Text = "Vehicle Information";
            // 
            // nudCurrentMileage
            // 
            this.nudCurrentMileage.Location = new System.Drawing.Point(237, 306);
            this.nudCurrentMileage.Margin = new System.Windows.Forms.Padding(2);
            this.nudCurrentMileage.Maximum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.nudCurrentMileage.Name = "nudCurrentMileage";
            this.nudCurrentMileage.Size = new System.Drawing.Size(159, 21);
            this.nudCurrentMileage.TabIndex = 30;
            this.nudCurrentMileage.ThousandsSeparator = true;
            // 
            // btnClose
            // 
            this.btnClose.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(66)))), ((int)(((byte)(66)))));
            this.btnClose.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnClose.FlatAppearance.BorderSize = 0;
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold);
            this.btnClose.ForeColor = System.Drawing.Color.White;
            this.btnClose.Location = new System.Drawing.Point(259, 343);
            this.btnClose.Margin = new System.Windows.Forms.Padding(2);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(105, 34);
            this.btnClose.TabIndex = 16;
            this.btnClose.Text = "✗ Close";
            this.btnClose.UseVisualStyleBackColor = false;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnVehicleDelete
            // 
            this.btnVehicleDelete.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(198)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.btnVehicleDelete.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnVehicleDelete.FlatAppearance.BorderSize = 0;
            this.btnVehicleDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnVehicleDelete.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold);
            this.btnVehicleDelete.ForeColor = System.Drawing.Color.White;
            this.btnVehicleDelete.Location = new System.Drawing.Point(148, 343);
            this.btnVehicleDelete.Name = "btnVehicleDelete";
            this.btnVehicleDelete.Size = new System.Drawing.Size(106, 34);
            this.btnVehicleDelete.TabIndex = 4;
            this.btnVehicleDelete.Text = "🗑 Delete";
            this.btnVehicleDelete.UseVisualStyleBackColor = false;
            this.btnVehicleDelete.Click += new System.EventHandler(this.btnVehicleDelete_Click);
            // 
            // lblCustomer
            // 
            this.lblCustomer.AutoSize = true;
            this.lblCustomer.BackColor = System.Drawing.Color.Transparent;
            this.lblCustomer.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Italic);
            this.lblCustomer.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(200)))), ((int)(((byte)(220)))));
            this.lblCustomer.Location = new System.Drawing.Point(31, 16);
            this.lblCustomer.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblCustomer.Name = "lblCustomer";
            this.lblCustomer.Size = new System.Drawing.Size(67, 15);
            this.lblCustomer.TabIndex = 22;
            this.lblCustomer.Text = "[Customer]";
            // 
            // lvVehicleList
            // 
            this.lvVehicleList.BackColor = System.Drawing.Color.White;
            this.lvVehicleList.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lvVehicleList.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.Year,
            this.Make,
            this.Model,
            this.VIN,
            this.Plate});
            this.lvVehicleList.Font = new System.Drawing.Font("Arial", 9F);
            this.lvVehicleList.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(43)))), ((int)(((byte)(74)))));
            this.lvVehicleList.FullRowSelect = true;
            this.lvVehicleList.GridLines = true;
            this.lvVehicleList.HideSelection = false;
            this.lvVehicleList.Location = new System.Drawing.Point(13, 33);
            this.lvVehicleList.Name = "lvVehicleList";
            this.lvVehicleList.Size = new System.Drawing.Size(389, 163);
            this.lvVehicleList.TabIndex = 2;
            this.lvVehicleList.UseCompatibleStateImageBehavior = false;
            this.lvVehicleList.SelectedIndexChanged += new System.EventHandler(this.lvVehicleList_SelectedIndexChanged);
            // 
            // Year
            // 
            this.Year.Text = "Year";
            this.Year.Width = 50;
            // 
            // Make
            // 
            this.Make.Text = "Make";
            this.Make.Width = 80;
            // 
            // Model
            // 
            this.Model.Text = "Model";
            this.Model.Width = 90;
            // 
            // VIN
            // 
            this.VIN.Text = "VIN";
            this.VIN.Width = 130;
            // 
            // Plate
            // 
            this.Plate.Text = "Plate";
            this.Plate.Width = 70;
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(125)))), ((int)(((byte)(50)))));
            this.btnSave.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSave.FlatAppearance.BorderSize = 0;
            this.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSave.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold);
            this.btnSave.ForeColor = System.Drawing.Color.White;
            this.btnSave.Location = new System.Drawing.Point(30, 343);
            this.btnSave.Margin = new System.Windows.Forms.Padding(2);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(113, 34);
            this.btnSave.TabIndex = 15;
            this.btnSave.Text = "✓ Save";
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // lblStatus
            // 
            this.lblStatus.AutoSize = true;
            this.lblStatus.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Italic);
            this.lblStatus.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))));
            this.lblStatus.Location = new System.Drawing.Point(208, 16);
            this.lblStatus.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(67, 14);
            this.lblStatus.TabIndex = 29;
            this.lblStatus.Text = "[ API Status]";
            // 
            // btnVINLookup
            // 
            this.btnVINLookup.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(118)))), ((int)(((byte)(210)))));
            this.btnVINLookup.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnVINLookup.FlatAppearance.BorderSize = 0;
            this.btnVINLookup.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnVINLookup.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold);
            this.btnVINLookup.ForeColor = System.Drawing.Color.White;
            this.btnVINLookup.Location = new System.Drawing.Point(286, 219);
            this.btnVINLookup.Margin = new System.Windows.Forms.Padding(2);
            this.btnVINLookup.Name = "btnVINLookup";
            this.btnVINLookup.Size = new System.Drawing.Size(110, 22);
            this.btnVINLookup.TabIndex = 28;
            this.btnVINLookup.Text = "🔍 Lookup VIN";
            this.btnVINLookup.UseVisualStyleBackColor = false;
            this.btnVINLookup.Click += new System.EventHandler(this.btnVINLookup_Click);
            // 
            // lblCurrentMileage
            // 
            this.lblCurrentMileage.AutoSize = true;
            this.lblCurrentMileage.Font = new System.Drawing.Font("Arial", 9F);
            this.lblCurrentMileage.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(43)))), ((int)(((byte)(74)))));
            this.lblCurrentMileage.Location = new System.Drawing.Point(234, 289);
            this.lblCurrentMileage.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblCurrentMileage.Name = "lblCurrentMileage";
            this.lblCurrentMileage.Size = new System.Drawing.Size(97, 15);
            this.lblCurrentMileage.TabIndex = 27;
            this.lblCurrentMileage.Text = "Current Mileage:";
            // 
            // lblLicensePlate
            // 
            this.lblLicensePlate.AutoSize = true;
            this.lblLicensePlate.Font = new System.Drawing.Font("Arial", 9F);
            this.lblLicensePlate.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(43)))), ((int)(((byte)(74)))));
            this.lblLicensePlate.Location = new System.Drawing.Point(12, 289);
            this.lblLicensePlate.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblLicensePlate.Name = "lblLicensePlate";
            this.lblLicensePlate.Size = new System.Drawing.Size(85, 15);
            this.lblLicensePlate.TabIndex = 26;
            this.lblLicensePlate.Text = "License Plate:";
            // 
            // lblYear
            // 
            this.lblYear.AutoSize = true;
            this.lblYear.Font = new System.Drawing.Font("Arial", 9F);
            this.lblYear.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(43)))), ((int)(((byte)(74)))));
            this.lblYear.Location = new System.Drawing.Point(256, 244);
            this.lblYear.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblYear.Name = "lblYear";
            this.lblYear.Size = new System.Drawing.Size(34, 15);
            this.lblYear.TabIndex = 24;
            this.lblYear.Text = "Year:";
            // 
            // lblModel
            // 
            this.lblModel.AutoSize = true;
            this.lblModel.Font = new System.Drawing.Font("Arial", 9F);
            this.lblModel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(43)))), ((int)(((byte)(74)))));
            this.lblModel.Location = new System.Drawing.Point(132, 244);
            this.lblModel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblModel.Name = "lblModel";
            this.lblModel.Size = new System.Drawing.Size(43, 15);
            this.lblModel.TabIndex = 23;
            this.lblModel.Text = "Model:";
            // 
            // lblMake
            // 
            this.lblMake.AutoSize = true;
            this.lblMake.Font = new System.Drawing.Font("Arial", 9F);
            this.lblMake.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(43)))), ((int)(((byte)(74)))));
            this.lblMake.Location = new System.Drawing.Point(10, 244);
            this.lblMake.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblMake.Name = "lblMake";
            this.lblMake.Size = new System.Drawing.Size(39, 15);
            this.lblMake.TabIndex = 22;
            this.lblMake.Text = "Make:";
            // 
            // lblVIN
            // 
            this.lblVIN.AutoSize = true;
            this.lblVIN.Font = new System.Drawing.Font("Arial", 9F);
            this.lblVIN.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(43)))), ((int)(((byte)(74)))));
            this.lblVIN.Location = new System.Drawing.Point(10, 203);
            this.lblVIN.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblVIN.Name = "lblVIN";
            this.lblVIN.Size = new System.Drawing.Size(29, 15);
            this.lblVIN.TabIndex = 21;
            this.lblVIN.Text = "VIN:";
            // 
            // txtLicensePlate
            // 
            this.txtLicensePlate.BackColor = System.Drawing.Color.White;
            this.txtLicensePlate.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtLicensePlate.Font = new System.Drawing.Font("Arial", 9F);
            this.txtLicensePlate.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(43)))), ((int)(((byte)(74)))));
            this.txtLicensePlate.Location = new System.Drawing.Point(15, 306);
            this.txtLicensePlate.Margin = new System.Windows.Forms.Padding(2);
            this.txtLicensePlate.Name = "txtLicensePlate";
            this.txtLicensePlate.Size = new System.Drawing.Size(218, 21);
            this.txtLicensePlate.TabIndex = 19;
            // 
            // txtYear
            // 
            this.txtYear.BackColor = System.Drawing.Color.White;
            this.txtYear.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtYear.Font = new System.Drawing.Font("Arial", 9F);
            this.txtYear.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(43)))), ((int)(((byte)(74)))));
            this.txtYear.Location = new System.Drawing.Point(259, 261);
            this.txtYear.Margin = new System.Windows.Forms.Padding(2);
            this.txtYear.Name = "txtYear";
            this.txtYear.ReadOnly = true;
            this.txtYear.Size = new System.Drawing.Size(137, 21);
            this.txtYear.TabIndex = 17;
            // 
            // txtModel
            // 
            this.txtModel.BackColor = System.Drawing.Color.White;
            this.txtModel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtModel.Font = new System.Drawing.Font("Arial", 9F);
            this.txtModel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(43)))), ((int)(((byte)(74)))));
            this.txtModel.Location = new System.Drawing.Point(130, 261);
            this.txtModel.Margin = new System.Windows.Forms.Padding(2);
            this.txtModel.Name = "txtModel";
            this.txtModel.ReadOnly = true;
            this.txtModel.Size = new System.Drawing.Size(127, 21);
            this.txtModel.TabIndex = 16;
            // 
            // txtMake
            // 
            this.txtMake.BackColor = System.Drawing.Color.White;
            this.txtMake.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtMake.Font = new System.Drawing.Font("Arial", 9F);
            this.txtMake.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(43)))), ((int)(((byte)(74)))));
            this.txtMake.Location = new System.Drawing.Point(13, 261);
            this.txtMake.Margin = new System.Windows.Forms.Padding(2);
            this.txtMake.Name = "txtMake";
            this.txtMake.ReadOnly = true;
            this.txtMake.Size = new System.Drawing.Size(113, 21);
            this.txtMake.TabIndex = 15;
            // 
            // txtVIN
            // 
            this.txtVIN.BackColor = System.Drawing.Color.White;
            this.txtVIN.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtVIN.Font = new System.Drawing.Font("Arial", 9F);
            this.txtVIN.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(43)))), ((int)(((byte)(74)))));
            this.txtVIN.Location = new System.Drawing.Point(13, 220);
            this.txtVIN.Margin = new System.Windows.Forms.Padding(2);
            this.txtVIN.Name = "txtVIN";
            this.txtVIN.Size = new System.Drawing.Size(262, 21);
            this.txtVIN.TabIndex = 14;
            // 
            // pnlHeader
            // 
            this.pnlHeader.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(43)))), ((int)(((byte)(74)))));
            this.pnlHeader.Controls.Add(this.lblSubtitle);
            this.pnlHeader.Controls.Add(this.lblTitle);
            this.pnlHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlHeader.Location = new System.Drawing.Point(0, 0);
            this.pnlHeader.Name = "pnlHeader";
            this.pnlHeader.Size = new System.Drawing.Size(435, 60);
            this.pnlHeader.TabIndex = 20;
            // 
            // lblSubtitle
            // 
            this.lblSubtitle.AutoSize = true;
            this.lblSubtitle.Font = new System.Drawing.Font("Arial", 8F);
            this.lblSubtitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(200)))), ((int)(((byte)(220)))));
            this.lblSubtitle.Location = new System.Drawing.Point(18, 38);
            this.lblSubtitle.Name = "lblSubtitle";
            this.lblSubtitle.Size = new System.Drawing.Size(146, 14);
            this.lblSubtitle.TabIndex = 0;
            this.lblSubtitle.Text = "Add, edit and delete vehicles";
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Arial", 14F, System.Drawing.FontStyle.Bold);
            this.lblTitle.ForeColor = System.Drawing.Color.White;
            this.lblTitle.Location = new System.Drawing.Point(12, 9);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(229, 22);
            this.lblTitle.TabIndex = 1;
            this.lblTitle.Text = "🚗 Vehicle Management";
            // 
            // frmVehicle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(435, 459);
            this.Controls.Add(this.pnlHeader);
            this.Controls.Add(this.gboVehicleInfo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "frmVehicle";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Vehicle Form";
            this.gboVehicleInfo.ResumeLayout(false);
            this.gboVehicleInfo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudCurrentMileage)).EndInit();
            this.pnlHeader.ResumeLayout(false);
            this.pnlHeader.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gboVehicleInfo;
        private System.Windows.Forms.Button btnVINLookup;
        private System.Windows.Forms.Label lblCurrentMileage;
        private System.Windows.Forms.Label lblLicensePlate;
        private System.Windows.Forms.Label lblYear;
        private System.Windows.Forms.Label lblModel;
        private System.Windows.Forms.Label lblMake;
        private System.Windows.Forms.Label lblVIN;
        private System.Windows.Forms.TextBox txtLicensePlate;
        private System.Windows.Forms.TextBox txtYear;
        private System.Windows.Forms.TextBox txtModel;
        private System.Windows.Forms.TextBox txtMake;
        private System.Windows.Forms.TextBox txtVIN;
        private System.Windows.Forms.Label lblStatus;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Label lblCustomer;
        private System.Windows.Forms.NumericUpDown nudCurrentMileage;
        private System.Windows.Forms.Button btnVehicleDelete;
        private System.Windows.Forms.ListView lvVehicleList;
        private System.Windows.Forms.Panel pnlHeader;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblSubtitle;
        private System.Windows.Forms.ColumnHeader Year;
        private System.Windows.Forms.ColumnHeader Make;
        private System.Windows.Forms.ColumnHeader Model;
        private System.Windows.Forms.ColumnHeader VIN;
        private System.Windows.Forms.ColumnHeader Plate;
    }
}