using System;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace coursework_forms {
    public partial class sotr_options: Form {

        public sotr_options() {
            InitializeComponent();
        }
        private void b_exit_MouseEnter(object sender, EventArgs e) {
            ((Button)sender).BackColor = Color.Red;
        }
        private void b_exit_MouseLeave(object sender, EventArgs e) {
            ((Button)sender).BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(2)))), ((int)(((byte)(30)))));
        }

        private void tb_Enter(object sender, EventArgs e) {
            if(((TextBox)sender).Text == "От" || ((TextBox)sender).Text == "До" || ((TextBox)sender).Text == "0" || ((TextBox)sender).Text == "Иванов Иван" || ((TextBox)sender).Text == "директор") {
                ((TextBox)sender).ForeColor = Color.Crimson;
                ((TextBox)sender).Text = "";
            }
        }
        private void tb_from_Leave(object sender, EventArgs e) {
            if(((TextBox)sender).Text.Length == 0 || !((TextBox)sender).Text.All(char.IsDigit)) {
                ((TextBox)sender).ForeColor = Color.BlueViolet;
                ((TextBox)sender).Text = "От";
                sotr_view v = Application.OpenForms.OfType<sotr_view>().SingleOrDefault();
                if(tb_salary_min.Text == "От")
                    v.sotrBindingSource.Filter = delete_option(v.sotrBindingSource.Filter, "ЗП >=");
                if(tb_stage_min.Text == "От")
                    v.sotrBindingSource.Filter = delete_option(v.sotrBindingSource.Filter, "Стаж >=");
            }
        }
        private void tb_from_changed(object sender, EventArgs e) {
            sotr_view v = Application.OpenForms.OfType<sotr_view>().SingleOrDefault();
            if(((TextBox)sender).Text.Length != 0 && ((TextBox)sender).Text.All(char.IsDigit)) {
                if(((TextBox)sender) == tb_salary_min) {
                    string option = delete_option(v.sotrBindingSource.Filter, "ЗП >=");
                    if(option.Length != 0)
                        option += " AND ";
                    v.sotrBindingSource.Filter = option + "ЗП >= " + ((TextBox)sender).Text;
                }
                if(((TextBox)sender) == tb_stage_min) {
                    string option = delete_option(v.sotrBindingSource.Filter, "Стаж >=");
                    if(option.Length != 0)
                        option += " AND ";
                    v.sotrBindingSource.Filter = option + "Стаж >= " + ((TextBox)sender).Text;
                }
            }
            else {
                if(((TextBox)sender) == tb_salary_min) {
                    v.sotrBindingSource.Filter = delete_option(v.sotrBindingSource.Filter, "ЗП >=");
                }
                if(((TextBox)sender) == tb_stage_min) {
                    v.sotrBindingSource.Filter = delete_option(v.sotrBindingSource.Filter, "Стаж >=");
                }
            }
        }
        private void tb_to_Leave(object sender, EventArgs e) {
            if(((TextBox)sender).Text.Length == 0 || !((TextBox)sender).Text.All(char.IsDigit)) {
                ((TextBox)sender).ForeColor = Color.BlueViolet;
                ((TextBox)sender).Text = "До";
                sotr_view v = Application.OpenForms.OfType<sotr_view>().SingleOrDefault();
                if(tb_salary_max.Text == "До")
                    v.sotrBindingSource.Filter = delete_option(v.sotrBindingSource.Filter, "ЗП <=");
                if(tb_stage_max.Text == "До")
                    v.sotrBindingSource.Filter = delete_option(v.sotrBindingSource.Filter, "Стаж <=");
                if(tb_salary_min.Text == "От")
                    v.sotrBindingSource.Filter = delete_option(v.sotrBindingSource.Filter, "ЗП >=");
                if(tb_stage_min.Text == "От")
                    v.sotrBindingSource.Filter = delete_option(v.sotrBindingSource.Filter, "Стаж >=");
            }
        }
        private void tb_to_changed(object sender, EventArgs e) {
            sotr_view v = Application.OpenForms.OfType<sotr_view>().SingleOrDefault();
            if(((TextBox)sender).Text.Length != 0 && ((TextBox)sender).Text.All(char.IsDigit)) {
                if(((TextBox)sender) == tb_salary_max) {
                    string option = delete_option(v.sotrBindingSource.Filter, "ЗП <=");
                    if(option.Length != 0)
                        option += " AND ";
                    v.sotrBindingSource.Filter = option + "ЗП <= " + ((TextBox)sender).Text;
                }
                if(((TextBox)sender) == tb_stage_max) {
                    string option = delete_option(v.sotrBindingSource.Filter, "Стаж <=");
                    if(option.Length != 0)
                        option += " AND ";
                    v.sotrBindingSource.Filter = option + "Стаж <= " + ((TextBox)sender).Text;
                }
            }
            else {
                if(((TextBox)sender) == tb_salary_max) {
                    v.sotrBindingSource.Filter = delete_option(v.sotrBindingSource.Filter, "ЗП <=");
                }
                if(((TextBox)sender) == tb_stage_max) {
                    v.sotrBindingSource.Filter = delete_option(v.sotrBindingSource.Filter, "Стаж <=");
                }
            }
        }

        private void tb_id_Leave(object sender, EventArgs e) {
            if(((TextBox)sender).Text.Length == 0 || !((TextBox)sender).Text.All(char.IsDigit)) {
                ((TextBox)sender).ForeColor = Color.BlueViolet;
                ((TextBox)sender).Text = "0";
                sotr_view v = Application.OpenForms.OfType<sotr_view>().SingleOrDefault();
                v.sotrBindingSource.Filter = delete_option(v.sotrBindingSource.Filter, "ID =");
            }
        }
        private void tb_id_change(object sender, EventArgs e) {
            sotr_view v = Application.OpenForms.OfType<sotr_view>().SingleOrDefault();
            if(((TextBox)sender).Text.Length != 0 && ((TextBox)sender).Text.All(char.IsDigit) && ((TextBox)sender).Text != "0") {
                string option = delete_option(v.sotrBindingSource.Filter, "ID =");
                if(option.Length != 0)
                    option += " AND ";
                v.sotrBindingSource.Filter = option + "ID = " + ((TextBox)sender).Text;
            }
            else {
                v.sotrBindingSource.Filter = delete_option(v.sotrBindingSource.Filter, "ID =");
            }
        }
        private void tb_td_Leave(object sender, EventArgs e) {
            if(((TextBox)sender).Text.Length == 0 || !((TextBox)sender).Text.All(char.IsDigit)) {
                ((TextBox)sender).ForeColor = Color.BlueViolet;
                ((TextBox)sender).Text = "0";
                sotr_view v = Application.OpenForms.OfType<sotr_view>().SingleOrDefault();
                v.sotrBindingSource.Filter = delete_option(v.sotrBindingSource.Filter, "ТД =");
            }
        }
        private void tb_td_change(object sender, EventArgs e) {
            sotr_view v = Application.OpenForms.OfType<sotr_view>().SingleOrDefault();
            if(((TextBox)sender).Text.Length != 0 && ((TextBox)sender).Text.All(char.IsDigit) && ((TextBox)sender).Text != "0") {
                string option = delete_option(v.sotrBindingSource.Filter, "ТД =");
                if(option.Length != 0)
                    option += " AND ";
                v.sotrBindingSource.Filter = option + "ТД = " + ((TextBox)sender).Text;
            }
            else {
                v.sotrBindingSource.Filter = delete_option(v.sotrBindingSource.Filter, "ТД =");
            }
        }
        private void tb_fio_Leave(object sender, EventArgs e) {
            if(((TextBox)sender).Text.Length == 0) {
                ((TextBox)sender).ForeColor = Color.BlueViolet;
                ((TextBox)sender).Text = "Иванов Иван";
                sotr_view v = Application.OpenForms.OfType<sotr_view>().SingleOrDefault();
                v.sotrBindingSource.Filter = delete_option(v.sotrBindingSource.Filter, "ФИО LIKE");
            }
        }
        private void tb_fio_change(object sender, EventArgs e) {
            sotr_view v = Application.OpenForms.OfType<sotr_view>().SingleOrDefault();
            if(((TextBox)sender).Text.Length != 0 && ((TextBox)sender).Text != "Иванов Иван") {
                string option = delete_option(v.sotrBindingSource.Filter, "ФИО LIKE");
                if(option.Length != 0)
                    option += " AND ";
                v.sotrBindingSource.Filter = option + "ФИО LIKE '%" + ((TextBox)sender).Text + "%'";
            }
            else {
                v.sotrBindingSource.Filter = delete_option(v.sotrBindingSource.Filter, "ФИО LIKE");
            }
        }
        private void tb_work_Leave(object sender, EventArgs e) {
            if(((TextBox)sender).Text.Length == 0) {
                ((TextBox)sender).ForeColor = Color.BlueViolet;
                ((TextBox)sender).Text = "директор";
                sotr_view v = Application.OpenForms.OfType<sotr_view>().SingleOrDefault();
                v.sotrBindingSource.Filter = delete_option(v.sotrBindingSource.Filter, "Должность LIKE");
            }
        }
        private void tb_work_change(object sender, EventArgs e) {
            sotr_view v = Application.OpenForms.OfType<sotr_view>().SingleOrDefault();
            if(((TextBox)sender).Text.Length != 0 && ((TextBox)sender).Text != "директор") {
                string option = delete_option(v.sotrBindingSource.Filter, "Должность LIKE");
                if(option.Length != 0)
                    option += " AND ";
                v.sotrBindingSource.Filter = option + "Должность LIKE '%" + ((TextBox)sender).Text + "%'";
            }
            else {
                v.sotrBindingSource.Filter = delete_option(v.sotrBindingSource.Filter, "Должность LIKE");
            }
        }
        private void rb_change(object sender, EventArgs e) {
            sotr_view v = Application.OpenForms.OfType<sotr_view>().SingleOrDefault();
            if(rb_n.Checked) {
                v.sotrBindingSource.Filter = delete_option(v.sotrBindingSource.Filter, "Пол =");
            }
            else if(rb_m.Checked) {
                string option = delete_option(v.sotrBindingSource.Filter, "Пол =");
                if(option.Length != 0)
                    option += " AND ";
                v.sotrBindingSource.Filter = option + "Пол = 'М'";
            }
            else {
                string option = delete_option(v.sotrBindingSource.Filter, "Пол =");
                if(option.Length != 0)
                    option += " AND ";
                v.sotrBindingSource.Filter = option + "Пол = 'Ж'";
            }
        }
        private void b_clear_Click(object sender, EventArgs e) {
            sotr_view v = Application.OpenForms.OfType<sotr_view>().SingleOrDefault();
            v.sotrBindingSource.Filter = "";
            tb_fio.Text = "Иванов Иван";
            tb_fio.ForeColor = Color.BlueViolet;
            tb_work.Text = "директор";
            tb_work.ForeColor = Color.BlueViolet;
            tb_id.Text = "0";
            tb_id.ForeColor = Color.BlueViolet;
            tb_td.Text = "0";
            tb_td.ForeColor = Color.BlueViolet;
            tb_salary_min.Text = "От";
            tb_salary_min.ForeColor = Color.BlueViolet;
            tb_salary_max.Text = "До";
            tb_salary_max.ForeColor = Color.BlueViolet;
            tb_stage_min.Text = "От";
            tb_stage_min.ForeColor = Color.BlueViolet;
            tb_stage_max.Text = "До";
            tb_stage_max.ForeColor = Color.BlueViolet;
            rb_n.Checked = true;
        }
        private string delete_option(string options, string value) {
            string[] separating = { "AND" };
            string[] filters = options.Split(separating, System.StringSplitOptions.RemoveEmptyEntries);
            foreach(var filter in filters) {
                if(filter.Contains(value)) {
                    filters = filters.Where(f => f != filter).ToArray();
                }
            }
            return string.Join(" AND ", filters);
        }
    }
}
