namespace coursework_forms {
    partial class Main {
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            this.p_top_menu = new System.Windows.Forms.Panel();
            this.p_side_menu = new System.Windows.Forms.Panel();
            this.AttesSubPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.b_attes = new System.Windows.Forms.Button();
            this.SotrSubPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.b_sotr_view = new System.Windows.Forms.Button();
            this.b_sotr_add = new System.Windows.Forms.Button();
            this.b_sotr = new System.Windows.Forms.Button();
            this.b_profile = new System.Windows.Forms.Button();
            this.p_form_view = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.b_exit = new System.Windows.Forms.Button();
            this.p_top_menu.SuspendLayout();
            this.p_side_menu.SuspendLayout();
            this.AttesSubPanel.SuspendLayout();
            this.SotrSubPanel.SuspendLayout();
            this.p_form_view.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // p_top_menu
            // 
            this.p_top_menu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(2)))), ((int)(((byte)(30)))));
            this.p_top_menu.Controls.Add(this.b_exit);
            this.p_top_menu.Dock = System.Windows.Forms.DockStyle.Top;
            this.p_top_menu.Location = new System.Drawing.Point(0, 0);
            this.p_top_menu.Name = "p_top_menu";
            this.p_top_menu.Size = new System.Drawing.Size(1200, 25);
            this.p_top_menu.TabIndex = 0;
            this.p_top_menu.MouseMove += new System.Windows.Forms.MouseEventHandler(this.p_top_menu_MouseMove);
            // 
            // p_side_menu
            // 
            this.p_side_menu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(2)))), ((int)(((byte)(30)))));
            this.p_side_menu.Controls.Add(this.AttesSubPanel);
            this.p_side_menu.Controls.Add(this.b_attes);
            this.p_side_menu.Controls.Add(this.SotrSubPanel);
            this.p_side_menu.Controls.Add(this.b_sotr);
            this.p_side_menu.Controls.Add(this.b_profile);
            this.p_side_menu.Dock = System.Windows.Forms.DockStyle.Left;
            this.p_side_menu.Location = new System.Drawing.Point(0, 25);
            this.p_side_menu.Name = "p_side_menu";
            this.p_side_menu.Size = new System.Drawing.Size(150, 575);
            this.p_side_menu.TabIndex = 2;
            // 
            // AttesSubPanel
            // 
            this.AttesSubPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(3)))), ((int)(((byte)(28)))));
            this.AttesSubPanel.Controls.Add(this.button1);
            this.AttesSubPanel.Controls.Add(this.button2);
            this.AttesSubPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.AttesSubPanel.Location = new System.Drawing.Point(0, 215);
            this.AttesSubPanel.Name = "AttesSubPanel";
            this.AttesSubPanel.Size = new System.Drawing.Size(150, 80);
            this.AttesSubPanel.TabIndex = 2;
            this.AttesSubPanel.Visible = false;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(1)))), ((int)(((byte)(20)))));
            this.button1.Dock = System.Windows.Forms.DockStyle.Top;
            this.button1.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(6)))), ((int)(((byte)(64)))));
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("JetBrains Mono Medium", 12F, System.Drawing.FontStyle.Bold);
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.ImageKey = "(none)";
            this.button1.Location = new System.Drawing.Point(0, 0);
            this.button1.Margin = new System.Windows.Forms.Padding(0);
            this.button1.Name = "button1";
            this.button1.Padding = new System.Windows.Forms.Padding(15, 0, 0, 0);
            this.button1.Size = new System.Drawing.Size(150, 40);
            this.button1.TabIndex = 2;
            this.button1.Text = "Список";
            this.button1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.button1.UseVisualStyleBackColor = false;
            this.button1.MouseEnter += new System.EventHandler(this.button_MouseEnter);
            this.button1.MouseLeave += new System.EventHandler(this.button_MouseLeave);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(1)))), ((int)(((byte)(20)))));
            this.button2.Dock = System.Windows.Forms.DockStyle.Top;
            this.button2.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(6)))), ((int)(((byte)(64)))));
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("JetBrains Mono Medium", 12F, System.Drawing.FontStyle.Bold);
            this.button2.ForeColor = System.Drawing.Color.White;
            this.button2.ImageKey = "(none)";
            this.button2.Location = new System.Drawing.Point(0, 40);
            this.button2.Margin = new System.Windows.Forms.Padding(0);
            this.button2.Name = "button2";
            this.button2.Padding = new System.Windows.Forms.Padding(15, 0, 0, 0);
            this.button2.Size = new System.Drawing.Size(150, 40);
            this.button2.TabIndex = 3;
            this.button2.Text = "Добавить";
            this.button2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button2.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.button2.UseVisualStyleBackColor = false;
            this.button2.MouseEnter += new System.EventHandler(this.button_MouseEnter);
            this.button2.MouseLeave += new System.EventHandler(this.button_MouseLeave);
            // 
            // b_attes
            // 
            this.b_attes.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(2)))), ((int)(((byte)(30)))));
            this.b_attes.Dock = System.Windows.Forms.DockStyle.Top;
            this.b_attes.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(83)))), ((int)(((byte)(16)))), ((int)(((byte)(105)))));
            this.b_attes.FlatAppearance.BorderSize = 0;
            this.b_attes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.b_attes.Font = new System.Drawing.Font("JetBrains Mono Medium", 14F, System.Drawing.FontStyle.Bold);
            this.b_attes.ForeColor = System.Drawing.Color.White;
            this.b_attes.ImageKey = "(none)";
            this.b_attes.Location = new System.Drawing.Point(0, 170);
            this.b_attes.Margin = new System.Windows.Forms.Padding(0);
            this.b_attes.Name = "b_attes";
            this.b_attes.Padding = new System.Windows.Forms.Padding(3, 0, 0, 0);
            this.b_attes.Size = new System.Drawing.Size(150, 45);
            this.b_attes.TabIndex = 3;
            this.b_attes.Text = "Аттестация";
            this.b_attes.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.b_attes.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.b_attes.UseVisualStyleBackColor = false;
            this.b_attes.Click += new System.EventHandler(this.b_attes_Click);
            this.b_attes.MouseEnter += new System.EventHandler(this.button_MouseEnter);
            this.b_attes.MouseLeave += new System.EventHandler(this.button_MouseLeave);
            // 
            // SotrSubPanel
            // 
            this.SotrSubPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(3)))), ((int)(((byte)(28)))));
            this.SotrSubPanel.Controls.Add(this.b_sotr_view);
            this.SotrSubPanel.Controls.Add(this.b_sotr_add);
            this.SotrSubPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.SotrSubPanel.Location = new System.Drawing.Point(0, 90);
            this.SotrSubPanel.Name = "SotrSubPanel";
            this.SotrSubPanel.Size = new System.Drawing.Size(150, 80);
            this.SotrSubPanel.TabIndex = 1;
            this.SotrSubPanel.Visible = false;
            // 
            // b_sotr_view
            // 
            this.b_sotr_view.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(1)))), ((int)(((byte)(20)))));
            this.b_sotr_view.Dock = System.Windows.Forms.DockStyle.Top;
            this.b_sotr_view.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(6)))), ((int)(((byte)(64)))));
            this.b_sotr_view.FlatAppearance.BorderSize = 0;
            this.b_sotr_view.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.b_sotr_view.Font = new System.Drawing.Font("JetBrains Mono Medium", 12F, System.Drawing.FontStyle.Bold);
            this.b_sotr_view.ForeColor = System.Drawing.Color.White;
            this.b_sotr_view.ImageKey = "(none)";
            this.b_sotr_view.Location = new System.Drawing.Point(0, 0);
            this.b_sotr_view.Margin = new System.Windows.Forms.Padding(0);
            this.b_sotr_view.Name = "b_sotr_view";
            this.b_sotr_view.Padding = new System.Windows.Forms.Padding(15, 0, 0, 0);
            this.b_sotr_view.Size = new System.Drawing.Size(150, 40);
            this.b_sotr_view.TabIndex = 2;
            this.b_sotr_view.Text = "Список";
            this.b_sotr_view.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.b_sotr_view.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.b_sotr_view.UseVisualStyleBackColor = false;
            this.b_sotr_view.Click += new System.EventHandler(this.b_sotr_view_Click);
            this.b_sotr_view.MouseEnter += new System.EventHandler(this.button_MouseEnter);
            this.b_sotr_view.MouseLeave += new System.EventHandler(this.button_MouseLeave);
            // 
            // b_sotr_add
            // 
            this.b_sotr_add.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(1)))), ((int)(((byte)(20)))));
            this.b_sotr_add.Dock = System.Windows.Forms.DockStyle.Top;
            this.b_sotr_add.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(6)))), ((int)(((byte)(64)))));
            this.b_sotr_add.FlatAppearance.BorderSize = 0;
            this.b_sotr_add.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.b_sotr_add.Font = new System.Drawing.Font("JetBrains Mono Medium", 12F, System.Drawing.FontStyle.Bold);
            this.b_sotr_add.ForeColor = System.Drawing.Color.White;
            this.b_sotr_add.ImageKey = "(none)";
            this.b_sotr_add.Location = new System.Drawing.Point(0, 40);
            this.b_sotr_add.Margin = new System.Windows.Forms.Padding(0);
            this.b_sotr_add.Name = "b_sotr_add";
            this.b_sotr_add.Padding = new System.Windows.Forms.Padding(15, 0, 0, 0);
            this.b_sotr_add.Size = new System.Drawing.Size(150, 40);
            this.b_sotr_add.TabIndex = 3;
            this.b_sotr_add.Text = "Добавить";
            this.b_sotr_add.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.b_sotr_add.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.b_sotr_add.UseVisualStyleBackColor = false;
            this.b_sotr_add.MouseEnter += new System.EventHandler(this.button_MouseEnter);
            this.b_sotr_add.MouseLeave += new System.EventHandler(this.button_MouseLeave);
            // 
            // b_sotr
            // 
            this.b_sotr.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(2)))), ((int)(((byte)(30)))));
            this.b_sotr.Dock = System.Windows.Forms.DockStyle.Top;
            this.b_sotr.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(83)))), ((int)(((byte)(16)))), ((int)(((byte)(105)))));
            this.b_sotr.FlatAppearance.BorderSize = 0;
            this.b_sotr.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.b_sotr.Font = new System.Drawing.Font("JetBrains Mono Medium", 14F, System.Drawing.FontStyle.Bold);
            this.b_sotr.ForeColor = System.Drawing.Color.White;
            this.b_sotr.ImageKey = "(none)";
            this.b_sotr.Location = new System.Drawing.Point(0, 45);
            this.b_sotr.Margin = new System.Windows.Forms.Padding(0);
            this.b_sotr.Name = "b_sotr";
            this.b_sotr.Padding = new System.Windows.Forms.Padding(3, 0, 0, 0);
            this.b_sotr.Size = new System.Drawing.Size(150, 45);
            this.b_sotr.TabIndex = 1;
            this.b_sotr.Text = "Сотдруник";
            this.b_sotr.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.b_sotr.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.b_sotr.UseVisualStyleBackColor = false;
            this.b_sotr.Click += new System.EventHandler(this.b_sotr_Click);
            this.b_sotr.MouseEnter += new System.EventHandler(this.button_MouseEnter);
            this.b_sotr.MouseLeave += new System.EventHandler(this.button_MouseLeave);
            // 
            // b_profile
            // 
            this.b_profile.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(2)))), ((int)(((byte)(30)))));
            this.b_profile.Dock = System.Windows.Forms.DockStyle.Top;
            this.b_profile.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(83)))), ((int)(((byte)(16)))), ((int)(((byte)(105)))));
            this.b_profile.FlatAppearance.BorderSize = 0;
            this.b_profile.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.b_profile.Font = new System.Drawing.Font("JetBrains Mono Medium", 14F, System.Drawing.FontStyle.Bold);
            this.b_profile.ForeColor = System.Drawing.Color.White;
            this.b_profile.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.b_profile.ImageKey = "(none)";
            this.b_profile.Location = new System.Drawing.Point(0, 0);
            this.b_profile.Name = "b_profile";
            this.b_profile.Padding = new System.Windows.Forms.Padding(3, 0, 0, 0);
            this.b_profile.Size = new System.Drawing.Size(150, 45);
            this.b_profile.TabIndex = 0;
            this.b_profile.Text = "Профиль";
            this.b_profile.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.b_profile.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.b_profile.UseVisualStyleBackColor = false;
            this.b_profile.Click += new System.EventHandler(this.b_profile_Click);
            this.b_profile.MouseEnter += new System.EventHandler(this.button_MouseEnter);
            this.b_profile.MouseLeave += new System.EventHandler(this.button_MouseLeave);
            // 
            // p_form_view
            // 
            this.p_form_view.Controls.Add(this.pictureBox1);
            this.p_form_view.Dock = System.Windows.Forms.DockStyle.Fill;
            this.p_form_view.Location = new System.Drawing.Point(150, 25);
            this.p_form_view.Name = "p_form_view";
            this.p_form_view.Size = new System.Drawing.Size(1050, 575);
            this.p_form_view.TabIndex = 3;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
            | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox1.Image = global::coursework_forms.Properties.Resources.HR_Form;
            this.pictureBox1.Location = new System.Drawing.Point(284, 69);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(450, 435);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // b_exit
            // 
            this.b_exit.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
            | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.b_exit.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.b_exit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(2)))), ((int)(((byte)(30)))));
            this.b_exit.BackgroundImage = global::coursework_forms.Properties.Resources.close;
            this.b_exit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.b_exit.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(83)))), ((int)(((byte)(16)))), ((int)(((byte)(105)))));
            this.b_exit.FlatAppearance.BorderSize = 0;
            this.b_exit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.b_exit.Font = new System.Drawing.Font("JetBrains Mono Medium", 12F, System.Drawing.FontStyle.Bold);
            this.b_exit.ForeColor = System.Drawing.Color.White;
            this.b_exit.ImageKey = "(none)";
            this.b_exit.Location = new System.Drawing.Point(1145, 0);
            this.b_exit.Margin = new System.Windows.Forms.Padding(0);
            this.b_exit.Name = "b_exit";
            this.b_exit.Size = new System.Drawing.Size(55, 25);
            this.b_exit.TabIndex = 7;
            this.b_exit.UseVisualStyleBackColor = false;
            this.b_exit.Click += new System.EventHandler(this.b_exit_Click);
            this.b_exit.MouseEnter += new System.EventHandler(this.b_exit_MouseEnter);
            this.b_exit.MouseLeave += new System.EventHandler(this.b_exit_MouseLeave);
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(4)))), ((int)(((byte)(51)))));
            this.ClientSize = new System.Drawing.Size(1200, 600);
            this.Controls.Add(this.p_form_view);
            this.Controls.Add(this.p_side_menu);
            this.Controls.Add(this.p_top_menu);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Main";
            this.Text = "Head";
            this.p_top_menu.ResumeLayout(false);
            this.p_side_menu.ResumeLayout(false);
            this.AttesSubPanel.ResumeLayout(false);
            this.SotrSubPanel.ResumeLayout(false);
            this.p_form_view.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel p_top_menu;
        private System.Windows.Forms.Panel p_side_menu;
        private System.Windows.Forms.FlowLayoutPanel AttesSubPanel;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button b_attes;
        private System.Windows.Forms.FlowLayoutPanel SotrSubPanel;
        private System.Windows.Forms.Button b_sotr_view;
        private System.Windows.Forms.Button b_sotr_add;
        private System.Windows.Forms.Button b_sotr;
        private System.Windows.Forms.Button b_profile;
        private System.Windows.Forms.Panel p_form_view;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button b_exit;
    }
}