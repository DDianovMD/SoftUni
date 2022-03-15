using System;

namespace DateModifier
{
    public static class DateModifier
    {
        public static int CompareDates(string date1, string date2)
        {
            DateTime firstDate = DateTime.Parse(date1);
            DateTime secondDate = DateTime.Parse(date2);

            int difference = Math.Abs((firstDate - secondDate).Days);

            return difference;
        }
    }
}
