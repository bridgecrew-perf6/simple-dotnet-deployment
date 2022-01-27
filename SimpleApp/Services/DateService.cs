namespace SimpleApp.Services
{
    public class DateService
    {
        public string FormatDate(DateTime date) => date.ToShortDateString();
    }
}
