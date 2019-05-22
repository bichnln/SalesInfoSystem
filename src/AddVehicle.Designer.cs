namespace SIS
{
    partial class AddVehicle
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
            this.NameLabel = new System.Windows.Forms.Label();
            this.ModelLabel = new System.Windows.Forms.Label();
            this.ManuLabel = new System.Windows.Forms.Label();
            this.YearLabel = new System.Windows.Forms.Label();
            this.NameTB = new System.Windows.Forms.TextBox();
            this.ModelTB = new System.Windows.Forms.TextBox();
            this.ManuTB = new System.Windows.Forms.TextBox();
            this.YearTB = new System.Windows.Forms.TextBox();
            this.SaveButton = new System.Windows.Forms.Button();
            this.CancelButton = new System.Windows.Forms.Button();
            this.FormTitleLabel = new System.Windows.Forms.Label();
            this.BaseCostTB = new System.Windows.Forms.TextBox();
            this.BaseCostLabel = new System.Windows.Forms.Label();
            this.CurrencyLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // NameLabel
            // 
            this.NameLabel.AutoSize = true;
            this.NameLabel.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.NameLabel.Font = new System.Drawing.Font("Cambria", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NameLabel.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.NameLabel.Location = new System.Drawing.Point(74, 133);
            this.NameLabel.Name = "NameLabel";
            this.NameLabel.Size = new System.Drawing.Size(60, 22);
            this.NameLabel.TabIndex = 0;
            this.NameLabel.Text = "Name";
            // 
            // ModelLabel
            // 
            this.ModelLabel.AutoSize = true;
            this.ModelLabel.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ModelLabel.Font = new System.Drawing.Font("Cambria", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ModelLabel.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ModelLabel.Location = new System.Drawing.Point(74, 198);
            this.ModelLabel.Name = "ModelLabel";
            this.ModelLabel.Size = new System.Drawing.Size(64, 22);
            this.ModelLabel.TabIndex = 1;
            this.ModelLabel.Text = "Model";
            // 
            // ManuLabel
            // 
            this.ManuLabel.AutoSize = true;
            this.ManuLabel.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ManuLabel.Font = new System.Drawing.Font("Cambria", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ManuLabel.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ManuLabel.Location = new System.Drawing.Point(74, 263);
            this.ManuLabel.Name = "ManuLabel";
            this.ManuLabel.Size = new System.Drawing.Size(129, 22);
            this.ManuLabel.TabIndex = 2;
            this.ManuLabel.Text = "Manufacturer";
            this.ManuLabel.Click += new System.EventHandler(this.YearLabel_Click);
            // 
            // YearLabel
            // 
            this.YearLabel.AutoSize = true;
            this.YearLabel.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.YearLabel.Font = new System.Drawing.Font("Cambria", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.YearLabel.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.YearLabel.Location = new System.Drawing.Point(453, 198);
            this.YearLabel.Name = "YearLabel";
            this.YearLabel.Size = new System.Drawing.Size(48, 22);
            this.YearLabel.TabIndex = 3;
            this.YearLabel.Text = "Year";
            // 
            // NameTB
            // 
            this.NameTB.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.NameTB.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NameTB.ForeColor = System.Drawing.SystemColors.InfoText;
            this.NameTB.Location = new System.Drawing.Point(251, 135);
            this.NameTB.Name = "NameTB";
            this.NameTB.Size = new System.Drawing.Size(372, 23);
            this.NameTB.TabIndex = 5;
            // 
            // ModelTB
            // 
            this.ModelTB.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.ModelTB.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ModelTB.ForeColor = System.Drawing.SystemColors.InfoText;
            this.ModelTB.Location = new System.Drawing.Point(251, 200);
            this.ModelTB.Name = "ModelTB";
            this.ModelTB.Size = new System.Drawing.Size(144, 23);
            this.ModelTB.TabIndex = 6;
            // 
            // ManuTB
            // 
            this.ManuTB.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.ManuTB.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ManuTB.ForeColor = System.Drawing.SystemColors.InfoText;
            this.ManuTB.Location = new System.Drawing.Point(251, 265);
            this.ManuTB.Name = "ManuTB";
            this.ManuTB.Size = new System.Drawing.Size(372, 23);
            this.ManuTB.TabIndex = 7;
            // 
            // YearTB
            // 
            this.YearTB.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.YearTB.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.YearTB.ForeColor = System.Drawing.SystemColors.InfoText;
            this.YearTB.Location = new System.Drawing.Point(530, 200);
            this.YearTB.Name = "YearTB";
            this.YearTB.Size = new System.Drawing.Size(93, 23);
            this.YearTB.TabIndex = 8;
            // 
            // SaveButton
            // 
            this.SaveButton.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.SaveButton.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SaveButton.Location = new System.Drawing.Point(251, 398);
            this.SaveButton.Name = "SaveButton";
            this.SaveButton.Size = new System.Drawing.Size(93, 32);
            this.SaveButton.TabIndex = 9;
            this.SaveButton.Text = "SAVE";
            this.SaveButton.UseVisualStyleBackColor = false;
            // 
            // CancelButton
            // 
            this.CancelButton.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.CancelButton.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CancelButton.Location = new System.Drawing.Point(457, 398);
            this.CancelButton.Name = "CancelButton";
            this.CancelButton.Size = new System.Drawing.Size(93, 32);
            this.CancelButton.TabIndex = 10;
            this.CancelButton.Text = "CANCEL";
            this.CancelButton.UseVisualStyleBackColor = false;
            // 
            // FormTitleLabel
            // 
            this.FormTitleLabel.AutoSize = true;
            this.FormTitleLabel.Font = new System.Drawing.Font("Cambria", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormTitleLabel.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.FormTitleLabel.Location = new System.Drawing.Point(182, 36);
            this.FormTitleLabel.Name = "FormTitleLabel";
            this.FormTitleLabel.Size = new System.Drawing.Size(381, 43);
            this.FormTitleLabel.TabIndex = 11;
            this.FormTitleLabel.Text = "Vehicle\'s Information";
            // 
            // BaseCostTB
            // 
            this.BaseCostTB.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.BaseCostTB.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BaseCostTB.ForeColor = System.Drawing.SystemColors.InfoText;
            this.BaseCostTB.Location = new System.Drawing.Point(251, 329);
            this.BaseCostTB.Name = "BaseCostTB";
            this.BaseCostTB.Size = new System.Drawing.Size(93, 23);
            this.BaseCostTB.TabIndex = 13;
            // 
            // BaseCostLabel
            // 
            this.BaseCostLabel.AutoSize = true;
            this.BaseCostLabel.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.BaseCostLabel.Font = new System.Drawing.Font("Cambria", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BaseCostLabel.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.BaseCostLabel.Location = new System.Drawing.Point(74, 327);
            this.BaseCostLabel.Name = "BaseCostLabel";
            this.BaseCostLabel.Size = new System.Drawing.Size(93, 22);
            this.BaseCostLabel.TabIndex = 12;
            this.BaseCostLabel.Text = "Base Cost";
            // 
            // CurrencyLabel
            // 
            this.CurrencyLabel.AutoSize = true;
            this.CurrencyLabel.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.CurrencyLabel.Font = new System.Drawing.Font("Cambria", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CurrencyLabel.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.CurrencyLabel.Location = new System.Drawing.Point(350, 332);
            this.CurrencyLabel.Name = "CurrencyLabel";
            this.CurrencyLabel.Size = new System.Drawing.Size(37, 17);
            this.CurrencyLabel.TabIndex = 21;
            this.CurrencyLabel.Text = "AUD";
            // 
            // AddVehicle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(729, 463);
            this.Controls.Add(this.CurrencyLabel);
            this.Controls.Add(this.BaseCostTB);
            this.Controls.Add(this.BaseCostLabel);
            this.Controls.Add(this.FormTitleLabel);
            this.Controls.Add(this.CancelButton);
            this.Controls.Add(this.SaveButton);
            this.Controls.Add(this.YearTB);
            this.Controls.Add(this.ManuTB);
            this.Controls.Add(this.ModelTB);
            this.Controls.Add(this.NameTB);
            this.Controls.Add(this.YearLabel);
            this.Controls.Add(this.ManuLabel);
            this.Controls.Add(this.ModelLabel);
            this.Controls.Add(this.NameLabel);
            this.Name = "AddVehicle";
            this.Text = "AddVehicle";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label NameLabel;
        private System.Windows.Forms.Label ModelLabel;
        private System.Windows.Forms.Label ManuLabel;
        private System.Windows.Forms.Label YearLabel;
        private System.Windows.Forms.TextBox NameTB;
        private System.Windows.Forms.TextBox ModelTB;
        private System.Windows.Forms.TextBox ManuTB;
        private System.Windows.Forms.TextBox YearTB;
        private System.Windows.Forms.Button SaveButton;
        private System.Windows.Forms.Button CancelButton;
        private System.Windows.Forms.Label FormTitleLabel;
        private System.Windows.Forms.TextBox BaseCostTB;
        private System.Windows.Forms.Label BaseCostLabel;
        private System.Windows.Forms.Label CurrencyLabel;
    }
}

