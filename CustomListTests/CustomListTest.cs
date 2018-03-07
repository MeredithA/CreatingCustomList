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
            customList.Add(1);
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
            customList.Add(1);
            customList.Add(2);
            customList.Add(3);
            customList.Add(4);
            customList.Add(5);
            customList.Add(6);
            customList.Add(7);
            customList.Add(8);
            customList.Add(9);
            customList.Add(10);
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



        //[TestMethod]
        //[ExpectedException(typeof(IndexOutOfRangeException))]
        //public void GettingValueOfIndexNotInListThrowsException()
        //{
        //    //for each
        //}
    }
}


// arrange  (hard code what you are testing

//Act (calling the method to be run)

//Assert
//Assert.AreEqual(expected, actual);



//string build for TO STRING
//for each needs ienumerable