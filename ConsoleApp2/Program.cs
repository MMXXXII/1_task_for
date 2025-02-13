using System;

public class StudentGrades
{
    private int[] gradeCount;

    public StudentGrades()
    {
        gradeCount = new int[6]; // Индексы 2-5 используются для подсчёта оценок
    }

    public void AddGrade(int grade)
    {
        if (grade < 2 || grade > 5)
            throw new ArgumentException("Оценка должна быть от 2 до 5.");

        gradeCount[grade]++;
    }

    public int GetGradeCount(int grade)
    {
        if (grade < 2 || grade > 5)
            throw new ArgumentException("Оценка должна быть от 2 до 5.");

        return gradeCount[grade];
    }
}

class Program
{
    static void Main()
    {
        int studentCount;
        while (true)
        {
            Console.Write("Введите количество детей в классе: ");
            if (int.TryParse(Console.ReadLine(), out studentCount) && studentCount > 0)
                break;

            Console.WriteLine("Ошибка! Введите число больше 0.");
        }

        StudentGrades studentGrades = new StudentGrades();

        for (int i = 1; i <= studentCount; i++)
        {
            Console.Write("Введите имя ученика: ");
            string name = Console.ReadLine();

            int grade;
            while (true)
            {
                Console.Write("Введите оценку ученика: ");
                if (int.TryParse(Console.ReadLine(), out grade) && grade >= 2 && grade <= 5)
                    break;

                Console.WriteLine("Ошибка! Введите корректную оценку (от 2 до 5).");
            }
            studentGrades.AddGrade(grade);
        }

        for (int i = 2; i <= 5; i++)
        {
            Console.WriteLine($"Оценка {i}: {studentGrades.GetGradeCount(i)} раз");
        }
    }
}
