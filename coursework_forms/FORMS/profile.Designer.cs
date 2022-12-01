namespace coursework_forms {
    partial class profile {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if(disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.p_top_menu = new System.Windows.Forms.Panel();
            this.b_exit = new System.Windows.Forms.Button();
            this.tb_pass = new System.Windows.Forms.TextBox();
            this.tb_id = new System.Windows.Forms.TextBox();
            this.l_pass = new System.Windows.Forms.Label();
            this.l_id = new System.Windows.Forms.Label();
            this.tb_fio = new System.Windows.Forms.TextBox();
            this.l_fio = new System.Windows.Forms.Label();
            this.p_profile_pic = new System.Windows.Forms.Panel();
            this.tb_mail = new System.Windows.Forms.TextBox();
            this.l_mail = new System.Windows.Forms.Label();
            this.tb_phone = new System.Windows.Forms.TextBox();
            this.l_phone = new System.Windows.Forms.Label();
            this.tb_error = new System.Windows.Forms.TextBox();
            this.b_logout = new System.Windows.Forms.Button();
            this.b_update = new System.Windows.Forms.Button();
            this.b_show_password = new System.Windows.Forms.Button();
            this.p_top_menu.SuspendLayout();
            this.SuspendLayout();
            // 
            // p_top_menu
            // 
            this.p_top_menu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(6)))), ((int)(((byte)(42)))));
            this.p_top_menu.Controls.Add(this.b_exit);
            this.p_top_menu.Dock = System.Windows.Forms.DockStyle.Top;
            this.p_top_menu.Location = new System.Drawing.Point(0, 0);
            this.p_top_menu.Name = "p_top_menu";
            this.p_top_menu.Size = new System.Drawing.Size(1150, 25);
            this.p_top_menu.TabIndex = 8;
            // 
            // b_exit
            // 
            this.b_exit.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.b_exit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(6)))), ((int)(((byte)(42)))));
            this.b_exit.BackgroundImage = global::coursework_forms.Properties.Resources.close;
            this.b_exit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.b_exit.Dock = System.Windows.Forms.DockStyle.Left;
            this.b_exit.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(83)))), ((int)(((byte)(16)))), ((int)(((byte)(105)))));
            this.b_exit.FlatAppearance.BorderSize = 0;
            this.b_exit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.b_exit.Font = new System.Drawing.Font("JetBrains Mono Medium", 12F, System.Drawing.FontStyle.Bold);
            this.b_exit.ForeColor = System.Drawing.Color.White;
            this.b_exit.ImageKey = "(none)";
            this.b_exit.Location = new System.Drawing.Point(0, 0);
            this.b_exit.Margin = new System.Windows.Forms.Padding(0);
            this.b_exit.Name = "b_exit";
            this.b_exit.Size = new System.Drawing.Size(55, 25);
            this.b_exit.TabIndex = 6;
            this.b_exit.UseVisualStyleBackColor = false;
            this.b_exit.Click += new System.EventHandler(this.b_exit_Click);
            this.b_exit.MouseEnter += new System.EventHandler(this.b_exit_MouseEnter);
            this.b_exit.MouseLeave += new System.EventHandler(this.b_exit_MouseLeave);
            // 
            // tb_pass
            // 
            this.tb_pass.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(6)))), ((int)(((byte)(42)))));
            this.tb_pass.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tb_pass.Font = new System.Drawing.Font("JetBrains Mono NL Medium", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_pass.ForeColor = System.Drawing.Color.Crimson;
            this.tb_pass.Location = new System.Drawing.Point(574, 259);
            this.tb_pass.Margin = new System.Windows.Forms.Padding(0);
            this.tb_pass.Name = "tb_pass";
            this.tb_pass.PasswordChar = '#';
            this.tb_pass.Size = new System.Drawing.Size(362, 39);
            this.tb_pass.TabIndex = 11;
            // 
            // tb_id
            // 
            this.tb_id.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(6)))), ((int)(((byte)(42)))));
            this.tb_id.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tb_id.Font = new System.Drawing.Font("JetBrains Mono NL Medium", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_id.ForeColor = System.Drawing.Color.Crimson;
            this.tb_id.Location = new System.Drawing.Point(574, 176);
            this.tb_id.Margin = new System.Windows.Forms.Padding(0);
            this.tb_id.Name = "tb_id";
            this.tb_id.ReadOnly = true;
            this.tb_id.Size = new System.Drawing.Size(362, 39);
            this.tb_id.TabIndex = 12;
            // 
            // l_pass
            // 
            this.l_pass.AutoSize = true;
            this.l_pass.Font = new System.Drawing.Font("JetBrains Mono NL Medium", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.l_pass.ForeColor = System.Drawing.Color.Crimson;
            this.l_pass.Location = new System.Drawing.Point(568, 225);
            this.l_pass.Margin = new System.Windows.Forms.Padding(25, 10, 3, 0);
            this.l_pass.Name = "l_pass";
            this.l_pass.Size = new System.Drawing.Size(125, 39);
            this.l_pass.TabIndex = 9;
            this.l_pass.Text = "Пароль";
            // 
            // l_id
            // 
            this.l_id.AutoSize = true;
            this.l_id.Font = new System.Drawing.Font("JetBrains Mono NL Medium", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.l_id.ForeColor = System.Drawing.Color.Crimson;
            this.l_id.Location = new System.Drawing.Point(568, 140);
            this.l_id.Margin = new System.Windows.Forms.Padding(25, 10, 3, 0);
            this.l_id.Name = "l_id";
            this.l_id.Size = new System.Drawing.Size(53, 39);
            this.l_id.TabIndex = 10;
            this.l_id.Text = "ID";
            // 
            // tb_fio
            // 
            this.tb_fio.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(6)))), ((int)(((byte)(42)))));
            this.tb_fio.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tb_fio.Font = new System.Drawing.Font("JetBrains Mono NL Medium", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_fio.ForeColor = System.Drawing.Color.Crimson;
            this.tb_fio.Location = new System.Drawing.Point(574, 344);
            this.tb_fio.Margin = new System.Windows.Forms.Padding(0);
            this.tb_fio.Name = "tb_fio";
            this.tb_fio.Size = new System.Drawing.Size(520, 39);
            this.tb_fio.TabIndex = 14;
            // 
            // l_fio
            // 
            this.l_fio.AutoSize = true;
            this.l_fio.Font = new System.Drawing.Font("JetBrains Mono NL Medium", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.l_fio.ForeColor = System.Drawing.Color.Crimson;
            this.l_fio.Location = new System.Drawing.Point(568, 308);
            this.l_fio.Margin = new System.Windows.Forms.Padding(25, 10, 0, 0);
            this.l_fio.Name = "l_fio";
            this.l_fio.Size = new System.Drawing.Size(71, 39);
            this.l_fio.TabIndex = 13;
            this.l_fio.Text = "ФИО";
            // 
            // p_profile_pic
            // 
            this.p_profile_pic.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.p_profile_pic.Dock = System.Windows.Forms.DockStyle.Left;
            this.p_profile_pic.Location = new System.Drawing.Point(0, 25);
            this.p_profile_pic.Name = "p_profile_pic";
            this.p_profile_pic.Size = new System.Drawing.Size(502, 650);
            this.p_profile_pic.TabIndex = 16;
            // 
            // tb_mail
            // 
            this.tb_mail.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(6)))), ((int)(((byte)(42)))));
            this.tb_mail.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tb_mail.Font = new System.Drawing.Font("JetBrains Mono NL Medium", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_mail.ForeColor = System.Drawing.Color.Crimson;
            this.tb_mail.Location = new System.Drawing.Point(574, 429);
            this.tb_mail.Margin = new System.Windows.Forms.Padding(0);
            this.tb_mail.Name = "tb_mail";
            this.tb_mail.Size = new System.Drawing.Size(520, 39);
            this.tb_mail.TabIndex = 18;
            // 
            // l_mail
            // 
            this.l_mail.AutoSize = true;
            this.l_mail.Font = new System.Drawing.Font("JetBrains Mono NL Medium", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.l_mail.ForeColor = System.Drawing.Color.Crimson;
            this.l_mail.Location = new System.Drawing.Point(568, 393);
            this.l_mail.Margin = new System.Windows.Forms.Padding(25, 10, 3, 0);
            this.l_mail.Name = "l_mail";
            this.l_mail.Size = new System.Drawing.Size(107, 39);
            this.l_mail.TabIndex = 17;
            this.l_mail.Text = "Почта";
            // 
            // tb_phone
            // 
            this.tb_phone.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(6)))), ((int)(((byte)(42)))));
            this.tb_phone.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tb_phone.Font = new System.Drawing.Font("JetBrains Mono NL Medium", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_phone.ForeColor = System.Drawing.Color.Crimson;
            this.tb_phone.Location = new System.Drawing.Point(573, 514);
            this.tb_phone.Margin = new System.Windows.Forms.Padding(0);
            this.tb_phone.Name = "tb_phone";
            this.tb_phone.Size = new System.Drawing.Size(520, 39);
            this.tb_phone.TabIndex = 20;
            // 
            // l_phone
            // 
            this.l_phone.AutoSize = true;
            this.l_phone.Font = new System.Drawing.Font("JetBrains Mono NL Medium", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.l_phone.ForeColor = System.Drawing.Color.Crimson;
            this.l_phone.Location = new System.Drawing.Point(567, 478);
            this.l_phone.Margin = new System.Windows.Forms.Padding(25, 10, 3, 0);
            this.l_phone.Name = "l_phone";
            this.l_phone.Size = new System.Drawing.Size(143, 39);
            this.l_phone.TabIndex = 19;
            this.l_phone.Text = "Телефон";
            // 
            // tb_error
            // 
            this.tb_error.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(4)))), ((int)(((byte)(51)))));
            this.tb_error.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tb_error.Font = new System.Drawing.Font("JetBrains Mono NL Medium", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_error.ForeColor = System.Drawing.Color.Orange;
            this.tb_error.Location = new System.Drawing.Point(574, 88);
            this.tb_error.Name = "tb_error";
            this.tb_error.Size = new System.Drawing.Size(520, 39);
            this.tb_error.TabIndex = 22;
            this.tb_error.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // b_logout
            // 
            this.b_logout.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(6)))), ((int)(((byte)(42)))));
            this.b_logout.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(83)))), ((int)(((byte)(16)))), ((int)(((byte)(105)))));
            this.b_logout.FlatAppearance.BorderSize = 0;
            this.b_logout.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.b_logout.Font = new System.Drawing.Font("JetBrains Mono NL Medium", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.b_logout.ForeColor = System.Drawing.Color.White;
            this.b_logout.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.b_logout.ImageKey = "(none)";
            this.b_logout.Location = new System.Drawing.Point(778, 576);
            this.b_logout.Name = "b_logout";
            this.b_logout.Padding = new System.Windows.Forms.Padding(3, 0, 0, 0);
            this.b_logout.Size = new System.Drawing.Size(316, 73);
            this.b_logout.TabIndex = 23;
            this.b_logout.Text = "Выйти из профиля";
            this.b_logout.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.b_logout.UseVisualStyleBackColor = false;
            this.b_logout.Click += new System.EventHandler(this.b_logout_Click);
            this.b_logout.MouseEnter += new System.EventHandler(this.b_exit_MouseEnter);
            this.b_logout.MouseLeave += new System.EventHandler(this.b_exit_MouseLeave);
            // 
            // b_update
            // 
            this.b_update.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.b_update.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(4)))), ((int)(((byte)(51)))));
            this.b_update.BackgroundImage = global::coursework_forms.Properties.Resources.refresh;
            this.b_update.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.b_update.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(4)))), ((int)(((byte)(51)))));
            this.b_update.FlatAppearance.BorderSize = 0;
            this.b_update.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(4)))), ((int)(((byte)(51)))));
            this.b_update.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(4)))), ((int)(((byte)(51)))));
            this.b_update.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.b_update.Font = new System.Drawing.Font("JetBrains Mono NL Medium", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.b_update.ForeColor = System.Drawing.Color.White;
            this.b_update.ImageKey = "(none)";
            this.b_update.Location = new System.Drawing.Point(962, 176);
            this.b_update.Margin = new System.Windows.Forms.Padding(0);
            this.b_update.Name = "b_update";
            this.b_update.Size = new System.Drawing.Size(132, 122);
            this.b_update.TabIndex = 21;
            this.b_update.UseVisualStyleBackColor = false;
            this.b_update.Click += new System.EventHandler(this.b_update_Click);
            this.b_update.MouseDown += new System.Windows.Forms.MouseEventHandler(this.b_update_MouseDown);
            this.b_update.MouseEnter += new System.EventHandler(this.b_update_MouseEnter);
            this.b_update.MouseLeave += new System.EventHandler(this.b_update_Leave);
            // 
            // b_show_password
            // 
            this.b_show_password.BackgroundImage = global::coursework_forms.Properties.Resources.eye;
            this.b_show_password.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.b_show_password.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.b_show_password.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(4)))), ((int)(((byte)(51)))));
            this.b_show_password.FlatAppearance.BorderSize = 0;
            this.b_show_password.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(4)))), ((int)(((byte)(51)))));
            this.b_show_password.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(4)))), ((int)(((byte)(51)))));
            this.b_show_password.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.b_show_password.Font = new System.Drawing.Font("JetBrains Mono NL Medium", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.b_show_password.Location = new System.Drawing.Point(528, 259);
            this.b_show_password.Margin = new System.Windows.Forms.Padding(10);
            this.b_show_password.Name = "b_show_password";
            this.b_show_password.Size = new System.Drawing.Size(36, 39);
            this.b_show_password.TabIndex = 15;
            this.b_show_password.UseVisualStyleBackColor = true;
            this.b_show_password.MouseDown += new System.Windows.Forms.MouseEventHandler(this.b_show_password_MouseDown);
            this.b_show_password.MouseUp += new System.Windows.Forms.MouseEventHandler(this.b_show_password_MouseUp);
            // 
            // profile
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(4)))), ((int)(((byte)(51)))));
            this.ClientSize = new System.Drawing.Size(1150, 675);
            this.Controls.Add(this.b_logout);
            this.Controls.Add(this.tb_error);
            this.Controls.Add(this.b_update);
            this.Controls.Add(this.tb_phone);
            this.Controls.Add(this.l_phone);
            this.Controls.Add(this.tb_mail);
            this.Controls.Add(this.l_mail);
            this.Controls.Add(this.p_profile_pic);
            this.Controls.Add(this.b_show_password);
            this.Controls.Add(this.tb_fio);
            this.Controls.Add(this.l_fio);
            this.Controls.Add(this.tb_pass);
            this.Controls.Add(this.tb_id);
            this.Controls.Add(this.l_pass);
            this.Controls.Add(this.l_id);
            this.Controls.Add(this.p_top_menu);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "profile";
            this.Text = "profile";
            this.p_top_menu.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel p_top_menu;
        private System.Windows.Forms.Button b_exit;
        private System.Windows.Forms.TextBox tb_pass;
        private System.Windows.Forms.TextBox tb_id;
        private System.Windows.Forms.Label l_pass;
        private System.Windows.Forms.Label l_id;
        private System.Windows.Forms.TextBox tb_fio;
        private System.Windows.Forms.Label l_fio;
        private System.Windows.Forms.Button b_show_password;
        private System.Windows.Forms.Panel p_profile_pic;
        private System.Windows.Forms.TextBox tb_mail;
        private System.Windows.Forms.Label l_mail;
        private System.Windows.Forms.TextBox tb_phone;
        private System.Windows.Forms.Label l_phone;
        private System.Windows.Forms.Button b_update;
        private System.Windows.Forms.TextBox tb_error;
        private System.Windows.Forms.Button b_logout;
    }
}