namespace Point_of_Sale
{
    partial class NewPurchases
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
            this.Header_panel = new System.Windows.Forms.Panel();
            this.New_Purchases_label = new System.Windows.Forms.Label();
            this.Select_Product_label = new System.Windows.Forms.Label();
            this.NewPurchases_combobox = new System.Windows.Forms.ComboBox();
            this.product_quantity_label = new System.Windows.Forms.Label();
            this.product_quantity_textbox = new System.Windows.Forms.TextBox();
            this.addproduct_datetime = new System.Windows.Forms.DateTimePicker();
            this.sellingprice_textbox = new System.Windows.Forms.TextBox();
            this.purchasingcost_textbox = new System.Windows.Forms.TextBox();
            this.addproduct_date_label = new System.Windows.Forms.Label();
            this.sellingprice_label = new System.Windows.Forms.Label();
            this.purcahsingcost_label = new System.Windows.Forms.Label();
            this.add_button = new System.Windows.Forms.Button();
            this.PerProduct1 = new System.Windows.Forms.Label();
            this.PerProduct2 = new System.Windows.Forms.Label();
            this.Header_panel.SuspendLayout();
            this.SuspendLayout();
            // 
            // Header_panel
            // 
            this.Header_panel.BackColor = System.Drawing.Color.LightSkyBlue;
            this.Header_panel.Controls.Add(this.New_Purchases_label);
            this.Header_panel.Dock = System.Windows.Forms.DockStyle.Top;
            this.Header_panel.Location = new System.Drawing.Point(0, 0);
            this.Header_panel.Name = "Header_panel";
            this.Header_panel.Size = new System.Drawing.Size(556, 100);
            this.Header_panel.TabIndex = 0;
            // 
            // New_Purchases_label
            // 
            this.New_Purchases_label.AutoSize = true;
            this.New_Purchases_label.Font = new System.Drawing.Font("Impact", 21.75F);
            this.New_Purchases_label.Location = new System.Drawing.Point(179, 30);
            this.New_Purchases_label.Name = "New_Purchases_label";
            this.New_Purchases_label.Size = new System.Drawing.Size(198, 36);
            this.New_Purchases_label.TabIndex = 11;
            this.New_Purchases_label.Text = "New Purchases";
            // 
            // Select_Product_label
            // 
            this.Select_Product_label.AutoSize = true;
            this.Select_Product_label.Font = new System.Drawing.Font("Yu Gothic", 12F, System.Drawing.FontStyle.Bold);
            this.Select_Product_label.Location = new System.Drawing.Point(126, 173);
            this.Select_Product_label.Name = "Select_Product_label";
            this.Select_Product_label.Size = new System.Drawing.Size(135, 21);
            this.Select_Product_label.TabIndex = 1;
            this.Select_Product_label.Text = "Select Product :";
            // 
            // NewPurchases_combobox
            // 
            this.NewPurchases_combobox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.NewPurchases_combobox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.NewPurchases_combobox.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NewPurchases_combobox.FormattingEnabled = true;
            this.NewPurchases_combobox.Location = new System.Drawing.Point(275, 175);
            this.NewPurchases_combobox.Name = "NewPurchases_combobox";
            this.NewPurchases_combobox.Size = new System.Drawing.Size(121, 26);
            this.NewPurchases_combobox.TabIndex = 0;
            // 
            // product_quantity_label
            // 
            this.product_quantity_label.AutoSize = true;
            this.product_quantity_label.Font = new System.Drawing.Font("Yu Gothic", 12F, System.Drawing.FontStyle.Bold);
            this.product_quantity_label.Location = new System.Drawing.Point(108, 221);
            this.product_quantity_label.Name = "product_quantity_label";
            this.product_quantity_label.Size = new System.Drawing.Size(153, 21);
            this.product_quantity_label.TabIndex = 3;
            this.product_quantity_label.Text = "Product Quantity :";
            // 
            // product_quantity_textbox
            // 
            this.product_quantity_textbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.product_quantity_textbox.Location = new System.Drawing.Point(275, 221);
            this.product_quantity_textbox.Name = "product_quantity_textbox";
            this.product_quantity_textbox.Size = new System.Drawing.Size(121, 24);
            this.product_quantity_textbox.TabIndex = 1;
            this.product_quantity_textbox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.product_quantity_textbox_KeyPress);
            // 
            // addproduct_datetime
            // 
            this.addproduct_datetime.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.addproduct_datetime.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addproduct_datetime.Location = new System.Drawing.Point(275, 357);
            this.addproduct_datetime.Margin = new System.Windows.Forms.Padding(2);
            this.addproduct_datetime.Name = "addproduct_datetime";
            this.addproduct_datetime.Size = new System.Drawing.Size(196, 19);
            this.addproduct_datetime.TabIndex = 4;
            // 
            // sellingprice_textbox
            // 
            this.sellingprice_textbox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.sellingprice_textbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sellingprice_textbox.Location = new System.Drawing.Point(275, 307);
            this.sellingprice_textbox.Margin = new System.Windows.Forms.Padding(2);
            this.sellingprice_textbox.Name = "sellingprice_textbox";
            this.sellingprice_textbox.Size = new System.Drawing.Size(121, 24);
            this.sellingprice_textbox.TabIndex = 3;
            this.sellingprice_textbox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.sellingprice_textbox_KeyPress);
            // 
            // purchasingcost_textbox
            // 
            this.purchasingcost_textbox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.purchasingcost_textbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.purchasingcost_textbox.Location = new System.Drawing.Point(275, 265);
            this.purchasingcost_textbox.Margin = new System.Windows.Forms.Padding(2);
            this.purchasingcost_textbox.Name = "purchasingcost_textbox";
            this.purchasingcost_textbox.Size = new System.Drawing.Size(121, 24);
            this.purchasingcost_textbox.TabIndex = 2;
            this.purchasingcost_textbox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.purchasingcost_textbox_KeyPress);
            // 
            // addproduct_date_label
            // 
            this.addproduct_date_label.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.addproduct_date_label.AutoSize = true;
            this.addproduct_date_label.Font = new System.Drawing.Font("Yu Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addproduct_date_label.Location = new System.Drawing.Point(200, 357);
            this.addproduct_date_label.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.addproduct_date_label.Name = "addproduct_date_label";
            this.addproduct_date_label.Size = new System.Drawing.Size(61, 21);
            this.addproduct_date_label.TabIndex = 5;
            this.addproduct_date_label.Text = " Date :";
            // 
            // sellingprice_label
            // 
            this.sellingprice_label.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.sellingprice_label.AutoSize = true;
            this.sellingprice_label.Font = new System.Drawing.Font("Yu Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sellingprice_label.Location = new System.Drawing.Point(142, 307);
            this.sellingprice_label.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.sellingprice_label.Name = "sellingprice_label";
            this.sellingprice_label.Size = new System.Drawing.Size(119, 21);
            this.sellingprice_label.TabIndex = 6;
            this.sellingprice_label.Text = "Selling Price :";
            // 
            // purcahsingcost_label
            // 
            this.purcahsingcost_label.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.purcahsingcost_label.AutoSize = true;
            this.purcahsingcost_label.Font = new System.Drawing.Font("Yu Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.purcahsingcost_label.Location = new System.Drawing.Point(113, 266);
            this.purcahsingcost_label.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.purcahsingcost_label.Name = "purcahsingcost_label";
            this.purcahsingcost_label.Size = new System.Drawing.Size(148, 21);
            this.purcahsingcost_label.TabIndex = 7;
            this.purcahsingcost_label.Text = "Purchasing Cost :";
            // 
            // add_button
            // 
            this.add_button.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.add_button.FlatAppearance.BorderColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.add_button.FlatAppearance.BorderSize = 2;
            this.add_button.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.add_button.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightSkyBlue;
            this.add_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.add_button.Font = new System.Drawing.Font("Impact", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.add_button.Location = new System.Drawing.Point(224, 432);
            this.add_button.Margin = new System.Windows.Forms.Padding(2);
            this.add_button.Name = "add_button";
            this.add_button.Size = new System.Drawing.Size(102, 47);
            this.add_button.TabIndex = 5;
            this.add_button.Text = "ADD";
            this.add_button.UseVisualStyleBackColor = true;
            this.add_button.Click += new System.EventHandler(this.add_button_Click);
            // 
            // PerProduct1
            // 
            this.PerProduct1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.PerProduct1.AutoSize = true;
            this.PerProduct1.BackColor = System.Drawing.Color.Transparent;
            this.PerProduct1.Font = new System.Drawing.Font("Yu Gothic", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PerProduct1.Location = new System.Drawing.Point(401, 271);
            this.PerProduct1.Name = "PerProduct1";
            this.PerProduct1.Size = new System.Drawing.Size(71, 14);
            this.PerProduct1.TabIndex = 12;
            this.PerProduct1.Text = "Per Product";
            // 
            // PerProduct2
            // 
            this.PerProduct2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.PerProduct2.AutoSize = true;
            this.PerProduct2.BackColor = System.Drawing.Color.Transparent;
            this.PerProduct2.Font = new System.Drawing.Font("Yu Gothic", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PerProduct2.Location = new System.Drawing.Point(401, 313);
            this.PerProduct2.Name = "PerProduct2";
            this.PerProduct2.Size = new System.Drawing.Size(71, 14);
            this.PerProduct2.TabIndex = 13;
            this.PerProduct2.Text = "Per Product";
            // 
            // NewPurchases
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(556, 619);
            this.Controls.Add(this.PerProduct2);
            this.Controls.Add(this.PerProduct1);
            this.Controls.Add(this.add_button);
            this.Controls.Add(this.addproduct_datetime);
            this.Controls.Add(this.sellingprice_textbox);
            this.Controls.Add(this.purchasingcost_textbox);
            this.Controls.Add(this.addproduct_date_label);
            this.Controls.Add(this.sellingprice_label);
            this.Controls.Add(this.purcahsingcost_label);
            this.Controls.Add(this.product_quantity_textbox);
            this.Controls.Add(this.product_quantity_label);
            this.Controls.Add(this.NewPurchases_combobox);
            this.Controls.Add(this.Select_Product_label);
            this.Controls.Add(this.Header_panel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "NewPurchases";
            this.Text = "NewPurchases";
            this.Header_panel.ResumeLayout(false);
            this.Header_panel.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel Header_panel;
        private System.Windows.Forms.Label Select_Product_label;
        private System.Windows.Forms.ComboBox NewPurchases_combobox;
        private System.Windows.Forms.Label product_quantity_label;
        private System.Windows.Forms.TextBox product_quantity_textbox;
        private System.Windows.Forms.Label New_Purchases_label;
        private System.Windows.Forms.DateTimePicker addproduct_datetime;
        private System.Windows.Forms.TextBox sellingprice_textbox;
        private System.Windows.Forms.TextBox purchasingcost_textbox;
        private System.Windows.Forms.Label addproduct_date_label;
        private System.Windows.Forms.Label sellingprice_label;
        private System.Windows.Forms.Label purcahsingcost_label;
        private System.Windows.Forms.Button add_button;
        private System.Windows.Forms.Label PerProduct1;
        private System.Windows.Forms.Label PerProduct2;
    }
}