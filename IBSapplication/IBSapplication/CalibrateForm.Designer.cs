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
            this.CalibrationBT = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Measure10mmHgBT
            // 
            this.Measure10mmHgBT.BackColor = System.Drawing.SystemColors.Control;
            this.Measure10mmHgBT.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Measure10mmHgBT.Location = new System.Drawing.Point(149, 145);
            this.Measure10mmHgBT.Name = "button1";
            this.Measure10mmHgBT.Size = new System.Drawing.Size(258, 49);
            this.Measure10mmHgBT.TabIndex = 0;
            this.Measure10mmHgBT.Text = "Meassure 10 mmHg";
            this.Measure10mmHgBT.UseVisualStyleBackColor = false;
            // 
            // Measure50mmHgBT
            // 
            this.Measure50mmHgBT.BackColor = System.Drawing.SystemColors.Control;
            this.Measure50mmHgBT.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Measure50mmHgBT.Location = new System.Drawing.Point(149, 218);
            this.Measure50mmHgBT.Name = "button2";
            this.Measure50mmHgBT.Size = new System.Drawing.Size(258, 53);
            this.Measure50mmHgBT.TabIndex = 1;
            this.Measure50mmHgBT.Text = "Meassure 50 mmHg";
            this.Measure50mmHgBT.UseVisualStyleBackColor = false;

            // 
            // Measure100mmHgBT
            // 
            this.Measure100mmHgBT.BackColor = System.Drawing.SystemColors.Control;
            this.Measure100mmHgBT.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Measure100mmHgBT.Location = new System.Drawing.Point(149, 294);
            this.Measure100mmHgBT.Name = "button3";
            this.Measure100mmHgBT.Size = new System.Drawing.Size(258, 53);
            this.Measure100mmHgBT.TabIndex = 2;
            this.Measure100mmHgBT.Text = "Meassure 100 mmHg";
            this.Measure100mmHgBT.UseVisualStyleBackColor = false;
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
            this.label2.Location = new System.Drawing.Point(134, 86);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(290, 25);
            this.label2.TabIndex = 4;
            this.label2.Text = "Please choose a pressure value";
            // 
            // CalibrationBT
            // 
            this.CalibrationBT.BackColor = System.Drawing.Color.Lime;
            this.CalibrationBT.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CalibrationBT.Location = new System.Drawing.Point(149, 374);
            this.CalibrationBT.Name = "button4";
            this.CalibrationBT.Size = new System.Drawing.Size(258, 53);
            this.CalibrationBT.TabIndex = 5;
            this.CalibrationBT.Text = "Calibration";
            this.CalibrationBT.UseVisualStyleBackColor = false;
            // 
            // CalibrateForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.ClientSize = new System.Drawing.Size(581, 473);
            this.Controls.Add(this.CalibrationBT);
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
        private System.Windows.Forms.Button CalibrationBT;
    }
}