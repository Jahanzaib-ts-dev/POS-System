namespace Point_of_Sale
{
    partial class UpdateInventoryForm
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
            this.selling_price_textbox = new System.Windows.Forms.TextBox();
            this.product_quantity_textbox = new System.Windows.Forms.TextBox();
            this.purchasing_cost_textbox = new System.Windows.Forms.TextBox();
            this.product_name_textbox = new System.Windows.Forms.TextBox();
            this.selling_price_label = new System.Windows.Forms.Label();
            this.purchasing_cost_label = new System.Windows.Forms.Label();
            this.product_quantity_label = new System.Windows.Forms.Label();
            this.product_name_label = new System.Windows.Forms.Label();
            this.Header = new System.Windows.Forms.Panel();
            this.Panel_label = new System.Windows.Forms.Label();
            this.Update_Prodct_label = new System.Windows.Forms.Label();
            this.update_button = new System.Windows.Forms.Button();
            this.Header.SuspendLayout();
            this.SuspendLayout();
            // 
            // selling_price_textbox
            // 
            this.selling_price_textbox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.selling_price_textbox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.selling_price_textbox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.selling_price_textbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.selling_price_textbox.Location = new System.Drawing.Point(184, 254);
            this.selling_price_textbox.Name = "selling_price_textbox";
            this.selling_price_textbox.Size = new System.Drawing.Size(141, 22);
            this.selling_price_textbox.TabIndex = 3;
            this.selling_price_textbox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.selling_price_textbox_KeyPress);
            // 
            // product_quantity_textbox
            // 
            this.product_quantity_textbox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.product_quantity_textbox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.product_quantity_textbox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.product_quantity_textbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.product_quantity_textbox.Location = new System.Drawing.Point(184, 181);
            this.product_quantity_textbox.Name = "product_quantity_textbox";
            this.product_quantity_textbox.Size = new System.Drawing.Size(141, 22);
            this.product_quantity_textbox.TabIndex = 1;
            this.product_quantity_textbox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.product_quantity_textbox_KeyPress);
            // 
            // purchasing_cost_textbox
            // 
            this.purchasing_cost_textbox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.purchasing_cost_textbox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.purchasing_cost_textbox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.purchasing_cost_textbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.purchasing_cost_textbox.Location = new System.Drawing.Point(184, 216);
            this.purchasing_cost_textbox.Name = "purchasing_cost_textbox";
            this.purchasing_cost_textbox.Size = new System.Drawing.Size(141, 22);
            this.purchasing_cost_textbox.TabIndex = 2;
            this.purchasing_cost_textbox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.purchasing_cost_textbox_KeyPress);
            // 
            // product_name_textbox
            // 
            this.product_name_textbox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.product_name_textbox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.product_name_textbox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.product_name_textbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.product_name_textbox.Location = new System.Drawing.Point(184, 140);
            this.product_name_textbox.Name = "product_name_textbox";
            this.product_name_textbox.ReadOnly = true;
            this.product_name_textbox.Size = new System.Drawing.Size(141, 22);
            this.product_name_textbox.TabIndex = 0;
            // 
            // selling_price_label
            // 
            this.selling_price_label.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.selling_price_label.AutoSize = true;
            this.selling_price_label.Font = new System.Drawing.Font("Yu Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.selling_price_label.Location = new System.Drawing.Point(59, 254);
            this.selling_price_label.Name = "selling_price_label";
            this.selling_price_label.Size = new System.Drawing.Size(119, 21);
            this.selling_price_label.TabIndex = 9;
            this.selling_price_label.Text = "Selling Price :";
            // 
            // purchasing_cost_label
            // 
            this.purchasing_cost_label.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.purchasing_cost_label.AutoSize = true;
            this.purchasing_cost_label.Font = new System.Drawing.Font("Yu Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.purchasing_cost_label.Location = new System.Drawing.Point(30, 216);
            this.purchasing_cost_label.Name = "purchasing_cost_label";
            this.purchasing_cost_label.Size = new System.Drawing.Size(148, 21);
            this.purchasing_cost_label.TabIndex = 10;
            this.purchasing_cost_label.Text = "Purchasing Cost :";
            // 
            // product_quantity_label
            // 
            this.product_quantity_label.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.product_quantity_label.AutoSize = true;
            this.product_quantity_label.Font = new System.Drawing.Font("Yu Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.product_quantity_label.Location = new System.Drawing.Point(25, 181);
            this.product_quantity_label.Name = "product_quantity_label";
            this.product_quantity_label.Size = new System.Drawing.Size(153, 21);
            this.product_quantity_label.TabIndex = 11;
            this.product_quantity_label.Text = "Product Quantity :";
            // 
            // product_name_label
            // 
            this.product_name_label.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.product_name_label.AutoSize = true;
            this.product_name_label.Font = new System.Drawing.Font("Yu Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.product_name_label.Location = new System.Drawing.Point(46, 141);
            this.product_name_label.Name = "product_name_label";
            this.product_name_label.Size = new System.Drawing.Size(132, 21);
            this.product_name_label.TabIndex = 12;
            this.product_name_label.Text = "Product Name :";
            // 
            // Header
            // 
            this.Header.BackColor = System.Drawing.Color.LightSkyBlue;
            this.Header.Controls.Add(this.Panel_label);
            this.Header.Controls.Add(this.Update_Prodct_label);
            this.Header.Dock = System.Windows.Forms.DockStyle.Top;
            this.Header.Location = new System.Drawing.Point(0, 0);
            this.Header.Margin = new System.Windows.Forms.Padding(2);
            this.Header.Name = "Header";
            this.Header.Size = new System.Drawing.Size(361, 81);
            this.Header.TabIndex = 17;
            // 
            // Panel_label
            // 
            this.Panel_label.AutoSize = true;
            this.Panel_label.Font = new System.Drawing.Font("Impact", 21.75F);
            this.Panel_label.Location = new System.Drawing.Point(141, 45);
            this.Panel_label.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Panel_label.Name = "Panel_label";
            this.Panel_label.Size = new System.Drawing.Size(83, 36);
            this.Panel_label.TabIndex = 0;
            this.Panel_label.Text = "Panel";
            // 
            // Update_Prodct_label
            // 
            this.Update_Prodct_label.AutoSize = true;
            this.Update_Prodct_label.Font = new System.Drawing.Font("Impact", 21.75F);
            this.Update_Prodct_label.Location = new System.Drawing.Point(84, 9);
            this.Update_Prodct_label.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Update_Prodct_label.Name = "Update_Prodct_label";
            this.Update_Prodct_label.Size = new System.Drawing.Size(198, 36);
            this.Update_Prodct_label.TabIndex = 0;
            this.Update_Prodct_label.Text = "Update Product";
            // 
            // update_button
            // 
            this.update_button.BackColor = System.Drawing.Color.LightSkyBlue;
            this.update_button.FlatAppearance.MouseDownBackColor = System.Drawing.Color.LightSkyBlue;
            this.update_button.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.update_button.Font = new System.Drawing.Font("Impact", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.update_button.Location = new System.Drawing.Point(99, 317);
            this.update_button.Name = "update_button";
            this.update_button.Size = new System.Drawing.Size(160, 48);
            this.update_button.TabIndex = 4;
            this.update_button.Text = "Update";
            this.update_button.UseVisualStyleBackColor = false;
            this.update_button.Click += new System.EventHandler(this.update_button_Click);
            // 
            // UpdateInventoryForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(361, 467);
            this.Controls.Add(this.update_button);
            this.Controls.Add(this.Header);
            this.Controls.Add(this.selling_price_textbox);
            this.Controls.Add(this.product_quantity_textbox);
            this.Controls.Add(this.purchasing_cost_textbox);
            this.Controls.Add(this.product_name_textbox);
            this.Controls.Add(this.selling_price_label);
            this.Controls.Add(this.purchasing_cost_label);
            this.Controls.Add(this.product_quantity_label);
            this.Controls.Add(this.product_name_label);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "UpdateInventoryForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "UpdateInventoryForm";
            this.Header.ResumeLayout(false);
            this.Header.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox selling_price_textbox;
        private System.Windows.Forms.TextBox product_quantity_textbox;
        private System.Windows.Forms.TextBox purchasing_cost_textbox;
        private System.Windows.Forms.TextBox product_name_textbox;
        private System.Windows.Forms.Label selling_price_label;
        private System.Windows.Forms.Label purchasing_cost_label;
        private System.Windows.Forms.Label product_quantity_label;
        private System.Windows.Forms.Label product_name_label;
        private System.Windows.Forms.Panel Header;
        private System.Windows.Forms.Label Update_Prodct_label;
        private System.Windows.Forms.Label Panel_label;
        private System.Windows.Forms.Button update_button;
    }
}