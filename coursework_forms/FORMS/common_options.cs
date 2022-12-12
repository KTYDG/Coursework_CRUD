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
    public partial class common_options: Form {
        BindingSource bs = null;
        string date = "";
        public common_options(BindingSource b, string d) {
            InitializeComponent();
            bs = b;
            b.Filter = "";
            date = d;
            DateTime today = DateTime.Now;
            dtp_from.Value = today;
            dtp_to.Value = today;
        }
        private void b_exit_MouseEnter(object sender, EventArgs e) {
            ((Button)sender).BackColor = Color.Red;
        }
        private void b_exit_MouseLeave(object sender, EventArgs e) {
            ((Button)sender).BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(2)))), ((int)(((byte)(30)))));
        }

        private void tb_Enter(object sender, EventArgs e) {
            if(((TextBox)sender).Text == "0" || ((TextBox)sender).Text == "Иванов Иван") {
                ((TextBox)sender).ForeColor = Color.Crimson;
                ((TextBox)sender).Text = "";
            }
        }

        private void tb_id_Leave(object sender, EventArgs e) {
            if(((TextBox)sender).Text.Length == 0 || !((TextBox)sender).Text.All(char.IsDigit)) {
                ((TextBox)sender).ForeColor = Color.BlueViolet;
                ((TextBox)sender).Text = "0";

                bs.Filter = delete_option(bs.Filter, "ID =");
            }
        }
        private void tb_id_change(object sender, EventArgs e) {
            if(((TextBox)sender).Text.Length != 0 && ((TextBox)sender).Text.All(char.IsDigit) && ((TextBox)sender).Text != "0") {
                string option = delete_option(bs.Filter, "ID =");
                if(option.Length != 0)
                    option += " AND ";
                bs.Filter = option + "ID = " + ((TextBox)sender).Text;
            }
            else {
                bs.Filter = delete_option(bs.Filter, "ID =");
            }
        }
        private void tb_fio_Leave(object sender, EventArgs e) {
            if(((TextBox)sender).Text.Length == 0) {
                ((TextBox)sender).ForeColor = Color.BlueViolet;
                ((TextBox)sender).Text = "Иванов Иван";

                bs.Filter = delete_option(bs.Filter, "ФИО LIKE");
            }
        }
        private void tb_fio_change(object sender, EventArgs e) {
            if(((TextBox)sender).Text.Length != 0 && ((TextBox)sender).Text != "Иванов Иван") {
                string option = delete_option(bs.Filter, "ФИО LIKE");
                if(option.Length != 0)
                    option += " AND ";
                bs.Filter = option + "ФИО LIKE '%" + ((TextBox)sender).Text + "%'";
            }
            else {
                bs.Filter = delete_option(bs.Filter, "ФИО LIKE");
            }
        }
        private void b_clear_Click(object sender, EventArgs e) {
            bs.Filter = "";
            tb_fio.Text = "Иванов Иван";
            tb_fio.ForeColor = Color.BlueViolet;
            tb_id.Text = "0";
            tb_id.ForeColor = Color.BlueViolet;
            cb_from.Checked = false;
            cb_to.Checked = false;
        }
        private string delete_option(string options, string value) {
            string[] separating = { " AND " };
            string[] filters = options.Split(separating, System.StringSplitOptions.RemoveEmptyEntries);
            var list = new List<string>(filters);
            foreach(var filter in filters) {
                if(filter.Contains(value)) {
                    list.Remove(filter);
                }
            }
            filters = list.ToArray();
            return string.Join(" AND ", filters);
        }

        private void cb_from_CheckedChanged(object sender, EventArgs e) {
            if(cb_from.Checked) {
                string option = bs.Filter;
                if(option.Length != 0)
                    option += " AND ";
                option += date + " > " + "'" + dtp_from.Text + "'";
                bs.Filter = option;
            }
            else {
                bs.Filter = delete_option(bs.Filter, date + " >");
            }
        }

        private void cb_to_CheckedChanged(object sender, EventArgs e) {
            if(cb_to.Checked) {
                string option = bs.Filter;
                if(option.Length != 0)
                    option += " AND ";
                option += date + " <" + "'" + dtp_to.Text + "'";
                bs.Filter = option;
            }
            else {
                bs.Filter = delete_option(bs.Filter, date + " <");
            }
        }

        private void dtp_from_CloseUp(object sender, EventArgs e) {
            if(cb_from.Checked) {
                bs.Filter = delete_option(bs.Filter, date + " >");
                string option = bs.Filter;
                if(option.Length != 0)
                    option += " AND ";
                option += date + " > " + "'" + dtp_from.Text + "'";
                bs.Filter = option;
            }
            else {
                bs.Filter = delete_option(bs.Filter, date + " >");
            }
        }

        private void dtp_to_CloseUp(object sender, EventArgs e) {
            if(cb_to.Checked) {
                bs.Filter = delete_option(bs.Filter, date + " <");
                string option = bs.Filter;
                if(option.Length != 0)
                    option += " AND ";
                option += date + " <" + "'" + dtp_to.Text + "'";
                bs.Filter = option;
            }
            else {
                bs.Filter = delete_option(bs.Filter, date + " <");
            }
        }
    }
}
