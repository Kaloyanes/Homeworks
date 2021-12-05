// Без да искам направих .net 6 проект

// To това е направо за 7 и 8 задача
int MonthDays(int monthNumber, bool isLeapYear)
{
    int year = 2021;

    if (isLeapYear)
        year = 2016;

    var days = DateTime.DaysInMonth(year, monthNumber);

    return days;
}

int months = int.Parse(Console.ReadLine());
bool isLeapYear = bool.Parse(Console.ReadLine());

int days = MonthDays(months, isLeapYear);
Console.WriteLine(days);