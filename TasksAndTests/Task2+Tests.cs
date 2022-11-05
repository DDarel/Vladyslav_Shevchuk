using NUnit.Framework;
using System.Collections.Generic;

namespace TasksAndTests
{
    public class Task2Tests
    {
        public static string FirstNoneRepeatingLetter(string enter)
        {
            char[] string_to_char_arr = enter.ToCharArray();
            for (int i = 0; i < string_to_char_arr.Length; i++)
            {
                if (!string_to_char_arr[i].Equals(' ') &&
                       enter.IndexOf(string_to_char_arr[i]) == enter.LastIndexOf(enter[i]) &&
                     (enter.LastIndexOf(enter[i].ToString().ToUpper()) == -1 || enter.LastIndexOf(enter[i].ToString().ToLower()) == -1)
                     )
                {
                    return enter[i].ToString();
                }
            }
            return "No letters";
        }

        [Test]
        public void Task2Test1()
        {
            //Arrange
            string input = "I love cookies";
            string expected = "l";

            //Act
            input = FirstNoneRepeatingLetter((input));

            //Assert
            Assert.AreEqual(expected, input);
        }
        [Test]
        public void Task2Test2()
        {
            //Arrange
            string input = "cAnT ImaGIne where I WILL work";
            string expected = "c";

            //Act
            input = FirstNoneRepeatingLetter((input));

            //Assert
            Assert.AreEqual(expected, input);
        }
    }
}