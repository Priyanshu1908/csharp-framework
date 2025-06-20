namespace csharp_framework.lib.model
{
    internal class TestEvidence
    {

        public string Screenshot { get; set; }

        public string StepName { get; set;}

        public string Details { get; set; }

        public string Expected { get; set; } = "";

        public string Actual { get; set; } = "";

        public TestType TestType { get; set; }

        public TestStatus StepStatus { get; set; }

        public Api Api { get; set; }

        public Dictionary<string, string> CustomRows { get; set; } = new();

        public List<string> EmbeddedFiles = new();

    }
}
