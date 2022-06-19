using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebAppFrame2019
{
    public class DataMask
    {
        public string MaskCrdtCrdNo(string inCardNo)
        {
            //Take first 6 characters
            string firstPart = inCardNo.Substring(0, 6);
            //Take last 4 characters
            int len = inCardNo.Length;
            string lastPart = inCardNo.Substring(len - 4, 4);
            //Take the middle part to mask (****)
            int middlePartLength = len - (firstPart.Length + lastPart.Length);
            string middlePart = new string('*', middlePartLength);
            return firstPart + middlePart + lastPart;
        }
    }
}