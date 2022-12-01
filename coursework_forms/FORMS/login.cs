using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Runtime.InteropServices;

namespace coursework_forms {
    public partial class login: Form {
        public login() {
            InitializeComponent();
        }

        private void b_login_Click(object sender, EventArgs e) {
            // строка подключения
            string connString = @"Data Source=KTYDGIK\SQLKTYDG;Initial Catalog=""Coursework"";Integrated Security=True";

            // создание подключения SqlConnection
            SqlConnection connection = new SqlConnection(connString);

            // создание объекта типа SqlCommand
            SqlCommand my_command = new SqlCommand();

            // настройка объект command 
            my_command.Connection = connection;
            my_command.CommandType = System.Data.CommandType.StoredProcedure;
            my_command.CommandText = "Login";

            // создание входных параметров
            my_command.Parameters.Add("@id", SqlDbType.Int);
            my_command.Parameters.Add("@password", SqlDbType.VarChar, 50);
            my_command.Parameters.Add("@check", SqlDbType.Int);
            my_command.Parameters.Add("@error", SqlDbType.VarChar, 60);

            my_command.Parameters["@error"].Direction = ParameterDirection.Output;
            my_command.Parameters["@check"].Direction = ParameterDirection.Output;

            if(tb_pass.Text.Length > 50) {
                tb_error.Text = "Невернный пароль";
                return;
            }
            my_command.Parameters["@password"].Value = tb_pass.Text;

            try {
                my_command.Parameters["@id"].Value = Convert.ToInt32(tb_id.Text);
            }
            catch {
                tb_error.Text = "Невернно введен ID";
                return;
            }
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
            catch {
                tb_error.Text = "Ошибка запроса";
                return;
            }

            // закрытие соединения с БД
            connection.Close();

            int check = (int)my_command.Parameters["@check"].Value;
            if(check == 1 || check == 2) {
                this.Hide();
                Form f = new main(check, Convert.ToInt32(tb_id.Text));
                f.ShowDialog();
                tb_error.Text = "";
                tb_id.Text = "";
                tb_pass.Text = "";
                //this.Close();
            }
            else {
                // вывод ошибки
                tb_error.Text = Convert.ToString((string)my_command.Parameters["@error"].Value);
            }

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
            ((Button)sender).BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(2)))), ((int)(((byte)(30)))));
        }

        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;

        [DllImportAttribute("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
        [DllImportAttribute("user32.dll")]
        public static extern bool ReleaseCapture();

        private void p_top_menu_MouseMove(object sender, MouseEventArgs e) {
            if(e.Button == MouseButtons.Left) {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }

        private void button1_Click(object sender, EventArgs e) {
            this.Close();
        }
    }
}
