namespace PresentationLogic
{
    partial class SaveDataForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.fullNameTB = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.cprTB = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.staffIDTB = new System.Windows.Forms.TextBox();
            this.SaveDataBT = new System.Windows.Forms.Button();
            this.CancelBT = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(154, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(207, 46);
            this.label1.TabIndex = 4;
            this.label1.Text = "Save data";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(114, 66);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(281, 25);
            this.label2.TabIndex = 5;
            this.label2.Text = "Please fill out all required fields ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(24, 146);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(148, 20);
            this.label3.TabIndex = 6;
            this.label3.Text = "Patients full name:";
            // 
            // fullNameTB
            // 
            this.fullNameTB.Location = new System.Drawing.Point(237, 148);
            this.fullNameTB.Name = "fullNameTB";
            this.fullNameTB.Size = new System.Drawing.Size(272, 22);
            this.fullNameTB.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(24, 199);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(177, 20);
            this.label4.TabIndex = 8;
            this.label4.Text = "Patients CPR-number:";
            // 
            // cprTB
            // 
            this.cprTB.Location = new System.Drawing.Point(237, 197);
            this.cprTB.Name = "cprTB";
            this.cprTB.Size = new System.Drawing.Size(272, 22);
            this.cprTB.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(24, 248);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(132, 20);
            this.label5.TabIndex = 10;
            this.label5.Text = "Staff ID number:";
            // 
            // staffIDTB
            // 
            this.staffIDTB.Location = new System.Drawing.Point(237, 246);
            this.staffIDTB.Name = "staffIDTB";
            this.staffIDTB.Size = new System.Drawing.Size(272, 22);
            this.staffIDTB.TabIndex = 11;
            // 
            // SaveDataBT
            // 
            this.SaveDataBT.Location = new System.Drawing.Point(343, 375);
            this.SaveDataBT.Name = "SaveDataBT";
            this.SaveDataBT.Size = new System.Drawing.Size(113, 57);
            this.SaveDataBT.TabIndex = 13;
            this.SaveDataBT.Text = "Save data";
            this.SaveDataBT.UseVisualStyleBackColor = true;
            this.SaveDataBT.Click += new System.EventHandler(this.SaveDataBT_Click);
            // 
            // CancelBT
            // 
            this.CancelBT.Location = new System.Drawing.Point(88, 394);
            this.CancelBT.Name = "CancelBT";
            this.CancelBT.Size = new System.Drawing.Size(84, 38);
            this.CancelBT.TabIndex = 14;
            this.CancelBT.Text = "Cancel";
            this.CancelBT.UseVisualStyleBackColor = true;
            this.CancelBT.Click += new System.EventHandler(this.CancelBT_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(40, 307);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(381, 17);
            this.label6.TabIndex = 15;
            this.label6.Text = "When \"Save data\" is clicked, the entered data will be saved";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(40, 334);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(396, 17);
            this.label7.TabIndex = 16;
            this.label7.Text = "together with date, time and the patients blood pressure data.";
            // 
            // SaveDataForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.ClientSize = new System.Drawing.Size(521, 452);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.CancelBT);
            this.Controls.Add(this.SaveDataBT);
            this.Controls.Add(this.staffIDTB);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.cprTB);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.fullNameTB);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "SaveDataForm";
            this.Text = "SaveDataForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox fullNameTB;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox cprTB;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox staffIDTB;
        private System.Windows.Forms.Button SaveDataBT;
        private System.Windows.Forms.Button CancelBT;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
    }
}