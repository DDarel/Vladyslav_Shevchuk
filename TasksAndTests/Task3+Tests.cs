using NUnit.Framework;
using System.Collections.Generic;

namespace TasksAndTests
{
    public class Task3Tests
    {
        public static int DigitalRoot(int number)
        {
            int result = 0;
            while (number > 0)
            {
                result += number % 10;
                number /= 10;
            }
            if (result > 9)
            {
                result = DigitalRoot(result);
            }
            return result;
        }

        [Test]
        public void Task3Test1()
        {
            //Arrange
            int input = 16;
            int expected = 7;

            //Act
            input = DigitalRoot(input);

            //Assert
            Assert.AreEqual(expected, input);
        }
        [Test]
        public void Task3Test2()
        {
            //Arrange
            int input = 493193;
            int expected = 2;

            //Act
            input = DigitalRoot(input);

            //Assert
            Assert.AreEqual(expected, input);
        }
    }
}