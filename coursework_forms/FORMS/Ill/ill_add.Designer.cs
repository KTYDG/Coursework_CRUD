namespace coursework_forms.FORMS.sotr {
    partial class ill_add {
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
            this.b_remove = new System.Windows.Forms.Button();
            this.tb_error = new System.Windows.Forms.TextBox();
            this.sotrTableAdapter = new coursework_forms.CourseworkDataSetTableAdapters.SotrTableAdapter();
            this.rtb_reason = new System.Windows.Forms.RichTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tb_place = new System.Windows.Forms.TextBox();
            this.tb_id = new System.Windows.Forms.TextBox();
            this.dtm_date = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.dtm_end = new System.Windows.Forms.DateTimePicker();
            this.cb_end = new System.Windows.Forms.CheckBox();
            this.p_top_menu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.sotrBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.courseworkDataSet)).BeginInit();
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
            this.label4.Location = new System.Drawing.Point(34, 71);
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
            this.cb_sotr.Location = new System.Drawing.Point(109, 110);
            this.cb_sotr.Margin = new System.Windows.Forms.Padding(3, 3, 10, 3);
            this.cb_sotr.MaxDropDownItems = 6;
            this.cb_sotr.Name = "cb_sotr";
            this.cb_sotr.Size = new System.Drawing.Size(508, 39);
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
            // b_remove
            // 
            this.b_remove.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(6)))), ((int)(((byte)(42)))));
            this.b_remove.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(83)))), ((int)(((byte)(16)))), ((int)(((byte)(105)))));
            this.b_remove.FlatAppearance.BorderSize = 0;
            this.b_remove.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.b_remove.Font = new System.Drawing.Font("JetBrains Mono Medium", 16F, System.Drawing.FontStyle.Bold);
            this.b_remove.ForeColor = System.Drawing.Color.White;
            this.b_remove.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.b_remove.ImageKey = "(none)";
            this.b_remove.Location = new System.Drawing.Point(40, 539);
            this.b_remove.Name = "b_remove";
            this.b_remove.Padding = new System.Windows.Forms.Padding(3, 0, 0, 0);
            this.b_remove.Size = new System.Drawing.Size(276, 104);
            this.b_remove.TabIndex = 39;
            this.b_remove.Text = "Добавить";
            this.b_remove.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.b_remove.UseVisualStyleBackColor = false;
            this.b_remove.Click += new System.EventHandler(this.b_add_Click);
            this.b_remove.MouseEnter += new System.EventHandler(this.button_MouseEnter);
            this.b_remove.MouseLeave += new System.EventHandler(this.button_MouseLeave);
            // 
            // tb_error
            // 
            this.tb_error.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(4)))), ((int)(((byte)(51)))));
            this.tb_error.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tb_error.Font = new System.Drawing.Font("JetBrains Mono NL Medium", 22F, System.Drawing.FontStyle.Bold);
            this.tb_error.ForeColor = System.Drawing.Color.Orange;
            this.tb_error.Location = new System.Drawing.Point(344, 569);
            this.tb_error.Name = "tb_error";
            this.tb_error.ReadOnly = true;
            this.tb_error.Size = new System.Drawing.Size(764, 39);
            this.tb_error.TabIndex = 40;
            this.tb_error.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // sotrTableAdapter
            // 
            this.sotrTableAdapter.ClearBeforeFill = true;
            // 
            // rtb_reason
            // 
            this.rtb_reason.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(6)))), ((int)(((byte)(42)))));
            this.rtb_reason.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.rtb_reason.Font = new System.Drawing.Font("JetBrainsMono NF", 15.7F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rtb_reason.ForeColor = System.Drawing.Color.White;
            this.rtb_reason.Location = new System.Drawing.Point(40, 202);
            this.rtb_reason.MaxLength = 255;
            this.rtb_reason.Name = "rtb_reason";
            this.rtb_reason.Size = new System.Drawing.Size(1068, 259);
            this.rtb_reason.TabIndex = 41;
            this.rtb_reason.Text = "";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("JetBrains Mono NL Medium", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Crimson;
            this.label1.Location = new System.Drawing.Point(34, 163);
            this.label1.Margin = new System.Windows.Forms.Padding(25, 10, 3, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(134, 36);
            this.label1.TabIndex = 42;
            this.label1.Text = "Причина";
            // 
            // tb_place
            // 
            this.tb_place.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(6)))), ((int)(((byte)(42)))));
            this.tb_place.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tb_place.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.sotrBindingSource, "Должность", true));
            this.tb_place.Font = new System.Drawing.Font("JetBrains Mono NL Medium", 22F, System.Drawing.FontStyle.Bold);
            this.tb_place.ForeColor = System.Drawing.Color.Crimson;
            this.tb_place.Location = new System.Drawing.Point(627, 110);
            this.tb_place.Margin = new System.Windows.Forms.Padding(0);
            this.tb_place.Name = "tb_place";
            this.tb_place.ReadOnly = true;
            this.tb_place.Size = new System.Drawing.Size(481, 39);
            this.tb_place.TabIndex = 43;
            // 
            // tb_id
            // 
            this.tb_id.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(6)))), ((int)(((byte)(42)))));
            this.tb_id.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tb_id.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.sotrBindingSource, "ID", true));
            this.tb_id.Font = new System.Drawing.Font("JetBrains Mono NL Medium", 22F, System.Drawing.FontStyle.Bold);
            this.tb_id.ForeColor = System.Drawing.Color.Crimson;
            this.tb_id.Location = new System.Drawing.Point(40, 110);
            this.tb_id.Margin = new System.Windows.Forms.Padding(0, 0, 10, 0);
            this.tb_id.Name = "tb_id";
            this.tb_id.ReadOnly = true;
            this.tb_id.Size = new System.Drawing.Size(56, 39);
            this.tb_id.TabIndex = 53;
            // 
            // dtm_date
            // 
            this.dtm_date.CalendarForeColor = System.Drawing.Color.Crimson;
            this.dtm_date.CalendarMonthBackground = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(6)))), ((int)(((byte)(42)))));
            this.dtm_date.CalendarTitleBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(6)))), ((int)(((byte)(42)))));
            this.dtm_date.CalendarTitleForeColor = System.Drawing.Color.Crimson;
            this.dtm_date.CalendarTrailingForeColor = System.Drawing.Color.Crimson;
            this.dtm_date.CustomFormat = "dd.MM.yyyy";
            this.dtm_date.Font = new System.Drawing.Font("Microsoft Sans Serif", 19F);
            this.dtm_date.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtm_date.Location = new System.Drawing.Point(281, 481);
            this.dtm_date.Margin = new System.Windows.Forms.Padding(20, 3, 20, 3);
            this.dtm_date.MaxDate = new System.DateTime(2310, 1, 1, 0, 0, 0, 0);
            this.dtm_date.MinDate = new System.DateTime(1900, 1, 1, 0, 0, 0, 0);
            this.dtm_date.Name = "dtm_date";
            this.dtm_date.Size = new System.Drawing.Size(190, 36);
            this.dtm_date.TabIndex = 54;
            this.dtm_date.Value = new System.DateTime(2022, 12, 3, 0, 0, 0, 0);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("JetBrains Mono NL Medium", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Crimson;
            this.label2.Location = new System.Drawing.Point(34, 481);
            this.label2.Margin = new System.Windows.Forms.Padding(25, 25, 25, 5);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(202, 36);
            this.label2.TabIndex = 55;
            this.label2.Text = "Дата начало";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("JetBrains Mono NL Medium", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Crimson;
            this.label3.Location = new System.Drawing.Point(635, 481);
            this.label3.Margin = new System.Windows.Forms.Padding(25, 25, 25, 5);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(185, 36);
            this.label3.TabIndex = 57;
            this.label3.Text = "Дата конец";
            // 
            // dtm_end
            // 
            this.dtm_end.CalendarForeColor = System.Drawing.Color.Crimson;
            this.dtm_end.CalendarMonthBackground = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(6)))), ((int)(((byte)(42)))));
            this.dtm_end.CalendarTitleBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(6)))), ((int)(((byte)(42)))));
            this.dtm_end.CalendarTitleForeColor = System.Drawing.Color.Crimson;
            this.dtm_end.CalendarTrailingForeColor = System.Drawing.Color.Crimson;
            this.dtm_end.CustomFormat = "dd.MM.yyyy";
            this.dtm_end.Font = new System.Drawing.Font("Microsoft Sans Serif", 19F);
            this.dtm_end.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtm_end.Location = new System.Drawing.Point(865, 481);
            this.dtm_end.Margin = new System.Windows.Forms.Padding(20, 3, 20, 3);
            this.dtm_end.MaxDate = new System.DateTime(2310, 1, 1, 0, 0, 0, 0);
            this.dtm_end.MinDate = new System.DateTime(1900, 1, 1, 0, 0, 0, 0);
            this.dtm_end.Name = "dtm_end";
            this.dtm_end.Size = new System.Drawing.Size(190, 36);
            this.dtm_end.TabIndex = 56;
            this.dtm_end.Value = new System.DateTime(2022, 12, 3, 0, 0, 0, 0);
            // 
            // cb_end
            // 
            this.cb_end.Appearance = System.Windows.Forms.Appearance.Button;
            this.cb_end.Checked = true;
            this.cb_end.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cb_end.FlatAppearance.BorderColor = System.Drawing.Color.Crimson;
            this.cb_end.FlatAppearance.BorderSize = 3;
            this.cb_end.FlatAppearance.CheckedBackColor = System.Drawing.Color.Lime;
            this.cb_end.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cb_end.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.cb_end.Location = new System.Drawing.Point(1078, 483);
            this.cb_end.Name = "cb_end";
            this.cb_end.Size = new System.Drawing.Size(30, 30);
            this.cb_end.TabIndex = 59;
            this.cb_end.UseVisualStyleBackColor = true;
            this.cb_end.Visible = false;
            // 
            // ill_add
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(4)))), ((int)(((byte)(51)))));
            this.ClientSize = new System.Drawing.Size(1150, 675);
            this.Controls.Add(this.cb_end);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.dtm_end);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dtm_date);
            this.Controls.Add(this.tb_id);
            this.Controls.Add(this.tb_place);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.rtb_reason);
            this.Controls.Add(this.tb_error);
            this.Controls.Add(this.b_remove);
            this.Controls.Add(this.cb_sotr);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.p_top_menu);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ill_add";
            this.Text = "sotr_add";
            this.Load += new System.EventHandler(this.sotr_add_Load);
            this.p_top_menu.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.sotrBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.courseworkDataSet)).EndInit();
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
        private System.Windows.Forms.Button b_remove;
        private System.Windows.Forms.TextBox tb_error;
        private System.Windows.Forms.BindingSource sotrBindingSource;
        private CourseworkDataSetTableAdapters.SotrTableAdapter sotrTableAdapter;
        private System.Windows.Forms.RichTextBox rtb_reason;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tb_place;
        private System.Windows.Forms.TextBox tb_id;
        private System.Windows.Forms.DateTimePicker dtm_date;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker dtm_end;
        private System.Windows.Forms.CheckBox cb_end;
    }
}