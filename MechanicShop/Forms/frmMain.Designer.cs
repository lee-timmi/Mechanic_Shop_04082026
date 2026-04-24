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
            this.lblLogInState = new System.Windows.Forms.Label();
            this.gboOptions = new System.Windows.Forms.GroupBox();
            this.btnAuditLog = new System.Windows.Forms.Button();
            this.btnRepairHistory = new System.Windows.Forms.Button();
            this.btnMechanics = new System.Windows.Forms.Button();
            this.btnRepairOrders = new System.Windows.Forms.Button();
            this.btnVehicles = new System.Windows.Forms.Button();
            this.btnCustomers = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.gboOptions.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnLogOut
            // 
            this.btnLogOut.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(198)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.btnLogOut.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLogOut.FlatAppearance.BorderSize = 0;
            this.btnLogOut.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLogOut.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold);
            this.btnLogOut.ForeColor = System.Drawing.Color.White;
            this.btnLogOut.Location = new System.Drawing.Point(398, 280);
            this.btnLogOut.Margin = new System.Windows.Forms.Padding(2);
            this.btnLogOut.Name = "btnLogOut";
            this.btnLogOut.Size = new System.Drawing.Size(80, 28);
            this.btnLogOut.TabIndex = 6;
            this.btnLogOut.Text = "Log Out";
            this.btnLogOut.UseVisualStyleBackColor = false;
            this.btnLogOut.Click += new System.EventHandler(this.btnLogOut_Click);
            // 
            // lblLogInState
            // 
            this.lblLogInState.AutoSize = true;
            this.lblLogInState.BackColor = System.Drawing.Color.Transparent;
            this.lblLogInState.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLogInState.ForeColor = System.Drawing.Color.White;
            this.lblLogInState.Location = new System.Drawing.Point(39, 288);
            this.lblLogInState.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblLogInState.Name = "lblLogInState";
            this.lblLogInState.Size = new System.Drawing.Size(67, 13);
            this.lblLogInState.TabIndex = 8;
            this.lblLogInState.Text = "Logged in:";
            // 
            // gboOptions
            // 
            this.gboOptions.BackColor = System.Drawing.Color.Transparent;
            this.gboOptions.Controls.Add(this.btnAuditLog);
            this.gboOptions.Controls.Add(this.btnRepairHistory);
            this.gboOptions.Controls.Add(this.btnMechanics);
            this.gboOptions.Controls.Add(this.btnRepairOrders);
            this.gboOptions.Controls.Add(this.btnVehicles);
            this.gboOptions.Controls.Add(this.btnCustomers);
            this.gboOptions.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gboOptions.ForeColor = System.Drawing.Color.White;
            this.gboOptions.Location = new System.Drawing.Point(42, 122);
            this.gboOptions.Margin = new System.Windows.Forms.Padding(2);
            this.gboOptions.Name = "gboOptions";
            this.gboOptions.Padding = new System.Windows.Forms.Padding(2);
            this.gboOptions.Size = new System.Drawing.Size(423, 150);
            this.gboOptions.TabIndex = 9;
            this.gboOptions.TabStop = false;
            this.gboOptions.Text = "Options";
            // 
            // btnAuditLog
            // 
            this.btnAuditLog.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(62)))), ((int)(((byte)(80)))));
            this.btnAuditLog.Location = new System.Drawing.Point(291, 86);
            this.btnAuditLog.Margin = new System.Windows.Forms.Padding(2);
            this.btnAuditLog.Name = "btnAuditLog";
            this.btnAuditLog.Size = new System.Drawing.Size(120, 52);
            this.btnAuditLog.TabIndex = 11;
            this.btnAuditLog.Text = "Audit Log";
            this.btnAuditLog.UseVisualStyleBackColor = false;
            this.btnAuditLog.Click += new System.EventHandler(this.btnAuditLog_Click);
            // 
            // btnRepairHistory
            // 
            this.btnRepairHistory.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(62)))), ((int)(((byte)(80)))));
            this.btnRepairHistory.Location = new System.Drawing.Point(146, 86);
            this.btnRepairHistory.Margin = new System.Windows.Forms.Padding(2);
            this.btnRepairHistory.Name = "btnRepairHistory";
            this.btnRepairHistory.Size = new System.Drawing.Size(120, 52);
            this.btnRepairHistory.TabIndex = 10;
            this.btnRepairHistory.Text = "Repair History";
            this.btnRepairHistory.UseVisualStyleBackColor = false;
            this.btnRepairHistory.Click += new System.EventHandler(this.btnRepairHistory_Click);
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
            this.btnCustomers.ForeColor = System.Drawing.Color.White;
            this.btnCustomers.Location = new System.Drawing.Point(8, 16);
            this.btnCustomers.Margin = new System.Windows.Forms.Padding(2);
            this.btnCustomers.Name = "btnCustomers";
            this.btnCustomers.Size = new System.Drawing.Size(120, 52);
            this.btnCustomers.TabIndex = 6;
            this.btnCustomers.Text = "Customers";
            this.btnCustomers.UseVisualStyleBackColor = false;
            this.btnCustomers.Click += new System.EventHandler(this.btnCustomers_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(-17, -76);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(537, 279);
            this.pictureBox1.TabIndex = 11;
            this.pictureBox1.TabStop = false;
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
            this.Controls.Add(this.btnLogOut);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MaximizeBox = false;
            this.Name = "frmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MECHANIC SHOP MANAGEMENT SYSTEM";
            this.Load += new System.EventHandler(this.frmMain_Load);
            this.gboOptions.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnLogOut;
        private System.Windows.Forms.Label lblLogInState;
        private System.Windows.Forms.GroupBox gboOptions;
        private System.Windows.Forms.Button btnAuditLog;
        private System.Windows.Forms.Button btnRepairHistory;
        private System.Windows.Forms.Button btnMechanics;
        private System.Windows.Forms.Button btnRepairOrders;
        private System.Windows.Forms.Button btnVehicles;
        private System.Windows.Forms.Button btnCustomers;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

