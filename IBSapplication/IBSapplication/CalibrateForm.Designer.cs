namespace PresentationLogic
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
            this.button1.BackColor = System.Drawing.SystemColors.Control;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(149, 145);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(258, 49);
            this.button1.TabIndex = 0;
            this.button1.Text = "Meassure 10 mmHg";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Measure50mmHgBT
            // 
            this.button2.BackColor = System.Drawing.SystemColors.Control;
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(149, 218);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(258, 53);
            this.button2.TabIndex = 1;
            this.button2.Text = "Meassure 50 mmHg";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // Measure100mmHgBT
            // 
            this.button3.BackColor = System.Drawing.SystemColors.Control;
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.Location = new System.Drawing.Point(149, 294);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(258, 53);
            this.button3.TabIndex = 2;
            this.button3.Text = "Meassure 100 mmHg";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
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
            this.button4.BackColor = System.Drawing.Color.Lime;
            this.button4.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.Location = new System.Drawing.Point(149, 374);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(258, 53);
            this.button4.TabIndex = 5;
            this.button4.Text = "Calibration";
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.button4_Click);
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