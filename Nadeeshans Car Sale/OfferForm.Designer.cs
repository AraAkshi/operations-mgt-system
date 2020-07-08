namespace Nadeeshans_Car_Sale
{
    partial class OfferForm
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
            this.dateToPurchase = new System.Windows.Forms.DateTimePicker();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.txtAmount = new System.Windows.Forms.TextBox();
            this.txtContactNo = new System.Windows.Forms.TextBox();
            this.txtName = new System.Windows.Forms.TextBox();
            this.lblPurchaseDateOfferDetails = new System.Windows.Forms.Label();
            this.lblEmailOfferDetails = new System.Windows.Forms.Label();
            this.lblAmountOfferDetails = new System.Windows.Forms.Label();
            this.lblContactNumberOfferDetails = new System.Windows.Forms.Label();
            this.lblNameOfferDetails = new System.Windows.Forms.Label();
            this.lblOfferDetails = new System.Windows.Forms.Label();
            this.btnAdd = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btnCancel = new Bunifu.Framework.UI.BunifuFlatButton();
            this.SuspendLayout();
            // 
            // dateToPurchase
            // 
            this.dateToPurchase.Font = new System.Drawing.Font("Lato", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateToPurchase.Location = new System.Drawing.Point(191, 256);
            this.dateToPurchase.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dateToPurchase.Name = "dateToPurchase";
            this.dateToPurchase.Size = new System.Drawing.Size(237, 25);
            this.dateToPurchase.TabIndex = 24;
            // 
            // txtEmail
            // 
            this.txtEmail.Font = new System.Drawing.Font("Lato", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEmail.Location = new System.Drawing.Point(191, 213);
            this.txtEmail.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(237, 25);
            this.txtEmail.TabIndex = 23;
            // 
            // txtAmount
            // 
            this.txtAmount.Font = new System.Drawing.Font("Lato", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAmount.Location = new System.Drawing.Point(191, 170);
            this.txtAmount.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtAmount.Name = "txtAmount";
            this.txtAmount.Size = new System.Drawing.Size(237, 25);
            this.txtAmount.TabIndex = 22;
            this.txtAmount.TextChanged += new System.EventHandler(this.txtAmountOfferDetails_TextChanged);
            // 
            // txtContactNo
            // 
            this.txtContactNo.Font = new System.Drawing.Font("Lato", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtContactNo.Location = new System.Drawing.Point(191, 127);
            this.txtContactNo.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtContactNo.Name = "txtContactNo";
            this.txtContactNo.Size = new System.Drawing.Size(237, 25);
            this.txtContactNo.TabIndex = 21;
            // 
            // txtName
            // 
            this.txtName.Font = new System.Drawing.Font("Lato", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtName.Location = new System.Drawing.Point(191, 84);
            this.txtName.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(237, 25);
            this.txtName.TabIndex = 20;
            // 
            // lblPurchaseDateOfferDetails
            // 
            this.lblPurchaseDateOfferDetails.AutoSize = true;
            this.lblPurchaseDateOfferDetails.Font = new System.Drawing.Font("Lato", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPurchaseDateOfferDetails.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lblPurchaseDateOfferDetails.Location = new System.Drawing.Point(45, 259);
            this.lblPurchaseDateOfferDetails.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblPurchaseDateOfferDetails.Name = "lblPurchaseDateOfferDetails";
            this.lblPurchaseDateOfferDetails.Size = new System.Drawing.Size(143, 18);
            this.lblPurchaseDateOfferDetails.TabIndex = 19;
            this.lblPurchaseDateOfferDetails.Text = "Plan to Purchase: ";
            // 
            // lblEmailOfferDetails
            // 
            this.lblEmailOfferDetails.AutoSize = true;
            this.lblEmailOfferDetails.Font = new System.Drawing.Font("Lato", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmailOfferDetails.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lblEmailOfferDetails.Location = new System.Drawing.Point(45, 216);
            this.lblEmailOfferDetails.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblEmailOfferDetails.Name = "lblEmailOfferDetails";
            this.lblEmailOfferDetails.Size = new System.Drawing.Size(59, 18);
            this.lblEmailOfferDetails.TabIndex = 18;
            this.lblEmailOfferDetails.Text = "Email :";
            // 
            // lblAmountOfferDetails
            // 
            this.lblAmountOfferDetails.AutoSize = true;
            this.lblAmountOfferDetails.Font = new System.Drawing.Font("Lato", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAmountOfferDetails.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lblAmountOfferDetails.Location = new System.Drawing.Point(45, 173);
            this.lblAmountOfferDetails.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblAmountOfferDetails.Name = "lblAmountOfferDetails";
            this.lblAmountOfferDetails.Size = new System.Drawing.Size(124, 18);
            this.lblAmountOfferDetails.TabIndex = 17;
            this.lblAmountOfferDetails.Text = "Offer Amount : ";
            // 
            // lblContactNumberOfferDetails
            // 
            this.lblContactNumberOfferDetails.AutoSize = true;
            this.lblContactNumberOfferDetails.Font = new System.Drawing.Font("Lato", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblContactNumberOfferDetails.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lblContactNumberOfferDetails.Location = new System.Drawing.Point(45, 130);
            this.lblContactNumberOfferDetails.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblContactNumberOfferDetails.Name = "lblContactNumberOfferDetails";
            this.lblContactNumberOfferDetails.Size = new System.Drawing.Size(102, 18);
            this.lblContactNumberOfferDetails.TabIndex = 16;
            this.lblContactNumberOfferDetails.Text = "Contact No :";
            // 
            // lblNameOfferDetails
            // 
            this.lblNameOfferDetails.AutoSize = true;
            this.lblNameOfferDetails.Font = new System.Drawing.Font("Lato", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNameOfferDetails.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lblNameOfferDetails.Location = new System.Drawing.Point(45, 87);
            this.lblNameOfferDetails.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblNameOfferDetails.Name = "lblNameOfferDetails";
            this.lblNameOfferDetails.Size = new System.Drawing.Size(141, 18);
            this.lblNameOfferDetails.TabIndex = 15;
            this.lblNameOfferDetails.Text = "Customer Name : ";
            // 
            // lblOfferDetails
            // 
            this.lblOfferDetails.AutoSize = true;
            this.lblOfferDetails.Font = new System.Drawing.Font("Lato", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOfferDetails.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lblOfferDetails.Location = new System.Drawing.Point(140, 24);
            this.lblOfferDetails.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblOfferDetails.Name = "lblOfferDetails";
            this.lblOfferDetails.Size = new System.Drawing.Size(185, 29);
            this.lblOfferDetails.TabIndex = 14;
            this.lblOfferDetails.Text = "Add New Offer";
            this.lblOfferDetails.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // btnAdd
            // 
            this.btnAdd.Activecolor = System.Drawing.Color.Gray;
            this.btnAdd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(57)))), ((int)(((byte)(58)))));
            this.btnAdd.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnAdd.BorderRadius = 1;
            this.btnAdd.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.btnAdd.ButtonText = "Add";
            this.btnAdd.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAdd.DisabledColor = System.Drawing.Color.Gray;
            this.btnAdd.Font = new System.Drawing.Font("Constantia", 12F, System.Drawing.FontStyle.Bold);
            this.btnAdd.ForeColor = System.Drawing.Color.Silver;
            this.btnAdd.Iconcolor = System.Drawing.Color.Transparent;
            this.btnAdd.Iconimage = null;
            this.btnAdd.Iconimage_right = null;
            this.btnAdd.Iconimage_right_Selected = null;
            this.btnAdd.Iconimage_Selected = null;
            this.btnAdd.IconMarginLeft = 0;
            this.btnAdd.IconMarginRight = 0;
            this.btnAdd.IconRightVisible = true;
            this.btnAdd.IconRightZoom = 0D;
            this.btnAdd.IconVisible = true;
            this.btnAdd.IconZoom = 50D;
            this.btnAdd.IsTab = false;
            this.btnAdd.Location = new System.Drawing.Point(97, 334);
            this.btnAdd.Margin = new System.Windows.Forms.Padding(2);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(57)))), ((int)(((byte)(58)))));
            this.btnAdd.OnHovercolor = System.Drawing.Color.Gray;
            this.btnAdd.OnHoverTextColor = System.Drawing.Color.White;
            this.btnAdd.Padding = new System.Windows.Forms.Padding(0, 50, 0, 0);
            this.btnAdd.selected = false;
            this.btnAdd.Size = new System.Drawing.Size(105, 35);
            this.btnAdd.TabIndex = 27;
            this.btnAdd.Text = "Add";
            this.btnAdd.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnAdd.Textcolor = System.Drawing.Color.White;
            this.btnAdd.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Activecolor = System.Drawing.Color.Gray;
            this.btnCancel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(57)))), ((int)(((byte)(58)))));
            this.btnCancel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnCancel.BorderRadius = 1;
            this.btnCancel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.btnCancel.ButtonText = "Cancel";
            this.btnCancel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCancel.DisabledColor = System.Drawing.Color.Gray;
            this.btnCancel.Font = new System.Drawing.Font("Constantia", 12F, System.Drawing.FontStyle.Bold);
            this.btnCancel.ForeColor = System.Drawing.Color.Silver;
            this.btnCancel.Iconcolor = System.Drawing.Color.Transparent;
            this.btnCancel.Iconimage = null;
            this.btnCancel.Iconimage_right = null;
            this.btnCancel.Iconimage_right_Selected = null;
            this.btnCancel.Iconimage_Selected = null;
            this.btnCancel.IconMarginLeft = 0;
            this.btnCancel.IconMarginRight = 0;
            this.btnCancel.IconRightVisible = true;
            this.btnCancel.IconRightZoom = 0D;
            this.btnCancel.IconVisible = true;
            this.btnCancel.IconZoom = 50D;
            this.btnCancel.IsTab = false;
            this.btnCancel.Location = new System.Drawing.Point(249, 334);
            this.btnCancel.Margin = new System.Windows.Forms.Padding(2);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(57)))), ((int)(((byte)(58)))));
            this.btnCancel.OnHovercolor = System.Drawing.Color.Gray;
            this.btnCancel.OnHoverTextColor = System.Drawing.Color.White;
            this.btnCancel.Padding = new System.Windows.Forms.Padding(0, 50, 0, 0);
            this.btnCancel.selected = false;
            this.btnCancel.Size = new System.Drawing.Size(105, 35);
            this.btnCancel.TabIndex = 28;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnCancel.Textcolor = System.Drawing.Color.White;
            this.btnCancel.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // OfferForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(49)))), ((int)(((byte)(82)))));
            this.ClientSize = new System.Drawing.Size(475, 416);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.dateToPurchase);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.txtAmount);
            this.Controls.Add(this.txtContactNo);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.lblPurchaseDateOfferDetails);
            this.Controls.Add(this.lblEmailOfferDetails);
            this.Controls.Add(this.lblAmountOfferDetails);
            this.Controls.Add(this.lblContactNumberOfferDetails);
            this.Controls.Add(this.lblNameOfferDetails);
            this.Controls.Add(this.lblOfferDetails);
            this.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "OfferForm";
            this.Text = "OfferForm";
            this.Load += new System.EventHandler(this.OfferForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DateTimePicker dateToPurchase;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.TextBox txtAmount;
        private System.Windows.Forms.TextBox txtContactNo;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label lblPurchaseDateOfferDetails;
        private System.Windows.Forms.Label lblEmailOfferDetails;
        private System.Windows.Forms.Label lblAmountOfferDetails;
        private System.Windows.Forms.Label lblContactNumberOfferDetails;
        private System.Windows.Forms.Label lblNameOfferDetails;
        private System.Windows.Forms.Label lblOfferDetails;
        private Bunifu.Framework.UI.BunifuFlatButton btnAdd;
        private Bunifu.Framework.UI.BunifuFlatButton btnCancel;
    }
}