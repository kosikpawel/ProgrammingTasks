using System.Linq;

namespace ProgrammingTasks.Services
{
    public interface ITheJourneyBeginsService
    {
        public int Add(int param1, int param2);
        public int CenturyFromYear(int year);
        public bool CheckPalindrome(string inputString);
    }
    public class TheJourneyBeginsService : ITheJourneyBeginsService
    {
        public int Add(int param1, int param2)
        {
            return param1 + param2;
        }

        public int CenturyFromYear(int year)
        {
            int century, modulo;
            century = (year / 100);
            modulo = (year % 100);

            return modulo == 0 ? century : century + 1;
        }

        public bool CheckPalindrome(string inputString)
        {
            return inputString.SequenceEqual(inputString.Reverse());
        }
    }
}
