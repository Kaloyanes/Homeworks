double kgCalculate(double meatForKg, double meatKg)
{
    return meatForKg * meatKg;
}

double meatForKg = double.Parse(Console.ReadLine());
double meatKg = double.Parse(Console.ReadLine());

Console.WriteLine(kgCalculate(meatForKg, meatKg));