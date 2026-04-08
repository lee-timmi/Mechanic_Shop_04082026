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
            this.lboMakes = new System.Windows.Forms.ListBox();
            this.btnLoadMakes = new System.Windows.Forms.Button();
            this.lblStatus = new System.Windows.Forms.Label();
            this.lblAvailableMakes = new System.Windows.Forms.Label();
            this.cboSelection = new System.Windows.Forms.ComboBox();
            this.lblMakeSelection = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lboMakes
            // 
            this.lboMakes.FormattingEnabled = true;
            this.lboMakes.ItemHeight = 20;
            this.lboMakes.Location = new System.Drawing.Point(59, 175);
            this.lboMakes.Name = "lboMakes";
            this.lboMakes.Size = new System.Drawing.Size(443, 224);
            this.lboMakes.TabIndex = 0;
            // 
            // btnLoadMakes
            // 
            this.btnLoadMakes.Location = new System.Drawing.Point(337, 52);
            this.btnLoadMakes.Name = "btnLoadMakes";
            this.btnLoadMakes.Size = new System.Drawing.Size(165, 45);
            this.btnLoadMakes.TabIndex = 1;
            this.btnLoadMakes.Text = "Load Makes";
            this.btnLoadMakes.UseVisualStyleBackColor = true;
            this.btnLoadMakes.Click += new System.EventHandler(this.btnLoadMakes_Click);
            // 
            // lblStatus
            // 
            this.lblStatus.AutoSize = true;
            this.lblStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStatus.Location = new System.Drawing.Point(54, 412);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(79, 29);
            this.lblStatus.TabIndex = 2;
            this.lblStatus.Text = "Status";
            // 
            // lblAvailableMakes
            // 
            this.lblAvailableMakes.AutoSize = true;
            this.lblAvailableMakes.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAvailableMakes.Location = new System.Drawing.Point(54, 143);
            this.lblAvailableMakes.Name = "lblAvailableMakes";
            this.lblAvailableMakes.Size = new System.Drawing.Size(188, 29);
            this.lblAvailableMakes.TabIndex = 3;
            this.lblAvailableMakes.Text = "Available Makes";
            // 
            // cboSelection
            // 
            this.cboSelection.FormattingEnabled = true;
            this.cboSelection.Location = new System.Drawing.Point(59, 69);
            this.cboSelection.Name = "cboSelection";
            this.cboSelection.Size = new System.Drawing.Size(183, 28);
            this.cboSelection.TabIndex = 4;
            this.cboSelection.SelectedIndexChanged += new System.EventHandler(this.cboSelection_SelectedIndexChanged_1);
            // 
            // lblMakeSelection
            // 
            this.lblMakeSelection.AutoSize = true;
            this.lblMakeSelection.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMakeSelection.Location = new System.Drawing.Point(54, 36);
            this.lblMakeSelection.Name = "lblMakeSelection";
            this.lblMakeSelection.Size = new System.Drawing.Size(146, 29);
            this.lblMakeSelection.TabIndex = 5;
            this.lblMakeSelection.Text = "Select Make";
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(568, 450);
            this.Controls.Add(this.lblMakeSelection);
            this.Controls.Add(this.cboSelection);
            this.Controls.Add(this.lblAvailableMakes);
            this.Controls.Add(this.lblStatus);
            this.Controls.Add(this.btnLoadMakes);
            this.Controls.Add(this.lboMakes);
            this.Name = "frmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Main Form";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lboMakes;
        private System.Windows.Forms.Button btnLoadMakes;
        private System.Windows.Forms.Label lblStatus;
        private System.Windows.Forms.Label lblAvailableMakes;
        private System.Windows.Forms.ComboBox cboSelection;
        private System.Windows.Forms.Label lblMakeSelection;
    }
}

