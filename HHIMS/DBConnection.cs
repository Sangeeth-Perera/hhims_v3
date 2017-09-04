using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Oracle.DataAccess.Client;

namespace HHIMS
{
    class DBConnection
    {
        private static string oradb = "Data Source=cmbtrndb02/app8sp2;User Id=ifsapp;Password=ifsapp;";
        OracleConnection conn;
        public DBConnection()
        {
            conn = new OracleConnection(oradb);  //Connection object
        }
        public OracleConnection Conn {
            get { return conn; }
            set { }
    }

    }
}







    



































        
  
