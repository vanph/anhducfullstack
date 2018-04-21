namespace Hrm.App.View
{
    partial class OrganizationListForm
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
            this.grdOrg = new System.Windows.Forms.DataGridView();
            this.CityName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Description = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Email = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Phone = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.grdOrg)).BeginInit();
            this.SuspendLayout();
            // 
            // grdOrg
            // 
            this.grdOrg.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grdOrg.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdOrg.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.CityName,
            this.Description,
            this.Email,
            this.Phone});
            this.grdOrg.Location = new System.Drawing.Point(63, 48);
            this.grdOrg.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.grdOrg.Name = "grdOrg";
            this.grdOrg.Size = new System.Drawing.Size(716, 281);
            this.grdOrg.TabIndex = 0;
            // 
            // CityName
            // 
            this.CityName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.CityName.DataPropertyName = "Name";
            this.CityName.FillWeight = 1F;
            this.CityName.HeaderText = "Name";
            this.CityName.Name = "CityName";
            // 
            // Description
            // 
            this.Description.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Description.DataPropertyName = "Description";
            this.Description.FillWeight = 2F;
            this.Description.HeaderText = "Description";
            this.Description.Name = "Description";
            // 
            // Email
            // 
            this.Email.DataPropertyName = "Email";
            this.Email.FillWeight = 1F;
            this.Email.HeaderText = "Email";
            this.Email.Name = "Email";
            // 
            // Phone
            // 
            this.Phone.DataPropertyName = "Phone";
            this.Phone.FillWeight = 1F;
            this.Phone.HeaderText = "Phone";
            this.Phone.Name = "Phone";
            this.Phone.Width = 80;
            // 
            // OrganizationListForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(829, 393);
            this.Controls.Add(this.grdOrg);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "OrganizationListForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "City";
            this.Load += new System.EventHandler(this.OrganizationListForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.grdOrg)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.DataGridView grdOrg;
        private System.Windows.Forms.DataGridViewTextBoxColumn CityName;
        private System.Windows.Forms.DataGridViewTextBoxColumn Description;
        private System.Windows.Forms.DataGridViewTextBoxColumn Email;
        private System.Windows.Forms.DataGridViewTextBoxColumn Phone;
    }
}