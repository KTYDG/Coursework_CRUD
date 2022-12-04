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
    public partial class sotr_move: Form {
        public sotr_move() {
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
            // TODO: This line of code loads data into the 'courseworkDataSet.ШтатноеРасписание' table. You can move, or remove it, as needed.
            this.штатноеРасписаниеTableAdapter.Fill(this.courseworkDataSet.ШтатноеРасписание);
            // TODO: This line of code loads data into the 'courseworkDataSet.Sotr' table. You can move, or remove it, as needed.
            this.sotrTableAdapter.Fill(this.courseworkDataSet.Sotr);
        }

        private void b_move_Click(object sender, EventArgs e) {
            if(tb_salary.Text == "") {
                tb_error.Text = "Неверный формат ЗП";
                return;
            }
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
            my_command.CommandText = "Move";

            // создание входных параметров
            my_command.Parameters.Add("@ID", SqlDbType.Int);
            my_command.Parameters.Add("@b", SqlDbType.VarChar, 80);
            my_command.Parameters.Add("@after", SqlDbType.Int);
            my_command.Parameters.Add("@salary", SqlDbType.Int);
            my_command.Parameters.Add("@res", SqlDbType.VarChar, 60);

            try {
                my_command.Parameters["@ID"].Value = Convert.ToInt32(cb_sotr.SelectedValue.ToString());
            }
            catch {
                tb_error.Text = "ID не существует";
                return;
            }
            try {
                my_command.Parameters["@Salary"].Value = Convert.ToInt32(tb_salary.Text);
            }
            catch {
                tb_error.Text = "Неверный формат ЗП";
                return;
            }
            my_command.Parameters["@b"].Value = tb_place.Text;
            my_command.Parameters["@after"].Value = Convert.ToInt32(cb_place.SelectedValue.ToString());
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
            connection.Close();

            tb_error.Text = Convert.ToString((string)my_command.Parameters["@res"].Value);
            var t = new Timer();
            t.Interval = 2000;
            t.Tick += (s, ev) => {
                tb_error.Text = "";
                t.Stop();
            };
            t.Start();
            if(cb_doc.Checked) {
                if(tb_error.Text == "Перевод произведен") {
                    try {
                        save();
                    }
                    catch {
                        MessageBox.Show("Не удалось сохранить документ");
                    }
                }
            }
            int index = cb_sotr.SelectedIndex;
            this.sotrTableAdapter.Fill(this.courseworkDataSet.Sotr);
            cb_sotr.SelectedIndex = index;
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
            object file = Path.GetFullPath("MOVE.docx");
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
            d.Range.Replace("ДТ", today.ToString("dd.MM.yyyy"), new FindReplaceOptions(FindReplaceDirection.Forward));
            d.Range.Replace("ID", cb_sotr.SelectedValue.ToString(), new FindReplaceOptions(FindReplaceDirection.Forward));
            d.Range.Replace("ФИО", cb_sotr.Text, new FindReplaceOptions(FindReplaceDirection.Forward));
            d.Range.Replace("ДЖН", tb_place.Text, new FindReplaceOptions(FindReplaceDirection.Forward));
            d.Range.Replace("ДДН", cb_place.Text, new FindReplaceOptions(FindReplaceDirection.Forward));
            d.Range.Replace("ЗП", tb_salary.Text, new FindReplaceOptions(FindReplaceDirection.Forward));
            // Save the Word document
            d.Save(Path.GetFullPath(saveFileDialog1.FileName));
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
    }
}
