using System;
using System.Collections.Generic;
using System.Text;

namespace FingerprintNetSample
{
    class DateTools
    {
        public static string datePatt = @"yyyy/M/d hh:mm:ss";

        public static string getNow()
        {
            DateTime saveNow = DateTime.Now;
            DateTime myDt;
            myDt = DateTime.SpecifyKind(saveNow, DateTimeKind.Local);
            myDt = myDt.ToLocalTime();  
            return myDt.ToString(datePatt);
        }
    }
}
