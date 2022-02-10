List<int> list = Console.ReadLine().Trim().Split().Select(int.Parse).ToList();

int curr,temp = 0, maxRow = 0, currRow = 1, p = 0;

foreach (int i in list)
{
    curr = i;
    
    if (curr == temp)
    {
        currRow++;
    }
    else
    {
        currRow = 1;
    }
    
    if (currRow > maxRow)
    {
        maxRow = currRow;
        p = temp;
    }
    
    temp = curr;
}

for(int i = 0; i < maxRow; i++)
{
    Console.Write(p + " ");
}