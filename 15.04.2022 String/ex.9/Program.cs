string input = Console.ReadLine();
int num;

// Check-ваме ако можем да parse-нем тогава няма букви, а ако не можем да parse-нем тогава има букви
// По-бързо и лесно отколкото да имаме 2 цикъла според мен
bool CanParse = int.TryParse(input.ToString(), out num);

if (!CanParse)
{
    Console.WriteLine("Wrong input");
    return;
}

foreach (var c in input)
{
    int n = int.Parse(c.ToString());

    Console.WriteLine(new string('*', n));
}