namespace Rca.Hue2Json.View
{
    partial class CapabilitySensorDetailsView
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.cat_Capabilities = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lbl_Zll = new System.Windows.Forms.Label();
            this.lbl_Zgp = new System.Windows.Forms.Label();
            this.lbl_Clip = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.lbl_SmartButton = new System.Windows.Forms.Label();
            this.lbl_DimmerSwitch = new System.Windows.Forms.Label();
            this.lbl_MotionSensor = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.cat_Capabilities)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // cat_Capabilities
            // 
            chartArea1.Name = "ChartArea1";
            this.cat_Capabilities.ChartAreas.Add(chartArea1);
            this.cat_Capabilities.Location = new System.Drawing.Point(12, 12);
            this.cat_Capabilities.Name = "cat_Capabilities";
            this.cat_Capabilities.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.Pastel;
            series1.ChartArea = "ChartArea1";
            series1.Name = "Series1";
            this.cat_Capabilities.Series.Add(series1);
            this.cat_Capabilities.Size = new System.Drawing.Size(345, 300);
            this.cat_Capabilities.TabIndex = 0;
            this.cat_Capabilities.Text = "chart1";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(16, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(27, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Clip:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(16, 53);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(29, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "ZLL:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(16, 79);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(32, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "ZGP:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lbl_Zll);
            this.groupBox1.Controls.Add(this.lbl_Zgp);
            this.groupBox1.Controls.Add(this.lbl_Clip);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 335);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(345, 113);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Bridge-Belegung";
            // 
            // lbl_Zll
            // 
            this.lbl_Zll.AutoSize = true;
            this.lbl_Zll.Location = new System.Drawing.Point(191, 53);
            this.lbl_Zll.Name = "lbl_Zll";
            this.lbl_Zll.Size = new System.Drawing.Size(34, 13);
            this.lbl_Zll.TabIndex = 5;
            this.lbl_Zll.Text = "lbl_Zll";
            // 
            // lbl_Zgp
            // 
            this.lbl_Zgp.AutoSize = true;
            this.lbl_Zgp.Location = new System.Drawing.Point(191, 79);
            this.lbl_Zgp.Name = "lbl_Zgp";
            this.lbl_Zgp.Size = new System.Drawing.Size(42, 13);
            this.lbl_Zgp.TabIndex = 6;
            this.lbl_Zgp.Text = "lbl_Zgp";
            // 
            // lbl_Clip
            // 
            this.lbl_Clip.AutoSize = true;
            this.lbl_Clip.Location = new System.Drawing.Point(191, 27);
            this.lbl_Clip.Name = "lbl_Clip";
            this.lbl_Clip.Size = new System.Drawing.Size(40, 13);
            this.lbl_Clip.TabIndex = 4;
            this.lbl_Clip.Text = "lbl_Clip";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.lbl_SmartButton);
            this.groupBox2.Controls.Add(this.lbl_DimmerSwitch);
            this.groupBox2.Controls.Add(this.lbl_MotionSensor);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Location = new System.Drawing.Point(13, 456);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(345, 113);
            this.groupBox2.TabIndex = 7;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Gerätekapazität";
            // 
            // lbl_SmartButton
            // 
            this.lbl_SmartButton.AutoSize = true;
            this.lbl_SmartButton.Location = new System.Drawing.Point(190, 53);
            this.lbl_SmartButton.Name = "lbl_SmartButton";
            this.lbl_SmartButton.Size = new System.Drawing.Size(81, 13);
            this.lbl_SmartButton.TabIndex = 5;
            this.lbl_SmartButton.Text = "lbl_SmartButton";
            // 
            // lbl_DimmerSwitch
            // 
            this.lbl_DimmerSwitch.AutoSize = true;
            this.lbl_DimmerSwitch.Location = new System.Drawing.Point(190, 79);
            this.lbl_DimmerSwitch.Name = "lbl_DimmerSwitch";
            this.lbl_DimmerSwitch.Size = new System.Drawing.Size(90, 13);
            this.lbl_DimmerSwitch.TabIndex = 6;
            this.lbl_DimmerSwitch.Text = "lbl_DimmerSwitch";
            // 
            // lbl_MotionSensor
            // 
            this.lbl_MotionSensor.AutoSize = true;
            this.lbl_MotionSensor.Location = new System.Drawing.Point(190, 27);
            this.lbl_MotionSensor.Name = "lbl_MotionSensor";
            this.lbl_MotionSensor.Size = new System.Drawing.Size(88, 13);
            this.lbl_MotionSensor.TabIndex = 4;
            this.lbl_MotionSensor.Text = "lbl_MotionSensor";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(15, 53);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(94, 13);
            this.label7.TabIndex = 2;
            this.label7.Text = "Hue Smart Button:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(15, 79);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(96, 13);
            this.label8.TabIndex = 3;
            this.label8.Text = "Hue Dimmschalter:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(15, 27);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(120, 13);
            this.label9.TabIndex = 1;
            this.label9.Text = "Hue Bewegungsmelder:";
            // 
            // CapabilitySensorDetailsView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(370, 581);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.cat_Capabilities);
            this.Name = "CapabilitySensorDetailsView";
            this.Text = "CapabilityView - Sensors";
            ((System.ComponentModel.ISupportInitialize)(this.cat_Capabilities)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataVisualization.Charting.Chart cat_Capabilities;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lbl_Zll;
        private System.Windows.Forms.Label lbl_Zgp;
        private System.Windows.Forms.Label lbl_Clip;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label lbl_SmartButton;
        private System.Windows.Forms.Label lbl_DimmerSwitch;
        private System.Windows.Forms.Label lbl_MotionSensor;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
    }
}