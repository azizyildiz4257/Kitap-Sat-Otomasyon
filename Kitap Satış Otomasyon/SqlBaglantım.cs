using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

public class SqlBaglantim
{
    public SqlConnection baglan()
    {
        SqlConnection baglan = new SqlConnection(@"Data Source=.;Initial Catalog=KitapSatisOtomasyon;Integrated Security=True");
        baglan.Open();
        return baglan;
    }
}
