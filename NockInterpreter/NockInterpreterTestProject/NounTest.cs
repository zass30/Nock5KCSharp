using NockInterpreter;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace NockInterpreterTestProject
{
    
    
    /// <summary>
    ///This is a test class for NounTest and is intended
    ///to contain all NounTest Unit Tests
    ///</summary>
    [TestClass()]
    public class NounTest
    {


        private TestContext testContextInstance;

        /// <summary>
        ///Gets or sets the test context which provides
        ///information about and functionality for the current test run.
        ///</summary>
        public TestContext TestContext
        {
            get
            {
                return testContextInstance;
            }
            set
            {
                testContextInstance = value;
            }
        }

        #region Additional test attributes
        // 
        //You can use the following additional attributes as you write your tests:
        //
        //Use ClassInitialize to run code before running the first test in the class
        //[ClassInitialize()]
        //public static void MyClassInitialize(TestContext testContext)
        //{
        //}
        //
        //Use ClassCleanup to run code after all tests in a class have run
        //[ClassCleanup()]
        //public static void MyClassCleanup()
        //{
        //}
        //
        //Use TestInitialize to run code before running each test
        //[TestInitialize()]
        //public void MyTestInitialize()
        //{
        //}
        //
        //Use TestCleanup to run code after each test has run
        //[TestCleanup()]
        //public void MyTestCleanup()
        //{
        //}
        //
        #endregion

        /// <summary>
        ///A test for IsAtom
        ///</summary>
        [TestMethod()]
        public void IsAtomTest()
        {
            string program = "23515"; 
            bool expected = true;
            bool actual;
            actual = Noun.IsAtom(program);
            Assert.AreEqual(expected, actual);

            program = "1";
            expected = true;
            actual = Noun.IsAtom(program);
            Assert.AreEqual(expected, actual);

            program = "0";
            expected = true;
            actual = Noun.IsAtom(program);
            Assert.AreEqual(expected, actual);
        }

        /// <summary>
        ///A test for IsCell
        ///</summary>
        [TestMethod()]
        public void IsCellTest()
        {
            string program = "[[[0 3] [3 [243145 5]]] 0]"; 
            bool expected = true; 
            bool actual;
            actual = Noun.IsCell(program);
            Assert.AreEqual(expected, actual);
        }

        /// <summary>
        ///A test for IsInt
        ///</summary>
        [TestMethod()]
        public void IsIntTest()
        {
            char c = '\0'; 
            bool expected = false; 
            bool actual;
            actual = Noun.IsInt(c);
            Assert.AreEqual(expected, actual);
        }

        /// <summary>
        ///A test for IsValidChar
        ///</summary>
        [TestMethod()]
        public void IsValidCharTest()
        {
            char c = '['; // TODO: Initialize to an appropriate value
            bool expected = true; // TODO: Initialize to an appropriate value
            bool actual;
            actual = Noun.IsValidChar(c);
            Assert.AreEqual(expected, actual);
        }

        /// <summary>
        ///A test for SplitCell
        ///</summary>
        [TestMethod()]
        public void SplitCellTest()
        {
            string program = "[[23 0] [34 2]]"; 
            Tuple<string, string> expected = new Tuple<string,string>("[23 0]", "[34 2]"); 
            Tuple<string, string> actual;
            actual = Noun.SplitCell(program);
            Assert.AreEqual(expected, actual);

            program = "[[1 2] [3 [3 4]]]";
            expected = new Tuple<string, string>("[1 2]", "[3 [3 4]]");
            actual = Noun.SplitCell(program);
            Assert.AreEqual(expected, actual);
        }
    }
}
