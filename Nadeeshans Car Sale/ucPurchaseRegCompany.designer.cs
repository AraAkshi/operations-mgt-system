namespace Nadeeshans_Car_Sale
{
    partial class ucPurchaseRegCompany
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblName = new System.Windows.Forms.Label();
            this.lblAddress = new System.Windows.Forms.Label();
            this.lblContactNumber = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.txtAddress = new System.Windows.Forms.TextBox();
            this.txtContactNumber = new System.Windows.Forms.TextBox();
            this.lblSpecialNotes = new System.Windows.Forms.Label();
            this.txtSpecialNotes = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.checkForm42 = new System.Windows.Forms.CheckBox();
            this.checkBRCopy = new System.Windows.Forms.CheckBox();
            this.checkSerRecords = new System.Windows.Forms.CheckBox();
            this.cmbDirectorNic = new System.Windows.Forms.ComboBox();
            this.checkDirectorNIC = new System.Windows.Forms.CheckBox();
            this.checkDuplicateKey = new System.Windows.Forms.CheckBox();
            this.checkMTA6 = new System.Windows.Forms.CheckBox();
            this.checkObjectionLetter = new System.Windows.Forms.CheckBox();
            this.checkDeletionLetter = new System.Windows.Forms.CheckBox();
            this.checkRevLicence = new System.Windows.Forms.CheckBox();
            this.checkVIC = new System.Windows.Forms.CheckBox();
            this.checkRegBook = new System.Windows.Forms.CheckBox();
            this.btnViewMore = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btnBack = new Bunifu.Framework.UI.BunifuFlatButton();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Font = new System.Drawing.Font("Lato", 12F);
            this.lblName.Location = new System.Drawing.Point(18, 31);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(53, 19);
            this.lblName.TabIndex = 11;
            this.lblName.Text = "Name ";
            // 
            // lblAddress
            // 
            this.lblAddress.AutoSize = true;
            this.lblAddress.Font = new System.Drawing.Font("Lato", 12F);
            this.lblAddress.Location = new System.Drawing.Point(19, 62);
            this.lblAddress.Name = "lblAddress";
            this.lblAddress.Size = new System.Drawing.Size(66, 19);
            this.lblAddress.TabIndex = 12;
            this.lblAddress.Text = "Address";
            // 
            // lblContactNumber
            // 
            this.lblContactNumber.AutoSize = true;
            this.lblContactNumber.Font = new System.Drawing.Font("Lato", 12F);
            this.lblContactNumber.Location = new System.Drawing.Point(18, 93);
            this.lblContactNumber.Name = "lblContactNumber";
            this.lblContactNumber.Size = new System.Drawing.Size(122, 19);
            this.lblContactNumber.TabIndex = 13;
            this.lblContactNumber.Text = "Contact number";
            // 
            // txtName
            // 
            this.txtName.Font = new System.Drawing.Font("Lato", 12F);
            this.txtName.Location = new System.Drawing.Point(191, 27);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(360, 27);
            this.txtName.TabIndex = 14;
            this.txtName.TextChanged += new System.EventHandler(this.txtName_TextChanged);
            // 
            // txtAddress
            // 
            this.txtAddress.Font = new System.Drawing.Font("Lato", 12F);
            this.txtAddress.Location = new System.Drawing.Point(191, 60);
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.Size = new System.Drawing.Size(360, 27);
            this.txtAddress.TabIndex = 15;
            this.txtAddress.TextChanged += new System.EventHandler(this.txtAddress_TextChanged);
            // 
            // txtContactNumber
            // 
            this.txtContactNumber.Font = new System.Drawing.Font("Lato", 12F);
            this.txtContactNumber.Location = new System.Drawing.Point(192, 93);
            this.txtContactNumber.Name = "txtContactNumber";
            this.txtContactNumber.Size = new System.Drawing.Size(360, 27);
            this.txtContactNumber.TabIndex = 16;
            this.txtContactNumber.TextChanged += new System.EventHandler(this.txtContactNumber_TextChanged);
            // 
            // lblSpecialNotes
            // 
            this.lblSpecialNotes.AutoSize = true;
            this.lblSpecialNotes.Font = new System.Drawing.Font("Lato", 12F);
            this.lblSpecialNotes.Location = new System.Drawing.Point(18, 124);
            this.lblSpecialNotes.Name = "lblSpecialNotes";
            this.lblSpecialNotes.Size = new System.Drawing.Size(102, 19);
            this.lblSpecialNotes.TabIndex = 30;
            this.lblSpecialNotes.Text = "Special Notes";
            // 
            // txtSpecialNotes
            // 
            this.txtSpecialNotes.Font = new System.Drawing.Font("Lato", 12F);
            this.txtSpecialNotes.Location = new System.Drawing.Point(191, 126);
            this.txtSpecialNotes.Multiline = true;
            this.txtSpecialNotes.Name = "txtSpecialNotes";
            this.txtSpecialNotes.Size = new System.Drawing.Size(557, 54);
            this.txtSpecialNotes.TabIndex = 31;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lblName);
            this.groupBox1.Controls.Add(this.lblAddress);
            this.groupBox1.Controls.Add(this.lblContactNumber);
            this.groupBox1.Controls.Add(this.txtName);
            this.groupBox1.Controls.Add(this.lblSpecialNotes);
            this.groupBox1.Controls.Add(this.txtSpecialNotes);
            this.groupBox1.Controls.Add(this.txtAddress);
            this.groupBox1.Controls.Add(this.txtContactNumber);
            this.groupBox1.Location = new System.Drawing.Point(18, 24);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox1.Size = new System.Drawing.Size(805, 199);
            this.groupBox1.TabIndex = 34;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Current Owner Details";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.checkForm42);
            this.groupBox2.Controls.Add(this.checkBRCopy);
            this.groupBox2.Controls.Add(this.checkSerRecords);
            this.groupBox2.Controls.Add(this.cmbDirectorNic);
            this.groupBox2.Controls.Add(this.checkDirectorNIC);
            this.groupBox2.Controls.Add(this.checkDuplicateKey);
            this.groupBox2.Controls.Add(this.checkMTA6);
            this.groupBox2.Controls.Add(this.checkObjectionLetter);
            this.groupBox2.Controls.Add(this.checkDeletionLetter);
            this.groupBox2.Controls.Add(this.checkRevLicence);
            this.groupBox2.Controls.Add(this.checkVIC);
            this.groupBox2.Controls.Add(this.checkRegBook);
            this.groupBox2.Location = new System.Drawing.Point(18, 242);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(805, 325);
            this.groupBox2.TabIndex = 35;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Documents to be Verified";
            this.groupBox2.Enter += new System.EventHandler(this.groupBox2_Enter);
            // 
            // checkForm42
            // 
            this.checkForm42.AutoSize = true;
            this.checkForm42.Font = new System.Drawing.Font("Lato", 12F);
            this.checkForm42.Location = new System.Drawing.Point(23, 289);
            this.checkForm42.Name = "checkForm42";
            this.checkForm42.Size = new System.Drawing.Size(263, 23);
            this.checkForm42.TabIndex = 41;
            this.checkForm42.Text = "Form 42/44 (with director\'s name)";
            this.checkForm42.UseVisualStyleBackColor = true;
            // 
            // checkBRCopy
            // 
            this.checkBRCopy.AutoSize = true;
            this.checkBRCopy.Font = new System.Drawing.Font("Lato", 12F);
            this.checkBRCopy.Location = new System.Drawing.Point(23, 263);
            this.checkBRCopy.Name = "checkBRCopy";
            this.checkBRCopy.Size = new System.Drawing.Size(88, 23);
            this.checkBRCopy.TabIndex = 40;
            this.checkBRCopy.Text = "BR Copy";
            this.checkBRCopy.UseVisualStyleBackColor = true;
            // 
            // checkSerRecords
            // 
            this.checkSerRecords.AutoSize = true;
            this.checkSerRecords.Font = new System.Drawing.Font("Lato", 12F);
            this.checkSerRecords.Location = new System.Drawing.Point(23, 237);
            this.checkSerRecords.Name = "checkSerRecords";
            this.checkSerRecords.Size = new System.Drawing.Size(132, 23);
            this.checkSerRecords.TabIndex = 39;
            this.checkSerRecords.Text = "Service records";
            this.checkSerRecords.UseVisualStyleBackColor = true;
            // 
            // cmbDirectorNic
            // 
            this.cmbDirectorNic.Font = new System.Drawing.Font("Lato", 12F);
            this.cmbDirectorNic.FormattingEnabled = true;
            this.cmbDirectorNic.Items.AddRange(new object[] {
            "1",
            "2"});
            this.cmbDirectorNic.Location = new System.Drawing.Point(192, 211);
            this.cmbDirectorNic.Name = "cmbDirectorNic";
            this.cmbDirectorNic.Size = new System.Drawing.Size(329, 27);
            this.cmbDirectorNic.TabIndex = 38;
            // 
            // checkDirectorNIC
            // 
            this.checkDirectorNIC.AutoSize = true;
            this.checkDirectorNIC.Font = new System.Drawing.Font("Lato", 12F);
            this.checkDirectorNIC.Location = new System.Drawing.Point(23, 211);
            this.checkDirectorNIC.Name = "checkDirectorNIC";
            this.checkDirectorNIC.Size = new System.Drawing.Size(165, 23);
            this.checkDirectorNIC.TabIndex = 37;
            this.checkDirectorNIC.Text = "Both Director\'s NIC";
            this.checkDirectorNIC.UseVisualStyleBackColor = true;
            // 
            // checkDuplicateKey
            // 
            this.checkDuplicateKey.AutoSize = true;
            this.checkDuplicateKey.Font = new System.Drawing.Font("Lato", 12F);
            this.checkDuplicateKey.Location = new System.Drawing.Point(23, 185);
            this.checkDuplicateKey.Name = "checkDuplicateKey";
            this.checkDuplicateKey.Size = new System.Drawing.Size(125, 23);
            this.checkDuplicateKey.TabIndex = 36;
            this.checkDuplicateKey.Text = "Duplicate Key";
            this.checkDuplicateKey.UseVisualStyleBackColor = true;
            // 
            // checkMTA6
            // 
            this.checkMTA6.AutoSize = true;
            this.checkMTA6.Font = new System.Drawing.Font("Lato", 12F);
            this.checkMTA6.Location = new System.Drawing.Point(23, 159);
            this.checkMTA6.Name = "checkMTA6";
            this.checkMTA6.Size = new System.Drawing.Size(74, 23);
            this.checkMTA6.TabIndex = 35;
            this.checkMTA6.Text = "MTA 6";
            this.checkMTA6.UseVisualStyleBackColor = true;
            // 
            // checkObjectionLetter
            // 
            this.checkObjectionLetter.AutoSize = true;
            this.checkObjectionLetter.Font = new System.Drawing.Font("Lato", 12F);
            this.checkObjectionLetter.Location = new System.Drawing.Point(23, 133);
            this.checkObjectionLetter.Name = "checkObjectionLetter";
            this.checkObjectionLetter.Size = new System.Drawing.Size(697, 23);
            this.checkObjectionLetter.TabIndex = 34;
            this.checkObjectionLetter.Text = "No objection letter (with company letter head with embrosed seal and signature of" +
    " both directors)";
            this.checkObjectionLetter.UseVisualStyleBackColor = true;
            // 
            // checkDeletionLetter
            // 
            this.checkDeletionLetter.AutoSize = true;
            this.checkDeletionLetter.Font = new System.Drawing.Font("Lato", 12F);
            this.checkDeletionLetter.Location = new System.Drawing.Point(23, 107);
            this.checkDeletionLetter.Name = "checkDeletionLetter";
            this.checkDeletionLetter.Size = new System.Drawing.Size(189, 23);
            this.checkDeletionLetter.TabIndex = 33;
            this.checkDeletionLetter.Text = "Deletion letter (if lease)";
            this.checkDeletionLetter.UseVisualStyleBackColor = true;
            // 
            // checkRevLicence
            // 
            this.checkRevLicence.AutoSize = true;
            this.checkRevLicence.Font = new System.Drawing.Font("Lato", 12F);
            this.checkRevLicence.Location = new System.Drawing.Point(23, 81);
            this.checkRevLicence.Name = "checkRevLicence";
            this.checkRevLicence.Size = new System.Drawing.Size(138, 23);
            this.checkRevLicence.TabIndex = 32;
            this.checkRevLicence.Text = "Revenue licence";
            this.checkRevLicence.UseVisualStyleBackColor = true;
            // 
            // checkVIC
            // 
            this.checkVIC.AutoSize = true;
            this.checkVIC.Font = new System.Drawing.Font("Lato", 12F);
            this.checkVIC.Location = new System.Drawing.Point(23, 55);
            this.checkVIC.Name = "checkVIC";
            this.checkVIC.Size = new System.Drawing.Size(171, 23);
            this.checkVIC.TabIndex = 31;
            this.checkVIC.Text = "VIC (for old vehicles)";
            this.checkVIC.UseVisualStyleBackColor = true;
            // 
            // checkRegBook
            // 
            this.checkRegBook.AutoSize = true;
            this.checkRegBook.Font = new System.Drawing.Font("Lato", 12F);
            this.checkRegBook.Location = new System.Drawing.Point(23, 29);
            this.checkRegBook.Name = "checkRegBook";
            this.checkRegBook.Size = new System.Drawing.Size(204, 23);
            this.checkRegBook.TabIndex = 30;
            this.checkRegBook.Text = "Vehicle Registration book";
            this.checkRegBook.UseVisualStyleBackColor = true;
            // 
            // btnViewMore
            // 
            this.btnViewMore.Activecolor = System.Drawing.Color.Gray;
            this.btnViewMore.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(57)))), ((int)(((byte)(58)))));
            this.btnViewMore.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnViewMore.BorderRadius = 1;
            this.btnViewMore.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.btnViewMore.ButtonText = "NEXT";
            this.btnViewMore.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnViewMore.DisabledColor = System.Drawing.Color.Gray;
            this.btnViewMore.Font = new System.Drawing.Font("Constantia", 12F, System.Drawing.FontStyle.Bold);
            this.btnViewMore.ForeColor = System.Drawing.Color.Silver;
            this.btnViewMore.Iconcolor = System.Drawing.Color.Transparent;
            this.btnViewMore.Iconimage = null;
            this.btnViewMore.Iconimage_right = null;
            this.btnViewMore.Iconimage_right_Selected = null;
            this.btnViewMore.Iconimage_Selected = null;
            this.btnViewMore.IconMarginLeft = 0;
            this.btnViewMore.IconMarginRight = 0;
            this.btnViewMore.IconRightVisible = true;
            this.btnViewMore.IconRightZoom = 0D;
            this.btnViewMore.IconVisible = true;
            this.btnViewMore.IconZoom = 50D;
            this.btnViewMore.IsTab = false;
            this.btnViewMore.Location = new System.Drawing.Point(531, 581);
            this.btnViewMore.Margin = new System.Windows.Forms.Padding(2);
            this.btnViewMore.Name = "btnViewMore";
            this.btnViewMore.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(57)))), ((int)(((byte)(58)))));
            this.btnViewMore.OnHovercolor = System.Drawing.Color.Gray;
            this.btnViewMore.OnHoverTextColor = System.Drawing.Color.White;
            this.btnViewMore.Padding = new System.Windows.Forms.Padding(0, 50, 0, 0);
            this.btnViewMore.selected = false;
            this.btnViewMore.Size = new System.Drawing.Size(127, 35);
            this.btnViewMore.TabIndex = 37;
            this.btnViewMore.Text = "NEXT";
            this.btnViewMore.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnViewMore.Textcolor = System.Drawing.Color.White;
            this.btnViewMore.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold);
            this.btnViewMore.Click += new System.EventHandler(this.btnViewMore_Click);
            // 
            // btnBack
            // 
            this.btnBack.Activecolor = System.Drawing.Color.Gray;
            this.btnBack.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(57)))), ((int)(((byte)(58)))));
            this.btnBack.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnBack.BorderRadius = 1;
            this.btnBack.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.btnBack.ButtonText = "CANCEL";
            this.btnBack.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnBack.DisabledColor = System.Drawing.Color.Gray;
            this.btnBack.Font = new System.Drawing.Font("Constantia", 12F, System.Drawing.FontStyle.Bold);
            this.btnBack.ForeColor = System.Drawing.Color.Silver;
            this.btnBack.Iconcolor = System.Drawing.Color.Transparent;
            this.btnBack.Iconimage = null;
            this.btnBack.Iconimage_right = null;
            this.btnBack.Iconimage_right_Selected = null;
            this.btnBack.Iconimage_Selected = null;
            this.btnBack.IconMarginLeft = 0;
            this.btnBack.IconMarginRight = 0;
            this.btnBack.IconRightVisible = true;
            this.btnBack.IconRightZoom = 0D;
            this.btnBack.IconVisible = true;
            this.btnBack.IconZoom = 50D;
            this.btnBack.IsTab = false;
            this.btnBack.Location = new System.Drawing.Point(696, 581);
            this.btnBack.Margin = new System.Windows.Forms.Padding(2);
            this.btnBack.Name = "btnBack";
            this.btnBack.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(57)))), ((int)(((byte)(58)))));
            this.btnBack.OnHovercolor = System.Drawing.Color.Gray;
            this.btnBack.OnHoverTextColor = System.Drawing.Color.White;
            this.btnBack.Padding = new System.Windows.Forms.Padding(0, 50, 0, 0);
            this.btnBack.selected = false;
            this.btnBack.Size = new System.Drawing.Size(127, 35);
            this.btnBack.TabIndex = 36;
            this.btnBack.Text = "CANCEL";
            this.btnBack.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnBack.Textcolor = System.Drawing.Color.White;
            this.btnBack.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold);
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // ucPurchaseRegCompany
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Transparent;
            this.Controls.Add(this.btnViewMore);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Lato", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "ucPurchaseRegCompany";
            this.Size = new System.Drawing.Size(857, 633);
            this.Load += new System.EventHandler(this.ucPurchaseRegCompany_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblAddress;
        private System.Windows.Forms.Label lblContactNumber;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.TextBox txtAddress;
        private System.Windows.Forms.TextBox txtContactNumber;
        private System.Windows.Forms.Label lblSpecialNotes;
        private System.Windows.Forms.TextBox txtSpecialNotes;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.CheckBox checkForm42;
        private System.Windows.Forms.CheckBox checkBRCopy;
        private System.Windows.Forms.CheckBox checkSerRecords;
        private System.Windows.Forms.ComboBox cmbDirectorNic;
        private System.Windows.Forms.CheckBox checkDirectorNIC;
        private System.Windows.Forms.CheckBox checkDuplicateKey;
        private System.Windows.Forms.CheckBox checkMTA6;
        private System.Windows.Forms.CheckBox checkObjectionLetter;
        private System.Windows.Forms.CheckBox checkDeletionLetter;
        private System.Windows.Forms.CheckBox checkRevLicence;
        private System.Windows.Forms.CheckBox checkVIC;
        private System.Windows.Forms.CheckBox checkRegBook;
        private Bunifu.Framework.UI.BunifuFlatButton btnViewMore;
        private Bunifu.Framework.UI.BunifuFlatButton btnBack;
    }
}
