using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinAppLaberynth
{
    public partial class frmMenu : Form
    {
        public frmMenu()
        {
            InitializeComponent();
        }

        private void frmMenu_Load(object sender, EventArgs e)
        {

        }

        private void btnBeginnerManual_Click(object sender, EventArgs e)
        {
            frmBeginnerManual ObjForm = new frmBeginnerManual();
            ObjForm.Show();
        }

        private void btnBeginnerAutomatic_Click(object sender, EventArgs e)
        {
            frmBeginnerAutomaticRight ObjForm = new frmBeginnerAutomaticRight();
            ObjForm.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            frmBeginnerAutomaticLeft ObjForm = new frmBeginnerAutomaticLeft();
            ObjForm.Show();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
