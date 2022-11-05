using NUnit.Framework;
using System;
using System.Collections.Generic;

namespace TasksAndTests
{
    public class Task5Tests
    {
        public static string Meeting(string listing)
        {
            string[] temp = listing.Split(new char[] { ';', ':' });
            string[] list = new string[temp.Length / 2];
            for (int i = 0; i < temp.Length / 2; i++)
            {
                list[i] = "(" + temp[i * 2 + 1].ToUpper() + ", " + temp[i * 2].ToUpper() + ")";
            }
            Array.Sort(list);
            string final = "";
            for (int i = 0; i < list.Length; i++)
            {
                final += list[i];
            }
            return final;
        }

        [Test]
        public void Task5Test1()
        {
            //Arrange
            string input = "Fired:Corwill;Wilfred:Corwill;Barney:TornBull;Betty:Tornbull;Bjon:Tornbull;Raphael:Corwill;Alfred:Corwill";
            string expected = "(CORWILL, ALFRED)(CORWILL, FIRED)(CORWILL, RAPHAEL)(CORWILL, WILFRED)(TORNBULL, BARNEY)(TORNBULL, BETTY)(TORNBULL, BJON)";

            //Act
            input = Meeting(input);

            //Assert
            Assert.AreEqual(expected, input);
        }
        [Test]
        public void Task5Test2()
        {
            //Arrange
            string input = "Fired:Corwill;Wilfred:Corwill;Barney:TornBull;Betty:Tornbull;Slava:Ukrainovna;Raphael:Shevchuk;Alfred:Corwill";
            string expected = "(CORWILL, ALFRED)(CORWILL, FIRED)(CORWILL, WILFRED)(SHEVCHUK, RAPHAEL)(TORNBULL, BARNEY)(TORNBULL, BETTY)(UKRAINOVNA, SLAVA)";

            //Act
            input = Meeting(input);

            //Assert
            Assert.AreEqual(expected, input);
        }
    }
}