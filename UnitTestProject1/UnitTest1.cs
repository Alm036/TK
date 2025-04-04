using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using TK;

namespace UnitTestProject1
{
    [TestClass]
    public class UnitTest1
    {
        public MainWindow _window;

        [TestInitialize]
        public void TestInitialize()
        {
            _window = new MainWindow();
        }

        [TestMethod]
        public void CalculateGrade_ShouldReturn5_For100Points()
        {
            double totalScore = 100;
            string result = _window.CalculateGrade(totalScore);
            Assert.AreEqual("5 (отлично)", result);
        }

        [TestMethod]
        public void CalculateGrade_ShouldReturn5_For70Points()
        {
            string result = _window.CalculateGrade(70);
            Assert.AreEqual("5 (отлично)", result);
        }

        [TestMethod]
        public void CalculateGrade_ShouldReturn4_For69Points()
        {
            string result = _window.CalculateGrade(69);
            Assert.AreEqual("4 (хорошо)", result);
        }

        [TestMethod]
        public void CalculateGrade_ShouldReturn4_For40Points()
        {
            string result = _window.CalculateGrade(40);
            Assert.AreEqual("4 (хорошо)", result);
        }

        [TestMethod]
        public void CalculateGrade_ShouldReturn3_For39Points()
        {
            string result = _window.CalculateGrade(39);
            Assert.AreEqual("3 (удовлетворительно)", result);
        }

        [TestMethod]
        public void CalculateGrade_ShouldReturn3_For20Points()
        {
            string result = _window.CalculateGrade(20);
            Assert.AreEqual("3 (удовлетворительно)", result);
        }

        [TestMethod]
        public void CalculateGrade_ShouldReturn2_For19Points()
        {
            string result = _window.CalculateGrade(19);
            Assert.AreEqual("2 (неудовлетворительно)", result);
        }

        [TestMethod]
        public void CalculateGrade_ShouldReturn2_For0Points()
        {
            string result = _window.CalculateGrade(0);
            Assert.AreEqual("2 (неудовлетворительно)", result);
        }

        [TestMethod]
        public void ValidateInput_ShouldReturnValue_ForValidInput()
        {
            double result = _window.ValidateInput("10", 10);
            Assert.AreEqual(10, result);
        }

        [TestMethod]
        public void ValidateInput_ShouldReturnValue_ForDecimalInput()
        {
            double result = _window.ValidateInput("7.5", 10);
            Assert.AreEqual(7.5, result);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void ValidateInput_ShouldThrowException_ForNonNumericInput()
        {
            _window.ValidateInput("abc", 10);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void ValidateInput_ShouldThrowException_ForNegativeInput()
        {
            _window.ValidateInput("-5", 10);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void ValidateInput_ShouldThrowException_ForInputAboveMax()
        {
            _window.ValidateInput("11", 10);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void ValidateInput_ShouldThrowException_ForEmptyInput()
        {
            _window.ValidateInput("", 10);
        }

        [TestMethod]
        public void CalculateGrade_Boundary70_ShouldReturn5()
        {
            string result = _window.CalculateGrade(70);
            Assert.AreEqual("5 (отлично)", result);
        }

        [TestMethod]
        public void CalculateGrade_Boundary69_9_ShouldReturn4()
        {
            string result = _window.CalculateGrade(69.9);
            Assert.AreEqual("4 (хорошо)", result);
        }

        [TestMethod]
        public void CalculateGrade_Boundary40_ShouldReturn4()
        {
            string result = _window.CalculateGrade(40);
            Assert.AreEqual("4 (хорошо)", result);
        }

        [TestMethod]
        public void CalculateGrade_Boundary39_9_ShouldReturn3()
        {
            string result = _window.CalculateGrade(39.9);
            Assert.AreEqual("3 (удовлетворительно)", result);
        }

        [TestMethod]
        public void CalculateGrade_Boundary20_ShouldReturn3()
        {
            string result = _window.CalculateGrade(20);
            Assert.AreEqual("3 (удовлетворительно)", result);
        }

        [TestMethod]
        public void CalculateGrade_Boundary19_9_ShouldReturn2()
        {
            string result = _window.CalculateGrade(19.9);
            Assert.AreEqual("2 (неудовлетворительно)", result);
        }
    }
}