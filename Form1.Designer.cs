namespace sayi_tahmin_oyunu
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
            this.btntahmin = new System.Windows.Forms.Button();
            this.tbtahmin = new System.Windows.Forms.TextBox();
            this.lblgoster = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btntahmin
            // 
            this.btntahmin.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btntahmin.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btntahmin.Location = new System.Drawing.Point(66, 172);
            this.btntahmin.Name = "btntahmin";
            this.btntahmin.Size = new System.Drawing.Size(170, 70);
            this.btntahmin.TabIndex = 0;
            this.btntahmin.Text = "Tahmin/Prediction";
            this.btntahmin.UseVisualStyleBackColor = false;
            this.btntahmin.Click += new System.EventHandler(this.btntahmin_Click);
            // 
            // tbtahmin
            // 
            this.tbtahmin.Location = new System.Drawing.Point(66, 124);
            this.tbtahmin.Name = "tbtahmin";
            this.tbtahmin.Size = new System.Drawing.Size(170, 22);
            this.tbtahmin.TabIndex = 1;
            // 
            // lblgoster
            // 
            this.lblgoster.AutoSize = true;
            this.lblgoster.Location = new System.Drawing.Point(66, 102);
            this.lblgoster.Name = "lblgoster";
            this.lblgoster.Size = new System.Drawing.Size(0, 16);
            this.lblgoster.TabIndex = 2;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(308, 310);
            this.Controls.Add(this.lblgoster);
            this.Controls.Add(this.tbtahmin);
            this.Controls.Add(this.btntahmin);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "GAME";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btntahmin;
        private System.Windows.Forms.TextBox tbtahmin;
        private System.Windows.Forms.Label lblgoster;
    }
}

