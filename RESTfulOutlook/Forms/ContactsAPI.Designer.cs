namespace RESTfulOutlook.Forms
{
    partial class ContactsAPI
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ContactsAPI));
            this.dgContactsList = new System.Windows.Forms.DataGridView();
            this.GivenName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mnuContextMenu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.copyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.Surname = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.compname = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BusinessPhone = new System.Windows.Forms.DataGridViewButtonColumn();
            this.businessaddress = new System.Windows.Forms.DataGridViewButtonColumn();
            this.businesshomepage = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.HomePhone = new System.Windows.Forms.DataGridViewButtonColumn();
            this.homeaddress = new System.Windows.Forms.DataGridViewButtonColumn();
            this.EmailAddress = new System.Windows.Forms.DataGridViewButtonColumn();
            this.asstname = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.birthday = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.categories = new System.Windows.Forms.DataGridViewButtonColumn();
            this.changekey = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.children = new System.Windows.Forms.DataGridViewButtonColumn();
            this.department = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.createddatetime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lastmodified = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.displayname = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fileas = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.generation = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.imaddresses = new System.Windows.Forms.DataGridViewButtonColumn();
            this.initials = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.jobtitle = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.manager = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.middlename = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.photo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nickname = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.officelocation = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.otheraddress = new System.Windows.Forms.DataGridViewButtonColumn();
            this.parentfolderid = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.personalnotes = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.profession = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.spousename = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.title = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.yomicompanyname = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.yomigivenname = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.yomisurname = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnGetContacts = new System.Windows.Forms.Button();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatus = new System.Windows.Forms.ToolStripStatusLabel();
            this.label1 = new System.Windows.Forms.Label();
            this.nudContacts = new System.Windows.Forms.NumericUpDown();
            this.cmbFolders = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgContactsList)).BeginInit();
            this.mnuContextMenu.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudContacts)).BeginInit();
            this.SuspendLayout();
            // 
            // dgContactsList
            // 
            this.dgContactsList.AllowUserToAddRows = false;
            this.dgContactsList.AllowUserToDeleteRows = false;
            this.dgContactsList.AllowUserToResizeRows = false;
            this.dgContactsList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgContactsList.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.GivenName,
            this.Surname,
            this.compname,
            this.BusinessPhone,
            this.businessaddress,
            this.businesshomepage,
            this.HomePhone,
            this.homeaddress,
            this.EmailAddress,
            this.asstname,
            this.birthday,
            this.categories,
            this.changekey,
            this.children,
            this.department,
            this.createddatetime,
            this.lastmodified,
            this.displayname,
            this.fileas,
            this.generation,
            this.id,
            this.imaddresses,
            this.initials,
            this.jobtitle,
            this.manager,
            this.middlename,
            this.photo,
            this.nickname,
            this.officelocation,
            this.otheraddress,
            this.parentfolderid,
            this.personalnotes,
            this.profession,
            this.spousename,
            this.title,
            this.yomicompanyname,
            this.yomigivenname,
            this.yomisurname});
            this.dgContactsList.Location = new System.Drawing.Point(12, 41);
            this.dgContactsList.MultiSelect = false;
            this.dgContactsList.Name = "dgContactsList";
            this.dgContactsList.ReadOnly = true;
            this.dgContactsList.Size = new System.Drawing.Size(872, 287);
            this.dgContactsList.TabIndex = 0;
            this.dgContactsList.CellContentDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgContactsList_CellContentDoubleClick);
            this.dgContactsList.CellMouseDown += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgContactsList_CellMouseDown);
            // 
            // GivenName
            // 
            this.GivenName.ContextMenuStrip = this.mnuContextMenu;
            this.GivenName.HeaderText = "GivenName";
            this.GivenName.Name = "GivenName";
            this.GivenName.ReadOnly = true;
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
            // Surname
            // 
            this.Surname.ContextMenuStrip = this.mnuContextMenu;
            this.Surname.HeaderText = "Surname";
            this.Surname.Name = "Surname";
            this.Surname.ReadOnly = true;
            // 
            // compname
            // 
            this.compname.ContextMenuStrip = this.mnuContextMenu;
            this.compname.HeaderText = "CompanyName";
            this.compname.Name = "compname";
            this.compname.ReadOnly = true;
            // 
            // BusinessPhone
            // 
            this.BusinessPhone.HeaderText = "BusinessPhone";
            this.BusinessPhone.Name = "BusinessPhone";
            this.BusinessPhone.ReadOnly = true;
            this.BusinessPhone.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.BusinessPhone.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // businessaddress
            // 
            this.businessaddress.HeaderText = "BusinessAddress";
            this.businessaddress.Name = "businessaddress";
            this.businessaddress.ReadOnly = true;
            this.businessaddress.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.businessaddress.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // businesshomepage
            // 
            this.businesshomepage.ContextMenuStrip = this.mnuContextMenu;
            this.businesshomepage.HeaderText = "BusinessHomePage";
            this.businesshomepage.Name = "businesshomepage";
            this.businesshomepage.ReadOnly = true;
            // 
            // HomePhone
            // 
            this.HomePhone.ContextMenuStrip = this.mnuContextMenu;
            this.HomePhone.HeaderText = "HomePhone";
            this.HomePhone.Name = "HomePhone";
            this.HomePhone.ReadOnly = true;
            this.HomePhone.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.HomePhone.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // homeaddress
            // 
            this.homeaddress.HeaderText = "HomeAddress";
            this.homeaddress.Name = "homeaddress";
            this.homeaddress.ReadOnly = true;
            this.homeaddress.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.homeaddress.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // EmailAddress
            // 
            this.EmailAddress.HeaderText = "EmailAddress";
            this.EmailAddress.Name = "EmailAddress";
            this.EmailAddress.ReadOnly = true;
            this.EmailAddress.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.EmailAddress.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // asstname
            // 
            this.asstname.ContextMenuStrip = this.mnuContextMenu;
            this.asstname.HeaderText = "AssistantName";
            this.asstname.Name = "asstname";
            this.asstname.ReadOnly = true;
            // 
            // birthday
            // 
            this.birthday.ContextMenuStrip = this.mnuContextMenu;
            this.birthday.HeaderText = "Birthday";
            this.birthday.Name = "birthday";
            this.birthday.ReadOnly = true;
            // 
            // categories
            // 
            this.categories.HeaderText = "Categories";
            this.categories.Name = "categories";
            this.categories.ReadOnly = true;
            this.categories.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.categories.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // changekey
            // 
            this.changekey.ContextMenuStrip = this.mnuContextMenu;
            this.changekey.HeaderText = "ChangeKey";
            this.changekey.Name = "changekey";
            this.changekey.ReadOnly = true;
            // 
            // children
            // 
            this.children.HeaderText = "Children";
            this.children.Name = "children";
            this.children.ReadOnly = true;
            this.children.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.children.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // department
            // 
            this.department.ContextMenuStrip = this.mnuContextMenu;
            this.department.HeaderText = "Department";
            this.department.Name = "department";
            this.department.ReadOnly = true;
            // 
            // createddatetime
            // 
            this.createddatetime.ContextMenuStrip = this.mnuContextMenu;
            this.createddatetime.HeaderText = "CreatedDateTime";
            this.createddatetime.Name = "createddatetime";
            this.createddatetime.ReadOnly = true;
            // 
            // lastmodified
            // 
            this.lastmodified.ContextMenuStrip = this.mnuContextMenu;
            this.lastmodified.HeaderText = "LastModifiedDateTime";
            this.lastmodified.Name = "lastmodified";
            this.lastmodified.ReadOnly = true;
            // 
            // displayname
            // 
            this.displayname.ContextMenuStrip = this.mnuContextMenu;
            this.displayname.HeaderText = "DisplayName";
            this.displayname.Name = "displayname";
            this.displayname.ReadOnly = true;
            // 
            // fileas
            // 
            this.fileas.ContextMenuStrip = this.mnuContextMenu;
            this.fileas.HeaderText = "FileAs";
            this.fileas.Name = "fileas";
            this.fileas.ReadOnly = true;
            // 
            // generation
            // 
            this.generation.ContextMenuStrip = this.mnuContextMenu;
            this.generation.HeaderText = "Generation";
            this.generation.Name = "generation";
            this.generation.ReadOnly = true;
            // 
            // id
            // 
            this.id.ContextMenuStrip = this.mnuContextMenu;
            this.id.HeaderText = "Id";
            this.id.Name = "id";
            this.id.ReadOnly = true;
            // 
            // imaddresses
            // 
            this.imaddresses.HeaderText = "ImAddresses";
            this.imaddresses.Name = "imaddresses";
            this.imaddresses.ReadOnly = true;
            this.imaddresses.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.imaddresses.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // initials
            // 
            this.initials.ContextMenuStrip = this.mnuContextMenu;
            this.initials.HeaderText = "Initials";
            this.initials.Name = "initials";
            this.initials.ReadOnly = true;
            // 
            // jobtitle
            // 
            this.jobtitle.ContextMenuStrip = this.mnuContextMenu;
            this.jobtitle.HeaderText = "JobTitle";
            this.jobtitle.Name = "jobtitle";
            this.jobtitle.ReadOnly = true;
            // 
            // manager
            // 
            this.manager.ContextMenuStrip = this.mnuContextMenu;
            this.manager.HeaderText = "Manager";
            this.manager.Name = "manager";
            this.manager.ReadOnly = true;
            // 
            // middlename
            // 
            this.middlename.ContextMenuStrip = this.mnuContextMenu;
            this.middlename.HeaderText = "MiddleName";
            this.middlename.Name = "middlename";
            this.middlename.ReadOnly = true;
            // 
            // photo
            // 
            this.photo.ContextMenuStrip = this.mnuContextMenu;
            this.photo.HeaderText = "Photo";
            this.photo.Name = "photo";
            this.photo.ReadOnly = true;
            // 
            // nickname
            // 
            this.nickname.ContextMenuStrip = this.mnuContextMenu;
            this.nickname.HeaderText = "NickName";
            this.nickname.Name = "nickname";
            this.nickname.ReadOnly = true;
            // 
            // officelocation
            // 
            this.officelocation.ContextMenuStrip = this.mnuContextMenu;
            this.officelocation.HeaderText = "OfficeLocation";
            this.officelocation.Name = "officelocation";
            this.officelocation.ReadOnly = true;
            // 
            // otheraddress
            // 
            this.otheraddress.HeaderText = "OtherAddress";
            this.otheraddress.Name = "otheraddress";
            this.otheraddress.ReadOnly = true;
            this.otheraddress.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.otheraddress.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // parentfolderid
            // 
            this.parentfolderid.ContextMenuStrip = this.mnuContextMenu;
            this.parentfolderid.HeaderText = "ParentFolderId";
            this.parentfolderid.Name = "parentfolderid";
            this.parentfolderid.ReadOnly = true;
            // 
            // personalnotes
            // 
            this.personalnotes.ContextMenuStrip = this.mnuContextMenu;
            this.personalnotes.HeaderText = "PersonalNotes";
            this.personalnotes.Name = "personalnotes";
            this.personalnotes.ReadOnly = true;
            // 
            // profession
            // 
            this.profession.ContextMenuStrip = this.mnuContextMenu;
            this.profession.HeaderText = "Profession";
            this.profession.Name = "profession";
            this.profession.ReadOnly = true;
            // 
            // spousename
            // 
            this.spousename.ContextMenuStrip = this.mnuContextMenu;
            this.spousename.HeaderText = "SpouseName";
            this.spousename.Name = "spousename";
            this.spousename.ReadOnly = true;
            // 
            // title
            // 
            this.title.ContextMenuStrip = this.mnuContextMenu;
            this.title.HeaderText = "Title";
            this.title.Name = "title";
            this.title.ReadOnly = true;
            // 
            // yomicompanyname
            // 
            this.yomicompanyname.ContextMenuStrip = this.mnuContextMenu;
            this.yomicompanyname.HeaderText = "YomiCompanyName";
            this.yomicompanyname.Name = "yomicompanyname";
            this.yomicompanyname.ReadOnly = true;
            // 
            // yomigivenname
            // 
            this.yomigivenname.ContextMenuStrip = this.mnuContextMenu;
            this.yomigivenname.HeaderText = "YomiGivenName";
            this.yomigivenname.Name = "yomigivenname";
            this.yomigivenname.ReadOnly = true;
            // 
            // yomisurname
            // 
            this.yomisurname.ContextMenuStrip = this.mnuContextMenu;
            this.yomisurname.HeaderText = "YomiSurname";
            this.yomisurname.Name = "yomisurname";
            this.yomisurname.ReadOnly = true;
            // 
            // btnGetContacts
            // 
            this.btnGetContacts.Location = new System.Drawing.Point(12, 12);
            this.btnGetContacts.Name = "btnGetContacts";
            this.btnGetContacts.Size = new System.Drawing.Size(98, 23);
            this.btnGetContacts.TabIndex = 1;
            this.btnGetContacts.Text = "Get Contacts";
            this.btnGetContacts.UseVisualStyleBackColor = true;
            this.btnGetContacts.Click += new System.EventHandler(this.btnGetContacts_Click);
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1,
            this.toolStripStatus});
            this.statusStrip1.Location = new System.Drawing.Point(0, 351);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(896, 22);
            this.statusStrip1.TabIndex = 2;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(45, 17);
            this.toolStripStatusLabel1.Text = "Status: ";
            // 
            // toolStripStatus
            // 
            this.toolStripStatus.Name = "toolStripStatus";
            this.toolStripStatus.Size = new System.Drawing.Size(39, 17);
            this.toolStripStatus.Text = "Ready";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(606, 335);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(278, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Double-Click Cell to open collection objects like recipients";
            // 
            // nudContacts
            // 
            this.nudContacts.Location = new System.Drawing.Point(116, 12);
            this.nudContacts.Maximum = new decimal(new int[] {
            999,
            0,
            0,
            0});
            this.nudContacts.Name = "nudContacts";
            this.nudContacts.Size = new System.Drawing.Size(56, 20);
            this.nudContacts.TabIndex = 5;
            this.nudContacts.Value = new decimal(new int[] {
            10,
            0,
            0,
            0});
            // 
            // cmbFolders
            // 
            this.cmbFolders.FormattingEnabled = true;
            this.cmbFolders.Location = new System.Drawing.Point(763, 14);
            this.cmbFolders.Name = "cmbFolders";
            this.cmbFolders.Size = new System.Drawing.Size(121, 21);
            this.cmbFolders.TabIndex = 6;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(722, 17);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(36, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Folder";
            // 
            // ContactsAPI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(896, 373);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cmbFolders);
            this.Controls.Add(this.nudContacts);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.btnGetContacts);
            this.Controls.Add(this.dgContactsList);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "ContactsAPI";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "ContactsAPI";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.ContactsAPI_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.dgContactsList)).EndInit();
            this.mnuContextMenu.ResumeLayout(false);
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudContacts)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgContactsList;
        private System.Windows.Forms.Button btnGetContacts;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatus;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ContextMenuStrip mnuContextMenu;
        private System.Windows.Forms.ToolStripMenuItem copyToolStripMenuItem;
        private System.Windows.Forms.NumericUpDown nudContacts;
        private System.Windows.Forms.ComboBox cmbFolders;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridViewTextBoxColumn compname;
        private System.Windows.Forms.DataGridViewTextBoxColumn yomisurname;
        private System.Windows.Forms.DataGridViewTextBoxColumn yomigivenname;
        private System.Windows.Forms.DataGridViewTextBoxColumn yomicompanyname;
        private System.Windows.Forms.DataGridViewTextBoxColumn title;
        private System.Windows.Forms.DataGridViewTextBoxColumn spousename;
        private System.Windows.Forms.DataGridViewTextBoxColumn profession;
        private System.Windows.Forms.DataGridViewTextBoxColumn personalnotes;
        private System.Windows.Forms.DataGridViewTextBoxColumn parentfolderid;
        private System.Windows.Forms.DataGridViewButtonColumn otheraddress;
        private System.Windows.Forms.DataGridViewTextBoxColumn officelocation;
        private System.Windows.Forms.DataGridViewTextBoxColumn nickname;
        private System.Windows.Forms.DataGridViewTextBoxColumn photo;
        private System.Windows.Forms.DataGridViewTextBoxColumn middlename;
        private System.Windows.Forms.DataGridViewTextBoxColumn manager;
        private System.Windows.Forms.DataGridViewTextBoxColumn jobtitle;
        private System.Windows.Forms.DataGridViewTextBoxColumn initials;
        private System.Windows.Forms.DataGridViewButtonColumn imaddresses;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.DataGridViewTextBoxColumn generation;
        private System.Windows.Forms.DataGridViewTextBoxColumn fileas;
        private System.Windows.Forms.DataGridViewTextBoxColumn displayname;
        private System.Windows.Forms.DataGridViewTextBoxColumn lastmodified;
        private System.Windows.Forms.DataGridViewTextBoxColumn createddatetime;
        private System.Windows.Forms.DataGridViewTextBoxColumn department;
        private System.Windows.Forms.DataGridViewButtonColumn children;
        private System.Windows.Forms.DataGridViewTextBoxColumn changekey;
        private System.Windows.Forms.DataGridViewButtonColumn categories;
        private System.Windows.Forms.DataGridViewTextBoxColumn birthday;
        private System.Windows.Forms.DataGridViewTextBoxColumn asstname;
        private System.Windows.Forms.DataGridViewButtonColumn EmailAddress;
        private System.Windows.Forms.DataGridViewButtonColumn homeaddress;
        private System.Windows.Forms.DataGridViewButtonColumn HomePhone;
        private System.Windows.Forms.DataGridViewTextBoxColumn businesshomepage;
        private System.Windows.Forms.DataGridViewButtonColumn businessaddress;
        private System.Windows.Forms.DataGridViewButtonColumn BusinessPhone;
        private System.Windows.Forms.DataGridViewTextBoxColumn Surname;
        private System.Windows.Forms.DataGridViewTextBoxColumn GivenName;
    }
}