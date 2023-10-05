using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Threading.Tasks;

public class Journal
{
    public string Title { get; set; }
    public int NumberOfPages { get; set; }
    public int NumberOfEmployees { get; set; }

    public Journal(string title, int numberOfPages, int numberOfEmployees)
    {
        Title = title;
        NumberOfPages = numberOfPages;
        NumberOfEmployees = numberOfEmployees;
    }

    public void IncreaseEmployees(int amount)
    {
        NumberOfEmployees += amount;
    }

    // Метод для зменшення кількості працівників
    public void DecreaseEmployees(int amount)
    {
        if (NumberOfEmployees - amount >= 0)
        {
            NumberOfEmployees -= amount;
        }
        else
        {
            Console.WriteLine("Неможливо зменшити кількість працівників менше нуля.");
        }
    }

    // Перевірка на рівність кількості працівників
    public bool Equals(Journal other)
    {
        return this.NumberOfEmployees == other.NumberOfEmployees;
    }

    // Перевірка на меншу кількість працівників
    public bool LessThan(Journal other)
    {
        return this.NumberOfEmployees < other.NumberOfEmployees;
    }

    // Перевірка на більшу кількість працівників
    public bool GreaterThan(Journal other)
    {
        return this.NumberOfEmployees > other.NumberOfEmployees;
    }
}
