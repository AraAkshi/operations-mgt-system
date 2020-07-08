namespace Nadeeshans_Car_Sale
{
    partial class ucInquiriesForm
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
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.txtPhoneNumber = new System.Windows.Forms.TextBox();
            this.txtName = new System.Windows.Forms.TextBox();
            this.lblAddress = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.txtSpecialNotes = new System.Windows.Forms.TextBox();
            this.cmbMake = new System.Windows.Forms.ComboBox();
            this.lblSpecialNotes = new System.Windows.Forms.Label();
            this.lblClass = new System.Windows.Forms.Label();
            this.lblVehicleModel = new System.Windows.Forms.Label();
            this.grpAllInquiries = new System.Windows.Forms.GroupBox();
            this.dgridAllInquiries = new System.Windows.Forms.DataGridView();
            this.btnOk = new System.Windows.Forms.Button();
            this.grpCustomerDetails = new System.Windows.Forms.GroupBox();
            this.lblPhoneNumber = new System.Windows.Forms.Label();
            this.grpVehicleDetails = new System.Windows.Forms.GroupBox();
            this.txtModel = new System.Windows.Forms.TextBox();
            this.btnCancel = new System.Windows.Forms.Button();
            this.grpAllInquiries.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgridAllInquiries)).BeginInit();
            this.grpCustomerDetails.SuspendLayout();
            this.grpVehicleDetails.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(147, 91);
            this.txtEmail.Margin = new System.Windows.Forms.Padding(2);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(389, 27);
            this.txtEmail.TabIndex = 5;
            this.txtEmail.TextChanged += new System.EventHandler(this.txtEmail_TextChanged);
            // 
            // txtPhoneNumber
            // 
            this.txtPhoneNumber.Location = new System.Drawing.Point(147, 59);
            this.txtPhoneNumber.Margin = new System.Windows.Forms.Padding(2);
            this.txtPhoneNumber.Name = "txtPhoneNumber";
            this.txtPhoneNumber.Size = new System.Drawing.Size(389, 27);
            this.txtPhoneNumber.TabIndex = 4;
            this.txtPhoneNumber.TextChanged += new System.EventHandler(this.txtPhoneNumber_TextChanged);
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(147, 27);
            this.txtName.Margin = new System.Windows.Forms.Padding(2);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(389, 27);
            this.txtName.TabIndex = 3;
            this.txtName.TextChanged += new System.EventHandler(this.txtName_TextChanged);
            // 
            // lblAddress
            // 
            this.lblAddress.AutoSize = true;
            this.lblAddress.Location = new System.Drawing.Point(20, 95);
            this.lblAddress.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblAddress.Name = "lblAddress";
            this.lblAddress.Size = new System.Drawing.Size(66, 19);
            this.lblAddress.TabIndex = 2;
            this.lblAddress.Text = "Address";
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(20, 31);
            this.lblName.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(50, 19);
            this.lblName.TabIndex = 0;
            this.lblName.Text = "Name";
            // 
            // txtSpecialNotes
            // 
            this.txtSpecialNotes.Font = new System.Drawing.Font("Lato", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSpecialNotes.Location = new System.Drawing.Point(147, 58);
            this.txtSpecialNotes.Margin = new System.Windows.Forms.Padding(2);
            this.txtSpecialNotes.Multiline = true;
            this.txtSpecialNotes.Name = "txtSpecialNotes";
            this.txtSpecialNotes.Size = new System.Drawing.Size(623, 64);
            this.txtSpecialNotes.TabIndex = 8;
            this.txtSpecialNotes.TextChanged += new System.EventHandler(this.txtSpecialNotes_TextChanged);
            // 
            // cmbMake
            // 
            this.cmbMake.AutoCompleteCustomSource.AddRange(new string[] {
            "CAR",
            "VAN"});
            this.cmbMake.FormattingEnabled = true;
            this.cmbMake.Items.AddRange(new object[] {
            "-",
            "SUZUKI",
            "AUDI",
            "NISSAN",
            "MITSUBUSHI",
            "HONDA",
            "BMW",
            "DATSUN",
            "TESLA",
            "MICRO",
            "MERCEDES-BENZ",
            "TATA",
            "LAND ROVER",
            "MAZDA",
            "TOYOTA"});
            this.cmbMake.Location = new System.Drawing.Point(147, 23);
            this.cmbMake.Margin = new System.Windows.Forms.Padding(2);
            this.cmbMake.Name = "cmbMake";
            this.cmbMake.Size = new System.Drawing.Size(237, 27);
            this.cmbMake.TabIndex = 7;
            this.cmbMake.SelectedIndexChanged += new System.EventHandler(this.cmbMake_SelectedIndexChanged);
            // 
            // lblSpecialNotes
            // 
            this.lblSpecialNotes.AutoSize = true;
            this.lblSpecialNotes.Location = new System.Drawing.Point(22, 58);
            this.lblSpecialNotes.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblSpecialNotes.Name = "lblSpecialNotes";
            this.lblSpecialNotes.Size = new System.Drawing.Size(102, 19);
            this.lblSpecialNotes.TabIndex = 2;
            this.lblSpecialNotes.Text = "Special Notes";
            // 
            // lblClass
            // 
            this.lblClass.AutoSize = true;
            this.lblClass.Location = new System.Drawing.Point(22, 27);
            this.lblClass.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblClass.Name = "lblClass";
            this.lblClass.Size = new System.Drawing.Size(48, 19);
            this.lblClass.TabIndex = 1;
            this.lblClass.Text = "Make";
            this.lblClass.Click += new System.EventHandler(this.lblClass_Click);
            // 
            // lblVehicleModel
            // 
            this.lblVehicleModel.AutoSize = true;
            this.lblVehicleModel.Location = new System.Drawing.Point(460, 27);
            this.lblVehicleModel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblVehicleModel.Name = "lblVehicleModel";
            this.lblVehicleModel.Size = new System.Drawing.Size(54, 19);
            this.lblVehicleModel.TabIndex = 0;
            this.lblVehicleModel.Text = "Model";
            // 
            // grpAllInquiries
            // 
            this.grpAllInquiries.Controls.Add(this.dgridAllInquiries);
            this.grpAllInquiries.Font = new System.Drawing.Font("Lato", 12F);
            this.grpAllInquiries.ForeColor = System.Drawing.Color.Black;
            this.grpAllInquiries.Location = new System.Drawing.Point(36, 377);
            this.grpAllInquiries.Margin = new System.Windows.Forms.Padding(2);
            this.grpAllInquiries.Name = "grpAllInquiries";
            this.grpAllInquiries.Padding = new System.Windows.Forms.Padding(2);
            this.grpAllInquiries.Size = new System.Drawing.Size(784, 241);
            this.grpAllInquiries.TabIndex = 6;
            this.grpAllInquiries.TabStop = false;
            this.grpAllInquiries.Text = "All Inquiries";
            // 
            // dgridAllInquiries
            // 
            this.dgridAllInquiries.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgridAllInquiries.Location = new System.Drawing.Point(14, 35);
            this.dgridAllInquiries.Margin = new System.Windows.Forms.Padding(2);
            this.dgridAllInquiries.Name = "dgridAllInquiries";
            this.dgridAllInquiries.RowTemplate.Height = 24;
            this.dgridAllInquiries.Size = new System.Drawing.Size(756, 202);
            this.dgridAllInquiries.TabIndex = 0;
            // 
            // btnOk
            // 
            this.btnOk.Font = new System.Drawing.Font("Lato", 12F);
            this.btnOk.ForeColor = System.Drawing.Color.Black;
            this.btnOk.Location = new System.Drawing.Point(615, 321);
            this.btnOk.Margin = new System.Windows.Forms.Padding(2);
            this.btnOk.Name = "btnOk";
            this.btnOk.Size = new System.Drawing.Size(85, 32);
            this.btnOk.TabIndex = 7;
            this.btnOk.Text = "OK";
            this.btnOk.UseVisualStyleBackColor = true;
            this.btnOk.Click += new System.EventHandler(this.btnOk_Click);
            // 
            // grpCustomerDetails
            // 
            this.grpCustomerDetails.Controls.Add(this.txtEmail);
            this.grpCustomerDetails.Controls.Add(this.txtPhoneNumber);
            this.grpCustomerDetails.Controls.Add(this.txtName);
            this.grpCustomerDetails.Controls.Add(this.lblAddress);
            this.grpCustomerDetails.Controls.Add(this.lblPhoneNumber);
            this.grpCustomerDetails.Controls.Add(this.lblName);
            this.grpCustomerDetails.Font = new System.Drawing.Font("Lato", 12F);
            this.grpCustomerDetails.ForeColor = System.Drawing.Color.Black;
            this.grpCustomerDetails.Location = new System.Drawing.Point(36, 175);
            this.grpCustomerDetails.Margin = new System.Windows.Forms.Padding(2);
            this.grpCustomerDetails.Name = "grpCustomerDetails";
            this.grpCustomerDetails.Padding = new System.Windows.Forms.Padding(2);
            this.grpCustomerDetails.Size = new System.Drawing.Size(784, 142);
            this.grpCustomerDetails.TabIndex = 4;
            this.grpCustomerDetails.TabStop = false;
            this.grpCustomerDetails.Text = "Customer Details";
            // 
            // lblPhoneNumber
            // 
            this.lblPhoneNumber.AutoSize = true;
            this.lblPhoneNumber.Location = new System.Drawing.Point(20, 63);
            this.lblPhoneNumber.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblPhoneNumber.Name = "lblPhoneNumber";
            this.lblPhoneNumber.Size = new System.Drawing.Size(114, 19);
            this.lblPhoneNumber.TabIndex = 1;
            this.lblPhoneNumber.Text = "Phone Number";
            // 
            // grpVehicleDetails
            // 
            this.grpVehicleDetails.Controls.Add(this.txtModel);
            this.grpVehicleDetails.Controls.Add(this.txtSpecialNotes);
            this.grpVehicleDetails.Controls.Add(this.cmbMake);
            this.grpVehicleDetails.Controls.Add(this.lblSpecialNotes);
            this.grpVehicleDetails.Controls.Add(this.lblClass);
            this.grpVehicleDetails.Controls.Add(this.lblVehicleModel);
            this.grpVehicleDetails.Font = new System.Drawing.Font("Lato", 12F);
            this.grpVehicleDetails.ForeColor = System.Drawing.Color.Black;
            this.grpVehicleDetails.Location = new System.Drawing.Point(36, 14);
            this.grpVehicleDetails.Margin = new System.Windows.Forms.Padding(2);
            this.grpVehicleDetails.Name = "grpVehicleDetails";
            this.grpVehicleDetails.Padding = new System.Windows.Forms.Padding(2);
            this.grpVehicleDetails.Size = new System.Drawing.Size(784, 138);
            this.grpVehicleDetails.TabIndex = 5;
            this.grpVehicleDetails.TabStop = false;
            this.grpVehicleDetails.Text = "Vehicle Details";
            // 
            // txtModel
            // 
            this.txtModel.Location = new System.Drawing.Point(518, 23);
            this.txtModel.Margin = new System.Windows.Forms.Padding(2);
            this.txtModel.Name = "txtModel";
            this.txtModel.Size = new System.Drawing.Size(252, 27);
            this.txtModel.TabIndex = 9;
            this.txtModel.TextChanged += new System.EventHandler(this.txtModel_TextChanged);
            // 
            // btnCancel
            // 
            this.btnCancel.Font = new System.Drawing.Font("Lato", 12F);
            this.btnCancel.ForeColor = System.Drawing.Color.Black;
            this.btnCancel.Location = new System.Drawing.Point(721, 321);
            this.btnCancel.Margin = new System.Windows.Forms.Padding(2);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(85, 32);
            this.btnCancel.TabIndex = 8;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // ucInquiriesForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.grpAllInquiries);
            this.Controls.Add(this.btnOk);
            this.Controls.Add(this.grpCustomerDetails);
            this.Controls.Add(this.grpVehicleDetails);
            this.Controls.Add(this.btnCancel);
            this.Name = "ucInquiriesForm";
            this.Size = new System.Drawing.Size(857, 633);
            this.Load += new System.EventHandler(this.ucInquiriesForm_Load);
            this.grpAllInquiries.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgridAllInquiries)).EndInit();
            this.grpCustomerDetails.ResumeLayout(false);
            this.grpCustomerDetails.PerformLayout();
            this.grpVehicleDetails.ResumeLayout(false);
            this.grpVehicleDetails.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.TextBox txtPhoneNumber;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label lblAddress;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.TextBox txtSpecialNotes;
        private System.Windows.Forms.ComboBox cmbMake;
        private System.Windows.Forms.Label lblSpecialNotes;
        private System.Windows.Forms.Label lblClass;
        private System.Windows.Forms.Label lblVehicleModel;
        private System.Windows.Forms.GroupBox grpAllInquiries;
        private System.Windows.Forms.DataGridView dgridAllInquiries;
        private System.Windows.Forms.Button btnOk;
        private System.Windows.Forms.GroupBox grpCustomerDetails;
        private System.Windows.Forms.Label lblPhoneNumber;
        private System.Windows.Forms.GroupBox grpVehicleDetails;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.TextBox txtModel;
    }
}
