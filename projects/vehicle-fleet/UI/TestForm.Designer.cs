namespace Vehicle_Fleet_factory.UI
{
    partial class TestForm
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
            this.buttonDisconnect = new System.Windows.Forms.Button();
            this.buttonExit = new System.Windows.Forms.Button();
            this.labelVehicleType = new System.Windows.Forms.Label();
            this.comboBoxType = new System.Windows.Forms.ComboBox();
            this.labelSerialNumber = new System.Windows.Forms.Label();
            this.labelTripCounter = new System.Windows.Forms.Label();
            this.textBoxTripCounter = new System.Windows.Forms.TextBox();
            this.groupBoxVehicle = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.textBoxDay = new System.Windows.Forms.TextBox();
            this.textBoxVide2 = new System.Windows.Forms.TextBox();
            this.textBoxYear = new System.Windows.Forms.TextBox();
            this.textBoxVide1 = new System.Windows.Forms.TextBox();
            this.textBoxMonth = new System.Windows.Forms.TextBox();
            this.comboBoxSelection = new System.Windows.Forms.ComboBox();
            this.labelSelectVehicle = new System.Windows.Forms.Label();
            this.listBoxVehicles = new System.Windows.Forms.ListBox();
            this.buttonReset = new System.Windows.Forms.Button();
            this.buttonRunTest = new System.Windows.Forms.Button();
            this.groupBoxGasolineVehicle = new System.Windows.Forms.GroupBox();
            this.textBoxFuelConsumptionRate = new System.Windows.Forms.TextBox();
            this.labelFuelConsumptionRate = new System.Windows.Forms.Label();
            this.groupBoxElectricVehicle = new System.Windows.Forms.GroupBox();
            this.textBoxBatteryConsumptionRate = new System.Windows.Forms.TextBox();
            this.labelBatteryConsumptionRate = new System.Windows.Forms.Label();
            this.groupBoxHybridVehicle = new System.Windows.Forms.GroupBox();
            this.textBoxBatteryConsumtionRateHybrid = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxFuelConsumptionRateHybrid = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.GroupBoxTechnicianTestVehicle = new System.Windows.Forms.GroupBox();
            this.buttonMakeTrip = new System.Windows.Forms.Button();
            this.textBoxCalculateMileageEfficiency = new System.Windows.Forms.TextBox();
            this.textBoxMakeTripDouble = new System.Windows.Forms.TextBox();
            this.buttonCalculateMileageEfficiency = new System.Windows.Forms.Button();
            this.textBoxMakeTrip = new System.Windows.Forms.TextBox();
            this.buttonMakeTripDouble = new System.Windows.Forms.Button();
            this.buttonLoadResulat = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.buttonReadXml = new System.Windows.Forms.Button();
            this.button1WriteXml = new System.Windows.Forms.Button();
            this.groupBoxVehicle.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBoxGasolineVehicle.SuspendLayout();
            this.groupBoxElectricVehicle.SuspendLayout();
            this.groupBoxHybridVehicle.SuspendLayout();
            this.GroupBoxTechnicianTestVehicle.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // buttonDisconnect
            // 
            this.buttonDisconnect.BackColor = System.Drawing.Color.Lime;
            this.buttonDisconnect.Location = new System.Drawing.Point(6, 223);
            this.buttonDisconnect.Name = "buttonDisconnect";
            this.buttonDisconnect.Size = new System.Drawing.Size(153, 38);
            this.buttonDisconnect.TabIndex = 37;
            this.buttonDisconnect.Text = "Disconnect";
            this.buttonDisconnect.UseVisualStyleBackColor = false;
            this.buttonDisconnect.Click += new System.EventHandler(this.buttonDisconnect_Click);
            // 
            // buttonExit
            // 
            this.buttonExit.BackColor = System.Drawing.Color.Red;
            this.buttonExit.Location = new System.Drawing.Point(6, 175);
            this.buttonExit.Name = "buttonExit";
            this.buttonExit.Size = new System.Drawing.Size(153, 42);
            this.buttonExit.TabIndex = 38;
            this.buttonExit.Text = "Exit";
            this.buttonExit.UseVisualStyleBackColor = false;
            this.buttonExit.Click += new System.EventHandler(this.buttonExit_Click);
            // 
            // labelVehicleType
            // 
            this.labelVehicleType.AutoSize = true;
            this.labelVehicleType.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.labelVehicleType.Location = new System.Drawing.Point(12, 79);
            this.labelVehicleType.Name = "labelVehicleType";
            this.labelVehicleType.Size = new System.Drawing.Size(106, 22);
            this.labelVehicleType.TabIndex = 40;
            this.labelVehicleType.Text = "Type de test :";
            this.labelVehicleType.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // comboBoxType
            // 
            this.comboBoxType.FormattingEnabled = true;
            this.comboBoxType.Location = new System.Drawing.Point(140, 79);
            this.comboBoxType.Name = "comboBoxType";
            this.comboBoxType.Size = new System.Drawing.Size(199, 28);
            this.comboBoxType.TabIndex = 41;
            this.comboBoxType.SelectedIndexChanged += new System.EventHandler(this.comboBoxType_SelectedIndexChanged);
            // 
            // labelSerialNumber
            // 
            this.labelSerialNumber.AutoSize = true;
            this.labelSerialNumber.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.labelSerialNumber.Location = new System.Drawing.Point(19, 133);
            this.labelSerialNumber.Name = "labelSerialNumber";
            this.labelSerialNumber.Size = new System.Drawing.Size(99, 22);
            this.labelSerialNumber.TabIndex = 42;
            this.labelSerialNumber.Text = "Date de test";
            this.labelSerialNumber.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelTripCounter
            // 
            this.labelTripCounter.AutoSize = true;
            this.labelTripCounter.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.labelTripCounter.Location = new System.Drawing.Point(16, 183);
            this.labelTripCounter.Name = "labelTripCounter";
            this.labelTripCounter.Size = new System.Drawing.Size(106, 22);
            this.labelTripCounter.TabIndex = 44;
            this.labelTripCounter.Text = "Trip Counter :";
            this.labelTripCounter.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // textBoxTripCounter
            // 
            this.textBoxTripCounter.Location = new System.Drawing.Point(131, 183);
            this.textBoxTripCounter.Name = "textBoxTripCounter";
            this.textBoxTripCounter.Size = new System.Drawing.Size(209, 26);
            this.textBoxTripCounter.TabIndex = 45;
            // 
            // groupBoxVehicle
            // 
            this.groupBoxVehicle.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.groupBoxVehicle.Controls.Add(this.groupBox2);
            this.groupBoxVehicle.Controls.Add(this.comboBoxSelection);
            this.groupBoxVehicle.Controls.Add(this.labelSelectVehicle);
            this.groupBoxVehicle.Controls.Add(this.labelVehicleType);
            this.groupBoxVehicle.Controls.Add(this.comboBoxType);
            this.groupBoxVehicle.Controls.Add(this.labelSerialNumber);
            this.groupBoxVehicle.Controls.Add(this.labelTripCounter);
            this.groupBoxVehicle.Controls.Add(this.textBoxTripCounter);
            this.groupBoxVehicle.Location = new System.Drawing.Point(35, 12);
            this.groupBoxVehicle.Name = "groupBoxVehicle";
            this.groupBoxVehicle.Size = new System.Drawing.Size(389, 240);
            this.groupBoxVehicle.TabIndex = 50;
            this.groupBoxVehicle.TabStop = false;
            this.groupBoxVehicle.Text = "Vehicle";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.textBoxDay);
            this.groupBox2.Controls.Add(this.textBoxVide2);
            this.groupBox2.Controls.Add(this.textBoxYear);
            this.groupBox2.Controls.Add(this.textBoxVide1);
            this.groupBox2.Controls.Add(this.textBoxMonth);
            this.groupBox2.Location = new System.Drawing.Point(141, 133);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(199, 34);
            this.groupBox2.TabIndex = 48;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "groupBox2";
            // 
            // textBoxDay
            // 
            this.textBoxDay.Location = new System.Drawing.Point(78, 2);
            this.textBoxDay.Name = "textBoxDay";
            this.textBoxDay.Size = new System.Drawing.Size(50, 26);
            this.textBoxDay.TabIndex = 17;
            // 
            // textBoxVide2
            // 
            this.textBoxVide2.Location = new System.Drawing.Point(127, 2);
            this.textBoxVide2.Name = "textBoxVide2";
            this.textBoxVide2.Size = new System.Drawing.Size(22, 26);
            this.textBoxVide2.TabIndex = 16;
            this.textBoxVide2.Text = "/";
            // 
            // textBoxYear
            // 
            this.textBoxYear.Location = new System.Drawing.Point(149, 2);
            this.textBoxYear.Name = "textBoxYear";
            this.textBoxYear.Size = new System.Drawing.Size(50, 26);
            this.textBoxYear.TabIndex = 15;
            // 
            // textBoxVide1
            // 
            this.textBoxVide1.Location = new System.Drawing.Point(59, 2);
            this.textBoxVide1.Name = "textBoxVide1";
            this.textBoxVide1.Size = new System.Drawing.Size(22, 26);
            this.textBoxVide1.TabIndex = 14;
            this.textBoxVide1.Text = "/";
            // 
            // textBoxMonth
            // 
            this.textBoxMonth.Location = new System.Drawing.Point(9, 2);
            this.textBoxMonth.Name = "textBoxMonth";
            this.textBoxMonth.Size = new System.Drawing.Size(50, 26);
            this.textBoxMonth.TabIndex = 13;
            // 
            // comboBoxSelection
            // 
            this.comboBoxSelection.FormattingEnabled = true;
            this.comboBoxSelection.Location = new System.Drawing.Point(141, 30);
            this.comboBoxSelection.Name = "comboBoxSelection";
            this.comboBoxSelection.Size = new System.Drawing.Size(199, 28);
            this.comboBoxSelection.TabIndex = 47;
            // 
            // labelSelectVehicle
            // 
            this.labelSelectVehicle.AutoSize = true;
            this.labelSelectVehicle.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.labelSelectVehicle.Location = new System.Drawing.Point(16, 33);
            this.labelSelectVehicle.Name = "labelSelectVehicle";
            this.labelSelectVehicle.Size = new System.Drawing.Size(116, 22);
            this.labelSelectVehicle.TabIndex = 46;
            this.labelSelectVehicle.Text = "Select vehicle :";
            this.labelSelectVehicle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // listBoxVehicles
            // 
            this.listBoxVehicles.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.listBoxVehicles.FormattingEnabled = true;
            this.listBoxVehicles.ItemHeight = 20;
            this.listBoxVehicles.Location = new System.Drawing.Point(35, 295);
            this.listBoxVehicles.Name = "listBoxVehicles";
            this.listBoxVehicles.Size = new System.Drawing.Size(753, 184);
            this.listBoxVehicles.TabIndex = 51;
            this.listBoxVehicles.SelectedIndexChanged += new System.EventHandler(this.listBoxVehicles_SelectedIndexChanged);
            // 
            // buttonReset
            // 
            this.buttonReset.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.buttonReset.Location = new System.Drawing.Point(6, 71);
            this.buttonReset.Name = "buttonReset";
            this.buttonReset.Size = new System.Drawing.Size(153, 45);
            this.buttonReset.TabIndex = 53;
            this.buttonReset.Text = "Reset";
            this.buttonReset.UseVisualStyleBackColor = false;
            this.buttonReset.Click += new System.EventHandler(this.buttonReset_Click);
            // 
            // buttonRunTest
            // 
            this.buttonRunTest.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.buttonRunTest.Location = new System.Drawing.Point(6, 25);
            this.buttonRunTest.Name = "buttonRunTest";
            this.buttonRunTest.Size = new System.Drawing.Size(153, 40);
            this.buttonRunTest.TabIndex = 54;
            this.buttonRunTest.Text = "RunTest";
            this.buttonRunTest.UseVisualStyleBackColor = false;
            this.buttonRunTest.Click += new System.EventHandler(this.buttonRunTest_Click);
            // 
            // groupBoxGasolineVehicle
            // 
            this.groupBoxGasolineVehicle.BackColor = System.Drawing.Color.Khaki;
            this.groupBoxGasolineVehicle.Controls.Add(this.textBoxFuelConsumptionRate);
            this.groupBoxGasolineVehicle.Controls.Add(this.labelFuelConsumptionRate);
            this.groupBoxGasolineVehicle.Location = new System.Drawing.Point(430, 18);
            this.groupBoxGasolineVehicle.Name = "groupBoxGasolineVehicle";
            this.groupBoxGasolineVehicle.Size = new System.Drawing.Size(343, 67);
            this.groupBoxGasolineVehicle.TabIndex = 55;
            this.groupBoxGasolineVehicle.TabStop = false;
            this.groupBoxGasolineVehicle.Text = "GasolineVehicle";
            this.groupBoxGasolineVehicle.Enter += new System.EventHandler(this.groupBoxGasolineVehicle_Enter);
            // 
            // textBoxFuelConsumptionRate
            // 
            this.textBoxFuelConsumptionRate.Location = new System.Drawing.Point(185, 31);
            this.textBoxFuelConsumptionRate.Name = "textBoxFuelConsumptionRate";
            this.textBoxFuelConsumptionRate.Size = new System.Drawing.Size(129, 26);
            this.textBoxFuelConsumptionRate.TabIndex = 3;
            // 
            // labelFuelConsumptionRate
            // 
            this.labelFuelConsumptionRate.AutoSize = true;
            this.labelFuelConsumptionRate.Location = new System.Drawing.Point(6, 34);
            this.labelFuelConsumptionRate.Name = "labelFuelConsumptionRate";
            this.labelFuelConsumptionRate.Size = new System.Drawing.Size(173, 20);
            this.labelFuelConsumptionRate.TabIndex = 2;
            this.labelFuelConsumptionRate.Text = "FuelConsumptionRate:";
            this.labelFuelConsumptionRate.Click += new System.EventHandler(this.labelFuelConsumptionRate_Click);
            // 
            // groupBoxElectricVehicle
            // 
            this.groupBoxElectricVehicle.BackColor = System.Drawing.Color.LightGreen;
            this.groupBoxElectricVehicle.Controls.Add(this.textBoxBatteryConsumptionRate);
            this.groupBoxElectricVehicle.Controls.Add(this.labelBatteryConsumptionRate);
            this.groupBoxElectricVehicle.Location = new System.Drawing.Point(430, 91);
            this.groupBoxElectricVehicle.Name = "groupBoxElectricVehicle";
            this.groupBoxElectricVehicle.Size = new System.Drawing.Size(343, 70);
            this.groupBoxElectricVehicle.TabIndex = 56;
            this.groupBoxElectricVehicle.TabStop = false;
            this.groupBoxElectricVehicle.Text = "ElectricVehicle";
            // 
            // textBoxBatteryConsumptionRate
            // 
            this.textBoxBatteryConsumptionRate.Location = new System.Drawing.Point(204, 31);
            this.textBoxBatteryConsumptionRate.Name = "textBoxBatteryConsumptionRate";
            this.textBoxBatteryConsumptionRate.Size = new System.Drawing.Size(129, 26);
            this.textBoxBatteryConsumptionRate.TabIndex = 3;
            // 
            // labelBatteryConsumptionRate
            // 
            this.labelBatteryConsumptionRate.AutoSize = true;
            this.labelBatteryConsumptionRate.Location = new System.Drawing.Point(6, 31);
            this.labelBatteryConsumptionRate.Name = "labelBatteryConsumptionRate";
            this.labelBatteryConsumptionRate.Size = new System.Drawing.Size(193, 20);
            this.labelBatteryConsumptionRate.TabIndex = 2;
            this.labelBatteryConsumptionRate.Text = "BatteryConsumptionRate:";
            // 
            // groupBoxHybridVehicle
            // 
            this.groupBoxHybridVehicle.BackColor = System.Drawing.Color.Violet;
            this.groupBoxHybridVehicle.Controls.Add(this.textBoxBatteryConsumtionRateHybrid);
            this.groupBoxHybridVehicle.Controls.Add(this.label2);
            this.groupBoxHybridVehicle.Controls.Add(this.textBoxFuelConsumptionRateHybrid);
            this.groupBoxHybridVehicle.Controls.Add(this.label1);
            this.groupBoxHybridVehicle.Location = new System.Drawing.Point(430, 175);
            this.groupBoxHybridVehicle.Name = "groupBoxHybridVehicle";
            this.groupBoxHybridVehicle.Size = new System.Drawing.Size(343, 102);
            this.groupBoxHybridVehicle.TabIndex = 57;
            this.groupBoxHybridVehicle.TabStop = false;
            this.groupBoxHybridVehicle.Text = "HybridVehicle";
            // 
            // textBoxBatteryConsumtionRateHybrid
            // 
            this.textBoxBatteryConsumtionRateHybrid.Location = new System.Drawing.Point(205, 57);
            this.textBoxBatteryConsumtionRateHybrid.Name = "textBoxBatteryConsumtionRateHybrid";
            this.textBoxBatteryConsumtionRateHybrid.Size = new System.Drawing.Size(129, 26);
            this.textBoxBatteryConsumtionRateHybrid.TabIndex = 6;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 60);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(193, 20);
            this.label2.TabIndex = 5;
            this.label2.Text = "BatteryConsumptionRate:";
            // 
            // textBoxFuelConsumptionRateHybrid
            // 
            this.textBoxFuelConsumptionRateHybrid.Location = new System.Drawing.Point(186, 24);
            this.textBoxFuelConsumptionRateHybrid.Name = "textBoxFuelConsumptionRateHybrid";
            this.textBoxFuelConsumptionRateHybrid.Size = new System.Drawing.Size(148, 26);
            this.textBoxFuelConsumptionRateHybrid.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(173, 20);
            this.label1.TabIndex = 3;
            this.label1.Text = "FuelConsumptionRate:";
            // 
            // GroupBoxTechnicianTestVehicle
            // 
            this.GroupBoxTechnicianTestVehicle.BackColor = System.Drawing.Color.IndianRed;
            this.GroupBoxTechnicianTestVehicle.Controls.Add(this.buttonMakeTrip);
            this.GroupBoxTechnicianTestVehicle.Controls.Add(this.textBoxCalculateMileageEfficiency);
            this.GroupBoxTechnicianTestVehicle.Controls.Add(this.textBoxMakeTripDouble);
            this.GroupBoxTechnicianTestVehicle.Controls.Add(this.buttonCalculateMileageEfficiency);
            this.GroupBoxTechnicianTestVehicle.Controls.Add(this.textBoxMakeTrip);
            this.GroupBoxTechnicianTestVehicle.Controls.Add(this.buttonMakeTripDouble);
            this.GroupBoxTechnicianTestVehicle.Location = new System.Drawing.Point(812, 18);
            this.GroupBoxTechnicianTestVehicle.Name = "GroupBoxTechnicianTestVehicle";
            this.GroupBoxTechnicianTestVehicle.Size = new System.Drawing.Size(381, 219);
            this.GroupBoxTechnicianTestVehicle.TabIndex = 58;
            this.GroupBoxTechnicianTestVehicle.TabStop = false;
            this.GroupBoxTechnicianTestVehicle.Text = "TechnicianTestVehicle";
            // 
            // buttonMakeTrip
            // 
            this.buttonMakeTrip.Location = new System.Drawing.Point(22, 29);
            this.buttonMakeTrip.Name = "buttonMakeTrip";
            this.buttonMakeTrip.Size = new System.Drawing.Size(126, 41);
            this.buttonMakeTrip.TabIndex = 13;
            this.buttonMakeTrip.Text = "Make Trip : ";
            this.buttonMakeTrip.UseVisualStyleBackColor = true;
            this.buttonMakeTrip.Click += new System.EventHandler(this.buttonMakeTrip_Click);
            // 
            // textBoxCalculateMileageEfficiency
            // 
            this.textBoxCalculateMileageEfficiency.Location = new System.Drawing.Point(232, 154);
            this.textBoxCalculateMileageEfficiency.Name = "textBoxCalculateMileageEfficiency";
            this.textBoxCalculateMileageEfficiency.Size = new System.Drawing.Size(129, 26);
            this.textBoxCalculateMileageEfficiency.TabIndex = 32;
            // 
            // textBoxMakeTripDouble
            // 
            this.textBoxMakeTripDouble.Location = new System.Drawing.Point(205, 95);
            this.textBoxMakeTripDouble.Name = "textBoxMakeTripDouble";
            this.textBoxMakeTripDouble.Size = new System.Drawing.Size(116, 26);
            this.textBoxMakeTripDouble.TabIndex = 34;
            // 
            // buttonCalculateMileageEfficiency
            // 
            this.buttonCalculateMileageEfficiency.Location = new System.Drawing.Point(6, 147);
            this.buttonCalculateMileageEfficiency.Name = "buttonCalculateMileageEfficiency";
            this.buttonCalculateMileageEfficiency.Size = new System.Drawing.Size(219, 39);
            this.buttonCalculateMileageEfficiency.TabIndex = 31;
            this.buttonCalculateMileageEfficiency.Text = "CalculateMileageEfficiency:";
            this.buttonCalculateMileageEfficiency.UseVisualStyleBackColor = true;
            this.buttonCalculateMileageEfficiency.Click += new System.EventHandler(this.buttonCalculateMileageEfficiency_Click);
            // 
            // textBoxMakeTrip
            // 
            this.textBoxMakeTrip.Location = new System.Drawing.Point(176, 36);
            this.textBoxMakeTrip.Name = "textBoxMakeTrip";
            this.textBoxMakeTrip.Size = new System.Drawing.Size(116, 26);
            this.textBoxMakeTrip.TabIndex = 9;
            // 
            // buttonMakeTripDouble
            // 
            this.buttonMakeTripDouble.Location = new System.Drawing.Point(22, 89);
            this.buttonMakeTripDouble.Name = "buttonMakeTripDouble";
            this.buttonMakeTripDouble.Size = new System.Drawing.Size(159, 39);
            this.buttonMakeTripDouble.TabIndex = 33;
            this.buttonMakeTripDouble.Text = "Make Trip Double : ";
            this.buttonMakeTripDouble.UseVisualStyleBackColor = true;
            this.buttonMakeTripDouble.Click += new System.EventHandler(this.buttonMakeTripDouble_Click);
            // 
            // buttonLoadResulat
            // 
            this.buttonLoadResulat.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.buttonLoadResulat.Location = new System.Drawing.Point(6, 122);
            this.buttonLoadResulat.Name = "buttonLoadResulat";
            this.buttonLoadResulat.Size = new System.Drawing.Size(153, 47);
            this.buttonLoadResulat.TabIndex = 61;
            this.buttonLoadResulat.Text = "Load Resulat";
            this.buttonLoadResulat.UseVisualStyleBackColor = false;
            this.buttonLoadResulat.Click += new System.EventHandler(this.buttonLoadResulat_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.buttonRunTest);
            this.groupBox1.Controls.Add(this.buttonLoadResulat);
            this.groupBox1.Controls.Add(this.buttonReset);
            this.groupBox1.Controls.Add(this.buttonExit);
            this.groupBox1.Controls.Add(this.buttonDisconnect);
            this.groupBox1.Location = new System.Drawing.Point(834, 243);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(159, 273);
            this.groupBox1.TabIndex = 62;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "groupBox1";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // buttonReadXml
            // 
            this.buttonReadXml.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.buttonReadXml.Location = new System.Drawing.Point(1017, 268);
            this.buttonReadXml.Name = "buttonReadXml";
            this.buttonReadXml.Size = new System.Drawing.Size(122, 41);
            this.buttonReadXml.TabIndex = 63;
            this.buttonReadXml.Text = "Read XML";
            this.buttonReadXml.UseVisualStyleBackColor = false;
            this.buttonReadXml.Click += new System.EventHandler(this.buttonReadXml_Click);
            // 
            // button1WriteXml
            // 
            this.button1WriteXml.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.button1WriteXml.Location = new System.Drawing.Point(1017, 318);
            this.button1WriteXml.Name = "button1WriteXml";
            this.button1WriteXml.Size = new System.Drawing.Size(122, 41);
            this.button1WriteXml.TabIndex = 64;
            this.button1WriteXml.Text = "Write XML";
            this.button1WriteXml.UseVisualStyleBackColor = false;
            this.button1WriteXml.Click += new System.EventHandler(this.button1WriteXml_Click);
            // 
            // TestForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Silver;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(1209, 610);
            this.Controls.Add(this.button1WriteXml);
            this.Controls.Add(this.buttonReadXml);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.GroupBoxTechnicianTestVehicle);
            this.Controls.Add(this.groupBoxHybridVehicle);
            this.Controls.Add(this.groupBoxElectricVehicle);
            this.Controls.Add(this.groupBoxGasolineVehicle);
            this.Controls.Add(this.listBoxVehicles);
            this.Controls.Add(this.groupBoxVehicle);
            this.Name = "TestForm";
            this.Text = "TestVehicle";
            this.Load += new System.EventHandler(this.TestForm_Load);
            this.groupBoxVehicle.ResumeLayout(false);
            this.groupBoxVehicle.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBoxGasolineVehicle.ResumeLayout(false);
            this.groupBoxGasolineVehicle.PerformLayout();
            this.groupBoxElectricVehicle.ResumeLayout(false);
            this.groupBoxElectricVehicle.PerformLayout();
            this.groupBoxHybridVehicle.ResumeLayout(false);
            this.groupBoxHybridVehicle.PerformLayout();
            this.GroupBoxTechnicianTestVehicle.ResumeLayout(false);
            this.GroupBoxTechnicianTestVehicle.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button buttonDisconnect;
        private System.Windows.Forms.Button buttonExit;
        private System.Windows.Forms.Label labelVehicleType;
        private System.Windows.Forms.ComboBox comboBoxType;
        private System.Windows.Forms.Label labelSerialNumber;
        private System.Windows.Forms.Label labelTripCounter;
        private System.Windows.Forms.TextBox textBoxTripCounter;
        private System.Windows.Forms.GroupBox groupBoxVehicle;
        private System.Windows.Forms.ListBox listBoxVehicles;
        private System.Windows.Forms.Button buttonReset;
        private System.Windows.Forms.Button buttonRunTest;
        private System.Windows.Forms.GroupBox groupBoxGasolineVehicle;
        private System.Windows.Forms.TextBox textBoxFuelConsumptionRate;
        private System.Windows.Forms.Label labelFuelConsumptionRate;
        private System.Windows.Forms.GroupBox groupBoxElectricVehicle;
        private System.Windows.Forms.TextBox textBoxBatteryConsumptionRate;
        private System.Windows.Forms.Label labelBatteryConsumptionRate;
        private System.Windows.Forms.GroupBox groupBoxHybridVehicle;
        private System.Windows.Forms.TextBox textBoxBatteryConsumtionRateHybrid;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxFuelConsumptionRateHybrid;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox GroupBoxTechnicianTestVehicle;
        private System.Windows.Forms.Button buttonMakeTrip;
        private System.Windows.Forms.TextBox textBoxCalculateMileageEfficiency;
        private System.Windows.Forms.TextBox textBoxMakeTripDouble;
        private System.Windows.Forms.Button buttonCalculateMileageEfficiency;
        private System.Windows.Forms.TextBox textBoxMakeTrip;
        private System.Windows.Forms.Button buttonMakeTripDouble;
        private System.Windows.Forms.ComboBox comboBoxSelection;
        private System.Windows.Forms.Label labelSelectVehicle;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox textBoxDay;
        private System.Windows.Forms.TextBox textBoxVide2;
        private System.Windows.Forms.TextBox textBoxYear;
        private System.Windows.Forms.TextBox textBoxVide1;
        private System.Windows.Forms.TextBox textBoxMonth;
        private System.Windows.Forms.Button buttonLoadResulat;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button buttonReadXml;
        private System.Windows.Forms.Button button1WriteXml;
    }
}