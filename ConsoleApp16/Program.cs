namespace ConsoleApp16
{
    internal class Program
    {
        static void Main()
        {
            BirthDate birthDate = new BirthDate(new DateTime(1900, 11, 10));
            Console.WriteLine(birthDate.GetDaysUntilBirthDay());
        }
    }
    struct BirthDate
    {
        private DateTime date;
        public BirthDate(DateTime date)
        {
            this.date = date;
        }
        public string GetWeekdayOfBirth()
        {
            return date.ToString("___");
        }
        public string GetWeekdayOfBirthInYear(int year)
        {
            DateTime date2 = new DateTime(year, date.Month, date.Day);
            return date2.ToString("___");
        }
        public int GetDaysUntilBirthDay()
        {
            DateTime today = DateTime.Today;
            DateTime nextBirth = new DateTime(today.Year, date.Month, date.Day);
            if (nextBirth < today)
            {
                nextBirth = nextBirth.AddYears(1);
            }
            return (nextBirth - today).Days;
        }
    }
}