namespace coursework_forms {
    partial class timetable {
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dgv_sotr = new System.Windows.Forms.DataGridView();
            this.штатноеРасписаниеBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.courseworkDataSet = new coursework_forms.CourseworkDataSet();
            this.b_exit = new System.Windows.Forms.Button();
            this.p_top_menu = new System.Windows.Forms.Panel();
            this.b_update = new System.Windows.Forms.Button();
            this.tableAdapterManager = new coursework_forms.CourseworkDataSetTableAdapters.TableAdapterManager();
            this.штатноеРасписаниеTableAdapter = new coursework_forms.CourseworkDataSetTableAdapters.ШтатноеРасписаниеTableAdapter();
            this.idдолжностьDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.отделDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.должностьDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.количествоМестDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.количествоСотрудниковDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_sotr)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.штатноеРасписаниеBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.courseworkDataSet)).BeginInit();
            this.p_top_menu.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgv_sotr
            // 
            this.dgv_sotr.AllowUserToAddRows = false;
            this.dgv_sotr.AllowUserToDeleteRows = false;
            this.dgv_sotr.AllowUserToResizeColumns = false;
            this.dgv_sotr.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(83)))), ((int)(((byte)(16)))), ((int)(((byte)(105)))));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.Orange;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(83)))), ((int)(((byte)(16)))), ((int)(((byte)(105)))));
            this.dgv_sotr.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgv_sotr.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgv_sotr.AutoGenerateColumns = false;
            this.dgv_sotr.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(4)))), ((int)(((byte)(51)))));
            this.dgv_sotr.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgv_sotr.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dgv_sotr.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(83)))), ((int)(((byte)(16)))), ((int)(((byte)(105)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.Orange;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(83)))), ((int)(((byte)(16)))), ((int)(((byte)(105)))));
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_sotr.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgv_sotr.ColumnHeadersHeight = 40;
            this.dgv_sotr.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgv_sotr.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idдолжностьDataGridViewTextBoxColumn,
            this.отделDataGridViewTextBoxColumn,
            this.должностьDataGridViewTextBoxColumn,
            this.количествоМестDataGridViewTextBoxColumn,
            this.количествоСотрудниковDataGridViewTextBoxColumn,
            this.dataGridViewTextBoxColumn1});
            this.dgv_sotr.DataSource = this.штатноеРасписаниеBindingSource;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(83)))), ((int)(((byte)(16)))), ((int)(((byte)(105)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.Orange;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(83)))), ((int)(((byte)(16)))), ((int)(((byte)(105)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgv_sotr.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgv_sotr.EnableHeadersVisualStyles = false;
            this.dgv_sotr.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(83)))), ((int)(((byte)(16)))), ((int)(((byte)(105)))));
            this.dgv_sotr.Location = new System.Drawing.Point(-1, 25);
            this.dgv_sotr.Margin = new System.Windows.Forms.Padding(0);
            this.dgv_sotr.Name = "dgv_sotr";
            this.dgv_sotr.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(83)))), ((int)(((byte)(16)))), ((int)(((byte)(105)))));
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.Orange;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(83)))), ((int)(((byte)(16)))), ((int)(((byte)(105)))));
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_sotr.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dgv_sotr.RowHeadersVisible = false;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(83)))), ((int)(((byte)(16)))), ((int)(((byte)(105)))));
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.Orange;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(83)))), ((int)(((byte)(16)))), ((int)(((byte)(105)))));
            this.dgv_sotr.RowsDefaultCellStyle = dataGridViewCellStyle5;
            this.dgv_sotr.RowTemplate.DefaultCellStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(83)))), ((int)(((byte)(16)))), ((int)(((byte)(105)))));
            this.dgv_sotr.RowTemplate.DefaultCellStyle.ForeColor = System.Drawing.Color.White;
            this.dgv_sotr.RowTemplate.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.Orange;
            this.dgv_sotr.RowTemplate.DefaultCellStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(83)))), ((int)(((byte)(16)))), ((int)(((byte)(105)))));
            this.dgv_sotr.Size = new System.Drawing.Size(1150, 647);
            this.dgv_sotr.TabIndex = 0;
            this.dgv_sotr.CellBeginEdit += new System.Windows.Forms.DataGridViewCellCancelEventHandler(this.dgv_sotr_CellBeginEdit);
            this.dgv_sotr.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_sotr_CellEndEdit);
            this.dgv_sotr.DataError += new System.Windows.Forms.DataGridViewDataErrorEventHandler(this.drg_DataError);
            // 
            // штатноеРасписаниеBindingSource
            // 
            this.штатноеРасписаниеBindingSource.DataMember = "ШтатноеРасписание";
            this.штатноеРасписаниеBindingSource.DataSource = this.courseworkDataSet;
            // 
            // courseworkDataSet
            // 
            this.courseworkDataSet.DataSetName = "CourseworkDataSet";
            this.courseworkDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
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
            // p_top_menu
            // 
            this.p_top_menu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(6)))), ((int)(((byte)(42)))));
            this.p_top_menu.Controls.Add(this.b_update);
            this.p_top_menu.Controls.Add(this.b_exit);
            this.p_top_menu.Dock = System.Windows.Forms.DockStyle.Top;
            this.p_top_menu.Location = new System.Drawing.Point(0, 0);
            this.p_top_menu.Name = "p_top_menu";
            this.p_top_menu.Size = new System.Drawing.Size(1150, 25);
            this.p_top_menu.TabIndex = 7;
            // 
            // b_update
            // 
            this.b_update.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.b_update.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(6)))), ((int)(((byte)(42)))));
            this.b_update.BackgroundImage = global::coursework_forms.Properties.Resources.refresh;
            this.b_update.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.b_update.Dock = System.Windows.Forms.DockStyle.Left;
            this.b_update.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(4)))), ((int)(((byte)(51)))));
            this.b_update.FlatAppearance.BorderSize = 0;
            this.b_update.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(4)))), ((int)(((byte)(51)))));
            this.b_update.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(4)))), ((int)(((byte)(51)))));
            this.b_update.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.b_update.Font = new System.Drawing.Font("JetBrains Mono Medium", 12F, System.Drawing.FontStyle.Bold);
            this.b_update.ForeColor = System.Drawing.Color.White;
            this.b_update.ImageKey = "(none)";
            this.b_update.Location = new System.Drawing.Point(55, 0);
            this.b_update.Margin = new System.Windows.Forms.Padding(0);
            this.b_update.Name = "b_update";
            this.b_update.Size = new System.Drawing.Size(55, 25);
            this.b_update.TabIndex = 23;
            this.b_update.UseVisualStyleBackColor = false;
            this.b_update.Click += new System.EventHandler(this.b_update_Click);
            this.b_update.MouseDown += new System.Windows.Forms.MouseEventHandler(this.b_update_MouseDown);
            this.b_update.MouseEnter += new System.EventHandler(this.b_update_MouseEnter);
            this.b_update.MouseLeave += new System.EventHandler(this.b_update_Leave);
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.UpdateOrder = coursework_forms.CourseworkDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.АттестацияTableAdapter = null;
            this.tableAdapterManager.БольничныйTableAdapter = null;
            this.tableAdapterManager.ОтпускTableAdapter = null;
            this.tableAdapterManager.ПользовательTableAdapter = null;
            this.tableAdapterManager.ПрогулTableAdapter = null;
            this.tableAdapterManager.СотрудникTableAdapter = null;
            this.tableAdapterManager.УвольнениеTableAdapter = null;
            this.tableAdapterManager.ШтатноеРасписаниеTableAdapter = this.штатноеРасписаниеTableAdapter;
            // 
            // штатноеРасписаниеTableAdapter
            // 
            this.штатноеРасписаниеTableAdapter.ClearBeforeFill = true;
            // 
            // idдолжностьDataGridViewTextBoxColumn
            // 
            this.idдолжностьDataGridViewTextBoxColumn.DataPropertyName = "id_должность";
            this.idдолжностьDataGridViewTextBoxColumn.HeaderText = "ID";
            this.idдолжностьDataGridViewTextBoxColumn.Name = "idдолжностьDataGridViewTextBoxColumn";
            this.idдолжностьDataGridViewTextBoxColumn.ReadOnly = true;
            this.idдолжностьDataGridViewTextBoxColumn.Width = 30;
            // 
            // отделDataGridViewTextBoxColumn
            // 
            this.отделDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.отделDataGridViewTextBoxColumn.DataPropertyName = "Отдел";
            this.отделDataGridViewTextBoxColumn.HeaderText = "Отдел";
            this.отделDataGridViewTextBoxColumn.Name = "отделDataGridViewTextBoxColumn";
            // 
            // должностьDataGridViewTextBoxColumn
            // 
            this.должностьDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.должностьDataGridViewTextBoxColumn.DataPropertyName = "Должность";
            this.должностьDataGridViewTextBoxColumn.HeaderText = "Должность";
            this.должностьDataGridViewTextBoxColumn.Name = "должностьDataGridViewTextBoxColumn";
            // 
            // количествоМестDataGridViewTextBoxColumn
            // 
            this.количествоМестDataGridViewTextBoxColumn.DataPropertyName = "Количество мест";
            this.количествоМестDataGridViewTextBoxColumn.HeaderText = "Кол-во мест";
            this.количествоМестDataGridViewTextBoxColumn.Name = "количествоМестDataGridViewTextBoxColumn";
            this.количествоМестDataGridViewTextBoxColumn.Width = 120;
            // 
            // количествоСотрудниковDataGridViewTextBoxColumn
            // 
            this.количествоСотрудниковDataGridViewTextBoxColumn.DataPropertyName = "Количество сотрудников";
            this.количествоСотрудниковDataGridViewTextBoxColumn.HeaderText = "Кол-во сотрудников";
            this.количествоСотрудниковDataGridViewTextBoxColumn.Name = "количествоСотрудниковDataGridViewTextBoxColumn";
            this.количествоСотрудниковDataGridViewTextBoxColumn.Width = 140;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.dataGridViewTextBoxColumn1.DataPropertyName = "Заработная плата";
            this.dataGridViewTextBoxColumn1.HeaderText = "Заработная плата";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.Width = 83;
            // 
            // timetable
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(4)))), ((int)(((byte)(51)))));
            this.ClientSize = new System.Drawing.Size(1150, 675);
            this.Controls.Add(this.p_top_menu);
            this.Controls.Add(this.dgv_sotr);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "timetable";
            this.Text = "sotr_view";
            this.Load += new System.EventHandler(this.sotr_view_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_sotr)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.штатноеРасписаниеBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.courseworkDataSet)).EndInit();
            this.p_top_menu.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgv_sotr;
        private System.Windows.Forms.Button b_exit;
        private System.Windows.Forms.Panel p_top_menu;
        private CourseworkDataSet courseworkDataSet;
        private CourseworkDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.Button b_update;
        private System.Windows.Forms.BindingSource штатноеРасписаниеBindingSource;
        private CourseworkDataSetTableAdapters.ШтатноеРасписаниеTableAdapter штатноеРасписаниеTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn idдолжностьDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn отделDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn должностьDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn количествоМестDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn количествоСотрудниковDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
    }
}