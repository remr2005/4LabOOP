using System;

namespace StressTest
{
    public class TestManager
    {
        /// <summary>
        /// генератор случайного TestResult
        /// </summary>
        /// <returns>возвращаю TestResult</returns>
        public static TestCaseResult GenerateResult() 
        {
            string[] reasons = new string[5] { "Material fatigue", "Design flaw", "Overload", "Environmental factors", "Manufacturing defect" };
            Random random = new Random();
            TestResult result = (random.Next() % 2 == 0) ? TestResult.Pass : TestResult.Fail;
            return new TestCaseResult(result, (result.Equals(TestResult.Pass)) ? "" : reasons[random.Next()%5]);
        }
    }
}
