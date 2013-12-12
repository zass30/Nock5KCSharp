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
            // tests from: http://www.urbit.org/2013/11/18/urbit-is-easy-ch3.html
            string program = "[[19 42] 0 3]";
            string expected = "42";
            Noun actual;
            actual = Interpreter.Nock(program);
            Assert.AreEqual(expected, actual.ToString());

            // tests from: https://github.com/mnemnion/sandbox/blob/master/doc/nockdown.md
            program = "[[132 19] [10 37 [4 0 3]]]";
            expected = "20";
            actual = Interpreter.Nock(program);
            Assert.AreEqual(expected, actual.ToString());

            // tests from: https://github.com/jtauber/pynock/blob/master/test.rst
            program = "[[[4 5] [6 14 15]] 0 7]";
            expected = "[14 15]";
            actual = Interpreter.Nock(program);
            Assert.AreEqual(expected, actual.ToString());

            program = "[42 1 153 218]";
            expected = "[153 218]";
            actual = Interpreter.Nock(program);
            Assert.AreEqual(expected, actual.ToString());

            program = "[77 [2 [1 42] [1 1 153 218]]]";
            expected = "[153 218]";
            actual = Interpreter.Nock(program);
            Assert.AreEqual(expected, actual.ToString());
 
            program = "[57 [0 1]]";
            expected = "57";
            actual = Interpreter.Nock(program);
            Assert.AreEqual(expected, actual.ToString());

            program = "[[132 19] [0 3]]";
            expected = "19";
            actual = Interpreter.Nock(program);
            Assert.AreEqual(expected, actual.ToString());

            program = "[42 [4 0 1]]";
            expected = "43";
            actual = Interpreter.Nock(program);
            Assert.AreEqual(expected, actual.ToString());

            program = "[42 [3 0 1]]";
            expected = "1";
            actual = Interpreter.Nock(program);
            Assert.AreEqual(expected, actual.ToString());

            program = "[42 [[4 0 1] [3 0 1]]]";
            expected = "[43 1]";
            actual = Interpreter.Nock(program);
            Assert.AreEqual(expected, actual.ToString()); 

            program = "[[132 19] [10 37 [4 0 3]]]";
            expected = "20";
            actual = Interpreter.Nock(program);
            Assert.AreEqual(expected, actual.ToString());

            program = "[42 [7 [4 0 1] [4 0 1]]]";
            expected = "44";
            actual = Interpreter.Nock(program);
            Assert.AreEqual(expected, actual.ToString()); 

            program = "[42 [8 [4 0 1] [0 1]]]";
            expected = "[43 42]";
            actual = Interpreter.Nock(program);
            Assert.AreEqual(expected, actual.ToString()); 

            program = "[42 [8 [4 0 1] [4 0 3]]]";
            expected = "43";
            actual = Interpreter.Nock(program);
            Assert.AreEqual(expected, actual.ToString()); 

            program = "[42 [6 [1 0] [4 0 1] [1 233]]]";
            expected = "43";
            actual = Interpreter.Nock(program);
            Assert.AreEqual(expected, actual.ToString()); 

            program = "[42 [6 [1 1] [4 0 1] [1 233]]]";
            expected = "233";
            actual = Interpreter.Nock(program);
            Assert.AreEqual(expected, actual.ToString());

            // tests from https://groups.google.com/forum/#!topic/urbit-dev/K7QpBge30JI
            program = "[10 [8 [1 [1 1]] [8 [1 0] [8 [1 [6 [5 [0 15] [4 0 6]] [0 28] [9 2 [[0 2] [4 0 6] [[0 29] [7 [0 14] [8 [1 0] [8 [1 [6 [5 [0 14] [0 6]] [0 15] [9 2 [[0 2] [4 0 6] [0 14] [4 0 15]]]]] [9 2 0 1]]]]] [0 15]]]]] [9 2 0 1]]]]]";
            expected = "55";
            actual = Interpreter.Nock(program);
            Assert.AreEqual(expected, actual.ToString());



