namespace PresentationLogic
{
    partial class PrimaryForm
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
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.label9 = new System.Windows.Forms.Label();
            this.DiastolicMinTB = new System.Windows.Forms.TextBox();
            this.DiastolicMaxTB = new System.Windows.Forms.TextBox();
            this.SystolicMinTB = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.ThresholdCheckpoint = new System.Windows.Forms.CheckBox();
            this.label5 = new System.Windows.Forms.Label();
            this.CalibrationBT = new System.Windows.Forms.Button();
            this.ZeroPointAdjustmentBT = new System.Windows.Forms.Button();
            this.SaveBT = new System.Windows.Forms.Button();
            this.StartStopBT = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.mmHgTB = new System.Windows.Forms.Label();
            this.PulseTB = new System.Windows.Forms.TextBox();
            this.AverageBP_TB = new System.Windows.Forms.TextBox();
            this.SysDiaTB = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.SystolicMaxTB = new System.Windows.Forms.TextBox();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.AdaptThresholdsBT = new System.Windows.Forms.Button();
            this.FilterB = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            this.SuspendLayout();
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.White;
            this.label9.Location = new System.Drawing.Point(263, 285);
            this.label9.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(44, 20);
            this.label9.TabIndex = 42;
            this.label9.Text = "Filter";
            // 
            // DiastolicMinTB
            // 
            this.DiastolicMinTB.Enabled = false;
            this.DiastolicMinTB.Location = new System.Drawing.Point(185, 315);
            this.DiastolicMinTB.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.DiastolicMinTB.Multiline = true;
            this.DiastolicMinTB.Name = "DiastolicMinTB";
            this.DiastolicMinTB.Size = new System.Drawing.Size(51, 23);
            this.DiastolicMinTB.TabIndex = 41;
            // 
            // DiastolicMaxTB
            // 
            this.DiastolicMaxTB.Enabled = false;
            this.DiastolicMaxTB.Location = new System.Drawing.Point(127, 315);
            this.DiastolicMaxTB.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.DiastolicMaxTB.Multiline = true;
            this.DiastolicMaxTB.Name = "DiastolicMaxTB";
            this.DiastolicMaxTB.Size = new System.Drawing.Size(53, 23);
            this.DiastolicMaxTB.TabIndex = 40;
            // 
            // SystolicMinTB
            // 
            this.SystolicMinTB.Enabled = false;
            this.SystolicMinTB.Location = new System.Drawing.Point(73, 315);
            this.SystolicMinTB.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.SystolicMinTB.Multiline = true;
            this.SystolicMinTB.Name = "SystolicMinTB";
            this.SystolicMinTB.Size = new System.Drawing.Size(51, 23);
            this.SystolicMinTB.TabIndex = 39;
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(-118, 320);
            this.textBox4.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.textBox4.Multiline = true;
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(37, 23);
            this.textBox4.TabIndex = 38;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.White;
            this.label8.Location = new System.Drawing.Point(124, 292);
            this.label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(69, 20);
            this.label8.TabIndex = 37;
            this.label8.Text = "Diastolic";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(-122, 298);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(56, 17);
            this.label7.TabIndex = 36;
            this.label7.Text = "Systolic";
            // 
            // ThresholdCheckpoint
            // 
            this.ThresholdCheckpoint.AllowDrop = true;
            this.ThresholdCheckpoint.FlatAppearance.CheckedBackColor = System.Drawing.Color.White;
            this.ThresholdCheckpoint.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ThresholdCheckpoint.Location = new System.Drawing.Point(173, 264);
            this.ThresholdCheckpoint.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.ThresholdCheckpoint.Name = "ThresholdCheckpoint";
            this.ThresholdCheckpoint.Size = new System.Drawing.Size(15, 26);
            this.ThresholdCheckpoint.TabIndex = 35;
            this.ThresholdCheckpoint.Text = "ThresholdCheckpoint";
            this.ThresholdCheckpoint.UseVisualStyleBackColor = true;
            this.ThresholdCheckpoint.CheckedChanged += new System.EventHandler(this.ThresholdCheckpoint_CheckedChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(17, 264);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(153, 20);
            this.label5.TabIndex = 34;
            this.label5.Text = "Adjust Thresholds";
            // 
            // CalibrationBT
            // 
            this.CalibrationBT.BackColor = System.Drawing.Color.DimGray;
            this.CalibrationBT.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CalibrationBT.Location = new System.Drawing.Point(448, 337);
            this.CalibrationBT.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.CalibrationBT.Name = "CalibrationBT";
            this.CalibrationBT.Size = new System.Drawing.Size(147, 51);
            this.CalibrationBT.TabIndex = 33;
            this.CalibrationBT.Text = "Calibration";
            this.CalibrationBT.UseVisualStyleBackColor = false;
            this.CalibrationBT.Click += new System.EventHandler(this.CalibrationBT_Click);
            // 
            // ZeroPointAdjustmentBT
            // 
            this.ZeroPointAdjustmentBT.BackColor = System.Drawing.Color.DimGray;
            this.ZeroPointAdjustmentBT.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ZeroPointAdjustmentBT.Location = new System.Drawing.Point(251, 337);
            this.ZeroPointAdjustmentBT.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.ZeroPointAdjustmentBT.Name = "ZeroPointAdjustmentBT";
            this.ZeroPointAdjustmentBT.Size = new System.Drawing.Size(177, 51);
            this.ZeroPointAdjustmentBT.TabIndex = 32;
            this.ZeroPointAdjustmentBT.Text = "Zero Point Adjustment";
            this.ZeroPointAdjustmentBT.UseVisualStyleBackColor = false;
            this.ZeroPointAdjustmentBT.Click += new System.EventHandler(this.ZeroPointAdjustmentBT_Click);
            // 
            // SaveBT
            // 
            this.SaveBT.BackColor = System.Drawing.Color.DimGray;
            this.SaveBT.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SaveBT.ForeColor = System.Drawing.Color.Black;
            this.SaveBT.Location = new System.Drawing.Point(448, 272);
            this.SaveBT.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.SaveBT.Name = "SaveBT";
            this.SaveBT.Size = new System.Drawing.Size(147, 51);
            this.SaveBT.TabIndex = 31;
            this.SaveBT.Text = "Save";
            this.SaveBT.UseVisualStyleBackColor = false;
            this.SaveBT.Click += new System.EventHandler(this.SaveBT_Click);
            // 
            // StartStopBT
            // 
            this.StartStopBT.BackColor = System.Drawing.Color.Lime;
            this.StartStopBT.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.StartStopBT.Location = new System.Drawing.Point(610, 272);
            this.StartStopBT.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.StartStopBT.Name = "StartStopBT";
            this.StartStopBT.Size = new System.Drawing.Size(208, 116);
            this.StartStopBT.TabIndex = 30;
            this.StartStopBT.Text = "START";
            this.StartStopBT.UseVisualStyleBackColor = false;
            this.StartStopBT.Click += new System.EventHandler(this.StartStopBT_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Yellow;
            this.label3.Location = new System.Drawing.Point(739, 164);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(70, 20);
            this.label3.TabIndex = 29;
            this.label3.Text = "beat/min";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Blue;
            this.label2.Location = new System.Drawing.Point(754, 103);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 20);
            this.label2.TabIndex = 28;
            this.label2.Text = "mmHg";
            // 
            // mmHgTB
            // 
            this.mmHgTB.AutoSize = true;
            this.mmHgTB.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mmHgTB.ForeColor = System.Drawing.Color.Lime;
            this.mmHgTB.Location = new System.Drawing.Point(754, 40);
            this.mmHgTB.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.mmHgTB.Name = "mmHgTB";
            this.mmHgTB.Size = new System.Drawing.Size(56, 20);
            this.mmHgTB.TabIndex = 27;
            this.mmHgTB.Text = "mmHg";
            // 
            // PulseTB
            // 
            this.PulseTB.BackColor = System.Drawing.Color.Black;
            this.PulseTB.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.PulseTB.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PulseTB.ForeColor = System.Drawing.Color.Yellow;
            this.PulseTB.Location = new System.Drawing.Point(690, 142);
            this.PulseTB.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.PulseTB.Multiline = true;
            this.PulseTB.Name = "PulseTB";
            this.PulseTB.Size = new System.Drawing.Size(53, 51);
            this.PulseTB.TabIndex = 26;
            this.PulseTB.Text = "60";
            this.PulseTB.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // AverageBP_TB
            // 
            this.AverageBP_TB.BackColor = System.Drawing.Color.Black;
            this.AverageBP_TB.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.AverageBP_TB.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AverageBP_TB.ForeColor = System.Drawing.Color.Blue;
            this.AverageBP_TB.Location = new System.Drawing.Point(679, 82);
            this.AverageBP_TB.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.AverageBP_TB.Multiline = true;
            this.AverageBP_TB.Name = "AverageBP_TB";
            this.AverageBP_TB.Size = new System.Drawing.Size(71, 49);
            this.AverageBP_TB.TabIndex = 25;
            this.AverageBP_TB.Text = "100 ";
            this.AverageBP_TB.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // SysDiaTB
            // 
            this.SysDiaTB.BackColor = System.Drawing.Color.Black;
            this.SysDiaTB.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.SysDiaTB.Font = new System.Drawing.Font("Microsoft Sans Serif", 32F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SysDiaTB.ForeColor = System.Drawing.Color.Lime;
            this.SysDiaTB.Location = new System.Drawing.Point(610, 19);
            this.SysDiaTB.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.SysDiaTB.Multiline = true;
            this.SysDiaTB.Name = "SysDiaTB";
            this.SysDiaTB.Size = new System.Drawing.Size(140, 58);
            this.SysDiaTB.TabIndex = 24;
            this.SysDiaTB.Text = "120/80";
            this.SysDiaTB.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(17, 292);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(63, 20);
            this.label4.TabIndex = 44;
            this.label4.Text = "Systolic";
            // 
            // SystolicMaxTB
            // 
            this.SystolicMaxTB.Enabled = false;
            this.SystolicMaxTB.Location = new System.Drawing.Point(20, 315);
            this.SystolicMaxTB.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.SystolicMaxTB.Multiline = true;
            this.SystolicMaxTB.Name = "SystolicMaxTB";
            this.SystolicMaxTB.Size = new System.Drawing.Size(50, 23);
            this.SystolicMaxTB.TabIndex = 45;
            this.SystolicMaxTB.TextChanged += new System.EventHandler(this.SystolicMaxTB_TextChanged);
            // 
            // chart1
            // 
            this.chart1.BackColor = System.Drawing.Color.Black;
            chartArea1.AxisX.Title = "Time (ms)";
            chartArea1.AxisX.TitleForeColor = System.Drawing.Color.Lime;
            chartArea1.AxisY.Title = "Pressure (mmHg)";
            chartArea1.AxisY.TitleForeColor = System.Drawing.Color.Lime;
            chartArea1.BackColor = System.Drawing.Color.Black;
            chartArea1.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea1);
            legend1.Enabled = false;
            legend1.Name = "Legend1";
            this.chart1.Legends.Add(legend1);
            this.chart1.Location = new System.Drawing.Point(8, 8);
            this.chart1.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.chart1.Name = "chart1";
            series1.BorderColor = System.Drawing.Color.Black;
            series1.BorderWidth = 3;
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series1.Color = System.Drawing.Color.Lime;
            series1.LabelBackColor = System.Drawing.Color.Black;
            series1.LabelBorderColor = System.Drawing.Color.Black;
            series1.LabelForeColor = System.Drawing.Color.Lime;
            series1.Legend = "Legend1";
            series1.Name = "Blood Pressure";
            this.chart1.Series.Add(series1);
            this.chart1.Size = new System.Drawing.Size(602, 243);
            this.chart1.TabIndex = 46;
            this.chart1.Text = "Blood pressure";
            this.chart1.Click += new System.EventHandler(this.chart1_Click);
            // 
            // AdaptThresholdsBT
            // 
            this.AdaptThresholdsBT.BackColor = System.Drawing.Color.DimGray;
            this.AdaptThresholdsBT.Enabled = false;
            this.AdaptThresholdsBT.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AdaptThresholdsBT.Location = new System.Drawing.Point(20, 352);
            this.AdaptThresholdsBT.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.AdaptThresholdsBT.Name = "AdaptThresholdsBT";
            this.AdaptThresholdsBT.Size = new System.Drawing.Size(214, 34);
            this.AdaptThresholdsBT.TabIndex = 47;
            this.AdaptThresholdsBT.Text = "Adapt thresholds";
            this.AdaptThresholdsBT.UseVisualStyleBackColor = false;
            this.AdaptThresholdsBT.Click += new System.EventHandler(this.AdaptThresholdsBT_Click);
            // 
            // FilterB
            // 
            this.FilterB.BackColor = System.Drawing.Color.Lime;
            this.FilterB.Location = new System.Drawing.Point(319, 285);
            this.FilterB.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.FilterB.Name = "FilterB";
            this.FilterB.Size = new System.Drawing.Size(75, 23);
            this.FilterB.TabIndex = 48;
            this.FilterB.Text = "ON";
            this.FilterB.UseVisualStyleBackColor = false;
            this.FilterB.Click += new System.EventHandler(this.FilterB_Click);
            // 
            // PrimaryForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(840, 413);
            this.Controls.Add(this.FilterB);
            this.Controls.Add(this.AdaptThresholdsBT);
            this.Controls.Add(this.chart1);
            this.Controls.Add(this.SystolicMaxTB);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.DiastolicMinTB);
            this.Controls.Add(this.DiastolicMaxTB);
            this.Controls.Add(this.SystolicMinTB);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.ThresholdCheckpoint);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.CalibrationBT);
            this.Controls.Add(this.ZeroPointAdjustmentBT);
            this.Controls.Add(this.SaveBT);
            this.Controls.Add(this.StartStopBT);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.mmHgTB);
            this.Controls.Add(this.PulseTB);
            this.Controls.Add(this.AverageBP_TB);
            this.Controls.Add(this.SysDiaTB);
            this.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.Name = "PrimaryForm";
            this.Text = "Invasiv Blodtrykssystem (IBS)";
            this.Load += new System.EventHandler(this.PrimaryForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox DiastolicMinTB;
        private System.Windows.Forms.TextBox DiastolicMaxTB;
        private System.Windows.Forms.TextBox SystolicMinTB;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.CheckBox ThresholdCheckpoint;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button CalibrationBT;
        private System.Windows.Forms.Button ZeroPointAdjustmentBT;
        private System.Windows.Forms.Button SaveBT;
        private System.Windows.Forms.Button StartStopBT;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label mmHgTB;
        private System.Windows.Forms.TextBox PulseTB;
        private System.Windows.Forms.TextBox AverageBP_TB;
        private System.Windows.Forms.TextBox SysDiaTB;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox SystolicMaxTB;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.Button AdaptThresholdsBT;
      private System.Windows.Forms.Button FilterB;
   }
}

