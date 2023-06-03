namespace Point_of_Sale.Forms
{
    partial class ViewReceipt
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
            this.view_receipt_grid = new System.Windows.Forms.DataGridView();
            this.Product = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Quantity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Amount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.items_label = new System.Windows.Forms.Label();
            this.items_count_label = new System.Windows.Forms.Label();
            this.total_label = new System.Windows.Forms.Label();
            this.total_count_label = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.view_receipt_grid)).BeginInit();
            this.SuspendLayout();
            // 
            // view_receipt_grid
            // 
            this.view_receipt_grid.AllowUserToAddRows = false;
            this.view_receipt_grid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.view_receipt_grid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.view_receipt_grid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Product,
            this.Quantity,
            this.Amount});
            this.view_receipt_grid.Dock = System.Windows.Forms.DockStyle.Top;
            this.view_receipt_grid.Location = new System.Drawing.Point(0, 0);
            this.view_receipt_grid.Name = "view_receipt_grid";
            this.view_receipt_grid.ReadOnly = true;
            this.view_receipt_grid.Size = new System.Drawing.Size(385, 292);
            this.view_receipt_grid.TabIndex = 0;
            // 
            // Product
            // 
            this.Product.HeaderText = "Product";
            this.Product.Name = "Product";
            this.Product.ReadOnly = true;
            // 
            // Quantity
            // 
            this.Quantity.HeaderText = "Quantity";
            this.Quantity.Name = "Quantity";
            this.Quantity.ReadOnly = true;
            // 
            // Amount
            // 
            this.Amount.HeaderText = "Amount";
            this.Amount.Name = "Amount";
            this.Amount.ReadOnly = true;
            // 
            // items_label
            // 
            this.items_label.AutoSize = true;
            this.items_label.Font = new System.Drawing.Font("Yu Gothic UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.items_label.Location = new System.Drawing.Point(65, 327);
            this.items_label.Name = "items_label";
            this.items_label.Size = new System.Drawing.Size(66, 25);
            this.items_label.TabIndex = 1;
            this.items_label.Text = "ITEMS";
            // 
            // items_count_label
            // 
            this.items_count_label.AutoSize = true;
            this.items_count_label.Font = new System.Drawing.Font("Yu Gothic UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.items_count_label.Location = new System.Drawing.Point(86, 369);
            this.items_count_label.Name = "items_count_label";
            this.items_count_label.Size = new System.Drawing.Size(23, 25);
            this.items_count_label.TabIndex = 1;
            this.items_count_label.Text = "0";
            // 
            // total_label
            // 
            this.total_label.AutoSize = true;
            this.total_label.Font = new System.Drawing.Font("Yu Gothic UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.total_label.Location = new System.Drawing.Point(238, 327);
            this.total_label.Name = "total_label";
            this.total_label.Size = new System.Drawing.Size(67, 25);
            this.total_label.TabIndex = 1;
            this.total_label.Text = "TOTAL";
            // 
            // total_count_label
            // 
            this.total_count_label.AutoSize = true;
            this.total_count_label.Font = new System.Drawing.Font("Yu Gothic UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.total_count_label.Location = new System.Drawing.Point(256, 369);
            this.total_count_label.Name = "total_count_label";
            this.total_count_label.Size = new System.Drawing.Size(23, 25);
            this.total_count_label.TabIndex = 1;
            this.total_count_label.Text = "0";
            // 
            // ViewReceipt
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(385, 433);
            this.Controls.Add(this.total_count_label);
            this.Controls.Add(this.total_label);
            this.Controls.Add(this.items_count_label);
            this.Controls.Add(this.items_label);
            this.Controls.Add(this.view_receipt_grid);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "ViewReceipt";
            this.Text = "ViewReceipt";
            ((System.ComponentModel.ISupportInitialize)(this.view_receipt_grid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView view_receipt_grid;
        private System.Windows.Forms.Label items_label;
        private System.Windows.Forms.Label items_count_label;
        private System.Windows.Forms.Label total_label;
        private System.Windows.Forms.Label total_count_label;
        private System.Windows.Forms.DataGridViewTextBoxColumn Product;
        private System.Windows.Forms.DataGridViewTextBoxColumn Quantity;
        private System.Windows.Forms.DataGridViewTextBoxColumn Amount;
    }
}