/*
            program = "[13 [8 [1 [1 1]] [8 [1 0] [8 [1 [6 [5 [0 15] [4 0 6]] [0 28] [9 2 [[0 2] [4 0 6] [[0 29] [7 [0 14] [8 [1 0] [8 [1 [6 [5 [0 14] [0 6]] [0 15] [9 2 [[0 2] [4 0 6] [0 14] [4 0 15]]]]] [9 2 0 1]]]]] [0 15]]]]] [9 2 0 1]]]]]";
            expected = "233";
            actual = Interpreter.Nock(program);
            Assert.AreEqual(expected, actual.ToString());

            program = "[13 [8 [1 [1 1]] [8 [1 0] [8 [1 [6 [5 [0 15] [4 0 6]] [0 28] [9 2 [[0 2] [4 0 6] [[0 29] [7 [0 14] [8 [1 0] [8 [1 [6 [5 [0 14] [0 6]] [0 15] [9 2 [[0 2] [4 0 6] [0 14] [4 0 15]]]]] [9 2 0 1]]]]] [0 15]]]]] [9 2 0 1]]]]]";
            expected = "233";
            actual = Interpreter.Nock(program);
            Assert.AreEqual(expected, actual.ToString());

            program = "[13 [8 [1 [1 1]] [8 [1 0] [8 [1 [6 [5 [0 15] [4 0 6]] [0 28] [9 2 [[0 2] [4 0 6] [[0 29] [7 [0 14] [8 [1 0] [8 [1 [6 [5 [0 14] [0 6]] [0 15] [9 2 [[0 2] [4 0 6] [0 14] [4 0 15]]]]] [9 2 0 1]]]]] [0 15]]]]] [9 2 0 1]]]]]";
            expected = "233";
            actual = Interpreter.Nock(program);
            Assert.AreEqual(expected, actual.ToString());

            program = "[13 [8 [1 [1 1]] [8 [1 0] [8 [1 [6 [5 [0 15] [4 0 6]] [0 28] [9 2 [[0 2] [4 0 6] [[0 29] [7 [0 14] [8 [1 0] [8 [1 [6 [5 [0 14] [0 6]] [0 15] [9 2 [[0 2] [4 0 6] [0 14] [4 0 15]]]]] [9 2 0 1]]]]] [0 15]]]]] [9 2 0 1]]]]]";
            expected = "233";
            actual = Interpreter.Nock(program);
            Assert.AreEqual(expected, actual.ToString());

            program = "[13 [8 [1 [1 1]] [8 [1 0] [8 [1 [6 [5 [0 15] [4 0 6]] [0 28] [9 2 [[0 2] [4 0 6] [[0 29] [7 [0 14] [8 [1 0] [8 [1 [6 [5 [0 14] [0 6]] [0 15] [9 2 [[0 2] [4 0 6] [0 14] [4 0 15]]]]] [9 2 0 1]]]]] [0 15]]]]] [9 2 0 1]]]]]";
            expected = "233";
            actual = Interpreter.Nock(program);
            Assert.AreEqual(expected, actual.ToString());
*/

            program = "[42 [10 [0 [0 2]] [0 1]]]";
            expected = "233";
            try
            {
                actual = Interpreter.Nock(program);
                Assert.Fail("This program should have thrown");
            }
            catch
            {
                Assert.IsTrue(true, "Correctly threw");
            }

            program = "[42 [8 [1 0] [8 [1 [6 [5 [0 7] [4 0 6]] [0 6] [9 2 [[0 2] [4 0 6] [0 7]]]]] [9 2 0 1]]]]";
            expected = "41";
            actual = Interpreter.Nock(program);
            Assert.AreEqual(expected, actual.ToString());       

            // my own tests
            program = "10";
            try
            {
                actual = Interpreter.Nock(program);
                Assert.Fail("This program should have thrown");
            }
            catch (Exception e)
            {
                Assert.AreEqual(e.Message, "Infinite loop nocking an atom: 10");
            }

            // fib 16 should stack overflow unless tail call elimination is implemented
            program = "[18 [8 [1 [1 1]] [8 [1 0] [8 [1 [6 [5 [0 15] [4 0 6]] [0 28] [9 2 [[0 2] [4 0 6] [[0 29] [7 [0 14] [8 [1 0] [8 [1 [6 [5 [0 14] [0 6]] [0 15] [9 2 [[0 2] [4 0 6] [0 14] [4 0 15]]]]] [9 2 0 1]]]]] [0 15]]]]] [9 2 0 1]]]]]";
            expected = "2584";
            actual = Interpreter.Nock(program);
            Assert.AreEqual(expected, actual.ToString());

        }
    }
}
