namespace PresentationLogic
{
    partial class ZeroPointAdjustmentForm
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
            this.zeroPointAdjustmentBT = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // zeroPointAdjustmentBT
            // 
            this.zeroPointAdjustmentBT.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.zeroPointAdjustmentBT.Location = new System.Drawing.Point(191, 148);
            this.zeroPointAdjustmentBT.Name = "zeroPointAdjustmentBT";
            this.zeroPointAdjustmentBT.Size = new System.Drawing.Size(137, 49);
            this.zeroPointAdjustmentBT.TabIndex = 0;
            this.zeroPointAdjustmentBT.Text = "Adjust";
            this.zeroPointAdjustmentBT.UseVisualStyleBackColor = true;
            this.zeroPointAdjustmentBT.Click += new System.EventHandler(this.zeroPointAdjustmentBT_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(53, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(420, 46);
            this.label1.TabIndex = 1;
            this.label1.Text = "Zeropoint Adjustment";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(58, 96);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(327, 34);
            this.label2.TabIndex = 2;
            this.label2.Text = "Position the transducer so it is open out to free air.\r\nPress ADJUST.";
            // 
            // ZeroPointAdjustmentForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.ClientSize = new System.Drawing.Size(538, 227);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.zeroPointAdjustmentBT);
            this.Name = "ZeroPointAdjustmentForm";
            this.Text = "ZeroPointAdjustmentForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button zeroPointAdjustmentBT;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}