﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace LoginRegis
{
    public partial class FrmLogin : Form
    {
        public FrmLogin()
        {
            InitializeComponent();
        }

        oCenter oC = new oCenter(); 

        private void txtUsername_Enter(object sender, EventArgs e)
        {
            oC.CheckEnterTextBox(txtUsername, "Username");
        }

        private void txtPassword_Enter(object sender, EventArgs e)
        {
            oC.CheckEnterTextBox(txtPassword, "Password");
        }

        private void txtUsername_Leave(object sender, EventArgs e)
        {
            oC.CheckLeaveTextBox(txtUsername, "Username");
        }

        private void txtPassword_Leave(object sender, EventArgs e)
        {
            oC.CheckLeaveTextBox(txtPassword, "Password");
        }

        private void cmdExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void cmdRegister_Click(object sender, EventArgs e)
        {
            FrmRegister Frm = new FrmRegister();
            Frm.ShowDialog();
        }

        private void cmdLogin_Click(object sender, EventArgs e)
        { 
            if (txtUsername.Text.Equals("") || txtUsername.Text.Equals("Username"))
            {
                MessageBox.Show("Input Username", "Msg", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (txtPassword.Text.Equals("") || txtPassword.Text.Equals("Password"))
            {
                MessageBox.Show("Input Password", "Msg", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            DataSet dsAction = new DataSet("Sample");
            string sSqlSave = "SELECT * FROM tbUser WHERE Username = '" + txtUsername.Text.Trim() + "' AND LPassword = '"+ txtPassword.Text+"'";
            dsAction = oC.ShowData(sSqlSave, "tbUser", dsAction);
            if (dsAction.Tables["tbUser"].Rows.Count > 0)
            {

                oCenter.sFirstName = dsAction.Tables["tbUser"].Rows[0]["FirstName"].ToString();
                oCenter.sUsername = dsAction.Tables["tbUser"].Rows[0]["Username"].ToString();
                oCenter.sEmail = dsAction.Tables["tbUser"].Rows[0]["Email"].ToString();
                Score s = new Score();
                s.Show();
               

            }
            else
            {
                MessageBox.Show("Login Fail", "Msg", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtUsername.Text = "";
                txtPassword.Text = "";

            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            FrnGame f = new FrnGame();
            f.Show();
        }
    }
}
