using NuGet.Frameworks;
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

                if (int.TryParse(list[i].ToString(), out var x)){
                    if (!list[i].Equals(x)) {
                        list.RemoveAt(i);
                        i--;
                    }
                } else {
                    list.RemoveAt(i);
                    i--;
                }
            }
            return list;
        }

        [Test]
        public void Task1Test1()
        {
            //Arrange

            List<object> listInput = new List<object> { 1, 2, 'a', '1', 2 };
            List<object> listExpected = new List<object> { 1, 2, 2};

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