using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace FingerprintNetSample
{
    class LogControl
    {
        private string log;
        private string path;
        private string file;
        private string filePath;

        public LogControl()
        {
            log = string.Empty;
            path = "..\\..\\LOG\\";
            file = "finger_log.txt";
            filePath = path + file;
        }

        public void SetFile()
        {
            try
            {
                if (!Directory.Exists(path))
                {
                    DirectoryInfo di = Directory.CreateDirectory(path);
                }

                if (File.Exists(filePath))
                {
                    using (StreamWriter sw = File.AppendText(filePath))
                    {
                        sw.Write(log);
                    }
                }

                else
                {
                    using (StreamWriter sw = File.CreateText(filePath))
                    {
                        sw.Write(log);
                    }
                }
            }
            catch (Exception e)
            {
                System.Windows.Forms.MessageBox.Show("File creation failed: {0}", e.ToString());
            }
            finally { }
        }

        public string GetFile()
        {
            if (File.Exists(filePath))
            {
                using (StreamReader sr = File.OpenText(filePath))
                {
                    string s = "";
                    while ((s += sr.ReadLine()) != null) ;
                    return s;
                }
            }

            else
            {
                SetFile();
                return log;
            }
        }

        public string GetCurrent()
        {
            return log;
        }

        public void SetCurrent(string msj,bool addTime, bool doubleLine)
        {
            if(msj != null)
            {   
                log += Environment.NewLine + msj + " - TIME: " + DateTools.getNow();

                if (doubleLine)
                    log += Environment.NewLine;
            }
        }
    }
}
