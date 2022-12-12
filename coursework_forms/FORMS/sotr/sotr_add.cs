using Microsoft.Office.Interop.Word;
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
using Word = Microsoft.Office.Interop.Word;
using Aspose.Words;
using Aspose.Words.Replacing;

namespace coursework_forms.FORMS.sotr {
    public partial class sotr_add: Form {
        public sotr_add() {
            InitializeComponent();
            DateTime today = DateTime.Now.AddYears(-18);
            DateTime TD = DateTime.Now;
            dtm_birth.MaxDate = today;
            dtm_birth.Value = today;
            tb_td.Text = TD.ToString("MMddmmss");
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
            // TODO: This line of code loads data into the 'courseworkDataSet.MoveAdd1' table. You can move, or remove it, as needed.
            this.moveAdd1TableAdapter.Fill(this.courseworkDataSet.MoveAdd1);
            // TODO: This line of code loads data into the 'courseworkDataSet.ШтатноеРасписание1' table. You can move, or remove it, as needed.
            this.штатноеРасписание1TableAdapter.Fill(this.courseworkDataSet.ШтатноеРасписание1);

            moveAdd1BindingSource.Filter = "Отдел = '" + comboBox1.SelectedValue.ToString() + "'";
        }

        private void tb_salary_TextChanged(object sender, EventArgs e) {
            long salary = 0;
            try {
                salary = Convert.ToInt32(tb_salary.Text);
            }
            catch {
                tb_error.Text = "Неверный формат заработной платы";
                tb_salary.Text = "";
            }
            if(salary <= 0) {
                tb_error.Text = "Неверный формат заработной платы";
                tb_salary.Text = "";
            }
            else {
                tb_error.Text = "";
            }
        }

        private void tb_stage_TextChanged(object sender, EventArgs e) {
            long stage = -1;
            try {
                stage = Convert.ToInt32(tb_stage.Text);
            }
            catch {
                tb_error.Text = "Неверный формат стажа";
                tb_stage.Text = "";
            }
            if(stage < 0) {
                tb_error.Text = "Неверный формат стажа";
                tb_stage.Text = "";
            }
            else {
                tb_error.Text = "";
            }
        }

        private void tb_phone_TextChanged(object sender, EventArgs e) {
            long phone = 0;
            try {
                phone = Convert.ToInt64(tb_phone.Text);
            }
            catch {
                tb_error.Text = "Неверный формат телефона";
                tb_phone.Text = "";
            }
            if(phone <= 0) {
                tb_error.Text = "Неверный формат телефона";
                tb_phone.Text = "";
            }
            else {
                tb_error.Text = "";
            }
        }

        private void tb_td_TextChanged(object sender, EventArgs e) {
            long phone = -1;
            try {
                phone = Convert.ToInt64(tb_td.Text);
            }
            catch {
                tb_error.Text = "Неверный формат № трудового договора";
                tb_td.Text = "";
            }
            if(phone < 0) {
                tb_error.Text = "Неверный формат № трудового договора";
                tb_td.Text = "";
            }
            else {
                tb_error.Text = "";
            }
        }

