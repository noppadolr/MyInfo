using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySqlConnector;
using MySql.Data;
using MySql.Data.MySqlClient;

namespace MyInfo
{


    class ConnectDB
    {
        string jhcisConString;
        string serverConString;
        string HdcConstring;
        private string getJhcisConString()
        {
            var p = Properties.Settings.Default;
            MySqlConnectionStringBuilder scb = new MySqlConnectionStringBuilder();
            scb.Server = p.jHost;
            scb.Port = p.jPort;
            scb.Database = p.jDb;
            scb.UserID = p.jUsername;
            scb.Password = p.jPassword;
            jhcisConString = scb.ConnectionString + ";AllowLoadLocalInfile=True;Allow User Variables=true";
            return jhcisConString;
        }
        private string getServerConString()
        {
            var p = Properties.Settings.Default;
            MySqlConnectionStringBuilder scb = new MySqlConnectionStringBuilder();
            scb.Server = p.sHost;
            scb.Port = p.sPort;
            scb.Database = p.sDb;
            scb.UserID = p.sUsername;
            scb.Password = p.sPassword;
            serverConString = scb.ConnectionString + ";AllowLoadLocalInfile=True;Allow User Variables=true";
            return serverConString;
        }


        private string getHdcConString()
        {
            var p = Properties.Settings.Default;
            MySqlConnectionStringBuilder scb = new MySqlConnectionStringBuilder();
            scb.Server = p.hHost;
            scb.Port = p.hPort;
            scb.Database = p.hDb;
            scb.UserID = p.hUsername;
            scb.Password = p.hPassword;
            HdcConstring = scb.ConnectionString + ";AllowLoadLocalInfile=True;Allow User Variables=true";
            return HdcConstring;
        }
        public MySqlConnection hdcConnection()
        {
            MySqlConnection hdcCon = new MySqlConnection(getHdcConString());
            return hdcCon;
        }
        public MySqlConnection jhcisConnection()
        {
            MySqlConnection jhcisCon = new MySqlConnection(getJhcisConString());
            return jhcisCon;
        }

        public MySqlConnection serverConnection()
        {
            MySqlConnection serverCon = new MySqlConnection(getServerConString());
            return serverCon;
        }




    }
}
