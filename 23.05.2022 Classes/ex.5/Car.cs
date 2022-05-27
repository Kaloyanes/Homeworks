namespace ex._5;

public class Car
{
    public string model { get; private set; }
    public double fuel { get; private set; }
    public double fuelPerKm { get; private set; }
    public double kmDriven { get; private set; } = 0;

    public Car(string model, double fuel, double fuelPerKm)
    {
        this.model = model;
        this.fuel = fuel;
        this.fuelPerKm = fuelPerKm;
    }

    public void Drive(double km)
    {
        kmDriven += km;
        fuel -= km * fuelPerKm;
    }

    public override string ToString()
    {
        return $"{model} {fuel:F2} {kmDriven}";
    }
}