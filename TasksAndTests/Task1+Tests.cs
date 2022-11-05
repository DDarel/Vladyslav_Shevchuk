using NUnit.Framework;
using System.Collections.Generic;

namespace TasksAndTests
{
    public class Task1Tests
    {
        public static List<object> GetIntegersFromList(List<object> list)
        {
            for (int i = 0; i < list.Count; i++)
            {
                if (list[i].Equals(list[i].ToString()))
                {
                    list.RemoveAt(i);
                }
            }
            return list;
        }

        [Test]
        public void Task1Test1()
        {
            //Arrange
            List<object> listInput = new List<object>() { "asdasdasd", 21, "asd", 2, "ekekk", 13, 45 };
            List<object> listExpected = new List<object>() { 21,  2, 13, 45 };

            //Act
            listInput = GetIntegersFromList(listInput);

            //Assert
            Assert.AreEqual(listExpected, listInput);
        }
        [Test]
        public void Task1Test2()
        {
            //Arrange
            List<object> listInput = new List<object>() { "ekekk", 123123,"asdasd"};
            List<object> listExpected = new List<object>() { 123123};

            //Act
            listInput = GetIntegersFromList(listInput);

            //Assert
            Assert.AreEqual(listExpected, listInput);
        }
    }
}