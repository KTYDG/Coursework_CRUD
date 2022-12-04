using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using coursework_forms.FORMS.sotr;

namespace coursework_forms {
    public partial class main: Form {
        private readonly int id;

        public main(int w, int i) {
            id = i;
            InitializeComponent();
            if(w != 1) {
                b_sotr_add.Visible = false;
                b_removed_remove.Visible = false;
                b_removed_restore.Visible = false;
                b_removed_delete.Visible = false;
            }
            else {
                b_sotr_add.Visible = true;
                b_removed_remove.Visible = true;
                b_removed_restore.Visible = true;
                b_removed_delete.Visible = true;
            }
        }

        private void b_profile_Click(object sender, EventArgs e) {
            HideSubPanels(null);
            openChildForm(new profile(id), p_form_view);
        }
        private void b_sotr_Click(object sender, EventArgs e) {
            HideSubPanels(SotrSubPanel);
            SubPanelsOnClick(sender, (ShowSubPanel(SotrSubPanel)));
        }
        private void b_sotr_view_Click(object sender, EventArgs e) {
            openChildForm(new sotr_view(), p_form_view);
        }
        private void b_sotr_edit_Click(object sender, EventArgs e) {
            openChildForm(new sotr_edit(), p_form_view);
        }
        private void b_sotr_add_Click(object sender, EventArgs e) {
            openChildForm(new sotr_add(), p_form_view);
        }
        private void b_sotr_move_Click(object sender, EventArgs e) {
            openChildForm(new sotr_move(), p_form_view);
        }
        private void b_removed_Click(object sender, EventArgs e) {
            HideSubPanels(RemovedSubPanel);
            SubPanelsOnClick(sender, (ShowSubPanel(RemovedSubPanel)));
        }
        private void b_removed_view_Click(object sender, EventArgs e) {
            openChildForm(new removed_view(), p_form_view);
        }
        private void b_removed_delete_Click(object sender, EventArgs e) {
            openChildForm(new removed_remove(), p_form_view);
        }
        private void b_removed_restore_Click(object sender, EventArgs e) {
            openChildForm(new removed_restore(), p_form_view);
        }
        private void b_removed_delete_Click_1(object sender, EventArgs e) {
            openChildForm(new removed_delete(), p_form_view);
        }
        private void b_tt_Click(object sender, EventArgs e) {
            openChildForm(new timetable(), p_form_view);
        }
        private void b_attes_Click(object sender, EventArgs e) {
            HideSubPanels(AttesSubPanel);
            SubPanelsOnClick(sender, (ShowSubPanel(AttesSubPanel)));
        }
        private void b_attes_view_Click(object sender, EventArgs e) {
            openChildForm(new attes_view(), p_form_view);
        }
        private void b_attes_add_Click(object sender, EventArgs e) {
            openChildForm(new attes_add(), p_form_view);
        }
        private void b_ill_Click(object sender, EventArgs e) {
            HideSubPanels(IllSubPanel);
            SubPanelsOnClick(sender, (ShowSubPanel(IllSubPanel)));
        }
        private void b_ill_view_Click(object sender, EventArgs e) {
            openChildForm(new ill_view(), p_form_view);
        }
        private void b_ill_add_Click(object sender, EventArgs e) {
            openChildForm(new ill_add(), p_form_view);
        }
        private void b_rest_Click(object sender, EventArgs e) {
            HideSubPanels(RestSubPanel);
            SubPanelsOnClick(sender, (ShowSubPanel(RestSubPanel)));
        }
        private void b_rest_view_Click(object sender, EventArgs e) {
            openChildForm(new rest_view(), p_form_view);
        }
        private void b_rest_add_Click(object sender, EventArgs e) {
            openChildForm(new rest_add(), p_form_view);
        }
        private void b_leave_Click(object sender, EventArgs e) {
            HideSubPanels(LeaveSubPanel);
            SubPanelsOnClick(sender, (ShowSubPanel(LeaveSubPanel)));
        }
        private void b_leave_view_Click(object sender, EventArgs e) {
            openChildForm(new leave_view(), p_form_view);
        }
        private void b_leave_add_Click(object sender, EventArgs e) {
            openChildForm(new leave_add(), p_form_view);
        }
        private void b_exit_Click(object sender, EventArgs e) {
            login l = Application.OpenForms.OfType<login>().SingleOrDefault();
            this.Close();
            l.Close();
        }

        private Color SetDefaultBackColor() {
            return System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(2)))), ((int)(((byte)(30)))));
        }
        private void SubPanelsOnClick(object sender, bool condition) {
            if(condition) {
                ((Button)sender).BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(10)))), ((int)(((byte)(77)))));
            }
            else {
                ((Button)sender).BackColor = SetDefaultBackColor();
            }
        }

        private void HideSubPanels(FlowLayoutPanel exept) {
            if(SotrSubPanel.Visible == true && SotrSubPanel != exept) {
                b_sotr.BackColor = SetDefaultBackColor();
                SotrSubPanel.Visible = false;
            }
            if(AttesSubPanel.Visible == true && AttesSubPanel != exept) {
                b_attes.BackColor = SetDefaultBackColor();
                AttesSubPanel.Visible = false;
            }
            if(RemovedSubPanel.Visible == true && RemovedSubPanel != exept) {
                b_removed.BackColor = SetDefaultBackColor();
                RemovedSubPanel.Visible = false;
            }
            if(IllSubPanel.Visible == true && IllSubPanel != exept) {
                b_ill.BackColor = SetDefaultBackColor();
                IllSubPanel.Visible = false;
            }
            if(RestSubPanel.Visible == true && RestSubPanel != exept) {
                b_rest.BackColor = SetDefaultBackColor();
                RestSubPanel.Visible = false;
            }
            if(LeaveSubPanel.Visible == true && LeaveSubPanel != exept) {
                b_leave.BackColor = SetDefaultBackColor();
                LeaveSubPanel.Visible = false;
            }
        }

        private bool ShowSubPanel(Panel sub) {
            if(sub.Visible == false) {
                sub.Visible = true;
                return true;
            }
            else {
                sub.Visible = false;
                return false;
            }
        }

        private Form activeForm = null;
        public void openChildForm(Form child, Panel To) {
            if(activeForm != null) {
                this.Width = 1300;
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


    }
}
