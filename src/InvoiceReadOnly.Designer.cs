namespace SIS
{
    partial class InvoiceReadOnly
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
            this.totalPaymentDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.isPaidDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.invoiceBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.TitleLabel = new System.Windows.Forms.Label();
            this.customerBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.InvoiceGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.invoiceBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.customerBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // InvoiceGridView
            // 
            this.InvoiceGridView.AllowUserToAddRows = false;
            this.InvoiceGridView.AllowUserToDeleteRows = false;
            this.InvoiceGridView.AllowUserToOrderColumns = true;
            this.InvoiceGridView.AutoGenerateColumns = false;
            this.InvoiceGridView.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.InvoiceGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.InvoiceGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.customerNameDataGridViewTextBoxColumn,
            this.salespersonNameDataGridViewTextBoxColumn,
            this.purchasedVehicleNameDataGridViewTextBoxColumn,
            this.tradeInVehicleNameDataGridViewTextBoxColumn,
            this.totalPaymentDataGridViewTextBoxColumn,
            this.isPaidDataGridViewCheckBoxColumn});
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
            this.InvoiceGridView.Location = new System.Drawing.Point(2, 68);
            this.InvoiceGridView.Name = "InvoiceGridView";
            this.InvoiceGridView.Size = new System.Drawing.Size(944, 343);
            this.InvoiceGridView.TabIndex = 0;
            this.InvoiceGridView.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.CustomerGridView_CellDoubleClick);
            // 
            // customerNameDataGridViewTextBoxColumn
            // 
            this.customerNameDataGridViewTextBoxColumn.DataPropertyName = "CustomerName";
            this.customerNameDataGridViewTextBoxColumn.HeaderText = "CustomerName";
            this.customerNameDataGridViewTextBoxColumn.Name = "customerNameDataGridViewTextBoxColumn";
            this.customerNameDataGridViewTextBoxColumn.ReadOnly = true;
            this.customerNameDataGridViewTextBoxColumn.Width = 200;
            // 
            // salespersonNameDataGridViewTextBoxColumn
            // 
            this.salespersonNameDataGridViewTextBoxColumn.DataPropertyName = "SalespersonName";
            this.salespersonNameDataGridViewTextBoxColumn.HeaderText = "SalespersonName";
            this.salespersonNameDataGridViewTextBoxColumn.Name = "salespersonNameDataGridViewTextBoxColumn";
            this.salespersonNameDataGridViewTextBoxColumn.ReadOnly = true;
            this.salespersonNameDataGridViewTextBoxColumn.Width = 200;
            // 
            // purchasedVehicleNameDataGridViewTextBoxColumn
            // 
            this.purchasedVehicleNameDataGridViewTextBoxColumn.DataPropertyName = "PurchasedVehicleName";
            this.purchasedVehicleNameDataGridViewTextBoxColumn.HeaderText = "PurchasedVehicleName";
            this.purchasedVehicleNameDataGridViewTextBoxColumn.Name = "purchasedVehicleNameDataGridViewTextBoxColumn";
            this.purchasedVehicleNameDataGridViewTextBoxColumn.ReadOnly = true;
            this.purchasedVehicleNameDataGridViewTextBoxColumn.Width = 150;
            // 
            // tradeInVehicleNameDataGridViewTextBoxColumn
            // 
            this.tradeInVehicleNameDataGridViewTextBoxColumn.DataPropertyName = "TradeInVehicleName";
            this.tradeInVehicleNameDataGridViewTextBoxColumn.HeaderText = "TradeInVehicleName";
            this.tradeInVehicleNameDataGridViewTextBoxColumn.Name = "tradeInVehicleNameDataGridViewTextBoxColumn";
            this.tradeInVehicleNameDataGridViewTextBoxColumn.ReadOnly = true;
            this.tradeInVehicleNameDataGridViewTextBoxColumn.Width = 150;
            // 
            // totalPaymentDataGridViewTextBoxColumn
            // 
            this.totalPaymentDataGridViewTextBoxColumn.DataPropertyName = "TotalPayment";
            this.totalPaymentDataGridViewTextBoxColumn.HeaderText = "TotalPayment";
            this.totalPaymentDataGridViewTextBoxColumn.Name = "totalPaymentDataGridViewTextBoxColumn";
            this.totalPaymentDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // isPaidDataGridViewCheckBoxColumn
            // 
            this.isPaidDataGridViewCheckBoxColumn.DataPropertyName = "IsPaid";
            this.isPaidDataGridViewCheckBoxColumn.HeaderText = "IsPaid";
            this.isPaidDataGridViewCheckBoxColumn.Name = "isPaidDataGridViewCheckBoxColumn";
            // 
            // invoiceBindingSource
            // 
            this.invoiceBindingSource.DataSource = typeof(SIS.Invoice);
            // 
            // TitleLabel
            // 
            this.TitleLabel.AutoSize = true;
            this.TitleLabel.Font = new System.Drawing.Font("Cambria", 30F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TitleLabel.ForeColor = System.Drawing.SystemColors.GrayText;
            this.TitleLabel.Location = new System.Drawing.Point(389, 9);
            this.TitleLabel.Name = "TitleLabel";
            this.TitleLabel.Size = new System.Drawing.Size(153, 47);
            this.TitleLabel.TabIndex = 12;
            this.TitleLabel.Text = "Invoice";
            // 
            // customerBindingSource
            // 
            this.customerBindingSource.DataSource = typeof(SIS.Customer);
            // 
            // InvoiceReadOnly
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(947, 462);
            this.Controls.Add(this.TitleLabel);
            this.Controls.Add(this.InvoiceGridView);
            this.Name = "InvoiceReadOnly";
            this.Text = "InvoiceReadOnly";
            ((System.ComponentModel.ISupportInitialize)(this.InvoiceGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.invoiceBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.customerBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView InvoiceGridView;
        private System.Windows.Forms.BindingSource customerBindingSource;
        private System.Windows.Forms.Label TitleLabel;
        private System.Windows.Forms.DataGridViewTextBoxColumn customerNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn salespersonNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn purchasedVehicleNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tradeInVehicleNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn totalPaymentDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn isPaidDataGridViewCheckBoxColumn;
        private System.Windows.Forms.BindingSource invoiceBindingSource;
    }
}