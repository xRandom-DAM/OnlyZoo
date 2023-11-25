﻿using MySqlX.XDevAPI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Data;
using OnlyZoo.util;

namespace OnlyZoo.drivers
{
    public class DBConnection
    {
        private static MySqlConnection Conn;
        public static MySqlConnection GetConnection()
        {
            if (Conn == null) Conn = new MySqlConnection(Constants.DBString);
            else
            {
                if (Conn.State == ConnectionState.Closed) Conn.Open();
                else if (Conn.State == ConnectionState.Broken)
                {
                    Conn.Close();
                    Conn.Open();
                }
            }
            return Conn;
        }
        public static void Close() { Conn.Close();}
    }
}
