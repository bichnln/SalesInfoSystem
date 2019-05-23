namespace SIS
{
    partial class VehicleListView
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
            this.VehicleGridView = new System.Windows.Forms.DataGridView();
            this.VehicleButton = new System.Windows.Forms.Button();
            this.CustomerButton = new System.Windows.Forms.Button();
            this.InvoiceButton = new System.Windows.Forms.Button();
            this.DealerOptButton = new System.Windows.Forms.Button();
            this.CurrentStaffButton = new System.Windows.Forms.Button();
            this.StaffButton = new System.Windows.Forms.Button();
            this.BackButton = new System.Windows.Forms.Button();
            this.AddButton = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.SearchButton = new System.Windows.Forms.Button();
            this.TitleLabel = new System.Windows.Forms.Label();
            this.HorizontalLineLabel = new System.Windows.Forms.Label();
            this.vehicleTypeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.serialNumberDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.modelDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.yearDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.vehicleBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.customerBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.DeleteButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.VehicleGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vehicleBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.customerBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // VehicleGridView
            // 
            this.VehicleGridView.AutoGenerateColumns = false;
            this.VehicleGridView.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.VehicleGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.VehicleGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.vehicleTypeDataGridViewTextBoxColumn,
            this.serialNumberDataGridViewTextBoxColumn,
            this.nameDataGridViewTextBoxColumn,
            this.modelDataGridViewTextBoxColumn,
            this.yearDataGridViewTextBoxColumn});
            this.VehicleGridView.DataSource = this.vehicleBindingSource;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Candara", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.VehicleGridView.DefaultCellStyle = dataGridViewCellStyle1;
            this.VehicleGridView.GridColor = System.Drawing.SystemColors.ControlDarkDark;
            this.VehicleGridView.Location = new System.Drawing.Point(118, 115);
            this.VehicleGridView.Name = "VehicleGridView";
            this.VehicleGridView.Size = new System.Drawing.Size(680, 337);
            this.VehicleGridView.TabIndex = 0;
            this.VehicleGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.VehicleGridView_CellContentClick);
            // 
            // VehicleButton
            // 
            this.VehicleButton.AccessibleDescription = "";
            this.VehicleButton.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.VehicleButton.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.VehicleButton.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.VehicleButton.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.VehicleButton.Location = new System.Drawing.Point(0, 157);
            this.VehicleButton.Name = "VehicleButton";
            this.VehicleButton.Size = new System.Drawing.Size(121, 82);
            this.VehicleButton.TabIndex = 1;
            this.VehicleButton.Text = "Vehicle";
            this.VehicleButton.UseVisualStyleBackColor = false;
            // 
            // CustomerButton
            // 
            this.CustomerButton.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.CustomerButton.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.CustomerButton.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CustomerButton.Location = new System.Drawing.Point(0, 87);
            this.CustomerButton.Name = "CustomerButton";
            this.CustomerButton.Size = new System.Drawing.Size(121, 79);
            this.CustomerButton.TabIndex = 2;
            this.CustomerButton.Text = "Customer";
            this.CustomerButton.UseVisualStyleBackColor = false;
            this.CustomerButton.Click += new System.EventHandler(this.CustomerButton_Click);
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
            // 
            // DealerOptButton
            // 
            this.DealerOptButton.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.DealerOptButton.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.DealerOptButton.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DealerOptButton.Location = new System.Drawing.Point(0, 305);
            this.DealerOptButton.Name = "DealerOptButton";
            this.DealerOptButton.Size = new System.Drawing.Size(121, 75);
            this.DealerOptButton.TabIndex = 4;
            this.DealerOptButton.Text = "Dealer Options";
            this.DealerOptButton.UseVisualStyleBackColor = false;
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
            this.AddButton.Location = new System.Drawing.Point(659, 422);
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
            this.TitleLabel.Location = new System.Drawing.Point(332, 9);
            this.TitleLabel.Name = "TitleLabel";
            this.TitleLabel.Size = new System.Drawing.Size(152, 47);
            this.TitleLabel.TabIndex = 12;
            this.TitleLabel.Text = "Vehicle";
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
            // vehicleTypeDataGridViewTextBoxColumn
            // 
            this.vehicleTypeDataGridViewTextBoxColumn.DataPropertyName = "VehicleType";
            this.vehicleTypeDataGridViewTextBoxColumn.HeaderText = "VehicleType";
            this.vehicleTypeDataGridViewTextBoxColumn.Name = "vehicleTypeDataGridViewTextBoxColumn";
            this.vehicleTypeDataGridViewTextBoxColumn.ReadOnly = true;
            this.vehicleTypeDataGridViewTextBoxColumn.Width = 150;
            // 
            // serialNumberDataGridViewTextBoxColumn
            // 
            this.serialNumberDataGridViewTextBoxColumn.DataPropertyName = "SerialNumber";
            this.serialNumberDataGridViewTextBoxColumn.HeaderText = "SerialNumber";
            this.serialNumberDataGridViewTextBoxColumn.Name = "serialNumberDataGridViewTextBoxColumn";
            // 
            // nameDataGridViewTextBoxColumn
            // 
            this.nameDataGridViewTextBoxColumn.DataPropertyName = "Name";
            this.nameDataGridViewTextBoxColumn.HeaderText = "Name";
            this.nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
            this.nameDataGridViewTextBoxColumn.Width = 150;
            // 
            // modelDataGridViewTextBoxColumn
            // 
            this.modelDataGridViewTextBoxColumn.DataPropertyName = "Model";
            this.modelDataGridViewTextBoxColumn.HeaderText = "Model";
            this.modelDataGridViewTextBoxColumn.Name = "modelDataGridViewTextBoxColumn";
            this.modelDataGridViewTextBoxColumn.Width = 150;
            // 
            // yearDataGridViewTextBoxColumn
            // 
            this.yearDataGridViewTextBoxColumn.DataPropertyName = "Year";
            this.yearDataGridViewTextBoxColumn.HeaderText = "Year";
            this.yearDataGridViewTextBoxColumn.Name = "yearDataGridViewTextBoxColumn";
            this.yearDataGridViewTextBoxColumn.Width = 80;
            // 
            // vehicleBindingSource
            // 
            this.vehicleBindingSource.DataSource = typeof(SIS.Vehicle);
            // 
            // customerBindingSource
            // 
            this.customerBindingSource.DataSource = typeof(SIS.Customer);
            // 
            // DeleteButton
            // 
            this.DeleteButton.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.DeleteButton.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.DeleteButton.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DeleteButton.Location = new System.Drawing.Point(514, 422);
            this.DeleteButton.Name = "DeleteButton";
            this.DeleteButton.Size = new System.Drawing.Size(139, 30);
            this.DeleteButton.TabIndex = 15;
            this.DeleteButton.Text = "Delete";
            this.DeleteButton.UseVisualStyleBackColor = false;
            this.DeleteButton.Click += new System.EventHandler(this.DeleteButton_Click);
            // 
            // VehicleListView
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
            this.Controls.Add(this.DealerOptButton);
            this.Controls.Add(this.InvoiceButton);
            this.Controls.Add(this.CustomerButton);
            this.Controls.Add(this.VehicleButton);
            this.Controls.Add(this.VehicleGridView);
            this.Name = "VehicleListView";
            this.Text = "VehicleListView";
            ((System.ComponentModel.ISupportInitialize)(this.VehicleGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vehicleBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.customerBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView VehicleGridView;
        private System.Windows.Forms.BindingSource customerBindingSource;
        private System.Windows.Forms.Button VehicleButton;
        private System.Windows.Forms.Button CustomerButton;
        private System.Windows.Forms.Button InvoiceButton;
        private System.Windows.Forms.Button DealerOptButton;
        private System.Windows.Forms.Button CurrentStaffButton;
        private System.Windows.Forms.Button StaffButton;
        private System.Windows.Forms.Button BackButton;
        private System.Windows.Forms.Button AddButton;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button SearchButton;
        private System.Windows.Forms.Label TitleLabel;
        private System.Windows.Forms.Label HorizontalLineLabel;
        private System.Windows.Forms.DataGridViewTextBoxColumn vehicleTypeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn serialNumberDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn modelDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn yearDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource vehicleBindingSource;
        private System.Windows.Forms.Button DeleteButton;
    }
}