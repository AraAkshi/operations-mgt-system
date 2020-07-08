using System;

namespace Nadeeshans_Car_Sale
{
    partial class ucVehicleDetails
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
            this.txtVehicleRegNo = new System.Windows.Forms.TextBox();
            this.cmbVehicleStatus = new System.Windows.Forms.ComboBox();
            this.cmbModel = new System.Windows.Forms.ComboBox();
            this.txtVehicleMileage = new System.Windows.Forms.TextBox();
            this.txtChassisNo = new System.Windows.Forms.TextBox();
            this.lblkm = new System.Windows.Forms.Label();
            this.txtEngineNo = new System.Windows.Forms.TextBox();
            this.txtCylinderCapacity = new System.Windows.Forms.TextBox();
            this.cmbFuelType = new System.Windows.Forms.ComboBox();
            this.cmbTransmissionGear = new System.Windows.Forms.ComboBox();
            this.dateFirstRegDate = new System.Windows.Forms.DateTimePicker();
            this.dateInsurance = new System.Windows.Forms.DateTimePicker();
            this.dateLastService = new System.Windows.Forms.DateTimePicker();
            this.yearManufacture = new System.Windows.Forms.DateTimePicker();
            this.lbllkr = new System.Windows.Forms.Label();
            this.txtVehiclePrice = new System.Windows.Forms.TextBox();
            this.txtSpecialNotes = new System.Windows.Forms.TextBox();
            this.lblRegistrationNo = new System.Windows.Forms.Label();
            this.lblVehicleDetails = new System.Windows.Forms.Label();
            this.lblVehicleMake = new System.Windows.Forms.Label();
            this.lblmodels = new System.Windows.Forms.Label();
            this.lblmileage = new System.Windows.Forms.Label();
            this.lblchassisno = new System.Windows.Forms.Label();
            this.lblengineno = new System.Windows.Forms.Label();
            this.lblcylindercapacity = new System.Windows.Forms.Label();
            this.lblfueltype = new System.Windows.Forms.Label();
            this.lbltransmissiongear = new System.Windows.Forms.Label();
            this.lblseatingcapacity = new System.Windows.Forms.Label();
            this.countPreviousOwner = new System.Windows.Forms.NumericUpDown();
            this.lblcountryoforigin = new System.Windows.Forms.Label();
            this.cmbOriginCountry = new System.Windows.Forms.ComboBox();
            this.lblfirstregistrationdate = new System.Windows.Forms.Label();
            this.lblinsurancedate = new System.Windows.Forms.Label();
            this.lblnoofservicesdone = new System.Windows.Forms.Label();
            this.countServicesDone = new System.Windows.Forms.NumericUpDown();
            this.lblservicedate = new System.Windows.Forms.Label();
            this.lblpreviousowners = new System.Windows.Forms.Label();
            this.countSeatingCapacity = new System.Windows.Forms.NumericUpDown();
            this.lblyearofmanufacture = new System.Windows.Forms.Label();
            this.lblprice = new System.Windows.Forms.Label();
            this.lblspecialnotes = new System.Windows.Forms.Label();
            this.lblvechile = new System.Windows.Forms.Label();
            this.grpboxVehicleImages = new System.Windows.Forms.GroupBox();
            this.picBoxTwo = new System.Windows.Forms.PictureBox();
            this.picBoxThree = new System.Windows.Forms.PictureBox();
            this.picBoxFour = new System.Windows.Forms.PictureBox();
            this.picBoxSix = new System.Windows.Forms.PictureBox();
            this.picBoxSeven = new System.Windows.Forms.PictureBox();
            this.picBoxEight = new System.Windows.Forms.PictureBox();
            this.picBoxNine = new System.Windows.Forms.PictureBox();
            this.picBoxFive = new System.Windows.Forms.PictureBox();
            this.picBoxOne = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtInsuranceCompany = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtInsuranceType = new System.Windows.Forms.TextBox();
            this.txtMake = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btnCancel = new Bunifu.Framework.UI.BunifuFlatButton();
            this.label4 = new System.Windows.Forms.Label();
            this.txtColor = new System.Windows.Forms.TextBox();
            this.btnViewMore = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btnBack = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btnEdit = new Bunifu.Framework.UI.BunifuFlatButton();
            ((System.ComponentModel.ISupportInitialize)(this.countPreviousOwner)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.countServicesDone)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.countSeatingCapacity)).BeginInit();
            this.grpboxVehicleImages.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxTwo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxThree)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxFour)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxSix)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxSeven)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxEight)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxNine)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxFive)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxOne)).BeginInit();
            this.SuspendLayout();
            // 
            // txtVehicleRegNo
            // 
            this.txtVehicleRegNo.Location = new System.Drawing.Point(178, 44);
            this.txtVehicleRegNo.Name = "txtVehicleRegNo";
            this.txtVehicleRegNo.Size = new System.Drawing.Size(223, 20);
            this.txtVehicleRegNo.TabIndex = 5;
            this.txtVehicleRegNo.TextChanged += new System.EventHandler(this.txtVehicleRegNo_TextChanged_1);
            // 
            // cmbVehicleStatus
            // 
            this.cmbVehicleStatus.FormattingEnabled = true;
            this.cmbVehicleStatus.Items.AddRange(new object[] {
            "--",
            "RECONDITIONED",
            "USED",
            "BRAND NEW"});
            this.cmbVehicleStatus.Location = new System.Drawing.Point(178, 144);
            this.cmbVehicleStatus.Name = "cmbVehicleStatus";
            this.cmbVehicleStatus.Size = new System.Drawing.Size(222, 21);
            this.cmbVehicleStatus.TabIndex = 7;
            this.cmbVehicleStatus.SelectedIndexChanged += new System.EventHandler(this.cmbVehicleStatus_SelectedIndexChanged);
            // 
            // cmbModel
            // 
            this.cmbModel.FormattingEnabled = true;
            this.cmbModel.Items.AddRange(new object[] {
            "--",
            "TOYOTA",
            "HONDA",
            "SUZUKI",
            "AUDI",
            "NISSAN",
            "MITSUBISHI",
            "BMW",
            "DATSUN",
            "TESLA",
            "MICRO",
            "MERCEDES-BENZ",
            "TATA",
            "LAND ROVER",
            "MAZDA"});
            this.cmbModel.Location = new System.Drawing.Point(178, 108);
            this.cmbModel.Name = "cmbModel";
            this.cmbModel.Size = new System.Drawing.Size(222, 21);
            this.cmbModel.TabIndex = 9;
            this.cmbModel.SelectedIndexChanged += new System.EventHandler(this.cmbModel_SelectedIndexChanged);
            // 
            // txtVehicleMileage
            // 
            this.txtVehicleMileage.Location = new System.Drawing.Point(177, 241);
            this.txtVehicleMileage.Name = "txtVehicleMileage";
            this.txtVehicleMileage.Size = new System.Drawing.Size(224, 20);
            this.txtVehicleMileage.TabIndex = 13;
            this.txtVehicleMileage.TextChanged += new System.EventHandler(this.txtVehicleMileage_TextChanged);
            // 
            // txtChassisNo
            // 
            this.txtChassisNo.Location = new System.Drawing.Point(177, 277);
            this.txtChassisNo.Name = "txtChassisNo";
            this.txtChassisNo.Size = new System.Drawing.Size(224, 20);
            this.txtChassisNo.TabIndex = 15;
            this.txtChassisNo.TextChanged += new System.EventHandler(this.txtChassisNo_TextChanged);
            // 
            // lblkm
            // 
            this.lblkm.AutoSize = true;
            this.lblkm.Font = new System.Drawing.Font("Lato", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblkm.Location = new System.Drawing.Point(404, 241);
            this.lblkm.Name = "lblkm";
            this.lblkm.Size = new System.Drawing.Size(26, 16);
            this.lblkm.TabIndex = 17;
            this.lblkm.Text = "km";
            this.lblkm.Click += new System.EventHandler(this.lblkm_Click);
            // 
            // txtEngineNo
            // 
            this.txtEngineNo.Location = new System.Drawing.Point(177, 310);
            this.txtEngineNo.Name = "txtEngineNo";
            this.txtEngineNo.Size = new System.Drawing.Size(224, 20);
            this.txtEngineNo.TabIndex = 18;
            this.txtEngineNo.TextChanged += new System.EventHandler(this.txtEngineNo_TextChanged);
            // 
            // txtCylinderCapacity
            // 
            this.txtCylinderCapacity.Location = new System.Drawing.Point(176, 345);
            this.txtCylinderCapacity.Name = "txtCylinderCapacity";
            this.txtCylinderCapacity.Size = new System.Drawing.Size(225, 20);
            this.txtCylinderCapacity.TabIndex = 20;
            this.txtCylinderCapacity.TextChanged += new System.EventHandler(this.txtCylinderCapacity_TextChanged);
            // 
            // cmbFuelType
            // 
            this.cmbFuelType.FormattingEnabled = true;
            this.cmbFuelType.Items.AddRange(new object[] {
            "--",
            "DIESEL",
            "PETROL-HYBRID",
            "DIESEL-HYBRID",
            "PLUGIN-HYBRID",
            "ELECTRIC",
            "PETROL"});
            this.cmbFuelType.Location = new System.Drawing.Point(177, 176);
            this.cmbFuelType.Name = "cmbFuelType";
            this.cmbFuelType.Size = new System.Drawing.Size(224, 21);
            this.cmbFuelType.TabIndex = 22;
            this.cmbFuelType.SelectedIndexChanged += new System.EventHandler(this.cmbFuelType_SelectedIndexChanged);
            // 
            // cmbTransmissionGear
            // 
            this.cmbTransmissionGear.FormattingEnabled = true;
            this.cmbTransmissionGear.Items.AddRange(new object[] {
            "--",
            "AUTO",
            "MANUAL",
            "TIPTRONIC"});
            this.cmbTransmissionGear.Location = new System.Drawing.Point(176, 207);
            this.cmbTransmissionGear.Name = "cmbTransmissionGear";
            this.cmbTransmissionGear.Size = new System.Drawing.Size(225, 21);
            this.cmbTransmissionGear.TabIndex = 24;
            this.cmbTransmissionGear.SelectedIndexChanged += new System.EventHandler(this.cmbTransmissionGear_SelectedIndexChanged);
            // 
            // dateFirstRegDate
            // 
            this.dateFirstRegDate.Location = new System.Drawing.Point(628, 43);
            this.dateFirstRegDate.Name = "dateFirstRegDate";
            this.dateFirstRegDate.Size = new System.Drawing.Size(200, 20);
            this.dateFirstRegDate.TabIndex = 29;
            this.dateFirstRegDate.ValueChanged += new System.EventHandler(this.dateFirstRegDate_ValueChanged);
            // 
            // dateInsurance
            // 
            this.dateInsurance.Location = new System.Drawing.Point(628, 189);
            this.dateInsurance.Name = "dateInsurance";
            this.dateInsurance.Size = new System.Drawing.Size(200, 20);
            this.dateInsurance.TabIndex = 30;
            this.dateInsurance.ValueChanged += new System.EventHandler(this.dateInsurance_ValueChanged);
            // 
            // dateLastService
            // 
            this.dateLastService.Location = new System.Drawing.Point(628, 131);
            this.dateLastService.Name = "dateLastService";
            this.dateLastService.Size = new System.Drawing.Size(200, 20);
            this.dateLastService.TabIndex = 34;
            this.dateLastService.ValueChanged += new System.EventHandler(this.dateLastService_ValueChanged);
            // 
            // yearManufacture
            // 
            this.yearManufacture.Location = new System.Drawing.Point(628, 161);
            this.yearManufacture.Name = "yearManufacture";
            this.yearManufacture.Size = new System.Drawing.Size(200, 20);
            this.yearManufacture.TabIndex = 35;
            this.yearManufacture.ValueChanged += new System.EventHandler(this.yearManufacture_ValueChanged);
            // 
            // lbllkr
            // 
            this.lbllkr.AutoSize = true;
            this.lbllkr.BackColor = System.Drawing.Color.Transparent;
            this.lbllkr.Font = new System.Drawing.Font("Lato", 9.749999F);
            this.lbllkr.ForeColor = System.Drawing.Color.Black;
            this.lbllkr.Location = new System.Drawing.Point(784, 569);
            this.lbllkr.Name = "lbllkr";
            this.lbllkr.Size = new System.Drawing.Size(32, 16);
            this.lbllkr.TabIndex = 38;
            this.lbllkr.Text = "LKR";
            this.lbllkr.Click += new System.EventHandler(this.lbllkr_Click);
            // 
            // txtVehiclePrice
            // 
            this.txtVehiclePrice.Location = new System.Drawing.Point(506, 568);
            this.txtVehiclePrice.Name = "txtVehiclePrice";
            this.txtVehiclePrice.Size = new System.Drawing.Size(274, 20);
            this.txtVehiclePrice.TabIndex = 39;
            this.txtVehiclePrice.TextChanged += new System.EventHandler(this.txtVehiclePrice_TextChanged);
            // 
            // txtSpecialNotes
            // 
            this.txtSpecialNotes.Location = new System.Drawing.Point(175, 545);
            this.txtSpecialNotes.Multiline = true;
            this.txtSpecialNotes.Name = "txtSpecialNotes";
            this.txtSpecialNotes.Size = new System.Drawing.Size(226, 69);
            this.txtSpecialNotes.TabIndex = 40;
            this.txtSpecialNotes.TextChanged += new System.EventHandler(this.txtSpecialNotes_TextChanged);
            // 
            // lblRegistrationNo
            // 
            this.lblRegistrationNo.AutoSize = true;
            this.lblRegistrationNo.BackColor = System.Drawing.Color.Transparent;
            this.lblRegistrationNo.Font = new System.Drawing.Font("Lato", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRegistrationNo.ForeColor = System.Drawing.Color.Black;
            this.lblRegistrationNo.Location = new System.Drawing.Point(2, 41);
            this.lblRegistrationNo.Name = "lblRegistrationNo";
            this.lblRegistrationNo.Size = new System.Drawing.Size(118, 19);
            this.lblRegistrationNo.TabIndex = 42;
            this.lblRegistrationNo.Text = "Registration No";
            this.lblRegistrationNo.Click += new System.EventHandler(this.lblRegistrationNo_Click);
            // 
            // lblVehicleDetails
            // 
            this.lblVehicleDetails.AutoSize = true;
            this.lblVehicleDetails.BackColor = System.Drawing.Color.Transparent;
            this.lblVehicleDetails.Font = new System.Drawing.Font("Lato", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblVehicleDetails.ForeColor = System.Drawing.Color.Black;
            this.lblVehicleDetails.Location = new System.Drawing.Point(2, 142);
            this.lblVehicleDetails.Name = "lblVehicleDetails";
            this.lblVehicleDetails.Size = new System.Drawing.Size(106, 19);
            this.lblVehicleDetails.TabIndex = 43;
            this.lblVehicleDetails.Text = "Vehicle Status";
            this.lblVehicleDetails.Click += new System.EventHandler(this.lblVehicleDetails_Click);
            // 
            // lblVehicleMake
            // 
            this.lblVehicleMake.AutoSize = true;
            this.lblVehicleMake.BackColor = System.Drawing.Color.Transparent;
            this.lblVehicleMake.Font = new System.Drawing.Font("Lato", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblVehicleMake.ForeColor = System.Drawing.Color.Black;
            this.lblVehicleMake.Location = new System.Drawing.Point(2, 72);
            this.lblVehicleMake.Name = "lblVehicleMake";
            this.lblVehicleMake.Size = new System.Drawing.Size(48, 19);
            this.lblVehicleMake.TabIndex = 44;
            this.lblVehicleMake.Text = "Make";
            this.lblVehicleMake.Click += new System.EventHandler(this.lblVehicleMake_Click);
            // 
            // lblmodels
            // 
            this.lblmodels.AutoSize = true;
            this.lblmodels.BackColor = System.Drawing.Color.Transparent;
            this.lblmodels.Font = new System.Drawing.Font("Lato", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblmodels.ForeColor = System.Drawing.Color.Black;
            this.lblmodels.Location = new System.Drawing.Point(2, 106);
            this.lblmodels.Name = "lblmodels";
            this.lblmodels.Size = new System.Drawing.Size(54, 19);
            this.lblmodels.TabIndex = 45;
            this.lblmodels.Text = "Model";
            this.lblmodels.Click += new System.EventHandler(this.lblmodels_Click);
            // 
            // lblmileage
            // 
            this.lblmileage.AutoSize = true;
            this.lblmileage.BackColor = System.Drawing.Color.Transparent;
            this.lblmileage.Font = new System.Drawing.Font("Lato", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblmileage.ForeColor = System.Drawing.Color.Black;
            this.lblmileage.Location = new System.Drawing.Point(3, 238);
            this.lblmileage.Name = "lblmileage";
            this.lblmileage.Size = new System.Drawing.Size(64, 19);
            this.lblmileage.TabIndex = 47;
            this.lblmileage.Text = "Mileage";
            this.lblmileage.Click += new System.EventHandler(this.lblmileage_Click);
            // 
            // lblchassisno
            // 
            this.lblchassisno.AutoSize = true;
            this.lblchassisno.BackColor = System.Drawing.Color.Transparent;
            this.lblchassisno.Font = new System.Drawing.Font("Lato", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblchassisno.ForeColor = System.Drawing.Color.Black;
            this.lblchassisno.Location = new System.Drawing.Point(2, 275);
            this.lblchassisno.Name = "lblchassisno";
            this.lblchassisno.Size = new System.Drawing.Size(86, 19);
            this.lblchassisno.TabIndex = 48;
            this.lblchassisno.Text = "Chassis No";
            this.lblchassisno.Click += new System.EventHandler(this.lblchassisno_Click);
            // 
            // lblengineno
            // 
            this.lblengineno.AutoSize = true;
            this.lblengineno.BackColor = System.Drawing.Color.Transparent;
            this.lblengineno.Font = new System.Drawing.Font("Lato", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblengineno.ForeColor = System.Drawing.Color.Black;
            this.lblengineno.Location = new System.Drawing.Point(3, 308);
            this.lblengineno.Name = "lblengineno";
            this.lblengineno.Size = new System.Drawing.Size(80, 19);
            this.lblengineno.TabIndex = 49;
            this.lblengineno.Text = "Engine No";
            this.lblengineno.Click += new System.EventHandler(this.lblengineno_Click);
            // 
            // lblcylindercapacity
            // 
            this.lblcylindercapacity.AutoSize = true;
            this.lblcylindercapacity.BackColor = System.Drawing.Color.Transparent;
            this.lblcylindercapacity.Font = new System.Drawing.Font("Lato", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblcylindercapacity.ForeColor = System.Drawing.Color.Black;
            this.lblcylindercapacity.Location = new System.Drawing.Point(3, 343);
            this.lblcylindercapacity.Name = "lblcylindercapacity";
            this.lblcylindercapacity.Size = new System.Drawing.Size(132, 19);
            this.lblcylindercapacity.TabIndex = 50;
            this.lblcylindercapacity.Text = "Cylinder Capacity";
            this.lblcylindercapacity.Click += new System.EventHandler(this.lblcylindercapacity_Click);
            // 
            // lblfueltype
            // 
            this.lblfueltype.AutoSize = true;
            this.lblfueltype.BackColor = System.Drawing.Color.Transparent;
            this.lblfueltype.Font = new System.Drawing.Font("Lato", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblfueltype.ForeColor = System.Drawing.Color.Black;
            this.lblfueltype.Location = new System.Drawing.Point(3, 174);
            this.lblfueltype.Name = "lblfueltype";
            this.lblfueltype.Size = new System.Drawing.Size(75, 19);
            this.lblfueltype.TabIndex = 51;
            this.lblfueltype.Text = "Fuel Type";
            this.lblfueltype.Click += new System.EventHandler(this.lblfueltype_Click);
            // 
            // lbltransmissiongear
            // 
            this.lbltransmissiongear.AutoSize = true;
            this.lbltransmissiongear.BackColor = System.Drawing.Color.Transparent;
            this.lbltransmissiongear.Font = new System.Drawing.Font("Lato", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbltransmissiongear.ForeColor = System.Drawing.Color.Black;
            this.lbltransmissiongear.Location = new System.Drawing.Point(2, 205);
            this.lbltransmissiongear.Name = "lbltransmissiongear";
            this.lbltransmissiongear.Size = new System.Drawing.Size(137, 19);
            this.lbltransmissiongear.TabIndex = 52;
            this.lbltransmissiongear.Text = "Transmission Gear";
            this.lbltransmissiongear.Click += new System.EventHandler(this.lbltransmissiongear_Click);
            // 
            // lblseatingcapacity
            // 
            this.lblseatingcapacity.AutoSize = true;
            this.lblseatingcapacity.BackColor = System.Drawing.Color.Transparent;
            this.lblseatingcapacity.Font = new System.Drawing.Font("Lato", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblseatingcapacity.ForeColor = System.Drawing.Color.Black;
            this.lblseatingcapacity.Location = new System.Drawing.Point(2, 479);
            this.lblseatingcapacity.Name = "lblseatingcapacity";
            this.lblseatingcapacity.Size = new System.Drawing.Size(124, 19);
            this.lblseatingcapacity.TabIndex = 53;
            this.lblseatingcapacity.Text = "Seating Capacity";
            this.lblseatingcapacity.Click += new System.EventHandler(this.lblseatingcapacity_Click);
            // 
            // countPreviousOwner
            // 
            this.countPreviousOwner.Location = new System.Drawing.Point(175, 447);
            this.countPreviousOwner.Name = "countPreviousOwner";
            this.countPreviousOwner.Size = new System.Drawing.Size(226, 20);
            this.countPreviousOwner.TabIndex = 54;
            this.countPreviousOwner.ValueChanged += new System.EventHandler(this.countPreviousOwner_ValueChanged);
            // 
            // lblcountryoforigin
            // 
            this.lblcountryoforigin.AutoSize = true;
            this.lblcountryoforigin.BackColor = System.Drawing.Color.Transparent;
            this.lblcountryoforigin.Font = new System.Drawing.Font("Lato", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblcountryoforigin.ForeColor = System.Drawing.Color.Black;
            this.lblcountryoforigin.Location = new System.Drawing.Point(3, 381);
            this.lblcountryoforigin.Name = "lblcountryoforigin";
            this.lblcountryoforigin.Size = new System.Drawing.Size(131, 19);
            this.lblcountryoforigin.TabIndex = 55;
            this.lblcountryoforigin.Text = "Country of Origin";
            this.lblcountryoforigin.Click += new System.EventHandler(this.lblcountryoforigin_Click);
            // 
            // cmbOriginCountry
            // 
            this.cmbOriginCountry.FormattingEnabled = true;
            this.cmbOriginCountry.Items.AddRange(new object[] {
            "CHINA",
            "JAPAN",
            "UNITED STATES",
            "KOREA",
            "GERMAN",
            "UNITED KINGDOM",
            "INDIA",
            "MALAYSIA",
            "ITALY",
            "FRANCE",
            "SRI LANKA"});
            this.cmbOriginCountry.Location = new System.Drawing.Point(176, 383);
            this.cmbOriginCountry.Name = "cmbOriginCountry";
            this.cmbOriginCountry.Size = new System.Drawing.Size(225, 21);
            this.cmbOriginCountry.TabIndex = 56;
            this.cmbOriginCountry.SelectedIndexChanged += new System.EventHandler(this.cmbOriginCountry_SelectedIndexChanged);
            // 
            // lblfirstregistrationdate
            // 
            this.lblfirstregistrationdate.AutoSize = true;
            this.lblfirstregistrationdate.BackColor = System.Drawing.Color.Transparent;
            this.lblfirstregistrationdate.Font = new System.Drawing.Font("Lato", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblfirstregistrationdate.ForeColor = System.Drawing.Color.Black;
            this.lblfirstregistrationdate.Location = new System.Drawing.Point(451, 45);
            this.lblfirstregistrationdate.Name = "lblfirstregistrationdate";
            this.lblfirstregistrationdate.Size = new System.Drawing.Size(166, 19);
            this.lblfirstregistrationdate.TabIndex = 57;
            this.lblfirstregistrationdate.Text = "First Registration Date";
            this.lblfirstregistrationdate.Click += new System.EventHandler(this.lblfirstregistrationdate_Click);
            // 
            // lblinsurancedate
            // 
            this.lblinsurancedate.AutoSize = true;
            this.lblinsurancedate.BackColor = System.Drawing.Color.Transparent;
            this.lblinsurancedate.Font = new System.Drawing.Font("Lato", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblinsurancedate.ForeColor = System.Drawing.Color.Black;
            this.lblinsurancedate.Location = new System.Drawing.Point(452, 190);
            this.lblinsurancedate.Name = "lblinsurancedate";
            this.lblinsurancedate.Size = new System.Drawing.Size(127, 19);
            this.lblinsurancedate.TabIndex = 58;
            this.lblinsurancedate.Text = "Last Service Date";
            this.lblinsurancedate.Click += new System.EventHandler(this.lblinsurancedate_Click);
            // 
            // lblnoofservicesdone
            // 
            this.lblnoofservicesdone.AutoSize = true;
            this.lblnoofservicesdone.BackColor = System.Drawing.Color.Transparent;
            this.lblnoofservicesdone.Font = new System.Drawing.Font("Lato", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblnoofservicesdone.ForeColor = System.Drawing.Color.Black;
            this.lblnoofservicesdone.Location = new System.Drawing.Point(2, 514);
            this.lblnoofservicesdone.Name = "lblnoofservicesdone";
            this.lblnoofservicesdone.Size = new System.Drawing.Size(147, 19);
            this.lblnoofservicesdone.TabIndex = 59;
            this.lblnoofservicesdone.Text = "No of Services Done";
            this.lblnoofservicesdone.Click += new System.EventHandler(this.lblnoofservicesdone_Click);
            // 
            // countServicesDone
            // 
            this.countServicesDone.Location = new System.Drawing.Point(175, 513);
            this.countServicesDone.Name = "countServicesDone";
            this.countServicesDone.Size = new System.Drawing.Size(226, 20);
            this.countServicesDone.TabIndex = 60;
            this.countServicesDone.ValueChanged += new System.EventHandler(this.countServicesDone_ValueChanged);
            // 
            // lblservicedate
            // 
            this.lblservicedate.AutoSize = true;
            this.lblservicedate.BackColor = System.Drawing.Color.Transparent;
            this.lblservicedate.Font = new System.Drawing.Font("Lato", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblservicedate.ForeColor = System.Drawing.Color.Black;
            this.lblservicedate.Location = new System.Drawing.Point(452, 132);
            this.lblservicedate.Name = "lblservicedate";
            this.lblservicedate.Size = new System.Drawing.Size(114, 19);
            this.lblservicedate.TabIndex = 61;
            this.lblservicedate.Text = "Insurance Date";
            this.lblservicedate.Click += new System.EventHandler(this.lblservicedate_Click);
            // 
            // lblpreviousowners
            // 
            this.lblpreviousowners.AutoSize = true;
            this.lblpreviousowners.BackColor = System.Drawing.Color.Transparent;
            this.lblpreviousowners.Font = new System.Drawing.Font("Lato", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblpreviousowners.ForeColor = System.Drawing.Color.Black;
            this.lblpreviousowners.Location = new System.Drawing.Point(2, 444);
            this.lblpreviousowners.Name = "lblpreviousowners";
            this.lblpreviousowners.Size = new System.Drawing.Size(168, 19);
            this.lblpreviousowners.TabIndex = 62;
            this.lblpreviousowners.Text = "Previous Owner Count";
            this.lblpreviousowners.Click += new System.EventHandler(this.lblpreviousowners_Click);
            // 
            // countSeatingCapacity
            // 
            this.countSeatingCapacity.Location = new System.Drawing.Point(175, 482);
            this.countSeatingCapacity.Name = "countSeatingCapacity";
            this.countSeatingCapacity.Size = new System.Drawing.Size(226, 20);
            this.countSeatingCapacity.TabIndex = 63;
            this.countSeatingCapacity.ValueChanged += new System.EventHandler(this.countSeatingCapacity_ValueChanged);
            // 
            // lblyearofmanufacture
            // 
            this.lblyearofmanufacture.AutoSize = true;
            this.lblyearofmanufacture.BackColor = System.Drawing.Color.Transparent;
            this.lblyearofmanufacture.Font = new System.Drawing.Font("Lato", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblyearofmanufacture.ForeColor = System.Drawing.Color.Black;
            this.lblyearofmanufacture.Location = new System.Drawing.Point(452, 162);
            this.lblyearofmanufacture.Name = "lblyearofmanufacture";
            this.lblyearofmanufacture.Size = new System.Drawing.Size(150, 19);
            this.lblyearofmanufacture.TabIndex = 64;
            this.lblyearofmanufacture.Text = "Year of Manufacture";
            this.lblyearofmanufacture.Click += new System.EventHandler(this.lblyearofmanufacture_Click);
            // 
            // lblprice
            // 
            this.lblprice.AutoSize = true;
            this.lblprice.BackColor = System.Drawing.Color.Transparent;
            this.lblprice.Font = new System.Drawing.Font("Lato", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblprice.ForeColor = System.Drawing.Color.Black;
            this.lblprice.Location = new System.Drawing.Point(456, 569);
            this.lblprice.Name = "lblprice";
            this.lblprice.Size = new System.Drawing.Size(44, 19);
            this.lblprice.TabIndex = 65;
            this.lblprice.Text = "Price";
            this.lblprice.Click += new System.EventHandler(this.lblprice_Click);
            // 
            // lblspecialnotes
            // 
            this.lblspecialnotes.AutoSize = true;
            this.lblspecialnotes.BackColor = System.Drawing.Color.Transparent;
            this.lblspecialnotes.Font = new System.Drawing.Font("Lato", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblspecialnotes.ForeColor = System.Drawing.Color.Black;
            this.lblspecialnotes.Location = new System.Drawing.Point(3, 545);
            this.lblspecialnotes.Name = "lblspecialnotes";
            this.lblspecialnotes.Size = new System.Drawing.Size(99, 19);
            this.lblspecialnotes.TabIndex = 66;
            this.lblspecialnotes.Text = "Special notes";
            this.lblspecialnotes.Click += new System.EventHandler(this.lblspecialnotes_Click);
            // 
            // lblvechile
            // 
            this.lblvechile.AutoSize = true;
            this.lblvechile.BackColor = System.Drawing.Color.Transparent;
            this.lblvechile.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblvechile.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(57)))), ((int)(((byte)(58)))));
            this.lblvechile.Location = new System.Drawing.Point(377, 10);
            this.lblvechile.Name = "lblvechile";
            this.lblvechile.Size = new System.Drawing.Size(134, 18);
            this.lblvechile.TabIndex = 67;
            this.lblvechile.Text = "Vehicle Details";
            this.lblvechile.Click += new System.EventHandler(this.lblvechile_Click);
            // 
            // grpboxVehicleImages
            // 
            this.grpboxVehicleImages.Controls.Add(this.picBoxTwo);
            this.grpboxVehicleImages.Controls.Add(this.picBoxThree);
            this.grpboxVehicleImages.Controls.Add(this.picBoxFour);
            this.grpboxVehicleImages.Controls.Add(this.picBoxSix);
            this.grpboxVehicleImages.Controls.Add(this.picBoxSeven);
            this.grpboxVehicleImages.Controls.Add(this.picBoxEight);
            this.grpboxVehicleImages.Controls.Add(this.picBoxNine);
            this.grpboxVehicleImages.Controls.Add(this.picBoxFive);
            this.grpboxVehicleImages.Controls.Add(this.picBoxOne);
            this.grpboxVehicleImages.Font = new System.Drawing.Font("Lato", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpboxVehicleImages.Location = new System.Drawing.Point(455, 237);
            this.grpboxVehicleImages.Name = "grpboxVehicleImages";
            this.grpboxVehicleImages.Size = new System.Drawing.Size(373, 317);
            this.grpboxVehicleImages.TabIndex = 78;
            this.grpboxVehicleImages.TabStop = false;
            this.grpboxVehicleImages.Text = "Add Vehicle Images";
            this.grpboxVehicleImages.Enter += new System.EventHandler(this.grpboxVehicleImages_Enter);
            // 
            // picBoxTwo
            // 
            this.picBoxTwo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.picBoxTwo.Location = new System.Drawing.Point(131, 41);
            this.picBoxTwo.Name = "picBoxTwo";
            this.picBoxTwo.Size = new System.Drawing.Size(112, 81);
            this.picBoxTwo.TabIndex = 87;
            this.picBoxTwo.TabStop = false;
            this.picBoxTwo.Click += new System.EventHandler(this.picBoxTwo_Click);
            // 
            // picBoxThree
            // 
            this.picBoxThree.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.picBoxThree.Location = new System.Drawing.Point(249, 40);
            this.picBoxThree.Name = "picBoxThree";
            this.picBoxThree.Size = new System.Drawing.Size(112, 81);
            this.picBoxThree.TabIndex = 86;
            this.picBoxThree.TabStop = false;
            this.picBoxThree.Click += new System.EventHandler(this.picBoxThree_Click);
            // 
            // picBoxFour
            // 
            this.picBoxFour.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.picBoxFour.Location = new System.Drawing.Point(13, 131);
            this.picBoxFour.Name = "picBoxFour";
            this.picBoxFour.Size = new System.Drawing.Size(112, 81);
            this.picBoxFour.TabIndex = 85;
            this.picBoxFour.TabStop = false;
            this.picBoxFour.Click += new System.EventHandler(this.picBoxFour_Click);
            // 
            // picBoxSix
            // 
            this.picBoxSix.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.picBoxSix.Location = new System.Drawing.Point(248, 131);
            this.picBoxSix.Name = "picBoxSix";
            this.picBoxSix.Size = new System.Drawing.Size(112, 81);
            this.picBoxSix.TabIndex = 84;
            this.picBoxSix.TabStop = false;
            this.picBoxSix.Click += new System.EventHandler(this.picBoxSix_Click);
            // 
            // picBoxSeven
            // 
            this.picBoxSeven.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.picBoxSeven.Location = new System.Drawing.Point(13, 221);
            this.picBoxSeven.Name = "picBoxSeven";
            this.picBoxSeven.Size = new System.Drawing.Size(112, 81);
            this.picBoxSeven.TabIndex = 83;
            this.picBoxSeven.TabStop = false;
            this.picBoxSeven.Click += new System.EventHandler(this.picBoxSeven_Click);
            // 
            // picBoxEight
            // 
            this.picBoxEight.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.picBoxEight.Location = new System.Drawing.Point(131, 219);
            this.picBoxEight.Name = "picBoxEight";
            this.picBoxEight.Size = new System.Drawing.Size(112, 81);
            this.picBoxEight.TabIndex = 82;
            this.picBoxEight.TabStop = false;
            this.picBoxEight.Click += new System.EventHandler(this.picBoxEight_Click);
            // 
            // picBoxNine
            // 
            this.picBoxNine.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.picBoxNine.Location = new System.Drawing.Point(249, 218);
            this.picBoxNine.Name = "picBoxNine";
            this.picBoxNine.Size = new System.Drawing.Size(112, 81);
            this.picBoxNine.TabIndex = 81;
            this.picBoxNine.TabStop = false;
            this.picBoxNine.Click += new System.EventHandler(this.picBoxNine_Click);
            // 
            // picBoxFive
            // 
            this.picBoxFive.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.picBoxFive.Location = new System.Drawing.Point(131, 129);
            this.picBoxFive.Name = "picBoxFive";
            this.picBoxFive.Size = new System.Drawing.Size(112, 81);
            this.picBoxFive.TabIndex = 79;
            this.picBoxFive.TabStop = false;
            this.picBoxFive.Click += new System.EventHandler(this.picBoxFive_Click);
            // 
            // picBoxOne
            // 
            this.picBoxOne.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.picBoxOne.Location = new System.Drawing.Point(13, 40);
            this.picBoxOne.Name = "picBoxOne";
            this.picBoxOne.Size = new System.Drawing.Size(112, 81);
            this.picBoxOne.TabIndex = 78;
            this.picBoxOne.TabStop = false;
            this.picBoxOne.Click += new System.EventHandler(this.picBoxOne_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Lato", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(451, 106);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(147, 19);
            this.label1.TabIndex = 80;
            this.label1.Text = "Insurance Company";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // txtInsuranceCompany
            // 
            this.txtInsuranceCompany.Location = new System.Drawing.Point(628, 105);
            this.txtInsuranceCompany.Name = "txtInsuranceCompany";
            this.txtInsuranceCompany.Size = new System.Drawing.Size(200, 20);
            this.txtInsuranceCompany.TabIndex = 79;
            this.txtInsuranceCompany.TextChanged += new System.EventHandler(this.txtInsuranceCompany_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Lato", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(451, 74);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(113, 19);
            this.label2.TabIndex = 82;
            this.label2.Text = "Insurance Type";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // txtInsuranceType
            // 
            this.txtInsuranceType.Location = new System.Drawing.Point(628, 74);
            this.txtInsuranceType.Name = "txtInsuranceType";
            this.txtInsuranceType.Size = new System.Drawing.Size(200, 20);
            this.txtInsuranceType.TabIndex = 81;
            this.txtInsuranceType.TextChanged += new System.EventHandler(this.txtInsuranceType_TextChanged);
            // 
            // txtMake
            // 
            this.txtMake.Location = new System.Drawing.Point(178, 74);
            this.txtMake.Name = "txtMake";
            this.txtMake.Size = new System.Drawing.Size(223, 20);
            this.txtMake.TabIndex = 83;
            this.txtMake.TextChanged += new System.EventHandler(this.txtMake_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Lato", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(404, 349);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(26, 16);
            this.label3.TabIndex = 84;
            this.label3.Text = "CC";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Activecolor = System.Drawing.Color.Gray;
            this.btnCancel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(57)))), ((int)(((byte)(58)))));
            this.btnCancel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnCancel.BorderRadius = 1;
            this.btnCancel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.btnCancel.ButtonText = "CANCEL";
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
            this.btnCancel.Location = new System.Drawing.Point(802, 686);
            this.btnCancel.Margin = new System.Windows.Forms.Padding(2);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(57)))), ((int)(((byte)(58)))));
            this.btnCancel.OnHovercolor = System.Drawing.Color.Gray;
            this.btnCancel.OnHoverTextColor = System.Drawing.Color.White;
            this.btnCancel.Padding = new System.Windows.Forms.Padding(0, 50, 0, 0);
            this.btnCancel.selected = false;
            this.btnCancel.Size = new System.Drawing.Size(119, 35);
            this.btnCancel.TabIndex = 86;
            this.btnCancel.Text = "CANCEL";
            this.btnCancel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnCancel.Textcolor = System.Drawing.Color.White;
            this.btnCancel.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Lato", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(3, 411);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(48, 19);
            this.label4.TabIndex = 89;
            this.label4.Text = "Color";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // txtColor
            // 
            this.txtColor.Location = new System.Drawing.Point(176, 412);
            this.txtColor.Name = "txtColor";
            this.txtColor.Size = new System.Drawing.Size(225, 20);
            this.txtColor.TabIndex = 88;
            this.txtColor.TextChanged += new System.EventHandler(this.txtColor_TextChanged);
            // 
            // btnViewMore
            // 
            this.btnViewMore.Activecolor = System.Drawing.Color.Gray;
            this.btnViewMore.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(57)))), ((int)(((byte)(58)))));
            this.btnViewMore.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnViewMore.BorderRadius = 1;
            this.btnViewMore.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.btnViewMore.ButtonText = "OK";
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
            this.btnViewMore.Location = new System.Drawing.Point(506, 607);
            this.btnViewMore.Margin = new System.Windows.Forms.Padding(2);
            this.btnViewMore.Name = "btnViewMore";
            this.btnViewMore.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(57)))), ((int)(((byte)(58)))));
            this.btnViewMore.OnHovercolor = System.Drawing.Color.Gray;
            this.btnViewMore.OnHoverTextColor = System.Drawing.Color.White;
            this.btnViewMore.Padding = new System.Windows.Forms.Padding(0, 50, 0, 0);
            this.btnViewMore.selected = false;
            this.btnViewMore.Size = new System.Drawing.Size(109, 26);
            this.btnViewMore.TabIndex = 91;
            this.btnViewMore.Text = "OK";
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
            this.btnBack.Location = new System.Drawing.Point(653, 607);
            this.btnBack.Margin = new System.Windows.Forms.Padding(2);
            this.btnBack.Name = "btnBack";
            this.btnBack.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(57)))), ((int)(((byte)(58)))));
            this.btnBack.OnHovercolor = System.Drawing.Color.Gray;
            this.btnBack.OnHoverTextColor = System.Drawing.Color.White;
            this.btnBack.Padding = new System.Windows.Forms.Padding(0, 50, 0, 0);
            this.btnBack.selected = false;
            this.btnBack.Size = new System.Drawing.Size(107, 26);
            this.btnBack.TabIndex = 90;
            this.btnBack.Text = "CANCEL";
            this.btnBack.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnBack.Textcolor = System.Drawing.Color.White;
            this.btnBack.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold);
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // btnEdit
            // 
            this.btnEdit.Activecolor = System.Drawing.Color.Gray;
            this.btnEdit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(57)))), ((int)(((byte)(58)))));
            this.btnEdit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnEdit.BorderRadius = 1;
            this.btnEdit.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.btnEdit.ButtonText = "EDIT";
            this.btnEdit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEdit.DisabledColor = System.Drawing.Color.Gray;
            this.btnEdit.Font = new System.Drawing.Font("Constantia", 12F, System.Drawing.FontStyle.Bold);
            this.btnEdit.ForeColor = System.Drawing.Color.Silver;
            this.btnEdit.Iconcolor = System.Drawing.Color.Transparent;
            this.btnEdit.Iconimage = null;
            this.btnEdit.Iconimage_right = null;
            this.btnEdit.Iconimage_right_Selected = null;
            this.btnEdit.Iconimage_Selected = null;
            this.btnEdit.IconMarginLeft = 0;
            this.btnEdit.IconMarginRight = 0;
            this.btnEdit.IconRightVisible = true;
            this.btnEdit.IconRightZoom = 0D;
            this.btnEdit.IconVisible = true;
            this.btnEdit.IconZoom = 50D;
            this.btnEdit.IsTab = false;
            this.btnEdit.Location = new System.Drawing.Point(506, 607);
            this.btnEdit.Margin = new System.Windows.Forms.Padding(2);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(57)))), ((int)(((byte)(58)))));
            this.btnEdit.OnHovercolor = System.Drawing.Color.Gray;
            this.btnEdit.OnHoverTextColor = System.Drawing.Color.White;
            this.btnEdit.Padding = new System.Windows.Forms.Padding(0, 50, 0, 0);
            this.btnEdit.selected = false;
            this.btnEdit.Size = new System.Drawing.Size(109, 26);
            this.btnEdit.TabIndex = 92;
            this.btnEdit.Text = "EDIT";
            this.btnEdit.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnEdit.Textcolor = System.Drawing.Color.White;
            this.btnEdit.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold);
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // ucVehicleDetails
            // 
            this.AccessibleDescription = "";
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Transparent;
            this.Controls.Add(this.btnEdit);
            this.Controls.Add(this.btnViewMore);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtColor);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtMake);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtInsuranceType);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtInsuranceCompany);
            this.Controls.Add(this.grpboxVehicleImages);
            this.Controls.Add(this.lblvechile);
            this.Controls.Add(this.lblspecialnotes);
            this.Controls.Add(this.lblprice);
            this.Controls.Add(this.lblyearofmanufacture);
            this.Controls.Add(this.dateInsurance);
            this.Controls.Add(this.countSeatingCapacity);
            this.Controls.Add(this.lblinsurancedate);
            this.Controls.Add(this.lblpreviousowners);
            this.Controls.Add(this.lblservicedate);
            this.Controls.Add(this.countServicesDone);
            this.Controls.Add(this.lblnoofservicesdone);
            this.Controls.Add(this.lblfirstregistrationdate);
            this.Controls.Add(this.cmbOriginCountry);
            this.Controls.Add(this.lblcountryoforigin);
            this.Controls.Add(this.countPreviousOwner);
            this.Controls.Add(this.lblseatingcapacity);
            this.Controls.Add(this.lbltransmissiongear);
            this.Controls.Add(this.lblfueltype);
            this.Controls.Add(this.lblcylindercapacity);
            this.Controls.Add(this.lblengineno);
            this.Controls.Add(this.lblchassisno);
            this.Controls.Add(this.lblmileage);
            this.Controls.Add(this.lblmodels);
            this.Controls.Add(this.lblVehicleMake);
            this.Controls.Add(this.lblVehicleDetails);
            this.Controls.Add(this.lblRegistrationNo);
            this.Controls.Add(this.txtSpecialNotes);
            this.Controls.Add(this.txtVehiclePrice);
            this.Controls.Add(this.lbllkr);
            this.Controls.Add(this.yearManufacture);
            this.Controls.Add(this.dateLastService);
            this.Controls.Add(this.dateFirstRegDate);
            this.Controls.Add(this.cmbTransmissionGear);
            this.Controls.Add(this.cmbFuelType);
            this.Controls.Add(this.txtCylinderCapacity);
            this.Controls.Add(this.txtEngineNo);
            this.Controls.Add(this.lblkm);
            this.Controls.Add(this.txtChassisNo);
            this.Controls.Add(this.txtVehicleMileage);
            this.Controls.Add(this.cmbModel);
            this.Controls.Add(this.cmbVehicleStatus);
            this.Controls.Add(this.txtVehicleRegNo);
            this.MinimumSize = new System.Drawing.Size(857, 633);
            this.Name = "ucVehicleDetails";
            this.Size = new System.Drawing.Size(857, 633);
            this.Load += new System.EventHandler(this.ucVehicleDetails_Load);
            ((System.ComponentModel.ISupportInitialize)(this.countPreviousOwner)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.countServicesDone)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.countSeatingCapacity)).EndInit();
            this.grpboxVehicleImages.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picBoxTwo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxThree)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxFour)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxSix)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxSeven)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxEight)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxNine)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxFive)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxOne)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox txtVehicleRegNo;
        private System.Windows.Forms.ComboBox cmbVehicleStatus;
        private System.Windows.Forms.ComboBox cmbModel;
        private System.Windows.Forms.TextBox txtVehicleMileage;
        private System.Windows.Forms.TextBox txtChassisNo;
        private System.Windows.Forms.Label lblkm;
        private System.Windows.Forms.TextBox txtEngineNo;
        private System.Windows.Forms.TextBox txtCylinderCapacity;
        private System.Windows.Forms.ComboBox cmbFuelType;
        private System.Windows.Forms.ComboBox cmbTransmissionGear;
        private System.Windows.Forms.DateTimePicker dateFirstRegDate;
        private System.Windows.Forms.DateTimePicker dateInsurance;
        private System.Windows.Forms.DateTimePicker dateLastService;
        private System.Windows.Forms.DateTimePicker yearManufacture;
        private System.Windows.Forms.Label lbllkr;
        private System.Windows.Forms.TextBox txtVehiclePrice;
        private System.Windows.Forms.TextBox txtSpecialNotes;
        private System.Windows.Forms.Label lblRegistrationNo;
        private System.Windows.Forms.Label lblVehicleDetails;
        private System.Windows.Forms.Label lblVehicleMake;
        private System.Windows.Forms.Label lblmodels;
        private System.Windows.Forms.Label lblmileage;
        private System.Windows.Forms.Label lblchassisno;
        private System.Windows.Forms.Label lblengineno;
        private System.Windows.Forms.Label lblcylindercapacity;
        private System.Windows.Forms.Label lblfueltype;
        private System.Windows.Forms.Label lbltransmissiongear;
        private System.Windows.Forms.Label lblseatingcapacity;
        private System.Windows.Forms.NumericUpDown countPreviousOwner;
        private System.Windows.Forms.Label lblcountryoforigin;
        private System.Windows.Forms.ComboBox cmbOriginCountry;
        private System.Windows.Forms.Label lblfirstregistrationdate;
        private System.Windows.Forms.Label lblinsurancedate;
        private System.Windows.Forms.Label lblnoofservicesdone;
        private System.Windows.Forms.NumericUpDown countServicesDone;
        private System.Windows.Forms.Label lblservicedate;
        private System.Windows.Forms.Label lblpreviousowners;
        private System.Windows.Forms.NumericUpDown countSeatingCapacity;
        private System.Windows.Forms.Label lblyearofmanufacture;
        private System.Windows.Forms.Label lblprice;
        private System.Windows.Forms.Label lblspecialnotes;
        private System.Windows.Forms.Label lblvechile;
        private System.Windows.Forms.GroupBox grpboxVehicleImages;
        private System.Windows.Forms.PictureBox picBoxTwo;
        private System.Windows.Forms.PictureBox picBoxThree;
        private System.Windows.Forms.PictureBox picBoxFour;
        private System.Windows.Forms.PictureBox picBoxSix;
        private System.Windows.Forms.PictureBox picBoxSeven;
        private System.Windows.Forms.PictureBox picBoxEight;
        private System.Windows.Forms.PictureBox picBoxNine;
        private System.Windows.Forms.PictureBox picBoxFive;
        private System.Windows.Forms.PictureBox picBoxOne;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtInsuranceCompany;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtInsuranceType;
        private System.Windows.Forms.TextBox txtMake;
        private System.Windows.Forms.Label label3;
        private Bunifu.Framework.UI.BunifuFlatButton btnCancel;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtColor;
        private Bunifu.Framework.UI.BunifuFlatButton btnViewMore;
        private Bunifu.Framework.UI.BunifuFlatButton btnBack;
        private Bunifu.Framework.UI.BunifuFlatButton btnEdit;
    }
}
