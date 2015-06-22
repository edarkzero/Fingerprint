using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Data.OleDb;
using System.Data.Common;
using GriauleFingerprintLibrary.DataTypes;
using System.Windows.Forms;
using Fingerprint.Password;

namespace FingerprintNetSample.DB.Dal
{
    public sealed class AccessDataAccessLayer : IGRDal
    {
        public OleDbConnection dbConection;
        public readonly string CONNECTION_STRING = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=";
        public readonly string CONNECTION_SOURCE_STRING = "..\\..\\DB\\FingerprintSample.mdb";
        private string joinUserCommand;
        private string joinUserEnrollCommand;

        private AccessDataAccessLayer() 
        {
            dbConection = new OleDbConnection(CONNECTION_STRING+CONNECTION_SOURCE_STRING);
            this.joinUserEnrollCommand = "LEFT JOIN USER ON USER.ID = ENROLL.ID_user";
        }

        public int SaveUser(string name, string info, string password)
        {
            /*using(OleDbConnection myCon = new OleDbConnection(CONNECTION_STRING))
            {
               myCon.Open(); 
               OleDbCommand cmd = new OleDbCommand(); 
               cmd.CommandType = CommandType.Text; 
               cmd.CommandText = "INSERT INTO [USER] ([Name],[Info]) values (@name,@info)";
               cmd.Parameters.AddWithValue("@name", name);
               cmd.Parameters.AddWithValue("@info", info); 
               cmd.Connection = myCon; 
               cmd.ExecuteNonQuery();
               myCon.Close();
               return 1;
            }*/

            using (dbConection)
            {
                dbConection.Open();                

                string strCommand = "INSERT INTO [USER] ([Name],[Info],[Password]) VALUES (?,?,?)";
                string strCommand2 = "Select @@Identity";
                OleDbCommand oleCommand = new OleDbCommand(strCommand, dbConection);

                oleCommand.Parameters.Add(new OleDbParameter("@name", OleDbType.VarChar));
                oleCommand.Parameters["@name"].Value = name;
                oleCommand.Parameters.Add(new OleDbParameter("@info", OleDbType.VarChar));
                oleCommand.Parameters["@info"].Value = info;
                oleCommand.Parameters.Add(new OleDbParameter("@password", OleDbType.LongVarChar));
                oleCommand.Parameters["@password"].Value = Password.GenerateHashWithSalt(password);
                oleCommand.ExecuteNonQuery();

                oleCommand.CommandText = strCommand2;
                return (int)oleCommand.ExecuteScalar();
            }
        }

        public void SaveTemplate(FingerprintTemplate fingerprintTemplate,int userID = 0) 
        {
            
                using (dbConection)
                {
                    dbConection.Open();

                    string strCommand;
                    bool validUserID = userID > 0;

                    if (validUserID)
                        strCommand = "INSERT INTO ENROLL(template,quality,[ID_user]) VALUES (?,?,?)";                        
                    else
                        strCommand = "INSERT INTO ENROLL(template,quality) VALUES (?,?)";

                    OleDbCommand oleCommand = new OleDbCommand(strCommand, dbConection);
                    oleCommand.Parameters.Add(new OleDbParameter("@template", OleDbType.VarBinary, fingerprintTemplate.Size, ParameterDirection.Input, false, 0, 0, "ID", DataRowVersion.Current, fingerprintTemplate.Buffer));
                    oleCommand.Parameters.Add(new OleDbParameter("@quality", OleDbType.Integer));
                    oleCommand.Parameters["@quality"].Value = fingerprintTemplate.Quality;

                    if(validUserID)
                    {
                        oleCommand.Parameters.Add(new OleDbParameter("@user", OleDbType.Integer));
                        oleCommand.Parameters["@user"].Value = userID;
                    }

                    oleCommand.ExecuteNonQuery();
                }
            
            
        }

        public IDataReader GetTemplates() 
        {
            
           
               dbConection.Open();

                string strCommand = "SELECT Enroll.Template, Enroll.quality, Enroll.ID AS Enroll_ID, Enroll.ID_user, User.ID AS User_ID, User.Name, User.Info FROM [User] INNER JOIN Enroll ON User.[ID] = Enroll.[ID_user]";

                OleDbCommand oleCommand = new OleDbCommand(strCommand, dbConection);

                return oleCommand.ExecuteReader();
            
        }

        ~AccessDataAccessLayer() 
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

        public IDataReader GetTemplate(int idTemplate)
        {
            dbConection.Open();
            string strCommand = "SELECT * FROM ENROLL "+this.joinUserEnrollCommand+" WHERE ID = ?";

            OleDbCommand oleCommand = new OleDbCommand(strCommand, dbConection);
            oleCommand.Parameters.Add(new OleDbParameter("@ID",idTemplate));

            return oleCommand.ExecuteReader();
        }

        public void DeleteTemplate(int idTemplate) { }

        public void DeleteTemplate() 
        {
            using (dbConection) 
            {
                dbConection.Open();

                string strCommand = "DELETE * FROM ENROLL";

                OleDbCommand oleCommand = new OleDbCommand(strCommand, dbConection);
                oleCommand.ExecuteNonQuery();
            }
        }

        /*public void openConectionDB()
        {
            try
            {
                dbConection.Open();
            }catch(Exception ex)
            {
                OpenFileDialog dialog = new OpenFileDialog();
                dialog.Filter = "Access Database Files (.mdb)|*.mdb";
                dialog.FilterIndex = 1;
                dialog.Multiselect = false;

                if (dialog.ShowDialog() == DialogResult.OK)
                {
                    CONNECTION_SOURCE_STRING = dialog.FileName;
                    dbConection = new OleDbConnection(CONNECTION_STRING + CONNECTION_SOURCE_STRING);
                    dbConection.Open();
                }
            }
        }*/

    }
}
