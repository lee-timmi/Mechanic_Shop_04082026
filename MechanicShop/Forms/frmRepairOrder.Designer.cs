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
            this.btnGenerateInvoice = new System.Windows.Forms.Button();
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
            this.gboLabor.Controls.Add(this.btnAddLabor);
            this.gboLabor.Controls.Add(this.dgvLaborItems);
            this.gboLabor.Location = new System.Drawing.Point(12, 175);
            this.gboLabor.Name = "gboLabor";
            this.gboLabor.Size = new System.Drawing.Size(680, 265);
            this.gboLabor.TabIndex = 4;
            this.gboLabor.TabStop = false;
            this.gboLabor.Text = "Labor";
            // 
            // btnAddLabor
            // 
            this.btnAddLabor.Location = new System.Drawing.Point(542, 229);
            this.btnAddLabor.Name = "btnAddLabor";
            this.btnAddLabor.Size = new System.Drawing.Size(106, 31);
            this.btnAddLabor.TabIndex = 6;
            this.btnAddLabor.Text = "Add Labor";
            this.btnAddLabor.UseVisualStyleBackColor = true;
            this.btnAddLabor.Click += new System.EventHandler(this.btnAddLabor_Click);
            // 
            // dgvLaborItems
            // 
            this.dgvLaborItems.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvLaborItems.Location = new System.Drawing.Point(16, 25);
            this.dgvLaborItems.Name = "dgvLaborItems";
            this.dgvLaborItems.RowHeadersWidth = 62;
            this.dgvLaborItems.RowTemplate.Height = 28;
            this.dgvLaborItems.Size = new System.Drawing.Size(642, 198);
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
            this.gboOrderInformation.Location = new System.Drawing.Point(12, 11);
            this.gboOrderInformation.Name = "gboOrderInformation";
            this.gboOrderInformation.Size = new System.Drawing.Size(680, 158);
            this.gboOrderInformation.TabIndex = 5;
            this.gboOrderInformation.TabStop = false;
            this.gboOrderInformation.Text = "Order Information";
            // 
            // nudMileage
            // 
            this.nudMileage.Location = new System.Drawing.Point(100, 111);
            this.nudMileage.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.nudMileage.Maximum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.nudMileage.Name = "nudMileage";
            this.nudMileage.Size = new System.Drawing.Size(99, 26);
            this.nudMileage.TabIndex = 19;
            // 
            // dtpDate
            // 
            this.dtpDate.Location = new System.Drawing.Point(399, 80);
            this.dtpDate.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dtpDate.Name = "dtpDate";
            this.dtpDate.Size = new System.Drawing.Size(271, 26);
            this.dtpDate.TabIndex = 18;
            // 
            // lblDate
            // 
            this.lblDate.AutoSize = true;
            this.lblDate.Location = new System.Drawing.Point(344, 80);
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(48, 20);
            this.lblDate.TabIndex = 17;
            this.lblDate.Text = "Date:";
            // 
            // txtOrderNum
            // 
            this.txtOrderNum.Location = new System.Drawing.Point(398, 46);
            this.txtOrderNum.Name = "txtOrderNum";
            this.txtOrderNum.Size = new System.Drawing.Size(190, 26);
            this.txtOrderNum.TabIndex = 16;
            // 
            // lblOrderNum
            // 
            this.lblOrderNum.AutoSize = true;
            this.lblOrderNum.Location = new System.Drawing.Point(326, 49);
            this.lblOrderNum.Name = "lblOrderNum";
            this.lblOrderNum.Size = new System.Drawing.Size(66, 20);
            this.lblOrderNum.TabIndex = 15;
            this.lblOrderNum.Text = "Order #:";
            // 
            // lblStatus
            // 
            this.lblStatus.AutoSize = true;
            this.lblStatus.Location = new System.Drawing.Point(333, 109);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(60, 20);
            this.lblStatus.TabIndex = 14;
            this.lblStatus.Text = "Status:";
            // 
            // lblMileage
            // 
            this.lblMileage.AutoSize = true;
            this.lblMileage.Location = new System.Drawing.Point(27, 114);
            this.lblMileage.Name = "lblMileage";
            this.lblMileage.Size = new System.Drawing.Size(68, 20);
            this.lblMileage.TabIndex = 13;
            this.lblMileage.Text = "Mileage:";
            // 
            // lblVehicle
            // 
            this.lblVehicle.AutoSize = true;
            this.lblVehicle.Location = new System.Drawing.Point(30, 80);
            this.lblVehicle.Name = "lblVehicle";
            this.lblVehicle.Size = new System.Drawing.Size(65, 20);
            this.lblVehicle.TabIndex = 12;
            this.lblVehicle.Text = "Vehicle:";
            // 
            // lblCustomer
            // 
            this.lblCustomer.AutoSize = true;
            this.lblCustomer.Location = new System.Drawing.Point(16, 46);
            this.lblCustomer.Name = "lblCustomer";
            this.lblCustomer.Size = new System.Drawing.Size(82, 20);
            this.lblCustomer.TabIndex = 11;
            this.lblCustomer.Text = "Customer:";
            // 
            // cboStatus
            // 
            this.cboStatus.FormattingEnabled = true;
            this.cboStatus.Location = new System.Drawing.Point(399, 106);
            this.cboStatus.Name = "cboStatus";
            this.cboStatus.Size = new System.Drawing.Size(120, 28);
            this.cboStatus.TabIndex = 7;
            // 
            // cboVehicle
            // 
            this.cboVehicle.FormattingEnabled = true;
            this.cboVehicle.Location = new System.Drawing.Point(100, 77);
            this.cboVehicle.Name = "cboVehicle";
            this.cboVehicle.Size = new System.Drawing.Size(200, 28);
            this.cboVehicle.TabIndex = 5;
            this.cboVehicle.SelectedIndexChanged += new System.EventHandler(this.cboVehicle_SelectedIndexChanged);
            // 
            // cboCustomer
            // 
            this.cboCustomer.FormattingEnabled = true;
            this.cboCustomer.Location = new System.Drawing.Point(100, 43);
            this.cboCustomer.Name = "cboCustomer";
            this.cboCustomer.Size = new System.Drawing.Size(200, 28);
            this.cboCustomer.TabIndex = 4;
            this.cboCustomer.SelectedIndexChanged += new System.EventHandler(this.cboCustomer_SelectedIndexChanged);
            // 
            // gboParts
            // 
            this.gboParts.Controls.Add(this.btnAddParts);
            this.gboParts.Controls.Add(this.dgvPartsItem);
            this.gboParts.Location = new System.Drawing.Point(12, 448);
            this.gboParts.Name = "gboParts";
            this.gboParts.Size = new System.Drawing.Size(680, 265);
            this.gboParts.TabIndex = 5;
            this.gboParts.TabStop = false;
            this.gboParts.Text = "Parts";
            // 
            // btnAddParts
            // 
            this.btnAddParts.Location = new System.Drawing.Point(542, 229);
            this.btnAddParts.Name = "btnAddParts";
            this.btnAddParts.Size = new System.Drawing.Size(106, 31);
            this.btnAddParts.TabIndex = 7;
            this.btnAddParts.Text = "Add Parts";
            this.btnAddParts.UseVisualStyleBackColor = true;
            this.btnAddParts.Click += new System.EventHandler(this.btnAddParts_Click);
            // 
            // dgvPartsItem
            // 
            this.dgvPartsItem.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPartsItem.Location = new System.Drawing.Point(16, 25);
            this.dgvPartsItem.Name = "dgvPartsItem";
            this.dgvPartsItem.RowHeadersWidth = 62;
            this.dgvPartsItem.RowTemplate.Height = 28;
            this.dgvPartsItem.Size = new System.Drawing.Size(642, 198);
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
            this.gboCostInformation.Location = new System.Drawing.Point(12, 718);
            this.gboCostInformation.Name = "gboCostInformation";
            this.gboCostInformation.Size = new System.Drawing.Size(682, 231);
            this.gboCostInformation.TabIndex = 6;
            this.gboCostInformation.TabStop = false;
            this.gboCostInformation.Text = "Cost Information";
            // 
            // txtFeedback
            // 
            this.txtFeedback.Location = new System.Drawing.Point(202, 126);
            this.txtFeedback.Multiline = true;
            this.txtFeedback.Name = "txtFeedback";
            this.txtFeedback.Size = new System.Drawing.Size(442, 99);
            this.txtFeedback.TabIndex = 7;
            // 
            // txtGrandTotal
            // 
            this.txtGrandTotal.Location = new System.Drawing.Point(154, 72);
            this.txtGrandTotal.Name = "txtGrandTotal";
            this.txtGrandTotal.Size = new System.Drawing.Size(146, 26);
            this.txtGrandTotal.TabIndex = 6;
            // 
            // txtPartsTotal
            // 
            this.txtPartsTotal.Location = new System.Drawing.Point(468, 32);
            this.txtPartsTotal.Name = "txtPartsTotal";
            this.txtPartsTotal.Size = new System.Drawing.Size(146, 26);
            this.txtPartsTotal.TabIndex = 5;
            // 
            // txtLaborTotal
            // 
            this.txtLaborTotal.Location = new System.Drawing.Point(140, 35);
            this.txtLaborTotal.Name = "txtLaborTotal";
            this.txtLaborTotal.Size = new System.Drawing.Size(146, 26);
            this.txtLaborTotal.TabIndex = 4;
            // 
            // lblFeedback
            // 
            this.lblFeedback.AutoSize = true;
            this.lblFeedback.Location = new System.Drawing.Point(40, 129);
            this.lblFeedback.Name = "lblFeedback";
            this.lblFeedback.Size = new System.Drawing.Size(157, 20);
            this.lblFeedback.TabIndex = 3;
            this.lblFeedback.Text = "Feedback (Optional):";
            // 
            // lblGrandTotal
            // 
            this.lblGrandTotal.AutoSize = true;
            this.lblGrandTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGrandTotal.Location = new System.Drawing.Point(40, 75);
            this.lblGrandTotal.Name = "lblGrandTotal";
            this.lblGrandTotal.Size = new System.Drawing.Size(109, 20);
            this.lblGrandTotal.TabIndex = 2;
            this.lblGrandTotal.Text = "Grand Total:";
            // 
            // lblPartsTotal
            // 
            this.lblPartsTotal.AutoSize = true;
            this.lblPartsTotal.Location = new System.Drawing.Point(374, 35);
            this.lblPartsTotal.Name = "lblPartsTotal";
            this.lblPartsTotal.Size = new System.Drawing.Size(89, 20);
            this.lblPartsTotal.TabIndex = 1;
            this.lblPartsTotal.Text = "Parts Total:";
            // 
            // lblLaborTotal
            // 
            this.lblLaborTotal.AutoSize = true;
            this.lblLaborTotal.Location = new System.Drawing.Point(40, 35);
            this.lblLaborTotal.Name = "lblLaborTotal";
            this.lblLaborTotal.Size = new System.Drawing.Size(93, 20);
            this.lblLaborTotal.TabIndex = 0;
            this.lblLaborTotal.Text = "Labor Total:";
            // 
            // btnSubmitOrder
            // 
            this.btnSubmitOrder.Location = new System.Drawing.Point(74, 989);
            this.btnSubmitOrder.Name = "btnSubmitOrder";
            this.btnSubmitOrder.Size = new System.Drawing.Size(130, 35);
            this.btnSubmitOrder.TabIndex = 7;
            this.btnSubmitOrder.Text = "Submit Order";
            this.btnSubmitOrder.UseVisualStyleBackColor = true;
            this.btnSubmitOrder.Click += new System.EventHandler(this.btnSubmitOrder_Click);
            // 
            // btnCloseOrder
            // 
            this.btnCloseOrder.Location = new System.Drawing.Point(208, 989);
            this.btnCloseOrder.Name = "btnCloseOrder";
            this.btnCloseOrder.Size = new System.Drawing.Size(124, 35);
            this.btnCloseOrder.TabIndex = 8;
            this.btnCloseOrder.Text = "Close Order";
            this.btnCloseOrder.UseVisualStyleBackColor = true;
            // 
            // btnGenerateInvoice
            // 
            this.btnGenerateInvoice.Location = new System.Drawing.Point(339, 989);
            this.btnGenerateInvoice.Name = "btnGenerateInvoice";
            this.btnGenerateInvoice.Size = new System.Drawing.Size(156, 35);
            this.btnGenerateInvoice.TabIndex = 9;
            this.btnGenerateInvoice.Text = "Generate Invoice";
            this.btnGenerateInvoice.UseVisualStyleBackColor = true;
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(501, 989);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(100, 35);
            this.btnClose.TabIndex = 10;
            this.btnClose.Text = "Cancel";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // frmRepairOrder
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(706, 1048);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnGenerateInvoice);
            this.Controls.Add(this.btnCloseOrder);
            this.Controls.Add(this.btnSubmitOrder);
            this.Controls.Add(this.gboCostInformation);
            this.Controls.Add(this.gboParts);
            this.Controls.Add(this.gboOrderInformation);
            this.Controls.Add(this.gboLabor);
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
        private System.Windows.Forms.Button btnGenerateInvoice;
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
    }
}