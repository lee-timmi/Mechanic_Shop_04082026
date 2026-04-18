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
            this.columnHeader1 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader2 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader3 = new System.Windows.Forms.ColumnHeader();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnEdit = new System.Windows.Forms.Button();
            this.btnAddNew = new System.Windows.Forms.Button();
            this.btnShowAll = new System.Windows.Forms.Button();
            this.btnSearch = new System.Windows.Forms.Button();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.lblSearch = new System.Windows.Forms.Label();

            this.gboMechanicInfo.SuspendLayout();
            this.gboMechanicEdit.SuspendLayout();
            this.SuspendLayout();

            // Title
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.lblTitle.Location = new System.Drawing.Point(230, 10);
            this.lblTitle.Text = "Mechanic Management Form";

            // Top GroupBox
            this.gboMechanicInfo.Controls.Add(this.btnCancel);
            this.gboMechanicInfo.Controls.Add(this.btnSave);
            this.gboMechanicInfo.Controls.Add(this.txtHourlyRate);
            this.gboMechanicInfo.Controls.Add(this.lblHourlyRate);
            this.gboMechanicInfo.Controls.Add(this.txtLastName);
            this.gboMechanicInfo.Controls.Add(this.lblLastName);
            this.gboMechanicInfo.Controls.Add(this.txtFirstName);
            this.gboMechanicInfo.Controls.Add(this.lblFirstName);
            this.gboMechanicInfo.Location = new System.Drawing.Point(50, 60);
            this.gboMechanicInfo.Size = new System.Drawing.Size(760, 220);
            this.gboMechanicInfo.Text = "Mechanic Information";

            // Labels + Textboxes
            this.lblFirstName.Location = new System.Drawing.Point(10, 30);
            this.lblFirstName.Text = "First Name:";
            this.txtFirstName.Location = new System.Drawing.Point(120, 30);
            this.txtFirstName.Size = new System.Drawing.Size(500, 26);

            this.lblLastName.Location = new System.Drawing.Point(10, 70);
            this.lblLastName.Text = "Last Name:";
            this.txtLastName.Location = new System.Drawing.Point(120, 70);
            this.txtLastName.Size = new System.Drawing.Size(500, 26);

            this.lblHourlyRate.Location = new System.Drawing.Point(10, 110);
            this.lblHourlyRate.Text = "Hourly Rate:";
            this.txtHourlyRate.Location = new System.Drawing.Point(120, 110);
            this.txtHourlyRate.Size = new System.Drawing.Size(500, 26);

            // Buttons
            this.btnSave.Location = new System.Drawing.Point(220, 170);
            this.btnSave.Text = "Save";
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);

            this.btnCancel.Location = new System.Drawing.Point(400, 170);
            this.btnCancel.Text = "Cancel";
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);

            // Bottom GroupBox
            this.gboMechanicEdit.Controls.Add(this.lvMechanicList);
            this.gboMechanicEdit.Controls.Add(this.btnDelete);
            this.gboMechanicEdit.Controls.Add(this.btnEdit);
            this.gboMechanicEdit.Controls.Add(this.btnAddNew);
            this.gboMechanicEdit.Controls.Add(this.btnShowAll);
            this.gboMechanicEdit.Controls.Add(this.btnSearch);
            this.gboMechanicEdit.Controls.Add(this.txtSearch);
            this.gboMechanicEdit.Controls.Add(this.lblSearch);
            this.gboMechanicEdit.Location = new System.Drawing.Point(50, 300);
            this.gboMechanicEdit.Size = new System.Drawing.Size(760, 420);
            this.gboMechanicEdit.Text = "Search / Edit Mechanics";

            // Search
            this.lblSearch.Location = new System.Drawing.Point(10, 40);
            this.lblSearch.Text = "Search:";
            this.txtSearch.Location = new System.Drawing.Point(80, 40);
            this.txtSearch.Size = new System.Drawing.Size(300, 26);

            this.btnSearch.Location = new System.Drawing.Point(400, 40);
            this.btnSearch.Text = "Search";
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);

            this.btnShowAll.Location = new System.Drawing.Point(500, 40);
            this.btnShowAll.Text = "Show All";
            this.btnShowAll.Click += new System.EventHandler(this.btnShowAll_Click);

            // Action buttons
            this.btnAddNew.Location = new System.Drawing.Point(100, 90);
            this.btnAddNew.Text = "Add New";
            this.btnAddNew.Click += new System.EventHandler(this.btnAddNew_Click);

            this.btnEdit.Location = new System.Drawing.Point(280, 90);
            this.btnEdit.Text = "Edit";
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);

            this.btnDelete.Location = new System.Drawing.Point(460, 90);
            this.btnDelete.Text = "Delete";
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);

            // ListView
            this.lvMechanicList.Location = new System.Drawing.Point(50, 140);
            this.lvMechanicList.Size = new System.Drawing.Size(650, 220);
            this.lvMechanicList.View = System.Windows.Forms.View.Details;
            this.lvMechanicList.FullRowSelect = true;
            this.lvMechanicList.GridLines = true;
            this.lvMechanicList.Columns.AddRange(new System.Windows.Forms.ColumnHeader[]
            {
                this.columnHeader1,
                this.columnHeader2,
                this.columnHeader3
            });
            this.lvMechanicList.SelectedIndexChanged += new System.EventHandler(this.lvMechanicList_SelectedIndexChanged);

            // Columns
            this.columnHeader1.Text = "First Name";
            this.columnHeader1.Width = 180;

            this.columnHeader2.Text = "Last Name";
            this.columnHeader2.Width = 180;

            this.columnHeader3.Text = "Hourly Rate";
            this.columnHeader3.Width = 120;

            // Form
            this.ClientSize = new System.Drawing.Size(880, 750);
            this.Controls.Add(this.gboMechanicEdit);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.gboMechanicInfo);
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
    }
}