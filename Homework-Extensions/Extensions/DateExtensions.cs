namespace Homework_Extensions.Extensions;

public static class DateExtensions
{
    public static DateTime Min(DateTime firstDate, DateTime secondDate)
    {
        DateTime minDate = firstDate < secondDate ? firstDate : secondDate;
        return minDate;
    }

    public static DateTime Max(DateTime firstDate, DateTime secondDate)
    {
        DateTime maxDate = firstDate > secondDate ? firstDate : secondDate;
        return maxDate;
    }
    public static DateTime BeginingOfMonth(DateTime date)
    {
        DateTime currentDate = DateTime.Now;
        DateTime beginningOfMonth = new DateTime(currentDate.Year, currentDate.Month, 1);
        return beginningOfMonth;
    }
    public static DateTime EndOfMonth(DateTime date)
    {
        DateTime beginningOfNextMonth = new DateTime(date.Year, date.Month, 1).AddMonths(1);
        DateTime endOfMonth = beginningOfNextMonth.AddDays(-1);
        return endOfMonth;
    }
}