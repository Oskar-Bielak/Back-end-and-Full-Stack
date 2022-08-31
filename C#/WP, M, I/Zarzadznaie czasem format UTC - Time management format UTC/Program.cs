using System;
using System.Globalization;

namespace csharp_time_zones
{
    class Program
    {
        static void Main(string[] args)
        {
            var now = DateTime.Now;
            Console.WriteLine($"1.1 --> {now}");
            Console.WriteLine($"1.2 --> {TimeZoneInfo.ConvertTimeToUtc(now)}");
            Console.WriteLine($"1.3 --> {now.ToUniversalTime()}");

            var dateTime = new DateTime(2019, 8, 29, 13, 55, 12);
            var zoneId = "W. Australia Standard Time";
            TimeZoneInfo zone = TimeZoneInfo.FindSystemTimeZoneById(zoneId);
            Console.WriteLine($"2 --> {TimeZoneInfo.ConvertTimeToUtc(dateTime, zone)}");

            var dt1 = DateTime.Now;
            var dt2 = DateTime.UtcNow;
            var difference = dt1 - dt2;
            Console.WriteLine($"{dt1} - {dt2} = {difference}");

            var dti1 = DateTimeOffset.Now;
            var dti2 = DateTimeOffset.UtcNow;
            var difference2 = dti1 - dti2;
            Console.WriteLine($"{dti1} - {dti2} = {difference2}");

            var localTime = new DateTimeOffset(DateTime.Now);
            Console.WriteLine($"3 -> LOCAL TIME = {localTime}");

            var otherTime = localTime.ToOffset(TimeSpan.Zero);
            Console.WriteLine($"3 -> OTHER TIME = {otherTime}");

            Console.WriteLine($"3 -> EQUALS: {localTime.Equals(otherTime)}");
            Console.WriteLine($"3 -> EQUALS EXACT: {localTime.EqualsExact(otherTime)}");

            // obliczanie roznicy czasu pomiedzy klientem a serwerem
            TimeSpan serverOffset = TimeZoneInfo.Local.GetUtcOffset(DateTimeOffset.Now);
            Console.WriteLine($"4 --> {serverOffset}");

            string clientString = "6/9/2019 1:00:05 -5:00";
            string format = @"M/d/yyyy H:m:s zzz";
            DateTimeOffset clientTime = DateTimeOffset.ParseExact(clientString, format, CultureInfo.InvariantCulture);
            Console.WriteLine($"4 --> {clientTime}");

            DateTimeOffset serverTime = clientTime.ToOffset(serverOffset);
            Console.WriteLine($"4 --> SERVER TIME: {serverTime}");

            var t1 = TimeZoneInfo.FindSystemTimeZoneById("GMT Standard Time");
            var t2 = TimeZoneInfo.FindSystemTimeZoneById("Pacific Standard Time");
            var noww = DateTimeOffset.Now;

            TimeSpan t1Offset = t1.GetUtcOffset(noww);
            TimeSpan t2Offset = t2.GetUtcOffset(noww);
            TimeSpan difference3 = t1Offset - t2Offset;
            Console.WriteLine($"5 --> {difference3}");

        }
    }
}
