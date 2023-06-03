namespace Point_of_Sale.Forms
{
    partial class ViewSales
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
            this.view_sales_grid = new System.Windows.Forms.DataGridView();
            this.SalesID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Quantity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Total = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Date = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.count_label = new System.Windows.Forms.Label();
            this.count_count_label = new System.Windows.Forms.Label();
            this.total_label = new System.Windows.Forms.Label();
            this.total_count_label = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.view_sales_grid)).BeginInit();
            this.SuspendLayout();
            // 
            // view_sales_grid
            // 
            this.view_sales_grid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.view_sales_grid.BackgroundColor = System.Drawing.Color.Gray;
            this.view_sales_grid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.view_sales_grid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.SalesID,
            this.Quantity,
            this.Total,
            this.Date});
            this.view_sales_grid.Dock = System.Windows.Forms.DockStyle.Top;
            this.view_sales_grid.Location = new System.Drawing.Point(0, 0);
            this.view_sales_grid.Name = "view_sales_grid";
            this.view_sales_grid.ReadOnly = true;
            this.view_sales_grid.Size = new System.Drawing.Size(772, 198);
            this.view_sales_grid.TabIndex = 0;
            // 
            // SalesID
            // 
            this.SalesID.HeaderText = "SalesID";
            this.SalesID.Name = "SalesID";
            this.SalesID.ReadOnly = true;
            // 
            // Quantity
            // 
            this.Quantity.HeaderText = "Quantity";
            this.Quantity.Name = "Quantity";
            this.Quantity.ReadOnly = true;
            // 
            // Total
            // 
            this.Total.HeaderText = "Total";
            this.Total.Name = "Total";
            this.Total.ReadOnly = true;
            // 
            // Date
            // 
            this.Date.HeaderText = "Date";
            this.Date.Name = "Date";
            this.Date.ReadOnly = true;
            // 
            // count_label
            // 
            this.count_label.AutoSize = true;
            this.count_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.count_label.Location = new System.Drawing.Point(187, 211);
            this.count_label.Name = "count_label";
            this.count_label.Size = new System.Drawing.Size(82, 24);
            this.count_label.TabIndex = 1;
            this.count_label.Text = "COUNT";
            // 
            // count_count_label
            // 
            this.count_count_label.AutoSize = true;
            this.count_count_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.count_count_label.Location = new System.Drawing.Point(216, 251);
            this.count_count_label.Name = "count_count_label";
            this.count_count_label.Size = new System.Drawing.Size(21, 24);
            this.count_count_label.TabIndex = 1;
            this.count_count_label.Text = "0";
            // 
            // total_label
            // 
            this.total_label.AutoSize = true;
            this.total_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.total_label.Location = new System.Drawing.Point(503, 211);
            this.total_label.Name = "total_label";
            this.total_label.Size = new System.Drawing.Size(77, 24);
            this.total_label.TabIndex = 1;
            this.total_label.Text = "TOTAL";
            // 
            // total_count_label
            // 
            this.total_count_label.AutoSize = true;
            this.total_count_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.total_count_label.Location = new System.Drawing.Point(528, 251);
            this.total_count_label.Name = "total_count_label";
            this.total_count_label.Size = new System.Drawing.Size(21, 24);
            this.total_count_label.TabIndex = 1;
            this.total_count_label.Text = "0";
            // 
            // ViewSales
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(772, 285);
            this.Controls.Add(this.total_count_label);
            this.Controls.Add(this.count_count_label);
            this.Controls.Add(this.total_label);
            this.Controls.Add(this.count_label);
            this.Controls.Add(this.view_sales_grid);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "ViewSales";
            this.Text = "ViewSales";
            ((System.ComponentModel.ISupportInitialize)(this.view_sales_grid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView view_sales_grid;
        private System.Windows.Forms.Label count_label;
        private System.Windows.Forms.Label count_count_label;
        private System.Windows.Forms.Label total_label;
        private System.Windows.Forms.Label total_count_label;
        private System.Windows.Forms.DataGridViewTextBoxColumn SalesID;
        private System.Windows.Forms.DataGridViewTextBoxColumn Quantity;
        private System.Windows.Forms.DataGridViewTextBoxColumn Total;
        private System.Windows.Forms.DataGridViewTextBoxColumn Date;
    }
}