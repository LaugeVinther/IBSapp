﻿namespace PresentationLogic
{
    partial class CalibrateForm
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
            this.Measure10mmHgBT = new System.Windows.Forms.Button();
            this.Measure50mmHgBT = new System.Windows.Forms.Button();
            this.Measure100mmHgBT = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.CalibrateBT = new System.Windows.Forms.Button();
            this.DateOfCalibration = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Measure10mmHgBT
            // 
            this.Measure10mmHgBT.BackColor = System.Drawing.SystemColors.Control;
            this.Measure10mmHgBT.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Measure10mmHgBT.Location = new System.Drawing.Point(136, 158);
            this.Measure10mmHgBT.Name = "Measure10mmHgBT";
            this.Measure10mmHgBT.Size = new System.Drawing.Size(258, 49);
            this.Measure10mmHgBT.TabIndex = 0;
            this.Measure10mmHgBT.Text = "Measure 10 mmHg";
            this.Measure10mmHgBT.UseVisualStyleBackColor = false;
            this.Measure10mmHgBT.Click += new System.EventHandler(this.Measure10mmHgBT_Click);
            // 
            // Measure50mmHgBT
            // 
            this.Measure50mmHgBT.BackColor = System.Drawing.SystemColors.Control;
            this.Measure50mmHgBT.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Measure50mmHgBT.Location = new System.Drawing.Point(136, 231);
            this.Measure50mmHgBT.Name = "Measure50mmHgBT";
            this.Measure50mmHgBT.Size = new System.Drawing.Size(258, 53);
            this.Measure50mmHgBT.TabIndex = 1;
            this.Measure50mmHgBT.Text = "Measure 50 mmHg";
            this.Measure50mmHgBT.UseVisualStyleBackColor = false;
            this.Measure50mmHgBT.Click += new System.EventHandler(this.Measure50mmHgBT_Click);
            // 
            // Measure100mmHgBT
            // 
            this.Measure100mmHgBT.BackColor = System.Drawing.SystemColors.Control;
            this.Measure100mmHgBT.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Measure100mmHgBT.Location = new System.Drawing.Point(136, 307);
            this.Measure100mmHgBT.Name = "Measure100mmHgBT";
            this.Measure100mmHgBT.Size = new System.Drawing.Size(258, 53);
            this.Measure100mmHgBT.TabIndex = 2;
            this.Measure100mmHgBT.Text = "Measure 100 mmHg";
            this.Measure100mmHgBT.UseVisualStyleBackColor = false;
            this.Measure100mmHgBT.Click += new System.EventHandler(this.Measure100mmHgBT_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(172, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(222, 46);
            this.label1.TabIndex = 3;
            this.label1.Text = "Calibration";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(131, 92);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(290, 25);
            this.label2.TabIndex = 4;
            this.label2.Text = "Please choose a pressure value";
            // 
            // CalibrateBT
            // 
            this.CalibrateBT.BackColor = System.Drawing.Color.Lime;
            this.CalibrateBT.Enabled = false;
            this.CalibrateBT.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CalibrateBT.Location = new System.Drawing.Point(136, 388);
            this.CalibrateBT.Name = "CalibrateBT";
            this.CalibrateBT.Size = new System.Drawing.Size(258, 53);
            this.CalibrateBT.TabIndex = 5;
            this.CalibrateBT.Text = "Calibrate";
            this.CalibrateBT.UseVisualStyleBackColor = false;
            this.CalibrateBT.Click += new System.EventHandler(this.CalibrateBT_Click);
            // 
            // DateOfCalibration
            // 
            this.DateOfCalibration.AutoSize = true;
            this.DateOfCalibration.Location = new System.Drawing.Point(12, 9);
            this.DateOfCalibration.Name = "DateOfCalibration";
            this.DateOfCalibration.Size = new System.Drawing.Size(127, 17);
            this.DateOfCalibration.TabIndex = 6;
            this.DateOfCalibration.Text = "Date of calibration:";
            this.DateOfCalibration.Click += new System.EventHandler(this.DateOfCalibration_Click);
            // 
            // CalibrateForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.ClientSize = new System.Drawing.Size(545, 471);
            this.Controls.Add(this.DateOfCalibration);
            this.Controls.Add(this.CalibrateBT);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Measure100mmHgBT);
            this.Controls.Add(this.Measure50mmHgBT);
            this.Controls.Add(this.Measure10mmHgBT);
            this.Name = "CalibrateForm";
            this.Text = "CalibrateForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Measure10mmHgBT;
        private System.Windows.Forms.Button Measure50mmHgBT;
        private System.Windows.Forms.Button Measure100mmHgBT;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button CalibrateBT;
        private System.Windows.Forms.Label DateOfCalibration;
    }
}