namespace Nadeeshans_Car_Sale
{
    partial class ucSearchCars
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.lblYearofManufactureAllCarDetails = new System.Windows.Forms.Label();
            this.lblMakeAllCarDetails = new System.Windows.Forms.Label();
            this.lblModeAllCarDetails = new System.Windows.Forms.Label();
            this.dateManufactured = new System.Windows.Forms.DateTimePicker();
            this.cmbMake = new System.Windows.Forms.ComboBox();
            this.txtSearchAllCarDetails = new System.Windows.Forms.TextBox();
            this.dgridCarsAllCarDetails = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.btnSearchVehicles = new Bunifu.Framework.UI.BunifuFlatButton();
            this.cmbModel = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgridCarsAllCarDetails)).BeginInit();
            this.SuspendLayout();
            // 
            // lblYearofManufactureAllCarDetails
            // 
            this.lblYearofManufactureAllCarDetails.AutoSize = true;
            this.lblYearofManufactureAllCarDetails.Font = new System.Drawing.Font("Lato", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblYearofManufactureAllCarDetails.Location = new System.Drawing.Point(4, 70);
            this.lblYearofManufactureAllCarDetails.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblYearofManufactureAllCarDetails.Name = "lblYearofManufactureAllCarDetails";
            this.lblYearofManufactureAllCarDetails.Size = new System.Drawing.Size(125, 16);
            this.lblYearofManufactureAllCarDetails.TabIndex = 17;
            this.lblYearofManufactureAllCarDetails.Text = "Year of Manufacture";
            // 
            // lblMakeAllCarDetails
            // 
            this.lblMakeAllCarDetails.AutoSize = true;
            this.lblMakeAllCarDetails.Font = new System.Drawing.Font("Lato", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMakeAllCarDetails.Location = new System.Drawing.Point(619, 73);
            this.lblMakeAllCarDetails.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblMakeAllCarDetails.Name = "lblMakeAllCarDetails";
            this.lblMakeAllCarDetails.Size = new System.Drawing.Size(44, 16);
            this.lblMakeAllCarDetails.TabIndex = 16;
            this.lblMakeAllCarDetails.Text = "Model";
            // 
            // lblModeAllCarDetails
            // 
            this.lblModeAllCarDetails.AutoSize = true;
            this.lblModeAllCarDetails.Font = new System.Drawing.Font("Lato", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblModeAllCarDetails.Location = new System.Drawing.Point(389, 70);
            this.lblModeAllCarDetails.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblModeAllCarDetails.Name = "lblModeAllCarDetails";
            this.lblModeAllCarDetails.Size = new System.Drawing.Size(41, 16);
            this.lblModeAllCarDetails.TabIndex = 15;
            this.lblModeAllCarDetails.Text = "Make";
            // 
            // dateManufactured
            // 
            this.dateManufactured.Font = new System.Drawing.Font("Lato", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateManufactured.Location = new System.Drawing.Point(137, 68);
            this.dateManufactured.Margin = new System.Windows.Forms.Padding(4);
            this.dateManufactured.Name = "dateManufactured";
            this.dateManufactured.Size = new System.Drawing.Size(226, 23);
            this.dateManufactured.TabIndex = 14;
            this.dateManufactured.ValueChanged += new System.EventHandler(this.dateTimePickerYearofManufactureAllCarDetails_ValueChanged);
            // 
            // cmbMake
            // 
            this.cmbMake.BackColor = System.Drawing.SystemColors.Window;
            this.cmbMake.Enabled = false;
            this.cmbMake.Font = new System.Drawing.Font("Lato", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbMake.FormattingEnabled = true;
            this.cmbMake.Location = new System.Drawing.Point(441, 68);
            this.cmbMake.Margin = new System.Windows.Forms.Padding(4);
            this.cmbMake.Name = "cmbMake";
            this.cmbMake.Size = new System.Drawing.Size(151, 24);
            this.cmbMake.TabIndex = 12;
            this.cmbMake.SelectedIndexChanged += new System.EventHandler(this.cmbModeAllCarDetails_SelectedIndexChanged);
            // 
            // txtSearchAllCarDetails
            // 
            this.txtSearchAllCarDetails.Font = new System.Drawing.Font("Lato", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSearchAllCarDetails.Location = new System.Drawing.Point(137, 19);
            this.txtSearchAllCarDetails.Margin = new System.Windows.Forms.Padding(4);
            this.txtSearchAllCarDetails.Name = "txtSearchAllCarDetails";
            this.txtSearchAllCarDetails.Size = new System.Drawing.Size(586, 25);
            this.txtSearchAllCarDetails.TabIndex = 10;
            this.txtSearchAllCarDetails.TextChanged += new System.EventHandler(this.txtSearchAllCarDetails_TextChanged);
            // 
            // dgridCarsAllCarDetails
            // 
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Lato", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgridCarsAllCarDetails.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgridCarsAllCarDetails.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgridCarsAllCarDetails.Location = new System.Drawing.Point(16, 121);
            this.dgridCarsAllCarDetails.Margin = new System.Windows.Forms.Padding(4);
            this.dgridCarsAllCarDetails.Name = "dgridCarsAllCarDetails";
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Lato", 8.999999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgridCarsAllCarDetails.RowHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgridCarsAllCarDetails.Size = new System.Drawing.Size(819, 482);
            this.dgridCarsAllCarDetails.TabIndex = 9;
            this.dgridCarsAllCarDetails.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewCarsAllCarDetails_CellContentClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Lato", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(4, 24);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(116, 16);
            this.label1.TabIndex = 18;
            this.label1.Text = "Search for Vehicles";
            // 
            // btnSearchVehicles
            // 
            this.btnSearchVehicles.Activecolor = System.Drawing.Color.Gray;
            this.btnSearchVehicles.BackColor = System.Drawing.Color.DimGray;
            this.btnSearchVehicles.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnSearchVehicles.BorderRadius = 0;
            this.btnSearchVehicles.ButtonText = "OK";
            this.btnSearchVehicles.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSearchVehicles.DisabledColor = System.Drawing.Color.DimGray;
            this.btnSearchVehicles.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearchVehicles.ForeColor = System.Drawing.Color.White;
            this.btnSearchVehicles.Iconcolor = System.Drawing.Color.Transparent;
            this.btnSearchVehicles.Iconimage = null;
            this.btnSearchVehicles.Iconimage_right = null;
            this.btnSearchVehicles.Iconimage_right_Selected = null;
            this.btnSearchVehicles.Iconimage_Selected = null;
            this.btnSearchVehicles.IconMarginLeft = 0;
            this.btnSearchVehicles.IconMarginRight = 0;
            this.btnSearchVehicles.IconRightVisible = true;
            this.btnSearchVehicles.IconRightZoom = 0D;
            this.btnSearchVehicles.IconVisible = true;
            this.btnSearchVehicles.IconZoom = 90D;
            this.btnSearchVehicles.IsTab = false;
            this.btnSearchVehicles.Location = new System.Drawing.Point(730, 20);
            this.btnSearchVehicles.Name = "btnSearchVehicles";
            this.btnSearchVehicles.Normalcolor = System.Drawing.Color.DimGray;
            this.btnSearchVehicles.OnHovercolor = System.Drawing.Color.Gray;
            this.btnSearchVehicles.OnHoverTextColor = System.Drawing.Color.White;
            this.btnSearchVehicles.selected = false;
            this.btnSearchVehicles.Size = new System.Drawing.Size(55, 24);
            this.btnSearchVehicles.TabIndex = 19;
            this.btnSearchVehicles.Text = "OK";
            this.btnSearchVehicles.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnSearchVehicles.Textcolor = System.Drawing.Color.Gainsboro;
            this.btnSearchVehicles.TextFont = new System.Drawing.Font("Lato", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            // 
            // cmbModel
            // 
            this.cmbModel.Font = new System.Drawing.Font("Lato", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbModel.FormattingEnabled = true;
            this.cmbModel.Location = new System.Drawing.Point(668, 70);
            this.cmbModel.Margin = new System.Windows.Forms.Padding(4);
            this.cmbModel.Name = "cmbModel";
            this.cmbModel.Size = new System.Drawing.Size(167, 24);
            this.cmbModel.TabIndex = 13;
            this.cmbModel.SelectedIndexChanged += new System.EventHandler(this.cmbMakeAllCarDetails_SelectedIndexChanged);
            // 
            // ucSearchCars
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Transparent;
            this.Controls.Add(this.btnSearchVehicles);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblYearofManufactureAllCarDetails);
            this.Controls.Add(this.lblMakeAllCarDetails);
            this.Controls.Add(this.lblModeAllCarDetails);
            this.Controls.Add(this.dateManufactured);
            this.Controls.Add(this.cmbModel);
            this.Controls.Add(this.cmbMake);
            this.Controls.Add(this.txtSearchAllCarDetails);
            this.Controls.Add(this.dgridCarsAllCarDetails);
            this.Name = "ucSearchCars";
            this.Size = new System.Drawing.Size(857, 633);
            this.Load += new System.EventHandler(this.ucSearchCars_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgridCarsAllCarDetails)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblYearofManufactureAllCarDetails;
        private System.Windows.Forms.Label lblMakeAllCarDetails;
        private System.Windows.Forms.Label lblModeAllCarDetails;
        private System.Windows.Forms.DateTimePicker dateManufactured;
        private System.Windows.Forms.ComboBox cmbMake;
        private System.Windows.Forms.TextBox txtSearchAllCarDetails;
        private System.Windows.Forms.DataGridView dgridCarsAllCarDetails;
        private System.Windows.Forms.Label label1;
        private Bunifu.Framework.UI.BunifuFlatButton btnSearchVehicles;
        private System.Windows.Forms.ComboBox cmbModel;
    }
}
