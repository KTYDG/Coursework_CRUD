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
    public partial class removed_remove: Form {
        public removed_remove() {
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
            // TODO: This line of code loads data into the 'courseworkDataSet.Sotr' table. You can move, or remove it, as needed.
            this.sotrTableAdapter.Fill(this.courseworkDataSet.Sotr);
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
            my_command.CommandText = "RemoveSotr";

            // создание входных параметров
            my_command.Parameters.Add("@ID", SqlDbType.Int);
            my_command.Parameters.Add("@reason", SqlDbType.VarChar, 256);
            my_command.Parameters.Add("@a_date", SqlDbType.Date);
            my_command.Parameters.Add("@res", SqlDbType.VarChar, 60);

            try {
                my_command.Parameters["@ID"].Value = Convert.ToInt32(cb_sotr.SelectedValue.ToString());
            }
            catch {
                tb_error.Text = "ID не существует";
                return;
            }
            my_command.Parameters["@reason"].Value = rtb_reason.Text;
            my_command.Parameters["@res"].Direction = ParameterDirection.Output;
            my_command.Parameters["@a_date"].Direction = ParameterDirection.Output;

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

            if(tb_error.Text == "Сотрудник уволен") {
                DateTime start = (DateTime)my_command.Parameters["@a_date"].Value;
                try {
                    save(start);
                }
                catch {
                    MessageBox.Show("Не удалось сохранить документ");
                }
            }

        }

        private void save(DateTime start) {
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
            object file = Path.GetFullPath("REMOVE.docx");
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
            d.Range.Replace("ДДА", start.ToString("dd.MM.yyyy"), new FindReplaceOptions(FindReplaceDirection.Forward));
            d.Range.Replace("ID", cb_sotr.SelectedValue.ToString(), new FindReplaceOptions(FindReplaceDirection.Forward));
            d.Range.Replace("ФИО", cb_sotr.Text, new FindReplaceOptions(FindReplaceDirection.Forward));
            d.Range.Replace("ДЖН", tb_place.Text, new FindReplaceOptions(FindReplaceDirection.Forward));
            d.Range.Replace("ПРИЧИНА", rtb_reason.Text, new FindReplaceOptions(FindReplaceDirection.Forward));
            // Save the Word document
            d.Save(Path.GetFullPath(saveFileDialog1.FileName));
        }
    }
}
