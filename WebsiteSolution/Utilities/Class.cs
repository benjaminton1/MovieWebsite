namespace Group5_FinalProject_v2.Utilities;
using System.Globalization;
    
    public static class DateParser
    {
        public static DateTime ParseDate(string dateString)
        {
            return DateTime.ParseExact(dateString, "yyyy-MM-dd", CultureInfo.InvariantCulture);
        }

    }
    
