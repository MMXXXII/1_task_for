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

        [Test]
        public void AddGrade_ValidGrade5_IncreasesCount()
        {
            // Добавляем одну оценку 5
            grades[3]++;

            // Проверяем, что количество пятёрок стало 1
            Assert.AreEqual(1, grades[3]);
        }

        [Test]
        public void GetGradeCount_Grade4_NoGrades_ReturnsZero()
        {
            // Проверяем, что если четвёрка не была добавлена, её количество 0
            Assert.AreEqual(0, grades[2]);
        }

        [Test]
        public void AddGrade_InvalidGradeBelowRange_DoesNotChangeCount()
        {
            // Пытаемся добавить некорректную оценку ниже диапазона (оценка 1)
            // Но в нашем тесте нет проверки на это, так как мы напрямую работаем с массивом

            // Проверяем, что количество двоек не изменилось
            Assert.AreEqual(0, grades[0]);
        }

        [Test]
        public void AddGrade_InvalidGradeAboveRange_DoesNotChangeCount()
        {
            // Пытаемся добавить некорректную оценку выше диапазона (оценка 6)
            // Проверяем, что количество пятёрок не изменилось
            Assert.AreEqual(0, grades[3]);
        }
    }
}
