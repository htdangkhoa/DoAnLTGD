using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace DoAnLTGD.WindowsForm
{
    public partial class Login : Form
    {
        private Main main;
        public Login(Main m)
        {
            InitializeComponent();
            main = m;

            txtLoginPassword.PasswordChar = '\u25CF';
        }

        private void btnLoginExit_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        private void btnLoginLogin_Click(object sender, EventArgs e)
        {
            SQL.connection.Open();
            SqlCommand cmd = new SqlCommand("SELECT * FROM Username WHERE username='" + txtLoginUsername.Text + "' AND pass='" + txtLoginPassword.Text + "'", SQL.connection);
            using (SqlDataReader reader = cmd.ExecuteReader())
            {
                if (reader.Read())
                {
                    Features features = new Features();
                    features.TopLevel = false;

                    // Center screen.
                    int x = (main.panel.Width - features.Width) / 2;
                    int y = (main.panel.Height - features.Height) / 2;
                    features.Location = new Point(x, y);
                    features.Anchor = AnchorStyles.None;

                    main.panel.Controls.Add(features);
                    features.Show();

                    main.panel.Controls.Remove(this);
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Username or password is incorrect!!!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            SQL.connection.Close();
        }
    }
}
