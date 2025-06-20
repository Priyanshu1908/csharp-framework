namespace csharp_framework.lib.model
{
    /// <summary>
    /// Type of test used for report generation assignment
    /// </summary>
    public enum TestType
    {

        /// <summary>
        /// Unit Test
        /// </summary>
        Unit,

        /// <summary>
        /// Web Application Test
        /// </summary>
        Web,

        /// <summary>
        /// API Test
        /// </summary>
        Api,

        /// <summary>
        /// Web and API Test
        /// </summary>
        WebApi,

        /// <summary>
        /// Standalone Application Test
        /// </summary>
        App,

        /// <summary>
        /// Excel Test
        /// </summary>
        Xls,

        /// <summary>
        /// Database Test
        /// </summary>
        Dbs
    }
}
