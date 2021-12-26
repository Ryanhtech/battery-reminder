namespace BatteryReminder
{
    partial class ChargedForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ChargedForm));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.CloseFormButton = new System.Windows.Forms.Button();
            this.OpenAboutLink = new System.Windows.Forms.LinkLabel();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(0)))), ((int)(((byte)(75)))));
            this.label1.Location = new System.Drawing.Point(9, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(521, 28);
            this.label1.TabIndex = 0;
            this.label1.Text = "Votre batterie a terminé de charger";
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 41);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(518, 111);
            this.label2.TabIndex = 1;
            this.label2.Text = resources.GetString("label2.Text");
            // 
            // CloseFormButton
            // 
            this.CloseFormButton.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CloseFormButton.Location = new System.Drawing.Point(455, 161);
            this.CloseFormButton.Name = "CloseFormButton";
            this.CloseFormButton.Size = new System.Drawing.Size(75, 23);
            this.CloseFormButton.TabIndex = 2;
            this.CloseFormButton.Text = "Fermer";
            this.CloseFormButton.UseVisualStyleBackColor = true;
            this.CloseFormButton.Click += new System.EventHandler(this.CloseFormButton_Click);
            // 
            // OpenAboutLink
            // 
            this.OpenAboutLink.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.OpenAboutLink.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.OpenAboutLink.Location = new System.Drawing.Point(12, 161);
            this.OpenAboutLink.Name = "OpenAboutLink";
            this.OpenAboutLink.Size = new System.Drawing.Size(437, 23);
            this.OpenAboutLink.TabIndex = 3;
            this.OpenAboutLink.TabStop = true;
            this.OpenAboutLink.Text = "En savoir plus sur BatteryReminder...";
            this.OpenAboutLink.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.OpenAboutLink.Visible = false;
            this.OpenAboutLink.VisitedLinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.OpenAboutLink.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.OpenAboutLink_LinkClicked);
            // 
            // ChargedForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(545, 196);
            this.ControlBox = false;
            this.Controls.Add(this.OpenAboutLink);
            this.Controls.Add(this.CloseFormButton);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.MaximumSize = new System.Drawing.Size(561, 235);
            this.MinimumSize = new System.Drawing.Size(561, 235);
            this.Name = "ChargedForm";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Ryanhtech BatteryReminder - Votre batterie est chargée";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.ChargedForm_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button CloseFormButton;
        private System.Windows.Forms.LinkLabel OpenAboutLink;
    }
}

