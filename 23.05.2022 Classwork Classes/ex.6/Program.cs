namespace ex._6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Employee> employees = new List<Employee>();

            int n = int.Parse(Console.ReadLine());
            
            for (int i = 0; i < n; i++)
            {
                string[] input = Console.ReadLine().Trim().Split();

                string name = input[0];
                double salary = double.Parse(input[1]);
                string position = input[2];
                string department = input[3];
                string email = "n/a";
                int age = -1;

                if (input.Length == 5)
                {
                    bool isAge = int.TryParse(input[4], out age);

                    if (isAge)
                    {
                        email = "n/a";
                    }
                    else
                    {
                        email = input[4];
                    }
                }
                else if (input.Length == 6)
                {
                    email = input[4];
                    age = int.Parse(input[5]);
                }

                Employee employee = new Employee(name, salary, position, department, email, age);
                employees.Add(employee);
            }

            string HighestAverageDepartment = employees
                .GroupBy(e => e.Department)
                .OrderByDescending(g => g.Select(e => e.Salary).Average())
                .First()
                .Key;
            Console.WriteLine($"Highest average salary: {HighestAverageDepartment}");


            foreach (var emp in employees
                    .OrderBy(e => e.Salary)
                    .GroupBy(e => e.Department)
                    .Where(g => g.Key == HighestAverageDepartment)
                    .SelectMany(g => g))
            {
                Console.WriteLine(emp.ToString());   
            }
        }

    }
}