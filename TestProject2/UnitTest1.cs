using NUnit.Framework;
using System;

namespace TestProject2
{
    public class StudentGradesTests
    {
        private StudentGrades studentGrades;

        [SetUp]
        public void Setup()
        {
            studentGrades = new StudentGrades();
        }

        // Проверяем, что корректные оценки добавляются правильно
        [Test]
        public void AddGrade_ValidGrades_IncreasesCount()
        {
            studentGrades.AddGrade(3);
            studentGrades.AddGrade(3);
            studentGrades.AddGrade(5);

            Assert.AreEqual(2, studentGrades.GetGradeCount(3)); // Оценка 3 встречается 2 раза
            Assert.AreEqual(1, studentGrades.GetGradeCount(5)); // Оценка 5 встречается 1 раз
            Assert.AreEqual(0, studentGrades.GetGradeCount(4)); // Оценка 4 не добавлялась
        }

        // Проверяем, что метод GetGradeCount не ломается на пустых данных
        [Test]
        public void GetGradeCount_NoGrades_ReturnsZero()
        {
            Assert.AreEqual(0, studentGrades.GetGradeCount(2));
            Assert.AreEqual(0, studentGrades.GetGradeCount(3));
            Assert.AreEqual(0, studentGrades.GetGradeCount(4));
            Assert.AreEqual(0, studentGrades.GetGradeCount(5));
        }

        // Проверяем, что метод AddGrade отказывается принимать некорректные значения
        [Test]
        public void AddGrade_InvalidGrades_ThrowsException()
        {
            Assert.Throws<ArgumentException>(() => studentGrades.AddGrade(1)); // Меньше 2
            Assert.Throws<ArgumentException>(() => studentGrades.AddGrade(6)); // Больше 5
            Assert.Throws<ArgumentException>(() => studentGrades.AddGrade(0)); // Нулевая оценка
            Assert.Throws<ArgumentException>(() => studentGrades.AddGrade(-3)); // Отрицательная оценка
        }

        // Проверяем, что метод GetGradeCount тоже выбрасывает исключение для некорректных оценок
        [Test]
        public void GetGradeCount_InvalidGrade_ThrowsException()
        {
            Assert.Throws<ArgumentException>(() => studentGrades.GetGradeCount(1));
            Assert.Throws<ArgumentException>(() => studentGrades.GetGradeCount(6));
        }
    }
}
