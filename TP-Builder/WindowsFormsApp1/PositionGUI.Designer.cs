namespace TPBuilder
{
    partial class PositionGUI
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
            this.pbMap = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pbMap)).BeginInit();
            this.SuspendLayout();
            // 
            // pbMap
            // 
            this.pbMap.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pbMap.Location = new System.Drawing.Point(27, 17);
            this.pbMap.Margin = new System.Windows.Forms.Padding(2);
            this.pbMap.Name = "pbMap";
            this.pbMap.Size = new System.Drawing.Size(1026, 591);
            this.pbMap.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pbMap.TabIndex = 0;
            this.pbMap.TabStop = false;
            this.pbMap.Click += new System.EventHandler(this.PbMap_Click);
            this.pbMap.Paint += new System.Windows.Forms.PaintEventHandler(this.PbMap_Paint);
            // 
            // PositionGUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1084, 631);
            this.Controls.Add(this.pbMap);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "PositionGUI";
            this.ShowIcon = false;
            this.Text = "Map";
            this.Load += new System.EventHandler(this.PositionGUI_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pbMap)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pbMap;
    }
}