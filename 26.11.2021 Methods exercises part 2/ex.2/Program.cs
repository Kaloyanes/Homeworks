string Calculate(Int64 time1, Int64 time2)
{
    // var time = new TimeOnly(time1);
    // var time5 = new TimeOnly(time2);

    time1 -= time2;

    return $"Last seen {Math.Abs(time1 / 60)} minutes ago";
}

{
    Int64 n1 = Int64.Parse(Console.ReadLine());
    Int64 n2 = Int64.Parse(Console.ReadLine());

    Console.WriteLine(Calculate(n1, n2));
}