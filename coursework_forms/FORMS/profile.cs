using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ProgressBar;

namespace coursework_forms {
    public partial class profile: Form {
        public profile(int id) {
            InitializeComponent();
            tb_id.Text = id.ToString();
            if(id == 1) {
                p_profile_pic.BackgroundImage = global::coursework_forms.Properties.Resources.DR;
            }
            else {
                p_profile_pic.BackgroundImage = global::coursework_forms.Properties.Resources.HR;
            }
            GetProfile();
        }
        private void b_update_Click(object sender, EventArgs e) {
            SetProfile();
            GetProfile();
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

        private void GetProfile() {
            // строка подключения
            string connString = @"Data Source=KTYDGIK\SQLKTYDG;Initial Catalog=""Coursework"";Integrated Security=True";

            // создание подключения SqlConnection
            SqlConnection connection = new SqlConnection(connString);

            // создание объекта типа SqlCommand
            SqlCommand my_command = new SqlCommand();

            // настройка объект command 
            my_command.Connection = connection;
            my_command.CommandType = System.Data.CommandType.StoredProcedure;
            my_command.CommandText = "GetProfile";

            // создание входных параметров
            my_command.Parameters.Add("@id", SqlDbType.Int);
            my_command.Parameters.Add("@password", SqlDbType.VarChar, 50);
            my_command.Parameters.Add("@fio", SqlDbType.VarChar, 60);
            my_command.Parameters.Add("@mail", SqlDbType.VarChar, 50);
            my_command.Parameters.Add("@phone", SqlDbType.BigInt);

            my_command.Parameters["@id"].Value = Convert.ToInt32(tb_id.Text);
            my_command.Parameters["@password"].Direction = ParameterDirection.Output;
            my_command.Parameters["@fio"].Direction = ParameterDirection.Output;
            my_command.Parameters["@mail"].Direction = ParameterDirection.Output;
            my_command.Parameters["@phone"].Direction = ParameterDirection.Output;

            try {
                connection.Open();

                my_command.ExecuteNonQuery();
            }
            catch {
                tb_error.Text = "Проблема с запросом или соединеним к БД";
                return;
            }

            // закрытие соединения с БД
            connection.Close();
            tb_pass.Text = Convert.ToString((string)my_command.Parameters["@password"].Value);
            tb_fio.Text = Convert.ToString((string)my_command.Parameters["@fio"].Value);
            tb_mail.Text = Convert.ToString((string)my_command.Parameters["@mail"].Value);
            tb_phone.Text = Convert.ToString((long)my_command.Parameters["@phone"].Value);
        }
        private void SetProfile() {
            // строка подключения
            string connString = @"Data Source=KTYDGIK\SQLKTYDG;Initial Catalog=""Coursework"";Integrated Security=True";

            // создание подключения SqlConnection
            SqlConnection connection = new SqlConnection(connString);

            // создание объекта типа SqlCommand
            SqlCommand my_command = new SqlCommand();

            // настройка объект command 
            my_command.Connection = connection;
            my_command.CommandType = System.Data.CommandType.StoredProcedure;
            my_command.CommandText = "SetProfile";

            // создание входных параметров
            my_command.Parameters.Add("@id", SqlDbType.Int);
            my_command.Parameters.Add("@password", SqlDbType.VarChar, 50);
            my_command.Parameters.Add("@f", SqlDbType.VarChar, 20);
            my_command.Parameters.Add("@i", SqlDbType.VarChar, 20);
            my_command.Parameters.Add("@o", SqlDbType.VarChar, 20);
            my_command.Parameters.Add("@mail", SqlDbType.VarChar, 50);
            my_command.Parameters.Add("@phone", SqlDbType.BigInt);

            string fio = tb_fio.Text;
            string[] f = fio.Split(' ');
            if(f.Length != 3 && f.Length != 2) {
                tb_error.Text = "Неверный формат ФИО";
                return;
            }
            my_command.Parameters["@id"].Value = Convert.ToInt32(tb_id.Text);
            my_command.Parameters["@password"].Value = tb_pass.Text;
            my_command.Parameters["@f"].Value = f[1];
            my_command.Parameters["@i"].Value = f[0];
            if(f.Length == 3) {
                my_command.Parameters["@o"].Value = f[2];
            }
            else {
                my_command.Parameters["@o"].Value = "";
            }

            if(!tb_mail.Text.Contains("@")) {
                tb_error.Text = "Неверный формат почты";
                return;
            }
            my_command.Parameters["@mail"].Value = tb_mail.Text;

            if(tb_pass.Text.Length > 50) {
                tb_error.Text = "Неверный формат пароля";
                return;
            }
            my_command.Parameters["@password"].Value = tb_pass.Text;
            try {
                my_command.Parameters["@phone"].Value = Convert.ToInt64(tb_phone.Text);
            }
            catch {
                tb_error.Text = "Неверный формат телефона";
                return;
            }
            if(Convert.ToInt64(tb_phone.Text) <= 0 || tb_phone.Text.Length != 10) {
                tb_error.Text = "Неверный формат телефона";
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

            tb_error.Text = "Изменения прошли успешно";

            var t = new System.Windows.Forms.Timer();
            t.Interval = 2000;
            t.Tick += (s, e) => {
                tb_error.Text = "";
                t.Stop();
            };
            t.Start();
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

        private void b_show_password_MouseDown(object sender, MouseEventArgs e) {
            b_show_password.BackgroundImage = global::coursework_forms.Properties.Resources.eye_red;
            tb_pass.PasswordChar = '\0';
        }

        private void b_show_password_MouseUp(object sender, MouseEventArgs e) {
            b_show_password.BackgroundImage = global::coursework_forms.Properties.Resources.eye;
            tb_pass.PasswordChar = '#';
        }

        private void b_logout_Click(object sender, EventArgs e) {
            main m = Application.OpenForms.OfType<main>().SingleOrDefault();
            if(m != null) {
                this.Hide();
                m.Hide();
                this.Close();
                m.Close();
            }
            login l = Application.OpenForms.OfType<login>().SingleOrDefault();
            l.Show();
        }

    }
}
