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
    public partial class timetable: Form {

        public timetable() {
            InitializeComponent();
            dgv_sotr.Columns[0].ReadOnly = true;
            dgv_sotr.Columns[1].ReadOnly = true;
            dgv_sotr.Columns[2].ReadOnly = true;
            dgv_sotr.Columns[4].ReadOnly = true;
        }

        private void sotr_view_Load(object sender, EventArgs e) {
            sotr_load();
        }
        private void sotr_load() {
            // TODO: This line of code loads data into the 'courseworkDataSet.Сотрудник' table. You can move, or remove it, as needed.
            this.штатноеРасписаниеTableAdapter.Fill(this.courseworkDataSet.ШтатноеРасписание);
        }
        private void b_exit_Click(object sender, EventArgs e) {
            this.Close();
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
            this.штатноеРасписаниеBindingSource.EndEdit(); // Закрывает подключение с сервером
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

        string amount_before = "";
        string salary_before = "";
        private void dgv_sotr_CellEndEdit(object sender, DataGridViewCellEventArgs e) {
            int col = e.ColumnIndex;
            int row = e.RowIndex;
            string col_name = dgv_sotr.Columns[col].HeaderText;
            if(col == 3) {
                if(dgv_sotr.Rows[row].Cells[2].Value.ToString() == "Генеральный Директор") {
                    dgv_sotr.Rows[row].Cells[col].Value = amount_before;
                    MessageBox.Show(String.Format("Нельзя изменить количество у этой ячейки в столбце: {0}", col_name));
                }
                if(dgv_sotr.Rows[row].Cells[col].Value.ToString().All(char.IsDigit) && dgv_sotr.Rows[row].Cells[col + 1].Value.ToString().All(char.IsDigit)) {
                    int a = Convert.ToInt32(dgv_sotr.Rows[row].Cells[col].Value.ToString());
                    int b = Convert.ToInt32(dgv_sotr.Rows[row].Cells[col + 1].Value.ToString());
                    if(a < b) {
                        dgv_sotr.Rows[row].Cells[col].Value = amount_before;
                        MessageBox.Show(String.Format("Количество мест не может быть меньше сотрудников в столбце: {0}", col_name));
                    }
                }
                if(dgv_sotr.Rows[row].Cells[col].Value.ToString()[0] == '-') {
                    dgv_sotr.Rows[row].Cells[col].Value = amount_before;
                    MessageBox.Show(String.Format("Неверный формат введеных данных в столбце: {0}", col_name));
                }
            }
            if(col == 5) {
                if(dgv_sotr.Rows[row].Cells[2].Value.ToString() == "Генеральный Директор") {
                    dgv_sotr.Rows[row].Cells[col].Value = salary_before;
                    MessageBox.Show(String.Format("Нельзя изменить зарплату у этой ячейки в столбце: {0}", col_name));
                }
                if(dgv_sotr.Rows[row].Cells[col].Value.ToString()[0] == '-') {
                    dgv_sotr.Rows[row].Cells[col].Value = salary_before;
                    MessageBox.Show(String.Format("Неверный формат введеных данных в столбце: {0}", col_name));
                }
            }
        }

        private void dgv_sotr_CellBeginEdit(object sender, DataGridViewCellCancelEventArgs e) {
            int col = e.ColumnIndex;
            int row = e.RowIndex;
            if(col == 3) {
                amount_before = dgv_sotr.Rows[row].Cells[col].Value.ToString();
            }
            if(col == 5) {
                salary_before = dgv_sotr.Rows[row].Cells[col].Value.ToString();
            }
        }
    }
}
