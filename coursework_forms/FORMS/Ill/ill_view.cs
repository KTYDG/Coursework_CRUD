using System;
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
    public partial class ill_view: Form {

        public ill_view() {
            InitializeComponent();
            dgv_sotr.Columns[0].ReadOnly = true;
            dgv_sotr.Columns[1].ReadOnly = true;
            dgv_sotr.Columns[2].ReadOnly = true;
            dgv_sotr.Columns[3].ReadOnly = true;
            dgv_sotr.Columns[4].ReadOnly = true;
            dgv_sotr.Columns[5].ReadOnly = true;
        }

        private void sotr_view_Load(object sender, EventArgs e) {
            // TODO: This line of code loads data into the 'courseworkDataSet.Ill' table. You can move, or remove it, as needed.
            this.illTableAdapter.Fill(this.courseworkDataSet.Ill);

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
            openChildForm(new common_options(this.illBindingSource, "[Дата начало]"), p_filter_options);
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
                string reason = dgv_sotr.Rows[row.Index].Cells[5].Value.ToString();
                string Date_end = dgv_sotr.Rows[row.Index].Cells[4].Value.ToString();
                SqlCommand comm = new SqlCommand("UPDATE Ill SET Причина = '" + reason + "', [Дата конец] = '" + Date_end + "' WHERE ID_Д = " + ID, connection);
                try {
                    comm.ExecuteNonQuery();
                }
                catch(Exception ex) {
                    MessageBox.Show(ex.ToString(), "ОБНОВЛЕНИЕ НЕ ПРОИЗОШЛО");
                }
            }
            connection.Close();
            this.illTableAdapter.Fill(this.courseworkDataSet.Ill);
        }
        private void b_delete_Click(object sender, EventArgs e) {
            foreach(DataGridViewRow item in this.dgv_sotr.SelectedRows) {
                string id = dgv_sotr.Rows[item.Index].Cells[0].Value.ToString();
                string connString = @"Data Source=KTYDGIK\SQLKTYDG;Initial Catalog=""Coursework"";Integrated Security=True";
                // создание подключения SqlConnection
                SqlConnection connection = new SqlConnection(connString);
                SqlCommand comm = new SqlCommand("DELETE FROM Больничный WHERE id_Больничный = " + id, connection);

                try {
                    connection.Open();
                    comm.ExecuteNonQuery();
                    connection.Close();
                }
                catch(Exception ex) {
                    MessageBox.Show(ex.ToString(), "УДАЛЕНИЕ НЕ ПРОИЗОШЛО");
                }
            }
            this.illTableAdapter.Fill(this.courseworkDataSet.Ill);
        }

        private void dgv_sotr_DataError(object sender, DataGridViewDataErrorEventArgs e) {
            string col_name = dgv_sotr.Columns[e.ColumnIndex].HeaderText;
            MessageBox.Show(String.Format("Неверный формат введеных данных в столбце: {0}", col_name));
        }

        string date_before = "";
        private void dgv_sotr_CellEndEdit(object sender, DataGridViewCellEventArgs e) {
            int col = e.ColumnIndex;
            int row = e.RowIndex;
            if(col == 4) {
                dgv_sotr.Rows[row].Cells[col].Value.ToString();
                DateTime end = DateTime.Parse(dgv_sotr.Rows[row].Cells[col].Value.ToString());
                DateTime start = DateTime.Parse(dgv_sotr.Rows[row].Cells[col - 1].Value.ToString());
                if(end.Date < start.Date) {
                    dgv_sotr.Rows[row].Cells[col].Value = date_before;
                    string col_name = dgv_sotr.Columns[col].HeaderText;
                    MessageBox.Show(String.Format("Неверный формат введеных данных в столбце: {0}", col_name));
                }
            }
        }

        private void dgv_sotr_CellBeginEdit(object sender, DataGridViewCellCancelEventArgs e) {
            int col = e.ColumnIndex;
            int row = e.RowIndex;
            if(col == 4) {
                date_before = dgv_sotr.Rows[row].Cells[col].Value.ToString();
            }
        }
    }
}
