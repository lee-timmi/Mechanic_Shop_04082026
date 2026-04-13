namespace MechanicShop
{
    partial class frmMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
            this.btnLogOut = new System.Windows.Forms.Button();
            this.pboLogo = new System.Windows.Forms.PictureBox();
            this.lblLogInState = new System.Windows.Forms.Label();
            this.gboOptions = new System.Windows.Forms.GroupBox();
            this.btnAdmin = new System.Windows.Forms.Button();
            this.btnReports = new System.Windows.Forms.Button();
            this.btnMechanics = new System.Windows.Forms.Button();
            this.btnRepairOrders = new System.Windows.Forms.Button();
            this.btnVehicles = new System.Windows.Forms.Button();
            this.btnCustomers = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pboLogo)).BeginInit();
            this.gboOptions.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnLogOut
            // 
            this.btnLogOut.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(62)))), ((int)(((byte)(80)))));
            this.btnLogOut.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(152)))), ((int)(((byte)(219)))));
            this.btnLogOut.Location = new System.Drawing.Point(398, 280);
            this.btnLogOut.Margin = new System.Windows.Forms.Padding(2);
            this.btnLogOut.Name = "btnLogOut";
            this.btnLogOut.Size = new System.Drawing.Size(80, 28);
            this.btnLogOut.TabIndex = 6;
            this.btnLogOut.Text = "Log Out";
            this.btnLogOut.UseVisualStyleBackColor = false;
            this.btnLogOut.Click += new System.EventHandler(this.btnLogOut_Click);
            // 
            // pboLogo
            // 
            this.pboLogo.BackColor = System.Drawing.Color.Transparent;
            this.pboLogo.BackgroundImage = global::MechanicShop.Properties.Resources.mechanicLogo;
            this.pboLogo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pboLogo.ErrorImage = null;
            this.pboLogo.Location = new System.Drawing.Point(124, 8);
            this.pboLogo.Margin = new System.Windows.Forms.Padding(2);
            this.pboLogo.Name = "pboLogo";
            this.pboLogo.Size = new System.Drawing.Size(260, 110);
            this.pboLogo.TabIndex = 7;
            this.pboLogo.TabStop = false;
            // 
            // lblLogInState
            // 
            this.lblLogInState.AutoSize = true;
            this.lblLogInState.BackColor = System.Drawing.Color.Transparent;
            this.lblLogInState.Location = new System.Drawing.Point(39, 288);
            this.lblLogInState.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblLogInState.Name = "lblLogInState";
            this.lblLogInState.Size = new System.Drawing.Size(57, 13);
            this.lblLogInState.TabIndex = 8;
            this.lblLogInState.Text = "Logged in:";
            // 
            // gboOptions
            // 
            this.gboOptions.BackColor = System.Drawing.Color.Transparent;
            this.gboOptions.Controls.Add(this.btnAdmin);
            this.gboOptions.Controls.Add(this.btnReports);
            this.gboOptions.Controls.Add(this.btnMechanics);
            this.gboOptions.Controls.Add(this.btnRepairOrders);
            this.gboOptions.Controls.Add(this.btnVehicles);
            this.gboOptions.Controls.Add(this.btnCustomers);
            this.gboOptions.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gboOptions.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(152)))), ((int)(((byte)(219)))));
            this.gboOptions.Location = new System.Drawing.Point(42, 122);
            this.gboOptions.Margin = new System.Windows.Forms.Padding(2);
            this.gboOptions.Name = "gboOptions";
            this.gboOptions.Padding = new System.Windows.Forms.Padding(2);
            this.gboOptions.Size = new System.Drawing.Size(423, 150);
            this.gboOptions.TabIndex = 9;
            this.gboOptions.TabStop = false;
            this.gboOptions.Text = "Options";
            // 
            // btnAdmin
            // 
            this.btnAdmin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(62)))), ((int)(((byte)(80)))));
            this.btnAdmin.Location = new System.Drawing.Point(291, 86);
            this.btnAdmin.Margin = new System.Windows.Forms.Padding(2);
            this.btnAdmin.Name = "btnAdmin";
            this.btnAdmin.Size = new System.Drawing.Size(120, 52);
            this.btnAdmin.TabIndex = 11;
            this.btnAdmin.Text = "Admin";
            this.btnAdmin.UseVisualStyleBackColor = false;
            this.btnAdmin.Click += new System.EventHandler(this.btnAdmin_Click);
            // 
            // btnReports
            // 
            this.btnReports.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(62)))), ((int)(((byte)(80)))));
            this.btnReports.Location = new System.Drawing.Point(146, 86);
            this.btnReports.Margin = new System.Windows.Forms.Padding(2);
            this.btnReports.Name = "btnReports";
            this.btnReports.Size = new System.Drawing.Size(120, 52);
            this.btnReports.TabIndex = 10;
            this.btnReports.Text = "Reports";
            this.btnReports.UseVisualStyleBackColor = false;
            this.btnReports.Click += new System.EventHandler(this.btnReports_Click);
            // 
            // btnMechanics
            // 
            this.btnMechanics.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(62)))), ((int)(((byte)(80)))));
            this.btnMechanics.Location = new System.Drawing.Point(8, 86);
            this.btnMechanics.Margin = new System.Windows.Forms.Padding(2);
            this.btnMechanics.Name = "btnMechanics";
            this.btnMechanics.Size = new System.Drawing.Size(120, 52);
            this.btnMechanics.TabIndex = 9;
            this.btnMechanics.Text = "Mechanics";
            this.btnMechanics.UseVisualStyleBackColor = false;
            this.btnMechanics.Click += new System.EventHandler(this.btnMechanics_Click);
            // 
            // btnRepairOrders
            // 
            this.btnRepairOrders.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(62)))), ((int)(((byte)(80)))));
            this.btnRepairOrders.Location = new System.Drawing.Point(291, 16);
            this.btnRepairOrders.Margin = new System.Windows.Forms.Padding(2);
            this.btnRepairOrders.Name = "btnRepairOrders";
            this.btnRepairOrders.Size = new System.Drawing.Size(120, 52);
            this.btnRepairOrders.TabIndex = 8;
            this.btnRepairOrders.Text = "Repair Orders";
            this.btnRepairOrders.UseVisualStyleBackColor = false;
            this.btnRepairOrders.Click += new System.EventHandler(this.btnRepairOrders_Click);
            // 
            // btnVehicles
            // 
            this.btnVehicles.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(62)))), ((int)(((byte)(80)))));
            this.btnVehicles.Location = new System.Drawing.Point(146, 16);
            this.btnVehicles.Margin = new System.Windows.Forms.Padding(2);
            this.btnVehicles.Name = "btnVehicles";
            this.btnVehicles.Size = new System.Drawing.Size(120, 52);
            this.btnVehicles.TabIndex = 7;
            this.btnVehicles.Text = "Vehicles";
            this.btnVehicles.UseVisualStyleBackColor = false;
            this.btnVehicles.Click += new System.EventHandler(this.btnVehicles_Click);
            // 
            // btnCustomers
            // 
            this.btnCustomers.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(62)))), ((int)(((byte)(80)))));
            this.btnCustomers.Location = new System.Drawing.Point(8, 16);
            this.btnCustomers.Margin = new System.Windows.Forms.Padding(2);
            this.btnCustomers.Name = "btnCustomers";
            this.btnCustomers.Size = new System.Drawing.Size(120, 52);
            this.btnCustomers.TabIndex = 6;
            this.btnCustomers.Text = "Customers";
            this.btnCustomers.UseVisualStyleBackColor = false;
            this.btnCustomers.Click += new System.EventHandler(this.btnCustomers_Click);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.BackgroundImage = global::MechanicShop.Properties.Resources.mechanicWorkshop;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(511, 319);
            this.Controls.Add(this.gboOptions);
            this.Controls.Add(this.lblLogInState);
            this.Controls.Add(this.pboLogo);
            this.Controls.Add(this.btnLogOut);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MaximizeBox = false;
            this.Name = "frmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MECHANIC SHOP MANAGEMENT SYSTEM";
            this.Load += new System.EventHandler(this.frmMain_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pboLogo)).EndInit();
            this.gboOptions.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnLogOut;
        private System.Windows.Forms.PictureBox pboLogo;
        private System.Windows.Forms.Label lblLogInState;
        private System.Windows.Forms.GroupBox gboOptions;
        private System.Windows.Forms.Button btnAdmin;
        private System.Windows.Forms.Button btnReports;
        private System.Windows.Forms.Button btnMechanics;
        private System.Windows.Forms.Button btnRepairOrders;
        private System.Windows.Forms.Button btnVehicles;
        private System.Windows.Forms.Button btnCustomers;
    }
}

