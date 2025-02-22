using NUnit.Framework;

namespace TestProject2
{
    public class StudentGradesTests
    {
        private int[] grades;

        [SetUp]
        public void Setup()
        {
            grades = new int[4]; // Массив для хранения количества оценок
        }

        // Метод для добавления оценки (если она от 2 до 5)
        private void AddGrade(int grade)
        {
            if (grade >= 2 && grade <= 5)
                grades[grade - 2]++;
        }

        // Метод для получения количества определенной оценки
        private int GetGradeCount(int grade)
        {
            return (grade >= 2 && grade <= 5) ? grades[grade - 2] : 0;
        }

        [Test]
        public void AddGrade_ValidGrade3_IncreasesCount()
        {
            // Добавляем две оценки 3
            AddGrade(3);
            AddGrade(3);

            // Проверяем, что количество троек стало 2
            Assert.AreEqual(2, GetGradeCount(3));
        }

        [Test]
        public void AddGrade_ValidGrade5_IncreasesCount()
        {
            // Добавляем одну оценку 5
            AddGrade(5);

            // Проверяем, что количество пятёрок стало 1
            Assert.AreEqual(1, GetGradeCount(5));
        }

        [Test]
        public void GetGradeCount_Grade4_NoGrades_ReturnsZero()
        {
            // Проверяем, что если четвёрка не была добавлена, её количество 0
            Assert.AreEqual(0, GetGradeCount(4));
        }

        [Test]
        public void AddGrade_InvalidGrade1_DoesNotChangeCount()
        {
            // Пытаемся добавить некорректную оценку 1
            AddGrade(1);

            // Проверяем, что её количество осталось 0 (т.к. оценка 1 не учитывается)
            Assert.AreEqual(0, GetGradeCount(1));
        }

        [Test]
        public void GetGradeCount_InvalidGrade6_ReturnsZero()
        {
            // Проверяем, что если запрашиваем количество оценки 6, возвращается 0
            Assert.AreEqual(0, GetGradeCount(6));
        }
    }
}
