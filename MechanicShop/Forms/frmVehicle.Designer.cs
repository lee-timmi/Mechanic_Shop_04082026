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
            this.lblCustomer = new System.Windows.Forms.Label();
            this.lblStatus = new System.Windows.Forms.Label();
            this.btnVINLookup = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.lblYear = new System.Windows.Forms.Label();
            this.lblModel = new System.Windows.Forms.Label();
            this.lblMake = new System.Windows.Forms.Label();
            this.lblVIN = new System.Windows.Forms.Label();
            this.txtLicensePlate = new System.Windows.Forms.TextBox();
            this.txtColor = new System.Windows.Forms.TextBox();
            this.txtYear = new System.Windows.Forms.TextBox();
            this.txtModel = new System.Windows.Forms.TextBox();
            this.txtMake = new System.Windows.Forms.TextBox();
            this.txtVIN = new System.Windows.Forms.TextBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.nudCurrentMileage = new System.Windows.Forms.NumericUpDown();
            this.gboVehicleInfo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudCurrentMileage)).BeginInit();
            this.SuspendLayout();
            // 
            // gboVehicleInfo
            // 
            this.gboVehicleInfo.Controls.Add(this.nudCurrentMileage);
            this.gboVehicleInfo.Controls.Add(this.lblCustomer);
            this.gboVehicleInfo.Controls.Add(this.lblStatus);
            this.gboVehicleInfo.Controls.Add(this.btnVINLookup);
            this.gboVehicleInfo.Controls.Add(this.label7);
            this.gboVehicleInfo.Controls.Add(this.label6);
            this.gboVehicleInfo.Controls.Add(this.label5);
            this.gboVehicleInfo.Controls.Add(this.lblYear);
            this.gboVehicleInfo.Controls.Add(this.lblModel);
            this.gboVehicleInfo.Controls.Add(this.lblMake);
            this.gboVehicleInfo.Controls.Add(this.lblVIN);
            this.gboVehicleInfo.Controls.Add(this.txtLicensePlate);
            this.gboVehicleInfo.Controls.Add(this.txtColor);
            this.gboVehicleInfo.Controls.Add(this.txtYear);
            this.gboVehicleInfo.Controls.Add(this.txtModel);
            this.gboVehicleInfo.Controls.Add(this.txtMake);
            this.gboVehicleInfo.Controls.Add(this.txtVIN);
            this.gboVehicleInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gboVehicleInfo.Location = new System.Drawing.Point(12, 12);
            this.gboVehicleInfo.Name = "gboVehicleInfo";
            this.gboVehicleInfo.Size = new System.Drawing.Size(670, 515);
            this.gboVehicleInfo.TabIndex = 14;
            this.gboVehicleInfo.TabStop = false;
            this.gboVehicleInfo.Text = "Vehicle Information";
            // 
            // lblCustomer
            // 
            this.lblCustomer.AutoSize = true;
            this.lblCustomer.Location = new System.Drawing.Point(289, 91);
            this.lblCustomer.Name = "lblCustomer";
            this.lblCustomer.Size = new System.Drawing.Size(109, 25);
            this.lblCustomer.TabIndex = 22;
            this.lblCustomer.Text = "[Customer]";
            // 
            // lblStatus
            // 
            this.lblStatus.AutoSize = true;
            this.lblStatus.Location = new System.Drawing.Point(310, 469);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(122, 25);
            this.lblStatus.TabIndex = 29;
            this.lblStatus.Text = "[ API Status]";
            // 
            // btnVINLookup
            // 
            this.btnVINLookup.Location = new System.Drawing.Point(501, 40);
            this.btnVINLookup.Name = "btnVINLookup";
            this.btnVINLookup.Size = new System.Drawing.Size(147, 34);
            this.btnVINLookup.TabIndex = 28;
            this.btnVINLookup.Text = "Lookup VIN";
            this.btnVINLookup.UseVisualStyleBackColor = true;
            this.btnVINLookup.Click += new System.EventHandler(this.btnVINLookup_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(14, 417);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(157, 25);
            this.label7.TabIndex = 27;
            this.label7.Text = "Current Mileage:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(32, 358);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(135, 25);
            this.label6.TabIndex = 26;
            this.label6.Text = "License Plate:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(88, 302);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(65, 25);
            this.label5.TabIndex = 25;
            this.label5.Text = "Color:";
            // 
            // lblYear
            // 
            this.lblYear.AutoSize = true;
            this.lblYear.Location = new System.Drawing.Point(88, 249);
            this.lblYear.Name = "lblYear";
            this.lblYear.Size = new System.Drawing.Size(59, 25);
            this.lblYear.TabIndex = 24;
            this.lblYear.Text = "Year:";
            // 
            // lblModel
            // 
            this.lblModel.AutoSize = true;
            this.lblModel.Location = new System.Drawing.Point(80, 195);
            this.lblModel.Name = "lblModel";
            this.lblModel.Size = new System.Drawing.Size(72, 25);
            this.lblModel.TabIndex = 23;
            this.lblModel.Text = "Model:";
            // 
            // lblMake
            // 
            this.lblMake.AutoSize = true;
            this.lblMake.Location = new System.Drawing.Point(84, 135);
            this.lblMake.Name = "lblMake";
            this.lblMake.Size = new System.Drawing.Size(67, 25);
            this.lblMake.TabIndex = 22;
            this.lblMake.Text = "Make:";
            // 
            // lblVIN
            // 
            this.lblVIN.AutoSize = true;
            this.lblVIN.Location = new System.Drawing.Point(80, 45);
            this.lblVIN.Name = "lblVIN";
            this.lblVIN.Size = new System.Drawing.Size(51, 25);
            this.lblVIN.TabIndex = 21;
            this.lblVIN.Text = "VIN:";
            // 
            // txtLicensePlate
            // 
            this.txtLicensePlate.Location = new System.Drawing.Point(177, 352);
            this.txtLicensePlate.Name = "txtLicensePlate";
            this.txtLicensePlate.Size = new System.Drawing.Size(318, 30);
            this.txtLicensePlate.TabIndex = 19;
            // 
            // txtColor
            // 
            this.txtColor.Location = new System.Drawing.Point(177, 297);
            this.txtColor.Name = "txtColor";
            this.txtColor.Size = new System.Drawing.Size(318, 30);
            this.txtColor.TabIndex = 18;
            // 
            // txtYear
            // 
            this.txtYear.Location = new System.Drawing.Point(177, 243);
            this.txtYear.Name = "txtYear";
            this.txtYear.ReadOnly = true;
            this.txtYear.Size = new System.Drawing.Size(318, 30);
            this.txtYear.TabIndex = 17;
            // 
            // txtModel
            // 
            this.txtModel.Location = new System.Drawing.Point(177, 188);
            this.txtModel.Name = "txtModel";
            this.txtModel.ReadOnly = true;
            this.txtModel.Size = new System.Drawing.Size(318, 30);
            this.txtModel.TabIndex = 16;
            // 
            // txtMake
            // 
            this.txtMake.Location = new System.Drawing.Point(180, 134);
            this.txtMake.Name = "txtMake";
            this.txtMake.ReadOnly = true;
            this.txtMake.Size = new System.Drawing.Size(318, 30);
            this.txtMake.TabIndex = 15;
            // 
            // txtVIN
            // 
            this.txtVIN.Location = new System.Drawing.Point(177, 40);
            this.txtVIN.Name = "txtVIN";
            this.txtVIN.Size = new System.Drawing.Size(318, 30);
            this.txtVIN.TabIndex = 14;
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(192, 533);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(130, 52);
            this.btnSave.TabIndex = 15;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(368, 533);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(130, 52);
            this.btnCancel.TabIndex = 16;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // nudCurrentMileage
            // 
            this.nudCurrentMileage.Location = new System.Drawing.Point(180, 415);
            this.nudCurrentMileage.Maximum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.nudCurrentMileage.Name = "nudCurrentMileage";
            this.nudCurrentMileage.Size = new System.Drawing.Size(315, 30);
            this.nudCurrentMileage.TabIndex = 30;
            this.nudCurrentMileage.ThousandsSeparator = true;
            // 
            // frmVehicle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(706, 603);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.gboVehicleInfo);
            this.Name = "frmVehicle";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Vehicle Form";
            this.gboVehicleInfo.ResumeLayout(false);
            this.gboVehicleInfo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudCurrentMileage)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gboVehicleInfo;
        private System.Windows.Forms.Button btnVINLookup;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lblYear;
        private System.Windows.Forms.Label lblModel;
        private System.Windows.Forms.Label lblMake;
        private System.Windows.Forms.Label lblVIN;
        private System.Windows.Forms.TextBox txtLicensePlate;
        private System.Windows.Forms.TextBox txtColor;
        private System.Windows.Forms.TextBox txtYear;
        private System.Windows.Forms.TextBox txtModel;
        private System.Windows.Forms.TextBox txtMake;
        private System.Windows.Forms.TextBox txtVIN;
        private System.Windows.Forms.Label lblStatus;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Label lblCustomer;
        private System.Windows.Forms.NumericUpDown nudCurrentMileage;
    }
}