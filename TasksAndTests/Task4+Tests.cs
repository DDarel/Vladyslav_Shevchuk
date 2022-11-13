using NUnit.Framework;
using System.Collections.Generic;

namespace TasksAndTests
{
    public class Task4Tests
    {
        public static int PairCounter(int[] arr, int target)
        {
            int count = 0;
            for (int i = 0; i < arr.Length - 1; i++)
            {
                for (int j = i + 1; j < arr.Length; j++)
                {
                    if (arr[i] + arr[j] == target)
                    {
                        count++;
                    }
                }
            }
            return count;
        }

        [Test]
        public void Task4Test1()
        {
            //Arrange
            int[] inputList = { 1, 3, 6, 2, 2, 0, 4, 5 };
            int target = 5;
            int expected = 4;

            //Act
            int pairs = PairCounter(inputList, target);

            //Assert
            Assert.AreEqual(expected, pairs);
        }
        [Test]
        public void Task4Test2()
        {
            //Arrange
            int[] inputList = { 7, 3, 6, 2, 2, 1, 4, 3 };
            int target = 5;
            int expected = 5;

            //Act
            int pairs = PairCounter(inputList, target);

            //Assert
            Assert.AreEqual(expected, pairs);
        }
    }
}