using System;
using buffetTest;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTestForAlgoritmTasks
{
    [TestClass]
    public class UnitTest1
    {
        EasyQuestions easyQuestions;
        public UnitTest1()
        {
            easyQuestions = new EasyQuestions();
        }
        [TestMethod]
        public void TestMethod1()
        {
            var response = easyQuestions.FizzBuzz(3);
            

        }
    }
}
