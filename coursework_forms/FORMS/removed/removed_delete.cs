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
    public partial class removed_delete: Form {
        public removed_delete() {
            InitializeComponent();
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
            // TODO: This line of code loads data into the 'courseworkDataSet.Removed' table. You can move, or remove it, as needed.
            this.removedTableAdapter.Fill(this.courseworkDataSet.Removed);
        }

        private void b_remove_Click(object sender, EventArgs e) {
            if(cb_sotr.SelectedValue == null) {
                tb_error.Text = "Сотрудника не существует";
                return;
            }

            // строка подключения
            string connString = @"Data Source=KTYDGIK\SQLKTYDG;Initial Catalog=""Coursework"";Integrated Security=True";

            // создание подключения SqlConnection
            SqlConnection connection = new SqlConnection(connString);

            // создание объекта типа SqlCommand
            SqlCommand my_command = new SqlCommand();

            // настройка объект command 
            my_command.Connection = connection;
            my_command.CommandType = System.Data.CommandType.StoredProcedure;
            my_command.CommandText = "DeleteSotr";

            // создание входных параметров
            my_command.Parameters.Add("@ID", SqlDbType.Int);
            my_command.Parameters.Add("@res", SqlDbType.VarChar, 60);

            try {
                my_command.Parameters["@ID"].Value = Convert.ToInt32(cb_sotr.SelectedValue.ToString());
            }
            catch {
                tb_error.Text = "ID не существует";
                return;
            }
            my_command.Parameters["@res"].Direction = ParameterDirection.Output;

            // открытие соединения с БД
            try {
                connection.Open();
            }
            catch {
                tb_error.Text = "Ошибка соединения";
                return;
            }
            try {
                my_command.ExecuteNonQuery();
            }
            catch(Exception ex) {
                tb_error.Text = "Ошибка запроса";
                MessageBox.Show(ex.ToString());
                return;
            }
            connection.Close();
            tb_error.Text = Convert.ToString((string)my_command.Parameters["@res"].Value);
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
