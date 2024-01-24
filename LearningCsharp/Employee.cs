namespace MyApp;

public class Employee
{
    public int Id { get; private set; }
    public string Name { get; private set; }
    public double Salary { get; private set; }

    public Employee(int id, string name, double salary)
    {
        Id = id;
        Name = name;
        AddSalary(salary);
    }

    public void AddSalary(double salary)
    {
        Salary += salary;
    }

    public void AddPercentage(double percentage)
    {
        Salary += Salary * percentage / 100.0;
    }

    public override string ToString()
    {
        return $"ID: {Id} | Name: {Name} | Salary: {Salary:0.00}";
    }
}
