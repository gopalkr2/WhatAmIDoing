using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace WhatAmIDoing.Model
{
    public static class StringHelper
    {
        public static string FormatTime(long activeTime)
        {
            string retVal = string.Empty;
            double remaining = activeTime;

            double hours = remaining > 3600 ? Math.Floor((double)remaining / 3600) : 0;

            retVal += hours > 0 ? hours.ToString() : "00";
            retVal += ":";

            remaining -= hours * 3600;

            double mins = remaining > 60 ? Math.Floor((double)remaining / 60) : 0;

            retVal += mins > 0 ? mins.ToString() : "00";
            retVal += ":";

            remaining -= mins * 60;

            retVal += remaining;

            return retVal;
        }
    }
}
