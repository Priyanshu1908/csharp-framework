//using AventStack.ExtentReports;
//using AventStack.ExtentReports.Reporter;
//using csharp_framework.lib.model;

//namespace csharp_framework.lib
//{
//    public class HtmlReportGenerator : IReportGenerator
//    {

//        private const string HtmlPath = "/HTML_Reports";
//        private TestReport _testReport;
//        private static readonly string Sep = Path.DirectorySeparatorChar.ToString();
//        public IReportGenerator Prepare(TestReport testReport)
//        {
//            _testReport = testReport;
//            Directory.CreateDirectory(_testReport.GetOutputPath() + HtmlPath);
//            return this;
//        }

//        public void RenderAndSave()
//        {
//            ExtentReports extentReports = new ExtentReports();
//            var outputPath = _testReport.GetOutputPath() + HtmlPath;
//            ExtentSparkReporter htmlReporter = new ExtentSparkReporter(outputPath + Sep);
//            extentReports.AttachReporter(htmlReporter);
//            extentReports.AddSystemInfo("Executed By", Environment.UserName);
//            var localZone = TimeZoneInfo.Local;
//            extentReports.AddSystemInfo("Time Zone", localZone.StandardName);
//            extentReports.AddSystemInfo("Executed On", Environment.MachineName);
//            extentReports.AddSystemInfo("Operating System", Environment.OSVersion.ToString());
//            foreach(var item in _testReport.TestData.CustomRows)
//            {
//                extentReports.AddSystemInfo(item.Key, item.Value);
//            }
//            var extentTest = extentReports.CreateTest(_testReport.TestData.Name);
//            foreach(var evidence in _testReport.TestData.TestEvidences)
//            {
//                extentTest.Log(TestStatus2AvantStatus(evidence.StepStatus),
//                    "Expected Result: " + evidence.Expected + "<br>" + "Actual Result: " + evidence.Actual);
//            }
//            extentReports.Flush();
//            try
//            {
//                if (File.Exists(GetPath(_testReport))) { File.Delete(GetPath(_testReport)); }
//                File.Move(outputPath + Sep + "index.html", GetPath(_testReport));
//            }catch (Exception e)
//            {
//                throw new Exception(e.Message);
//            }
//        }

//        private static Status TestStatus2AvantStatus(TestStatus status)
//        {
//            return status switch
//            {
//                TestStatus.Passed => Status.Pass,
//                TestStatus.Ignored => Status.Skip,
//                _ => Status.Fail
//            };
//        }

//        public static string GetPath(TestReport report)
//        {
//            var outputPath = report.GetOutputPath() + HtmlPath;
//            var fileName = report.TestData.Name + (report.TestData.TestParam.IsNullOrEmpty() ? "" : "_") + report.TestData.TestParam + ".html";
//            return outputPath + Sep + fileName;
//        }
//    }
//}
