namespace Point_of_Sale.Forms
{
    partial class LoginForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoginForm));
            this.Main = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.login_button = new System.Windows.Forms.Button();
            this.signup_button = new System.Windows.Forms.Button();
            this.password_textbox = new System.Windows.Forms.TextBox();
            this.username_textbox = new System.Windows.Forms.TextBox();
            this.password_label = new System.Windows.Forms.Label();
            this.username_label = new System.Windows.Forms.Label();
            this.LOGIN_LABEL = new System.Windows.Forms.Label();
            this.PointofSale_Label = new System.Windows.Forms.Label();
            this.Main.SuspendLayout();
            this.SuspendLayout();
            // 
            // Main
            // 
            this.Main.BackColor = System.Drawing.Color.LightSkyBlue;
            this.Main.Controls.Add(this.label2);
            this.Main.Controls.Add(this.label1);
            this.Main.Controls.Add(this.login_button);
            this.Main.Controls.Add(this.signup_button);
            this.Main.Controls.Add(this.password_textbox);
            this.Main.Controls.Add(this.username_textbox);
            this.Main.Controls.Add(this.password_label);
            this.Main.Controls.Add(this.username_label);
            this.Main.Controls.Add(this.LOGIN_LABEL);
            this.Main.Controls.Add(this.PointofSale_Label);
            this.Main.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Main.Location = new System.Drawing.Point(0, 0);
            this.Main.Name = "Main";
            this.Main.Size = new System.Drawing.Size(602, 309);
            this.Main.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Yu Gothic UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(423, 285);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(176, 15);
            this.label2.TabIndex = 6;
            this.label2.Text = "Developed by Jahanzaib Tanveer";
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Impact", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(200, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(210, 45);
            this.label1.TabIndex = 5;
            this.label1.Text = "STOCK POINT";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // login_button
            // 
            this.login_button.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.login_button.BackColor = System.Drawing.Color.Ivory;
            this.login_button.FlatAppearance.BorderColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.login_button.FlatAppearance.BorderSize = 2;
            this.login_button.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.login_button.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightSkyBlue;
            this.login_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.login_button.Font = new System.Drawing.Font("Impact", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.login_button.Location = new System.Drawing.Point(269, 234);
            this.login_button.Margin = new System.Windows.Forms.Padding(2);
            this.login_button.Name = "login_button";
            this.login_button.Size = new System.Drawing.Size(81, 41);
            this.login_button.TabIndex = 2;
            this.login_button.Text = "LOGIN";
            this.login_button.UseVisualStyleBackColor = false;
            this.login_button.Click += new System.EventHandler(this.login_button_Click);
            // 
            // signup_button
            // 
            this.signup_button.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.signup_button.BackColor = System.Drawing.Color.Ivory;
            this.signup_button.FlatAppearance.BorderColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.signup_button.FlatAppearance.BorderSize = 2;
            this.signup_button.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.signup_button.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightSkyBlue;
            this.signup_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.signup_button.Font = new System.Drawing.Font("Impact", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.signup_button.Location = new System.Drawing.Point(493, 11);
            this.signup_button.Margin = new System.Windows.Forms.Padding(2);
            this.signup_button.Name = "signup_button";
            this.signup_button.Size = new System.Drawing.Size(98, 44);
            this.signup_button.TabIndex = 3;
            this.signup_button.Text = "SIGNUP";
            this.signup_button.UseVisualStyleBackColor = false;
            this.signup_button.Click += new System.EventHandler(this.signup_button_Click);
            // 
            // password_textbox
            // 
            this.password_textbox.Location = new System.Drawing.Point(306, 196);
            this.password_textbox.Name = "password_textbox";
            this.password_textbox.PasswordChar = '*';
            this.password_textbox.Size = new System.Drawing.Size(100, 20);
            this.password_textbox.TabIndex = 1;
            this.password_textbox.TextChanged += new System.EventHandler(this.password_textbox_TextChanged);
            // 
            // username_textbox
            // 
            this.username_textbox.Location = new System.Drawing.Point(306, 163);
            this.username_textbox.Name = "username_textbox";
            this.username_textbox.Size = new System.Drawing.Size(100, 20);
            this.username_textbox.TabIndex = 0;
            this.username_textbox.TextChanged += new System.EventHandler(this.username_textbox_TextChanged);
            // 
            // password_label
            // 
            this.password_label.AutoSize = true;
            this.password_label.Font = new System.Drawing.Font("Yu Gothic", 12F, System.Drawing.FontStyle.Bold);
            this.password_label.Location = new System.Drawing.Point(204, 194);
            this.password_label.Name = "password_label";
            this.password_label.Size = new System.Drawing.Size(96, 21);
            this.password_label.TabIndex = 4;
            this.password_label.Text = "Password :";
            this.password_label.Click += new System.EventHandler(this.password_label_Click);
            // 
            // username_label
            // 
            this.username_label.AutoSize = true;
            this.username_label.Font = new System.Drawing.Font("Yu Gothic", 12F, System.Drawing.FontStyle.Bold);
            this.username_label.Location = new System.Drawing.Point(201, 161);
            this.username_label.Name = "username_label";
            this.username_label.Size = new System.Drawing.Size(99, 21);
            this.username_label.TabIndex = 4;
            this.username_label.Text = "Username :";
            this.username_label.Click += new System.EventHandler(this.username_label_Click);
            // 
            // LOGIN_LABEL
            // 
            this.LOGIN_LABEL.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.LOGIN_LABEL.AutoSize = true;
            this.LOGIN_LABEL.Font = new System.Drawing.Font("Impact", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LOGIN_LABEL.Location = new System.Drawing.Point(277, 116);
            this.LOGIN_LABEL.Name = "LOGIN_LABEL";
            this.LOGIN_LABEL.Size = new System.Drawing.Size(60, 26);
            this.LOGIN_LABEL.TabIndex = 3;
            this.LOGIN_LABEL.Text = "LOGIN";
            this.LOGIN_LABEL.Click += new System.EventHandler(this.LOGIN_LABEL_Click);
            // 
            // PointofSale_Label
            // 
            this.PointofSale_Label.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.PointofSale_Label.AutoSize = true;
            this.PointofSale_Label.Font = new System.Drawing.Font("Impact", 15.75F);
            this.PointofSale_Label.Location = new System.Drawing.Point(246, 81);
            this.PointofSale_Label.Name = "PointofSale_Label";
            this.PointofSale_Label.Size = new System.Drawing.Size(123, 26);
            this.PointofSale_Label.TabIndex = 3;
            this.PointofSale_Label.Text = "Point of Sale ";
            this.PointofSale_Label.Click += new System.EventHandler(this.PointofSale_Label_Click);
            // 
            // LoginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(602, 309);
            this.Controls.Add(this.Main);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "LoginForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Accounts";
            this.Main.ResumeLayout(false);
            this.Main.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel Main;
        private System.Windows.Forms.Label PointofSale_Label;
        private System.Windows.Forms.Label username_label;
        private System.Windows.Forms.Label LOGIN_LABEL;
        private System.Windows.Forms.TextBox password_textbox;
        private System.Windows.Forms.TextBox username_textbox;
        private System.Windows.Forms.Label password_label;
        private System.Windows.Forms.Button signup_button;
        private System.Windows.Forms.Button login_button;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}