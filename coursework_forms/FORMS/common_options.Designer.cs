namespace coursework_forms {
    partial class common_options {
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
            this.label4 = new System.Windows.Forms.Label();
            this.tb_id = new System.Windows.Forms.TextBox();
            this.b_profile = new System.Windows.Forms.Button();
            this.tb_fio = new System.Windows.Forms.TextBox();
            this.l_id = new System.Windows.Forms.Label();
            this.dtp_from = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.dtp_to = new System.Windows.Forms.DateTimePicker();
            this.cb_from = new System.Windows.Forms.CheckBox();
            this.cb_to = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("JetBrains Mono NL Medium", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Crimson;
            this.label1.Location = new System.Drawing.Point(34, 262);
            this.label1.Margin = new System.Windows.Forms.Padding(25, 25, 3, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(83, 36);
            this.label1.TabIndex = 40;
            this.label1.Text = "Дата";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("JetBrains Mono NL Medium", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Crimson;
            this.label4.Location = new System.Drawing.Point(34, 68);
            this.label4.Margin = new System.Windows.Forms.Padding(25, 25, 3, 0);
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
            this.tb_id.Location = new System.Drawing.Point(29, 104);
            this.tb_id.Margin = new System.Windows.Forms.Padding(20, 0, 20, 0);
            this.tb_id.Name = "tb_id";
            this.tb_id.Size = new System.Drawing.Size(292, 36);
            this.tb_id.TabIndex = 49;
            this.tb_id.Text = "0";
            this.tb_id.TextChanged += new System.EventHandler(this.tb_id_change);
            this.tb_id.Enter += new System.EventHandler(this.tb_Enter);
            this.tb_id.Leave += new System.EventHandler(this.tb_id_Leave);
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
            this.b_profile.Location = new System.Drawing.Point(29, 488);
            this.b_profile.Name = "b_profile";
            this.b_profile.Padding = new System.Windows.Forms.Padding(3, 0, 0, 0);
            this.b_profile.Size = new System.Drawing.Size(292, 73);
            this.b_profile.TabIndex = 53;
            this.b_profile.Text = "Очистить фильтр";
            this.b_profile.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.b_profile.UseVisualStyleBackColor = false;
            this.b_profile.Click += new System.EventHandler(this.b_clear_Click);
            this.b_profile.MouseEnter += new System.EventHandler(this.b_exit_MouseEnter);
            this.b_profile.MouseLeave += new System.EventHandler(this.b_exit_MouseLeave);
            // 
            // tb_fio
            // 
            this.tb_fio.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(6)))), ((int)(((byte)(42)))));
            this.tb_fio.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tb_fio.Font = new System.Drawing.Font("JetBrains Mono NL Medium", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_fio.ForeColor = System.Drawing.Color.BlueViolet;
            this.tb_fio.Location = new System.Drawing.Point(29, 201);
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
            this.l_id.Location = new System.Drawing.Point(34, 165);
            this.l_id.Margin = new System.Windows.Forms.Padding(25, 25, 3, 0);
            this.l_id.Name = "l_id";
            this.l_id.Size = new System.Drawing.Size(66, 36);
            this.l_id.TabIndex = 38;
            this.l_id.Text = "ФИО";
            // 
            // dtp_from
            // 
            this.dtp_from.CalendarForeColor = System.Drawing.Color.Crimson;
            this.dtp_from.CalendarTitleBackColor = System.Drawing.SystemColors.ControlText;
            this.dtp_from.CalendarTitleForeColor = System.Drawing.Color.AliceBlue;
            this.dtp_from.CustomFormat = "dd.MM.yyyy";
            this.dtp_from.Font = new System.Drawing.Font("JetBrains Mono NL Medium", 18F, System.Drawing.FontStyle.Bold);
            this.dtp_from.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtp_from.Location = new System.Drawing.Point(89, 321);
            this.dtp_from.Name = "dtp_from";
            this.dtp_from.Size = new System.Drawing.Size(196, 39);
            this.dtp_from.TabIndex = 54;
            this.dtp_from.Value = new System.DateTime(2020, 1, 1, 0, 0, 0, 0);
            this.dtp_from.CloseUp += new System.EventHandler(this.dtp_from_CloseUp);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("JetBrains Mono NL Medium", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Crimson;
            this.label2.Location = new System.Drawing.Point(34, 323);
            this.label2.Margin = new System.Windows.Forms.Padding(25, 25, 3, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 36);
            this.label2.TabIndex = 55;
            this.label2.Text = "От";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("JetBrains Mono NL Medium", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Crimson;
            this.label3.Location = new System.Drawing.Point(34, 384);
            this.label3.Margin = new System.Windows.Forms.Padding(25, 25, 3, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(49, 36);
            this.label3.TabIndex = 57;
            this.label3.Text = "До";
            // 
            // dtp_to
            // 
            this.dtp_to.CustomFormat = "dd.MM.yyyy";
            this.dtp_to.Font = new System.Drawing.Font("JetBrains Mono NL Medium", 18F, System.Drawing.FontStyle.Bold);
            this.dtp_to.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtp_to.Location = new System.Drawing.Point(89, 382);
            this.dtp_to.Name = "dtp_to";
            this.dtp_to.Size = new System.Drawing.Size(196, 39);
            this.dtp_to.TabIndex = 56;
            this.dtp_to.Value = new System.DateTime(2022, 12, 2, 18, 8, 49, 0);
            this.dtp_to.CloseUp += new System.EventHandler(this.dtp_to_CloseUp);
            // 
            // cb_from
            // 
            this.cb_from.Appearance = System.Windows.Forms.Appearance.Button;
            this.cb_from.FlatAppearance.BorderColor = System.Drawing.Color.Crimson;
            this.cb_from.FlatAppearance.BorderSize = 3;
            this.cb_from.FlatAppearance.CheckedBackColor = System.Drawing.Color.Lime;
            this.cb_from.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cb_from.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.cb_from.Location = new System.Drawing.Point(291, 325);
            this.cb_from.Name = "cb_from";
            this.cb_from.Size = new System.Drawing.Size(30, 30);
            this.cb_from.TabIndex = 58;
            this.cb_from.UseVisualStyleBackColor = true;
            this.cb_from.CheckedChanged += new System.EventHandler(this.cb_from_CheckedChanged);
            // 
            // cb_to
            // 
            this.cb_to.Appearance = System.Windows.Forms.Appearance.Button;
            this.cb_to.FlatAppearance.BorderColor = System.Drawing.Color.Crimson;
            this.cb_to.FlatAppearance.BorderSize = 3;
            this.cb_to.FlatAppearance.CheckedBackColor = System.Drawing.Color.Lime;
            this.cb_to.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cb_to.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.cb_to.Location = new System.Drawing.Point(291, 386);
            this.cb_to.Name = "cb_to";
            this.cb_to.Size = new System.Drawing.Size(30, 30);
            this.cb_to.TabIndex = 59;
            this.cb_to.UseVisualStyleBackColor = true;
            this.cb_to.CheckedChanged += new System.EventHandler(this.cb_to_CheckedChanged);
            // 
            // common_options
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(4)))), ((int)(((byte)(51)))));
            this.ClientSize = new System.Drawing.Size(350, 650);
            this.Controls.Add(this.cb_to);
            this.Controls.Add(this.cb_from);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.dtp_to);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dtp_from);
            this.Controls.Add(this.b_profile);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.tb_id);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.l_id);
            this.Controls.Add(this.tb_fio);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "common_options";
            this.Text = "sotr_view";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tb_id;
        private System.Windows.Forms.Button b_profile;
        private System.Windows.Forms.TextBox tb_fio;
        private System.Windows.Forms.Label l_id;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker dtp_to;
        private System.Windows.Forms.DateTimePicker dtp_from;
        private System.Windows.Forms.CheckBox cb_from;
        private System.Windows.Forms.CheckBox cb_to;
    }
}