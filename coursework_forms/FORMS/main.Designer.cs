namespace coursework_forms {
    partial class main {
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(main));
            this.p_top_menu = new System.Windows.Forms.Panel();
            this.p_side_menu = new System.Windows.Forms.Panel();
            this.AttesSubPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.b_attes_view = new System.Windows.Forms.Button();
            this.b_attes_add = new System.Windows.Forms.Button();
            this.b_attes = new System.Windows.Forms.Button();
            this.b_tt = new System.Windows.Forms.Button();
            this.RemovedSubPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.b_removed_view = new System.Windows.Forms.Button();
            this.b_removed_remove = new System.Windows.Forms.Button();
            this.b_removed_restore = new System.Windows.Forms.Button();
            this.b_removed_delete = new System.Windows.Forms.Button();
            this.b_removed = new System.Windows.Forms.Button();
            this.SotrSubPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.b_sotr_view = new System.Windows.Forms.Button();
            this.b_sotr_edit = new System.Windows.Forms.Button();
            this.b_sotr_add = new System.Windows.Forms.Button();
            this.b_sotr_move = new System.Windows.Forms.Button();
            this.b_sotr = new System.Windows.Forms.Button();
            this.b_profile = new System.Windows.Forms.Button();
            this.p_form_view = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.b_exit = new System.Windows.Forms.Button();
            this.p_top_menu.SuspendLayout();
            this.p_side_menu.SuspendLayout();
            this.AttesSubPanel.SuspendLayout();
            this.RemovedSubPanel.SuspendLayout();
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
            this.p_top_menu.Size = new System.Drawing.Size(1315, 25);
            this.p_top_menu.TabIndex = 0;
            this.p_top_menu.MouseMove += new System.Windows.Forms.MouseEventHandler(this.p_top_menu_MouseMove);
            // 
            // p_side_menu
            // 
            this.p_side_menu.AutoScroll = true;
            this.p_side_menu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(2)))), ((int)(((byte)(30)))));
            this.p_side_menu.Controls.Add(this.AttesSubPanel);
            this.p_side_menu.Controls.Add(this.b_attes);
            this.p_side_menu.Controls.Add(this.b_tt);
            this.p_side_menu.Controls.Add(this.RemovedSubPanel);
            this.p_side_menu.Controls.Add(this.b_removed);
            this.p_side_menu.Controls.Add(this.SotrSubPanel);
            this.p_side_menu.Controls.Add(this.b_sotr);
            this.p_side_menu.Controls.Add(this.b_profile);
            this.p_side_menu.Dock = System.Windows.Forms.DockStyle.Left;
            this.p_side_menu.Location = new System.Drawing.Point(0, 25);
            this.p_side_menu.Name = "p_side_menu";
            this.p_side_menu.Size = new System.Drawing.Size(165, 675);
            this.p_side_menu.TabIndex = 2;
            // 
            // AttesSubPanel
            // 
            this.AttesSubPanel.AutoSize = true;
            this.AttesSubPanel.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.AttesSubPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(3)))), ((int)(((byte)(28)))));
            this.AttesSubPanel.Controls.Add(this.b_attes_view);
            this.AttesSubPanel.Controls.Add(this.b_attes_add);
            this.AttesSubPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.AttesSubPanel.Location = new System.Drawing.Point(0, 545);
            this.AttesSubPanel.Name = "AttesSubPanel";
            this.AttesSubPanel.Size = new System.Drawing.Size(165, 80);
            this.AttesSubPanel.TabIndex = 13;
            this.AttesSubPanel.Visible = false;
            // 
            // b_attes_view
            // 
            this.b_attes_view.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(1)))), ((int)(((byte)(20)))));
            this.b_attes_view.Dock = System.Windows.Forms.DockStyle.Top;
            this.b_attes_view.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(6)))), ((int)(((byte)(64)))));
            this.b_attes_view.FlatAppearance.BorderSize = 0;
            this.b_attes_view.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.b_attes_view.Font = new System.Drawing.Font("JetBrains Mono Medium", 10F, System.Drawing.FontStyle.Bold);
            this.b_attes_view.ForeColor = System.Drawing.Color.White;
            this.b_attes_view.ImageKey = "(none)";
            this.b_attes_view.Location = new System.Drawing.Point(0, 0);
            this.b_attes_view.Margin = new System.Windows.Forms.Padding(0);
            this.b_attes_view.Name = "b_attes_view";
            this.b_attes_view.Padding = new System.Windows.Forms.Padding(15, 0, 0, 0);
            this.b_attes_view.Size = new System.Drawing.Size(165, 40);
            this.b_attes_view.TabIndex = 15;
            this.b_attes_view.Text = "Список";
            this.b_attes_view.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.b_attes_view.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.b_attes_view.UseVisualStyleBackColor = false;
            this.b_attes_view.Click += new System.EventHandler(this.b_attes_view_Click);
            this.b_attes_view.MouseEnter += new System.EventHandler(this.button_MouseEnter);
            this.b_attes_view.MouseLeave += new System.EventHandler(this.button_MouseLeave);
            // 
            // b_attes_add
            // 
            this.b_attes_add.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(1)))), ((int)(((byte)(20)))));
            this.b_attes_add.Dock = System.Windows.Forms.DockStyle.Top;
            this.b_attes_add.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(6)))), ((int)(((byte)(64)))));
            this.b_attes_add.FlatAppearance.BorderSize = 0;
            this.b_attes_add.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.b_attes_add.Font = new System.Drawing.Font("JetBrains Mono Medium", 10F, System.Drawing.FontStyle.Bold);
            this.b_attes_add.ForeColor = System.Drawing.Color.White;
            this.b_attes_add.ImageKey = "(none)";
            this.b_attes_add.Location = new System.Drawing.Point(0, 40);
            this.b_attes_add.Margin = new System.Windows.Forms.Padding(0);
            this.b_attes_add.Name = "b_attes_add";
            this.b_attes_add.Padding = new System.Windows.Forms.Padding(15, 0, 0, 0);
            this.b_attes_add.Size = new System.Drawing.Size(165, 40);
            this.b_attes_add.TabIndex = 16;
            this.b_attes_add.Text = "Добавить";
            this.b_attes_add.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.b_attes_add.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.b_attes_add.UseVisualStyleBackColor = false;
            this.b_attes_add.MouseEnter += new System.EventHandler(this.button_MouseEnter);
            this.b_attes_add.MouseLeave += new System.EventHandler(this.button_MouseLeave);
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
            this.b_attes.Location = new System.Drawing.Point(0, 500);
            this.b_attes.Margin = new System.Windows.Forms.Padding(0);
            this.b_attes.Name = "b_attes";
            this.b_attes.Padding = new System.Windows.Forms.Padding(3, 0, 0, 0);
            this.b_attes.Size = new System.Drawing.Size(165, 45);
            this.b_attes.TabIndex = 12;
            this.b_attes.Text = "Аттестация";
            this.b_attes.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.b_attes.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.b_attes.UseVisualStyleBackColor = false;
            this.b_attes.Click += new System.EventHandler(this.b_attes_Click);
            this.b_attes.MouseEnter += new System.EventHandler(this.button_MouseEnter);
            this.b_attes.MouseLeave += new System.EventHandler(this.button_MouseLeave);
            // 
            // b_tt
            // 
            this.b_tt.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(2)))), ((int)(((byte)(30)))));
            this.b_tt.Dock = System.Windows.Forms.DockStyle.Top;
            this.b_tt.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(83)))), ((int)(((byte)(16)))), ((int)(((byte)(105)))));
            this.b_tt.FlatAppearance.BorderSize = 0;
            this.b_tt.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.b_tt.Font = new System.Drawing.Font("JetBrains Mono Medium", 14F, System.Drawing.FontStyle.Bold);
            this.b_tt.ForeColor = System.Drawing.Color.White;
            this.b_tt.ImageKey = "(none)";
            this.b_tt.Location = new System.Drawing.Point(0, 455);
            this.b_tt.Margin = new System.Windows.Forms.Padding(0);
            this.b_tt.Name = "b_tt";
            this.b_tt.Padding = new System.Windows.Forms.Padding(3, 0, 0, 0);
            this.b_tt.Size = new System.Drawing.Size(165, 45);
            this.b_tt.TabIndex = 10;
            this.b_tt.Text = "ШР";
            this.b_tt.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.b_tt.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.b_tt.UseVisualStyleBackColor = false;
            this.b_tt.Click += new System.EventHandler(this.b_tt_Click);
            this.b_tt.MouseEnter += new System.EventHandler(this.button_MouseEnter);
            this.b_tt.MouseLeave += new System.EventHandler(this.button_MouseLeave);
            // 
            // RemovedSubPanel
            // 
            this.RemovedSubPanel.AutoSize = true;
            this.RemovedSubPanel.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.RemovedSubPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(3)))), ((int)(((byte)(28)))));
            this.RemovedSubPanel.Controls.Add(this.b_removed_view);
            this.RemovedSubPanel.Controls.Add(this.b_removed_remove);
            this.RemovedSubPanel.Controls.Add(this.b_removed_restore);
            this.RemovedSubPanel.Controls.Add(this.b_removed_delete);
            this.RemovedSubPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.RemovedSubPanel.Location = new System.Drawing.Point(0, 295);
            this.RemovedSubPanel.Name = "RemovedSubPanel";
            this.RemovedSubPanel.Size = new System.Drawing.Size(165, 160);
            this.RemovedSubPanel.TabIndex = 4;
            this.RemovedSubPanel.Visible = false;
            // 
            // b_removed_view
            // 
            this.b_removed_view.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(1)))), ((int)(((byte)(20)))));
            this.b_removed_view.Dock = System.Windows.Forms.DockStyle.Top;
            this.b_removed_view.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(6)))), ((int)(((byte)(64)))));
            this.b_removed_view.FlatAppearance.BorderSize = 0;
            this.b_removed_view.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.b_removed_view.Font = new System.Drawing.Font("JetBrains Mono Medium", 10F, System.Drawing.FontStyle.Bold);
            this.b_removed_view.ForeColor = System.Drawing.Color.White;
            this.b_removed_view.ImageKey = "(none)";
            this.b_removed_view.Location = new System.Drawing.Point(0, 0);
            this.b_removed_view.Margin = new System.Windows.Forms.Padding(0);
            this.b_removed_view.Name = "b_removed_view";
            this.b_removed_view.Padding = new System.Windows.Forms.Padding(15, 0, 0, 0);
            this.b_removed_view.Size = new System.Drawing.Size(165, 40);
            this.b_removed_view.TabIndex = 2;
            this.b_removed_view.Text = "Список";
            this.b_removed_view.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.b_removed_view.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.b_removed_view.UseVisualStyleBackColor = false;
            this.b_removed_view.Click += new System.EventHandler(this.b_removed_view_Click);
            this.b_removed_view.MouseEnter += new System.EventHandler(this.button_MouseEnter);
            this.b_removed_view.MouseLeave += new System.EventHandler(this.button_MouseLeave);
            // 
            // b_removed_remove
            // 
            this.b_removed_remove.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(1)))), ((int)(((byte)(20)))));
            this.b_removed_remove.Dock = System.Windows.Forms.DockStyle.Top;
            this.b_removed_remove.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(6)))), ((int)(((byte)(64)))));
            this.b_removed_remove.FlatAppearance.BorderSize = 0;
            this.b_removed_remove.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.b_removed_remove.Font = new System.Drawing.Font("JetBrains Mono Medium", 10F, System.Drawing.FontStyle.Bold);
            this.b_removed_remove.ForeColor = System.Drawing.Color.White;
            this.b_removed_remove.ImageKey = "(none)";
            this.b_removed_remove.Location = new System.Drawing.Point(0, 40);
            this.b_removed_remove.Margin = new System.Windows.Forms.Padding(0);
            this.b_removed_remove.Name = "b_removed_remove";
            this.b_removed_remove.Padding = new System.Windows.Forms.Padding(15, 0, 0, 0);
            this.b_removed_remove.Size = new System.Drawing.Size(165, 40);
            this.b_removed_remove.TabIndex = 8;
            this.b_removed_remove.Text = "Увольнение";
            this.b_removed_remove.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.b_removed_remove.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.b_removed_remove.UseVisualStyleBackColor = false;
            this.b_removed_remove.Click += new System.EventHandler(this.b_removed_delete_Click);
            this.b_removed_remove.MouseEnter += new System.EventHandler(this.button_MouseEnter);
            this.b_removed_remove.MouseLeave += new System.EventHandler(this.button_MouseLeave);
            // 
            // b_removed_restore
            // 
            this.b_removed_restore.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(1)))), ((int)(((byte)(20)))));
            this.b_removed_restore.Dock = System.Windows.Forms.DockStyle.Top;
            this.b_removed_restore.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(6)))), ((int)(((byte)(64)))));
            this.b_removed_restore.FlatAppearance.BorderSize = 0;
            this.b_removed_restore.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.b_removed_restore.Font = new System.Drawing.Font("JetBrains Mono Medium", 10F, System.Drawing.FontStyle.Bold);
            this.b_removed_restore.ForeColor = System.Drawing.Color.White;
            this.b_removed_restore.ImageKey = "(none)";
            this.b_removed_restore.Location = new System.Drawing.Point(0, 80);
            this.b_removed_restore.Margin = new System.Windows.Forms.Padding(0);
            this.b_removed_restore.Name = "b_removed_restore";
            this.b_removed_restore.Padding = new System.Windows.Forms.Padding(15, 0, 0, 0);
            this.b_removed_restore.Size = new System.Drawing.Size(165, 40);
            this.b_removed_restore.TabIndex = 9;
            this.b_removed_restore.Text = "Восстановить";
            this.b_removed_restore.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.b_removed_restore.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.b_removed_restore.UseVisualStyleBackColor = false;
            this.b_removed_restore.Click += new System.EventHandler(this.b_removed_restore_Click);
            this.b_removed_restore.MouseEnter += new System.EventHandler(this.button_MouseEnter);
            this.b_removed_restore.MouseLeave += new System.EventHandler(this.button_MouseLeave);
            // 
            // b_removed_delete
            // 
            this.b_removed_delete.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(1)))), ((int)(((byte)(20)))));
            this.b_removed_delete.Dock = System.Windows.Forms.DockStyle.Top;
            this.b_removed_delete.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(6)))), ((int)(((byte)(64)))));
            this.b_removed_delete.FlatAppearance.BorderSize = 0;
            this.b_removed_delete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.b_removed_delete.Font = new System.Drawing.Font("JetBrains Mono Medium", 10F, System.Drawing.FontStyle.Bold);
            this.b_removed_delete.ForeColor = System.Drawing.Color.White;
            this.b_removed_delete.ImageKey = "(none)";
            this.b_removed_delete.Location = new System.Drawing.Point(0, 120);
            this.b_removed_delete.Margin = new System.Windows.Forms.Padding(0);
            this.b_removed_delete.Name = "b_removed_delete";
            this.b_removed_delete.Padding = new System.Windows.Forms.Padding(15, 0, 0, 0);
            this.b_removed_delete.Size = new System.Drawing.Size(165, 40);
            this.b_removed_delete.TabIndex = 10;
            this.b_removed_delete.Text = "Удалить";
            this.b_removed_delete.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.b_removed_delete.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.b_removed_delete.UseVisualStyleBackColor = false;
            this.b_removed_delete.Click += new System.EventHandler(this.b_removed_delete_Click_1);
            this.b_removed_delete.MouseEnter += new System.EventHandler(this.button_MouseEnter);
            this.b_removed_delete.MouseLeave += new System.EventHandler(this.button_MouseLeave);
            // 
            // b_removed
            // 
            this.b_removed.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(2)))), ((int)(((byte)(30)))));
            this.b_removed.Dock = System.Windows.Forms.DockStyle.Top;
            this.b_removed.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(83)))), ((int)(((byte)(16)))), ((int)(((byte)(105)))));
            this.b_removed.FlatAppearance.BorderSize = 0;
            this.b_removed.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.b_removed.Font = new System.Drawing.Font("JetBrains Mono Medium", 14F, System.Drawing.FontStyle.Bold);
            this.b_removed.ForeColor = System.Drawing.Color.White;
            this.b_removed.ImageKey = "(none)";
            this.b_removed.Location = new System.Drawing.Point(0, 250);
            this.b_removed.Margin = new System.Windows.Forms.Padding(0);
            this.b_removed.Name = "b_removed";
            this.b_removed.Padding = new System.Windows.Forms.Padding(3, 0, 0, 0);
            this.b_removed.Size = new System.Drawing.Size(165, 45);
            this.b_removed.TabIndex = 5;
            this.b_removed.Text = "Увольнение";
            this.b_removed.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.b_removed.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.b_removed.UseVisualStyleBackColor = false;
            this.b_removed.Click += new System.EventHandler(this.b_removed_Click);
            this.b_removed.MouseEnter += new System.EventHandler(this.button_MouseEnter);
            this.b_removed.MouseLeave += new System.EventHandler(this.button_MouseLeave);
            // 
            // SotrSubPanel
            // 
            this.SotrSubPanel.AutoSize = true;
            this.SotrSubPanel.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.SotrSubPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(3)))), ((int)(((byte)(28)))));
            this.SotrSubPanel.Controls.Add(this.b_sotr_view);
            this.SotrSubPanel.Controls.Add(this.b_sotr_edit);
            this.SotrSubPanel.Controls.Add(this.b_sotr_add);
            this.SotrSubPanel.Controls.Add(this.b_sotr_move);
            this.SotrSubPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.SotrSubPanel.Location = new System.Drawing.Point(0, 90);
            this.SotrSubPanel.Name = "SotrSubPanel";
            this.SotrSubPanel.Size = new System.Drawing.Size(165, 160);
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
            this.b_sotr_view.Font = new System.Drawing.Font("JetBrains Mono Medium", 10F, System.Drawing.FontStyle.Bold);
            this.b_sotr_view.ForeColor = System.Drawing.Color.White;
            this.b_sotr_view.ImageKey = "(none)";
            this.b_sotr_view.Location = new System.Drawing.Point(0, 0);
            this.b_sotr_view.Margin = new System.Windows.Forms.Padding(0);
            this.b_sotr_view.Name = "b_sotr_view";
            this.b_sotr_view.Padding = new System.Windows.Forms.Padding(15, 0, 0, 0);
            this.b_sotr_view.Size = new System.Drawing.Size(165, 40);
            this.b_sotr_view.TabIndex = 2;
            this.b_sotr_view.Text = "Список";
            this.b_sotr_view.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.b_sotr_view.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.b_sotr_view.UseVisualStyleBackColor = false;
            this.b_sotr_view.Click += new System.EventHandler(this.b_sotr_view_Click);
            this.b_sotr_view.MouseEnter += new System.EventHandler(this.button_MouseEnter);
            this.b_sotr_view.MouseLeave += new System.EventHandler(this.button_MouseLeave);
            // 
            // b_sotr_edit
            // 
            this.b_sotr_edit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(1)))), ((int)(((byte)(20)))));
            this.b_sotr_edit.Dock = System.Windows.Forms.DockStyle.Top;
            this.b_sotr_edit.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(6)))), ((int)(((byte)(64)))));
            this.b_sotr_edit.FlatAppearance.BorderSize = 0;
            this.b_sotr_edit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.b_sotr_edit.Font = new System.Drawing.Font("JetBrains Mono Medium", 10F, System.Drawing.FontStyle.Bold);
            this.b_sotr_edit.ForeColor = System.Drawing.Color.White;
            this.b_sotr_edit.ImageKey = "(none)";
            this.b_sotr_edit.Location = new System.Drawing.Point(0, 40);
            this.b_sotr_edit.Margin = new System.Windows.Forms.Padding(0);
            this.b_sotr_edit.Name = "b_sotr_edit";
            this.b_sotr_edit.Padding = new System.Windows.Forms.Padding(15, 0, 0, 0);
            this.b_sotr_edit.Size = new System.Drawing.Size(165, 40);
            this.b_sotr_edit.TabIndex = 5;
            this.b_sotr_edit.Text = "Изменить";
            this.b_sotr_edit.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.b_sotr_edit.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.b_sotr_edit.UseVisualStyleBackColor = false;
            this.b_sotr_edit.Click += new System.EventHandler(this.b_sotr_edit_Click);
            this.b_sotr_edit.MouseEnter += new System.EventHandler(this.button_MouseEnter);
            this.b_sotr_edit.MouseLeave += new System.EventHandler(this.button_MouseLeave);
            // 
            // b_sotr_add
            // 
            this.b_sotr_add.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(1)))), ((int)(((byte)(20)))));
            this.b_sotr_add.Dock = System.Windows.Forms.DockStyle.Top;
            this.b_sotr_add.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(6)))), ((int)(((byte)(64)))));
            this.b_sotr_add.FlatAppearance.BorderSize = 0;
            this.b_sotr_add.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.b_sotr_add.Font = new System.Drawing.Font("JetBrains Mono Medium", 10F, System.Drawing.FontStyle.Bold);
            this.b_sotr_add.ForeColor = System.Drawing.Color.White;
            this.b_sotr_add.ImageKey = "(none)";
            this.b_sotr_add.Location = new System.Drawing.Point(0, 80);
            this.b_sotr_add.Margin = new System.Windows.Forms.Padding(0);
            this.b_sotr_add.Name = "b_sotr_add";
            this.b_sotr_add.Padding = new System.Windows.Forms.Padding(15, 0, 0, 0);
            this.b_sotr_add.Size = new System.Drawing.Size(165, 40);
            this.b_sotr_add.TabIndex = 6;
            this.b_sotr_add.Text = "Прием";
            this.b_sotr_add.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.b_sotr_add.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.b_sotr_add.UseVisualStyleBackColor = false;
            this.b_sotr_add.Click += new System.EventHandler(this.b_sotr_add_Click);
            this.b_sotr_add.MouseEnter += new System.EventHandler(this.button_MouseEnter);
            this.b_sotr_add.MouseLeave += new System.EventHandler(this.button_MouseLeave);
            // 
            // b_sotr_move
            // 
            this.b_sotr_move.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(1)))), ((int)(((byte)(20)))));
            this.b_sotr_move.Dock = System.Windows.Forms.DockStyle.Top;
            this.b_sotr_move.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(6)))), ((int)(((byte)(64)))));
            this.b_sotr_move.FlatAppearance.BorderSize = 0;
            this.b_sotr_move.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.b_sotr_move.Font = new System.Drawing.Font("JetBrains Mono Medium", 10F, System.Drawing.FontStyle.Bold);
            this.b_sotr_move.ForeColor = System.Drawing.Color.White;
            this.b_sotr_move.ImageKey = "(none)";
            this.b_sotr_move.Location = new System.Drawing.Point(0, 120);
            this.b_sotr_move.Margin = new System.Windows.Forms.Padding(0);
            this.b_sotr_move.Name = "b_sotr_move";
            this.b_sotr_move.Padding = new System.Windows.Forms.Padding(15, 0, 0, 0);
            this.b_sotr_move.Size = new System.Drawing.Size(165, 40);
            this.b_sotr_move.TabIndex = 7;
            this.b_sotr_move.Text = "Перевод";
            this.b_sotr_move.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.b_sotr_move.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.b_sotr_move.UseVisualStyleBackColor = false;
            this.b_sotr_move.Click += new System.EventHandler(this.b_sotr_move_Click);
            this.b_sotr_move.MouseEnter += new System.EventHandler(this.button_MouseEnter);
            this.b_sotr_move.MouseLeave += new System.EventHandler(this.button_MouseLeave);
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
            this.b_sotr.Size = new System.Drawing.Size(165, 45);
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
            this.b_profile.Size = new System.Drawing.Size(165, 45);
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
            this.p_form_view.Location = new System.Drawing.Point(165, 25);
            this.p_form_view.Name = "p_form_view";
            this.p_form_view.Size = new System.Drawing.Size(1150, 675);
            this.p_form_view.TabIndex = 3;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
            | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox1.BackgroundImage = global::coursework_forms.Properties.Resources.HR_Form;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox1.Location = new System.Drawing.Point(284, 69);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(550, 535);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // b_exit
            // 
            this.b_exit.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.b_exit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(2)))), ((int)(((byte)(30)))));
            this.b_exit.BackgroundImage = global::coursework_forms.Properties.Resources.close;
            this.b_exit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.b_exit.Dock = System.Windows.Forms.DockStyle.Right;
            this.b_exit.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(83)))), ((int)(((byte)(16)))), ((int)(((byte)(105)))));
            this.b_exit.FlatAppearance.BorderSize = 0;
            this.b_exit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.b_exit.Font = new System.Drawing.Font("JetBrains Mono Medium", 12F, System.Drawing.FontStyle.Bold);
            this.b_exit.ForeColor = System.Drawing.Color.White;
            this.b_exit.ImageKey = "(none)";
            this.b_exit.Location = new System.Drawing.Point(1260, 0);
            this.b_exit.Margin = new System.Windows.Forms.Padding(0);
            this.b_exit.Name = "b_exit";
            this.b_exit.Size = new System.Drawing.Size(55, 25);
            this.b_exit.TabIndex = 7;
            this.b_exit.UseVisualStyleBackColor = false;
            this.b_exit.Click += new System.EventHandler(this.b_exit_Click);
            this.b_exit.MouseEnter += new System.EventHandler(this.b_exit_MouseEnter);
            this.b_exit.MouseLeave += new System.EventHandler(this.b_exit_MouseLeave);
            // 
            // main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(4)))), ((int)(((byte)(51)))));
            this.ClientSize = new System.Drawing.Size(1315, 700);
            this.Controls.Add(this.p_form_view);
            this.Controls.Add(this.p_side_menu);
            this.Controls.Add(this.p_top_menu);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "main";
            this.Text = "Head";
            this.p_top_menu.ResumeLayout(false);
            this.p_side_menu.ResumeLayout(false);
            this.p_side_menu.PerformLayout();
            this.AttesSubPanel.ResumeLayout(false);
            this.RemovedSubPanel.ResumeLayout(false);
            this.SotrSubPanel.ResumeLayout(false);
            this.p_form_view.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel p_top_menu;
        private System.Windows.Forms.Panel p_side_menu;
        private System.Windows.Forms.FlowLayoutPanel SotrSubPanel;
        private System.Windows.Forms.Button b_sotr_view;
        private System.Windows.Forms.Button b_sotr;
        private System.Windows.Forms.Button b_profile;
        private System.Windows.Forms.Panel p_form_view;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button b_exit;
        private System.Windows.Forms.Button b_sotr_edit;
        private System.Windows.Forms.Button b_sotr_add;
        private System.Windows.Forms.FlowLayoutPanel RemovedSubPanel;
        private System.Windows.Forms.Button b_removed_view;
        private System.Windows.Forms.Button b_removed;
        private System.Windows.Forms.Button b_removed_remove;
        private System.Windows.Forms.Button b_removed_restore;
        private System.Windows.Forms.Button b_sotr_move;
        private System.Windows.Forms.Button b_removed_delete;
        private System.Windows.Forms.Button b_attes;
        private System.Windows.Forms.Button b_tt;
        private System.Windows.Forms.FlowLayoutPanel AttesSubPanel;
        private System.Windows.Forms.Button b_attes_view;
        private System.Windows.Forms.Button b_attes_add;
    }
}