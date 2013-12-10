using NockInterpreter;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace NockInterpreterTestProject
{
    
    
    /// <summary>
    ///This is a test class for InterpreterTest and is intended
    ///to contain all InterpreterTest Unit Tests
    ///</summary>
    [TestClass()]
    public class InterpreterTest
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
        ///A test for Nock
        ///</summary>
        [TestMethod()]
        public void NockTest()
        {
            string program = "[[19 42] 0 3]";
            string expected = "42";
            Noun actual;
            actual = Interpreter.Nock(program);
            Assert.AreEqual(expected, actual.ToString());

            // tests from: http://www.urbit.org/2013/11/18/urbit-is-easy-ch3.html
            program = "[[19 42] 0 3]";
            expected = "42";
            actual = Interpreter.Nock(program);
            Assert.AreEqual(expected, actual.ToString());
        
        }
    }
}
