using System.Text.RegularExpressions;

namespace Exercise
{
    using System.Text.RegularExpressions;
    public class Checker
    {
        public bool DayOfWeek(string str)
        {
            Regex rgx = new Regex("^(mon|tue|wed|thu|fri|sat|sun)$");
            if (rgx.IsMatch(str))
            {
                return true;
            }
            return false;
        }

        public bool AllVowels(string str)
        {
            Regex rgx = new Regex("^(a|e|i|o|u)*$");
            if (rgx.IsMatch(str))
            {
                return true;
            }
            return false;
        }

        public bool TimeOfDay(string str)
        {
            Regex rgx = new Regex("^(0[0-9]|1[0-9]|2[0-3]):[0-5][0-9]:[0-5][0-9]$");
            if (rgx.IsMatch(str))
            {
                return true;
            }
            return false;
        }
    }
}