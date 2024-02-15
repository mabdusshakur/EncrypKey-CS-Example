namespace EncrypKey_CS_Example
{
    partial class Main
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
            this.license_tb = new System.Windows.Forms.TextBox();
            this.activate_btn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // license_tb
            // 
            this.license_tb.Location = new System.Drawing.Point(12, 21);
            this.license_tb.Name = "license_tb";
            this.license_tb.Size = new System.Drawing.Size(368, 20);
            this.license_tb.TabIndex = 0;
            // 
            // activate_btn
            // 
            this.activate_btn.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.activate_btn.Location = new System.Drawing.Point(0, 61);
            this.activate_btn.Name = "activate_btn";
            this.activate_btn.Size = new System.Drawing.Size(392, 33);
            this.activate_btn.TabIndex = 1;
            this.activate_btn.Text = "Activate";
            this.activate_btn.UseVisualStyleBackColor = true;
            this.activate_btn.Click += new System.EventHandler(this.activate_btn_Click);
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(392, 94);
            this.Controls.Add(this.activate_btn);
            this.Controls.Add(this.license_tb);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Main";
            this.Text = "EncrypKey-CS-Example";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox license_tb;
        private System.Windows.Forms.Button activate_btn;
    }
}

