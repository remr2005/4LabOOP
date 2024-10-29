namespace StressTest
{
    /// <summary>
    /// Enumeration of girder material types
    /// </summary>
    public enum Material
    {
        StainlessSteel,
        Aluminium,
        ReinforcedConcrete,
        Composite,
        Titanium
    }

    /// <summary>
    /// Enumeration of girder cross-sections
    /// </summary>
    public enum CrossSection
    {
        IBeam,
        Box,
        ZShaped,
        CShaped
    }

    /// <summary>
    /// Enumeration of test results
    /// </summary>
    public enum TestResult
    {
        Pass,
        Fail
    }

    /// <summary>
    /// Структура, содержащая результаты испытаний
    /// </summary>
    public struct TestCaseResult
    {
        /// <summary>
        /// Тест result (перечисление)
        /// </summary>
        public TestResult Result;
        /// <summary>
        /// Описание причины сбоя
        /// </summary>
        public string ReasonForFailure;
        /// <summary>
        /// конструктор структуры
        /// </summary>
        /// <param name="result">результат</param>
        /// <param name="reason">причина</param>
        public TestCaseResult(TestResult result, string reason)
        {
            Result = result;
            ReasonForFailure = reason;
        }
    }
}
