﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Runtime.Remoting.Contexts;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace coursework_forms {
    public partial class removed_view: Form {

        public removed_view() {
            InitializeComponent();
        }

        private void sotr_view_Load(object sender, EventArgs e) {
            // TODO: This line of code loads data into the 'courseworkDataSet1.Увольнение' table. You can move, or remove it, as needed.
            this.увольнениеTableAdapter.Fill(this.courseworkDataSet.Увольнение);
            // TODO: This line of code loads data into the 'courseworkDataSet.Removed' table. You can move, or remove it, as needed.
            this.removedTableAdapter.Fill(this.courseworkDataSet.Removed);

        }
        private void b_exit_Click(object sender, EventArgs e) {
            main m = Application.OpenForms.OfType<main>().SingleOrDefault();
            if(Application.OpenForms.OfType<common_options>().Count() == 1) {
                Application.OpenForms.OfType<common_options>().First().Close();
                m.Width = 1300;
                this.p_filter_options.Width = 0;
            }
            this.Close();
        }
        private void b_options_Click(object sender, EventArgs e) {
            main m = Application.OpenForms.OfType<main>().SingleOrDefault();
            if(Application.OpenForms.OfType<common_options>().Count() == 1) {
                Application.OpenForms.OfType<common_options>().First().Close();
                m.Width = 1300;
                this.p_filter_options.Width = 0;
                return;
            }
            m.Width = 1650;
            this.Width = 1500;
            this.p_filter_options.Width = 350;
            openChildForm(new common_options(this.removedBindingSource, "Дата"), p_filter_options);
        }
        private Form activeForm = null;
        public void openChildForm(Form child, Panel To) {
            if(activeForm != null) {
                activeForm.Close();
            }
            activeForm = child;
            child.TopLevel = false;
            child.FormBorderStyle = FormBorderStyle.None;
            child.Dock = DockStyle.Fill;
            To.Controls.Add(child);
            To.Tag = child;
            child.BringToFront();
            child.Show();
        }
        private void b_exit_MouseEnter(object sender, EventArgs e) {
            ((Button)sender).BackColor = Color.Red;
        }
        private void b_options_MouseEnter(object sender, EventArgs e) {
            ((Button)sender).BackColor = Color.Orange;
        }
        private void b_MouseLeave(object sender, EventArgs e) {
            ((Button)sender).BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(6)))), ((int)(((byte)(42)))));
        }
        private void b_update_MouseDown(object sender, MouseEventArgs e) {
            b_update.BackgroundImage = global::coursework_forms.Properties.Resources.refresh_green;
        }
        private void b_update_Leave(object sender, EventArgs e) {
            b_update.BackgroundImage = global::coursework_forms.Properties.Resources.refresh;
        }
        private void b_update_MouseEnter(object sender, EventArgs e) {
            b_update.BackgroundImage = global::coursework_forms.Properties.Resources.refresh_orange;
        }

        private void b_update_Click(object sender, EventArgs e) {
            string connString = @"Data Source=KTYDGIK\SQLKTYDG;Initial Catalog=""Coursework"";Integrated Security=True";
            // создание подключения SqlConnection
            SqlConnection connection = new SqlConnection(connString);
            connection.Open();
            foreach(DataGridViewRow row in dgv_sotr.Rows) {
                string ID = dgv_sotr.Rows[row.Index].Cells[0].Value.ToString();
                string reason = dgv_sotr.Rows[row.Index].Cells[3].Value.ToString();
                string Date = dgv_sotr.Rows[row.Index].Cells[2].Value.ToString();
                SqlCommand comm = new SqlCommand("UPDATE Removed SET Причина = '" + reason + "' WHERE ID = " + ID + " AND Дата = '" + Date + "'", connection);

                try {
                    comm.ExecuteNonQuery();
                }
                catch(Exception ex) {
                    MessageBox.Show(ex.ToString(), "ОБНОВЛЕНИЕ НЕ ПРОИЗОШЛО");
                }
            }
            connection.Close();
            this.removedTableAdapter.Fill(this.courseworkDataSet.Removed);
        }
    }
}
