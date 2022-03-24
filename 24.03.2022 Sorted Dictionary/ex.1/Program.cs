var sightings = new SortedDictionary<double, int>();
var input = Console.ReadLine().Trim().Split().Select(double.Parse).ToArray();

foreach (var s in input)
{
    if (!sightings.ContainsKey(s))
        sightings[s] = 0;

    sightings[s]++;
}

foreach (var sighting in sightings)
{
    Console.WriteLine($"{sighting.Key} -> {sighting.Value}");
}