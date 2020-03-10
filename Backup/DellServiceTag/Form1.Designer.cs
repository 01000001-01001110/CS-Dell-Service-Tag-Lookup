namespace DellServiceTag
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
            this.Display = new System.Windows.Forms.TextBox();
            this.DisplayLabel = new System.Windows.Forms.Label();
            this.DriversLink = new System.Windows.Forms.LinkLabel();
            this.warrantyLink = new System.Windows.Forms.LinkLabel();
            this.ExpressCodeLabel = new System.Windows.Forms.Label();
            this.ExpressTxtBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // Display
            // 
            this.Display.Location = new System.Drawing.Point(88, 12);
            this.Display.Name = "Display";
            this.Display.ReadOnly = true;
            this.Display.Size = new System.Drawing.Size(121, 20);
            this.Display.TabIndex = 1;
            this.Display.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // DisplayLabel
            // 
            this.DisplayLabel.AutoSize = true;
            this.DisplayLabel.Location = new System.Drawing.Point(5, 19);
            this.DisplayLabel.Name = "DisplayLabel";
            this.DisplayLabel.Size = new System.Drawing.Size(68, 13);
            this.DisplayLabel.TabIndex = 2;
            this.DisplayLabel.Text = "Service Tag:";
            // 
            // DriversLink
            // 
            this.DriversLink.AutoSize = true;
            this.DriversLink.Location = new System.Drawing.Point(85, 67);
            this.DriversLink.Name = "DriversLink";
            this.DriversLink.Size = new System.Drawing.Size(40, 13);
            this.DriversLink.TabIndex = 3;
            this.DriversLink.TabStop = true;
            this.DriversLink.Text = "Drivers";
            this.DriversLink.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.DriversLink_LinkClicked);
            // 
            // warrantyLink
            // 
            this.warrantyLink.AutoSize = true;
            this.warrantyLink.Location = new System.Drawing.Point(159, 67);
            this.warrantyLink.Name = "warrantyLink";
            this.warrantyLink.Size = new System.Drawing.Size(50, 13);
            this.warrantyLink.TabIndex = 4;
            this.warrantyLink.TabStop = true;
            this.warrantyLink.Text = "Warranty";
            this.warrantyLink.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.warrantyLink_LinkClicked);
            // 
            // ExpressCodeLabel
            // 
            this.ExpressCodeLabel.AutoSize = true;
            this.ExpressCodeLabel.Location = new System.Drawing.Point(5, 47);
            this.ExpressCodeLabel.Name = "ExpressCodeLabel";
            this.ExpressCodeLabel.Size = new System.Drawing.Size(75, 13);
            this.ExpressCodeLabel.TabIndex = 5;
            this.ExpressCodeLabel.Text = "Express Code:";
            // 
            // ExpressTxtBox
            // 
            this.ExpressTxtBox.Location = new System.Drawing.Point(88, 44);
            this.ExpressTxtBox.Name = "ExpressTxtBox";
            this.ExpressTxtBox.ReadOnly = true;
            this.ExpressTxtBox.Size = new System.Drawing.Size(121, 20);
            this.ExpressTxtBox.TabIndex = 6;
            this.ExpressTxtBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(222, 86);
            this.Controls.Add(this.ExpressTxtBox);
            this.Controls.Add(this.ExpressCodeLabel);
            this.Controls.Add(this.warrantyLink);
            this.Controls.Add(this.DriversLink);
            this.Controls.Add(this.DisplayLabel);
            this.Controls.Add(this.Display);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Form1";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Dell Service Tag - SamuelHaddad.com";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox Display;
        private System.Windows.Forms.Label DisplayLabel;
        private System.Windows.Forms.LinkLabel DriversLink;
        private System.Windows.Forms.LinkLabel warrantyLink;
        private System.Windows.Forms.Label ExpressCodeLabel;
        private System.Windows.Forms.TextBox ExpressTxtBox;
    }
}

