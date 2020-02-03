using System;
using System.Collections.Generic;
using System.Linq;

namespace Features
{
  class Program
  {
    static void Main(string[] args)
    {
      // FirstExample();
      // SecondExample();
      // ThirdExample();
      // FourthExample();
      // FifthExample();
      // SixthExample();
      // SeventhExample();
      EigthExample();
    }

    private static void EigthExample()
    {
      Func<int, int> square = x => x * x;
      Func<int, int, int> add = (x, y) => x + y;

      Console.WriteLine(square(add(2, 3)));
    }

    private static void SeventhExample()
    {
      Employee[] developers = new Employee[]{
              new Employee() { Id = 1, Name="Zenius"},
              new Employee() {Id = 2, Name = "Bharat"}
          };

      var filteredEmployees = developers.Where(employee => employee.Name.StartsWith("B"));

      ShowEmployees(filteredEmployees);
    }

    private static void SixthExample()
    {
      Employee[] developers = new Employee[]{
              new Employee() { Id = 1, Name="Zenius"},
              new Employee() {Id = 2, Name = "Bharat"}
          };

      var filteredEmployees = developers.Where(delegate (Employee employee)
      {
        return employee.Name.StartsWith("B");
      });

      ShowEmployees(filteredEmployees);
    }

    private static void FifthExample()
    {
      Employee[] developers = new Employee[]{
              new Employee() { Id = 1, Name="Zenius"},
              new Employee() {Id = 2, Name = "Bharat"}
          };

      var filteredEmployees = developers.Where(nameStartsWithB);

      ShowEmployees(filteredEmployees);
    }

    private static bool nameStartsWithB(Employee employee)
    {
      return employee.Name.StartsWith("B");
    }

    private static void ShowEmployees(IEnumerable<Employee> employees)
    {
      foreach (var employee in employees)
      {
        Console.WriteLine(employee.Name);
      }
    }

    private static void FourthExample()
    {
      IEnumerable<Employee> sales = new List<Employee>() {
              new Employee() { Id = 3, Name = "Zen"}
          };

      ShowEmployees(sales);
    }

    private static void ThirdExample()
    {
      List<Employee> sales = new List<Employee>() {
              new Employee() { Id = 3, Name = "Zen"}
          };

      ShowEmployees(sales);
    }
    private static void SecondExample()
    {
      IEnumerable<Employee> developers = new Employee[]{
              new Employee() { Id = 1, Name="Zenius"},
              new Employee() {Id = 2, Name = "Bharat"}
        };

      IEnumerator<Employee> enumerator = developers.GetEnumerator();
      while (enumerator.MoveNext())
      {
        Console.WriteLine(enumerator.Current.Name);
      }
    }

    private static void FirstExample()
    {
      Employee[] developers = new Employee[]{
              new Employee() { Id = 1, Name="zenius"},
              new Employee() {Id = 2, Name = "bharat"}
          };

      ShowEmployees(developers);
    }

  }
}
