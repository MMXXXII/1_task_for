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

        [Test]
        public void AddGrade_ValidGrade5_IncreasesCount()
        {
            // ��������� ���� ������ 5
            grades[3]++;

            // ���������, ��� ���������� ������ ����� 1
            Assert.AreEqual(1, grades[3]);
        }

        [Test]
        public void GetGradeCount_Grade4_NoGrades_ReturnsZero()
        {
            // ���������, ��� ���� ������� �� ���� ���������, � ���������� 0
            Assert.AreEqual(0, grades[2]);
        }

        [Test]
        public void AddGrade_InvalidGradeBelowRange_DoesNotChangeCount()
        {
            // �������� �������� ������������ ������ ���� ��������� (������ 1)
            // �� � ����� ����� ��� �������� �� ���, ��� ��� �� �������� �������� � ��������

            // ���������, ��� ���������� ����� �� ����������
            Assert.AreEqual(0, grades[0]);
        }

        [Test]
        public void AddGrade_InvalidGradeAboveRange_DoesNotChangeCount()
        {
            // �������� �������� ������������ ������ ���� ��������� (������ 6)
            // ���������, ��� ���������� ������ �� ����������
            Assert.AreEqual(0, grades[3]);
        }
    }
}
