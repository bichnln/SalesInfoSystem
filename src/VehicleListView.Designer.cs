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
            this.serialNumberDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.vehicleTypeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.modelDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.yearDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IsSold = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.vehicleBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.VehicleButton = new System.Windows.Forms.Button();
            this.CustomerButton = new System.Windows.Forms.Button();
            this.InvoiceButton = new System.Windows.Forms.Button();
            this.DealerOptButton = new System.Windows.Forms.Button();
            this.StaffButton = new System.Windows.Forms.Button();
            this.AddButton = new System.Windows.Forms.Button();
            this.TitleLabel = new System.Windows.Forms.Label();
            this.HorizontalLineLabel = new System.Windows.Forms.Label();
            this.DeleteButton = new System.Windows.Forms.Button();
            this.customerBindingSource = new System.Windows.Forms.BindingSource(this.components);
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
            this.serialNumberDataGridViewTextBoxColumn,
            this.vehicleTypeDataGridViewTextBoxColumn,
            this.nameDataGridViewTextBoxColumn,
            this.modelDataGridViewTextBoxColumn,
            this.yearDataGridViewTextBoxColumn,
            this.IsSold});
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
            this.VehicleGridView.Location = new System.Drawing.Point(118, 87);
            this.VehicleGridView.Name = "VehicleGridView";
            this.VehicleGridView.ReadOnly = true;
            this.VehicleGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.VehicleGridView.Size = new System.Drawing.Size(732, 365);
            this.VehicleGridView.TabIndex = 0;
          
            this.VehicleGridView.CellContentDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.VehicleGridView_CellContentDoubleClick);
            // 
            // serialNumberDataGridViewTextBoxColumn
            // 
            this.serialNumberDataGridViewTextBoxColumn.DataPropertyName = "SerialNumber";
            this.serialNumberDataGridViewTextBoxColumn.HeaderText = "SerialNumber";
            this.serialNumberDataGridViewTextBoxColumn.Name = "serialNumberDataGridViewTextBoxColumn";
            this.serialNumberDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // vehicleTypeDataGridViewTextBoxColumn
            // 
            this.vehicleTypeDataGridViewTextBoxColumn.DataPropertyName = "VehicleType";
            this.vehicleTypeDataGridViewTextBoxColumn.HeaderText = "VehicleType";
            this.vehicleTypeDataGridViewTextBoxColumn.Name = "vehicleTypeDataGridViewTextBoxColumn";
            this.vehicleTypeDataGridViewTextBoxColumn.ReadOnly = true;
            this.vehicleTypeDataGridViewTextBoxColumn.Width = 150;
            // 
            // nameDataGridViewTextBoxColumn
            // 
            this.nameDataGridViewTextBoxColumn.DataPropertyName = "Name";
            this.nameDataGridViewTextBoxColumn.HeaderText = "Name";
            this.nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
            this.nameDataGridViewTextBoxColumn.ReadOnly = true;
            this.nameDataGridViewTextBoxColumn.Width = 150;
            // 
            // modelDataGridViewTextBoxColumn
            // 
            this.modelDataGridViewTextBoxColumn.DataPropertyName = "Model";
            this.modelDataGridViewTextBoxColumn.HeaderText = "Model";
            this.modelDataGridViewTextBoxColumn.Name = "modelDataGridViewTextBoxColumn";
            this.modelDataGridViewTextBoxColumn.ReadOnly = true;
            this.modelDataGridViewTextBoxColumn.Width = 150;
            // 
            // yearDataGridViewTextBoxColumn
            // 
            this.yearDataGridViewTextBoxColumn.DataPropertyName = "Year";
            this.yearDataGridViewTextBoxColumn.HeaderText = "Year";
            this.yearDataGridViewTextBoxColumn.Name = "yearDataGridViewTextBoxColumn";
            this.yearDataGridViewTextBoxColumn.ReadOnly = true;
            this.yearDataGridViewTextBoxColumn.Width = 80;
            // 
            // IsSold
            // 
            this.IsSold.DataPropertyName = "IsSold";
            this.IsSold.HeaderText = "IsSold";
            this.IsSold.Name = "IsSold";
            this.IsSold.ReadOnly = true;
            this.IsSold.Width = 50;
            // 
            // vehicleBindingSource
            // 
            this.vehicleBindingSource.DataSource = typeof(SIS.Vehicle);
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
            this.InvoiceButton.Click += new System.EventHandler(this.InvoiceButton_Click);
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
            this.DealerOptButton.Click += new System.EventHandler(this.DealerOptButton_Click);
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
            // AddButton
            // 
            this.AddButton.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.AddButton.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.AddButton.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddButton.Location = new System.Drawing.Point(694, 471);
            this.AddButton.Name = "AddButton";
            this.AddButton.Size = new System.Drawing.Size(139, 30);
            this.AddButton.TabIndex = 8;
            this.AddButton.Text = "Add Customer";
            this.AddButton.UseVisualStyleBackColor = false;
            this.AddButton.Click += new System.EventHandler(this.button3_Click);
            // 
            // TitleLabel
            // 
            this.TitleLabel.AutoSize = true;
            this.TitleLabel.Font = new System.Drawing.Font("Cambria", 30F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TitleLabel.ForeColor = System.Drawing.SystemColors.GrayText;
            this.TitleLabel.Location = new System.Drawing.Point(352, 9);
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
            this.HorizontalLineLabel.Size = new System.Drawing.Size(1051, 13);
            this.HorizontalLineLabel.TabIndex = 13;
            this.HorizontalLineLabel.Text = "_________________________________________________________________________________" +
    "________________________________________________________________________________" +
    "_____________";
            // 
            // DeleteButton
            // 
            this.DeleteButton.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.DeleteButton.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.DeleteButton.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DeleteButton.Location = new System.Drawing.Point(529, 471);
            this.DeleteButton.Name = "DeleteButton";
            this.DeleteButton.Size = new System.Drawing.Size(139, 30);
            this.DeleteButton.TabIndex = 15;
            this.DeleteButton.Text = "Delete";
            this.DeleteButton.UseVisualStyleBackColor = false;
            this.DeleteButton.Click += new System.EventHandler(this.DeleteButton_Click);
            // 
            // customerBindingSource
            // 
            this.customerBindingSource.DataSource = typeof(SIS.Customer);
            // 
            // VehicleListView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(840, 513);
            this.Controls.Add(this.DeleteButton);
            this.Controls.Add(this.HorizontalLineLabel);
            this.Controls.Add(this.TitleLabel);
            this.Controls.Add(this.AddButton);
            this.Controls.Add(this.StaffButton);
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
        private System.Windows.Forms.Button StaffButton;
        private System.Windows.Forms.Button AddButton;
        private System.Windows.Forms.Label TitleLabel;
        private System.Windows.Forms.Label HorizontalLineLabel;
        private System.Windows.Forms.BindingSource vehicleBindingSource;
        private System.Windows.Forms.Button DeleteButton;
        private System.Windows.Forms.DataGridViewTextBoxColumn serialNumberDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn vehicleTypeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn modelDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn yearDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn IsSold;
    }
}