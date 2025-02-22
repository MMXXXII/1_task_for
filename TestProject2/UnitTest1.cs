using NUnit.Framework;

namespace TestProject2
{
    public class StudentGradesTests
    {
        private int[] grades;

        [SetUp]
        public void Setup()
        {
            grades = new int[4]; // ������ ��� �������� ���������� ������
        }

        // ����� ��� ���������� ������ (���� ��� �� 2 �� 5)
        private void AddGrade(int grade)
        {
            if (grade >= 2 && grade <= 5)
                grades[grade - 2]++;
        }

        // ����� ��� ��������� ���������� ������������ ������
        private int GetGradeCount(int grade)
        {
            return (grade >= 2 && grade <= 5) ? grades[grade - 2] : 0;
        }

        [Test]
        public void AddGrade_ValidGrade3_IncreasesCount()
        {
            // ��������� ��� ������ 3
            AddGrade(3);
            AddGrade(3);

            // ���������, ��� ���������� ����� ����� 2
            Assert.AreEqual(2, GetGradeCount(3));
        }

        [Test]
        public void AddGrade_ValidGrade5_IncreasesCount()
        {
            // ��������� ���� ������ 5
            AddGrade(5);

            // ���������, ��� ���������� ������ ����� 1
            Assert.AreEqual(1, GetGradeCount(5));
        }

        [Test]
        public void GetGradeCount_Grade4_NoGrades_ReturnsZero()
        {
            // ���������, ��� ���� ������� �� ���� ���������, � ���������� 0
            Assert.AreEqual(0, GetGradeCount(4));
        }

        [Test]
        public void AddGrade_InvalidGrade1_DoesNotChangeCount()
        {
            // �������� �������� ������������ ������ 1
            AddGrade(1);

            // ���������, ��� � ���������� �������� 0 (�.�. ������ 1 �� �����������)
            Assert.AreEqual(0, GetGradeCount(1));
        }

        [Test]
        public void GetGradeCount_InvalidGrade6_ReturnsZero()
        {
            // ���������, ��� ���� ����������� ���������� ������ 6, ������������ 0
            Assert.AreEqual(0, GetGradeCount(6));
        }
    }
}
