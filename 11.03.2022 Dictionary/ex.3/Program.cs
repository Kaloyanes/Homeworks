Dictionary<string, int> resources = new Dictionary<string, int>();

while (true)
{
    string resource = Console.ReadLine().Trim();

    if (resource.ToLower() == "stop") return;

    int quantity = int.Parse(Console.ReadLine().Trim());

    if (!resources.ContainsKey(resource))
        resources.Add(resource, 0);

    resources[resource] += quantity;

    Console.WriteLine($"{resource} -> {resources[resource]}");
    Console.WriteLine("");
}