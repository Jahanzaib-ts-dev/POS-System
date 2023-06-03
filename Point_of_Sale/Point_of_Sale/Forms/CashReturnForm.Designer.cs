namespace Point_of_Sale.Forms
{
    partial class CashReturnForm
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
            this.cash_received_textbox = new System.Windows.Forms.TextBox();
            this.cash_received_label = new System.Windows.Forms.Label();
            this.cash_return_label = new System.Windows.Forms.Label();
            this.total_bill_label = new System.Windows.Forms.Label();
            this.total_bill_count = new System.Windows.Forms.Label();
            this.cash_return_count = new System.Windows.Forms.Label();
            this.hint_label = new System.Windows.Forms.Label();
            this.Payment_Label = new System.Windows.Forms.Label();
            this.end_button = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // cash_received_textbox
            // 
            this.cash_received_textbox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.cash_received_textbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.cash_received_textbox.Location = new System.Drawing.Point(347, 144);
            this.cash_received_textbox.MaxLength = 10;
            this.cash_received_textbox.Name = "cash_received_textbox";
            this.cash_received_textbox.Size = new System.Drawing.Size(139, 32);
            this.cash_received_textbox.TabIndex = 0;
            this.cash_received_textbox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.cash_received_textbox.TextChanged += new System.EventHandler(this.cash_received_textbox_TextChanged);
            this.cash_received_textbox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.cash_received_textbox_KeyPress);
            // 
            // cash_received_label
            // 
            this.cash_received_label.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.cash_received_label.AutoSize = true;
            this.cash_received_label.Font = new System.Drawing.Font("Yu Gothic", 18.25F, System.Drawing.FontStyle.Bold);
            this.cash_received_label.Location = new System.Drawing.Point(132, 143);
            this.cash_received_label.Name = "cash_received_label";
            this.cash_received_label.Size = new System.Drawing.Size(209, 32);
            this.cash_received_label.TabIndex = 11;
            this.cash_received_label.Text = "Cash Received :";
            // 
            // cash_return_label
            // 
            this.cash_return_label.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.cash_return_label.AutoSize = true;
            this.cash_return_label.Font = new System.Drawing.Font("Yu Gothic", 18.25F, System.Drawing.FontStyle.Bold);
            this.cash_return_label.Location = new System.Drawing.Point(161, 274);
            this.cash_return_label.Name = "cash_return_label";
            this.cash_return_label.Size = new System.Drawing.Size(180, 32);
            this.cash_return_label.TabIndex = 11;
            this.cash_return_label.Text = "Cash Return :";
            // 
            // total_bill_label
            // 
            this.total_bill_label.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.total_bill_label.AutoSize = true;
            this.total_bill_label.Font = new System.Drawing.Font("Yu Gothic", 18.25F, System.Drawing.FontStyle.Bold);
            this.total_bill_label.Location = new System.Drawing.Point(205, 205);
            this.total_bill_label.Name = "total_bill_label";
            this.total_bill_label.Size = new System.Drawing.Size(136, 32);
            this.total_bill_label.TabIndex = 11;
            this.total_bill_label.Text = "Total Bill :";
            // 
            // total_bill_count
            // 
            this.total_bill_count.BackColor = System.Drawing.Color.White;
            this.total_bill_count.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.total_bill_count.Location = new System.Drawing.Point(347, 205);
            this.total_bill_count.Name = "total_bill_count";
            this.total_bill_count.Size = new System.Drawing.Size(139, 32);
            this.total_bill_count.TabIndex = 13;
            this.total_bill_count.Text = "0";
            this.total_bill_count.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // cash_return_count
            // 
            this.cash_return_count.BackColor = System.Drawing.Color.White;
            this.cash_return_count.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cash_return_count.Location = new System.Drawing.Point(347, 274);
            this.cash_return_count.Name = "cash_return_count";
            this.cash_return_count.Size = new System.Drawing.Size(139, 32);
            this.cash_return_count.TabIndex = 13;
            this.cash_return_count.Text = "0";
            this.cash_return_count.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // hint_label
            // 
            this.hint_label.AutoSize = true;
            this.hint_label.Font = new System.Drawing.Font("Yu Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.hint_label.Location = new System.Drawing.Point(492, 154);
            this.hint_label.Name = "hint_label";
            this.hint_label.Size = new System.Drawing.Size(49, 17);
            this.hint_label.TabIndex = 14;
            this.hint_label.Text = "*Enter";
            // 
            // Payment_Label
            // 
            this.Payment_Label.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Payment_Label.AutoSize = true;
            this.Payment_Label.Font = new System.Drawing.Font("Impact", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Payment_Label.Location = new System.Drawing.Point(262, 55);
            this.Payment_Label.Name = "Payment_Label";
            this.Payment_Label.Size = new System.Drawing.Size(152, 45);
            this.Payment_Label.TabIndex = 15;
            this.Payment_Label.Text = "Payment";
            // 
            // end_button
            // 
            this.end_button.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.end_button.BackColor = System.Drawing.Color.Ivory;
            this.end_button.FlatAppearance.BorderColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.end_button.FlatAppearance.BorderSize = 2;
            this.end_button.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.end_button.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightSkyBlue;
            this.end_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.end_button.Font = new System.Drawing.Font("Impact", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.end_button.Location = new System.Drawing.Point(289, 348);
            this.end_button.Margin = new System.Windows.Forms.Padding(2);
            this.end_button.Name = "end_button";
            this.end_button.Size = new System.Drawing.Size(108, 51);
            this.end_button.TabIndex = 1;
            this.end_button.Text = "END";
            this.end_button.UseVisualStyleBackColor = false;
            this.end_button.Click += new System.EventHandler(this.end_button_Click);
            // 
            // CashReturnForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSkyBlue;
            this.ClientSize = new System.Drawing.Size(657, 438);
            this.ControlBox = false;
            this.Controls.Add(this.end_button);
            this.Controls.Add(this.Payment_Label);
            this.Controls.Add(this.hint_label);
            this.Controls.Add(this.cash_received_label);
            this.Controls.Add(this.cash_received_textbox);
            this.Controls.Add(this.total_bill_label);
            this.Controls.Add(this.total_bill_count);
            this.Controls.Add(this.cash_return_label);
            this.Controls.Add(this.cash_return_count);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "CashReturnForm";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CashReturnForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox cash_received_textbox;
        private System.Windows.Forms.Label cash_received_label;
        private System.Windows.Forms.Label cash_return_label;
        private System.Windows.Forms.Label total_bill_label;
        private System.Windows.Forms.Label total_bill_count;
        private System.Windows.Forms.Label cash_return_count;
        private System.Windows.Forms.Label hint_label;
        private System.Windows.Forms.Label Payment_Label;
        private System.Windows.Forms.Button end_button;
    }
}