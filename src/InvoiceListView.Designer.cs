namespace SIS
{
    partial class InvoiceListView
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
            this.InvoiceGridView = new System.Windows.Forms.DataGridView();
            this.customerNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.salespersonNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.purchasedVehicleNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tradeInVehicleNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column1 = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.invoiceBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.salesInvoiceBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.CustomerButton = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.InvoiceButton = new System.Windows.Forms.Button();
            this.DealerOptButton = new System.Windows.Forms.Button();
            this.StaffButton = new System.Windows.Forms.Button();
            this.TitleLabel = new System.Windows.Forms.Label();
            this.HorizontalLineLabel = new System.Windows.Forms.Label();
            this.DeleteButton = new System.Windows.Forms.Button();
            this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.customerBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.InvoiceGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.invoiceBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.salesInvoiceBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.customerBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // InvoiceGridView
            // 
            this.InvoiceGridView.AllowUserToAddRows = false;
            this.InvoiceGridView.AllowUserToDeleteRows = false;
            this.InvoiceGridView.AutoGenerateColumns = false;
            this.InvoiceGridView.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.InvoiceGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.InvoiceGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.customerNameDataGridViewTextBoxColumn,
            this.salespersonNameDataGridViewTextBoxColumn,
            this.purchasedVehicleNameDataGridViewTextBoxColumn,
            this.tradeInVehicleNameDataGridViewTextBoxColumn,
            this.dataGridViewTextBoxColumn6,
            this.Column1});
            this.InvoiceGridView.DataSource = this.invoiceBindingSource;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Candara", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.InvoiceGridView.DefaultCellStyle = dataGridViewCellStyle1;
            this.InvoiceGridView.GridColor = System.Drawing.SystemColors.ControlDarkDark;
            this.InvoiceGridView.Location = new System.Drawing.Point(118, 82);
            this.InvoiceGridView.Name = "InvoiceGridView";
            this.InvoiceGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.InvoiceGridView.Size = new System.Drawing.Size(892, 368);
            this.InvoiceGridView.TabIndex = 0;
           
            this.InvoiceGridView.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.InvoiceGridView_CellDoubleClick);
            // 
            // customerNameDataGridViewTextBoxColumn
            // 
            this.customerNameDataGridViewTextBoxColumn.DataPropertyName = "CustomerName";
            this.customerNameDataGridViewTextBoxColumn.Frozen = true;
            this.customerNameDataGridViewTextBoxColumn.HeaderText = "CustomerName";
            this.customerNameDataGridViewTextBoxColumn.Name = "customerNameDataGridViewTextBoxColumn";
            this.customerNameDataGridViewTextBoxColumn.ReadOnly = true;
            this.customerNameDataGridViewTextBoxColumn.Width = 200;
            // 
            // salespersonNameDataGridViewTextBoxColumn
            // 
            this.salespersonNameDataGridViewTextBoxColumn.DataPropertyName = "SalespersonName";
            this.salespersonNameDataGridViewTextBoxColumn.Frozen = true;
            this.salespersonNameDataGridViewTextBoxColumn.HeaderText = "SalespersonName";
            this.salespersonNameDataGridViewTextBoxColumn.Name = "salespersonNameDataGridViewTextBoxColumn";
            this.salespersonNameDataGridViewTextBoxColumn.ReadOnly = true;
            this.salespersonNameDataGridViewTextBoxColumn.Width = 200;
            // 
            // purchasedVehicleNameDataGridViewTextBoxColumn
            // 
            this.purchasedVehicleNameDataGridViewTextBoxColumn.DataPropertyName = "PurchasedVehicleName";
            this.purchasedVehicleNameDataGridViewTextBoxColumn.Frozen = true;
            this.purchasedVehicleNameDataGridViewTextBoxColumn.HeaderText = "PurchasedVehicleName";
            this.purchasedVehicleNameDataGridViewTextBoxColumn.Name = "purchasedVehicleNameDataGridViewTextBoxColumn";
            this.purchasedVehicleNameDataGridViewTextBoxColumn.ReadOnly = true;
            this.purchasedVehicleNameDataGridViewTextBoxColumn.Width = 150;
            // 
            // tradeInVehicleNameDataGridViewTextBoxColumn
            // 
            this.tradeInVehicleNameDataGridViewTextBoxColumn.DataPropertyName = "TradeInVehicleName";
            this.tradeInVehicleNameDataGridViewTextBoxColumn.Frozen = true;
            this.tradeInVehicleNameDataGridViewTextBoxColumn.HeaderText = "TradeInVehicleName";
            this.tradeInVehicleNameDataGridViewTextBoxColumn.Name = "tradeInVehicleNameDataGridViewTextBoxColumn";
            this.tradeInVehicleNameDataGridViewTextBoxColumn.ReadOnly = true;
            this.tradeInVehicleNameDataGridViewTextBoxColumn.Width = 150;
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "TotalPayment";
            this.dataGridViewTextBoxColumn6.Frozen = true;
            this.dataGridViewTextBoxColumn6.HeaderText = "TotalPayment";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            this.dataGridViewTextBoxColumn6.ReadOnly = true;
            // 
            // Column1
            // 
            this.Column1.DataPropertyName = "IsPaid";
            this.Column1.Frozen = true;
            this.Column1.HeaderText = "IsPaid";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            this.Column1.Width = 50;
            // 
            // invoiceBindingSource
            // 
            this.invoiceBindingSource.DataSource = typeof(SIS.Invoice);
            // 
            // CustomerButton
            // 
            this.CustomerButton.AccessibleDescription = "";
            this.CustomerButton.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.CustomerButton.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.CustomerButton.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CustomerButton.ForeColor = System.Drawing.SystemColors.ControlText;
            this.CustomerButton.Location = new System.Drawing.Point(0, 82);
            this.CustomerButton.Name = "CustomerButton";
            this.CustomerButton.Size = new System.Drawing.Size(121, 82);
            this.CustomerButton.TabIndex = 1;
            this.CustomerButton.Text = "Customer";
            this.CustomerButton.UseVisualStyleBackColor = false;
            this.CustomerButton.Click += new System.EventHandler(this.CustomerButton_Click);
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
            this.InvoiceButton.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.InvoiceButton.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.InvoiceButton.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.InvoiceButton.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
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
            // TitleLabel
            // 
            this.TitleLabel.AutoSize = true;
            this.TitleLabel.Font = new System.Drawing.Font("Cambria", 30F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TitleLabel.ForeColor = System.Drawing.SystemColors.GrayText;
            this.TitleLabel.Location = new System.Drawing.Point(429, 9);
            this.TitleLabel.Name = "TitleLabel";
            this.TitleLabel.Size = new System.Drawing.Size(153, 47);
            this.TitleLabel.TabIndex = 12;
            this.TitleLabel.Text = "Invoice";
           
            // 
            // HorizontalLineLabel
            // 
            this.HorizontalLineLabel.AutoSize = true;
            this.HorizontalLineLabel.Location = new System.Drawing.Point(-3, 55);
            this.HorizontalLineLabel.Name = "HorizontalLineLabel";
            this.HorizontalLineLabel.Size = new System.Drawing.Size(1039, 13);
            this.HorizontalLineLabel.TabIndex = 13;
            this.HorizontalLineLabel.Text = "_________________________________________________________________________________" +
    "________________________________________________________________________________" +
    "___________";
            // 
            // DeleteButton
            // 
            this.DeleteButton.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.DeleteButton.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.DeleteButton.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DeleteButton.Location = new System.Drawing.Point(854, 456);
            this.DeleteButton.Name = "DeleteButton";
            this.DeleteButton.Size = new System.Drawing.Size(139, 30);
            this.DeleteButton.TabIndex = 15;
            this.DeleteButton.Text = "Delete";
            this.DeleteButton.UseVisualStyleBackColor = false;
            this.DeleteButton.Click += new System.EventHandler(this.DeleteButton_Click);
            // 
            // bindingSource1
            // 
            this.bindingSource1.DataSource = typeof(SIS.Invoice);
            
            // 
            // customerBindingSource
            // 
            this.customerBindingSource.DataSource = typeof(SIS.Customer);
            // 
            // InvoiceListView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(1009, 492);
            this.Controls.Add(this.DeleteButton);
            this.Controls.Add(this.HorizontalLineLabel);
            this.Controls.Add(this.TitleLabel);
            this.Controls.Add(this.StaffButton);
            this.Controls.Add(this.DealerOptButton);
            this.Controls.Add(this.InvoiceButton);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.CustomerButton);
            this.Controls.Add(this.InvoiceGridView);
            this.Name = "InvoiceListView";
            this.Text = "InvoiceListView";
            ((System.ComponentModel.ISupportInitialize)(this.InvoiceGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.invoiceBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.salesInvoiceBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.customerBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.BindingSource customerBindingSource;
        private System.Windows.Forms.Button CustomerButton;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button InvoiceButton;
        private System.Windows.Forms.Button DealerOptButton;
        private System.Windows.Forms.Button StaffButton;
        private System.Windows.Forms.Label TitleLabel;
        private System.Windows.Forms.Label HorizontalLineLabel;
        private System.Windows.Forms.BindingSource salesInvoiceBindingSource;
        private System.Windows.Forms.DataGridView InvoiceGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn custDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sPersonDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn purchasedVehicleDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tradedVehicleDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tradeInAllowanceDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn totalPaymentDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn taxDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn totalFeesDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn totalDealerOptionPriceDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn negotiatedPriceDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource bindingSource1;
        private System.Windows.Forms.BindingSource invoiceBindingSource;
        private System.Windows.Forms.Button DeleteButton;
        private System.Windows.Forms.DataGridViewTextBoxColumn customerNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn salespersonNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn purchasedVehicleNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tradeInVehicleNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Column1;
    }
}