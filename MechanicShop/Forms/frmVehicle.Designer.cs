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
            this.lblStatus = new System.Windows.Forms.Label();
            this.btnVINLookup = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.lblYear = new System.Windows.Forms.Label();
            this.lblModel = new System.Windows.Forms.Label();
            this.lblMake = new System.Windows.Forms.Label();
            this.lblVIN = new System.Windows.Forms.Label();
            this.txtCurrentMileage = new System.Windows.Forms.TextBox();
            this.txtLicensePlate = new System.Windows.Forms.TextBox();
            this.txtColor = new System.Windows.Forms.TextBox();
            this.txtYear = new System.Windows.Forms.TextBox();
            this.txtModel = new System.Windows.Forms.TextBox();
            this.txtMake = new System.Windows.Forms.TextBox();
            this.txtVIN = new System.Windows.Forms.TextBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.gboVehicleInfo.SuspendLayout();
            this.SuspendLayout();
            // 
            // gboVehicleInfo
            // 
            this.gboVehicleInfo.Controls.Add(this.lblStatus);
            this.gboVehicleInfo.Controls.Add(this.btnVINLookup);
            this.gboVehicleInfo.Controls.Add(this.label7);
            this.gboVehicleInfo.Controls.Add(this.label6);
            this.gboVehicleInfo.Controls.Add(this.label5);
            this.gboVehicleInfo.Controls.Add(this.lblYear);
            this.gboVehicleInfo.Controls.Add(this.lblModel);
            this.gboVehicleInfo.Controls.Add(this.lblMake);
            this.gboVehicleInfo.Controls.Add(this.lblVIN);
            this.gboVehicleInfo.Controls.Add(this.txtCurrentMileage);
            this.gboVehicleInfo.Controls.Add(this.txtLicensePlate);
            this.gboVehicleInfo.Controls.Add(this.txtColor);
            this.gboVehicleInfo.Controls.Add(this.txtYear);
            this.gboVehicleInfo.Controls.Add(this.txtModel);
            this.gboVehicleInfo.Controls.Add(this.txtMake);
            this.gboVehicleInfo.Controls.Add(this.txtVIN);
            this.gboVehicleInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gboVehicleInfo.Location = new System.Drawing.Point(8, 8);
            this.gboVehicleInfo.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.gboVehicleInfo.Name = "gboVehicleInfo";
            this.gboVehicleInfo.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.gboVehicleInfo.Size = new System.Drawing.Size(447, 335);
            this.gboVehicleInfo.TabIndex = 14;
            this.gboVehicleInfo.TabStop = false;
            this.gboVehicleInfo.Text = "Vehicle Information";
            // 
            // lblStatus
            // 
            this.lblStatus.AutoSize = true;
            this.lblStatus.Location = new System.Drawing.Point(207, 305);
            this.lblStatus.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(85, 17);
            this.lblStatus.TabIndex = 29;
            this.lblStatus.Text = "[ API Status]";
            // 
            // btnVINLookup
            // 
            this.btnVINLookup.Location = new System.Drawing.Point(334, 26);
            this.btnVINLookup.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnVINLookup.Name = "btnVINLookup";
            this.btnVINLookup.Size = new System.Drawing.Size(98, 22);
            this.btnVINLookup.TabIndex = 28;
            this.btnVINLookup.Text = "Lookup VIN";
            this.btnVINLookup.UseVisualStyleBackColor = true;
            this.btnVINLookup.Click += new System.EventHandler(this.btnVINLookup_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(9, 271);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(112, 17);
            this.label7.TabIndex = 27;
            this.label7.Text = "Current Mileage:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(21, 233);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(97, 17);
            this.label6.TabIndex = 26;
            this.label6.Text = "License Plate:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(59, 196);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(45, 17);
            this.label5.TabIndex = 25;
            this.label5.Text = "Color:";
            // 
            // lblYear
            // 
            this.lblYear.AutoSize = true;
            this.lblYear.Location = new System.Drawing.Point(59, 162);
            this.lblYear.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblYear.Name = "lblYear";
            this.lblYear.Size = new System.Drawing.Size(42, 17);
            this.lblYear.TabIndex = 24;
            this.lblYear.Text = "Year:";
            // 
            // lblModel
            // 
            this.lblModel.AutoSize = true;
            this.lblModel.Location = new System.Drawing.Point(53, 127);
            this.lblModel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblModel.Name = "lblModel";
            this.lblModel.Size = new System.Drawing.Size(50, 17);
            this.lblModel.TabIndex = 23;
            this.lblModel.Text = "Model:";
            // 
            // lblMake
            // 
            this.lblMake.AutoSize = true;
            this.lblMake.Location = new System.Drawing.Point(56, 88);
            this.lblMake.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblMake.Name = "lblMake";
            this.lblMake.Size = new System.Drawing.Size(46, 17);
            this.lblMake.TabIndex = 22;
            this.lblMake.Text = "Make:";
            // 
            // lblVIN
            // 
            this.lblVIN.AutoSize = true;
            this.lblVIN.Location = new System.Drawing.Point(53, 29);
            this.lblVIN.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblVIN.Name = "lblVIN";
            this.lblVIN.Size = new System.Drawing.Size(34, 17);
            this.lblVIN.TabIndex = 21;
            this.lblVIN.Text = "VIN:";
            // 
            // txtCurrentMileage
            // 
            this.txtCurrentMileage.Location = new System.Drawing.Point(118, 268);
            this.txtCurrentMileage.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtCurrentMileage.Name = "txtCurrentMileage";
            this.txtCurrentMileage.Size = new System.Drawing.Size(213, 23);
            this.txtCurrentMileage.TabIndex = 20;
            // 
            // txtLicensePlate
            // 
            this.txtLicensePlate.Location = new System.Drawing.Point(118, 229);
            this.txtLicensePlate.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtLicensePlate.Name = "txtLicensePlate";
            this.txtLicensePlate.Size = new System.Drawing.Size(213, 23);
            this.txtLicensePlate.TabIndex = 19;
            // 
            // txtColor
            // 
            this.txtColor.Location = new System.Drawing.Point(118, 193);
            this.txtColor.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtColor.Name = "txtColor";
            this.txtColor.Size = new System.Drawing.Size(213, 23);
            this.txtColor.TabIndex = 18;
            // 
            // txtYear
            // 
            this.txtYear.Location = new System.Drawing.Point(118, 158);
            this.txtYear.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtYear.Name = "txtYear";
            this.txtYear.ReadOnly = true;
            this.txtYear.Size = new System.Drawing.Size(213, 23);
            this.txtYear.TabIndex = 17;
            // 
            // txtModel
            // 
            this.txtModel.Location = new System.Drawing.Point(118, 122);
            this.txtModel.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtModel.Name = "txtModel";
            this.txtModel.ReadOnly = true;
            this.txtModel.Size = new System.Drawing.Size(213, 23);
            this.txtModel.TabIndex = 16;
            // 
            // txtMake
            // 
            this.txtMake.Location = new System.Drawing.Point(120, 87);
            this.txtMake.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtMake.Name = "txtMake";
            this.txtMake.ReadOnly = true;
            this.txtMake.Size = new System.Drawing.Size(213, 23);
            this.txtMake.TabIndex = 15;
            // 
            // txtVIN
            // 
            this.txtVIN.Location = new System.Drawing.Point(118, 26);
            this.txtVIN.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtVIN.Name = "txtVIN";
            this.txtVIN.Size = new System.Drawing.Size(213, 23);
            this.txtVIN.TabIndex = 14;
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(113, 367);
            this.btnSave.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(87, 34);
            this.btnSave.TabIndex = 15;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(231, 367);
            this.btnCancel.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(87, 34);
            this.btnCancel.TabIndex = 16;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // frmVehicle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(471, 420);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.gboVehicleInfo);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "frmVehicle";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Vehicle Form";
            this.gboVehicleInfo.ResumeLayout(false);
            this.gboVehicleInfo.PerformLayout();
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
        private System.Windows.Forms.TextBox txtCurrentMileage;
        private System.Windows.Forms.TextBox txtLicensePlate;
        private System.Windows.Forms.TextBox txtColor;
        private System.Windows.Forms.TextBox txtYear;
        private System.Windows.Forms.TextBox txtModel;
        private System.Windows.Forms.TextBox txtMake;
        private System.Windows.Forms.TextBox txtVIN;
        private System.Windows.Forms.Label lblStatus;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnCancel;
    }
}