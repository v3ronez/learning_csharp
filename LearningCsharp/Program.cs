using System.Globalization;

namespace MyApp;
// Note: actual namespace depends on the project name.

internal class Program
{
    private static void Main(string[] args)
    {
        //lists
        // List<String> list = new List<string>();
        // list.Add("Verone");
        // list.Add("casa");
        // list.Add("sla fodase");
        //
        // foreach (string name in list)
        // {
        //     Console.WriteLine(name);
        // }
        //
        // string n = list.Find(n => n[0] == 's');
        // Console.WriteLine(n);

        Console.WriteLine("Enter the number of employees");
        int numberEmployees = int.Parse(Console.ReadLine());

        List<Employee> listEmployers = new List<Employee>();
        for (int i = 0; i < numberEmployees; i++)
        {
            Console.WriteLine($"Employee #{i}");
            int id = int.Parse(Console.ReadLine());
            string name = Console.ReadLine();
            double salary = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            listEmployers.Add(new Employee(id, name, salary));
        }

        Console.WriteLine("Enter the employee id that will have salary increase: ");
        int idEmployee = int.Parse(Console.ReadLine());

        Console.WriteLine("Enter the percentage: ");
        float percentage = float.Parse(Console.ReadLine());
        Employee employeeFounded = listEmployers.Find(e => e.Id == idEmployee);
        employeeFounded.AddPercentage(percentage);
        Console.WriteLine("Updated list of employees:");
        foreach (Employee employee in listEmployers)
        {
            Console.WriteLine(employee);
        }
    }
}
