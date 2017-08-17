using System.Web;
using System.Web.Optimization;

namespace Erasmus_MTA
{
    public class BundleConfig
    {
        // For more information on bundling, visit https://go.microsoft.com/fwlink/?LinkId=301862
        public static void RegisterBundles(BundleCollection bundles)
        {
            bundles.Add(new ScriptBundle("~/bundles/jquery").Include(
                        "~/Scripts/jquery-{version}.js"));

            bundles.Add(new ScriptBundle("~/bundles/jqueryval").Include(
                        "~/Scripts/jquery.validate*"));

            bundles.Add(new ScriptBundle("~/bundles/bootstrap").Include(
                      "~/Scripts/bootstrap.js",
                      "~/Scripts/respond.js"));

            bundles.Add(new ScriptBundle("~/bundles/jsgrid").Include(
                      "~/Content/jsgrid.min.js",
                      "~/Scripts/custom.jsgrid.js"));

            bundles.Add(new ScriptBundle("~/bundles/jstree").Include(
                      "~/Scripts/dist/jstree.min.js",
                      "~/Scripts/custom.jstree.js"));

            bundles.Add(new StyleBundle("~/Content/jsgrid").Include(
                      "~/Content/jsgrid.min.css",
                      "~/Content/jsgrid-theme.min.css"));

            bundles.Add(new StyleBundle("~/Content/css").Include(
                      "~/Content/bootstrap.css",
                      "~/Content/site.css",
                      "~/Content/sb-admin.css",
                      "~/Scripts/dist/themes/proton/style.css"));
        }
    }
}
