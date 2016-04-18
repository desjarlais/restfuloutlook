namespace RESTfulOutlook.Forms
{
    partial class NewMessageForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(NewMessageForm));
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnSendEmail = new System.Windows.Forms.Button();
            this.tbBody = new System.Windows.Forms.TextBox();
            this.tbSubject = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tbToRecipients = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(100, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(29, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "To...";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnSendEmail);
            this.groupBox1.Controls.Add(this.tbBody);
            this.groupBox1.Controls.Add(this.tbSubject);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.tbToRecipients);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(533, 341);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Message Details";
            // 
            // btnSendEmail
            // 
            this.btnSendEmail.Image = ((System.Drawing.Image)(resources.GetObject("btnSendEmail.Image")));
            this.btnSendEmail.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnSendEmail.Location = new System.Drawing.Point(9, 19);
            this.btnSendEmail.Name = "btnSendEmail";
            this.btnSendEmail.Size = new System.Drawing.Size(68, 46);
            this.btnSendEmail.TabIndex = 4;
            this.btnSendEmail.Text = "Send";
            this.btnSendEmail.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnSendEmail.UseVisualStyleBackColor = true;
            this.btnSendEmail.Click += new System.EventHandler(this.btnSendEmail_Click);
            // 
            // tbBody
            // 
            this.tbBody.Location = new System.Drawing.Point(9, 84);
            this.tbBody.Multiline = true;
            this.tbBody.Name = "tbBody";
            this.tbBody.Size = new System.Drawing.Size(511, 240);
            this.tbBody.TabIndex = 5;
            // 
            // tbSubject
            // 
            this.tbSubject.Location = new System.Drawing.Point(135, 49);
            this.tbSubject.Name = "tbSubject";
            this.tbSubject.Size = new System.Drawing.Size(385, 20);
            this.tbSubject.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(83, 52);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(46, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Subject:";
            // 
            // tbToRecipients
            // 
            this.tbToRecipients.Location = new System.Drawing.Point(135, 16);
            this.tbToRecipients.Name = "tbToRecipients";
            this.tbToRecipients.Size = new System.Drawing.Size(385, 20);
            this.tbToRecipients.TabIndex = 1;
            // 
            // NewMessageForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(557, 362);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "NewMessageForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "New Message";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox tbBody;
        private System.Windows.Forms.TextBox tbSubject;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbToRecipients;
        private System.Windows.Forms.Button btnSendEmail;
    }
}