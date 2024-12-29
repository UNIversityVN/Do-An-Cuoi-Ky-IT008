using Project___Review_RBT;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Form_Main
{
    public partial class CauTrucDuLieu : Form
    {

        public CauTrucDuLieu()
        {
            InitializeComponent();
        }

        private void CauTrucDuLieu_Load(object sender, EventArgs e)
        {
            panel_main.Width = Width - panel_Tool.Width;
            panel_main.Height = Height;

        }

        private void button_RBT_Click(object sender, EventArgs e)
        {
            RedBlackForm redBlackForm = new RedBlackForm();
            HienThi(redBlackForm);
        }


        private void HienThi( Form form)
        {
            panel_main.Controls.Clear();
            form.TopLevel = false;
            form.FormBorderStyle = FormBorderStyle.None;
            form.Anchor = AnchorStyles.Top | AnchorStyles.Left;
            form.Dock = DockStyle.Fill;
            panel_main.Controls.Add(form);
            form.Show();
        }

        private void button_user_Click(object sender, EventArgs e)
        {
            User us = new User();
            HienThi(us);
        }
    }
}
