using csharp_framework.lib.model;
using Newtonsoft.Json.Linq;
using NPOI.Util.Collections;
using System.Text;

namespace csharp_framework.lib
{
    public class Utilities
    {
        private static Properties _config;

        public static Properties GetConfig(string filename)
        {
            Encoding.RegisterProvider(CodePagesEncodingProvider.Instance);
            _config = new Properties();
            _config.Load(new FileStream(filename, FileMode.Open, FileAccess.Read));
            return _config;
        }

        public static TestStatus TryAssert(Action action)
        {
            try
            {
                action();
                return TestStatus.Passed;
            }
            catch (AssertionException)
            {
                return TestStatus.Failed;
            }
        }

        public static string GetSolutionPath()
        {
            return Directory.GetParent(Environment.CurrentDirectory)?.Parent?.Parent?.FullName;
        }

        public static string ReadJson(string path, string token)
        {
            string text = File.ReadAllText(path);
            var jsonObject = JToken.Parse(text);
            return jsonObject.SelectToken(token).Value<string>();
        }
    }
}
