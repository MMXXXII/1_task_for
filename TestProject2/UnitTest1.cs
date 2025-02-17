using NUnit.Framework;

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

        [Test]
        public void AddGrade_ValidGrade3_IncreasesCount()
        {
            studentGrades.AddGrade(3);
            studentGrades.AddGrade(3);

            Assert.AreEqual(2, studentGrades.GetGradeCount(3));
        }

        [Test]
        public void AddGrade_ValidGrade5_IncreasesCount()
        {
            studentGrades.AddGrade(5);

            Assert.AreEqual(1, studentGrades.GetGradeCount(5));
        }

        [Test]
        public void GetGradeCount_Grade4_NoGrades_ReturnsZero()
        {
            Assert.AreEqual(0, studentGrades.GetGradeCount(4));
        }

        [Test]
        public void AddGrade_InvalidGrade1_DoesNotChangeCount()
        {
            studentGrades.AddGrade(1);

            Assert.AreEqual(0, studentGrades.GetGradeCount(1));
        }

        [Test]
        public void GetGradeCount_InvalidGrade6_ReturnsZero()
        {
            Assert.AreEqual(0, studentGrades.GetGradeCount(6));
        }
    }
}
