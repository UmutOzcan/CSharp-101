// DateTime
Console.WriteLine("****** DateTime Library ******");
Console.WriteLine(DateTime.Now);
Console.WriteLine(DateTime.Now.Date);
Console.WriteLine(DateTime.Now.Day);
Console.WriteLine(DateTime.Now.Month);
Console.WriteLine(DateTime.Now.Year);
Console.WriteLine(DateTime.Now.Hour);
Console.WriteLine(DateTime.Now.Minute);
Console.WriteLine(DateTime.Now.Second);
Console.WriteLine(DateTime.Now.DayOfWeek);
Console.WriteLine(DateTime.Now.DayOfYear);
Console.WriteLine(DateTime.Now.ToLongDateString());
Console.WriteLine(DateTime.Now.ToShortDateString());
Console.WriteLine(DateTime.Now.ToLongTimeString());
Console.WriteLine(DateTime.Now.ToShortTimeString());
Console.WriteLine(DateTime.Now.AddDays(9));
Console.WriteLine(DateTime.Now.ToString("dd"));
Console.WriteLine(DateTime.Now.ToString("ddd"));
Console.WriteLine(DateTime.Now.ToString("dddd"));
Console.WriteLine(DateTime.Now.ToString("MM"));
Console.WriteLine(DateTime.Now.ToString("MMM"));
Console.WriteLine(DateTime.Now.ToString("MMMM"));

// Math
Console.WriteLine("\n****** Math Library ******");
Console.WriteLine(Math.Abs(-25));
Console.WriteLine(Math.Sin(60));
Console.WriteLine(Math.Ceiling(60.3)); //61
Console.WriteLine(Math.Round(60.3)); //60
Console.WriteLine(Math.Round(60.7)); //61
Console.WriteLine(Math.Floor(60.7)); //60
Console.WriteLine(Math.Max(2, 6));
Console.WriteLine(Math.Min(2, 6));
Console.WriteLine(Math.Pow(2, 6));
Console.WriteLine(Math.Sqrt(64));


Console.ReadKey();