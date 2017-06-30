using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoAnLTGD
{
    public class ConData
    {
        private SqlConnection connect;
        public SqlCommand cmd;
        private SqlDataAdapter da;
        private DataTable dt;

        public ConData()
        {
            connect = new SqlConnection(@"Data Source=DESKTOP-D0108LF\TRINHPHAM;Initial Catalog=QL_SinhVien;Integrated Security=True");
            connect.Open();
        
        }
        public void SqlQuery(string queryText)
        {
            
            cmd = connect.CreateCommand();
            cmd.CommandText = queryText;
        }
        public DataTable QueryEx()
        {
            da = new SqlDataAdapter(cmd);
            dt = new DataTable();
            da.Fill(dt);
            return dt; 
        }
      
    }
}
