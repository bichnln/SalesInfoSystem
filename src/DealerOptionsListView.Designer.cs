namespace SIS
{
    partial class DealerOptionsListView
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.OptionGridView = new System.Windows.Forms.DataGridView();
            this.OptButton = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.InvoiceButton = new System.Windows.Forms.Button();
            this.CustomerButton = new System.Windows.Forms.Button();
            this.CurrentStaffButton = new System.Windows.Forms.Button();
            this.StaffButton = new System.Windows.Forms.Button();
            this.BackButton = new System.Windows.Forms.Button();
            this.AddButton = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.SearchButton = new System.Windows.Forms.Button();
            this.TitleLabel = new System.Windows.Forms.Label();
            this.HorizontalLineLabel = new System.Windows.Forms.Label();
            this.DeleteButton = new System.Windows.Forms.Button();
            this.codeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.descriptionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.priceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dealerOptionBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.customerBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.OptionGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dealerOptionBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.customerBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // OptionGridView
            // 
            this.OptionGridView.AutoGenerateColumns = false;
            this.OptionGridView.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.OptionGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.OptionGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.codeDataGridViewTextBoxColumn,
            this.descriptionDataGridViewTextBoxColumn,
            this.priceDataGridViewTextBoxColumn});
            this.OptionGridView.DataSource = this.dealerOptionBindingSource;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Candara", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.OptionGridView.DefaultCellStyle = dataGridViewCellStyle1;
            this.OptionGridView.GridColor = System.Drawing.SystemColors.ControlDarkDark;
            this.OptionGridView.Location = new System.Drawing.Point(127, 120);
            this.OptionGridView.Name = "OptionGridView";
            this.OptionGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.OptionGridView.Size = new System.Drawing.Size(680, 332);
            this.OptionGridView.TabIndex = 0;
            this.OptionGridView.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.OptionGridView_CellDoubleClick);
            // 
            // OptButton
            // 
            this.OptButton.AccessibleDescription = "";
            this.OptButton.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.OptButton.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.OptButton.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.OptButton.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.OptButton.Location = new System.Drawing.Point(0, 299);
            this.OptButton.Name = "OptButton";
            this.OptButton.Size = new System.Drawing.Size(121, 82);
            this.OptButton.TabIndex = 1;
            this.OptButton.Text = "Dealer Options";
            this.OptButton.UseVisualStyleBackColor = false;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button2.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.button2.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(0, 160);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(121, 79);
            this.button2.TabIndex = 2;
            this.button2.Text = "Vehicles";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // InvoiceButton
            // 
            this.InvoiceButton.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.InvoiceButton.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.InvoiceButton.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.InvoiceButton.Location = new System.Drawing.Point(0, 235);
            this.InvoiceButton.Name = "InvoiceButton";
            this.InvoiceButton.Size = new System.Drawing.Size(121, 74);
            this.InvoiceButton.TabIndex = 3;
            this.InvoiceButton.Text = "Invoices";
            this.InvoiceButton.UseVisualStyleBackColor = false;
            this.InvoiceButton.Click += new System.EventHandler(this.InvoiceButton_Click);
            // 
            // CustomerButton
            // 
            this.CustomerButton.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.CustomerButton.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.CustomerButton.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CustomerButton.Location = new System.Drawing.Point(0, 87);
            this.CustomerButton.Name = "CustomerButton";
            this.CustomerButton.Size = new System.Drawing.Size(121, 75);
            this.CustomerButton.TabIndex = 4;
            this.CustomerButton.Text = "Customers";
            this.CustomerButton.UseVisualStyleBackColor = false;
            this.CustomerButton.Click += new System.EventHandler(this.CustomerButton_Click);
            // 
            // CurrentStaffButton
            // 
            this.CurrentStaffButton.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.CurrentStaffButton.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.CurrentStaffButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CurrentStaffButton.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CurrentStaffButton.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.CurrentStaffButton.Location = new System.Drawing.Point(610, 0);
            this.CurrentStaffButton.Name = "CurrentStaffButton";
            this.CurrentStaffButton.Size = new System.Drawing.Size(188, 29);
            this.CurrentStaffButton.TabIndex = 5;
            this.CurrentStaffButton.Text = "Name";
            this.CurrentStaffButton.UseVisualStyleBackColor = false;
            // 
            // StaffButton
            // 
            this.StaffButton.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.StaffButton.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.StaffButton.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.StaffButton.Location = new System.Drawing.Point(0, 377);
            this.StaffButton.Name = "StaffButton";
            this.StaffButton.Size = new System.Drawing.Size(121, 75);
            this.StaffButton.TabIndex = 6;
            this.StaffButton.Text = "Staff";
            this.StaffButton.UseVisualStyleBackColor = false;
            this.StaffButton.Click += new System.EventHandler(this.StaffButton_Click);
            // 
            // BackButton
            // 
            this.BackButton.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.BackButton.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.BackButton.Font = new System.Drawing.Font("Lucida Sans Unicode", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BackButton.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.BackButton.Location = new System.Drawing.Point(0, 0);
            this.BackButton.Name = "BackButton";
            this.BackButton.Size = new System.Drawing.Size(105, 52);
            this.BackButton.TabIndex = 7;
            this.BackButton.Text = "Back";
            this.BackButton.UseVisualStyleBackColor = false;
            // 
            // AddButton
            // 
            this.AddButton.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.AddButton.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.AddButton.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddButton.Location = new System.Drawing.Point(659, 408);
            this.AddButton.Name = "AddButton";
            this.AddButton.Size = new System.Drawing.Size(139, 30);
            this.AddButton.TabIndex = 8;
            this.AddButton.Text = "Add Customer";
            this.AddButton.UseVisualStyleBackColor = false;
            this.AddButton.Click += new System.EventHandler(this.button3_Click);
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(127, 87);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(578, 27);
            this.textBox1.TabIndex = 9;
            // 
            // SearchButton
            // 
            this.SearchButton.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.SearchButton.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.SearchButton.Font = new System.Drawing.Font("Lucida Sans Unicode", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SearchButton.Location = new System.Drawing.Point(714, 87);
            this.SearchButton.Name = "SearchButton";
            this.SearchButton.Size = new System.Drawing.Size(64, 27);
            this.SearchButton.TabIndex = 10;
            this.SearchButton.Text = "Search";
            this.SearchButton.UseVisualStyleBackColor = false;
            // 
            // TitleLabel
            // 
            this.TitleLabel.AutoSize = true;
            this.TitleLabel.Font = new System.Drawing.Font("Cambria", 30F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TitleLabel.ForeColor = System.Drawing.SystemColors.GrayText;
            this.TitleLabel.Location = new System.Drawing.Point(276, 9);
            this.TitleLabel.Name = "TitleLabel";
            this.TitleLabel.Size = new System.Drawing.Size(277, 47);
            this.TitleLabel.TabIndex = 12;
            this.TitleLabel.Text = "Dealer Option";
            // 
            // HorizontalLineLabel
            // 
            this.HorizontalLineLabel.AutoSize = true;
            this.HorizontalLineLabel.Location = new System.Drawing.Point(-3, 55);
            this.HorizontalLineLabel.Name = "HorizontalLineLabel";
            this.HorizontalLineLabel.Size = new System.Drawing.Size(805, 13);
            this.HorizontalLineLabel.TabIndex = 13;
            this.HorizontalLineLabel.Text = "_________________________________________________________________________________" +
    "____________________________________________________";
            // 
            // DeleteButton
            // 
            this.DeleteButton.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.DeleteButton.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.DeleteButton.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DeleteButton.Location = new System.Drawing.Point(514, 408);
            this.DeleteButton.Name = "DeleteButton";
            this.DeleteButton.Size = new System.Drawing.Size(139, 30);
            this.DeleteButton.TabIndex = 15;
            this.DeleteButton.Text = "Delete";
            this.DeleteButton.UseVisualStyleBackColor = false;
            this.DeleteButton.Click += new System.EventHandler(this.DeleteButton_Click);
            // 
            // codeDataGridViewTextBoxColumn
            // 
            this.codeDataGridViewTextBoxColumn.DataPropertyName = "Code";
            this.codeDataGridViewTextBoxColumn.HeaderText = "Code";
            this.codeDataGridViewTextBoxColumn.Name = "codeDataGridViewTextBoxColumn";
            // 
            // descriptionDataGridViewTextBoxColumn
            // 
            this.descriptionDataGridViewTextBoxColumn.DataPropertyName = "Description";
            this.descriptionDataGridViewTextBoxColumn.HeaderText = "Description";
            this.descriptionDataGridViewTextBoxColumn.Name = "descriptionDataGridViewTextBoxColumn";
            // 
            // priceDataGridViewTextBoxColumn
            // 
            this.priceDataGridViewTextBoxColumn.DataPropertyName = "Price";
            this.priceDataGridViewTextBoxColumn.HeaderText = "Price";
            this.priceDataGridViewTextBoxColumn.Name = "priceDataGridViewTextBoxColumn";
            // 
            // dealerOptionBindingSource
            // 
            this.dealerOptionBindingSource.DataSource = typeof(SIS.DealerOption);
            // 
            // customerBindingSource
            // 
            this.customerBindingSource.DataSource = typeof(SIS.Customer);
            // 
            // DealerOptionsListView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.DeleteButton);
            this.Controls.Add(this.HorizontalLineLabel);
            this.Controls.Add(this.TitleLabel);
            this.Controls.Add(this.SearchButton);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.AddButton);
            this.Controls.Add(this.BackButton);
            this.Controls.Add(this.StaffButton);
            this.Controls.Add(this.CurrentStaffButton);
            this.Controls.Add(this.CustomerButton);
            this.Controls.Add(this.InvoiceButton);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.OptButton);
            this.Controls.Add(this.OptionGridView);
            this.Name = "DealerOptionsListView";
            this.Text = "DealerOptionsListView";
            ((System.ComponentModel.ISupportInitialize)(this.OptionGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dealerOptionBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.customerBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView OptionGridView;
        private System.Windows.Forms.BindingSource customerBindingSource;
        private System.Windows.Forms.Button OptButton;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button InvoiceButton;
        private System.Windows.Forms.Button CustomerButton;
        private System.Windows.Forms.Button CurrentStaffButton;
        private System.Windows.Forms.Button StaffButton;
        private System.Windows.Forms.Button BackButton;
        private System.Windows.Forms.Button AddButton;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button SearchButton;
        private System.Windows.Forms.Label TitleLabel;
        private System.Windows.Forms.Label HorizontalLineLabel;
        private System.Windows.Forms.DataGridViewTextBoxColumn codeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn descriptionDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn priceDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource dealerOptionBindingSource;
        private System.Windows.Forms.Button DeleteButton;
    }
}