int ReverseNum(int num)
{
    var str = "";
    while (num != 0)
    {
        if (num % 10 == 0 && num / 10 != 0)
        {
            num /= 10;
            continue;
        }

        str += num % 10;
        num /= 10;
    }

    return int.Parse(str);
}

var list = Console.ReadLine().Trim().Split().Select(int.Parse).ToList();

var sum = 0;

list.ForEach(x =>
{
    var reverse = ReverseNum(x);

    sum += reverse;
});

Console.WriteLine(sum);