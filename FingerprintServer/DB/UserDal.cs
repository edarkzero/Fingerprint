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

                frmMain.logControl.SetCurrent("Trying to log: " + name,true,false);

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
                        frmMain.logControl.SetCurrent("Logged: " + name, true, true);
                    }
                    else
                    {
                        name = info = "Invalid";
                        frmMain.logControl.SetCurrent("Invalid login data: " + name, true, true);
                    }
                }

                return name + "[{sep}]" + info;
            }
            else
            {
                frmMain.logControl.SetCurrent("Invalid login data: " + rawMessage, true, true);
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
