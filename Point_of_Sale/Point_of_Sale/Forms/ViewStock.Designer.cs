namespace Point_of_Sale.Forms
{
    partial class ViewStock
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
            this.view_stock_grid = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.view_stock_grid)).BeginInit();
            this.SuspendLayout();
            // 
            // view_stock_grid
            // 
            this.view_stock_grid.AllowUserToAddRows = false;
            this.view_stock_grid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.view_stock_grid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.view_stock_grid.Dock = System.Windows.Forms.DockStyle.Fill;
            this.view_stock_grid.Location = new System.Drawing.Point(0, 0);
            this.view_stock_grid.Name = "view_stock_grid";
            this.view_stock_grid.ReadOnly = true;
            this.view_stock_grid.Size = new System.Drawing.Size(562, 210);
            this.view_stock_grid.TabIndex = 0;
            this.view_stock_grid.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.view_stock_grid_CellClick);
            // 
            // ViewStock
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(562, 210);
            this.Controls.Add(this.view_stock_grid);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "ViewStock";
            this.Text = "ViewStock";
            ((System.ComponentModel.ISupportInitialize)(this.view_stock_grid)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView view_stock_grid;
    }
}