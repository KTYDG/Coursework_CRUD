using Aspose.Words.Replacing;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Drawing.Printing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace coursework_forms.FORMS.sotr {
    public partial class rest_add: Form {
        public rest_add() {
            InitializeComponent();
            DateTime today = DateTime.Now;
            //dtm_date.MaxDate = today;
            //dtm_end.MinDate = today;
            dtm_date.Value = today;
            dtm_end.Value = today;
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

        private void sotr_add_Load(object sender, EventArgs e) {
            // TODO: This line of code loads data into the 'courseworkDataSet.Sotr' table. You can move, or remove it, as needed.
            this.sotrTableAdapter.Fill(this.courseworkDataSet.Sotr);
        }

        private void b_add_Click(object sender, EventArgs e) {
            if(cb_sotr.SelectedValue == null) {
                tb_error.Text = "Сотрудника не существует";
                return;
            }
            string date_end = "";
            if(cb_end.Checked) {
                if(dtm_date.Value > dtm_end.Value) {
                    tb_error.Text = "Неверный формат даты";
                    return;
                }
                date_end = "'" + dtm_end.Text + "'";
            }
            else {
                date_end = "NULL";
            }

            string connString = @"Data Source=KTYDGIK\SQLKTYDG;Initial Catalog=""Coursework"";Integrated Security=True";
            // создание подключения SqlConnection
            SqlConnection connection = new SqlConnection(connString);
            SqlCommand comm = new SqlCommand("INSERT INTO Отпуск VALUES(" + tb_id.Text + ", '" + dtm_date.Text + "', " + date_end + ", '" + rtb_reason.Text + "')", connection);

            try {
                connection.Open();
                comm.ExecuteNonQuery();
                connection.Close();
            }
            catch(Exception ex) {
                MessageBox.Show(ex.ToString(), "ОБНОВЛЕНИЕ НЕ ПРОИЗОШЛО");
                return;
            }

            tb_error.Text = "Изменения прошли успешно";
            var t = new Timer();
            t.Interval = 2000;
            t.Tick += (s, ev) => {
                tb_error.Text = "";
                t.Stop();
            };
            t.Start();

        }
    }
}
