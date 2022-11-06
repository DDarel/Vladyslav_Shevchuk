using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Security.Cryptography;

namespace TasksAndTests
{
    public class ExtraTask1Tests
    {
        public static int ReturnBiggerNumber(int number)
        {
            int[] arrNumber = new int[number.ToString().Length];
            int tracker = 0;
            while (number > 0) {
                arrNumber[tracker] = number % 10;
                number/=10;
                tracker++;
            }
            //2347 ---> [7][4][3][2] ---> [4][7][3][2] ---> 2374
            //2343 ---> [3][4][3][2] ---> [3][3][4][2] ---> 2433
            //1231  ---> [1][3][2][1]  ---> [2][1][3][1]  ---> 1312
            tracker = 0;
            while (tracker < arrNumber.Length - 1) {
                if (arrNumber[tracker] > arrNumber[tracker + 1])
                {
                    int temp = arrNumber[tracker];
                    arrNumber[tracker] = arrNumber[tracker + 1];
                    arrNumber[tracker + 1] = temp;
                    while (tracker > 0)
                    {
                        if (arrNumber[tracker] > arrNumber[tracker - 1]) {
                            temp = arrNumber[tracker];
                            arrNumber[tracker] = arrNumber[tracker - 1];
                            arrNumber[tracker - 1] = temp;
                        } 
                        tracker--; 
                    }
                    break;
                }
                else tracker++;
            }
            number = 0;
            for (int i = 0; i < arrNumber.Length; i++) {
                number = number + arrNumber[i] * (int)(Math.Pow(10, i));
            }
            return number;
        }


        [Test]
        public void ExtraTask1Test1()
        {
            //Arrange
            int input = 2047;
            int expected = 2074;

            //Act
            input = ReturnBiggerNumber(input);

            //Assert
            Assert.AreEqual(expected, input);
        }
        [Test]
        public void ExtraTask1Test2()
        {
            //Arrange
            int input = 1231;
            int expected = 1312;

            //Act
            input = ReturnBiggerNumber(input);

            //Assert
            Assert.AreEqual(expected, input);
        }
    }
}