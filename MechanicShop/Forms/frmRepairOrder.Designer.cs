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
            this.btnRemoveLabor = new System.Windows.Forms.Button();
            this.btnDiagnostic = new System.Windows.Forms.Button();
            this.btnTireRotation = new System.Windows.Forms.Button();
            this.btnBrakePad = new System.Windows.Forms.Button();
            this.btnOilChange = new System.Windows.Forms.Button();
            this.btnAddLabor = new System.Windows.Forms.Button();
            this.dgvLaborItems = new System.Windows.Forms.DataGridView();
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
            this.btnRemoveParts = new System.Windows.Forms.Button();
            this.btnOilFilter = new System.Windows.Forms.Button();
            this.btnAirFilter = new System.Windows.Forms.Button();
            this.btnAddParts = new System.Windows.Forms.Button();
            this.dgvPartsItem = new System.Windows.Forms.DataGridView();
            this.gboCostInformation = new System.Windows.Forms.GroupBox();
            this.txtFeedback = new System.Windows.Forms.TextBox();
            this.txtGrandTotal = new System.Windows.Forms.TextBox();
            this.txtPartsTotal = new System.Windows.Forms.TextBox();
            this.txtLaborTotal = new System.Windows.Forms.TextBox();
            this.lblFeedback = new System.Windows.Forms.Label();
            this.lblGrandTotal = new System.Windows.Forms.Label();
            this.lblPartsTotal = new System.Windows.Forms.Label();
            this.lblLaborTotal = new System.Windows.Forms.Label();
            this.btnSubmitOrder = new System.Windows.Forms.Button();
            this.btnCloseOrder = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.gboLabor.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLaborItems)).BeginInit();
            this.gboOrderInformation.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudMileage)).BeginInit();
            this.gboParts.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPartsItem)).BeginInit();
            this.gboCostInformation.SuspendLayout();
            this.SuspendLayout();
            // 
            // gboLabor
            // 
            this.gboLabor.Controls.Add(this.btnRemoveLabor);
            this.gboLabor.Controls.Add(this.btnDiagnostic);
            this.gboLabor.Controls.Add(this.btnTireRotation);
            this.gboLabor.Controls.Add(this.btnBrakePad);
            this.gboLabor.Controls.Add(this.btnOilChange);
            this.gboLabor.Controls.Add(this.btnAddLabor);
            this.gboLabor.Controls.Add(this.dgvLaborItems);
            this.gboLabor.Location = new System.Drawing.Point(8, 114);
            this.gboLabor.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.gboLabor.Name = "gboLabor";
            this.gboLabor.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.gboLabor.Size = new System.Drawing.Size(453, 207);
            this.gboLabor.TabIndex = 4;
            this.gboLabor.TabStop = false;
            this.gboLabor.Text = "Labor";
            // 
            // btnRemoveLabor
            // 
            this.btnRemoveLabor.Location = new System.Drawing.Point(217, 169);
            this.btnRemoveLabor.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnRemoveLabor.Name = "btnRemoveLabor";
            this.btnRemoveLabor.Size = new System.Drawing.Size(85, 27);
            this.btnRemoveLabor.TabIndex = 15;
            this.btnRemoveLabor.Text = "Remove Labor";
            this.btnRemoveLabor.UseVisualStyleBackColor = true;
            this.btnRemoveLabor.Click += new System.EventHandler(this.btnRemoveLabor_Click);
            // 
            // btnDiagnostic
            // 
            this.btnDiagnostic.Location = new System.Drawing.Point(295, 138);
            this.btnDiagnostic.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnDiagnostic.Name = "btnDiagnostic";
            this.btnDiagnostic.Size = new System.Drawing.Size(69, 27);
            this.btnDiagnostic.TabIndex = 14;
            this.btnDiagnostic.Text = "Diagnostics";
            this.btnDiagnostic.UseVisualStyleBackColor = true;
            this.btnDiagnostic.Click += new System.EventHandler(this.btnDiagnostic_Click);
            // 
            // btnTireRotation
            // 
            this.btnTireRotation.Location = new System.Drawing.Point(217, 138);
            this.btnTireRotation.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnTireRotation.Name = "btnTireRotation";
            this.btnTireRotation.Size = new System.Drawing.Size(74, 27);
            this.btnTireRotation.TabIndex = 13;
            this.btnTireRotation.Text = "Tire Rotation";
            this.btnTireRotation.UseVisualStyleBackColor = true;
            this.btnTireRotation.Click += new System.EventHandler(this.btnTireRotation_Click);
            // 
            // btnBrakePad
            // 
            this.btnBrakePad.Location = new System.Drawing.Point(137, 138);
            this.btnBrakePad.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnBrakePad.Name = "btnBrakePad";
            this.btnBrakePad.Size = new System.Drawing.Size(76, 27);
            this.btnBrakePad.TabIndex = 12;
            this.btnBrakePad.Text = "Brake Pads";
            this.btnBrakePad.UseVisualStyleBackColor = true;
            this.btnBrakePad.Click += new System.EventHandler(this.btnBrakePad_Click);
            // 
            // btnOilChange
            // 
            this.btnOilChange.Location = new System.Drawing.Point(59, 138);
            this.btnOilChange.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnOilChange.Name = "btnOilChange";
            this.btnOilChange.Size = new System.Drawing.Size(75, 27);
            this.btnOilChange.TabIndex = 11;
            this.btnOilChange.Text = "Oil Change";
            this.btnOilChange.UseVisualStyleBackColor = true;
            this.btnOilChange.Click += new System.EventHandler(this.btnOilChange_Click);
            // 
            // btnAddLabor
            // 
            this.btnAddLabor.Location = new System.Drawing.Point(133, 169);
            this.btnAddLabor.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnAddLabor.Name = "btnAddLabor";
            this.btnAddLabor.Size = new System.Drawing.Size(79, 27);
            this.btnAddLabor.TabIndex = 6;
            this.btnAddLabor.Text = "Add Labor";
            this.btnAddLabor.UseVisualStyleBackColor = true;
            this.btnAddLabor.Click += new System.EventHandler(this.btnAddLabor_Click);
            // 
            // dgvLaborItems
            // 
            this.dgvLaborItems.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvLaborItems.Location = new System.Drawing.Point(11, 16);
            this.dgvLaborItems.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dgvLaborItems.Name = "dgvLaborItems";
            this.dgvLaborItems.RowHeadersWidth = 62;
            this.dgvLaborItems.RowTemplate.Height = 28;
            this.dgvLaborItems.Size = new System.Drawing.Size(428, 112);
            this.dgvLaborItems.TabIndex = 0;
            // 
            // gboOrderInformation
            // 
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
            this.gboOrderInformation.Location = new System.Drawing.Point(8, 7);
            this.gboOrderInformation.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.gboOrderInformation.Name = "gboOrderInformation";
            this.gboOrderInformation.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.gboOrderInformation.Size = new System.Drawing.Size(453, 103);
            this.gboOrderInformation.TabIndex = 5;
            this.gboOrderInformation.TabStop = false;
            this.gboOrderInformation.Text = "Order Information";
            // 
            // nudMileage
            // 
            this.nudMileage.Location = new System.Drawing.Point(67, 72);
            this.nudMileage.Maximum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.nudMileage.Name = "nudMileage";
            this.nudMileage.Size = new System.Drawing.Size(66, 20);
            this.nudMileage.TabIndex = 19;
            // 
            // dtpDate
            // 
            this.dtpDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpDate.Location = new System.Drawing.Point(266, 50);
            this.dtpDate.Name = "dtpDate";
            this.dtpDate.Size = new System.Drawing.Size(128, 20);
            this.dtpDate.TabIndex = 18;
            // 
            // lblDate
            // 
            this.lblDate.AutoSize = true;
            this.lblDate.Location = new System.Drawing.Point(229, 52);
            this.lblDate.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(33, 13);
            this.lblDate.TabIndex = 17;
            this.lblDate.Text = "Date:";
            // 
            // txtOrderNum
            // 
            this.txtOrderNum.Location = new System.Drawing.Point(266, 27);
            this.txtOrderNum.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtOrderNum.Name = "txtOrderNum";
            this.txtOrderNum.Size = new System.Drawing.Size(128, 20);
            this.txtOrderNum.TabIndex = 16;
            // 
            // lblOrderNum
            // 
            this.lblOrderNum.AutoSize = true;
            this.lblOrderNum.Location = new System.Drawing.Point(217, 32);
            this.lblOrderNum.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblOrderNum.Name = "lblOrderNum";
            this.lblOrderNum.Size = new System.Drawing.Size(46, 13);
            this.lblOrderNum.TabIndex = 15;
            this.lblOrderNum.Text = "Order #:";
            // 
            // lblStatus
            // 
            this.lblStatus.AutoSize = true;
            this.lblStatus.Location = new System.Drawing.Point(222, 71);
            this.lblStatus.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(40, 13);
            this.lblStatus.TabIndex = 14;
            this.lblStatus.Text = "Status:";
            // 
            // lblMileage
            // 
            this.lblMileage.AutoSize = true;
            this.lblMileage.Location = new System.Drawing.Point(18, 74);
            this.lblMileage.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblMileage.Name = "lblMileage";
            this.lblMileage.Size = new System.Drawing.Size(47, 13);
            this.lblMileage.TabIndex = 13;
            this.lblMileage.Text = "Mileage:";
            // 
            // lblVehicle
            // 
            this.lblVehicle.AutoSize = true;
            this.lblVehicle.Location = new System.Drawing.Point(20, 52);
            this.lblVehicle.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblVehicle.Name = "lblVehicle";
            this.lblVehicle.Size = new System.Drawing.Size(45, 13);
            this.lblVehicle.TabIndex = 12;
            this.lblVehicle.Text = "Vehicle:";
            // 
            // lblCustomer
            // 
            this.lblCustomer.AutoSize = true;
            this.lblCustomer.Location = new System.Drawing.Point(11, 30);
            this.lblCustomer.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblCustomer.Name = "lblCustomer";
            this.lblCustomer.Size = new System.Drawing.Size(54, 13);
            this.lblCustomer.TabIndex = 11;
            this.lblCustomer.Text = "Customer:";
            // 
            // cboStatus
            // 
            this.cboStatus.FormattingEnabled = true;
            this.cboStatus.Location = new System.Drawing.Point(267, 72);
            this.cboStatus.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cboStatus.Name = "cboStatus";
            this.cboStatus.Size = new System.Drawing.Size(127, 21);
            this.cboStatus.TabIndex = 7;
            // 
            // cboVehicle
            // 
            this.cboVehicle.FormattingEnabled = true;
            this.cboVehicle.Location = new System.Drawing.Point(67, 50);
            this.cboVehicle.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cboVehicle.Name = "cboVehicle";
            this.cboVehicle.Size = new System.Drawing.Size(135, 21);
            this.cboVehicle.TabIndex = 5;
            this.cboVehicle.SelectedIndexChanged += new System.EventHandler(this.cboVehicle_SelectedIndexChanged);
            // 
            // cboCustomer
            // 
            this.cboCustomer.FormattingEnabled = true;
            this.cboCustomer.Location = new System.Drawing.Point(67, 28);
            this.cboCustomer.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cboCustomer.Name = "cboCustomer";
            this.cboCustomer.Size = new System.Drawing.Size(135, 21);
            this.cboCustomer.TabIndex = 4;
            this.cboCustomer.SelectedIndexChanged += new System.EventHandler(this.cboCustomer_SelectedIndexChanged);
            // 
            // gboParts
            // 
            this.gboParts.Controls.Add(this.btnRemoveParts);
            this.gboParts.Controls.Add(this.btnOilFilter);
            this.gboParts.Controls.Add(this.btnAirFilter);
            this.gboParts.Controls.Add(this.btnAddParts);
            this.gboParts.Controls.Add(this.dgvPartsItem);
            this.gboParts.Location = new System.Drawing.Point(8, 324);
            this.gboParts.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.gboParts.Name = "gboParts";
            this.gboParts.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.gboParts.Size = new System.Drawing.Size(453, 172);
            this.gboParts.TabIndex = 5;
            this.gboParts.TabStop = false;
            this.gboParts.Text = "Parts";
            // 
            // btnRemoveParts
            // 
            this.btnRemoveParts.Location = new System.Drawing.Point(307, 137);
            this.btnRemoveParts.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnRemoveParts.Name = "btnRemoveParts";
            this.btnRemoveParts.Size = new System.Drawing.Size(79, 27);
            this.btnRemoveParts.TabIndex = 14;
            this.btnRemoveParts.Text = "Remove Parts";
            this.btnRemoveParts.UseVisualStyleBackColor = true;
            this.btnRemoveParts.Click += new System.EventHandler(this.btnRemoveParts_Click);
            // 
            // btnOilFilter
            // 
            this.btnOilFilter.Location = new System.Drawing.Point(145, 137);
            this.btnOilFilter.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnOilFilter.Name = "btnOilFilter";
            this.btnOilFilter.Size = new System.Drawing.Size(75, 27);
            this.btnOilFilter.TabIndex = 13;
            this.btnOilFilter.Text = "Oil Filter";
            this.btnOilFilter.UseVisualStyleBackColor = true;
            this.btnOilFilter.Click += new System.EventHandler(this.btnOilFilter_Click);
            // 
            // btnAirFilter
            // 
            this.btnAirFilter.Location = new System.Drawing.Point(67, 137);
            this.btnAirFilter.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnAirFilter.Name = "btnAirFilter";
            this.btnAirFilter.Size = new System.Drawing.Size(75, 27);
            this.btnAirFilter.TabIndex = 12;
            this.btnAirFilter.Text = "Air Filter";
            this.btnAirFilter.UseVisualStyleBackColor = true;
            this.btnAirFilter.Click += new System.EventHandler(this.btnAirFilter_Click);
            // 
            // btnAddParts
            // 
            this.btnAddParts.Location = new System.Drawing.Point(224, 137);
            this.btnAddParts.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnAddParts.Name = "btnAddParts";
            this.btnAddParts.Size = new System.Drawing.Size(79, 27);
            this.btnAddParts.TabIndex = 7;
            this.btnAddParts.Text = "Add Parts";
            this.btnAddParts.UseVisualStyleBackColor = true;
            this.btnAddParts.Click += new System.EventHandler(this.btnAddParts_Click);
            // 
            // dgvPartsItem
            // 
            this.dgvPartsItem.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPartsItem.Location = new System.Drawing.Point(11, 16);
            this.dgvPartsItem.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dgvPartsItem.Name = "dgvPartsItem";
            this.dgvPartsItem.RowHeadersWidth = 62;
            this.dgvPartsItem.RowTemplate.Height = 28;
            this.dgvPartsItem.Size = new System.Drawing.Size(428, 117);
            this.dgvPartsItem.TabIndex = 0;
            // 
            // gboCostInformation
            // 
            this.gboCostInformation.Controls.Add(this.txtFeedback);
            this.gboCostInformation.Controls.Add(this.txtGrandTotal);
            this.gboCostInformation.Controls.Add(this.txtPartsTotal);
            this.gboCostInformation.Controls.Add(this.txtLaborTotal);
            this.gboCostInformation.Controls.Add(this.lblFeedback);
            this.gboCostInformation.Controls.Add(this.lblGrandTotal);
            this.gboCostInformation.Controls.Add(this.lblPartsTotal);
            this.gboCostInformation.Controls.Add(this.lblLaborTotal);
            this.gboCostInformation.Location = new System.Drawing.Point(8, 500);
            this.gboCostInformation.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.gboCostInformation.Name = "gboCostInformation";
            this.gboCostInformation.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.gboCostInformation.Size = new System.Drawing.Size(455, 138);
            this.gboCostInformation.TabIndex = 6;
            this.gboCostInformation.TabStop = false;
            this.gboCostInformation.Text = "Cost Information";
            // 
            // txtFeedback
            // 
            this.txtFeedback.Location = new System.Drawing.Point(131, 66);
            this.txtFeedback.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtFeedback.Multiline = true;
            this.txtFeedback.Name = "txtFeedback";
            this.txtFeedback.Size = new System.Drawing.Size(296, 66);
            this.txtFeedback.TabIndex = 7;
            // 
            // txtGrandTotal
            // 
            this.txtGrandTotal.Location = new System.Drawing.Point(97, 43);
            this.txtGrandTotal.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtGrandTotal.Name = "txtGrandTotal";
            this.txtGrandTotal.Size = new System.Drawing.Size(99, 20);
            this.txtGrandTotal.TabIndex = 6;
            // 
            // txtPartsTotal
            // 
            this.txtPartsTotal.Location = new System.Drawing.Point(307, 17);
            this.txtPartsTotal.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtPartsTotal.Name = "txtPartsTotal";
            this.txtPartsTotal.Size = new System.Drawing.Size(99, 20);
            this.txtPartsTotal.TabIndex = 5;
            // 
            // txtLaborTotal
            // 
            this.txtLaborTotal.Location = new System.Drawing.Point(88, 19);
            this.txtLaborTotal.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtLaborTotal.Name = "txtLaborTotal";
            this.txtLaborTotal.Size = new System.Drawing.Size(99, 20);
            this.txtLaborTotal.TabIndex = 4;
            // 
            // lblFeedback
            // 
            this.lblFeedback.AutoSize = true;
            this.lblFeedback.Location = new System.Drawing.Point(22, 68);
            this.lblFeedback.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblFeedback.Name = "lblFeedback";
            this.lblFeedback.Size = new System.Drawing.Size(106, 13);
            this.lblFeedback.TabIndex = 3;
            this.lblFeedback.Text = "Feedback (Optional):";
            // 
            // lblGrandTotal
            // 
            this.lblGrandTotal.AutoSize = true;
            this.lblGrandTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGrandTotal.Location = new System.Drawing.Point(21, 45);
            this.lblGrandTotal.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblGrandTotal.Name = "lblGrandTotal";
            this.lblGrandTotal.Size = new System.Drawing.Size(78, 13);
            this.lblGrandTotal.TabIndex = 2;
            this.lblGrandTotal.Text = "Grand Total:";
            // 
            // lblPartsTotal
            // 
            this.lblPartsTotal.AutoSize = true;
            this.lblPartsTotal.Location = new System.Drawing.Point(244, 19);
            this.lblPartsTotal.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblPartsTotal.Name = "lblPartsTotal";
            this.lblPartsTotal.Size = new System.Drawing.Size(61, 13);
            this.lblPartsTotal.TabIndex = 1;
            this.lblPartsTotal.Text = "Parts Total:";
            // 
            // lblLaborTotal
            // 
            this.lblLaborTotal.AutoSize = true;
            this.lblLaborTotal.Location = new System.Drawing.Point(21, 19);
            this.lblLaborTotal.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblLaborTotal.Name = "lblLaborTotal";
            this.lblLaborTotal.Size = new System.Drawing.Size(64, 13);
            this.lblLaborTotal.TabIndex = 0;
            this.lblLaborTotal.Text = "Labor Total:";
            // 
            // btnSubmitOrder
            // 
            this.btnSubmitOrder.Location = new System.Drawing.Point(85, 643);
            this.btnSubmitOrder.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnSubmitOrder.Name = "btnSubmitOrder";
            this.btnSubmitOrder.Size = new System.Drawing.Size(87, 23);
            this.btnSubmitOrder.TabIndex = 7;
            this.btnSubmitOrder.Text = "Submit Order";
            this.btnSubmitOrder.UseVisualStyleBackColor = true;
            this.btnSubmitOrder.Click += new System.EventHandler(this.btnSubmitOrder_Click);
            // 
            // btnCloseOrder
            // 
            this.btnCloseOrder.Location = new System.Drawing.Point(188, 642);
            this.btnCloseOrder.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnCloseOrder.Name = "btnCloseOrder";
            this.btnCloseOrder.Size = new System.Drawing.Size(83, 23);
            this.btnCloseOrder.TabIndex = 8;
            this.btnCloseOrder.Text = "Close Order";
            this.btnCloseOrder.UseVisualStyleBackColor = true;
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(290, 642);
            this.btnClose.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(67, 23);
            this.btnClose.TabIndex = 10;
            this.btnClose.Text = "Cancel";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // frmRepairOrder
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(471, 682);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnCloseOrder);
            this.Controls.Add(this.btnSubmitOrder);
            this.Controls.Add(this.gboCostInformation);
            this.Controls.Add(this.gboParts);
            this.Controls.Add(this.gboOrderInformation);
            this.Controls.Add(this.gboLabor);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "frmRepairOrder";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Mechanic Shop - REPAIR ORDER";
            this.gboLabor.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvLaborItems)).EndInit();
            this.gboOrderInformation.ResumeLayout(false);
            this.gboOrderInformation.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudMileage)).EndInit();
            this.gboParts.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPartsItem)).EndInit();
            this.gboCostInformation.ResumeLayout(false);
            this.gboCostInformation.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.GroupBox gboLabor;
        private System.Windows.Forms.DataGridView dgvLaborItems;
        private System.Windows.Forms.GroupBox gboOrderInformation;
        private System.Windows.Forms.ComboBox cboStatus;
        private System.Windows.Forms.ComboBox cboVehicle;
        private System.Windows.Forms.ComboBox cboCustomer;
        private System.Windows.Forms.GroupBox gboParts;
        private System.Windows.Forms.DataGridView dgvPartsItem;
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
        private System.Windows.Forms.Button btnRemoveLabor;
        private System.Windows.Forms.Button btnRemoveParts;
    }
}