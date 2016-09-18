using System.Web;
using System.Web.Optimization;

namespace Cosmicdistortion.DataShifter
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

            // Google material design instead of bootstrap
            bundles.Add(new ScriptBundle("~/bundles/mdl").Include(
                                        "~/Content/mdl-v1.1.2/material.js"));
            bundles.Add(new StyleBundle("~/Content/mdl").Include(
                                    "~/Content/mdl-v1.1.2/material.css"));

            bundles.Add(new StyleBundle("~/Content/css").Include(
                      "~/Content/site.css"));

            // CodeMirror bundles
            bundles.Add(new ScriptBundle("~/bundles/codemirror").Include(
                                    "~/Scripts/codemirror/lib/codemirror.js",
                                    "~/Scripts/codemirror/mode/sql/sql.js",
                                    "~/Scripts/codemirror/addon/hint/show-hint.js",
                                    "~/Scripts/codemirror/addon/hint/sql-hint.js"));
            bundles.Add(new StyleBundle("~/Content/codemirror").Include(
                                    "~/Scripts/codemirror/lib/codemirror.css",
                                    "~/Scripts/codemirror/theme/erlang-dark.css",
                                    "~/Scripts/codemirror/addon/hint/show-hint.css"));
        }
    }
}
