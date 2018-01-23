namespace SourceControl
{
    partial class Form1
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
            this.btnExit = new System.Windows.Forms.Button();
            this.btnAddStreet = new System.Windows.Forms.Button();
            this.txtStreetName = new System.Windows.Forms.TextBox();
            this.lstStreets = new System.Windows.Forms.ListBox();
            this.cboStreetName = new System.Windows.Forms.ComboBox();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnExit
            // 
            this.btnExit.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnExit.Location = new System.Drawing.Point(193, 203);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(79, 46);
            this.btnExit.TabIndex = 0;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnAddStreet
            // 
            this.btnAddStreet.Location = new System.Drawing.Point(181, 12);
            this.btnAddStreet.Name = "btnAddStreet";
            this.btnAddStreet.Size = new System.Drawing.Size(91, 46);
            this.btnAddStreet.TabIndex = 1;
            this.btnAddStreet.Text = "Add Street Name";
            this.btnAddStreet.UseVisualStyleBackColor = true;
            this.btnAddStreet.Click += new System.EventHandler(this.BtnAddStreet_Click);
            // 
            // txtStreetName
            // 
            this.txtStreetName.Location = new System.Drawing.Point(21, 12);
            this.txtStreetName.Name = "txtStreetName";
            this.txtStreetName.Size = new System.Drawing.Size(100, 20);
            this.txtStreetName.TabIndex = 2;
            // 
            // lstStreets
            // 
            this.lstStreets.FormattingEnabled = true;
            this.lstStreets.Location = new System.Drawing.Point(22, 65);
            this.lstStreets.Name = "lstStreets";
            this.lstStreets.Size = new System.Drawing.Size(120, 95);
            this.lstStreets.TabIndex = 3;
            this.lstStreets.SelectedIndexChanged += new System.EventHandler(this.lstStreets_SelectedIndexChanged);
            // 
            // cboStreetName
            // 
            this.cboStreetName.FormattingEnabled = true;
            this.cboStreetName.Location = new System.Drawing.Point(21, 38);
            this.cboStreetName.Name = "cboStreetName";
            this.cboStreetName.Size = new System.Drawing.Size(121, 21);
            this.cboStreetName.TabIndex = 4;
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(181, 65);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(91, 42);
            this.btnUpdate.TabIndex = 5;
            this.btnUpdate.Text = "Update Street";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(181, 113);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(91, 46);
            this.btnDelete.TabIndex = 6;
            this.btnDelete.Text = "Delete Street";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // Form1
            // 
            this.AcceptButton = this.btnAddStreet;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnExit;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.cboStreetName);
            this.Controls.Add(this.lstStreets);
            this.Controls.Add(this.txtStreetName);
            this.Controls.Add(this.btnAddStreet);
            this.Controls.Add(this.btnExit);
            this.Name = "Form1";
            this.Text = "Streets List";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnAddStreet;
        private System.Windows.Forms.TextBox txtStreetName;
        private System.Windows.Forms.ListBox lstStreets;
        private System.Windows.Forms.ComboBox cboStreetName;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnDelete;
    }
}

