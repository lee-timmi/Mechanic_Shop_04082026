namespace MechanicShop.Forms
{
    partial class frmMechanic
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.gboMechanicInfo = new System.Windows.Forms.GroupBox();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.txtHourlyRate = new System.Windows.Forms.TextBox();
            this.lblHourlyRate = new System.Windows.Forms.Label();
            this.txtLastName = new System.Windows.Forms.TextBox();
            this.lblLastName = new System.Windows.Forms.Label();
            this.txtFirstName = new System.Windows.Forms.TextBox();
            this.lblFirstName = new System.Windows.Forms.Label();
            this.lblTitle = new System.Windows.Forms.Label();
            this.gboMechanicEdit = new System.Windows.Forms.GroupBox();
            this.lvMechanicList = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnEdit = new System.Windows.Forms.Button();
            this.btnAddNew = new System.Windows.Forms.Button();
            this.btnShowAll = new System.Windows.Forms.Button();
            this.btnSearch = new System.Windows.Forms.Button();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.lblSearch = new System.Windows.Forms.Label();
            this.Specialty = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Phone = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.txtSpecialty = new System.Windows.Forms.TextBox();
            this.lblSpecialty = new System.Windows.Forms.Label();
            this.txtPhone = new System.Windows.Forms.TextBox();
            this.lblPhone = new System.Windows.Forms.Label();
            this.gboMechanicInfo.SuspendLayout();
            this.gboMechanicEdit.SuspendLayout();
            this.SuspendLayout();
            // 
            // gboMechanicInfo
            // 
            this.gboMechanicInfo.Controls.Add(this.txtPhone);
            this.gboMechanicInfo.Controls.Add(this.lblPhone);
            this.gboMechanicInfo.Controls.Add(this.txtSpecialty);
            this.gboMechanicInfo.Controls.Add(this.lblSpecialty);
            this.gboMechanicInfo.Controls.Add(this.btnCancel);
            this.gboMechanicInfo.Controls.Add(this.btnSave);
            this.gboMechanicInfo.Controls.Add(this.txtHourlyRate);
            this.gboMechanicInfo.Controls.Add(this.lblHourlyRate);
            this.gboMechanicInfo.Controls.Add(this.txtLastName);
            this.gboMechanicInfo.Controls.Add(this.lblLastName);
            this.gboMechanicInfo.Controls.Add(this.txtFirstName);
            this.gboMechanicInfo.Controls.Add(this.lblFirstName);
            this.gboMechanicInfo.Location = new System.Drawing.Point(50, 60);
            this.gboMechanicInfo.Name = "gboMechanicInfo";
            this.gboMechanicInfo.Size = new System.Drawing.Size(760, 301);
            this.gboMechanicInfo.TabIndex = 2;
            this.gboMechanicInfo.TabStop = false;
            this.gboMechanicInfo.Text = "Mechanic Information";
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(404, 234);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 0;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(224, 234);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 1;
            this.btnSave.Text = "Save";
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // txtHourlyRate
            // 
            this.txtHourlyRate.Location = new System.Drawing.Point(120, 110);
            this.txtHourlyRate.Name = "txtHourlyRate";
            this.txtHourlyRate.Size = new System.Drawing.Size(500, 20);
            this.txtHourlyRate.TabIndex = 2;
            // 
            // lblHourlyRate
            // 
            this.lblHourlyRate.Location = new System.Drawing.Point(10, 110);
            this.lblHourlyRate.Name = "lblHourlyRate";
            this.lblHourlyRate.Size = new System.Drawing.Size(100, 23);
            this.lblHourlyRate.TabIndex = 3;
            this.lblHourlyRate.Text = "Hourly Rate:";
            // 
            // txtLastName
            // 
            this.txtLastName.Location = new System.Drawing.Point(120, 70);
            this.txtLastName.Name = "txtLastName";
            this.txtLastName.Size = new System.Drawing.Size(500, 20);
            this.txtLastName.TabIndex = 4;
            // 
            // lblLastName
            // 
            this.lblLastName.Location = new System.Drawing.Point(10, 70);
            this.lblLastName.Name = "lblLastName";
            this.lblLastName.Size = new System.Drawing.Size(100, 23);
            this.lblLastName.TabIndex = 5;
            this.lblLastName.Text = "Last Name:";
            // 
            // txtFirstName
            // 
            this.txtFirstName.Location = new System.Drawing.Point(120, 30);
            this.txtFirstName.Name = "txtFirstName";
            this.txtFirstName.Size = new System.Drawing.Size(500, 20);
            this.txtFirstName.TabIndex = 6;
            // 
            // lblFirstName
            // 
            this.lblFirstName.Location = new System.Drawing.Point(10, 30);
            this.lblFirstName.Name = "lblFirstName";
            this.lblFirstName.Size = new System.Drawing.Size(100, 23);
            this.lblFirstName.TabIndex = 7;
            this.lblFirstName.Text = "First Name:";
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.lblTitle.Location = new System.Drawing.Point(230, 10);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(240, 20);
            this.lblTitle.TabIndex = 1;
            this.lblTitle.Text = "Mechanic Management Form";
            // 
            // gboMechanicEdit
            // 
            this.gboMechanicEdit.Controls.Add(this.lvMechanicList);
            this.gboMechanicEdit.Controls.Add(this.btnDelete);
            this.gboMechanicEdit.Controls.Add(this.btnEdit);
            this.gboMechanicEdit.Controls.Add(this.btnAddNew);
            this.gboMechanicEdit.Controls.Add(this.btnShowAll);
            this.gboMechanicEdit.Controls.Add(this.btnSearch);
            this.gboMechanicEdit.Controls.Add(this.txtSearch);
            this.gboMechanicEdit.Controls.Add(this.lblSearch);
            this.gboMechanicEdit.Location = new System.Drawing.Point(50, 367);
            this.gboMechanicEdit.Name = "gboMechanicEdit";
            this.gboMechanicEdit.Size = new System.Drawing.Size(760, 371);
            this.gboMechanicEdit.TabIndex = 0;
            this.gboMechanicEdit.TabStop = false;
            this.gboMechanicEdit.Text = "Search / Edit Mechanics";
            // 
            // lvMechanicList
            // 
            this.lvMechanicList.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.Specialty,
            this.Phone});
            this.lvMechanicList.FullRowSelect = true;
            this.lvMechanicList.GridLines = true;
            this.lvMechanicList.HideSelection = false;
            this.lvMechanicList.Location = new System.Drawing.Point(40, 130);
            this.lvMechanicList.Name = "lvMechanicList";
            this.lvMechanicList.Size = new System.Drawing.Size(704, 220);
            this.lvMechanicList.TabIndex = 0;
            this.lvMechanicList.UseCompatibleStateImageBehavior = false;
            this.lvMechanicList.View = System.Windows.Forms.View.Details;
            this.lvMechanicList.SelectedIndexChanged += new System.EventHandler(this.lvMechanicList_SelectedIndexChanged);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "First Name";
            this.columnHeader1.Width = 180;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Last Name";
            this.columnHeader2.Width = 180;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Hourly Rate";
            this.columnHeader3.Width = 120;
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(471, 78);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(75, 23);
            this.btnDelete.TabIndex = 1;
            this.btnDelete.Text = "Delete";
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnEdit
            // 
            this.btnEdit.Location = new System.Drawing.Point(291, 78);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(75, 23);
            this.btnEdit.TabIndex = 2;
            this.btnEdit.Text = "Edit";
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // btnAddNew
            // 
            this.btnAddNew.Location = new System.Drawing.Point(111, 78);
            this.btnAddNew.Name = "btnAddNew";
            this.btnAddNew.Size = new System.Drawing.Size(75, 23);
            this.btnAddNew.TabIndex = 3;
            this.btnAddNew.Text = "Add New";
            this.btnAddNew.Click += new System.EventHandler(this.btnAddNew_Click);
            // 
            // btnShowAll
            // 
            this.btnShowAll.Location = new System.Drawing.Point(511, 28);
            this.btnShowAll.Name = "btnShowAll";
            this.btnShowAll.Size = new System.Drawing.Size(75, 23);
            this.btnShowAll.TabIndex = 4;
            this.btnShowAll.Text = "Show All";
            this.btnShowAll.Click += new System.EventHandler(this.btnShowAll_Click);
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(411, 28);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(75, 23);
            this.btnSearch.TabIndex = 5;
            this.btnSearch.Text = "Search";
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // txtSearch
            // 
            this.txtSearch.Location = new System.Drawing.Point(91, 28);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(300, 20);
            this.txtSearch.TabIndex = 6;
            // 
            // lblSearch
            // 
            this.lblSearch.Location = new System.Drawing.Point(21, 28);
            this.lblSearch.Name = "lblSearch";
            this.lblSearch.Size = new System.Drawing.Size(100, 23);
            this.lblSearch.TabIndex = 7;
            this.lblSearch.Text = "Search:";
            // 
            // Specialty
            // 
            this.Specialty.Text = "Specialty";
            this.Specialty.Width = 120;
            // 
            // Phone
            // 
            this.Phone.Text = "Phone";
            this.Phone.Width = 100;
            // 
            // txtSpecialty
            // 
            this.txtSpecialty.Location = new System.Drawing.Point(120, 152);
            this.txtSpecialty.Name = "txtSpecialty";
            this.txtSpecialty.Size = new System.Drawing.Size(500, 20);
            this.txtSpecialty.TabIndex = 8;
            // 
            // lblSpecialty
            // 
            this.lblSpecialty.Location = new System.Drawing.Point(10, 152);
            this.lblSpecialty.Name = "lblSpecialty";
            this.lblSpecialty.Size = new System.Drawing.Size(100, 23);
            this.lblSpecialty.TabIndex = 9;
            this.lblSpecialty.Text = "Specialty:";
            // 
            // txtPhone
            // 
            this.txtPhone.Location = new System.Drawing.Point(120, 193);
            this.txtPhone.Name = "txtPhone";
            this.txtPhone.Size = new System.Drawing.Size(500, 20);
            this.txtPhone.TabIndex = 10;
            // 
            // lblPhone
            // 
            this.lblPhone.Location = new System.Drawing.Point(10, 193);
            this.lblPhone.Name = "lblPhone";
            this.lblPhone.Size = new System.Drawing.Size(100, 23);
            this.lblPhone.TabIndex = 11;
            this.lblPhone.Text = "Phone:";
            // 
            // frmMechanic
            // 
            this.ClientSize = new System.Drawing.Size(880, 750);
            this.Controls.Add(this.gboMechanicEdit);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.gboMechanicInfo);
            this.Name = "frmMechanic";
            this.Text = "Mechanic Management";
            this.Load += new System.EventHandler(this.frmMechanic_Load);
            this.gboMechanicInfo.ResumeLayout(false);
            this.gboMechanicInfo.PerformLayout();
            this.gboMechanicEdit.ResumeLayout(false);
            this.gboMechanicEdit.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private System.Windows.Forms.GroupBox gboMechanicInfo;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.TextBox txtHourlyRate;
        private System.Windows.Forms.Label lblHourlyRate;
        private System.Windows.Forms.TextBox txtLastName;
        private System.Windows.Forms.Label lblLastName;
        private System.Windows.Forms.TextBox txtFirstName;
        private System.Windows.Forms.Label lblFirstName;
        private System.Windows.Forms.Label lblTitle;

        private System.Windows.Forms.GroupBox gboMechanicEdit;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Label lblSearch;
        private System.Windows.Forms.Button btnShowAll;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Button btnAddNew;
        private System.Windows.Forms.ListView lvMechanicList;

        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader Specialty;
        private System.Windows.Forms.ColumnHeader Phone;
        private System.Windows.Forms.TextBox txtPhone;
        private System.Windows.Forms.Label lblPhone;
        private System.Windows.Forms.TextBox txtSpecialty;
        private System.Windows.Forms.Label lblSpecialty;
    }
}