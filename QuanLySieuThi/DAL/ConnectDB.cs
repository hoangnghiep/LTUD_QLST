using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace DAL
{
    public class ConnectDB
    {
        protected SqlConnection conn = new SqlConnection("Data Source=.;Initial Catalog=QUANLYSIEUTHI;Integrated Security=True");
    }
}
