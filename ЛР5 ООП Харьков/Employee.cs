using System;
using System.Collections.Generic;

public class Employee
{
    public string Name { get; set; }
    public virtual double GetSalary() => 15000;
}

public class Manager : Employee
{
    public override double GetSalary() => 25000;
}

public class Director : Employee
{
    public override double GetSalary() => 50000;
}

public class SalaryCalculator
{
    public double GetTotalSalary(List<Employee> employees)
    {
        double sum = 0;
        foreach (var emp in employees)
            sum += emp.GetSalary();
        return sum;
    }
}

public class Demo1
{
    public static void Run()
    {
        var employees = new List<Employee>
        {
            new Employee { Name="Worker" },
            new Manager { Name="Boss" },
            new Director { Name="Chief" }
        };

        SalaryCalculator calc = new SalaryCalculator();
        Console.WriteLine("Total salary = " + calc.GetTotalSalary(employees));
    }
}
