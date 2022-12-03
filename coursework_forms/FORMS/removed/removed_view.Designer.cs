using System.Windows.Forms;

namespace coursework_forms {
    partial class removed_view {
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
        /// // Handle the BindingComplete event to ensure the two forms
        // remain synchronized.
        private void bindingSource1_BindingComplete(object sender, BindingCompleteEventArgs e) {
            if(e.BindingCompleteContext == BindingCompleteContext.DataSourceUpdate
                && e.Exception == null)
                e.Binding.BindingManagerBase.EndCurrentEdit();
        }
        private void InitializeComponent() {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            this.courseworkDataSet = new coursework_forms.CourseworkDataSet();
            this.b_exit = new System.Windows.Forms.Button();
            this.p_top_menu = new System.Windows.Forms.Panel();
            this.b_options = new System.Windows.Forms.Button();
            this.b_update = new System.Windows.Forms.Button();
            this.p_filter_options = new System.Windows.Forms.Panel();
            this.dgv_sotr = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.фИОDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.датаDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Причина = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.removedBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.removedTableAdapter = new coursework_forms.CourseworkDataSetTableAdapters.RemovedTableAdapter();
            this.panel1 = new System.Windows.Forms.Panel();
            this.rtb_reason = new System.Windows.Forms.RichTextBox();
            this.увольнениеBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.увольнениеTableAdapter = new coursework_forms.CourseworkDataSetTableAdapters.УвольнениеTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.courseworkDataSet)).BeginInit();
            this.p_top_menu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_sotr)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.removedBindingSource)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.увольнениеBindingSource1)).BeginInit();
            this.SuspendLayout();
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
            this.b_exit.MouseLeave += new System.EventHandler(this.b_MouseLeave);
            // 
            // p_top_menu
            // 
            this.p_top_menu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(6)))), ((int)(((byte)(42)))));
            this.p_top_menu.Controls.Add(this.b_options);
            this.p_top_menu.Controls.Add(this.b_update);
            this.p_top_menu.Controls.Add(this.b_exit);
            this.p_top_menu.Dock = System.Windows.Forms.DockStyle.Top;
            this.p_top_menu.Location = new System.Drawing.Point(0, 0);
            this.p_top_menu.Name = "p_top_menu";
            this.p_top_menu.Size = new System.Drawing.Size(1150, 25);
            this.p_top_menu.TabIndex = 7;
            // 
            // b_options
            // 
            this.b_options.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.b_options.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(6)))), ((int)(((byte)(42)))));
            this.b_options.BackgroundImage = global::coursework_forms.Properties.Resources.option;
            this.b_options.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.b_options.Dock = System.Windows.Forms.DockStyle.Left;
            this.b_options.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(83)))), ((int)(((byte)(16)))), ((int)(((byte)(105)))));
            this.b_options.FlatAppearance.BorderSize = 0;
            this.b_options.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.b_options.Font = new System.Drawing.Font("JetBrains Mono Medium", 12F, System.Drawing.FontStyle.Bold);
            this.b_options.ForeColor = System.Drawing.Color.White;
            this.b_options.ImageKey = "(none)";
            this.b_options.Location = new System.Drawing.Point(110, 0);
            this.b_options.Margin = new System.Windows.Forms.Padding(0);
            this.b_options.Name = "b_options";
            this.b_options.Size = new System.Drawing.Size(55, 25);
            this.b_options.TabIndex = 25;
            this.b_options.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.b_options.UseVisualStyleBackColor = false;
            this.b_options.Click += new System.EventHandler(this.b_options_Click);
            this.b_options.MouseEnter += new System.EventHandler(this.b_options_MouseEnter);
            this.b_options.MouseLeave += new System.EventHandler(this.b_MouseLeave);
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
            this.b_update.TabIndex = 24;
            this.b_update.UseVisualStyleBackColor = false;
            this.b_update.Click += new System.EventHandler(this.b_update_Click);
            this.b_update.MouseDown += new System.Windows.Forms.MouseEventHandler(this.b_update_MouseDown);
            this.b_update.MouseEnter += new System.EventHandler(this.b_update_MouseEnter);
            this.b_update.MouseLeave += new System.EventHandler(this.b_update_Leave);
            // 
            // p_filter_options
            // 
            this.p_filter_options.Dock = System.Windows.Forms.DockStyle.Right;
            this.p_filter_options.Location = new System.Drawing.Point(1150, 25);
            this.p_filter_options.Name = "p_filter_options";
            this.p_filter_options.Size = new System.Drawing.Size(0, 650);
            this.p_filter_options.TabIndex = 8;
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
            this.dataGridViewTextBoxColumn1,
            this.фИОDataGridViewTextBoxColumn,
            this.датаDataGridViewTextBoxColumn,
            this.Причина});
            this.dgv_sotr.DataSource = this.removedBindingSource;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(83)))), ((int)(((byte)(16)))), ((int)(((byte)(105)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.Orange;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(83)))), ((int)(((byte)(16)))), ((int)(((byte)(105)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgv_sotr.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgv_sotr.Dock = System.Windows.Forms.DockStyle.Left;
            this.dgv_sotr.EnableHeadersVisualStyles = false;
            this.dgv_sotr.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(83)))), ((int)(((byte)(16)))), ((int)(((byte)(105)))));
            this.dgv_sotr.Location = new System.Drawing.Point(0, 25);
            this.dgv_sotr.Margin = new System.Windows.Forms.Padding(0);
            this.dgv_sotr.Name = "dgv_sotr";
            this.dgv_sotr.ReadOnly = true;
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
            this.dgv_sotr.Size = new System.Drawing.Size(711, 650);
            this.dgv_sotr.TabIndex = 1;
            this.dgv_sotr.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_sotr_CellClick);
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "ID";
            this.dataGridViewTextBoxColumn1.HeaderText = "ID";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            this.dataGridViewTextBoxColumn1.Width = 30;
            // 
            // фИОDataGridViewTextBoxColumn
            // 
            this.фИОDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.фИОDataGridViewTextBoxColumn.DataPropertyName = "ФИО";
            this.фИОDataGridViewTextBoxColumn.HeaderText = "ФИО";
            this.фИОDataGridViewTextBoxColumn.Name = "фИОDataGridViewTextBoxColumn";
            this.фИОDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // датаDataGridViewTextBoxColumn
            // 
            this.датаDataGridViewTextBoxColumn.DataPropertyName = "Дата";
            this.датаDataGridViewTextBoxColumn.HeaderText = "Дата";
            this.датаDataGridViewTextBoxColumn.Name = "датаDataGridViewTextBoxColumn";
            this.датаDataGridViewTextBoxColumn.ReadOnly = true;
            this.датаDataGridViewTextBoxColumn.Width = 110;
            // 
            // Причина
            // 
            this.Причина.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Причина.DataPropertyName = "Причина";
            this.Причина.FillWeight = 90F;
            this.Причина.HeaderText = "Причина";
            this.Причина.Name = "Причина";
            this.Причина.ReadOnly = true;
            // 
            // removedBindingSource
            // 
            this.removedBindingSource.DataMember = "Removed";
            this.removedBindingSource.DataSource = this.courseworkDataSet;
            this.removedBindingSource.BindingComplete += new System.Windows.Forms.BindingCompleteEventHandler(this.bindingSource1_BindingComplete);
            // 
            // removedTableAdapter
            // 
            this.removedTableAdapter.ClearBeforeFill = true;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(6)))), ((int)(((byte)(42)))));
            this.panel1.Controls.Add(this.rtb_reason);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(711, 25);
            this.panel1.Name = "panel1";
            this.panel1.Padding = new System.Windows.Forms.Padding(15, 50, 15, 15);
            this.panel1.Size = new System.Drawing.Size(439, 650);
            this.panel1.TabIndex = 43;
            // 
            // rtb_reason
            // 
            this.rtb_reason.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(6)))), ((int)(((byte)(42)))));
            this.rtb_reason.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.rtb_reason.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.removedBindingSource, "Причина", true));
            this.rtb_reason.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rtb_reason.Font = new System.Drawing.Font("JetBrainsMono NF", 14F, System.Drawing.FontStyle.Bold);
            this.rtb_reason.ForeColor = System.Drawing.Color.White;
            this.rtb_reason.Location = new System.Drawing.Point(15, 50);
            this.rtb_reason.Margin = new System.Windows.Forms.Padding(5);
            this.rtb_reason.MaxLength = 256;
            this.rtb_reason.Name = "rtb_reason";
            this.rtb_reason.Size = new System.Drawing.Size(409, 585);
            this.rtb_reason.TabIndex = 43;
            this.rtb_reason.Text = "";
            // 
            // увольнениеBindingSource1
            // 
            this.увольнениеBindingSource1.DataMember = "Увольнение";
            this.увольнениеBindingSource1.DataSource = this.courseworkDataSet;
            // 
            // увольнениеTableAdapter
            // 
            this.увольнениеTableAdapter.ClearBeforeFill = true;
            // 
            // removed_view
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(4)))), ((int)(((byte)(51)))));
            this.ClientSize = new System.Drawing.Size(1150, 675);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.dgv_sotr);
            this.Controls.Add(this.p_filter_options);
            this.Controls.Add(this.p_top_menu);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "removed_view";
            this.Text = "sotr_view";
            this.Load += new System.EventHandler(this.sotr_view_Load);
            ((System.ComponentModel.ISupportInitialize)(this.courseworkDataSet)).EndInit();
            this.p_top_menu.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_sotr)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.removedBindingSource)).EndInit();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.увольнениеBindingSource1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button b_exit;
        private System.Windows.Forms.Panel p_top_menu;
        private CourseworkDataSet courseworkDataSet;
        private System.Windows.Forms.Panel p_filter_options;
        private System.Windows.Forms.DataGridView dgv_sotr;
        public System.Windows.Forms.BindingSource removedBindingSource;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.RichTextBox rtb_reason;
        private System.Windows.Forms.Button b_update;
        public CourseworkDataSetTableAdapters.RemovedTableAdapter removedTableAdapter;
        private CourseworkDataSetTableAdapters.УвольнениеTableAdapter увольнениеTableAdapter;
        private System.Windows.Forms.BindingSource увольнениеBindingSource1;
        private System.Windows.Forms.DataGridViewTextBoxColumn idсотрудникDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button b_options;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private DataGridViewTextBoxColumn фИОDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn датаDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn Причина;
    }
}