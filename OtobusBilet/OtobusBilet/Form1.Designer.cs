﻿namespace OtobusBilet
{
    partial class Form1
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
            this.otobusTipCMBOX = new System.Windows.Forms.ComboBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // otobusTipCMBOX
            // 
            this.otobusTipCMBOX.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.otobusTipCMBOX.FormattingEnabled = true;
            this.otobusTipCMBOX.Items.AddRange(new object[] {
            "Mercedes-Travego",
            "Setra-S 517 HDH"});
            this.otobusTipCMBOX.Location = new System.Drawing.Point(22, 12);
            this.otobusTipCMBOX.Name = "otobusTipCMBOX";
            this.otobusTipCMBOX.Size = new System.Drawing.Size(302, 28);
            this.otobusTipCMBOX.TabIndex = 0;
            this.otobusTipCMBOX.SelectedIndexChanged += new System.EventHandler(this.otobusTipCMBOX_SelectedIndexChanged);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel1.Location = new System.Drawing.Point(22, 46);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(302, 556);
            this.panel1.TabIndex = 1;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(334, 614);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.otobusTipCMBOX);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox otobusTipCMBOX;
        private System.Windows.Forms.Panel panel1;
    }
}
