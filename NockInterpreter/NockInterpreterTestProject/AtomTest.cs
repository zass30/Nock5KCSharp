using NockInterpreter;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace NockInterpreterTestProject
{
    
    
    /// <summary>
    ///This is a test class for AtomTest and is intended
    ///to contain all AtomTest Unit Tests
    ///</summary>
    [TestClass()]
    public class AtomTest
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
        ///A test for Atom Constructor
        ///</summary>
        [TestMethod()]
        public void AtomConstructorTest()
        {
            string program = "99";
            Atom target = new Atom(program);
            Assert.AreEqual(99, target.value);

            program = String.Empty;
            try
            {
                target = new Atom(program);
                Assert.Fail("Shouldn't be able to create an empty Atom");
            }
            catch (ArgumentException e)
            {
                Assert.AreEqual(e.Message, "Invalid Atom: ");
            }

            program = "-5";
            try
            {
                target = new Atom(program);
                Assert.Fail("Shouldn't be able to create a negative Atom");
            }
            catch (ArgumentException e)
            {
                Assert.AreEqual(e.Message, "Invalid Atom: -5");
            }

        }
    }
}
