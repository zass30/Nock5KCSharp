using NockInterpreter;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace NockInterpreterTestProject
{
    
    
    /// <summary>
    ///This is a test class for CellTest and is intended
    ///to contain all CellTest Unit Tests
    ///</summary>
    [TestClass()]
    public class CellTest
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
        ///A test for Cell Constructor
        ///</summary>
        [TestMethod()]
        public void CellConstructorTest()
        {
            // test a bad cell
            string program = "[1 2] [3 4]";
            Cell target;
            try
            {
                target = new Cell(program);
                Assert.Fail("Shouldn't be able to create an invalid Cell");
            }
            catch (ArgumentException e)
            {
                Assert.AreEqual(e.Message, "Invalid Cell: " + program);
            }

            // test a good cell gets brackets added
            program = "[1 [2 3] [5 3]]";
            string expected = "[1 [[2 3] [5 3]]]";
            target = new Cell(program);
            Assert.AreEqual(expected, target.ToString());
        }
    }
}
