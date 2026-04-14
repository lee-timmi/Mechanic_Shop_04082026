namespace MechanicShop.Forms
{
    partial class frmCustomer
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
            this.btnSave = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.gboCustomerInfo = new System.Windows.Forms.GroupBox();
            this.lblCustomerAddress = new System.Windows.Forms.Label();
            this.lblCustomerEmail = new System.Windows.Forms.Label();
            this.lblCustomerPhone = new System.Windows.Forms.Label();
            this.lblCustomerLastName = new System.Windows.Forms.Label();
            this.lblCustomerFirstName = new System.Windows.Forms.Label();
            this.txtAddress = new System.Windows.Forms.TextBox();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.txtPhone = new System.Windows.Forms.TextBox();
            this.txtLastName = new System.Windows.Forms.TextBox();
            this.txtFirstName = new System.Windows.Forms.TextBox();
            this.gboCustomerEdit = new System.Windows.Forms.GroupBox();
            this.lblStatus = new System.Windows.Forms.Label();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnEdit = new System.Windows.Forms.Button();
            this.btnAddNew = new System.Windows.Forms.Button();
            this.btnShowAll = new System.Windows.Forms.Button();
            this.btnSearch = new System.Windows.Forms.Button();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.lblSearch = new System.Windows.Forms.Label();
            this.lvCustomerList = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.gboCustomerInfo.SuspendLayout();
            this.gboCustomerEdit.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(138, 158);
            this.btnSave.Margin = new System.Windows.Forms.Padding(2);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(67, 23);
            this.btnSave.TabIndex = 11;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(209, 158);
            this.btnCancel.Margin = new System.Windows.Forms.Padding(2);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(67, 23);
            this.btnCancel.TabIndex = 12;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // gboCustomerInfo
            // 
            this.gboCustomerInfo.Controls.Add(this.lblCustomerAddress);
            this.gboCustomerInfo.Controls.Add(this.lblCustomerEmail);
            this.gboCustomerInfo.Controls.Add(this.btnCancel);
            this.gboCustomerInfo.Controls.Add(this.lblCustomerPhone);
            this.gboCustomerInfo.Controls.Add(this.btnSave);
            this.gboCustomerInfo.Controls.Add(this.lblCustomerLastName);
            this.gboCustomerInfo.Controls.Add(this.lblCustomerFirstName);
            this.gboCustomerInfo.Controls.Add(this.txtAddress);
            this.gboCustomerInfo.Controls.Add(this.txtEmail);
            this.gboCustomerInfo.Controls.Add(this.txtPhone);
            this.gboCustomerInfo.Controls.Add(this.txtLastName);
            this.gboCustomerInfo.Controls.Add(this.txtFirstName);
            this.gboCustomerInfo.Location = new System.Drawing.Point(8, 8);
            this.gboCustomerInfo.Margin = new System.Windows.Forms.Padding(2);
            this.gboCustomerInfo.Name = "gboCustomerInfo";
            this.gboCustomerInfo.Padding = new System.Windows.Forms.Padding(2);
            this.gboCustomerInfo.Size = new System.Drawing.Size(441, 203);
            this.gboCustomerInfo.TabIndex = 13;
            this.gboCustomerInfo.TabStop = false;
            this.gboCustomerInfo.Text = "Customer Info";
            // 
            // lblCustomerAddress
            // 
            this.lblCustomerAddress.AutoSize = true;
            this.lblCustomerAddress.Location = new System.Drawing.Point(28, 122);
            this.lblCustomerAddress.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblCustomerAddress.Name = "lblCustomerAddress";
            this.lblCustomerAddress.Size = new System.Drawing.Size(48, 13);
            this.lblCustomerAddress.TabIndex = 20;
            this.lblCustomerAddress.Text = "Address:";
            // 
            // lblCustomerEmail
            // 
            this.lblCustomerEmail.AutoSize = true;
            this.lblCustomerEmail.Location = new System.Drawing.Point(41, 97);
            this.lblCustomerEmail.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblCustomerEmail.Name = "lblCustomerEmail";
            this.lblCustomerEmail.Size = new System.Drawing.Size(35, 13);
            this.lblCustomerEmail.TabIndex = 19;
            this.lblCustomerEmail.Text = "Email:";
            // 
            // lblCustomerPhone
            // 
            this.lblCustomerPhone.AutoSize = true;
            this.lblCustomerPhone.Location = new System.Drawing.Point(37, 74);
            this.lblCustomerPhone.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblCustomerPhone.Name = "lblCustomerPhone";
            this.lblCustomerPhone.Size = new System.Drawing.Size(41, 13);
            this.lblCustomerPhone.TabIndex = 18;
            this.lblCustomerPhone.Text = "Phone:";
            // 
            // lblCustomerLastName
            // 
            this.lblCustomerLastName.AutoSize = true;
            this.lblCustomerLastName.Location = new System.Drawing.Point(20, 53);
            this.lblCustomerLastName.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblCustomerLastName.Name = "lblCustomerLastName";
            this.lblCustomerLastName.Size = new System.Drawing.Size(61, 13);
            this.lblCustomerLastName.TabIndex = 17;
            this.lblCustomerLastName.Text = "Last Name:";
            // 
            // lblCustomerFirstName
            // 
            this.lblCustomerFirstName.AutoSize = true;
            this.lblCustomerFirstName.Location = new System.Drawing.Point(20, 30);
            this.lblCustomerFirstName.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblCustomerFirstName.Name = "lblCustomerFirstName";
            this.lblCustomerFirstName.Size = new System.Drawing.Size(60, 13);
            this.lblCustomerFirstName.TabIndex = 16;
            this.lblCustomerFirstName.Text = "First Name:";
            // 
            // txtAddress
            // 
            this.txtAddress.Location = new System.Drawing.Point(80, 120);
            this.txtAddress.Margin = new System.Windows.Forms.Padding(2);
            this.txtAddress.Multiline = true;
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.Size = new System.Drawing.Size(171, 18);
            this.txtAddress.TabIndex = 15;
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(80, 97);
            this.txtEmail.Margin = new System.Windows.Forms.Padding(2);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(171, 20);
            this.txtEmail.TabIndex = 14;
            // 
            // txtPhone
            // 
            this.txtPhone.Location = new System.Drawing.Point(80, 74);
            this.txtPhone.Margin = new System.Windows.Forms.Padding(2);
            this.txtPhone.Name = "txtPhone";
            this.txtPhone.Size = new System.Drawing.Size(168, 20);
            this.txtPhone.TabIndex = 13;
            // 
            // txtLastName
            // 
            this.txtLastName.Location = new System.Drawing.Point(80, 51);
            this.txtLastName.Margin = new System.Windows.Forms.Padding(2);
            this.txtLastName.Name = "txtLastName";
            this.txtLastName.Size = new System.Drawing.Size(168, 20);
            this.txtLastName.TabIndex = 12;
            // 
            // txtFirstName
            // 
            this.txtFirstName.Location = new System.Drawing.Point(80, 29);
            this.txtFirstName.Margin = new System.Windows.Forms.Padding(2);
            this.txtFirstName.Name = "txtFirstName";
            this.txtFirstName.Size = new System.Drawing.Size(168, 20);
            this.txtFirstName.TabIndex = 11;
            // 
            // gboCustomerEdit
            // 
            this.gboCustomerEdit.Controls.Add(this.lvCustomerList);
            this.gboCustomerEdit.Controls.Add(this.lblStatus);
            this.gboCustomerEdit.Controls.Add(this.btnDelete);
            this.gboCustomerEdit.Controls.Add(this.btnEdit);
            this.gboCustomerEdit.Controls.Add(this.btnAddNew);
            this.gboCustomerEdit.Controls.Add(this.btnShowAll);
            this.gboCustomerEdit.Controls.Add(this.btnSearch);
            this.gboCustomerEdit.Controls.Add(this.txtSearch);
            this.gboCustomerEdit.Controls.Add(this.lblSearch);
            this.gboCustomerEdit.Location = new System.Drawing.Point(8, 216);
            this.gboCustomerEdit.Name = "gboCustomerEdit";
            this.gboCustomerEdit.Size = new System.Drawing.Size(441, 285);
            this.gboCustomerEdit.TabIndex = 14;
            this.gboCustomerEdit.TabStop = false;
            this.gboCustomerEdit.Text = "Customer Edit";
            // 
            // lblStatus
            // 
            this.lblStatus.AutoSize = true;
            this.lblStatus.Location = new System.Drawing.Point(331, 56);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(67, 13);
            this.lblStatus.TabIndex = 9;
            this.lblStatus.Text = "[Status Text]";
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(268, 249);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(94, 23);
            this.btnDelete.TabIndex = 7;
            this.btnDelete.Text = "Delete Selected";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnEdit
            // 
            this.btnEdit.Location = new System.Drawing.Point(165, 249);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(86, 23);
            this.btnEdit.TabIndex = 6;
            this.btnEdit.Text = "Edit Selected";
            this.btnEdit.UseVisualStyleBackColor = true;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // btnAddNew
            // 
            this.btnAddNew.Location = new System.Drawing.Point(70, 249);
            this.btnAddNew.Name = "btnAddNew";
            this.btnAddNew.Size = new System.Drawing.Size(75, 23);
            this.btnAddNew.TabIndex = 5;
            this.btnAddNew.Text = "Add New";
            this.btnAddNew.UseVisualStyleBackColor = true;
            this.btnAddNew.Click += new System.EventHandler(this.btnAddNew_Click);
            // 
            // btnShowAll
            // 
            this.btnShowAll.Location = new System.Drawing.Point(323, 30);
            this.btnShowAll.Name = "btnShowAll";
            this.btnShowAll.Size = new System.Drawing.Size(75, 23);
            this.btnShowAll.TabIndex = 3;
            this.btnShowAll.Text = "Show All";
            this.btnShowAll.UseVisualStyleBackColor = true;
            this.btnShowAll.Click += new System.EventHandler(this.btnShowAll_Click);
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(176, 27);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(75, 23);
            this.btnSearch.TabIndex = 2;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // txtSearch
            // 
            this.txtSearch.Location = new System.Drawing.Point(70, 27);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(100, 20);
            this.txtSearch.TabIndex = 1;
            // 
            // lblSearch
            // 
            this.lblSearch.AutoSize = true;
            this.lblSearch.Location = new System.Drawing.Point(20, 30);
            this.lblSearch.Name = "lblSearch";
            this.lblSearch.Size = new System.Drawing.Size(44, 13);
            this.lblSearch.TabIndex = 0;
            this.lblSearch.Text = "Search:";
            // 
            // lvCustomerList
            // 
            this.lvCustomerList.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader5});
            this.lvCustomerList.FullRowSelect = true;
            this.lvCustomerList.GridLines = true;
            this.lvCustomerList.HideSelection = false;
            this.lvCustomerList.Location = new System.Drawing.Point(23, 72);
            this.lvCustomerList.MultiSelect = false;
            this.lvCustomerList.Name = "lvCustomerList";
            this.lvCustomerList.Size = new System.Drawing.Size(375, 171);
            this.lvCustomerList.TabIndex = 10;
            this.lvCustomerList.UseCompatibleStateImageBehavior = false;
            this.lvCustomerList.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Name";
            this.columnHeader1.Width = 100;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Phone";
            this.columnHeader2.Width = 100;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Email";
            this.columnHeader3.Width = 100;
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "Address";
            this.columnHeader5.Width = 100;
            // 
            // frmCustomer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(461, 522);
            this.Controls.Add(this.gboCustomerEdit);
            this.Controls.Add(this.gboCustomerInfo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmCustomer";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Mechanic Shop - ADD/EDIT Customer";
            this.gboCustomerInfo.ResumeLayout(false);
            this.gboCustomerInfo.PerformLayout();
            this.gboCustomerEdit.ResumeLayout(false);
            this.gboCustomerEdit.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.GroupBox gboCustomerInfo;
        private System.Windows.Forms.Label lblCustomerAddress;
        private System.Windows.Forms.Label lblCustomerEmail;
        private System.Windows.Forms.Label lblCustomerPhone;
        private System.Windows.Forms.Label lblCustomerLastName;
        private System.Windows.Forms.Label lblCustomerFirstName;
        private System.Windows.Forms.TextBox txtAddress;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.TextBox txtPhone;
        private System.Windows.Forms.TextBox txtLastName;
        private System.Windows.Forms.TextBox txtFirstName;
        private System.Windows.Forms.GroupBox gboCustomerEdit;
        private System.Windows.Forms.Button btnShowAll;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Label lblSearch;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Button btnAddNew;
        private System.Windows.Forms.Label lblStatus;
        private System.Windows.Forms.ListView lvCustomerList;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader5;
    }
}