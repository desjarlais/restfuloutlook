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
            this.label1 = new System.Windows.Forms.Label();
            this.nudContacts = new System.Windows.Forms.NumericUpDown();
            this.cmbFolders = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnNewContact = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgContactsList)).BeginInit();
            this.mnuContextMenu.SuspendLayout();
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
            this.GivenName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.GivenName.ContextMenuStrip = this.mnuContextMenu;
            this.GivenName.HeaderText = "GivenName";
            this.GivenName.Name = "GivenName";
            this.GivenName.ReadOnly = true;
            this.GivenName.Width = 88;
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
            this.Surname.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Surname.ContextMenuStrip = this.mnuContextMenu;
            this.Surname.HeaderText = "Surname";
            this.Surname.Name = "Surname";
            this.Surname.ReadOnly = true;
            this.Surname.Width = 74;
            // 
            // compname
            // 
            this.compname.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.compname.ContextMenuStrip = this.mnuContextMenu;
            this.compname.HeaderText = "CompanyName";
            this.compname.Name = "compname";
            this.compname.ReadOnly = true;
            this.compname.Width = 104;
            // 
            // BusinessPhone
            // 
            this.BusinessPhone.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.BusinessPhone.HeaderText = "BusinessPhone";
            this.BusinessPhone.Name = "BusinessPhone";
            this.BusinessPhone.ReadOnly = true;
            this.BusinessPhone.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.BusinessPhone.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.BusinessPhone.Width = 105;
            // 
            // businessaddress
            // 
            this.businessaddress.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.businessaddress.HeaderText = "BusinessAddress";
            this.businessaddress.Name = "businessaddress";
            this.businessaddress.ReadOnly = true;
            this.businessaddress.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.businessaddress.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.businessaddress.Width = 112;
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
            this.HomePhone.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.HomePhone.ContextMenuStrip = this.mnuContextMenu;
            this.HomePhone.HeaderText = "HomePhone";
            this.HomePhone.Name = "HomePhone";
            this.HomePhone.ReadOnly = true;
            this.HomePhone.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.HomePhone.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.HomePhone.Width = 91;
            // 
            // homeaddress
            // 
            this.homeaddress.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.homeaddress.HeaderText = "HomeAddress";
            this.homeaddress.Name = "homeaddress";
            this.homeaddress.ReadOnly = true;
            this.homeaddress.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.homeaddress.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.homeaddress.Width = 98;
            // 
            // EmailAddress
            // 
            this.EmailAddress.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.EmailAddress.HeaderText = "EmailAddress";
            this.EmailAddress.Name = "EmailAddress";
            this.EmailAddress.ReadOnly = true;
            this.EmailAddress.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.EmailAddress.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.EmailAddress.Width = 95;
            // 
            // asstname
            // 
            this.asstname.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.asstname.ContextMenuStrip = this.mnuContextMenu;
            this.asstname.HeaderText = "AssistantName";
            this.asstname.Name = "asstname";
            this.asstname.ReadOnly = true;
            this.asstname.Width = 102;
            // 
            // birthday
            // 
            this.birthday.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.birthday.ContextMenuStrip = this.mnuContextMenu;
            this.birthday.HeaderText = "Birthday";
            this.birthday.Name = "birthday";
            this.birthday.ReadOnly = true;
            this.birthday.Width = 70;
            // 
            // categories
            // 
            this.categories.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.categories.HeaderText = "Categories";
            this.categories.Name = "categories";
            this.categories.ReadOnly = true;
            this.categories.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.categories.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.categories.Width = 82;
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
            this.children.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.children.HeaderText = "Children";
            this.children.Name = "children";
            this.children.ReadOnly = true;
            this.children.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.children.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.children.Width = 70;
            // 
            // department
            // 
            this.department.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.department.ContextMenuStrip = this.mnuContextMenu;
            this.department.HeaderText = "Department";
            this.department.Name = "department";
            this.department.ReadOnly = true;
            this.department.Width = 87;
            // 
            // createddatetime
            // 
            this.createddatetime.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.createddatetime.ContextMenuStrip = this.mnuContextMenu;
            this.createddatetime.HeaderText = "CreatedDateTime";
            this.createddatetime.Name = "createddatetime";
            this.createddatetime.ReadOnly = true;
            this.createddatetime.Width = 115;
            // 
            // lastmodified
            // 
            this.lastmodified.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.lastmodified.ContextMenuStrip = this.mnuContextMenu;
            this.lastmodified.HeaderText = "LastModifiedDateTime";
            this.lastmodified.Name = "lastmodified";
            this.lastmodified.ReadOnly = true;
            this.lastmodified.Width = 138;
            // 
            // displayname
            // 
            this.displayname.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.displayname.ContextMenuStrip = this.mnuContextMenu;
            this.displayname.HeaderText = "DisplayName";
            this.displayname.Name = "displayname";
            this.displayname.ReadOnly = true;
            this.displayname.Width = 94;
            // 
            // fileas
            // 
            this.fileas.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.fileas.ContextMenuStrip = this.mnuContextMenu;
            this.fileas.HeaderText = "FileAs";
            this.fileas.Name = "fileas";
            this.fileas.ReadOnly = true;
            this.fileas.Width = 60;
            // 
            // generation
            // 
            this.generation.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.generation.ContextMenuStrip = this.mnuContextMenu;
            this.generation.HeaderText = "Generation";
            this.generation.Name = "generation";
            this.generation.ReadOnly = true;
            this.generation.Width = 84;
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
            this.imaddresses.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.imaddresses.HeaderText = "ImAddresses";
            this.imaddresses.Name = "imaddresses";
            this.imaddresses.ReadOnly = true;
            this.imaddresses.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.imaddresses.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.imaddresses.Width = 92;
            // 
            // initials
            // 
            this.initials.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.initials.ContextMenuStrip = this.mnuContextMenu;
            this.initials.HeaderText = "Initials";
            this.initials.Name = "initials";
            this.initials.ReadOnly = true;
            this.initials.Width = 61;
            // 
            // jobtitle
            // 
            this.jobtitle.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.jobtitle.ContextMenuStrip = this.mnuContextMenu;
            this.jobtitle.HeaderText = "JobTitle";
            this.jobtitle.Name = "jobtitle";
            this.jobtitle.ReadOnly = true;
            this.jobtitle.Width = 69;
            // 
            // manager
            // 
            this.manager.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.manager.ContextMenuStrip = this.mnuContextMenu;
            this.manager.HeaderText = "Manager";
            this.manager.Name = "manager";
            this.manager.ReadOnly = true;
            this.manager.Width = 74;
            // 
            // middlename
            // 
            this.middlename.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.middlename.ContextMenuStrip = this.mnuContextMenu;
            this.middlename.HeaderText = "MiddleName";
            this.middlename.Name = "middlename";
            this.middlename.ReadOnly = true;
            this.middlename.Width = 91;
            // 
            // photo
            // 
            this.photo.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.photo.ContextMenuStrip = this.mnuContextMenu;
            this.photo.HeaderText = "Photo";
            this.photo.Name = "photo";
            this.photo.ReadOnly = true;
            this.photo.Width = 60;
            // 
            // nickname
            // 
            this.nickname.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.nickname.ContextMenuStrip = this.mnuContextMenu;
            this.nickname.HeaderText = "NickName";
            this.nickname.Name = "nickname";
            this.nickname.ReadOnly = true;
            this.nickname.Width = 82;
            // 
            // officelocation
            // 
            this.officelocation.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.officelocation.ContextMenuStrip = this.mnuContextMenu;
            this.officelocation.HeaderText = "OfficeLocation";
            this.officelocation.Name = "officelocation";
            this.officelocation.ReadOnly = true;
            this.officelocation.Width = 101;
            // 
            // otheraddress
            // 
            this.otheraddress.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.otheraddress.HeaderText = "OtherAddress";
            this.otheraddress.Name = "otheraddress";
            this.otheraddress.ReadOnly = true;
            this.otheraddress.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.otheraddress.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.otheraddress.Width = 96;
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
            this.profession.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.profession.ContextMenuStrip = this.mnuContextMenu;
            this.profession.HeaderText = "Profession";
            this.profession.Name = "profession";
            this.profession.ReadOnly = true;
            this.profession.Width = 81;
            // 
            // spousename
            // 
            this.spousename.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.spousename.ContextMenuStrip = this.mnuContextMenu;
            this.spousename.HeaderText = "SpouseName";
            this.spousename.Name = "spousename";
            this.spousename.ReadOnly = true;
            this.spousename.Width = 96;
            // 
            // title
            // 
            this.title.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.title.ContextMenuStrip = this.mnuContextMenu;
            this.title.HeaderText = "Title";
            this.title.Name = "title";
            this.title.ReadOnly = true;
            this.title.Width = 52;
            // 
            // yomicompanyname
            // 
            this.yomicompanyname.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.yomicompanyname.ContextMenuStrip = this.mnuContextMenu;
            this.yomicompanyname.HeaderText = "YomiCompanyName";
            this.yomicompanyname.Name = "yomicompanyname";
            this.yomicompanyname.ReadOnly = true;
            this.yomicompanyname.Width = 127;
            // 
            // yomigivenname
            // 
            this.yomigivenname.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.yomigivenname.ContextMenuStrip = this.mnuContextMenu;
            this.yomigivenname.HeaderText = "YomiGivenName";
            this.yomigivenname.Name = "yomigivenname";
            this.yomigivenname.ReadOnly = true;
            this.yomigivenname.Width = 111;
            // 
            // yomisurname
            // 
            this.yomisurname.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.yomisurname.ContextMenuStrip = this.mnuContextMenu;
            this.yomisurname.HeaderText = "YomiSurname";
            this.yomisurname.Name = "yomisurname";
            this.yomisurname.ReadOnly = true;
            this.yomisurname.Width = 97;
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
            // btnNewContact
            // 
            this.btnNewContact.Location = new System.Drawing.Point(12, 334);
            this.btnNewContact.Name = "btnNewContact";
            this.btnNewContact.Size = new System.Drawing.Size(98, 23);
            this.btnNewContact.TabIndex = 8;
            this.btnNewContact.Text = "New Contact";
            this.btnNewContact.UseVisualStyleBackColor = true;
            this.btnNewContact.Click += new System.EventHandler(this.btnNewContact_Click);
            // 
            // ContactsAPI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(896, 364);
            this.Controls.Add(this.btnNewContact);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cmbFolders);
            this.Controls.Add(this.nudContacts);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnGetContacts);
            this.Controls.Add(this.dgContactsList);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "ContactsAPI";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Contacts";
            ((System.ComponentModel.ISupportInitialize)(this.dgContactsList)).EndInit();
            this.mnuContextMenu.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.nudContacts)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgContactsList;
        private System.Windows.Forms.Button btnGetContacts;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ContextMenuStrip mnuContextMenu;
        private System.Windows.Forms.ToolStripMenuItem copyToolStripMenuItem;
        private System.Windows.Forms.NumericUpDown nudContacts;
        private System.Windows.Forms.ComboBox cmbFolders;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridViewTextBoxColumn GivenName;
        private System.Windows.Forms.DataGridViewTextBoxColumn Surname;
        private System.Windows.Forms.DataGridViewTextBoxColumn compname;
        private System.Windows.Forms.DataGridViewButtonColumn BusinessPhone;
        private System.Windows.Forms.DataGridViewButtonColumn businessaddress;
        private System.Windows.Forms.DataGridViewTextBoxColumn businesshomepage;
        private System.Windows.Forms.DataGridViewButtonColumn HomePhone;
        private System.Windows.Forms.DataGridViewButtonColumn homeaddress;
        private System.Windows.Forms.DataGridViewButtonColumn EmailAddress;
        private System.Windows.Forms.DataGridViewTextBoxColumn asstname;
        private System.Windows.Forms.DataGridViewTextBoxColumn birthday;
        private System.Windows.Forms.DataGridViewButtonColumn categories;
        private System.Windows.Forms.DataGridViewTextBoxColumn changekey;
        private System.Windows.Forms.DataGridViewButtonColumn children;
        private System.Windows.Forms.DataGridViewTextBoxColumn department;
        private System.Windows.Forms.DataGridViewTextBoxColumn createddatetime;
        private System.Windows.Forms.DataGridViewTextBoxColumn lastmodified;
        private System.Windows.Forms.DataGridViewTextBoxColumn displayname;
        private System.Windows.Forms.DataGridViewTextBoxColumn fileas;
        private System.Windows.Forms.DataGridViewTextBoxColumn generation;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.DataGridViewButtonColumn imaddresses;
        private System.Windows.Forms.DataGridViewTextBoxColumn initials;
        private System.Windows.Forms.DataGridViewTextBoxColumn jobtitle;
        private System.Windows.Forms.DataGridViewTextBoxColumn manager;
        private System.Windows.Forms.DataGridViewTextBoxColumn middlename;
        private System.Windows.Forms.DataGridViewTextBoxColumn photo;
        private System.Windows.Forms.DataGridViewTextBoxColumn nickname;
        private System.Windows.Forms.DataGridViewTextBoxColumn officelocation;
        private System.Windows.Forms.DataGridViewButtonColumn otheraddress;
        private System.Windows.Forms.DataGridViewTextBoxColumn parentfolderid;
        private System.Windows.Forms.DataGridViewTextBoxColumn personalnotes;
        private System.Windows.Forms.DataGridViewTextBoxColumn profession;
        private System.Windows.Forms.DataGridViewTextBoxColumn spousename;
        private System.Windows.Forms.DataGridViewTextBoxColumn title;
        private System.Windows.Forms.DataGridViewTextBoxColumn yomicompanyname;
        private System.Windows.Forms.DataGridViewTextBoxColumn yomigivenname;
        private System.Windows.Forms.DataGridViewTextBoxColumn yomisurname;
        private System.Windows.Forms.Button btnNewContact;
    }
}