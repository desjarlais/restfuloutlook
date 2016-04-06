namespace RESTfulOutlook.Forms
{
    partial class PhysicalAddressForm
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PhysicalAddressForm));
            this.dgPhysicalAddress = new System.Windows.Forms.DataGridView();
            this.street = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.city = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.state = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.country = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.zip = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mnuContextMenu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.copyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.dgPhysicalAddress)).BeginInit();
            this.mnuContextMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgPhysicalAddress
            // 
            this.dgPhysicalAddress.AllowUserToAddRows = false;
            this.dgPhysicalAddress.AllowUserToDeleteRows = false;
            this.dgPhysicalAddress.AllowUserToResizeRows = false;
            this.dgPhysicalAddress.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgPhysicalAddress.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.street,
            this.city,
            this.state,
            this.country,
            this.zip});
            this.dgPhysicalAddress.Location = new System.Drawing.Point(12, 12);
            this.dgPhysicalAddress.MultiSelect = false;
            this.dgPhysicalAddress.Name = "dgPhysicalAddress";
            this.dgPhysicalAddress.ReadOnly = true;
            this.dgPhysicalAddress.Size = new System.Drawing.Size(703, 195);
            this.dgPhysicalAddress.TabIndex = 0;
            this.dgPhysicalAddress.CellMouseDown += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgPhysicalAddress_CellMouseDown);
            // 
            // street
            // 
            this.street.HeaderText = "Street";
            this.street.Name = "street";
            this.street.ReadOnly = true;
            this.street.Width = 250;
            // 
            // city
            // 
            this.city.HeaderText = "City";
            this.city.Name = "city";
            this.city.ReadOnly = true;
            // 
            // state
            // 
            this.state.HeaderText = "State";
            this.state.Name = "state";
            this.state.ReadOnly = true;
            // 
            // country
            // 
            this.country.HeaderText = "CountryOrRegion";
            this.country.Name = "country";
            this.country.ReadOnly = true;
            // 
            // zip
            // 
            this.zip.HeaderText = "PostalCode";
            this.zip.Name = "zip";
            this.zip.ReadOnly = true;
            // 
            // mnuContextMenu
            // 
            this.mnuContextMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.copyToolStripMenuItem});
            this.mnuContextMenu.Name = "mnuContextMenu";
            this.mnuContextMenu.Size = new System.Drawing.Size(145, 26);
            // 
            // copyToolStripMenuItem
            // 
            this.copyToolStripMenuItem.Name = "copyToolStripMenuItem";
            this.copyToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.C)));
            this.copyToolStripMenuItem.Size = new System.Drawing.Size(144, 22);
            this.copyToolStripMenuItem.Text = "Copy";
            this.copyToolStripMenuItem.Click += new System.EventHandler(this.copyToolStripMenuItem_Click);
            // 
            // PhysicalAddressForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(736, 219);
            this.Controls.Add(this.dgPhysicalAddress);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "PhysicalAddressForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "PhysicalAddressForm";
            ((System.ComponentModel.ISupportInitialize)(this.dgPhysicalAddress)).EndInit();
            this.mnuContextMenu.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgPhysicalAddress;
        private System.Windows.Forms.DataGridViewTextBoxColumn street;
        private System.Windows.Forms.DataGridViewTextBoxColumn city;
        private System.Windows.Forms.DataGridViewTextBoxColumn state;
        private System.Windows.Forms.DataGridViewTextBoxColumn country;
        private System.Windows.Forms.DataGridViewTextBoxColumn zip;
        private System.Windows.Forms.ContextMenuStrip mnuContextMenu;
        private System.Windows.Forms.ToolStripMenuItem copyToolStripMenuItem;
    }
}