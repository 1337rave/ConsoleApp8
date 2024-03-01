using System;

class Journal
{
    // Властивість для кількості працівників
    public int EmployeeCount { get; private set; }

    // Конструктор класу
    public Journal(int employeeCount)
    {
        EmployeeCount = employeeCount;
    }

    // Метод для збільшення кількості працівників
    public void IncreaseEmployeeCount(int value)
    {
        EmployeeCount += value;
    }

    // Перевантажений оператор + для збільшення кількості працівників
    public static Journal operator +(Journal journal, int value)
    {
        journal.EmployeeCount += value;
        return journal;
    }

    // Перевантажений оператор - для зменшення кількості працівників
    public static Journal operator -(Journal journal, int value)
    {
        journal.EmployeeCount -= value;
        return journal;
    }

    // Перевантажений оператор == для перевірки на рівність кількості працівників
    public static bool operator ==(Journal journal1, Journal journal2)
    {
        return journal1.EmployeeCount == journal2.EmployeeCount;
    }

    // Перевантажений оператор != для перевірки на нерівність кількості працівників
    public static bool operator !=(Journal journal1, Journal journal2)
    {
        return journal1.EmployeeCount != journal2.EmployeeCount;
    }

    // Перевантажений метод Equals для порівняння об'єктів
    public override bool Equals(object obj)
    {
        if (obj == null || GetType() != obj.GetType())
        {
            return false;
        }

        Journal other = (Journal)obj;
        return this.EmployeeCount == other.EmployeeCount;
    }

    // Перевантажений метод GetHashCode для використання з Equals
    public override int GetHashCode()
    {
        return EmployeeCount.GetHashCode();
    }

    // Метод Main для демонстрації використання класу
    public static void Main(string[] args)
    {
        // Створення екземпляру класу Journal з початковою кількістю працівників
        Journal journal1 = new Journal(10);
        Journal journal2 = new Journal(15);

        // Збільшення кількості працівників на 5 за допомогою оператора +
        journal1 += 5;

        // Виведення кількості працівників для першого журналу
        Console.WriteLine("Кількість працівників у першому журналі: " + journal1.EmployeeCount);

        // Перевірка на рівність кількості працівників
        if (journal1 == journal2)
        {
            Console.WriteLine("Кількість працівників у першому і другому журналах рівна.");
        }
        else
        {
            Console.WriteLine("Кількість працівників у першому і другому журналах різна.");
        }
    }
}
