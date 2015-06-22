using System;
using System.Collections.Generic;
using System.Data;
using System.Data.OleDb;
using System.Text;

namespace FingerprintNetSample.DB
{
    class UserDal
    {
        public OleDbConnection dbConection;
        public readonly string CONNECTION_STRING = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=..\\..\\DB\\FingerprintSample.mdb";

        public UserDal()
        {
            dbConection = new OleDbConnection(CONNECTION_STRING);
        }

        public string getUserDataByClientRequest(string rawMessage)
        {
            string strCommand = "SELECT * FROM [USER] WHERE [Name] = ? AND [Password] = ?";

            if (rawMessage.Contains("[{sep}]"))
            {
                dbConection.Open();

                string[] fields = rawMessage.Split(new string[] { "[{sep}]" }, StringSplitOptions.RemoveEmptyEntries);
                string name = fields[0];
                string password = fields[1].Replace("<EOF>", "");
                string info;
                //Console.WriteLine(name + ", " + password);
                string msj = name;

                frmMain.Log += Environment.NewLine + "Trying to log: " + msj+" - TIME: "+DateTools.getNow();

                OleDbCommand oleCommand = new OleDbCommand(strCommand, dbConection);
                oleCommand.Parameters.Add(new OleDbParameter("@name", OleDbType.VarChar));
                oleCommand.Parameters["@name"].Value = name;
                oleCommand.Parameters.Add(new OleDbParameter("@password", OleDbType.LongVarChar));
                oleCommand.Parameters["@password"].Value = password;
                Console.WriteLine(oleCommand.CommandText);
                OleDbDataReader dataReader = oleCommand.ExecuteReader();

                using (dataReader)
                {
                    if (dataReader.Read())
                    {
                        name = Convert.ToString(dataReader["Name"]);
                        info = Convert.ToString(dataReader["Info"]);
                        frmMain.Log += Environment.NewLine + "Logged: " + msj + Environment.NewLine + " - TIME: " + DateTools.getNow();
                    }
                    else
                    {
                        name = info = "Invalid";
                        frmMain.Log += Environment.NewLine + "Invalid login data: " + msj + Environment.NewLine + " - TIME: " + DateTools.getNow();
                    }
                }

                return name + "[{sep}]" + info;
            }
            else
            {
                frmMain.Log += Environment.NewLine + "Invalid login data: " + rawMessage + Environment.NewLine + " - TIME: " + DateTools.getNow();
                return "Invalid2[{sep}]Invalid2";
            }
        }

        ~UserDal() 
        {
            if (dbConection.State == ConnectionState.Open) 
            {
                try
                {                  
                    dbConection.Dispose();
                }
                catch { }
            }
        }
    }
}
