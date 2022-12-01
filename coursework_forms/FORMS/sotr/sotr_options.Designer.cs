namespace coursework_forms {
    partial class sotr_options {
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
            this.label1 = new System.Windows.Forms.Label();
            this.tb_salary_min = new System.Windows.Forms.TextBox();
            this.tb_salary_max = new System.Windows.Forms.TextBox();
            this.tb_stage_max = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tb_stage_min = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.tb_id = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.tb_td = new System.Windows.Forms.TextBox();
            this.b_profile = new System.Windows.Forms.Button();
            this.rb_w = new System.Windows.Forms.RadioButton();
            this.label3 = new System.Windows.Forms.Label();
            this.rb_m = new System.Windows.Forms.RadioButton();
            this.rb_n = new System.Windows.Forms.RadioButton();
            this.tb_fio = new System.Windows.Forms.TextBox();
            this.l_id = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.tb_work = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("JetBrains Mono NL Medium", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Crimson;
            this.label1.Location = new System.Drawing.Point(34, 314);
            this.label1.Margin = new System.Windows.Forms.Padding(25, 5, 3, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 36);
            this.label1.TabIndex = 40;
            this.label1.Text = "ЗП";
            // 
            // tb_salary_min
            // 
            this.tb_salary_min.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(6)))), ((int)(((byte)(42)))));
            this.tb_salary_min.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tb_salary_min.Font = new System.Drawing.Font("JetBrains Mono NL Medium", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_salary_min.ForeColor = System.Drawing.Color.BlueViolet;
            this.tb_salary_min.Location = new System.Drawing.Point(29, 350);
            this.tb_salary_min.Margin = new System.Windows.Forms.Padding(20, 0, 20, 0);
            this.tb_salary_min.Name = "tb_salary_min";
            this.tb_salary_min.Size = new System.Drawing.Size(136, 36);
            this.tb_salary_min.TabIndex = 39;
            this.tb_salary_min.Text = "От";
            this.tb_salary_min.TextChanged += new System.EventHandler(this.tb_from_changed);
            this.tb_salary_min.Enter += new System.EventHandler(this.tb_Enter);
            this.tb_salary_min.Leave += new System.EventHandler(this.tb_from_Leave);
            // 
            // tb_salary_max
            // 
            this.tb_salary_max.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(6)))), ((int)(((byte)(42)))));
            this.tb_salary_max.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tb_salary_max.Font = new System.Drawing.Font("JetBrains Mono NL Medium", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_salary_max.ForeColor = System.Drawing.Color.BlueViolet;
            this.tb_salary_max.Location = new System.Drawing.Point(185, 350);
            this.tb_salary_max.Margin = new System.Windows.Forms.Padding(20, 0, 20, 0);
            this.tb_salary_max.Name = "tb_salary_max";
            this.tb_salary_max.Size = new System.Drawing.Size(136, 36);
            this.tb_salary_max.TabIndex = 41;
            this.tb_salary_max.Text = "До";
            this.tb_salary_max.TextChanged += new System.EventHandler(this.tb_to_changed);
            this.tb_salary_max.Enter += new System.EventHandler(this.tb_Enter);
            this.tb_salary_max.Leave += new System.EventHandler(this.tb_to_Leave);
            // 
            // tb_stage_max
            // 
            this.tb_stage_max.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(6)))), ((int)(((byte)(42)))));
            this.tb_stage_max.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tb_stage_max.Font = new System.Drawing.Font("JetBrains Mono NL Medium", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_stage_max.ForeColor = System.Drawing.Color.BlueViolet;
            this.tb_stage_max.Location = new System.Drawing.Point(185, 427);
            this.tb_stage_max.Margin = new System.Windows.Forms.Padding(20, 0, 20, 0);
            this.tb_stage_max.Name = "tb_stage_max";
            this.tb_stage_max.Size = new System.Drawing.Size(136, 36);
            this.tb_stage_max.TabIndex = 44;
            this.tb_stage_max.Text = "До";
            this.tb_stage_max.TextChanged += new System.EventHandler(this.tb_to_changed);
            this.tb_stage_max.Enter += new System.EventHandler(this.tb_Enter);
            this.tb_stage_max.Leave += new System.EventHandler(this.tb_to_Leave);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("JetBrains Mono NL Medium", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Crimson;
            this.label2.Location = new System.Drawing.Point(34, 391);
            this.label2.Margin = new System.Windows.Forms.Padding(25, 5, 3, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(83, 36);
            this.label2.TabIndex = 43;
            this.label2.Text = "Стаж";
            // 
            // tb_stage_min
            // 
            this.tb_stage_min.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(6)))), ((int)(((byte)(42)))));
            this.tb_stage_min.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tb_stage_min.Font = new System.Drawing.Font("JetBrains Mono NL Medium", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_stage_min.ForeColor = System.Drawing.Color.BlueViolet;
            this.tb_stage_min.Location = new System.Drawing.Point(29, 427);
            this.tb_stage_min.Margin = new System.Windows.Forms.Padding(20, 0, 20, 0);
            this.tb_stage_min.Name = "tb_stage_min";
            this.tb_stage_min.Size = new System.Drawing.Size(136, 36);
            this.tb_stage_min.TabIndex = 42;
            this.tb_stage_min.Text = "От";
            this.tb_stage_min.TextChanged += new System.EventHandler(this.tb_from_changed);
            this.tb_stage_min.Enter += new System.EventHandler(this.tb_Enter);
            this.tb_stage_min.Leave += new System.EventHandler(this.tb_from_Leave);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("JetBrains Mono NL Medium", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Crimson;
            this.label4.Location = new System.Drawing.Point(34, 6);
            this.label4.Margin = new System.Windows.Forms.Padding(25, 5, 3, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(49, 36);
            this.label4.TabIndex = 50;
            this.label4.Text = "ID";
            // 
            // tb_id
            // 
            this.tb_id.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(6)))), ((int)(((byte)(42)))));
            this.tb_id.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tb_id.Font = new System.Drawing.Font("JetBrains Mono NL Medium", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_id.ForeColor = System.Drawing.Color.BlueViolet;
            this.tb_id.Location = new System.Drawing.Point(29, 42);
            this.tb_id.Margin = new System.Windows.Forms.Padding(20, 0, 20, 0);
            this.tb_id.Name = "tb_id";
            this.tb_id.Size = new System.Drawing.Size(292, 36);
            this.tb_id.TabIndex = 49;
            this.tb_id.Text = "0";
            this.tb_id.TextChanged += new System.EventHandler(this.tb_id_change);
            this.tb_id.Enter += new System.EventHandler(this.tb_Enter);
            this.tb_id.Leave += new System.EventHandler(this.tb_id_Leave);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("JetBrains Mono NL Medium", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Crimson;
            this.label5.Location = new System.Drawing.Point(34, 83);
            this.label5.Margin = new System.Windows.Forms.Padding(25, 5, 3, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(287, 36);
            this.label5.TabIndex = 52;
            this.label5.Text = "Трудовой договор";
            // 
            // tb_td
            // 
            this.tb_td.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(6)))), ((int)(((byte)(42)))));
            this.tb_td.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tb_td.Font = new System.Drawing.Font("JetBrains Mono NL Medium", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_td.ForeColor = System.Drawing.Color.BlueViolet;
            this.tb_td.Location = new System.Drawing.Point(29, 119);
            this.tb_td.Margin = new System.Windows.Forms.Padding(20, 0, 20, 0);
            this.tb_td.Name = "tb_td";
            this.tb_td.Size = new System.Drawing.Size(292, 36);
            this.tb_td.TabIndex = 51;
            this.tb_td.Text = "0";
            this.tb_td.TextChanged += new System.EventHandler(this.tb_td_change);
            this.tb_td.Enter += new System.EventHandler(this.tb_Enter);
            this.tb_td.Leave += new System.EventHandler(this.tb_td_Leave);
            // 
            // b_profile
            // 
            this.b_profile.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(2)))), ((int)(((byte)(30)))));
            this.b_profile.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(83)))), ((int)(((byte)(16)))), ((int)(((byte)(105)))));
            this.b_profile.FlatAppearance.BorderSize = 0;
            this.b_profile.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.b_profile.Font = new System.Drawing.Font("JetBrains Mono Medium", 17F, System.Drawing.FontStyle.Bold);
            this.b_profile.ForeColor = System.Drawing.Color.White;
            this.b_profile.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.b_profile.ImageKey = "(none)";
            this.b_profile.Location = new System.Drawing.Point(29, 571);
            this.b_profile.Name = "b_profile";
            this.b_profile.Padding = new System.Windows.Forms.Padding(3, 0, 0, 0);
            this.b_profile.Size = new System.Drawing.Size(292, 67);
            this.b_profile.TabIndex = 53;
            this.b_profile.Text = "Очистить фильтр";
            this.b_profile.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.b_profile.UseVisualStyleBackColor = false;
            this.b_profile.Click += new System.EventHandler(this.b_clear_Click);
            this.b_profile.MouseEnter += new System.EventHandler(this.b_exit_MouseEnter);
            this.b_profile.MouseLeave += new System.EventHandler(this.b_exit_MouseLeave);
            // 
            // rb_w
            // 
            this.rb_w.Appearance = System.Windows.Forms.Appearance.Button;
            this.rb_w.AutoSize = true;
            this.rb_w.FlatAppearance.CheckedBackColor = System.Drawing.Color.Lime;
            this.rb_w.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.rb_w.Font = new System.Drawing.Font("JetBrains Mono NL Medium", 20.25F, System.Drawing.FontStyle.Bold);
            this.rb_w.ForeColor = System.Drawing.Color.Crimson;
            this.rb_w.Location = new System.Drawing.Point(102, 507);
            this.rb_w.Name = "rb_w";
            this.rb_w.Size = new System.Drawing.Size(44, 48);
            this.rb_w.TabIndex = 56;
            this.rb_w.Text = "Ж";
            this.rb_w.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.rb_w.UseVisualStyleBackColor = true;
            this.rb_w.CheckedChanged += new System.EventHandler(this.rb_change);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("JetBrains Mono NL Medium", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Crimson;
            this.label3.Location = new System.Drawing.Point(34, 468);
            this.label3.Margin = new System.Windows.Forms.Padding(25, 5, 3, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(66, 36);
            this.label3.TabIndex = 55;
            this.label3.Text = "Пол";
            // 
            // rb_m
            // 
            this.rb_m.Appearance = System.Windows.Forms.Appearance.Button;
            this.rb_m.AutoSize = true;
            this.rb_m.FlatAppearance.CheckedBackColor = System.Drawing.Color.Lime;
            this.rb_m.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.rb_m.Font = new System.Drawing.Font("JetBrains Mono NL Medium", 20.25F, System.Drawing.FontStyle.Bold);
            this.rb_m.ForeColor = System.Drawing.Color.Crimson;
            this.rb_m.Location = new System.Drawing.Point(29, 507);
            this.rb_m.Name = "rb_m";
            this.rb_m.Size = new System.Drawing.Size(44, 48);
            this.rb_m.TabIndex = 54;
            this.rb_m.Text = "M";
            this.rb_m.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.rb_m.UseVisualStyleBackColor = true;
            this.rb_m.CheckedChanged += new System.EventHandler(this.rb_change);
            // 
            // rb_n
            // 
            this.rb_n.Appearance = System.Windows.Forms.Appearance.Button;
            this.rb_n.AutoSize = true;
            this.rb_n.Checked = true;
            this.rb_n.FlatAppearance.CheckedBackColor = System.Drawing.Color.Lime;
            this.rb_n.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.rb_n.Font = new System.Drawing.Font("JetBrains Mono NL Medium", 20.25F, System.Drawing.FontStyle.Bold);
            this.rb_n.ForeColor = System.Drawing.Color.Crimson;
            this.rb_n.Location = new System.Drawing.Point(175, 507);
            this.rb_n.Name = "rb_n";
            this.rb_n.Size = new System.Drawing.Size(146, 48);
            this.rb_n.TabIndex = 57;
            this.rb_n.TabStop = true;
            this.rb_n.Text = "Никакой";
            this.rb_n.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.rb_n.UseVisualStyleBackColor = true;
            this.rb_n.CheckedChanged += new System.EventHandler(this.rb_change);
            // 
            // tb_fio
            // 
            this.tb_fio.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(6)))), ((int)(((byte)(42)))));
            this.tb_fio.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tb_fio.Font = new System.Drawing.Font("JetBrains Mono NL Medium", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_fio.ForeColor = System.Drawing.Color.BlueViolet;
            this.tb_fio.Location = new System.Drawing.Point(29, 196);
            this.tb_fio.Margin = new System.Windows.Forms.Padding(20, 0, 20, 0);
            this.tb_fio.Name = "tb_fio";
            this.tb_fio.Size = new System.Drawing.Size(292, 36);
            this.tb_fio.TabIndex = 37;
            this.tb_fio.Text = "Иванов Иван";
            this.tb_fio.TextChanged += new System.EventHandler(this.tb_fio_change);
            this.tb_fio.Enter += new System.EventHandler(this.tb_Enter);
            this.tb_fio.Leave += new System.EventHandler(this.tb_fio_Leave);
            // 
            // l_id
            // 
            this.l_id.AutoSize = true;
            this.l_id.Font = new System.Drawing.Font("JetBrains Mono NL Medium", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.l_id.ForeColor = System.Drawing.Color.Crimson;
            this.l_id.Location = new System.Drawing.Point(34, 160);
            this.l_id.Margin = new System.Windows.Forms.Padding(25, 5, 3, 0);
            this.l_id.Name = "l_id";
            this.l_id.Size = new System.Drawing.Size(66, 36);
            this.l_id.TabIndex = 38;
            this.l_id.Text = "ФИО";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("JetBrains Mono NL Medium", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Crimson;
            this.label6.Location = new System.Drawing.Point(34, 237);
            this.label6.Margin = new System.Windows.Forms.Padding(25, 5, 3, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(168, 36);
            this.label6.TabIndex = 59;
            this.label6.Text = "Должность";
            // 
            // tb_work
            // 
            this.tb_work.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(6)))), ((int)(((byte)(42)))));
            this.tb_work.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tb_work.Font = new System.Drawing.Font("JetBrains Mono NL Medium", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_work.ForeColor = System.Drawing.Color.BlueViolet;
            this.tb_work.Location = new System.Drawing.Point(29, 273);
            this.tb_work.Margin = new System.Windows.Forms.Padding(20, 0, 20, 0);
            this.tb_work.Name = "tb_work";
            this.tb_work.Size = new System.Drawing.Size(292, 36);
            this.tb_work.TabIndex = 58;
            this.tb_work.Text = "директор";
            this.tb_work.TextChanged += new System.EventHandler(this.tb_work_change);
            this.tb_work.Enter += new System.EventHandler(this.tb_Enter);
            this.tb_work.Leave += new System.EventHandler(this.tb_work_Leave);
            // 
            // sotr_options
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(4)))), ((int)(((byte)(51)))));
            this.ClientSize = new System.Drawing.Size(350, 650);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.tb_work);
            this.Controls.Add(this.rb_n);
            this.Controls.Add(this.rb_w);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.rb_m);
            this.Controls.Add(this.b_profile);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.tb_td);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.tb_id);
            this.Controls.Add(this.tb_stage_max);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tb_stage_min);
            this.Controls.Add(this.tb_salary_max);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tb_salary_min);
            this.Controls.Add(this.l_id);
            this.Controls.Add(this.tb_fio);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "sotr_options";
            this.Text = "sotr_view";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tb_salary_min;
        private System.Windows.Forms.TextBox tb_salary_max;
        private System.Windows.Forms.TextBox tb_stage_max;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tb_stage_min;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tb_id;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tb_td;
        private System.Windows.Forms.Button b_profile;
        private System.Windows.Forms.RadioButton rb_w;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.RadioButton rb_m;
        private System.Windows.Forms.RadioButton rb_n;
        private System.Windows.Forms.TextBox tb_fio;
        private System.Windows.Forms.Label l_id;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox tb_work;
    }
}