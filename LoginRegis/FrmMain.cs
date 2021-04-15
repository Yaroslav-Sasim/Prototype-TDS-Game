using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace LoginRegis
{
    public partial class FrmMain : Form
    {
        public FrmMain()
        {
            InitializeComponent();
        }

        oCenter oC = new oCenter();
        private void FrmMain_Load(object sender, EventArgs e)
        {
           

            if (oCenter.sFirstName.Equals(""))
            {
                Application.Exit();
            }

            lblFirstName.Text = "Имя : " + oCenter.sFirstName;
            lblLastName.Text = "Никнейм : " + oCenter.sLastName;
            lblEmail.Text = "Email : " + oCenter.sEmail;
        }

        private void cmdExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FrnGame f = new FrnGame();
            f.Show();
        }
    }
}