        private void b_add_Click(object sender, EventArgs e) {

            if(!tb_mail.Text.Contains("@") || tb_mail.Text == "") {
                tb_error.Text = "Неверный формат почты";
                return;
            }
            if(tb_phone.Text.Length != 10) {
                tb_error.Text = "Номер телефона - 10 цифр";
                return;
            }
            if(tb_stage.Text == "") {
                tb_error.Text = "Данные не заполнены";
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
            my_command.CommandText = "CheckNewWorker";

            // создание входных параметров
            my_command.Parameters.Add("@id_TD", SqlDbType.Int);
            my_command.Parameters.Add("@id_work", SqlDbType.Int);
            my_command.Parameters.Add("@mail", SqlDbType.VarChar, 50);
            my_command.Parameters.Add("@tel", SqlDbType.BigInt);
            my_command.Parameters.Add("@res", SqlDbType.VarChar, 60);

            try {
                my_command.Parameters["@id_TD"].Value = Convert.ToInt32(tb_td.Text);
                my_command.Parameters["@id_work"].Value = Convert.ToInt32(cb_place.SelectedValue.ToString());
                my_command.Parameters["@tel"].Value = Convert.ToInt64(tb_phone.Text);
            }
            catch {
                tb_error.Text = "Данные не заполнены";
            }

            my_command.Parameters["@mail"].Value = tb_mail.Text;
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
            catch {
                tb_error.Text = "Ошибка запроса";
                return;
            }


            // закрытие соединения с БД
            connection.Close();
            string res = Convert.ToString((string)my_command.Parameters["@res"].Value);
            if(res != "ОК") {
                tb_error.Text = res;
                return;
            }

            string fio = tb_fio.Text;
            string[] f = fio.Split(' ');
            if(f.Length != 3 || tb_fio.Text.Any(char.IsDigit)) {
                tb_error.Text = "Неверный формат ФИО";
                return;
            }

            // создание объекта типа SqlCommand
            SqlCommand my_command2 = new SqlCommand();

            // настройка объект command 
            my_command2.Connection = connection;
            my_command2.CommandText = String.Format("INSERT INTO Сотрудник VALUES({0},{1},'{2}','{3}','{4}','{5}','{6}',{7},'{8}',{9})",
                tb_td.Text,
                cb_place.SelectedValue.ToString(),
                f[0], f[1], f[2],
                dtm_birth.Value.ToShortDateString(),
                cb_gender.Text,
                tb_phone.Text,
                tb_mail.Text,
                tb_stage.Text
                );

            try {
                connection.Open();
            }
            catch {
                tb_error.Text = "Ошибка соединения";
                return;
            }
            try {
                my_command2.ExecuteNonQuery();
            }
            catch {
                tb_error.Text = "Ошибка запроса";
                return;
            }
            connection.Close();

            tb_error.Text = "Изменения прошли успешно";
            var t = new Timer();
            t.Interval = 2000;
            t.Tick += (s, ev) => {
                tb_error.Text = "";
                t.Stop();
            };
            t.Start();
            if(cb_doc.Checked) {
                try {
                    save();
                }
                catch {
                    MessageBox.Show("Не удалось сохранить документ");
                }
            }
        }
        private void save() {
            // Displays a SaveFileDialog so the user can save the Image
            // assigned to Button2.
            SaveFileDialog saveFileDialog1 = new SaveFileDialog();
            saveFileDialog1.Filter = "Word document |*.docx";
            saveFileDialog1.Title = "Сохранить ТД";
            saveFileDialog1.ShowDialog();

            // If the file name is not an empty string open it for saving.
            if(saveFileDialog1.FileName != "") {
                // Saves the Image via a FileStream created by the OpenFile method.
                System.IO.FileStream fs =
                    (System.IO.FileStream)saveFileDialog1.OpenFile();
                // Saves the Image in the appropriate ImageFormat based upon the
                // File type selected in the dialog box.
                // NOTE that the FilterIndex property is one-based.
                fs.Close();
            }
            Microsoft.Office.Interop.Word.Application wordApp = new Microsoft.Office.Interop.Word.Application();
            object file = Path.GetFullPath("TD.docx");
            object nullobj = System.Reflection.Missing.Value;

            Microsoft.Office.Interop.Word.Document doc = wordApp.Documents.Open(
                ref file, ref nullobj, ref nullobj,
                ref nullobj, ref nullobj, ref nullobj,
                ref nullobj, ref nullobj, ref nullobj,
                ref nullobj, ref nullobj, ref nullobj, true);

            Object oSaveAsFile = (Object)Path.GetFullPath(saveFileDialog1.FileName);

            doc.SaveAs2(oSaveAsFile, Microsoft.Office.Interop.Word.WdSaveFormat.wdFormatXMLDocument);

            doc.Close(ref nullobj, ref nullobj, ref nullobj);
            wordApp.Quit(ref nullobj, ref nullobj, ref nullobj);

            DateTime today = DateTime.Today;

            Aspose.Words.Document d = new Aspose.Words.Document(Path.GetFullPath(saveFileDialog1.FileName));
            // Find and replace text in the document
            d.Range.Replace("$0", tb_td.Text, new FindReplaceOptions(FindReplaceDirection.Forward));
            d.Range.Replace("$1", today.ToString("dd.MM.yyyy"), new FindReplaceOptions(FindReplaceDirection.Forward));
            d.Range.Replace("$2", tb_fio.Text, new FindReplaceOptions(FindReplaceDirection.Forward));
            d.Range.Replace("$3", cb_place.Text, new FindReplaceOptions(FindReplaceDirection.Forward));
            d.Range.Replace("$4", today.ToString("dd.MM.yyyy"), new FindReplaceOptions(FindReplaceDirection.Forward));
            d.Range.Replace("$5", tb_salary.Text, new FindReplaceOptions(FindReplaceDirection.Forward));
            // Save the Word document
            d.Save(Path.GetFullPath(saveFileDialog1.FileName));
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e) {
            if(comboBox1.SelectedValue != null)
                moveAdd1BindingSource.Filter = "Отдел = '" + comboBox1.SelectedValue.ToString() + "'";
        }
    }
}
