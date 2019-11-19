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
            this.lsbAirport = new System.Windows.Forms.ListBox();
            this.lsbAircraft = new System.Windows.Forms.ListBox();
            this.lblAirportName = new System.Windows.Forms.Label();
            this.lblAirportPosition = new System.Windows.Forms.Label();
            this.lblAirportTitle = new System.Windows.Forms.Label();
            this.lblAircraftTitle = new System.Windows.Forms.Label();
            this.lblMinPassenger = new System.Windows.Forms.Label();
            this.lblMaxPassenger = new System.Windows.Forms.Label();
            this.lblMinMarchandise = new System.Windows.Forms.Label();
            this.lblMaxMarchandise = new System.Windows.Forms.Label();
            this.tbAirportName = new System.Windows.Forms.TextBox();
            this.tbAirportPosition = new System.Windows.Forms.TextBox();
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
            this.tbType = new System.Windows.Forms.TextBox();
            this.tbAircraftName = new System.Windows.Forms.TextBox();
            this.lblAircraftMaintenance = new System.Windows.Forms.Label();
            this.lblAircraftUnload = new System.Windows.Forms.Label();
            this.lblAircraftLoad = new System.Windows.Forms.Label();
            this.lblAircraftSpeed = new System.Windows.Forms.Label();
            this.lblAircraftType = new System.Windows.Forms.Label();
            this.lblAircraftName = new System.Windows.Forms.Label();
            this.lblMapImage = new System.Windows.Forms.Label();
            this.lblAirportImage = new System.Windows.Forms.Label();
            this.lblAircraftImage = new System.Windows.Forms.Label();
            this.tbMapImage = new System.Windows.Forms.TextBox();
            this.tbAirportImage = new System.Windows.Forms.TextBox();
            this.tbAircraftImage = new System.Windows.Forms.TextBox();
            this.btnGenerate = new System.Windows.Forms.Button();
            this.label10 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lsbAirport
            // 
            this.lsbAirport.FormattingEnabled = true;
            this.lsbAirport.Location = new System.Drawing.Point(12, 30);
            this.lsbAirport.Name = "lsbAirport";
            this.lsbAirport.Size = new System.Drawing.Size(760, 95);
            this.lsbAirport.TabIndex = 0;
            // 
            // lsbAircraft
            // 
            this.lsbAircraft.FormattingEnabled = true;
            this.lsbAircraft.Location = new System.Drawing.Point(12, 236);
            this.lsbAircraft.Name = "lsbAircraft";
            this.lsbAircraft.Size = new System.Drawing.Size(760, 95);
            this.lsbAircraft.TabIndex = 1;
            // 
            // lblAirportName
            // 
            this.lblAirportName.AutoSize = true;
            this.lblAirportName.Location = new System.Drawing.Point(9, 145);
            this.lblAirportName.Name = "lblAirportName";
            this.lblAirportName.Size = new System.Drawing.Size(38, 13);
            this.lblAirportName.TabIndex = 2;
            this.lblAirportName.Text = "Name:";
            // 
            // lblAirportPosition
            // 
            this.lblAirportPosition.AutoSize = true;
            this.lblAirportPosition.Location = new System.Drawing.Point(137, 145);
            this.lblAirportPosition.Name = "lblAirportPosition";
            this.lblAirportPosition.Size = new System.Drawing.Size(45, 13);
            this.lblAirportPosition.TabIndex = 3;
            this.lblAirportPosition.Text = "Positon:";
            // 
            // lblAirportTitle
            // 
            this.lblAirportTitle.AutoSize = true;
            this.lblAirportTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAirportTitle.Location = new System.Drawing.Point(16, 8);
            this.lblAirportTitle.Name = "lblAirportTitle";
            this.lblAirportTitle.Size = new System.Drawing.Size(57, 17);
            this.lblAirportTitle.TabIndex = 4;
            this.lblAirportTitle.Text = "Airport";
            // 
            // lblAircraftTitle
            // 
            this.lblAircraftTitle.AutoSize = true;
            this.lblAircraftTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAircraftTitle.Location = new System.Drawing.Point(16, 216);
            this.lblAircraftTitle.Name = "lblAircraftTitle";
            this.lblAircraftTitle.Size = new System.Drawing.Size(61, 17);
            this.lblAircraftTitle.TabIndex = 5;
            this.lblAircraftTitle.Text = "Aircraft";
            // 
            // lblMinPassenger
            // 
            this.lblMinPassenger.AutoSize = true;
            this.lblMinPassenger.Location = new System.Drawing.Point(276, 145);
            this.lblMinPassenger.Name = "lblMinPassenger";
            this.lblMinPassenger.Size = new System.Drawing.Size(82, 13);
            this.lblMinPassenger.TabIndex = 6;
            this.lblMinPassenger.Text = "MinPassengers:";
            // 
            // lblMaxPassenger
            // 
            this.lblMaxPassenger.AutoSize = true;
            this.lblMaxPassenger.Location = new System.Drawing.Point(395, 145);
            this.lblMaxPassenger.Name = "lblMaxPassenger";
            this.lblMaxPassenger.Size = new System.Drawing.Size(85, 13);
            this.lblMaxPassenger.TabIndex = 7;
            this.lblMaxPassenger.Text = "MaxPassengers:";
            // 
            // lblMinMarchandise
            // 
            this.lblMinMarchandise.AutoSize = true;
            this.lblMinMarchandise.Location = new System.Drawing.Point(522, 145);
            this.lblMinMarchandise.Name = "lblMinMarchandise";
            this.lblMinMarchandise.Size = new System.Drawing.Size(88, 13);
            this.lblMinMarchandise.TabIndex = 8;
            this.lblMinMarchandise.Text = "MinMarchandise:";
            // 
            // lblMaxMarchandise
            // 
            this.lblMaxMarchandise.AutoSize = true;
            this.lblMaxMarchandise.Location = new System.Drawing.Point(650, 145);
            this.lblMaxMarchandise.Name = "lblMaxMarchandise";
            this.lblMaxMarchandise.Size = new System.Drawing.Size(91, 13);
            this.lblMaxMarchandise.TabIndex = 9;
            this.lblMaxMarchandise.Text = "MaxMarchandise:";
            // 
            // tbAirportName
            // 
            this.tbAirportName.Location = new System.Drawing.Point(56, 142);
            this.tbAirportName.Name = "tbAirportName";
            this.tbAirportName.Size = new System.Drawing.Size(75, 20);
            this.tbAirportName.TabIndex = 10;
            // 
            // tbAirportPosition
            // 
            this.tbAirportPosition.Location = new System.Drawing.Point(188, 142);
            this.tbAirportPosition.Name = "tbAirportPosition";
            this.tbAirportPosition.Size = new System.Drawing.Size(75, 20);
            this.tbAirportPosition.TabIndex = 11;
            // 
            // tbMinPassenger
            // 
            this.tbMinPassenger.Location = new System.Drawing.Point(364, 142);
            this.tbMinPassenger.Name = "tbMinPassenger";
            this.tbMinPassenger.Size = new System.Drawing.Size(25, 20);
            this.tbMinPassenger.TabIndex = 12;
            // 
            // tbMaxPassenger
            // 
            this.tbMaxPassenger.Location = new System.Drawing.Point(486, 142);
            this.tbMaxPassenger.Name = "tbMaxPassenger";
            this.tbMaxPassenger.Size = new System.Drawing.Size(25, 20);
            this.tbMaxPassenger.TabIndex = 13;
            // 
            // tbMinMarchandise
            // 
            this.tbMinMarchandise.Location = new System.Drawing.Point(616, 142);
            this.tbMinMarchandise.Name = "tbMinMarchandise";
            this.tbMinMarchandise.Size = new System.Drawing.Size(25, 20);
            this.tbMinMarchandise.TabIndex = 14;
            // 
            // tbMaxMarchandise
            // 
            this.tbMaxMarchandise.Location = new System.Drawing.Point(747, 142);
            this.tbMaxMarchandise.Name = "tbMaxMarchandise";
            this.tbMaxMarchandise.Size = new System.Drawing.Size(25, 20);
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
            this.btnAddAirport.Location = new System.Drawing.Point(12, 177);
            this.btnAddAirport.Name = "btnAddAirport";
            this.btnAddAirport.Size = new System.Drawing.Size(759, 23);
            this.btnAddAirport.TabIndex = 16;
            this.btnAddAirport.TabStop = false;
            this.btnAddAirport.Text = "Add";
            this.btnAddAirport.UseVisualStyleBackColor = false;
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
            this.btnAddAircraft.Location = new System.Drawing.Point(12, 383);
            this.btnAddAircraft.Name = "btnAddAircraft";
            this.btnAddAircraft.Size = new System.Drawing.Size(759, 23);
            this.btnAddAircraft.TabIndex = 29;
            this.btnAddAircraft.Text = "Add";
            this.btnAddAircraft.UseVisualStyleBackColor = false;
            // 
            // tbMaintenance
            // 
            this.tbMaintenance.Location = new System.Drawing.Point(691, 348);
            this.tbMaintenance.Name = "tbMaintenance";
            this.tbMaintenance.Size = new System.Drawing.Size(80, 20);
            this.tbMaintenance.TabIndex = 28;
            // 
            // tbUnload
            // 
            this.tbUnload.Location = new System.Drawing.Point(545, 348);
            this.tbUnload.Name = "tbUnload";
            this.tbUnload.Size = new System.Drawing.Size(50, 20);
            this.tbUnload.TabIndex = 27;
            // 
            // tbLoad
            // 
            this.tbLoad.Location = new System.Drawing.Point(430, 348);
            this.tbLoad.Name = "tbLoad";
            this.tbLoad.Size = new System.Drawing.Size(50, 20);
            this.tbLoad.TabIndex = 26;
            // 
            // tbSpeed
            // 
            this.tbSpeed.Location = new System.Drawing.Point(323, 348);
            this.tbSpeed.Name = "tbSpeed";
            this.tbSpeed.Size = new System.Drawing.Size(65, 20);
            this.tbSpeed.TabIndex = 25;
            // 
            // tbType
            // 
            this.tbType.Location = new System.Drawing.Point(188, 348);
            this.tbType.Name = "tbType";
            this.tbType.Size = new System.Drawing.Size(75, 20);
            this.tbType.TabIndex = 24;
            // 
            // tbAircraftName
            // 
            this.tbAircraftName.Location = new System.Drawing.Point(56, 348);
            this.tbAircraftName.Name = "tbAircraftName";
            this.tbAircraftName.Size = new System.Drawing.Size(75, 20);
            this.tbAircraftName.TabIndex = 23;
            // 
            // lblAircraftMaintenance
            // 
            this.lblAircraftMaintenance.AutoSize = true;
            this.lblAircraftMaintenance.Location = new System.Drawing.Point(613, 351);
            this.lblAircraftMaintenance.Name = "lblAircraftMaintenance";
            this.lblAircraftMaintenance.Size = new System.Drawing.Size(72, 13);
            this.lblAircraftMaintenance.TabIndex = 22;
            this.lblAircraftMaintenance.Text = "Maintenance:";
            // 
            // lblAircraftUnload
            // 
            this.lblAircraftUnload.AutoSize = true;
            this.lblAircraftUnload.Location = new System.Drawing.Point(495, 351);
            this.lblAircraftUnload.Name = "lblAircraftUnload";
            this.lblAircraftUnload.Size = new System.Drawing.Size(44, 13);
            this.lblAircraftUnload.TabIndex = 21;
            this.lblAircraftUnload.Text = "Unload:";
            // 
            // lblAircraftLoad
            // 
            this.lblAircraftLoad.AutoSize = true;
            this.lblAircraftLoad.Location = new System.Drawing.Point(395, 351);
            this.lblAircraftLoad.Name = "lblAircraftLoad";
            this.lblAircraftLoad.Size = new System.Drawing.Size(34, 13);
            this.lblAircraftLoad.TabIndex = 20;
            this.lblAircraftLoad.Text = "Load:";
            // 
            // lblAircraftSpeed
            // 
            this.lblAircraftSpeed.AutoSize = true;
            this.lblAircraftSpeed.Location = new System.Drawing.Point(276, 351);
            this.lblAircraftSpeed.Name = "lblAircraftSpeed";
            this.lblAircraftSpeed.Size = new System.Drawing.Size(41, 13);
            this.lblAircraftSpeed.TabIndex = 19;
            this.lblAircraftSpeed.Text = "Speed:";
            // 
            // lblAircraftType
            // 
            this.lblAircraftType.AutoSize = true;
            this.lblAircraftType.Location = new System.Drawing.Point(137, 351);
            this.lblAircraftType.Name = "lblAircraftType";
            this.lblAircraftType.Size = new System.Drawing.Size(34, 13);
            this.lblAircraftType.TabIndex = 18;
            this.lblAircraftType.Text = "Type:";
            // 
            // lblAircraftName
            // 
            this.lblAircraftName.AutoSize = true;
            this.lblAircraftName.Location = new System.Drawing.Point(12, 351);
            this.lblAircraftName.Name = "lblAircraftName";
            this.lblAircraftName.Size = new System.Drawing.Size(38, 13);
            this.lblAircraftName.TabIndex = 17;
            this.lblAircraftName.Text = "Name:";
            // 
            // lblMapImage
            // 
            this.lblMapImage.AutoSize = true;
            this.lblMapImage.Location = new System.Drawing.Point(12, 457);
            this.lblMapImage.Name = "lblMapImage";
            this.lblMapImage.Size = new System.Drawing.Size(62, 13);
            this.lblMapImage.TabIndex = 30;
            this.lblMapImage.Text = "Map image:";
            // 
            // lblAirportImage
            // 
            this.lblAirportImage.AutoSize = true;
            this.lblAirportImage.Location = new System.Drawing.Point(264, 457);
            this.lblAirportImage.Name = "lblAirportImage";
            this.lblAirportImage.Size = new System.Drawing.Size(68, 13);
            this.lblAirportImage.TabIndex = 31;
            this.lblAirportImage.Text = "Airport image";
            // 
            // lblAircraftImage
            // 
            this.lblAircraftImage.AutoSize = true;
            this.lblAircraftImage.Location = new System.Drawing.Point(519, 457);
            this.lblAircraftImage.Name = "lblAircraftImage";
            this.lblAircraftImage.Size = new System.Drawing.Size(71, 13);
            this.lblAircraftImage.TabIndex = 32;
            this.lblAircraftImage.Text = "Aircraft image";
            // 
            // tbMapImage
            // 
            this.tbMapImage.Location = new System.Drawing.Point(80, 454);
            this.tbMapImage.Name = "tbMapImage";
            this.tbMapImage.Size = new System.Drawing.Size(175, 20);
            this.tbMapImage.TabIndex = 33;
            // 
            // tbAirportImage
            // 
            this.tbAirportImage.Location = new System.Drawing.Point(338, 454);
            this.tbAirportImage.Name = "tbAirportImage";
            this.tbAirportImage.Size = new System.Drawing.Size(175, 20);
            this.tbAirportImage.TabIndex = 34;
            // 
            // tbAircraftImage
            // 
            this.tbAircraftImage.Location = new System.Drawing.Point(596, 454);
            this.tbAircraftImage.Name = "tbAircraftImage";
            this.tbAircraftImage.Size = new System.Drawing.Size(175, 20);
            this.tbAircraftImage.TabIndex = 35;
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
            this.btnGenerate.Location = new System.Drawing.Point(12, 494);
            this.btnGenerate.Name = "btnGenerate";
            this.btnGenerate.Size = new System.Drawing.Size(759, 23);
            this.btnGenerate.TabIndex = 36;
            this.btnGenerate.Text = "Generate";
            this.btnGenerate.UseVisualStyleBackColor = false;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(16, 425);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(86, 17);
            this.label10.TabIndex = 37;
            this.label10.Text = "Image files";
            // 
            // BuilderGUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 561);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.btnGenerate);
            this.Controls.Add(this.tbAircraftImage);
            this.Controls.Add(this.tbAirportImage);
            this.Controls.Add(this.tbMapImage);
            this.Controls.Add(this.lblAircraftImage);
            this.Controls.Add(this.lblAirportImage);
            this.Controls.Add(this.lblMapImage);
            this.Controls.Add(this.btnAddAircraft);
            this.Controls.Add(this.tbMaintenance);
            this.Controls.Add(this.tbUnload);
            this.Controls.Add(this.tbLoad);
            this.Controls.Add(this.tbSpeed);
            this.Controls.Add(this.tbType);
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
            this.Controls.Add(this.tbAirportPosition);
            this.Controls.Add(this.tbAirportName);
            this.Controls.Add(this.lblMaxMarchandise);
            this.Controls.Add(this.lblMinMarchandise);
            this.Controls.Add(this.lblMaxPassenger);
            this.Controls.Add(this.lblMinPassenger);
            this.Controls.Add(this.lblAircraftTitle);
            this.Controls.Add(this.lblAirportTitle);
            this.Controls.Add(this.lblAirportPosition);
            this.Controls.Add(this.lblAirportName);
            this.Controls.Add(this.lsbAircraft);
            this.Controls.Add(this.lsbAirport);
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

        private System.Windows.Forms.ListBox lsbAirport;
        private System.Windows.Forms.ListBox lsbAircraft;
        private System.Windows.Forms.Label lblAirportName;
        private System.Windows.Forms.Label lblAirportPosition;
        private System.Windows.Forms.Label lblAirportTitle;
        private System.Windows.Forms.Label lblAircraftTitle;
        private System.Windows.Forms.Label lblMinPassenger;
        private System.Windows.Forms.Label lblMaxPassenger;
        private System.Windows.Forms.Label lblMinMarchandise;
        private System.Windows.Forms.Label lblMaxMarchandise;
        private System.Windows.Forms.TextBox tbAirportName;
        private System.Windows.Forms.TextBox tbAirportPosition;
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
        private System.Windows.Forms.TextBox tbType;
        private System.Windows.Forms.TextBox tbAircraftName;
        private System.Windows.Forms.Label lblAircraftMaintenance;
        private System.Windows.Forms.Label lblAircraftUnload;
        private System.Windows.Forms.Label lblAircraftLoad;
        private System.Windows.Forms.Label lblAircraftSpeed;
        private System.Windows.Forms.Label lblAircraftType;
        private System.Windows.Forms.Label lblAircraftName;
        private System.Windows.Forms.Label lblMapImage;
        private System.Windows.Forms.Label lblAirportImage;
        private System.Windows.Forms.Label lblAircraftImage;
        private System.Windows.Forms.TextBox tbMapImage;
        private System.Windows.Forms.TextBox tbAirportImage;
        private System.Windows.Forms.TextBox tbAircraftImage;
        private System.Windows.Forms.Button btnGenerate;
        private System.Windows.Forms.Label label10;
    }
}

