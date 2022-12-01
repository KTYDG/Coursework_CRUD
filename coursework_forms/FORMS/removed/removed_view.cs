using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace coursework_forms {
    public partial class removed_view: Form {

        public removed_view() {
            InitializeComponent();
            const int dist = 24;
        }

        private void sotr_view_Load(object sender, EventArgs e) {
            // TODO: This line of code loads data into the 'courseworkDataSet.Removed' table. You can move, or remove it, as needed.
            this.removedTableAdapter.Fill(this.courseworkDataSet.Removed);

        }
        private void b_exit_Click(object sender, EventArgs e) {
            main m = Application.OpenForms.OfType<main>().SingleOrDefault();
            if(Application.OpenForms.OfType<sotr_options>().Count() == 1) {
                Application.OpenForms.OfType<sotr_options>().First().Close();
                m.Width = 1300;
            }
            this.Close();
        }
        private void b_options_Click(object sender, EventArgs e) {
            main m = Application.OpenForms.OfType<main>().SingleOrDefault();
            if(Application.OpenForms.OfType<sotr_options>().Count() == 1) {
                Application.OpenForms.OfType<sotr_options>().First().Close();
                m.Width = 1300;
                return;
            }
            m.Width = 1650;
            this.Width = 1500;
            this.p_filter_options.Width = 350;
            openChildForm(new sotr_options(), p_filter_options);
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

        private void drg_DataError(object sender, DataGridViewDataErrorEventArgs e) {
            string col_name = dgv_sotr.Columns[e.ColumnIndex].HeaderText;
            MessageBox.Show(String.Format("Неверный формат введеных данных в столбце: {0}", col_name));
        }
    }
}
