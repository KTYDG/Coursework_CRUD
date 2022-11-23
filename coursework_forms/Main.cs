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

namespace coursework_forms {
    public partial class Main: Form {
        int who, id;
        public Main(int w, int i) {
            who = w;
            id = i;
            InitializeComponent();
        }

        private void b_profile_Click(object sender, EventArgs e) {
            HideSubPanels(null);
            openChildForm(new profile(id));
        }
        private void b_sotr_Click(object sender, EventArgs e) {
            HideSubPanels(SotrSubPanel);
            SubPanelsOnClick(sender, (ShowSubPanel(SotrSubPanel)));
        }
        private void b_attes_Click(object sender, EventArgs e) {
            HideSubPanels(AttesSubPanel);
            SubPanelsOnClick(sender, (ShowSubPanel(AttesSubPanel)));
        }
        private void b_sotr_view_Click(object sender, EventArgs e) {
            openChildForm(new sotr_view());
        }
        private void b_exit_Click(object sender, EventArgs e) {
            this.Close();
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
        private void openChildForm(Form child) {
            if(activeForm != null) {
                activeForm.Close();
            }
            activeForm = child;
            child.TopLevel = false;
            child.FormBorderStyle = FormBorderStyle.None;
            child.Dock = DockStyle.Fill;
            p_form_view.Controls.Add(child);
            p_form_view.Tag = child;
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
