namespace TPBuilder
{
    partial class BuilderGUI
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
            this.lblAirportName = new System.Windows.Forms.Label();
            this.lblAirportTitle = new System.Windows.Forms.Label();
            this.lblAircraftTitle = new System.Windows.Forms.Label();
            this.lblMinPassenger = new System.Windows.Forms.Label();
            this.lblMaxPassenger = new System.Windows.Forms.Label();
            this.lblMinMarchandise = new System.Windows.Forms.Label();
            this.lblMaxMarchandise = new System.Windows.Forms.Label();
            this.tbAirportName = new System.Windows.Forms.TextBox();
            this.tbMinPassenger = new System.Windows.Forms.TextBox();
            this.tbMaxPassenger = new System.Windows.Forms.TextBox();
            this.tbMinMarchandise = new System.Windows.Forms.TextBox();
            this.tbMaxMarchandise = new System.Windows.Forms.TextBox();
            this.btnAddAirport = new System.Windows.Forms.Button();
            this.btnAddAircraft = new System.Windows.Forms.Button();
            this.tbMaintenance = new System.Windows.Forms.TextBox();
            this.tbUnload = new System.Windows.Forms.TextBox();
            this.tbLoad = new System.Windows.Forms.TextBox();
            this.tbSpeed = new System.Windows.Forms.TextBox();
            this.tbAircraftName = new System.Windows.Forms.TextBox();
            this.lblAircraftMaintenance = new System.Windows.Forms.Label();
            this.lblAircraftUnload = new System.Windows.Forms.Label();
            this.lblAircraftLoad = new System.Windows.Forms.Label();
            this.lblAircraftSpeed = new System.Windows.Forms.Label();
            this.lblAircraftType = new System.Windows.Forms.Label();
            this.lblAircraftName = new System.Windows.Forms.Label();
            this.btnGenerate = new System.Windows.Forms.Button();
            this.Positions = new System.Windows.Forms.Label();
            this.lsvAirport = new System.Windows.Forms.ListView();
            this.lsvAircraft = new System.Windows.Forms.ListView();
            this.btnMap = new System.Windows.Forms.Button();
            this.cmbAircraftType = new System.Windows.Forms.ComboBox();
            this.tbCapacity = new System.Windows.Forms.TextBox();
            this.lblCapacity = new System.Windows.Forms.Label();
            this.tbWeight = new System.Windows.Forms.TextBox();
            this.lblWeight = new System.Windows.Forms.Label();
            this.tbWaterCapacity = new System.Windows.Forms.TextBox();
            this.lblWaterCapacity = new System.Windows.Forms.Label();
            this.tbDropTime = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tbFilename = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnSaveFile = new System.Windows.Forms.Button();
            this.AirportControlGroup = new System.Windows.Forms.Panel();
            this.AircraftControlGroup = new System.Windows.Forms.Panel();
            this.unlockBtn = new System.Windows.Forms.Button();
            this.AirportControlGroup.SuspendLayout();
            this.AircraftControlGroup.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblAirportName
            // 
            this.lblAirportName.AutoSize = true;
            this.lblAirportName.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAirportName.Location = new System.Drawing.Point(13, 6);
            this.lblAirportName.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.lblAirportName.Name = "lblAirportName";
            this.lblAirportName.Size = new System.Drawing.Size(38, 13);
            this.lblAirportName.TabIndex = 2;
            this.lblAirportName.Text = "Name:";
            // 
            // lblAirportTitle
            // 
            this.lblAirportTitle.AutoSize = true;
            this.lblAirportTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAirportTitle.Location = new System.Drawing.Point(6, 3);
            this.lblAirportTitle.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.lblAirportTitle.Name = "lblAirportTitle";
            this.lblAirportTitle.Size = new System.Drawing.Size(57, 17);
            this.lblAirportTitle.TabIndex = 4;
            this.lblAirportTitle.Text = "Airport";
            // 
            // lblAircraftTitle
            // 
            this.lblAircraftTitle.AutoSize = true;
            this.lblAircraftTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAircraftTitle.Location = new System.Drawing.Point(6, 253);
            this.lblAircraftTitle.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.lblAircraftTitle.Name = "lblAircraftTitle";
            this.lblAircraftTitle.Size = new System.Drawing.Size(61, 17);
            this.lblAircraftTitle.TabIndex = 5;
            this.lblAircraftTitle.Text = "Aircraft";
            // 
            // lblMinPassenger
            // 
            this.lblMinPassenger.AutoSize = true;
            this.lblMinPassenger.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMinPassenger.Location = new System.Drawing.Point(220, 4);
            this.lblMinPassenger.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.lblMinPassenger.Name = "lblMinPassenger";
            this.lblMinPassenger.Size = new System.Drawing.Size(82, 13);
            this.lblMinPassenger.TabIndex = 6;
            this.lblMinPassenger.Text = "MinPassengers:";
            // 
            // lblMaxPassenger
            // 
            this.lblMaxPassenger.AutoSize = true;
            this.lblMaxPassenger.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMaxPassenger.Location = new System.Drawing.Point(217, 38);
            this.lblMaxPassenger.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.lblMaxPassenger.Name = "lblMaxPassenger";
            this.lblMaxPassenger.Size = new System.Drawing.Size(85, 13);
            this.lblMaxPassenger.TabIndex = 7;
            this.lblMaxPassenger.Text = "MaxPassengers:";
            // 
            // lblMinMarchandise
            // 
            this.lblMinMarchandise.AutoSize = true;
            this.lblMinMarchandise.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMinMarchandise.Location = new System.Drawing.Point(410, 4);
            this.lblMinMarchandise.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.lblMinMarchandise.Name = "lblMinMarchandise";
            this.lblMinMarchandise.Size = new System.Drawing.Size(88, 13);
            this.lblMinMarchandise.TabIndex = 8;
            this.lblMinMarchandise.Text = "MinMarchandise:";
            // 
            // lblMaxMarchandise
            // 
            this.lblMaxMarchandise.AutoSize = true;
            this.lblMaxMarchandise.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMaxMarchandise.Location = new System.Drawing.Point(407, 38);
            this.lblMaxMarchandise.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.lblMaxMarchandise.Name = "lblMaxMarchandise";
            this.lblMaxMarchandise.Size = new System.Drawing.Size(91, 13);
            this.lblMaxMarchandise.TabIndex = 9;
            this.lblMaxMarchandise.Text = "MaxMarchandise:";
            // 
            // tbAirportName
            // 
            this.tbAirportName.Location = new System.Drawing.Point(56, 4);
            this.tbAirportName.Margin = new System.Windows.Forms.Padding(1, 1, 1, 1);
            this.tbAirportName.Name = "tbAirportName";
            this.tbAirportName.Size = new System.Drawing.Size(92, 20);
            this.tbAirportName.TabIndex = 10;
            // 
            // tbMinPassenger
            // 
            this.tbMinPassenger.Location = new System.Drawing.Point(300, 4);
            this.tbMinPassenger.Margin = new System.Windows.Forms.Padding(1, 1, 1, 1);
            this.tbMinPassenger.Name = "tbMinPassenger";
            this.tbMinPassenger.Size = new System.Drawing.Size(92, 20);
            this.tbMinPassenger.TabIndex = 12;
            // 
            // tbMaxPassenger
            // 
            this.tbMaxPassenger.Location = new System.Drawing.Point(300, 38);
            this.tbMaxPassenger.Margin = new System.Windows.Forms.Padding(1, 1, 1, 1);
            this.tbMaxPassenger.Name = "tbMaxPassenger";
            this.tbMaxPassenger.Size = new System.Drawing.Size(92, 20);
            this.tbMaxPassenger.TabIndex = 13;
            // 
            // tbMinMarchandise
            // 
            this.tbMinMarchandise.Location = new System.Drawing.Point(494, 4);
            this.tbMinMarchandise.Margin = new System.Windows.Forms.Padding(1, 1, 1, 1);
            this.tbMinMarchandise.Name = "tbMinMarchandise";
            this.tbMinMarchandise.Size = new System.Drawing.Size(92, 20);
            this.tbMinMarchandise.TabIndex = 14;
            // 
            // tbMaxMarchandise
            // 
            this.tbMaxMarchandise.Location = new System.Drawing.Point(494, 38);
            this.tbMaxMarchandise.Margin = new System.Windows.Forms.Padding(1, 1, 1, 1);
            this.tbMaxMarchandise.Name = "tbMaxMarchandise";
            this.tbMaxMarchandise.Size = new System.Drawing.Size(92, 20);
            this.tbMaxMarchandise.TabIndex = 15;
            // 
            // btnAddAirport
            // 
            this.btnAddAirport.BackColor = System.Drawing.Color.Green;
            this.btnAddAirport.FlatAppearance.BorderColor = System.Drawing.Color.Green;
            this.btnAddAirport.FlatAppearance.BorderSize = 0;
            this.btnAddAirport.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkGreen;
            this.btnAddAirport.FlatAppearance.MouseOverBackColor = System.Drawing.Color.ForestGreen;
            this.btnAddAirport.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddAirport.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.btnAddAirport.Location = new System.Drawing.Point(934, 187);
            this.btnAddAirport.Margin = new System.Windows.Forms.Padding(1, 1, 1, 1);
            this.btnAddAirport.Name = "btnAddAirport";
            this.btnAddAirport.Size = new System.Drawing.Size(165, 49);
            this.btnAddAirport.TabIndex = 16;
            this.btnAddAirport.TabStop = false;
            this.btnAddAirport.Text = "Add";
            this.btnAddAirport.UseVisualStyleBackColor = false;
            this.btnAddAirport.Click += new System.EventHandler(this.BtnAddAirport_Click);
            // 
            // btnAddAircraft
            // 
            this.btnAddAircraft.BackColor = System.Drawing.Color.Green;
            this.btnAddAircraft.FlatAppearance.BorderColor = System.Drawing.Color.Green;
            this.btnAddAircraft.FlatAppearance.BorderSize = 0;
            this.btnAddAircraft.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkGreen;
            this.btnAddAircraft.FlatAppearance.MouseOverBackColor = System.Drawing.Color.ForestGreen;
            this.btnAddAircraft.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddAircraft.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.btnAddAircraft.Location = new System.Drawing.Point(934, 435);
            this.btnAddAircraft.Margin = new System.Windows.Forms.Padding(1, 1, 1, 1);
            this.btnAddAircraft.Name = "btnAddAircraft";
            this.btnAddAircraft.Size = new System.Drawing.Size(165, 49);
            this.btnAddAircraft.TabIndex = 29;
            this.btnAddAircraft.Text = "Add";
            this.btnAddAircraft.UseVisualStyleBackColor = false;
            this.btnAddAircraft.Click += new System.EventHandler(this.BtnAddAircraft_Click);
            // 
            // tbMaintenance
            // 
            this.tbMaintenance.Location = new System.Drawing.Point(224, 3);
            this.tbMaintenance.Margin = new System.Windows.Forms.Padding(1, 1, 1, 1);
            this.tbMaintenance.Name = "tbMaintenance";
            this.tbMaintenance.Size = new System.Drawing.Size(92, 20);
            this.tbMaintenance.TabIndex = 28;
            // 
            // tbUnload
            // 
            this.tbUnload.Location = new System.Drawing.Point(395, 34);
            this.tbUnload.Margin = new System.Windows.Forms.Padding(1, 1, 1, 1);
            this.tbUnload.Name = "tbUnload";
            this.tbUnload.Size = new System.Drawing.Size(92, 20);
            this.tbUnload.TabIndex = 27;
            // 
            // tbLoad
            // 
            this.tbLoad.Location = new System.Drawing.Point(395, 3);
            this.tbLoad.Margin = new System.Windows.Forms.Padding(1, 1, 1, 1);
            this.tbLoad.Name = "tbLoad";
            this.tbLoad.Size = new System.Drawing.Size(92, 20);
            this.tbLoad.TabIndex = 26;
            // 
            // tbSpeed
            // 
            this.tbSpeed.Location = new System.Drawing.Point(223, 32);
            this.tbSpeed.Margin = new System.Windows.Forms.Padding(1, 1, 1, 1);
            this.tbSpeed.Name = "tbSpeed";
            this.tbSpeed.Size = new System.Drawing.Size(92, 20);
            this.tbSpeed.TabIndex = 25;
            // 
            // tbAircraftName
            // 
            this.tbAircraftName.Location = new System.Drawing.Point(37, 3);
            this.tbAircraftName.Margin = new System.Windows.Forms.Padding(1, 1, 1, 1);
            this.tbAircraftName.Name = "tbAircraftName";
            this.tbAircraftName.Size = new System.Drawing.Size(92, 20);
            this.tbAircraftName.TabIndex = 23;
            // 
            // lblAircraftMaintenance
            // 
            this.lblAircraftMaintenance.AutoSize = true;
            this.lblAircraftMaintenance.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAircraftMaintenance.Location = new System.Drawing.Point(130, 5);
            this.lblAircraftMaintenance.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.lblAircraftMaintenance.Name = "lblAircraftMaintenance";
            this.lblAircraftMaintenance.Size = new System.Drawing.Size(98, 13);
            this.lblAircraftMaintenance.TabIndex = 22;
            this.lblAircraftMaintenance.Text = "Maintenance Time:";
            // 
            // lblAircraftUnload
            // 
            this.lblAircraftUnload.AutoSize = true;
            this.lblAircraftUnload.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAircraftUnload.Location = new System.Drawing.Point(314, 36);
            this.lblAircraftUnload.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.lblAircraftUnload.Name = "lblAircraftUnload";
            this.lblAircraftUnload.Size = new System.Drawing.Size(84, 13);
            this.lblAircraftUnload.TabIndex = 21;
            this.lblAircraftUnload.Text = "Unloading Time:";
            // 
            // lblAircraftLoad
            // 
            this.lblAircraftLoad.AutoSize = true;
            this.lblAircraftLoad.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAircraftLoad.Location = new System.Drawing.Point(323, 5);
            this.lblAircraftLoad.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.lblAircraftLoad.Name = "lblAircraftLoad";
            this.lblAircraftLoad.Size = new System.Drawing.Size(74, 13);
            this.lblAircraftLoad.TabIndex = 20;
            this.lblAircraftLoad.Text = "Loading Time:";
            // 
            // lblAircraftSpeed
            // 
            this.lblAircraftSpeed.AutoSize = true;
            this.lblAircraftSpeed.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAircraftSpeed.Location = new System.Drawing.Point(130, 38);
            this.lblAircraftSpeed.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.lblAircraftSpeed.Name = "lblAircraftSpeed";
            this.lblAircraftSpeed.Size = new System.Drawing.Size(41, 13);
            this.lblAircraftSpeed.TabIndex = 19;
            this.lblAircraftSpeed.Text = "Speed:";
            // 
            // lblAircraftType
            // 
            this.lblAircraftType.AutoSize = true;
            this.lblAircraftType.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAircraftType.Location = new System.Drawing.Point(0, 38);
            this.lblAircraftType.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.lblAircraftType.Name = "lblAircraftType";
            this.lblAircraftType.Size = new System.Drawing.Size(34, 13);
            this.lblAircraftType.TabIndex = 18;
            this.lblAircraftType.Text = "Type:";
            // 
            // lblAircraftName
            // 
            this.lblAircraftName.AutoSize = true;
            this.lblAircraftName.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAircraftName.Location = new System.Drawing.Point(3, 453);
            this.lblAircraftName.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.lblAircraftName.Name = "lblAircraftName";
            this.lblAircraftName.Size = new System.Drawing.Size(38, 13);
            this.lblAircraftName.TabIndex = 17;
            this.lblAircraftName.Text = "Name:";
            // 
            // btnGenerate
            // 
            this.btnGenerate.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnGenerate.BackColor = System.Drawing.Color.Green;
            this.btnGenerate.FlatAppearance.BorderColor = System.Drawing.Color.Green;
            this.btnGenerate.FlatAppearance.BorderSize = 0;
            this.btnGenerate.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkGreen;
            this.btnGenerate.FlatAppearance.MouseOverBackColor = System.Drawing.Color.ForestGreen;
            this.btnGenerate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGenerate.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.btnGenerate.Location = new System.Drawing.Point(500, 593);
            this.btnGenerate.Margin = new System.Windows.Forms.Padding(1, 1, 1, 1);
            this.btnGenerate.Name = "btnGenerate";
            this.btnGenerate.Size = new System.Drawing.Size(163, 47);
            this.btnGenerate.TabIndex = 36;
            this.btnGenerate.Text = "Generate";
            this.btnGenerate.UseVisualStyleBackColor = false;
            this.btnGenerate.Click += new System.EventHandler(this.BtnGenerate_Click);
            // 
            // Positions
            // 
            this.Positions.AutoSize = true;
            this.Positions.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Positions.Location = new System.Drawing.Point(4, 222);
            this.Positions.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.Positions.Name = "Positions";
            this.Positions.Size = new System.Drawing.Size(52, 13);
            this.Positions.TabIndex = 40;
            this.Positions.Text = "Positions:";
            // 
            // lsvAirport
            // 
            this.lsvAirport.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lsvAirport.HideSelection = false;
            this.lsvAirport.Location = new System.Drawing.Point(7, 21);
            this.lsvAirport.Margin = new System.Windows.Forms.Padding(1, 1, 1, 1);
            this.lsvAirport.Name = "lsvAirport";
            this.lsvAirport.Size = new System.Drawing.Size(1124, 154);
            this.lsvAirport.TabIndex = 41;
            this.lsvAirport.UseCompatibleStateImageBehavior = false;
            this.lsvAirport.DoubleClick += new System.EventHandler(this.LsvAirport_DoubleClick);
            // 
            // lsvAircraft
            // 
            this.lsvAircraft.HideSelection = false;
            this.lsvAircraft.Location = new System.Drawing.Point(8, 271);
            this.lsvAircraft.Margin = new System.Windows.Forms.Padding(1, 1, 1, 1);
            this.lsvAircraft.Name = "lsvAircraft";
            this.lsvAircraft.Size = new System.Drawing.Size(1124, 154);
            this.lsvAircraft.TabIndex = 42;
            this.lsvAircraft.UseCompatibleStateImageBehavior = false;
            // 
            // btnMap
            // 
            this.btnMap.Location = new System.Drawing.Point(55, 34);
            this.btnMap.Margin = new System.Windows.Forms.Padding(1, 1, 1, 1);
            this.btnMap.Name = "btnMap";
            this.btnMap.Size = new System.Drawing.Size(91, 27);
            this.btnMap.TabIndex = 44;
            this.btnMap.Text = "Map";
            this.btnMap.UseVisualStyleBackColor = true;
            this.btnMap.Click += new System.EventHandler(this.BtnMap_Click);
            // 
            // cmbAircraftType
            // 
            this.cmbAircraftType.FormattingEnabled = true;
            this.cmbAircraftType.Location = new System.Drawing.Point(37, 36);
            this.cmbAircraftType.Margin = new System.Windows.Forms.Padding(1, 1, 1, 1);
            this.cmbAircraftType.Name = "cmbAircraftType";
            this.cmbAircraftType.Size = new System.Drawing.Size(92, 21);
            this.cmbAircraftType.TabIndex = 45;
            this.cmbAircraftType.SelectionChangeCommitted += new System.EventHandler(this.CmbAircraftType_SelectionChangeCommitted);
            // 
            // tbCapacity
            // 
            this.tbCapacity.Location = new System.Drawing.Point(757, 34);
            this.tbCapacity.Margin = new System.Windows.Forms.Padding(1, 1, 1, 1);
            this.tbCapacity.Name = "tbCapacity";
            this.tbCapacity.Size = new System.Drawing.Size(92, 20);
            this.tbCapacity.TabIndex = 47;
            // 
            // lblCapacity
            // 
            this.lblCapacity.AutoSize = true;
            this.lblCapacity.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCapacity.Location = new System.Drawing.Point(677, 34);
            this.lblCapacity.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.lblCapacity.Name = "lblCapacity";
            this.lblCapacity.Size = new System.Drawing.Size(71, 13);
            this.lblCapacity.TabIndex = 46;
            this.lblCapacity.Text = "MaxCapacity:";
            // 
            // tbWeight
            // 
            this.tbWeight.Location = new System.Drawing.Point(580, 3);
            this.tbWeight.Margin = new System.Windows.Forms.Padding(1, 1, 1, 1);
            this.tbWeight.Name = "tbWeight";
            this.tbWeight.Size = new System.Drawing.Size(92, 20);
            this.tbWeight.TabIndex = 49;
            // 
            // lblWeight
            // 
            this.lblWeight.AutoSize = true;
            this.lblWeight.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWeight.Location = new System.Drawing.Point(491, 5);
            this.lblWeight.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.lblWeight.Name = "lblWeight";
            this.lblWeight.Size = new System.Drawing.Size(44, 13);
            this.lblWeight.TabIndex = 48;
            this.lblWeight.Text = "Weight:";
            // 
            // tbWaterCapacity
            // 
            this.tbWaterCapacity.Location = new System.Drawing.Point(757, 5);
            this.tbWaterCapacity.Margin = new System.Windows.Forms.Padding(1, 1, 1, 1);
            this.tbWaterCapacity.Name = "tbWaterCapacity";
            this.tbWaterCapacity.Size = new System.Drawing.Size(92, 20);
            this.tbWaterCapacity.TabIndex = 51;
            // 
            // lblWaterCapacity
            // 
            this.lblWaterCapacity.AutoSize = true;
            this.lblWaterCapacity.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWaterCapacity.Location = new System.Drawing.Point(677, 5);
            this.lblWaterCapacity.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.lblWaterCapacity.Name = "lblWaterCapacity";
            this.lblWaterCapacity.Size = new System.Drawing.Size(83, 13);
            this.lblWaterCapacity.TabIndex = 50;
            this.lblWaterCapacity.Text = "Water Capacity:";
            // 
            // tbDropTime
            // 
            this.tbDropTime.Location = new System.Drawing.Point(580, 34);
            this.tbDropTime.Margin = new System.Windows.Forms.Padding(1, 1, 1, 1);
            this.tbDropTime.Name = "tbDropTime";
            this.tbDropTime.Size = new System.Drawing.Size(92, 20);
            this.tbDropTime.TabIndex = 53;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(488, 36);
            this.label1.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(79, 13);
            this.label1.TabIndex = 52;
            this.label1.Text = "Dropping Time:";
            // 
            // tbFilename
            // 
            this.tbFilename.Location = new System.Drawing.Point(490, 554);
            this.tbFilename.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tbFilename.Name = "tbFilename";
            this.tbFilename.Size = new System.Drawing.Size(185, 20);
            this.tbFilename.TabIndex = 54;
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Location = new System.Drawing.Point(9, 515);
            this.panel1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1120, 7);
            this.panel1.TabIndex = 55;
            // 
            // btnSaveFile
            // 
            this.btnSaveFile.Location = new System.Drawing.Point(677, 551);
            this.btnSaveFile.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnSaveFile.Name = "btnSaveFile";
            this.btnSaveFile.Size = new System.Drawing.Size(45, 25);
            this.btnSaveFile.TabIndex = 56;
            this.btnSaveFile.Text = "Save";
            this.btnSaveFile.UseVisualStyleBackColor = true;
            this.btnSaveFile.Click += new System.EventHandler(this.BtnSaveFile_Click);
            // 
            // AirportControlGroup
            // 
            this.AirportControlGroup.Controls.Add(this.btnMap);
            this.AirportControlGroup.Controls.Add(this.tbMaxMarchandise);
            this.AirportControlGroup.Controls.Add(this.tbMinMarchandise);
            this.AirportControlGroup.Controls.Add(this.tbMaxPassenger);
            this.AirportControlGroup.Controls.Add(this.tbMinPassenger);
            this.AirportControlGroup.Controls.Add(this.tbAirportName);
            this.AirportControlGroup.Controls.Add(this.lblMaxMarchandise);
            this.AirportControlGroup.Controls.Add(this.lblMinMarchandise);
            this.AirportControlGroup.Controls.Add(this.lblMaxPassenger);
            this.AirportControlGroup.Controls.Add(this.lblMinPassenger);
            this.AirportControlGroup.Controls.Add(this.lblAirportName);
            this.AirportControlGroup.Location = new System.Drawing.Point(1, 182);
            this.AirportControlGroup.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.AirportControlGroup.Name = "AirportControlGroup";
            this.AirportControlGroup.Size = new System.Drawing.Size(593, 70);
            this.AirportControlGroup.TabIndex = 57;
            // 
            // AircraftControlGroup
            // 
            this.AircraftControlGroup.Controls.Add(this.tbDropTime);
            this.AircraftControlGroup.Controls.Add(this.label1);
            this.AircraftControlGroup.Controls.Add(this.tbWaterCapacity);
            this.AircraftControlGroup.Controls.Add(this.lblWaterCapacity);
            this.AircraftControlGroup.Controls.Add(this.tbWeight);
            this.AircraftControlGroup.Controls.Add(this.lblWeight);
            this.AircraftControlGroup.Controls.Add(this.tbCapacity);
            this.AircraftControlGroup.Controls.Add(this.lblCapacity);
            this.AircraftControlGroup.Controls.Add(this.cmbAircraftType);
            this.AircraftControlGroup.Controls.Add(this.tbMaintenance);
            this.AircraftControlGroup.Controls.Add(this.tbUnload);
            this.AircraftControlGroup.Controls.Add(this.tbLoad);
            this.AircraftControlGroup.Controls.Add(this.tbSpeed);
            this.AircraftControlGroup.Controls.Add(this.tbAircraftName);
            this.AircraftControlGroup.Controls.Add(this.lblAircraftMaintenance);
            this.AircraftControlGroup.Controls.Add(this.lblAircraftUnload);
            this.AircraftControlGroup.Controls.Add(this.lblAircraftLoad);
            this.AircraftControlGroup.Controls.Add(this.lblAircraftSpeed);
            this.AircraftControlGroup.Controls.Add(this.lblAircraftType);
            this.AircraftControlGroup.Location = new System.Drawing.Point(4, 449);
            this.AircraftControlGroup.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.AircraftControlGroup.Name = "AircraftControlGroup";
            this.AircraftControlGroup.Size = new System.Drawing.Size(856, 66);
            this.AircraftControlGroup.TabIndex = 58;
            // 
            // unlockBtn
            // 
            this.unlockBtn.Location = new System.Drawing.Point(534, 68);
            this.unlockBtn.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.unlockBtn.Name = "unlockBtn";
            this.unlockBtn.Size = new System.Drawing.Size(79, 41);
            this.unlockBtn.TabIndex = 59;
            this.unlockBtn.Text = "Unlock";
            this.unlockBtn.UseVisualStyleBackColor = true;
            this.unlockBtn.Click += new System.EventHandler(this.UnlockBtn_Click);
            // 
            // BuilderGUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1139, 666);
            this.Controls.Add(this.unlockBtn);
            this.Controls.Add(this.lblAircraftName);
            this.Controls.Add(this.Positions);
            this.Controls.Add(this.AircraftControlGroup);
            this.Controls.Add(this.AirportControlGroup);
            this.Controls.Add(this.btnSaveFile);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.tbFilename);
            this.Controls.Add(this.lsvAircraft);
            this.Controls.Add(this.lsvAirport);
            this.Controls.Add(this.btnGenerate);
            this.Controls.Add(this.btnAddAircraft);
            this.Controls.Add(this.btnAddAirport);
            this.Controls.Add(this.lblAircraftTitle);
            this.Controls.Add(this.lblAirportTitle);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(1, 1, 1, 1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "BuilderGUI";
            this.ShowIcon = false;
            this.Text = "Scenario Builder";
            this.Load += new System.EventHandler(this.BuilderGUI_Load);
            this.AirportControlGroup.ResumeLayout(false);
            this.AirportControlGroup.PerformLayout();
            this.AircraftControlGroup.ResumeLayout(false);
            this.AircraftControlGroup.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblAirportName;
        private System.Windows.Forms.Label lblAirportTitle;
        private System.Windows.Forms.Label lblAircraftTitle;
        private System.Windows.Forms.Label lblMinPassenger;
        private System.Windows.Forms.Label lblMaxPassenger;
        private System.Windows.Forms.Label lblMinMarchandise;
        private System.Windows.Forms.Label lblMaxMarchandise;
        private System.Windows.Forms.TextBox tbAirportName;
        private System.Windows.Forms.TextBox tbMinPassenger;
        private System.Windows.Forms.TextBox tbMaxPassenger;
        private System.Windows.Forms.TextBox tbMinMarchandise;
        private System.Windows.Forms.TextBox tbMaxMarchandise;
        private System.Windows.Forms.Button btnAddAirport;
        private System.Windows.Forms.Button btnAddAircraft;
        private System.Windows.Forms.TextBox tbMaintenance;
        private System.Windows.Forms.TextBox tbUnload;
        private System.Windows.Forms.TextBox tbLoad;
        private System.Windows.Forms.TextBox tbSpeed;
        private System.Windows.Forms.TextBox tbAircraftName;
        private System.Windows.Forms.Label lblAircraftMaintenance;
        private System.Windows.Forms.Label lblAircraftUnload;
        private System.Windows.Forms.Label lblAircraftLoad;
        private System.Windows.Forms.Label lblAircraftSpeed;
        private System.Windows.Forms.Label lblAircraftType;
        private System.Windows.Forms.Label lblAircraftName;
        private System.Windows.Forms.Button btnGenerate;
        private System.Windows.Forms.Label Positions;
        private System.Windows.Forms.ListView lsvAirport;
        private System.Windows.Forms.ListView lsvAircraft;
        private System.Windows.Forms.Button btnMap;
        private System.Windows.Forms.ComboBox cmbAircraftType;
        private System.Windows.Forms.TextBox tbCapacity;
        private System.Windows.Forms.Label lblCapacity;
        private System.Windows.Forms.TextBox tbWeight;
        private System.Windows.Forms.Label lblWeight;
        private System.Windows.Forms.TextBox tbWaterCapacity;
        private System.Windows.Forms.Label lblWaterCapacity;
        private System.Windows.Forms.TextBox tbDropTime;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbFilename;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnSaveFile;
        private System.Windows.Forms.Panel AirportControlGroup;
        private System.Windows.Forms.Panel AircraftControlGroup;
        private System.Windows.Forms.Button unlockBtn;
    }
}

