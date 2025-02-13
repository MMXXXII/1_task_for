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

        // ���������, ��� ���������� ������ ����������� ���������
        [Test]
        public void AddGrade_ValidGrades_IncreasesCount()
        {
            studentGrades.AddGrade(3);
            studentGrades.AddGrade(3);
            studentGrades.AddGrade(5);

            Assert.AreEqual(2, studentGrades.GetGradeCount(3)); // ������ 3 ����������� 2 ����
            Assert.AreEqual(1, studentGrades.GetGradeCount(5)); // ������ 5 ����������� 1 ���
            Assert.AreEqual(0, studentGrades.GetGradeCount(4)); // ������ 4 �� �����������
        }

        // ���������, ��� ����� GetGradeCount �� �������� �� ������ ������
        [Test]
        public void GetGradeCount_NoGrades_ReturnsZero()
        {
            Assert.AreEqual(0, studentGrades.GetGradeCount(2));
            Assert.AreEqual(0, studentGrades.GetGradeCount(3));
            Assert.AreEqual(0, studentGrades.GetGradeCount(4));
            Assert.AreEqual(0, studentGrades.GetGradeCount(5));
        }

        // ���������, ��� ����� AddGrade ������������ ��������� ������������ ��������
        [Test]
        public void AddGrade_InvalidGrades_ThrowsException()
        {
            Assert.Throws<ArgumentException>(() => studentGrades.AddGrade(1)); // ������ 2
            Assert.Throws<ArgumentException>(() => studentGrades.AddGrade(6)); // ������ 5
            Assert.Throws<ArgumentException>(() => studentGrades.AddGrade(0)); // ������� ������
            Assert.Throws<ArgumentException>(() => studentGrades.AddGrade(-3)); // ������������� ������
        }

        // ���������, ��� ����� GetGradeCount ���� ����������� ���������� ��� ������������ ������
        [Test]
        public void GetGradeCount_InvalidGrade_ThrowsException()
        {
            Assert.Throws<ArgumentException>(() => studentGrades.GetGradeCount(1));
            Assert.Throws<ArgumentException>(() => studentGrades.GetGradeCount(6));
        }
    }
}
