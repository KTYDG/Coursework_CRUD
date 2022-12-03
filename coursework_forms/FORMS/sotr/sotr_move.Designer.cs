namespace coursework_forms.FORMS.sotr {
    partial class sotr_move {
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
            this.label4 = new System.Windows.Forms.Label();
            this.cb_sotr = new System.Windows.Forms.ComboBox();
            this.sotrBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.courseworkDataSet = new coursework_forms.CourseworkDataSet();
            this.b_move = new System.Windows.Forms.Button();
            this.tb_error = new System.Windows.Forms.TextBox();
            this.sotrTableAdapter = new coursework_forms.CourseworkDataSetTableAdapters.SotrTableAdapter();
            this.tb_place = new System.Windows.Forms.TextBox();
            this.cb_place = new System.Windows.Forms.ComboBox();
            this.штатноеРасписаниеBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.штатноеРасписаниеTableAdapter = new coursework_forms.CourseworkDataSetTableAdapters.ШтатноеРасписаниеTableAdapter();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.tb_salary = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.p_top_menu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.sotrBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.courseworkDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.штатноеРасписаниеBindingSource)).BeginInit();
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
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("JetBrains Mono NL Medium", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Crimson;
            this.label4.Location = new System.Drawing.Point(34, 97);
            this.label4.Margin = new System.Windows.Forms.Padding(25, 10, 3, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(168, 36);
            this.label4.TabIndex = 37;
            this.label4.Text = "Сотрудник";
            // 
            // cb_sotr
            // 
            this.cb_sotr.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cb_sotr.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cb_sotr.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(6)))), ((int)(((byte)(42)))));
            this.cb_sotr.DataSource = this.sotrBindingSource;
            this.cb_sotr.DisplayMember = "ФИО";
            this.cb_sotr.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cb_sotr.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.cb_sotr.ForeColor = System.Drawing.Color.Crimson;
            this.cb_sotr.FormattingEnabled = true;
            this.cb_sotr.Location = new System.Drawing.Point(109, 145);
            this.cb_sotr.MaxDropDownItems = 6;
            this.cb_sotr.Name = "cb_sotr";
            this.cb_sotr.Size = new System.Drawing.Size(615, 39);
            this.cb_sotr.TabIndex = 38;
            this.cb_sotr.ValueMember = "ID";
            // 
            // sotrBindingSource
            // 
            this.sotrBindingSource.DataMember = "Sotr";
            this.sotrBindingSource.DataSource = this.courseworkDataSet;
            // 
            // courseworkDataSet
            // 
            this.courseworkDataSet.DataSetName = "CourseworkDataSet";
            this.courseworkDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // b_move
            // 
            this.b_move.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(6)))), ((int)(((byte)(42)))));
            this.b_move.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(83)))), ((int)(((byte)(16)))), ((int)(((byte)(105)))));
            this.b_move.FlatAppearance.BorderSize = 0;
            this.b_move.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.b_move.Font = new System.Drawing.Font("JetBrains Mono Medium", 16F, System.Drawing.FontStyle.Bold);
            this.b_move.ForeColor = System.Drawing.Color.White;
            this.b_move.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.b_move.ImageKey = "(none)";
            this.b_move.Location = new System.Drawing.Point(40, 489);
            this.b_move.Name = "b_move";
            this.b_move.Padding = new System.Windows.Forms.Padding(3, 0, 0, 0);
            this.b_move.Size = new System.Drawing.Size(306, 104);
            this.b_move.TabIndex = 39;
            this.b_move.Text = "Перевести сотрудника";
            this.b_move.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.b_move.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.b_move.UseVisualStyleBackColor = false;
            this.b_move.Click += new System.EventHandler(this.b_move_Click);
            this.b_move.MouseEnter += new System.EventHandler(this.button_MouseEnter);
            this.b_move.MouseLeave += new System.EventHandler(this.button_MouseLeave);
            // 
            // tb_error
            // 
            this.tb_error.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(4)))), ((int)(((byte)(51)))));
            this.tb_error.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tb_error.Font = new System.Drawing.Font("JetBrains Mono NL Medium", 24F, System.Drawing.FontStyle.Bold);
            this.tb_error.ForeColor = System.Drawing.Color.Orange;
            this.tb_error.Location = new System.Drawing.Point(352, 516);
            this.tb_error.Name = "tb_error";
            this.tb_error.ReadOnly = true;
            this.tb_error.Size = new System.Drawing.Size(756, 43);
            this.tb_error.TabIndex = 40;
            this.tb_error.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // sotrTableAdapter
            // 
            this.sotrTableAdapter.ClearBeforeFill = true;
            // 
            // tb_place
            // 
            this.tb_place.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(6)))), ((int)(((byte)(42)))));
            this.tb_place.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tb_place.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.sotrBindingSource, "Должность", true));
            this.tb_place.Font = new System.Drawing.Font("JetBrains Mono NL Medium", 22F, System.Drawing.FontStyle.Bold);
            this.tb_place.ForeColor = System.Drawing.Color.Crimson;
            this.tb_place.Location = new System.Drawing.Point(40, 253);
            this.tb_place.Margin = new System.Windows.Forms.Padding(0);
            this.tb_place.Name = "tb_place";
            this.tb_place.ReadOnly = true;
            this.tb_place.Size = new System.Drawing.Size(481, 39);
            this.tb_place.TabIndex = 43;
            // 
            // cb_place
            // 
            this.cb_place.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(6)))), ((int)(((byte)(42)))));
            this.cb_place.DataSource = this.штатноеРасписаниеBindingSource;
            this.cb_place.DisplayMember = "Должность";
            this.cb_place.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_place.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cb_place.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.cb_place.ForeColor = System.Drawing.Color.Crimson;
            this.cb_place.FormattingEnabled = true;
            this.cb_place.Location = new System.Drawing.Point(618, 253);
            this.cb_place.MaxDropDownItems = 6;
            this.cb_place.Name = "cb_place";
            this.cb_place.Size = new System.Drawing.Size(490, 39);
            this.cb_place.TabIndex = 44;
            this.cb_place.ValueMember = "id_должность";
            // 
            // штатноеРасписаниеBindingSource
            // 
            this.штатноеРасписаниеBindingSource.DataMember = "ШтатноеРасписание";
            this.штатноеРасписаниеBindingSource.DataSource = this.courseworkDataSet;
            // 
            // штатноеРасписаниеTableAdapter
            // 
            this.штатноеРасписаниеTableAdapter.ClearBeforeFill = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("JetBrains Mono NL Medium", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Crimson;
            this.label1.Location = new System.Drawing.Point(555, 256);
            this.label1.Margin = new System.Windows.Forms.Padding(25, 10, 3, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(32, 36);
            this.label1.TabIndex = 45;
            this.label1.Text = "В";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("JetBrains Mono NL Medium", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Crimson;
            this.label2.Location = new System.Drawing.Point(34, 217);
            this.label2.Margin = new System.Windows.Forms.Padding(25, 10, 3, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(168, 36);
            this.label2.TabIndex = 46;
            this.label2.Text = "Должность";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("JetBrains Mono NL Medium", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Crimson;
            this.label3.Location = new System.Drawing.Point(34, 331);
            this.label3.Margin = new System.Windows.Forms.Padding(25, 10, 3, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(287, 36);
            this.label3.TabIndex = 49;
            this.label3.Text = "Заработная плата";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("JetBrains Mono NL Medium", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Crimson;
            this.label5.Location = new System.Drawing.Point(555, 370);
            this.label5.Margin = new System.Windows.Forms.Padding(25, 10, 3, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(32, 36);
            this.label5.TabIndex = 48;
            this.label5.Text = "В";
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(6)))), ((int)(((byte)(42)))));
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.sotrBindingSource, "ЗП", true));
            this.textBox1.Font = new System.Drawing.Font("JetBrains Mono NL Medium", 22F, System.Drawing.FontStyle.Bold);
            this.textBox1.ForeColor = System.Drawing.Color.Crimson;
            this.textBox1.Location = new System.Drawing.Point(40, 367);
            this.textBox1.Margin = new System.Windows.Forms.Padding(0);
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(481, 39);
            this.textBox1.TabIndex = 47;
            // 
            // tb_salary
            // 
            this.tb_salary.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(6)))), ((int)(((byte)(42)))));
            this.tb_salary.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tb_salary.Font = new System.Drawing.Font("JetBrains Mono NL Medium", 22F, System.Drawing.FontStyle.Bold);
            this.tb_salary.ForeColor = System.Drawing.Color.Crimson;
            this.tb_salary.Location = new System.Drawing.Point(618, 367);
            this.tb_salary.Margin = new System.Windows.Forms.Padding(0);
            this.tb_salary.Name = "tb_salary";
            this.tb_salary.Size = new System.Drawing.Size(490, 39);
            this.tb_salary.TabIndex = 50;
            this.tb_salary.TextChanged += new System.EventHandler(this.tb_salary_TextChanged);
            // 
            // textBox2
            // 
            this.textBox2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(6)))), ((int)(((byte)(42)))));
            this.textBox2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox2.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.sotrBindingSource, "ID", true));
            this.textBox2.Font = new System.Drawing.Font("JetBrains Mono NL Medium", 22F, System.Drawing.FontStyle.Bold);
            this.textBox2.ForeColor = System.Drawing.Color.Crimson;
            this.textBox2.Location = new System.Drawing.Point(40, 144);
            this.textBox2.Margin = new System.Windows.Forms.Padding(0, 0, 10, 0);
            this.textBox2.Name = "textBox2";
            this.textBox2.ReadOnly = true;
            this.textBox2.Size = new System.Drawing.Size(56, 39);
            this.textBox2.TabIndex = 51;
            // 
            // sotr_move
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(4)))), ((int)(((byte)(51)))));
            this.ClientSize = new System.Drawing.Size(1150, 675);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.tb_salary);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cb_place);
            this.Controls.Add(this.tb_place);
            this.Controls.Add(this.tb_error);
            this.Controls.Add(this.b_move);
            this.Controls.Add(this.cb_sotr);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.p_top_menu);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "sotr_move";
            this.Text = "sotr_add";
            this.Load += new System.EventHandler(this.sotr_add_Load);
            this.p_top_menu.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.sotrBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.courseworkDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.штатноеРасписаниеBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel p_top_menu;
        private System.Windows.Forms.Button b_exit;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cb_sotr;
        private CourseworkDataSet courseworkDataSet;
        private System.Windows.Forms.Button b_move;
        private System.Windows.Forms.TextBox tb_error;
        private System.Windows.Forms.BindingSource sotrBindingSource;
        private CourseworkDataSetTableAdapters.SotrTableAdapter sotrTableAdapter;
        private System.Windows.Forms.TextBox tb_place;
        private System.Windows.Forms.ComboBox cb_place;
        private System.Windows.Forms.BindingSource штатноеРасписаниеBindingSource;
        private CourseworkDataSetTableAdapters.ШтатноеРасписаниеTableAdapter штатноеРасписаниеTableAdapter;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox tb_salary;
        private System.Windows.Forms.TextBox textBox2;
    }
}