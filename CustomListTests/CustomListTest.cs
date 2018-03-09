using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using CreatingCustomLists;

namespace CustomListTests
{
    [TestClass]
    public class CustomListTest
    {
        [TestMethod]
        public void AddPutsIntIntoListTest()
        {
            CustomList<int> customList = new CustomList<int>();

            //arrange
            int expected = 45;
            int actual;

            //Assert
            customList.Add(expected);
            actual = customList[0];

            //Assert
            Assert.AreEqual(expected, actual);

        }
        [TestMethod]
        public void AddingPastInitialArrayValueCorrectlyAddsItem()
        {
            CustomList<int> customList = new CustomList<int>();
            //arrange
            int expected = 45;
            int actual;

            //act
            CustomList<int> add = new CustomList<int> { 1, 1, 1, 1, 1, 1, 1, 1, 1, 1 };
            customList.Add(1);
            customList.Add(1);
            customList.Add(1);
            customList.Add(1);
            customList.Add(1);
            customList.Add(1);
            customList.Add(1);
            customList.Add(1);
            customList.Add(1);
            customList.Add(expected);
            actual = customList[10];

            //assert
            Assert.AreEqual(expected, actual);

        }
        [TestMethod]

        public void MethodRemovesAnItem()
        {
            CustomList<int> customList = new CustomList<int>();

            //arrange
            int expected = 2;
            int actual;

            //act
            CustomList<int> remove = new CustomList<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            customList.Remove(0);
            actual = customList[1];

            //assert
            Assert.AreEqual(expected, actual);

        }
        [TestMethod]
        public void IemnumerableTestByReturningElementsInALists()
        {
            CustomList<string> customList = new CustomList<string>();


            // arrange
            string expected = "TestingTheIEnumerable";
            string actual = "";

            //act
            customList.Add("Testing");
            customList.Add("The");
            customList.Add("IEnumerable");
            foreach (string item in customList)
            {
                actual += item;
            }

            //assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void TestPlusOperator()
        {
            CustomList<int> firstList = new CustomList<int> { 3, 4, 7, 12, 15 };
            CustomList<int> secondList = new CustomList<int> { 6, 1, 18, 20, 5 };

            CustomList<int> finalList = firstList + secondList;

            Assert.AreEqual(10, finalList.Count);
        }
    }
}
