namespace coursework_forms.FORMS.sotr {
    partial class sotr_add {
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
            this.components = new System.ComponentModel.Container();
            this.p_top_menu = new System.Windows.Forms.Panel();
            this.b_exit = new System.Windows.Forms.Button();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.tb_phone = new System.Windows.Forms.TextBox();
            this.l_phone = new System.Windows.Forms.Label();
            this.tb_mail = new System.Windows.Forms.TextBox();
            this.l_mail = new System.Windows.Forms.Label();
            this.tb_fio = new System.Windows.Forms.TextBox();
            this.l_fio = new System.Windows.Forms.Label();
            this.l_gender = new System.Windows.Forms.Label();
            this.tb_stage = new System.Windows.Forms.TextBox();
            this.l_stage = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dtm_birth = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.tb_td = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.cb_place = new System.Windows.Forms.ComboBox();
            this.moveAdd1BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.courseworkDataSet = new coursework_forms.CourseworkDataSet();
            this.b_add = new System.Windows.Forms.Button();
            this.tb_error = new System.Windows.Forms.TextBox();
            this.cb_gender = new System.Windows.Forms.ComboBox();
            this.cb_doc = new System.Windows.Forms.CheckBox();
            this.label5 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.штатноеРасписание1BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.штатноеРасписание1TableAdapter = new coursework_forms.CourseworkDataSetTableAdapters.ШтатноеРасписание1TableAdapter();
            this.label6 = new System.Windows.Forms.Label();
            this.tb_salary = new System.Windows.Forms.TextBox();
            this.moveAdd1TableAdapter = new coursework_forms.CourseworkDataSetTableAdapters.MoveAdd1TableAdapter();
            this.p_top_menu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.moveAdd1BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.courseworkDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.штатноеРасписание1BindingSource)).BeginInit();
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
            this.p_top_menu.TabIndex = 9;
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
            // tb_phone
            // 
            this.tb_phone.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(6)))), ((int)(((byte)(42)))));
            this.tb_phone.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tb_phone.Font = new System.Drawing.Font("JetBrains Mono NL Medium", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_phone.ForeColor = System.Drawing.Color.Crimson;
            this.tb_phone.Location = new System.Drawing.Point(595, 227);
            this.tb_phone.Margin = new System.Windows.Forms.Padding(0);
            this.tb_phone.Name = "tb_phone";
            this.tb_phone.Size = new System.Drawing.Size(465, 36);
            this.tb_phone.TabIndex = 26;
            this.tb_phone.TextChanged += new System.EventHandler(this.tb_phone_TextChanged);
            // 
            // l_phone
            // 
            this.l_phone.AutoSize = true;
            this.l_phone.Font = new System.Drawing.Font("JetBrains Mono NL Medium", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.l_phone.ForeColor = System.Drawing.Color.Crimson;
            this.l_phone.Location = new System.Drawing.Point(589, 186);
            this.l_phone.Margin = new System.Windows.Forms.Padding(25, 25, 25, 5);
            this.l_phone.Name = "l_phone";
            this.l_phone.Size = new System.Drawing.Size(134, 36);
            this.l_phone.TabIndex = 25;
            this.l_phone.Text = "Телефон";
            // 
            // tb_mail
            // 
            this.tb_mail.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(6)))), ((int)(((byte)(42)))));
            this.tb_mail.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tb_mail.Font = new System.Drawing.Font("JetBrains Mono NL Medium", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_mail.ForeColor = System.Drawing.Color.Crimson;
            this.tb_mail.Location = new System.Drawing.Point(93, 227);
            this.tb_mail.Margin = new System.Windows.Forms.Padding(0);
            this.tb_mail.Name = "tb_mail";
            this.tb_mail.Size = new System.Drawing.Size(485, 36);
            this.tb_mail.TabIndex = 24;
            // 
            // l_mail
            // 
            this.l_mail.AutoSize = true;
            this.l_mail.Font = new System.Drawing.Font("JetBrains Mono NL Medium", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.l_mail.ForeColor = System.Drawing.Color.Crimson;
            this.l_mail.Location = new System.Drawing.Point(87, 186);
            this.l_mail.Margin = new System.Windows.Forms.Padding(25, 25, 25, 5);
            this.l_mail.Name = "l_mail";
            this.l_mail.Size = new System.Drawing.Size(100, 36);
            this.l_mail.TabIndex = 23;
            this.l_mail.Text = "Почта";
            // 
            // tb_fio
            // 
            this.tb_fio.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(6)))), ((int)(((byte)(42)))));
            this.tb_fio.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tb_fio.Font = new System.Drawing.Font("JetBrains Mono NL Medium", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_fio.ForeColor = System.Drawing.Color.Crimson;
            this.tb_fio.Location = new System.Drawing.Point(93, 125);
            this.tb_fio.Margin = new System.Windows.Forms.Padding(0);
            this.tb_fio.Name = "tb_fio";
            this.tb_fio.Size = new System.Drawing.Size(967, 36);
            this.tb_fio.TabIndex = 22;
            // 
            // l_fio
            // 
            this.l_fio.AutoSize = true;
            this.l_fio.Font = new System.Drawing.Font("JetBrains Mono NL Medium", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.l_fio.ForeColor = System.Drawing.Color.Crimson;
            this.l_fio.Location = new System.Drawing.Point(87, 84);
            this.l_fio.Margin = new System.Windows.Forms.Padding(25, 25, 25, 5);
            this.l_fio.Name = "l_fio";
            this.l_fio.Size = new System.Drawing.Size(66, 36);
            this.l_fio.TabIndex = 21;
            this.l_fio.Text = "ФИО";
            // 
            // l_gender
            // 
            this.l_gender.AutoSize = true;
            this.l_gender.Font = new System.Drawing.Font("JetBrains Mono NL Medium", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.l_gender.ForeColor = System.Drawing.Color.Crimson;
            this.l_gender.Location = new System.Drawing.Point(87, 293);
            this.l_gender.Margin = new System.Windows.Forms.Padding(25, 25, 25, 5);
            this.l_gender.Name = "l_gender";
            this.l_gender.Size = new System.Drawing.Size(66, 36);
            this.l_gender.TabIndex = 27;
            this.l_gender.Text = "Пол";
            // 
            // tb_stage
            // 
            this.tb_stage.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(6)))), ((int)(((byte)(42)))));
            this.tb_stage.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tb_stage.Font = new System.Drawing.Font("JetBrains Mono NL Medium", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_stage.ForeColor = System.Drawing.Color.Crimson;
            this.tb_stage.Location = new System.Drawing.Point(944, 334);
            this.tb_stage.Margin = new System.Windows.Forms.Padding(20, 0, 20, 0);
            this.tb_stage.Name = "tb_stage";
            this.tb_stage.Size = new System.Drawing.Size(116, 36);
            this.tb_stage.TabIndex = 30;
            this.tb_stage.TextChanged += new System.EventHandler(this.tb_stage_TextChanged);
            // 
            // l_stage
            // 
            this.l_stage.AutoSize = true;
            this.l_stage.Font = new System.Drawing.Font("JetBrains Mono NL Medium", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.l_stage.ForeColor = System.Drawing.Color.Crimson;
            this.l_stage.Location = new System.Drawing.Point(938, 293);
            this.l_stage.Margin = new System.Windows.Forms.Padding(25, 25, 25, 5);
            this.l_stage.Name = "l_stage";
            this.l_stage.Size = new System.Drawing.Size(83, 36);
            this.l_stage.TabIndex = 29;
            this.l_stage.Text = "Стаж";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("JetBrains Mono NL Medium", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Crimson;
            this.label1.Location = new System.Drawing.Point(87, 396);
            this.label1.Margin = new System.Windows.Forms.Padding(25, 25, 25, 5);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 36);
            this.label1.TabIndex = 31;
            this.label1.Text = "Отдел";
            // 
            // dtm_birth
            // 
            this.dtm_birth.CalendarForeColor = System.Drawing.Color.Crimson;
            this.dtm_birth.CalendarMonthBackground = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(6)))), ((int)(((byte)(42)))));
            this.dtm_birth.CalendarTitleBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(6)))), ((int)(((byte)(42)))));
            this.dtm_birth.CalendarTitleForeColor = System.Drawing.Color.Crimson;
            this.dtm_birth.CalendarTrailingForeColor = System.Drawing.Color.Crimson;
            this.dtm_birth.CustomFormat = "dd.MM.yyyy";
            this.dtm_birth.Font = new System.Drawing.Font("Microsoft Sans Serif", 19F);
            this.dtm_birth.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtm_birth.Location = new System.Drawing.Point(193, 334);
            this.dtm_birth.Margin = new System.Windows.Forms.Padding(20, 3, 20, 3);
            this.dtm_birth.MaxDate = new System.DateTime(2022, 12, 3, 0, 0, 0, 0);
            this.dtm_birth.MinDate = new System.DateTime(1900, 1, 1, 0, 0, 0, 0);
            this.dtm_birth.Name = "dtm_birth";
            this.dtm_birth.Size = new System.Drawing.Size(301, 36);
            this.dtm_birth.TabIndex = 33;
            this.dtm_birth.Value = new System.DateTime(2022, 12, 3, 0, 0, 0, 0);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("JetBrains Mono NL Medium", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Crimson;
            this.label2.Location = new System.Drawing.Point(187, 293);
            this.label2.Margin = new System.Windows.Forms.Padding(25, 25, 25, 5);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(236, 36);
            this.label2.TabIndex = 34;
            this.label2.Text = "Дата рождения";
            // 
            // tb_td
            // 
            this.tb_td.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(6)))), ((int)(((byte)(42)))));
            this.tb_td.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tb_td.Font = new System.Drawing.Font("JetBrains Mono NL Medium", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_td.ForeColor = System.Drawing.Color.Crimson;
            this.tb_td.Location = new System.Drawing.Point(699, 38);
            this.tb_td.Margin = new System.Windows.Forms.Padding(20, 0, 20, 0);
            this.tb_td.Name = "tb_td";
            this.tb_td.ReadOnly = true;
            this.tb_td.Size = new System.Drawing.Size(138, 36);
            this.tb_td.TabIndex = 36;
            this.tb_td.TextChanged += new System.EventHandler(this.tb_td_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("JetBrains Mono NL Medium", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Crimson;
            this.label3.Location = new System.Drawing.Point(379, 38);
            this.label3.Margin = new System.Windows.Forms.Padding(25, 10, 3, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(321, 36);
            this.label3.TabIndex = 35;
            this.label3.Text = "Трудовой договор №";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("JetBrains Mono NL Medium", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Crimson;
            this.label4.Location = new System.Drawing.Point(589, 396);
            this.label4.Margin = new System.Windows.Forms.Padding(25, 25, 25, 5);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(168, 36);
            this.label4.TabIndex = 37;
            this.label4.Text = "Должность";
            // 
            // cb_place
            // 
            this.cb_place.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(6)))), ((int)(((byte)(42)))));
            this.cb_place.DataSource = this.moveAdd1BindingSource;
            this.cb_place.DisplayMember = "Должность";
            this.cb_place.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_place.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cb_place.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.cb_place.ForeColor = System.Drawing.Color.Crimson;
            this.cb_place.Location = new System.Drawing.Point(595, 440);
            this.cb_place.Name = "cb_place";
            this.cb_place.Size = new System.Drawing.Size(465, 39);
            this.cb_place.TabIndex = 38;
            this.cb_place.ValueMember = "ID";
            // 
            // moveAdd1BindingSource
            // 
            this.moveAdd1BindingSource.DataMember = "MoveAdd1";
            this.moveAdd1BindingSource.DataSource = this.courseworkDataSet;
            // 
            // courseworkDataSet
            // 
            this.courseworkDataSet.DataSetName = "CourseworkDataSet";
            this.courseworkDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // b_add
            // 
            this.b_add.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(6)))), ((int)(((byte)(42)))));
            this.b_add.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(83)))), ((int)(((byte)(16)))), ((int)(((byte)(105)))));
            this.b_add.FlatAppearance.BorderSize = 0;
            this.b_add.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.b_add.Font = new System.Drawing.Font("JetBrains Mono Medium", 15F, System.Drawing.FontStyle.Bold);
            this.b_add.ForeColor = System.Drawing.Color.White;
            this.b_add.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.b_add.ImageKey = "(none)";
            this.b_add.Location = new System.Drawing.Point(93, 507);
            this.b_add.Name = "b_add";
            this.b_add.Padding = new System.Windows.Forms.Padding(3, 0, 0, 0);
            this.b_add.Size = new System.Drawing.Size(271, 104);
            this.b_add.TabIndex = 39;
            this.b_add.Text = "Добавить сотрудника";
            this.b_add.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.b_add.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.b_add.UseVisualStyleBackColor = false;
            this.b_add.Click += new System.EventHandler(this.b_add_Click);
            this.b_add.MouseEnter += new System.EventHandler(this.button_MouseEnter);
            this.b_add.MouseLeave += new System.EventHandler(this.button_MouseLeave);
            // 
            // tb_error
            // 
            this.tb_error.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(4)))), ((int)(((byte)(51)))));
            this.tb_error.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tb_error.Font = new System.Drawing.Font("JetBrains Mono NL Medium", 20F, System.Drawing.FontStyle.Bold);
            this.tb_error.ForeColor = System.Drawing.Color.Orange;
            this.tb_error.Location = new System.Drawing.Point(385, 575);
            this.tb_error.Name = "tb_error";
            this.tb_error.ReadOnly = true;
            this.tb_error.Size = new System.Drawing.Size(675, 36);
            this.tb_error.TabIndex = 40;
            this.tb_error.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // cb_gender
            // 
            this.cb_gender.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(6)))), ((int)(((byte)(42)))));
            this.cb_gender.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_gender.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cb_gender.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.cb_gender.ForeColor = System.Drawing.Color.Crimson;
            this.cb_gender.FormattingEnabled = true;
            this.cb_gender.Items.AddRange(new object[] {
            "М",
            "Ж"});
            this.cb_gender.Location = new System.Drawing.Point(93, 332);
            this.cb_gender.Name = "cb_gender";
            this.cb_gender.Size = new System.Drawing.Size(77, 39);
            this.cb_gender.TabIndex = 41;
            // 
            // cb_doc
            // 
            this.cb_doc.Appearance = System.Windows.Forms.Appearance.Button;
            this.cb_doc.FlatAppearance.BorderColor = System.Drawing.Color.Crimson;
            this.cb_doc.FlatAppearance.BorderSize = 3;
            this.cb_doc.FlatAppearance.CheckedBackColor = System.Drawing.Color.Lime;
            this.cb_doc.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cb_doc.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.cb_doc.Location = new System.Drawing.Point(670, 509);
            this.cb_doc.Name = "cb_doc";
            this.cb_doc.Size = new System.Drawing.Size(30, 30);
            this.cb_doc.TabIndex = 60;
            this.cb_doc.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("JetBrains Mono NL Medium", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Crimson;
            this.label5.Location = new System.Drawing.Point(379, 507);
            this.label5.Margin = new System.Windows.Forms.Padding(25, 25, 25, 5);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(287, 36);
            this.label5.TabIndex = 61;
            this.label5.Text = "Создать документ";
            // 
            // comboBox1
            // 
            this.comboBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(6)))), ((int)(((byte)(42)))));
            this.comboBox1.DataSource = this.штатноеРасписание1BindingSource;
            this.comboBox1.DisplayMember = "Отдел";
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.comboBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.comboBox1.ForeColor = System.Drawing.Color.Crimson;
            this.comboBox1.Location = new System.Drawing.Point(93, 440);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(485, 39);
            this.comboBox1.TabIndex = 62;
            this.comboBox1.ValueMember = "Отдел";
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // штатноеРасписание1BindingSource
            // 
            this.штатноеРасписание1BindingSource.DataMember = "ШтатноеРасписание1";
            this.штатноеРасписание1BindingSource.DataSource = this.courseworkDataSet;
            // 
            // штатноеРасписание1TableAdapter
            // 
            this.штатноеРасписание1TableAdapter.ClearBeforeFill = true;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("JetBrains Mono NL Medium", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Crimson;
            this.label6.Location = new System.Drawing.Point(539, 293);
            this.label6.Margin = new System.Windows.Forms.Padding(25, 25, 25, 5);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(287, 36);
            this.label6.TabIndex = 63;
            this.label6.Text = "Заработная плата";
            // 
            // tb_salary
            // 
            this.tb_salary.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(6)))), ((int)(((byte)(42)))));
            this.tb_salary.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tb_salary.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.moveAdd1BindingSource, "Заработная плата", true));
            this.tb_salary.Font = new System.Drawing.Font("JetBrains Mono NL Medium", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_salary.ForeColor = System.Drawing.Color.Crimson;
            this.tb_salary.Location = new System.Drawing.Point(534, 334);
            this.tb_salary.Margin = new System.Windows.Forms.Padding(20, 0, 20, 0);
            this.tb_salary.Name = "tb_salary";
            this.tb_salary.ReadOnly = true;
            this.tb_salary.Size = new System.Drawing.Size(385, 36);
            this.tb_salary.TabIndex = 64;
            // 
            // moveAdd1TableAdapter
            // 
            this.moveAdd1TableAdapter.ClearBeforeFill = true;
            // 
            // sotr_add
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(4)))), ((int)(((byte)(51)))));
            this.ClientSize = new System.Drawing.Size(1150, 675);
            this.Controls.Add(this.tb_salary);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.cb_doc);
            this.Controls.Add(this.cb_gender);
            this.Controls.Add(this.tb_error);
            this.Controls.Add(this.b_add);
            this.Controls.Add(this.cb_place);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.tb_td);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dtm_birth);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tb_stage);
            this.Controls.Add(this.l_stage);
            this.Controls.Add(this.l_gender);
            this.Controls.Add(this.tb_phone);
            this.Controls.Add(this.l_phone);
            this.Controls.Add(this.tb_mail);
            this.Controls.Add(this.l_mail);
            this.Controls.Add(this.tb_fio);
            this.Controls.Add(this.l_fio);
            this.Controls.Add(this.p_top_menu);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "sotr_add";
            this.Text = "sotr_add";
            this.Load += new System.EventHandler(this.sotr_add_Load);
            this.p_top_menu.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.moveAdd1BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.courseworkDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.штатноеРасписание1BindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel p_top_menu;
        private System.Windows.Forms.Button b_exit;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.TextBox tb_phone;
        private System.Windows.Forms.Label l_phone;
        private System.Windows.Forms.TextBox tb_mail;
        private System.Windows.Forms.Label l_mail;
        private System.Windows.Forms.TextBox tb_fio;
        private System.Windows.Forms.Label l_fio;
        private System.Windows.Forms.Label l_gender;
        private System.Windows.Forms.TextBox tb_stage;
        private System.Windows.Forms.Label l_stage;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dtm_birth;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tb_td;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private CourseworkDataSet courseworkDataSet;
        private System.Windows.Forms.Button b_add;
        private System.Windows.Forms.TextBox tb_error;
        private System.Windows.Forms.ComboBox cb_gender;
        private System.Windows.Forms.ComboBox cb_place;
        private System.Windows.Forms.CheckBox cb_doc;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.BindingSource штатноеРасписание1BindingSource;
        private CourseworkDataSetTableAdapters.ШтатноеРасписание1TableAdapter штатноеРасписание1TableAdapter;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox tb_salary;
        private System.Windows.Forms.BindingSource moveAdd1BindingSource;
        private CourseworkDataSetTableAdapters.MoveAdd1TableAdapter moveAdd1TableAdapter;
    }
}