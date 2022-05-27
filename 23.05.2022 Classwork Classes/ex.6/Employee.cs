namespace ex._6;

public class Employee
{
    public string Name { get; set; }
    public double Salary { get; set; }
    public string Position { get; set; }
    public string Department { get; set; }
    //Optional
    public string Email { get; set; } = "n/a";
    //Optional
    public int Age { get; set; } = -1;

    public Employee(string name, double salary, string position, string department, string email = "n/a", int age = -1)
    {
        Name = name;
        Salary = salary;
        Position = position;
        Department = department;
        Age = age;
        Email = email;
    }

    public override string ToString()
    {
        return $"{Name} {Salary:F2} {Position} {Department} {Email} {Age}";
    }
}