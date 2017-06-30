using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace DoAnLTGD
{
    class SQL
    {
        public static string ConnectionString = @"Server=DESKTOP-RVTFDNC\MSSQLSERVER12;Database=TuyenSinh;Trusted_Connection=True;";
        public static SqlConnection connection;
    }
}
