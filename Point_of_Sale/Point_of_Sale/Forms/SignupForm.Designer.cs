namespace Point_of_Sale.Forms
{
    partial class SignupForm
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
            this.signup_button = new System.Windows.Forms.Button();
            this.Header = new System.Windows.Forms.Panel();
            this.signup_label = new System.Windows.Forms.Label();
            this.password_textbox = new System.Windows.Forms.TextBox();
            this.retype_password_textbox = new System.Windows.Forms.TextBox();
            this.username_textbox = new System.Windows.Forms.TextBox();
            this.retype_password_label = new System.Windows.Forms.Label();
            this.password_label = new System.Windows.Forms.Label();
            this.username_label = new System.Windows.Forms.Label();
            this.DateTimePick = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.role_combobox = new System.Windows.Forms.ComboBox();
            this.Header.SuspendLayout();
            this.SuspendLayout();
            // 
            // signup_button
            // 
            this.signup_button.BackColor = System.Drawing.Color.LightSkyBlue;
            this.signup_button.FlatAppearance.MouseDownBackColor = System.Drawing.Color.LightSkyBlue;
            this.signup_button.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.signup_button.Font = new System.Drawing.Font("Impact", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.signup_button.Location = new System.Drawing.Point(101, 343);
            this.signup_button.Name = "signup_button";
            this.signup_button.Size = new System.Drawing.Size(160, 48);
            this.signup_button.TabIndex = 5;
            this.signup_button.Text = "SIGNUP";
            this.signup_button.UseVisualStyleBackColor = false;
            this.signup_button.Click += new System.EventHandler(this.signup_button_Click);
            // 
            // Header
            // 
            this.Header.BackColor = System.Drawing.Color.LightSkyBlue;
            this.Header.Controls.Add(this.signup_label);
            this.Header.Dock = System.Windows.Forms.DockStyle.Top;
            this.Header.Location = new System.Drawing.Point(0, 0);
            this.Header.Margin = new System.Windows.Forms.Padding(2);
            this.Header.Name = "Header";
            this.Header.Size = new System.Drawing.Size(361, 73);
            this.Header.TabIndex = 27;
            // 
            // signup_label
            // 
            this.signup_label.AutoSize = true;
            this.signup_label.Font = new System.Drawing.Font("Impact", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.signup_label.Location = new System.Drawing.Point(73, 18);
            this.signup_label.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.signup_label.Name = "signup_label";
            this.signup_label.Size = new System.Drawing.Size(209, 43);
            this.signup_label.TabIndex = 0;
            this.signup_label.Text = "SIGNUP PANEL";
            // 
            // password_textbox
            // 
            this.password_textbox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.password_textbox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.password_textbox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.password_textbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.password_textbox.Location = new System.Drawing.Point(169, 173);
            this.password_textbox.Name = "password_textbox";
            this.password_textbox.PasswordChar = '*';
            this.password_textbox.Size = new System.Drawing.Size(141, 22);
            this.password_textbox.TabIndex = 1;
            // 
            // retype_password_textbox
            // 
            this.retype_password_textbox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.retype_password_textbox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.retype_password_textbox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.retype_password_textbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.retype_password_textbox.Location = new System.Drawing.Point(169, 212);
            this.retype_password_textbox.Name = "retype_password_textbox";
            this.retype_password_textbox.PasswordChar = '*';
            this.retype_password_textbox.Size = new System.Drawing.Size(141, 22);
            this.retype_password_textbox.TabIndex = 2;
            // 
            // username_textbox
            // 
            this.username_textbox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.username_textbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.username_textbox.Location = new System.Drawing.Point(169, 132);
            this.username_textbox.MaxLength = 15;
            this.username_textbox.Name = "username_textbox";
            this.username_textbox.Size = new System.Drawing.Size(141, 22);
            this.username_textbox.TabIndex = 0;
            // 
            // retype_password_label
            // 
            this.retype_password_label.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.retype_password_label.AutoSize = true;
            this.retype_password_label.Font = new System.Drawing.Font("Yu Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.retype_password_label.Location = new System.Drawing.Point(12, 213);
            this.retype_password_label.Name = "retype_password_label";
            this.retype_password_label.Size = new System.Drawing.Size(152, 19);
            this.retype_password_label.TabIndex = 20;
            this.retype_password_label.Text = "Re-Type Password :";
            // 
            // password_label
            // 
            this.password_label.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.password_label.AutoSize = true;
            this.password_label.Font = new System.Drawing.Font("Yu Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.password_label.Location = new System.Drawing.Point(67, 173);
            this.password_label.Name = "password_label";
            this.password_label.Size = new System.Drawing.Size(96, 21);
            this.password_label.TabIndex = 21;
            this.password_label.Text = "Password :";
            // 
            // username_label
            // 
            this.username_label.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.username_label.AutoSize = true;
            this.username_label.Font = new System.Drawing.Font("Yu Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.username_label.Location = new System.Drawing.Point(64, 133);
            this.username_label.Name = "username_label";
            this.username_label.Size = new System.Drawing.Size(99, 21);
            this.username_label.TabIndex = 22;
            this.username_label.Text = "Username :";
            // 
            // DateTimePick
            // 
            this.DateTimePick.Enabled = false;
            this.DateTimePick.Location = new System.Drawing.Point(92, 299);
            this.DateTimePick.Name = "DateTimePick";
            this.DateTimePick.Size = new System.Drawing.Size(200, 20);
            this.DateTimePick.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Yu Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(109, 248);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 21);
            this.label1.TabIndex = 21;
            this.label1.Text = "Role :";
            // 
            // role_combobox
            // 
            this.role_combobox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.role_combobox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.role_combobox.FormattingEnabled = true;
            this.role_combobox.Location = new System.Drawing.Point(169, 250);
            this.role_combobox.Name = "role_combobox";
            this.role_combobox.Size = new System.Drawing.Size(141, 21);
            this.role_combobox.TabIndex = 3;
            // 
            // SignupForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(361, 435);
            this.Controls.Add(this.Header);
            this.Controls.Add(this.role_combobox);
            this.Controls.Add(this.DateTimePick);
            this.Controls.Add(this.signup_button);
            this.Controls.Add(this.password_textbox);
            this.Controls.Add(this.retype_password_textbox);
            this.Controls.Add(this.username_textbox);
            this.Controls.Add(this.retype_password_label);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.password_label);
            this.Controls.Add(this.username_label);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "SignupForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SignupForm";
            this.Header.ResumeLayout(false);
            this.Header.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button signup_button;
        private System.Windows.Forms.Panel Header;
        private System.Windows.Forms.Label signup_label;
        private System.Windows.Forms.TextBox password_textbox;
        private System.Windows.Forms.TextBox retype_password_textbox;
        private System.Windows.Forms.TextBox username_textbox;
        private System.Windows.Forms.Label retype_password_label;
        private System.Windows.Forms.Label password_label;
        private System.Windows.Forms.Label username_label;
        private System.Windows.Forms.DateTimePicker DateTimePick;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox role_combobox;
    }
}