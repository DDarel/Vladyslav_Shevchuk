using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Data.SqlTypes;
using System.Security.Cryptography;
using static System.Net.Mime.MediaTypeNames;

namespace TasksAndTests
{
    public class ExtraTask2Tests
    {
        public static string uintToAdress(uint num)
        {
            int  tracker = 0;
            uint[] binArray = new uint[32];
            while (tracker < 32)
            {
                binArray[tracker] = (num % 2);
                num /= 2;
                tracker++;
            }
            tracker = 0;
            string output = "";
            while (tracker < 4) {
                uint dec = 0;
                int pow = 0;
                for (int j= tracker * 8; j < tracker * 8 + 8; j++) {
                    dec += binArray[j] * (uint)Math.Pow(2, pow);
                    pow++;
                }
                output = output.Insert(0, dec.ToString());
                if (tracker != 3) {
                    output = output.Insert(0, ".");
                }
                tracker++;
            }
            return output;
        }

        [Test]
        public void ExtraTask2Test1()
        {
            //Arrange
            uint input = 2149583361;
            string expected= "128.32.10.1";

            //Act
            string result = uintToAdress(input);

            //Assert
            Assert.AreEqual(expected, result);
        }
        [Test]
        public void ExtraTask2Test2()
        {
            //Arrange
            uint input = 32;
            string expected = "0.0.0.32";

            //Act
            string result = uintToAdress(input);

            //Assert
            Assert.AreEqual(expected, result);
        }
    }
}