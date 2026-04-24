namespace MechanicShop.Forms
{
    partial class frmRepairOrder
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
            this.gboLabor = new System.Windows.Forms.GroupBox();
            this.flpLabor = new System.Windows.Forms.FlowLayoutPanel();
            this.btnDiagnostic = new System.Windows.Forms.Button();
            this.btnTireRotation = new System.Windows.Forms.Button();
            this.btnBrakePad = new System.Windows.Forms.Button();
            this.btnOilChange = new System.Windows.Forms.Button();
            this.btnAddLabor = new System.Windows.Forms.Button();
            this.gboOrderInformation = new System.Windows.Forms.GroupBox();
            this.nudMileage = new System.Windows.Forms.NumericUpDown();
            this.dtpDate = new System.Windows.Forms.DateTimePicker();
            this.lblDate = new System.Windows.Forms.Label();
            this.txtOrderNum = new System.Windows.Forms.TextBox();
            this.lblOrderNum = new System.Windows.Forms.Label();
            this.lblStatus = new System.Windows.Forms.Label();
            this.lblMileage = new System.Windows.Forms.Label();
            this.lblVehicle = new System.Windows.Forms.Label();
            this.lblCustomer = new System.Windows.Forms.Label();
            this.cboStatus = new System.Windows.Forms.ComboBox();
            this.cboVehicle = new System.Windows.Forms.ComboBox();
            this.cboCustomer = new System.Windows.Forms.ComboBox();
            this.gboParts = new System.Windows.Forms.GroupBox();
            this.flpParts = new System.Windows.Forms.FlowLayoutPanel();
            this.btnOilFilter = new System.Windows.Forms.Button();
            this.btnAirFilter = new System.Windows.Forms.Button();
            this.btnAddParts = new System.Windows.Forms.Button();
            this.gboCostInformation = new System.Windows.Forms.GroupBox();
            this.txtFeedback = new System.Windows.Forms.TextBox();
            this.txtGrandTotal = new System.Windows.Forms.TextBox();
            this.btnClose = new System.Windows.Forms.Button();
            this.txtPartsTotal = new System.Windows.Forms.TextBox();
            this.btnCloseOrder = new System.Windows.Forms.Button();
            this.txtLaborTotal = new System.Windows.Forms.TextBox();
            this.btnSubmitOrder = new System.Windows.Forms.Button();
            this.lblFeedback = new System.Windows.Forms.Label();
            this.lblGrandTotal = new System.Windows.Forms.Label();
            this.lblPartsTotal = new System.Windows.Forms.Label();
            this.lblLaborTotal = new System.Windows.Forms.Label();
            this.pnlHeader = new System.Windows.Forms.Panel();
            this.lblSubtitle = new System.Windows.Forms.Label();
            this.lblTitle = new System.Windows.Forms.Label();
            this.gboLabor.SuspendLayout();
            this.gboOrderInformation.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudMileage)).BeginInit();
            this.gboParts.SuspendLayout();
            this.gboCostInformation.SuspendLayout();
            this.pnlHeader.SuspendLayout();
            this.SuspendLayout();
            // 
            // gboLabor
            // 
            this.gboLabor.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(246)))), ((int)(((byte)(248)))));
            this.gboLabor.Controls.Add(this.flpLabor);
            this.gboLabor.Controls.Add(this.btnDiagnostic);
            this.gboLabor.Controls.Add(this.btnTireRotation);
            this.gboLabor.Controls.Add(this.btnBrakePad);
            this.gboLabor.Controls.Add(this.btnOilChange);
            this.gboLabor.Controls.Add(this.btnAddLabor);
            this.gboLabor.Font = new System.Drawing.Font("Arial", 9F);
            this.gboLabor.Location = new System.Drawing.Point(12, 212);
            this.gboLabor.Margin = new System.Windows.Forms.Padding(2);
            this.gboLabor.Name = "gboLabor";
            this.gboLabor.Padding = new System.Windows.Forms.Padding(2);
            this.gboLabor.Size = new System.Drawing.Size(553, 273);
            this.gboLabor.TabIndex = 4;
            this.gboLabor.TabStop = false;
            this.gboLabor.Text = "👷‍♂️ Labor Item";
            // 
            // flpLabor
            // 
            this.flpLabor.AutoScroll = true;
            this.flpLabor.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.flpLabor.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flpLabor.Location = new System.Drawing.Point(13, 57);
            this.flpLabor.Margin = new System.Windows.Forms.Padding(2);
            this.flpLabor.Name = "flpLabor";
            this.flpLabor.Size = new System.Drawing.Size(528, 201);
            this.flpLabor.TabIndex = 11;
            this.flpLabor.WrapContents = false;
            // 
            // btnDiagnostic
            // 
            this.btnDiagnostic.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(119)))), ((int)(((byte)(34)))));
            this.btnDiagnostic.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDiagnostic.FlatAppearance.BorderSize = 0;
            this.btnDiagnostic.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDiagnostic.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold);
            this.btnDiagnostic.ForeColor = System.Drawing.Color.White;
            this.btnDiagnostic.Location = new System.Drawing.Point(347, 20);
            this.btnDiagnostic.Margin = new System.Windows.Forms.Padding(2);
            this.btnDiagnostic.Name = "btnDiagnostic";
            this.btnDiagnostic.Size = new System.Drawing.Size(104, 33);
            this.btnDiagnostic.TabIndex = 14;
            this.btnDiagnostic.Text = "🔍 Diagnostics";
            this.btnDiagnostic.UseVisualStyleBackColor = true;
            this.btnDiagnostic.Click += new System.EventHandler(this.btnDiagnostic_Click);
            // 
            // btnTireRotation
            // 
            this.btnTireRotation.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(119)))), ((int)(((byte)(34)))));
            this.btnTireRotation.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnTireRotation.FlatAppearance.BorderSize = 0;
            this.btnTireRotation.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTireRotation.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold);
            this.btnTireRotation.ForeColor = System.Drawing.Color.White;
            this.btnTireRotation.Location = new System.Drawing.Point(235, 20);
            this.btnTireRotation.Margin = new System.Windows.Forms.Padding(2);
            this.btnTireRotation.Name = "btnTireRotation";
            this.btnTireRotation.Size = new System.Drawing.Size(108, 33);
            this.btnTireRotation.TabIndex = 13;
            this.btnTireRotation.Text = "✇ Tire Rotation";
            this.btnTireRotation.UseVisualStyleBackColor = true;
            this.btnTireRotation.Click += new System.EventHandler(this.btnTireRotation_Click);
            // 
            // btnBrakePad
            // 
            this.btnBrakePad.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(119)))), ((int)(((byte)(34)))));
            this.btnBrakePad.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnBrakePad.FlatAppearance.BorderSize = 0;
            this.btnBrakePad.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBrakePad.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold);
            this.btnBrakePad.ForeColor = System.Drawing.Color.White;
            this.btnBrakePad.Location = new System.Drawing.Point(131, 20);
            this.btnBrakePad.Margin = new System.Windows.Forms.Padding(2);
            this.btnBrakePad.Name = "btnBrakePad";
            this.btnBrakePad.Size = new System.Drawing.Size(100, 33);
            this.btnBrakePad.TabIndex = 12;
            this.btnBrakePad.Text = "🛑 Brake Pads";
            this.btnBrakePad.UseVisualStyleBackColor = true;
            this.btnBrakePad.Click += new System.EventHandler(this.btnBrakePad_Click);
            // 
            // btnOilChange
            // 
            this.btnOilChange.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(119)))), ((int)(((byte)(34)))));
            this.btnOilChange.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnOilChange.FlatAppearance.BorderSize = 0;
            this.btnOilChange.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnOilChange.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold);
            this.btnOilChange.ForeColor = System.Drawing.Color.White;
            this.btnOilChange.Location = new System.Drawing.Point(11, 20);
            this.btnOilChange.Margin = new System.Windows.Forms.Padding(2);
            this.btnOilChange.Name = "btnOilChange";
            this.btnOilChange.Size = new System.Drawing.Size(116, 33);
            this.btnOilChange.TabIndex = 11;
            this.btnOilChange.Text = "🔧 Oil Change";
            this.btnOilChange.UseVisualStyleBackColor = true;
            this.btnOilChange.Click += new System.EventHandler(this.btnOilChange_Click);
            // 
            // btnAddLabor
            // 
            this.btnAddLabor.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(66)))), ((int)(((byte)(66)))));
            this.btnAddLabor.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAddLabor.FlatAppearance.BorderSize = 0;
            this.btnAddLabor.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddLabor.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold);
            this.btnAddLabor.ForeColor = System.Drawing.Color.White;
            this.btnAddLabor.Location = new System.Drawing.Point(455, 20);
            this.btnAddLabor.Margin = new System.Windows.Forms.Padding(2);
            this.btnAddLabor.Name = "btnAddLabor";
            this.btnAddLabor.Size = new System.Drawing.Size(86, 33);
            this.btnAddLabor.TabIndex = 6;
            this.btnAddLabor.Text = "Add Labor";
            this.btnAddLabor.UseVisualStyleBackColor = true;
            this.btnAddLabor.Click += new System.EventHandler(this.btnAddLabor_Click);
            // 
            // gboOrderInformation
            // 
            this.gboOrderInformation.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(246)))), ((int)(((byte)(248)))));
            this.gboOrderInformation.Controls.Add(this.nudMileage);
            this.gboOrderInformation.Controls.Add(this.dtpDate);
            this.gboOrderInformation.Controls.Add(this.lblDate);
            this.gboOrderInformation.Controls.Add(this.txtOrderNum);
            this.gboOrderInformation.Controls.Add(this.lblOrderNum);
            this.gboOrderInformation.Controls.Add(this.lblStatus);
            this.gboOrderInformation.Controls.Add(this.lblMileage);
            this.gboOrderInformation.Controls.Add(this.lblVehicle);
            this.gboOrderInformation.Controls.Add(this.lblCustomer);
            this.gboOrderInformation.Controls.Add(this.cboStatus);
            this.gboOrderInformation.Controls.Add(this.cboVehicle);
            this.gboOrderInformation.Controls.Add(this.cboCustomer);
            this.gboOrderInformation.Font = new System.Drawing.Font("Arial", 9F);
            this.gboOrderInformation.Location = new System.Drawing.Point(12, 70);
            this.gboOrderInformation.Margin = new System.Windows.Forms.Padding(2);
            this.gboOrderInformation.Name = "gboOrderInformation";
            this.gboOrderInformation.Padding = new System.Windows.Forms.Padding(2);
            this.gboOrderInformation.Size = new System.Drawing.Size(553, 138);
            this.gboOrderInformation.TabIndex = 5;
            this.gboOrderInformation.TabStop = false;
            this.gboOrderInformation.Text = "📝 Order Information";
            // 
            // nudMileage
            // 
            this.nudMileage.Location = new System.Drawing.Point(374, 85);
            this.nudMileage.Maximum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.nudMileage.Name = "nudMileage";
            this.nudMileage.Size = new System.Drawing.Size(111, 21);
            this.nudMileage.TabIndex = 19;
            // 
            // dtpDate
            // 
            this.dtpDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpDate.Location = new System.Drawing.Point(211, 85);
            this.dtpDate.Name = "dtpDate";
            this.dtpDate.Size = new System.Drawing.Size(158, 21);
            this.dtpDate.TabIndex = 18;
            // 
            // lblDate
            // 
            this.lblDate.AutoSize = true;
            this.lblDate.Location = new System.Drawing.Point(208, 67);
            this.lblDate.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(36, 15);
            this.lblDate.TabIndex = 17;
            this.lblDate.Text = "Date:";
            // 
            // txtOrderNum
            // 
            this.txtOrderNum.BackColor = System.Drawing.Color.White;
            this.txtOrderNum.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtOrderNum.Font = new System.Drawing.Font("Arial", 9F);
            this.txtOrderNum.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(43)))), ((int)(((byte)(74)))));
            this.txtOrderNum.Location = new System.Drawing.Point(46, 85);
            this.txtOrderNum.Margin = new System.Windows.Forms.Padding(2);
            this.txtOrderNum.Name = "txtOrderNum";
            this.txtOrderNum.Size = new System.Drawing.Size(158, 21);
            this.txtOrderNum.TabIndex = 16;
            // 
            // lblOrderNum
            // 
            this.lblOrderNum.AutoSize = true;
            this.lblOrderNum.Location = new System.Drawing.Point(43, 68);
            this.lblOrderNum.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblOrderNum.Name = "lblOrderNum";
            this.lblOrderNum.Size = new System.Drawing.Size(51, 15);
            this.lblOrderNum.TabIndex = 15;
            this.lblOrderNum.Text = "Order #:";
            // 
            // lblStatus
            // 
            this.lblStatus.AutoSize = true;
            this.lblStatus.Location = new System.Drawing.Point(384, 22);
            this.lblStatus.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(45, 15);
            this.lblStatus.TabIndex = 14;
            this.lblStatus.Text = "Status:";
            // 
            // lblMileage
            // 
            this.lblMileage.AutoSize = true;
            this.lblMileage.Location = new System.Drawing.Point(371, 67);
            this.lblMileage.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblMileage.Name = "lblMileage";
            this.lblMileage.Size = new System.Drawing.Size(53, 15);
            this.lblMileage.TabIndex = 13;
            this.lblMileage.Text = "Mileage:";
            // 
            // lblVehicle
            // 
            this.lblVehicle.AutoSize = true;
            this.lblVehicle.Location = new System.Drawing.Point(190, 22);
            this.lblVehicle.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblVehicle.Name = "lblVehicle";
            this.lblVehicle.Size = new System.Drawing.Size(49, 15);
            this.lblVehicle.TabIndex = 12;
            this.lblVehicle.Text = "Vehicle:";
            // 
            // lblCustomer
            // 
            this.lblCustomer.AutoSize = true;
            this.lblCustomer.Location = new System.Drawing.Point(38, 22);
            this.lblCustomer.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblCustomer.Name = "lblCustomer";
            this.lblCustomer.Size = new System.Drawing.Size(65, 15);
            this.lblCustomer.TabIndex = 11;
            this.lblCustomer.Text = "Customer:";
            // 
            // cboStatus
            // 
            this.cboStatus.FormattingEnabled = true;
            this.cboStatus.Location = new System.Drawing.Point(383, 39);
            this.cboStatus.Margin = new System.Windows.Forms.Padding(2);
            this.cboStatus.Name = "cboStatus";
            this.cboStatus.Size = new System.Drawing.Size(102, 23);
            this.cboStatus.TabIndex = 7;
            // 
            // cboVehicle
            // 
            this.cboVehicle.FormattingEnabled = true;
            this.cboVehicle.Location = new System.Drawing.Point(193, 39);
            this.cboVehicle.Margin = new System.Windows.Forms.Padding(2);
            this.cboVehicle.Name = "cboVehicle";
            this.cboVehicle.Size = new System.Drawing.Size(186, 23);
            this.cboVehicle.TabIndex = 5;
            this.cboVehicle.SelectedIndexChanged += new System.EventHandler(this.cboVehicle_SelectedIndexChanged);
            // 
            // cboCustomer
            // 
            this.cboCustomer.FormattingEnabled = true;
            this.cboCustomer.Location = new System.Drawing.Point(41, 39);
            this.cboCustomer.Margin = new System.Windows.Forms.Padding(2);
            this.cboCustomer.Name = "cboCustomer";
            this.cboCustomer.Size = new System.Drawing.Size(148, 23);
            this.cboCustomer.TabIndex = 4;
            this.cboCustomer.SelectedIndexChanged += new System.EventHandler(this.cboCustomer_SelectedIndexChanged);
            // 
            // gboParts
            // 
            this.gboParts.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(246)))), ((int)(((byte)(248)))));
            this.gboParts.Controls.Add(this.flpParts);
            this.gboParts.Controls.Add(this.btnOilFilter);
            this.gboParts.Controls.Add(this.btnAirFilter);
            this.gboParts.Controls.Add(this.btnAddParts);
            this.gboParts.Font = new System.Drawing.Font("Arial", 9F);
            this.gboParts.Location = new System.Drawing.Point(12, 489);
            this.gboParts.Margin = new System.Windows.Forms.Padding(2);
            this.gboParts.Name = "gboParts";
            this.gboParts.Padding = new System.Windows.Forms.Padding(2);
            this.gboParts.Size = new System.Drawing.Size(553, 223);
            this.gboParts.TabIndex = 5;
            this.gboParts.TabStop = false;
            this.gboParts.Text = "⚙️ Parts Item";
            // 
            // flpParts
            // 
            this.flpParts.AutoScroll = true;
            this.flpParts.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.flpParts.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flpParts.Location = new System.Drawing.Point(13, 57);
            this.flpParts.Margin = new System.Windows.Forms.Padding(2);
            this.flpParts.Name = "flpParts";
            this.flpParts.Size = new System.Drawing.Size(528, 148);
            this.flpParts.TabIndex = 15;
            this.flpParts.WrapContents = false;
            // 
            // btnOilFilter
            // 
            this.btnOilFilter.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(118)))), ((int)(((byte)(210)))));
            this.btnOilFilter.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnOilFilter.FlatAppearance.BorderSize = 0;
            this.btnOilFilter.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnOilFilter.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold);
            this.btnOilFilter.ForeColor = System.Drawing.Color.White;
            this.btnOilFilter.Location = new System.Drawing.Point(216, 18);
            this.btnOilFilter.Margin = new System.Windows.Forms.Padding(2);
            this.btnOilFilter.Name = "btnOilFilter";
            this.btnOilFilter.Size = new System.Drawing.Size(93, 35);
            this.btnOilFilter.TabIndex = 13;
            this.btnOilFilter.Text = "💧 Oil Filter";
            this.btnOilFilter.UseVisualStyleBackColor = true;
            this.btnOilFilter.Click += new System.EventHandler(this.btnOilFilter_Click);
            // 
            // btnAirFilter
            // 
            this.btnAirFilter.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(118)))), ((int)(((byte)(210)))));
            this.btnAirFilter.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAirFilter.FlatAppearance.BorderSize = 0;
            this.btnAirFilter.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAirFilter.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold);
            this.btnAirFilter.ForeColor = System.Drawing.Color.White;
            this.btnAirFilter.Location = new System.Drawing.Point(112, 18);
            this.btnAirFilter.Margin = new System.Windows.Forms.Padding(2);
            this.btnAirFilter.Name = "btnAirFilter";
            this.btnAirFilter.Size = new System.Drawing.Size(100, 35);
            this.btnAirFilter.TabIndex = 12;
            this.btnAirFilter.Text = "💨Air Filter";
            this.btnAirFilter.UseVisualStyleBackColor = true;
            this.btnAirFilter.Click += new System.EventHandler(this.btnAirFilter_Click);
            // 
            // btnAddParts
            // 
            this.btnAddParts.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(66)))), ((int)(((byte)(66)))));
            this.btnAddParts.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAddParts.FlatAppearance.BorderSize = 0;
            this.btnAddParts.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddParts.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold);
            this.btnAddParts.ForeColor = System.Drawing.Color.White;
            this.btnAddParts.Location = new System.Drawing.Point(313, 18);
            this.btnAddParts.Margin = new System.Windows.Forms.Padding(2);
            this.btnAddParts.Name = "btnAddParts";
            this.btnAddParts.Size = new System.Drawing.Size(90, 35);
            this.btnAddParts.TabIndex = 7;
            this.btnAddParts.Text = "Add Parts";
            this.btnAddParts.UseVisualStyleBackColor = true;
            this.btnAddParts.Click += new System.EventHandler(this.btnAddParts_Click);
            // 
            // gboCostInformation
            // 
            this.gboCostInformation.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(246)))), ((int)(((byte)(248)))));
            this.gboCostInformation.Controls.Add(this.txtFeedback);
            this.gboCostInformation.Controls.Add(this.txtGrandTotal);
            this.gboCostInformation.Controls.Add(this.btnClose);
            this.gboCostInformation.Controls.Add(this.txtPartsTotal);
            this.gboCostInformation.Controls.Add(this.btnCloseOrder);
            this.gboCostInformation.Controls.Add(this.txtLaborTotal);
            this.gboCostInformation.Controls.Add(this.btnSubmitOrder);
            this.gboCostInformation.Controls.Add(this.lblFeedback);
            this.gboCostInformation.Controls.Add(this.lblGrandTotal);
            this.gboCostInformation.Controls.Add(this.lblPartsTotal);
            this.gboCostInformation.Controls.Add(this.lblLaborTotal);
            this.gboCostInformation.Font = new System.Drawing.Font("Arial", 9F);
            this.gboCostInformation.Location = new System.Drawing.Point(12, 716);
            this.gboCostInformation.Margin = new System.Windows.Forms.Padding(2);
            this.gboCostInformation.Name = "gboCostInformation";
            this.gboCostInformation.Padding = new System.Windows.Forms.Padding(2);
            this.gboCostInformation.Size = new System.Drawing.Size(553, 215);
            this.gboCostInformation.TabIndex = 6;
            this.gboCostInformation.TabStop = false;
            this.gboCostInformation.Text = "Cost Information";
            // 
            // txtFeedback
            // 
            this.txtFeedback.BackColor = System.Drawing.Color.White;
            this.txtFeedback.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtFeedback.Font = new System.Drawing.Font("Arial", 9F);
            this.txtFeedback.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(43)))), ((int)(((byte)(74)))));
            this.txtFeedback.Location = new System.Drawing.Point(75, 84);
            this.txtFeedback.Margin = new System.Windows.Forms.Padding(2);
            this.txtFeedback.Multiline = true;
            this.txtFeedback.Name = "txtFeedback";
            this.txtFeedback.Size = new System.Drawing.Size(405, 66);
            this.txtFeedback.TabIndex = 7;
            // 
            // txtGrandTotal
            // 
            this.txtGrandTotal.BackColor = System.Drawing.Color.White;
            this.txtGrandTotal.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtGrandTotal.Font = new System.Drawing.Font("Arial", 11F, System.Drawing.FontStyle.Bold);
            this.txtGrandTotal.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(119)))), ((int)(((byte)(34)))));
            this.txtGrandTotal.Location = new System.Drawing.Point(341, 41);
            this.txtGrandTotal.Margin = new System.Windows.Forms.Padding(2);
            this.txtGrandTotal.Name = "txtGrandTotal";
            this.txtGrandTotal.ReadOnly = true;
            this.txtGrandTotal.Size = new System.Drawing.Size(137, 24);
            this.txtGrandTotal.TabIndex = 6;
            // 
            // btnClose
            // 
            this.btnClose.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(198)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.btnClose.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnClose.FlatAppearance.BorderSize = 0;
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold);
            this.btnClose.ForeColor = System.Drawing.Color.White;
            this.btnClose.Location = new System.Drawing.Point(224, 176);
            this.btnClose.Margin = new System.Windows.Forms.Padding(2);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(110, 35);
            this.btnClose.TabIndex = 10;
            this.btnClose.Text = "✗ Cancel";
            this.btnClose.UseVisualStyleBackColor = false;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // txtPartsTotal
            // 
            this.txtPartsTotal.BackColor = System.Drawing.Color.White;
            this.txtPartsTotal.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtPartsTotal.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold);
            this.txtPartsTotal.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(125)))), ((int)(((byte)(50)))));
            this.txtPartsTotal.Location = new System.Drawing.Point(216, 44);
            this.txtPartsTotal.Margin = new System.Windows.Forms.Padding(2);
            this.txtPartsTotal.Name = "txtPartsTotal";
            this.txtPartsTotal.ReadOnly = true;
            this.txtPartsTotal.Size = new System.Drawing.Size(121, 21);
            this.txtPartsTotal.TabIndex = 5;
            // 
            // btnCloseOrder
            // 
            this.btnCloseOrder.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(66)))), ((int)(((byte)(66)))));
            this.btnCloseOrder.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCloseOrder.FlatAppearance.BorderSize = 0;
            this.btnCloseOrder.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCloseOrder.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold);
            this.btnCloseOrder.ForeColor = System.Drawing.Color.White;
            this.btnCloseOrder.Location = new System.Drawing.Point(338, 176);
            this.btnCloseOrder.Margin = new System.Windows.Forms.Padding(2);
            this.btnCloseOrder.Name = "btnCloseOrder";
            this.btnCloseOrder.Size = new System.Drawing.Size(130, 35);
            this.btnCloseOrder.TabIndex = 8;
            this.btnCloseOrder.Text = "Close Order";
            this.btnCloseOrder.UseVisualStyleBackColor = false;
            this.btnCloseOrder.Click += new System.EventHandler(this.btnCloseOrder_Click);
            // 
            // txtLaborTotal
            // 
            this.txtLaborTotal.BackColor = System.Drawing.Color.White;
            this.txtLaborTotal.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtLaborTotal.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold);
            this.txtLaborTotal.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(125)))), ((int)(((byte)(50)))));
            this.txtLaborTotal.Location = new System.Drawing.Point(75, 44);
            this.txtLaborTotal.Margin = new System.Windows.Forms.Padding(2);
            this.txtLaborTotal.Name = "txtLaborTotal";
            this.txtLaborTotal.ReadOnly = true;
            this.txtLaborTotal.Size = new System.Drawing.Size(137, 21);
            this.txtLaborTotal.TabIndex = 4;
            // 
            // btnSubmitOrder
            // 
            this.btnSubmitOrder.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(125)))), ((int)(((byte)(50)))));
            this.btnSubmitOrder.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSubmitOrder.FlatAppearance.BorderSize = 0;
            this.btnSubmitOrder.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSubmitOrder.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold);
            this.btnSubmitOrder.ForeColor = System.Drawing.Color.White;
            this.btnSubmitOrder.Location = new System.Drawing.Point(70, 176);
            this.btnSubmitOrder.Margin = new System.Windows.Forms.Padding(2);
            this.btnSubmitOrder.Name = "btnSubmitOrder";
            this.btnSubmitOrder.Size = new System.Drawing.Size(150, 35);
            this.btnSubmitOrder.TabIndex = 7;
            this.btnSubmitOrder.Text = "✓ Submit Order";
            this.btnSubmitOrder.UseVisualStyleBackColor = false;
            this.btnSubmitOrder.Click += new System.EventHandler(this.btnSubmitOrder_Click);
            // 
            // lblFeedback
            // 
            this.lblFeedback.AutoSize = true;
            this.lblFeedback.Location = new System.Drawing.Point(72, 67);
            this.lblFeedback.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblFeedback.Name = "lblFeedback";
            this.lblFeedback.Size = new System.Drawing.Size(121, 15);
            this.lblFeedback.TabIndex = 3;
            this.lblFeedback.Text = "Feedback (Optional):";
            // 
            // lblGrandTotal
            // 
            this.lblGrandTotal.AutoSize = true;
            this.lblGrandTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGrandTotal.Location = new System.Drawing.Point(338, 26);
            this.lblGrandTotal.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblGrandTotal.Name = "lblGrandTotal";
            this.lblGrandTotal.Size = new System.Drawing.Size(78, 13);
            this.lblGrandTotal.TabIndex = 2;
            this.lblGrandTotal.Text = "Grand Total:";
            // 
            // lblPartsTotal
            // 
            this.lblPartsTotal.AutoSize = true;
            this.lblPartsTotal.Location = new System.Drawing.Point(213, 29);
            this.lblPartsTotal.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblPartsTotal.Name = "lblPartsTotal";
            this.lblPartsTotal.Size = new System.Drawing.Size(68, 15);
            this.lblPartsTotal.TabIndex = 1;
            this.lblPartsTotal.Text = "Parts Total:";
            // 
            // lblLaborTotal
            // 
            this.lblLaborTotal.AutoSize = true;
            this.lblLaborTotal.Location = new System.Drawing.Point(72, 27);
            this.lblLaborTotal.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblLaborTotal.Name = "lblLaborTotal";
            this.lblLaborTotal.Size = new System.Drawing.Size(71, 15);
            this.lblLaborTotal.TabIndex = 0;
            this.lblLaborTotal.Text = "Labor Total:";
            // 
            // pnlHeader
            // 
            this.pnlHeader.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(43)))), ((int)(((byte)(74)))));
            this.pnlHeader.Controls.Add(this.lblSubtitle);
            this.pnlHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlHeader.ForeColor = System.Drawing.Color.White;
            this.pnlHeader.Location = new System.Drawing.Point(0, 0);
            this.pnlHeader.Name = "pnlHeader";
            this.pnlHeader.Size = new System.Drawing.Size(582, 60);
            this.pnlHeader.TabIndex = 20;
            // 
            // lblSubtitle
            // 
            this.lblSubtitle.AutoSize = true;
            this.lblSubtitle.Font = new System.Drawing.Font("Arial", 8F);
            this.lblSubtitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(200)))), ((int)(((byte)(220)))));
            this.lblSubtitle.Location = new System.Drawing.Point(18, 38);
            this.lblSubtitle.Name = "lblSubtitle";
            this.lblSubtitle.Size = new System.Drawing.Size(167, 14);
            this.lblSubtitle.TabIndex = 22;
            this.lblSubtitle.Text = "Create and manage repair orders";
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(43)))), ((int)(((byte)(74)))));
            this.lblTitle.Font = new System.Drawing.Font("Arial", 14F, System.Drawing.FontStyle.Bold);
            this.lblTitle.ForeColor = System.Drawing.Color.White;
            this.lblTitle.Location = new System.Drawing.Point(15, 10);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(156, 22);
            this.lblTitle.TabIndex = 21;
            this.lblTitle.Text = "📋 Repair Order";
            // 
            // frmRepairOrder
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(246)))), ((int)(((byte)(248)))));
            this.ClientSize = new System.Drawing.Size(582, 942);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.pnlHeader);
            this.Controls.Add(this.gboCostInformation);
            this.Controls.Add(this.gboParts);
            this.Controls.Add(this.gboOrderInformation);
            this.Controls.Add(this.gboLabor);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "frmRepairOrder";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Mechanic Shop - REPAIR ORDER";
            this.gboLabor.ResumeLayout(false);
            this.gboOrderInformation.ResumeLayout(false);
            this.gboOrderInformation.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudMileage)).EndInit();
            this.gboParts.ResumeLayout(false);
            this.gboCostInformation.ResumeLayout(false);
            this.gboCostInformation.PerformLayout();
            this.pnlHeader.ResumeLayout(false);
            this.pnlHeader.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.GroupBox gboLabor;
        private System.Windows.Forms.GroupBox gboOrderInformation;
        private System.Windows.Forms.ComboBox cboStatus;
        private System.Windows.Forms.ComboBox cboVehicle;
        private System.Windows.Forms.ComboBox cboCustomer;
        private System.Windows.Forms.GroupBox gboParts;
        private System.Windows.Forms.Button btnAddLabor;
        private System.Windows.Forms.Button btnAddParts;
        private System.Windows.Forms.GroupBox gboCostInformation;
        private System.Windows.Forms.TextBox txtFeedback;
        private System.Windows.Forms.TextBox txtGrandTotal;
        private System.Windows.Forms.TextBox txtPartsTotal;
        private System.Windows.Forms.TextBox txtLaborTotal;
        private System.Windows.Forms.Label lblFeedback;
        private System.Windows.Forms.Label lblGrandTotal;
        private System.Windows.Forms.Label lblPartsTotal;
        private System.Windows.Forms.Label lblLaborTotal;
        private System.Windows.Forms.Button btnSubmitOrder;
        private System.Windows.Forms.Button btnCloseOrder;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Label lblOrderNum;
        private System.Windows.Forms.Label lblStatus;
        private System.Windows.Forms.Label lblMileage;
        private System.Windows.Forms.Label lblVehicle;
        private System.Windows.Forms.Label lblCustomer;
        private System.Windows.Forms.Label lblDate;
        private System.Windows.Forms.TextBox txtOrderNum;
        private System.Windows.Forms.DateTimePicker dtpDate;
        private System.Windows.Forms.NumericUpDown nudMileage;
        private System.Windows.Forms.Button btnDiagnostic;
        private System.Windows.Forms.Button btnTireRotation;
        private System.Windows.Forms.Button btnBrakePad;
        private System.Windows.Forms.Button btnOilChange;
        private System.Windows.Forms.Button btnOilFilter;
        private System.Windows.Forms.Button btnAirFilter;
        private System.Windows.Forms.FlowLayoutPanel flpLabor;
        private System.Windows.Forms.FlowLayoutPanel flpParts;
        private System.Windows.Forms.Panel pnlHeader;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblSubtitle;
    }
}