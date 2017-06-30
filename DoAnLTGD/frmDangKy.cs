using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DoAnLTGD
{
    public partial class frmDangKy : Form
    {
        private ConData con;
        public frmDangKy()
        {
            InitializeComponent();
        }
       
  
        private void btnĐangKy_Click(object sender, EventArgs e)
        {
            string tenDangNhap = txtEditDangNhap.Text;
            string matKhau = txtEditNhapMatKhau.Text;
            con = new ConData();
            string sql = "insert into username (username, pass) values ('"+tenDangNhap+"','"+matKhau+"')";
           
            con.SqlQuery(sql);
            int result = con.cmd.ExecuteNonQuery();
            if ( result > 0)
            {
                MessageBox.Show("Thanh Cong");
            }
       
        }
    }
}
