//using csharp_framework.lib.model;

//namespace csharp_framework.lib
//{
//    public class TestReport
//    {

//        private string _outputPath;
//        private static readonly string Sep = Path.DirectorySeparatorChar.ToString();

//        public TestReport(TestData data)
//        {
//            TestData = data;
//        }

//        public TestReport SetOutputPath(string path)
//        {
//            _outputPath = path;
//            return this;
//        }

//        public string GetOutputPath()
//        {
//            if (_outputPath.IsNullOrEmpty()) throw new Exception("Report output path is not set");
//            return _outputPath;
//        }

//        public TestData TestData { get; set; }

//        /// <summary>
//        /// Add test evidence to test report
//        /// </summary>
//        /// <param name="evidence"></param>
//        /// <returns></returns>
//        public TestReport AddEvidence(TestEvidence evidence)
//        {
//            TestData.TestEvidences ??= new List<TestEvidence>();
//            if (TestData.TestCaseStatus != TestStatus.Failed) TestData.TestCaseStatus = evidence.StepStatus;
//            TestData.TestEvidences.Add(evidence);
//            return this;
//        }
//    }
//}
