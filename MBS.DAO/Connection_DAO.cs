﻿using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MBSApp.DAO
{
    public class Connection_DAO
    {
        public SqlConnection Connect()
        {
            string cnstr = "Data Source=CLIMAX;Initial Catalog=mbwdb;Integrated Security=True";
            SqlConnection conn = new SqlConnection(cnstr);
            return conn;
        }
    }
}
