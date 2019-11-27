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
            this.tbPositions = new System.Windows.Forms.TextBox();
            this.btnMap = new System.Windows.Forms.Button();
            this.cmbAircraftType = new System.Windows.Forms.ComboBox();
            this.tbCapacity = new System.Windows.Forms.TextBox();
            this.lblCapacity = new System.Windows.Forms.Label();
            this.tbWeigth = new System.Windows.Forms.TextBox();
            this.lblWeigth = new System.Windows.Forms.Label();
            this.tbWaterCapacity = new System.Windows.Forms.TextBox();
            this.lblWaterCapacity = new System.Windows.Forms.Label();
            this.tbDropTime = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblAirportName
            // 
            this.lblAirportName.AutoSize = true;
            this.lblAirportName.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAirportName.Location = new System.Drawing.Point(9, 145);
            this.lblAirportName.Name = "lblAirportName";
            this.lblAirportName.Size = new System.Drawing.Size(58, 20);
            this.lblAirportName.TabIndex = 2;
            this.lblAirportName.Text = "Name:";
            // 
            // lblAirportTitle
            // 
            this.lblAirportTitle.AutoSize = true;
            this.lblAirportTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAirportTitle.Location = new System.Drawing.Point(16, 8);
            this.lblAirportTitle.Name = "lblAirportTitle";
            this.lblAirportTitle.Size = new System.Drawing.Size(82, 25);
            this.lblAirportTitle.TabIndex = 4;
            this.lblAirportTitle.Text = "Airport";
            // 
            // lblAircraftTitle
            // 
            this.lblAircraftTitle.AutoSize = true;
            this.lblAircraftTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAircraftTitle.Location = new System.Drawing.Point(16, 216);
            this.lblAircraftTitle.Name = "lblAircraftTitle";
            this.lblAircraftTitle.Size = new System.Drawing.Size(88, 25);
            this.lblAircraftTitle.TabIndex = 5;
            this.lblAircraftTitle.Text = "Aircraft";
            // 
            // lblMinPassenger
            // 
            this.lblMinPassenger.AutoSize = true;
            this.lblMinPassenger.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMinPassenger.Location = new System.Drawing.Point(284, 145);
            this.lblMinPassenger.Name = "lblMinPassenger";
            this.lblMinPassenger.Size = new System.Drawing.Size(130, 20);
            this.lblMinPassenger.TabIndex = 6;
            this.lblMinPassenger.Text = "MinPassengers:";
            // 
            // lblMaxPassenger
            // 
            this.lblMaxPassenger.AutoSize = true;
            this.lblMaxPassenger.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMaxPassenger.Location = new System.Drawing.Point(395, 145);
            this.lblMaxPassenger.Name = "lblMaxPassenger";
            this.lblMaxPassenger.Size = new System.Drawing.Size(134, 20);
            this.lblMaxPassenger.TabIndex = 7;
            this.lblMaxPassenger.Text = "MaxPassengers:";
            // 
            // lblMinMarchandise
            // 
            this.lblMinMarchandise.AutoSize = true;
            this.lblMinMarchandise.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMinMarchandise.Location = new System.Drawing.Point(522, 145);
            this.lblMinMarchandise.Name = "lblMinMarchandise";
            this.lblMinMarchandise.Size = new System.Drawing.Size(137, 20);
            this.lblMinMarchandise.TabIndex = 8;
            this.lblMinMarchandise.Text = "MinMarchandise:";
            // 
            // lblMaxMarchandise
            // 
            this.lblMaxMarchandise.AutoSize = true;
            this.lblMaxMarchandise.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMaxMarchandise.Location = new System.Drawing.Point(650, 145);
            this.lblMaxMarchandise.Name = "lblMaxMarchandise";
            this.lblMaxMarchandise.Size = new System.Drawing.Size(141, 20);
            this.lblMaxMarchandise.TabIndex = 9;
            this.lblMaxMarchandise.Text = "MaxMarchandise:";
            // 
            // tbAirportName
            // 
            this.tbAirportName.Location = new System.Drawing.Point(56, 142);
            this.tbAirportName.Name = "tbAirportName";
            this.tbAirportName.Size = new System.Drawing.Size(60, 26);
            this.tbAirportName.TabIndex = 10;
            // 
            // tbMinPassenger
            // 
            this.tbMinPassenger.Location = new System.Drawing.Point(364, 142);
            this.tbMinPassenger.Name = "tbMinPassenger";
            this.tbMinPassenger.Size = new System.Drawing.Size(25, 26);
            this.tbMinPassenger.TabIndex = 12;
            // 
            // tbMaxPassenger
            // 
            this.tbMaxPassenger.Location = new System.Drawing.Point(486, 142);
            this.tbMaxPassenger.Name = "tbMaxPassenger";
            this.tbMaxPassenger.Size = new System.Drawing.Size(25, 26);
            this.tbMaxPassenger.TabIndex = 13;
            // 
            // tbMinMarchandise
            // 
            this.tbMinMarchandise.Location = new System.Drawing.Point(616, 142);
            this.tbMinMarchandise.Name = "tbMinMarchandise";
            this.tbMinMarchandise.Size = new System.Drawing.Size(25, 26);
            this.tbMinMarchandise.TabIndex = 14;
            // 
            // tbMaxMarchandise
            // 
            this.tbMaxMarchandise.Location = new System.Drawing.Point(747, 142);
            this.tbMaxMarchandise.Name = "tbMaxMarchandise";
            this.tbMaxMarchandise.Size = new System.Drawing.Size(25, 26);
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
            this.btnAddAirport.Location = new System.Drawing.Point(830, 193);
            this.btnAddAirport.Name = "btnAddAirport";
            this.btnAddAirport.Size = new System.Drawing.Size(129, 40);
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
            this.btnAddAircraft.Location = new System.Drawing.Point(830, 424);
            this.btnAddAircraft.Name = "btnAddAircraft";
            this.btnAddAircraft.Size = new System.Drawing.Size(129, 40);
            this.btnAddAircraft.TabIndex = 29;
            this.btnAddAircraft.Text = "Add";
            this.btnAddAircraft.UseVisualStyleBackColor = false;
            this.btnAddAircraft.Click += new System.EventHandler(this.BtnAddAircraft_Click);
            // 
            // tbMaintenance
            // 
            this.tbMaintenance.Location = new System.Drawing.Point(272, 348);
            this.tbMaintenance.Name = "tbMaintenance";
            this.tbMaintenance.Size = new System.Drawing.Size(95, 26);
            this.tbMaintenance.TabIndex = 28;
            // 
            // tbUnload
            // 
            this.tbUnload.Location = new System.Drawing.Point(476, 384);
            this.tbUnload.Name = "tbUnload";
            this.tbUnload.Size = new System.Drawing.Size(95, 26);
            this.tbUnload.TabIndex = 27;
            // 
            // tbLoad
            // 
            this.tbLoad.Location = new System.Drawing.Point(476, 348);
            this.tbLoad.Name = "tbLoad";
            this.tbLoad.Size = new System.Drawing.Size(95, 26);
            this.tbLoad.TabIndex = 26;
            // 
            // tbSpeed
            // 
            this.tbSpeed.Location = new System.Drawing.Point(272, 384);
            this.tbSpeed.Name = "tbSpeed";
            this.tbSpeed.Size = new System.Drawing.Size(95, 26);
            this.tbSpeed.TabIndex = 25;
            // 
            // tbAircraftName
            // 
            this.tbAircraftName.Location = new System.Drawing.Point(56, 348);
            this.tbAircraftName.Name = "tbAircraftName";
            this.tbAircraftName.Size = new System.Drawing.Size(95, 26);
            this.tbAircraftName.TabIndex = 23;
            // 
            // lblAircraftMaintenance
            // 
            this.lblAircraftMaintenance.AutoSize = true;
            this.lblAircraftMaintenance.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAircraftMaintenance.Location = new System.Drawing.Point(168, 351);
            this.lblAircraftMaintenance.Name = "lblAircraftMaintenance";
            this.lblAircraftMaintenance.Size = new System.Drawing.Size(151, 20);
            this.lblAircraftMaintenance.TabIndex = 22;
            this.lblAircraftMaintenance.Text = "Maintenance Time:";
            // 
            // lblAircraftUnload
            // 
            this.lblAircraftUnload.AutoSize = true;
            this.lblAircraftUnload.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAircraftUnload.Location = new System.Drawing.Point(375, 387);
            this.lblAircraftUnload.Name = "lblAircraftUnload";
            this.lblAircraftUnload.Size = new System.Drawing.Size(130, 20);
            this.lblAircraftUnload.TabIndex = 21;
            this.lblAircraftUnload.Text = "Unloading Time:";
            // 
            // lblAircraftLoad
            // 
            this.lblAircraftLoad.AutoSize = true;
            this.lblAircraftLoad.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAircraftLoad.Location = new System.Drawing.Point(386, 351);
            this.lblAircraftLoad.Name = "lblAircraftLoad";
            this.lblAircraftLoad.Size = new System.Drawing.Size(115, 20);
            this.lblAircraftLoad.TabIndex = 20;
            this.lblAircraftLoad.Text = "Loading Time:";
            // 
            // lblAircraftSpeed
            // 
            this.lblAircraftSpeed.AutoSize = true;
            this.lblAircraftSpeed.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAircraftSpeed.Location = new System.Drawing.Point(168, 387);
            this.lblAircraftSpeed.Name = "lblAircraftSpeed";
            this.lblAircraftSpeed.Size = new System.Drawing.Size(61, 20);
            this.lblAircraftSpeed.TabIndex = 19;
            this.lblAircraftSpeed.Text = "Speed:";
            // 
            // lblAircraftType
            // 
            this.lblAircraftType.AutoSize = true;
            this.lblAircraftType.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAircraftType.Location = new System.Drawing.Point(15, 387);
            this.lblAircraftType.Name = "lblAircraftType";
            this.lblAircraftType.Size = new System.Drawing.Size(50, 20);
            this.lblAircraftType.TabIndex = 18;
            this.lblAircraftType.Text = "Type:";
            // 
            // lblAircraftName
            // 
            this.lblAircraftName.AutoSize = true;
            this.lblAircraftName.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAircraftName.Location = new System.Drawing.Point(12, 351);
            this.lblAircraftName.Name = "lblAircraftName";
            this.lblAircraftName.Size = new System.Drawing.Size(58, 20);
            this.lblAircraftName.TabIndex = 17;
            this.lblAircraftName.Text = "Name:";
            // 
            // btnGenerate
            // 
            this.btnGenerate.BackColor = System.Drawing.Color.Green;
            this.btnGenerate.FlatAppearance.BorderColor = System.Drawing.Color.Green;
            this.btnGenerate.FlatAppearance.BorderSize = 0;
            this.btnGenerate.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkGreen;
            this.btnGenerate.FlatAppearance.MouseOverBackColor = System.Drawing.Color.ForestGreen;
            this.btnGenerate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGenerate.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.btnGenerate.Location = new System.Drawing.Point(830, 529);
            this.btnGenerate.Name = "btnGenerate";
            this.btnGenerate.Size = new System.Drawing.Size(129, 40);
            this.btnGenerate.TabIndex = 36;
            this.btnGenerate.Text = "Generate";
            this.btnGenerate.UseVisualStyleBackColor = false;
            this.btnGenerate.Click += new System.EventHandler(this.BtnGenerate_Click);
            // 
            // Positions
            // 
            this.Positions.AutoSize = true;
            this.Positions.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Positions.Location = new System.Drawing.Point(123, 145);
            this.Positions.Name = "Positions";
            this.Positions.Size = new System.Drawing.Size(83, 20);
            this.Positions.TabIndex = 40;
            this.Positions.Text = "Positions:";
            // 
            // lsvAirport
            // 
            this.lsvAirport.HideSelection = false;
            this.lsvAirport.Location = new System.Drawing.Point(21, 37);
            this.lsvAirport.Name = "lsvAirport";
            this.lsvAirport.Size = new System.Drawing.Size(938, 97);
            this.lsvAirport.TabIndex = 41;
            this.lsvAirport.UseCompatibleStateImageBehavior = false;
            // 
            // lsvAircraft
            // 
            this.lsvAircraft.HideSelection = false;
            this.lsvAircraft.Location = new System.Drawing.Point(21, 245);
            this.lsvAircraft.Name = "lsvAircraft";
            this.lsvAircraft.Size = new System.Drawing.Size(938, 97);
            this.lsvAircraft.TabIndex = 42;
            this.lsvAircraft.UseCompatibleStateImageBehavior = false;
            // 
            // tbPositions
            // 
            this.tbPositions.Location = new System.Drawing.Point(177, 142);
            this.tbPositions.Name = "tbPositions";
            this.tbPositions.Size = new System.Drawing.Size(56, 26);
            this.tbPositions.TabIndex = 43;
            // 
            // btnMap
            // 
            this.btnMap.Location = new System.Drawing.Point(237, 140);
            this.btnMap.Name = "btnMap";
            this.btnMap.Size = new System.Drawing.Size(47, 23);
            this.btnMap.TabIndex = 44;
            this.btnMap.Text = "Map";
            this.btnMap.UseVisualStyleBackColor = true;
            this.btnMap.Click += new System.EventHandler(this.BtnMap_Click);
            // 
            // cmbAircraftType
            // 
            this.cmbAircraftType.FormattingEnabled = true;
            this.cmbAircraftType.Location = new System.Drawing.Point(56, 384);
            this.cmbAircraftType.Name = "cmbAircraftType";
            this.cmbAircraftType.Size = new System.Drawing.Size(95, 28);
            this.cmbAircraftType.TabIndex = 45;
            this.cmbAircraftType.SelectionChangeCommitted += new System.EventHandler(this.CmbAircraftType_SelectionChangeCommitted);
            // 
            // tbCapacity
            // 
            this.tbCapacity.Location = new System.Drawing.Point(652, 384);
            this.tbCapacity.Name = "tbCapacity";
            this.tbCapacity.Size = new System.Drawing.Size(95, 26);
            this.tbCapacity.TabIndex = 47;
            // 
            // lblCapacity
            // 
            this.lblCapacity.AutoSize = true;
            this.lblCapacity.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCapacity.Location = new System.Drawing.Point(593, 387);
            this.lblCapacity.Name = "lblCapacity";
            this.lblCapacity.Size = new System.Drawing.Size(79, 20);
            this.lblCapacity.TabIndex = 46;
            this.lblCapacity.Text = "Capacity:";
            // 
            // tbWeigth
            // 
            this.tbWeigth.Location = new System.Drawing.Point(652, 348);
            this.tbWeigth.Name = "tbWeigth";
            this.tbWeigth.Size = new System.Drawing.Size(95, 26);
            this.tbWeigth.TabIndex = 49;
            // 
            // lblWeigth
            // 
            this.lblWeigth.AutoSize = true;
            this.lblWeigth.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWeigth.Location = new System.Drawing.Point(593, 351);
            this.lblWeigth.Name = "lblWeigth";
            this.lblWeigth.Size = new System.Drawing.Size(66, 20);
            this.lblWeigth.TabIndex = 48;
            this.lblWeigth.Text = "Weigth:";
            // 
            // tbWaterCapacity
            // 
            this.tbWaterCapacity.Location = new System.Drawing.Point(864, 348);
            this.tbWaterCapacity.Name = "tbWaterCapacity";
            this.tbWaterCapacity.Size = new System.Drawing.Size(95, 26);
            this.tbWaterCapacity.TabIndex = 51;
            // 
            // lblWaterCapacity
            // 
            this.lblWaterCapacity.AutoSize = true;
            this.lblWaterCapacity.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWaterCapacity.Location = new System.Drawing.Point(775, 351);
            this.lblWaterCapacity.Name = "lblWaterCapacity";
            this.lblWaterCapacity.Size = new System.Drawing.Size(129, 20);
            this.lblWaterCapacity.TabIndex = 50;
            this.lblWaterCapacity.Text = "Water Capacity:";
            // 
            // tbDropTime
            // 
            this.tbDropTime.Location = new System.Drawing.Point(864, 384);
            this.tbDropTime.Name = "tbDropTime";
            this.tbDropTime.Size = new System.Drawing.Size(95, 26);
            this.tbDropTime.TabIndex = 53;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(775, 387);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(124, 20);
            this.label1.TabIndex = 52;
            this.label1.Text = "Dropping Time:";
            // 
            // BuilderGUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1147, 621);
            this.Controls.Add(this.tbDropTime);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbWaterCapacity);
            this.Controls.Add(this.lblWaterCapacity);
            this.Controls.Add(this.tbWeigth);
            this.Controls.Add(this.lblWeigth);
            this.Controls.Add(this.tbCapacity);
            this.Controls.Add(this.lblCapacity);
            this.Controls.Add(this.cmbAircraftType);
            this.Controls.Add(this.btnMap);
            this.Controls.Add(this.tbPositions);
            this.Controls.Add(this.lsvAircraft);
            this.Controls.Add(this.lsvAirport);
            this.Controls.Add(this.Positions);
            this.Controls.Add(this.btnGenerate);
            this.Controls.Add(this.btnAddAircraft);
            this.Controls.Add(this.tbMaintenance);
            this.Controls.Add(this.tbUnload);
            this.Controls.Add(this.tbLoad);
            this.Controls.Add(this.tbSpeed);
            this.Controls.Add(this.tbAircraftName);
            this.Controls.Add(this.lblAircraftMaintenance);
            this.Controls.Add(this.lblAircraftUnload);
            this.Controls.Add(this.lblAircraftLoad);
            this.Controls.Add(this.lblAircraftSpeed);
            this.Controls.Add(this.lblAircraftType);
            this.Controls.Add(this.lblAircraftName);
            this.Controls.Add(this.btnAddAirport);
            this.Controls.Add(this.tbMaxMarchandise);
            this.Controls.Add(this.tbMinMarchandise);
            this.Controls.Add(this.tbMaxPassenger);
            this.Controls.Add(this.tbMinPassenger);
            this.Controls.Add(this.tbAirportName);
            this.Controls.Add(this.lblMaxMarchandise);
            this.Controls.Add(this.lblMinMarchandise);
            this.Controls.Add(this.lblMaxPassenger);
            this.Controls.Add(this.lblMinPassenger);
            this.Controls.Add(this.lblAircraftTitle);
            this.Controls.Add(this.lblAirportTitle);
            this.Controls.Add(this.lblAirportName);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "BuilderGUI";
            this.ShowIcon = false;
            this.Text = "Scenario Builder";
            this.Load += new System.EventHandler(this.BuilderGUI_Load);
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
        private System.Windows.Forms.TextBox tbPositions;
        private System.Windows.Forms.Button btnMap;
        private System.Windows.Forms.ComboBox cmbAircraftType;
        private System.Windows.Forms.TextBox tbCapacity;
        private System.Windows.Forms.Label lblCapacity;
        private System.Windows.Forms.TextBox tbWeigth;
        private System.Windows.Forms.Label lblWeigth;
        private System.Windows.Forms.TextBox tbWaterCapacity;
        private System.Windows.Forms.Label lblWaterCapacity;
        private System.Windows.Forms.TextBox tbDropTime;
        private System.Windows.Forms.Label label1;
    }
}

