using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FerretLib.WinForms.Demo;

namespace FerretLib.WinForms
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

        private void btnShowColorPicker_Click(object sender, EventArgs e)
        {
            (new frmDemoColorPicker()).ShowDialog();
        }

        private void btnShowRageMessageBox_Click(object sender, EventArgs e)
        {
            (new frmDemoRageMessageBox()).ShowDialog();
        }
    }
}
