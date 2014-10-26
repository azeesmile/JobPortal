using System.Web.Optimization;

namespace JobPortal
{
    public class BundleConfig
    {
        // For more information on bundling, visit http://go.microsoft.com/fwlink/?LinkId=301862
        public static void RegisterBundles(BundleCollection bundles)
        {
            bundles.Add(new ScriptBundle("~/bundles/jquery").Include(
                        "~/Scripts/jquery-{version}.js"));

            bundles.Add(new ScriptBundle("~/bundles/jqueryval").Include(
                        "~/Scripts/jquery.validate*"));

            // Use the development version of Modernizr to develop with and learn from. Then, when you're
            // ready for production, use the build tool at http://modernizr.com to pick only the tests you need.
            bundles.Add(new ScriptBundle("~/bundles/modernizr").Include(
                        "~/Scripts/modernizr-*"));

            bundles.Add(new ScriptBundle("~/bundles/bootstrap").Include(
                      "~/Scripts/bootstrap.js",
                      "~/Scripts/respond.js"));

            bundles.Add(new StyleBundle("~/Content/css").Include(
                      "~/Content/bootstrap.css",
                      "~/Content/site.css"));

            #region FrontEnd

            bundles.Add(new ScriptBundle("~/FrontEnd/bundles/jquery").Include(
                        "~/Areas/FrontEnd/Scripts/jquery-{version}.js"));

            bundles.Add(new ScriptBundle("~/FrontEnd/bundles/scripts").Include(
                        "~/Areas/FrontEnd/Scripts/script.js"));

            bundles.Add(new StyleBundle("~/FrontEnd/Content/css").Include("~/Areas/FrontEnd/Content/style.css"));

            #endregion

            #region FrontEnd

            bundles.Add(new ScriptBundle("~/Website/bundles/jquery").Include(
                        "~/Scripts/jquery-{version}.js"));

            bundles.Add(new ScriptBundle("~/Website/bundles/scripts").Include(
                        "~/Scripts/script.js"));

            bundles.Add(new StyleBundle("~/Website/Content/css").Include("~/Content/style.css"));

            #endregion

        }
    }
}
