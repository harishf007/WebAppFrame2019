using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Text;

namespace WebAppFrame2019
{
    public class PWOption
    {
        public string SimplEncryptn(string pwToEncrypt)
        {
            string pwEncryptd = null;
            string pwToEncrpt = null;
            string pwChar = null;
            int i;

            pwToEncrpt = pwToEncrypt.Trim();
            pwToEncrpt = pwToEncrpt.ToUpper();
            if(pwToEncrpt.Length > 12)
            {
                pwToEncrpt = pwToEncrpt.PadLeft(12);
            }
            for(i=0; i<pwToEncrpt.Length; i++)
            {
                pwChar = pwToEncrpt.Substring(i, 1);
                byte asciiVal = Encoding.Default.GetBytes(pwChar)[0];
                int asciiValInt = asciiVal;
                asciiValInt = asciiValInt + 23;
                pwChar = asciiValInt.ToString();
                pwChar = pwChar.Trim();
                pwChar = pwChar.PadLeft(4, '0');
                pwEncryptd = pwEncryptd + pwChar;
            }
            return pwEncryptd;
        }
    }
}