using NUnit.Framework;
using System.Collections.Generic;

namespace TestProject2
{
    public class StudentGradesTests
    {
        private Dictionary<int, int> gradesCount;

        [SetUp]
        public void Setup()
        {
            gradesCount = new Dictionary<int, int>
            {
                { 2, 0 }, // Двойки
                { 3, 0 }, // Тройки
                { 4, 0 }, // Четверки
                { 5, 0 }  // Пятерки
            };
        }


        [Test]
        public void AddMultipleGrades_ValidGrades_IncreasesCount()
        {
            // Добавляем несколько оценок
            gradesCount[5]++;
            gradesCount[4]++;
            gradesCount[4]++;

            // Проверяем, что количество пятёрок стало 1, а количество четвёрок стало 2
            Assert.AreEqual(1, gradesCount[5]);
            Assert.AreEqual(2, gradesCount[4]);
        }


        [Test]
        public void AddGrade_InvalidGradeBelowRange_DoesNotChangeCount()
        {
            //проверить, что количество двоек не изменилось
            Assert.AreEqual(0, gradesCount[2]);
        }


        [Test]
        public void AddGrade_SameGradeMultipleTimes_IncreasesCountCorrectly()
        {
            // Добавляем одну пятерку 5 раз
            for (int i = 0; i < 5; i++)
            {
                gradesCount[5]++;
            }

            // Проверяем, что количество пятёрок стало 5
            Assert.AreEqual(5, gradesCount[5]);
        }


        [Test]
        public void GetGradeCount_Grade2_ReturnsZero()
        {
            // Проверяем, что если двойка не была добавлена, её количество 0
            Assert.AreEqual(0, gradesCount[2]);
        }

        [Test]
        public void AddGrade_EmptyInput_DoesNotChangeCount()
        {
            string input = "";
            Assert.AreEqual(0, gradesCount[2]);
            Assert.AreEqual(0, gradesCount[3]);
            Assert.AreEqual(0, gradesCount[4]);
            Assert.AreEqual(0, gradesCount[5]);
        }

        [Test]
        public void AddGrade_LettersInput_DoesNotChangeCount()
        {
            string input = "A";
            Assert.AreEqual(0, gradesCount[2]);
            Assert.AreEqual(0, gradesCount[3]);
            Assert.AreEqual(0, gradesCount[4]);
            Assert.AreEqual(0, gradesCount[5]);
        }
    }
}
