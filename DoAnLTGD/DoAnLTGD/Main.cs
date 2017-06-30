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

namespace DoAnLTGD
{
    public partial class Main : Form
    {
        WindowsForm.Login login;

        public Main()
        {
            InitializeComponent();

            SQL.connection = new SqlConnection(SQL.ConnectionString);
        }

        /************************** Function. **************************/
        private WindowsForm.Login initLogin()
        {
            WindowsForm.Login login = new WindowsForm.Login(this);
            login.TopLevel = false;

            // Center screen.
            int x = (this.panel.Width - login.Width) / 2;
            int y = (this.panel.Height - login.Height) / 2;
            login.Location = new Point(x, y);
            login.Anchor = AnchorStyles.None;

            return login;
        }
        /********************** End Function.***********************/



        /************************** Event. **************************/
        private void Main_Load(object sender, EventArgs e)
        {
            login = initLogin();
            panel.Controls.Add(login);
            login.Show();
        }

        
        /************************ End Event. ***********************/
    }
}
