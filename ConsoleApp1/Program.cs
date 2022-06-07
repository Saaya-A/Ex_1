using System;
using System.Globalization;
class Program
{
    static void Main(string[] args)
    {
        DateTime dateTime;
        GregorianCalendar gregorianCalendar = new GregorianCalendar();
        int kolDay;
        Console.WriteLine("Число: ");
        int a = int.Parse(Console.ReadLine());
        Console.WriteLine("Месяц: ");
        int b = int.Parse(Console.ReadLine());
        Console.WriteLine("Год: ");
        int c = int.Parse(Console.ReadLine());
        string data = $"{a}.{b}.{c}";
        if (DateTime.TryParse(data, out dateTime))
        {
            int nomer = gregorianCalendar.GetDayOfYear(dateTime);
            Console.WriteLine("Номер дня с начала года = " + nomer);
            if (gregorianCalendar.IsLeapYear(c)) kolDay = 366 - nomer;
            else kolDay = 365 - nomer;
            Console.WriteLine($"До конца года осталось {kolDay} дней");
        }
        else Console.WriteLine("Некорректная дата");
    }
}
