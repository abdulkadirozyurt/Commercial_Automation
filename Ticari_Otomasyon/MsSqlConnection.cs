using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ticari_Otomasyon
{
    public class MsSqlConnection
    {

        public SqlConnection ConnectSql()
        {


            SqlConnection connectionAddress = new SqlConnection(@"Data Source=DESKTOP-BUF0L8L;Initial Catalog=CommercialAutomation;Integrated Security=True");

            connectionAddress.Open();
            return connectionAddress;


        }

    }
}
