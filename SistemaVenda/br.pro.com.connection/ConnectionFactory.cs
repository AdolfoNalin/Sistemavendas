﻿using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaVenda.br.pro.com.connection
{
    public class ConnectionFactory
    {
        public MySqlConnection getConnection()
        {
            string connection = ConfigurationManager.ConnectionStrings["bdvendas2"].ConnectionString;
            return new MySqlConnection(connection);
        }
    }
}
