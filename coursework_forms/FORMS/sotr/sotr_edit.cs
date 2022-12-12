using Aspose.Words.Tables;
using Microsoft.Office.Interop.Word;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace coursework_forms {
    public partial class sotr_edit: Form {

        public sotr_edit() {
            InitializeComponent();
            dgv_sotr.Columns[0].ReadOnly = true;
            dgv_sotr.Columns[1].ReadOnly = true;
            dgv_sotr.Columns[2].ReadOnly = true;
            dgv_sotr.Columns[6].ReadOnly = true;
        }

        private void sotr_view_Load(object sender, EventArgs e) {
            sotr_load();
        }
        private void sotr_load() {
            // TODO: This line of code loads data into the 'courseworkDataSet.Сотрудник' table. You can move, or remove it, as needed.
            this.сотрудникTableAdapter.Fill(this.courseworkDataSet.Сотрудник);


        }
        private void b_exit_Click(object sender, EventArgs e) {
            this.Close();
        }



        private void button_MouseEnter(object sender, EventArgs e) {
            ((Button)sender).ForeColor = Color.Crimson;
        }

        private void button_MouseLeave(object sender, EventArgs e) {
            ((Button)sender).ForeColor = Color.White;
        }

        private void b_exit_MouseEnter(object sender, EventArgs e) {
            ((Button)sender).BackColor = Color.Red;
        }

        private void b_exit_MouseLeave(object sender, EventArgs e) {
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
            this.Validate(); // Проверяет введеные поля на соответсвие типам данных
            this.сотрудникBindingSource.EndEdit(); // Закрывает подключение с сервером
            try {
                this.tableAdapterManager.UpdateAll(this.courseworkDataSet); // Обновляет данные на сервере
            }
            catch(Exception ex) {
                sotr_load();
                MessageBox.Show(ex.ToString(), "БЫЛО ВВЕДЕНО НЕДОПУСТИМОЕ ЗНАЧЕНИЕ");
            }
        }

        private void drg_DataError(object sender, DataGridViewDataErrorEventArgs e) {
            string col_name = dgv_sotr.Columns[e.ColumnIndex].HeaderText;
            MessageBox.Show(String.Format("Неверный формат введеных данных в столбце: {0}", col_name));
        }

        string phone_before = "";
        string stage_before = "";
        string salary_before = "";
        private void dgv_sotr_CellEndEdit(object sender, DataGridViewCellEventArgs e) {
            int col = e.ColumnIndex;
            int row = e.RowIndex;
            if(col == 8) {
                if(dgv_sotr.Rows[row].Cells[col].Value.ToString().Length != 10 || dgv_sotr.Rows[row].Cells[col].Value.ToString()[0] == '-') {
                    dgv_sotr.Rows[row].Cells[col].Value = phone_before;
                    string col_name = dgv_sotr.Columns[col].HeaderText;
                    MessageBox.Show(String.Format("Неверный формат введеных данных в столбце: {0}", col_name));
                }
            }
            if(col == 10) {
                if(dgv_sotr.Rows[row].Cells[col].Value.ToString()[0] == '-') {
                    dgv_sotr.Rows[row].Cells[col].Value = salary_before;
                    string col_name = dgv_sotr.Columns[col].HeaderText;
                    MessageBox.Show(String.Format("Неверный формат введеных данных в столбце: {0}", col_name));
                }
            }
            if(col == 11) {
                if(dgv_sotr.Rows[row].Cells[col].Value.ToString()[0] == '-') {
                    dgv_sotr.Rows[row].Cells[col].Value = stage_before;
                    string col_name = dgv_sotr.Columns[col].HeaderText;
                    MessageBox.Show(String.Format("Неверный формат введеных данных в столбце: {0}", col_name));
                }
            }
        }

        private void dgv_sotr_CellBeginEdit(object sender, DataGridViewCellCancelEventArgs e) {
            int col = e.ColumnIndex;
            int row = e.RowIndex;
            if(col == 8) {
                phone_before = dgv_sotr.Rows[row].Cells[col].Value.ToString();

            }
            if(col == 10) {
                salary_before = dgv_sotr.Rows[row].Cells[col].Value.ToString();
            }
            if(col == 11) {
                stage_before = dgv_sotr.Rows[row].Cells[col].Value.ToString();
            }
        }

        private void dgv_sotr_Paint(object sender, PaintEventArgs e) {
            string connString = @"Data Source=KTYDGIK\SQLKTYDG;Initial Catalog=""Coursework"";Integrated Security=True";
            // создание подключения SqlConnection
            SqlConnection connection = new SqlConnection(connString);
            SqlCommand comm = new SqlCommand("SELECT id_сотрудник FROM Увольнение", connection);

            connection.Open();
            SqlDataReader reader = comm.ExecuteReader();
            while(reader.Read()) {
                int id = Convert.ToInt32(reader.GetValue(0).ToString());
                foreach(DataGridViewRow row in dgv_sotr.Rows) {
                    if(dgv_sotr.Rows[row.Index].Cells[0].Value.ToString() == id.ToString())
                        dgv_sotr.Rows[row.Index].DefaultCellStyle.BackColor = Color.Crimson;
                }
            }
            reader.Close();
            connection.Close();
        }
    }
}
