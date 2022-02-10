int ReverseNum(int num)
{
    string str = "";
    while (num != 0)
    {
        str += num % 10; 
        num /= 10;
    }

    return int.Parse(str);
}

List<int> list = Console.ReadLine().Trim().Split().Select(int.Parse).ToList();

int sum = 0;

list.ForEach((x) =>
{
    int reverse = ReverseNum(x);
    
    sum += reverse;
});

Console.WriteLine(sum);