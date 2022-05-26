namespace ex._2;

public class Person
{
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public int Age { get; set; }
    public double Salary { get; set; }
    public int BonusPercentage { get; set; }

    public Person(string firstName, string lastName, int age, double salary)
    {
        FirstName = firstName;
        LastName = lastName;
        Age = age;
        Salary = salary;
    }

    public void IncreaseSalary(double bonusPercentage)
    {
        if (Age > 30) Salary += Salary * bonusPercentage / 100;
        else Salary += Salary * bonusPercentage / 200;
    }

    public override string ToString()
    {
        return $"{FirstName} {LastName} get {Salary:F2} leva";
    }
}