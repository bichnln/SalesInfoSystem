namespace SIS
{
    partial class EditCustomer
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose( bool disposing )
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose( disposing );
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.FirstnameLabel = new System.Windows.Forms.Label();
            this.LastnameLabel = new System.Windows.Forms.Label();
            this.AddressLabel = new System.Windows.Forms.Label();
            this.PhoneLabel = new System.Windows.Forms.Label();
            this.FirstnameTB = new System.Windows.Forms.TextBox();
            this.LastnameTB = new System.Windows.Forms.TextBox();
            this.AddressTB = new System.Windows.Forms.TextBox();
            this.PhoneTB = new System.Windows.Forms.TextBox();
            this.SaveButton = new System.Windows.Forms.Button();
            this.CancelButton = new System.Windows.Forms.Button();
            this.FormTitleLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // FirstnameLabel
            // 
            this.FirstnameLabel.AutoSize = true;
            this.FirstnameLabel.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.FirstnameLabel.Font = new System.Drawing.Font("Cambria", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FirstnameLabel.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.FirstnameLabel.Location = new System.Drawing.Point(74, 133);
            this.FirstnameLabel.Name = "FirstnameLabel";
            this.FirstnameLabel.Size = new System.Drawing.Size(105, 22);
            this.FirstnameLabel.TabIndex = 0;
            this.FirstnameLabel.Text = "First Name";
            // 
            // LastnameLabel
            // 
            this.LastnameLabel.AutoSize = true;
            this.LastnameLabel.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.LastnameLabel.Font = new System.Drawing.Font("Cambria", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LastnameLabel.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.LastnameLabel.Location = new System.Drawing.Point(74, 198);
            this.LastnameLabel.Name = "LastnameLabel";
            this.LastnameLabel.Size = new System.Drawing.Size(100, 22);
            this.LastnameLabel.TabIndex = 1;
            this.LastnameLabel.Text = "Last Name";
            // 
            // AddressLabel
            // 
            this.AddressLabel.AutoSize = true;
            this.AddressLabel.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.AddressLabel.Font = new System.Drawing.Font("Cambria", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddressLabel.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.AddressLabel.Location = new System.Drawing.Point(74, 263);
            this.AddressLabel.Name = "AddressLabel";
            this.AddressLabel.Size = new System.Drawing.Size(81, 22);
            this.AddressLabel.TabIndex = 2;
            this.AddressLabel.Text = "Address";
            // 
            // PhoneLabel
            // 
            this.PhoneLabel.AutoSize = true;
            this.PhoneLabel.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.PhoneLabel.Font = new System.Drawing.Font("Cambria", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PhoneLabel.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.PhoneLabel.Location = new System.Drawing.Point(74, 331);
            this.PhoneLabel.Name = "PhoneLabel";
            this.PhoneLabel.Size = new System.Drawing.Size(140, 22);
            this.PhoneLabel.TabIndex = 3;
            this.PhoneLabel.Text = "Phone Number";
            // 
            // FirstnameTB
            // 
            this.FirstnameTB.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.FirstnameTB.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FirstnameTB.ForeColor = System.Drawing.SystemColors.InfoText;
            this.FirstnameTB.Location = new System.Drawing.Point(251, 135);
            this.FirstnameTB.Name = "FirstnameTB";
            this.FirstnameTB.Size = new System.Drawing.Size(372, 23);
            this.FirstnameTB.TabIndex = 5;
            this.FirstnameTB.TextChanged += new System.EventHandler(this.FirstnameTB_TextChanged_1);
            // 
            // LastnameTB
            // 
            this.LastnameTB.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.LastnameTB.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LastnameTB.ForeColor = System.Drawing.SystemColors.InfoText;
            this.LastnameTB.Location = new System.Drawing.Point(251, 200);
            this.LastnameTB.Name = "LastnameTB";
            this.LastnameTB.Size = new System.Drawing.Size(372, 23);
            this.LastnameTB.TabIndex = 6;
            // 
            // AddressTB
            // 
            this.AddressTB.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.AddressTB.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddressTB.ForeColor = System.Drawing.SystemColors.InfoText;
            this.AddressTB.Location = new System.Drawing.Point(251, 265);
            this.AddressTB.Name = "AddressTB";
            this.AddressTB.Size = new System.Drawing.Size(372, 23);
            this.AddressTB.TabIndex = 7;
            // 
            // PhoneTB
            // 
            this.PhoneTB.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.PhoneTB.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PhoneTB.ForeColor = System.Drawing.SystemColors.InfoText;
            this.PhoneTB.Location = new System.Drawing.Point(251, 333);
            this.PhoneTB.Name = "PhoneTB";
            this.PhoneTB.Size = new System.Drawing.Size(372, 23);
            this.PhoneTB.TabIndex = 8;
            // 
            // SaveButton
            // 
            this.SaveButton.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.SaveButton.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SaveButton.Location = new System.Drawing.Point(251, 410);
            this.SaveButton.Name = "SaveButton";
            this.SaveButton.Size = new System.Drawing.Size(93, 32);
            this.SaveButton.TabIndex = 9;
            this.SaveButton.Text = "SAVE";
            this.SaveButton.UseVisualStyleBackColor = false;
            this.SaveButton.Click += new System.EventHandler(this.SaveButton_Click_1);
            // 
            // CancelButton
            // 
            this.CancelButton.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.CancelButton.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CancelButton.Location = new System.Drawing.Point(457, 410);
            this.CancelButton.Name = "CancelButton";
            this.CancelButton.Size = new System.Drawing.Size(93, 32);
            this.CancelButton.TabIndex = 10;
            this.CancelButton.Text = "CANCEL";
            this.CancelButton.UseVisualStyleBackColor = false;
            this.CancelButton.Click += new System.EventHandler(this.CancelButton_Click);
            // 
            // FormTitleLabel
            // 
            this.FormTitleLabel.AutoSize = true;
            this.FormTitleLabel.Font = new System.Drawing.Font("Cambria", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormTitleLabel.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.FormTitleLabel.Location = new System.Drawing.Point(122, 36);
            this.FormTitleLabel.Name = "FormTitleLabel";
            this.FormTitleLabel.Size = new System.Drawing.Size(501, 43);
            this.FormTitleLabel.TabIndex = 11;
            this.FormTitleLabel.Text = "Edit Customer\'s Information";
            // 
            // EditCustomer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(729, 480);
            this.Controls.Add(this.FormTitleLabel);
            this.Controls.Add(this.CancelButton);
            this.Controls.Add(this.SaveButton);
            this.Controls.Add(this.PhoneTB);
            this.Controls.Add(this.AddressTB);
            this.Controls.Add(this.LastnameTB);
            this.Controls.Add(this.FirstnameTB);
            this.Controls.Add(this.PhoneLabel);
            this.Controls.Add(this.AddressLabel);
            this.Controls.Add(this.LastnameLabel);
            this.Controls.Add(this.FirstnameLabel);
            this.Name = "EditCustomer";
            this.Text = "EditCustomer";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label FirstnameLabel;
        private System.Windows.Forms.Label LastnameLabel;
        private System.Windows.Forms.Label AddressLabel;
        private System.Windows.Forms.Label PhoneLabel;
        private System.Windows.Forms.TextBox FirstnameTB;
        private System.Windows.Forms.TextBox LastnameTB;
        private System.Windows.Forms.TextBox AddressTB;
        private System.Windows.Forms.TextBox PhoneTB;
        private System.Windows.Forms.Button SaveButton;
        private System.Windows.Forms.Button CancelButton;
        private System.Windows.Forms.Label FormTitleLabel;
    }
}

