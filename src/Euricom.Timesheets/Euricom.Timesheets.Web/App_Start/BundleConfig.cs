using System.Web;
using System.Web.Optimization;

namespace Euricom.Timesheets.Web
{
    public class BundleConfig
    {
        public static void RegisterBundles(BundleCollection bundles)
        {
            bundles.Add(new ScriptBundle("~/bundles/jquery").Include(
                        "~/Scripts/jquery-1.*"));

            bundles.Add(new ScriptBundle("~/bundles/bootstrap").Include(
                        "~/Scripts/bootstrap.min.js"));

            bundles.Add(new ScriptBundle("~/bundles/knockout").Include(
                        "~/Scripts/knockout-2.1.0.js"));

            bundles.Add(new StyleBundle("~/Content/bootstrap/css").Include(
                        "~/Content/bootstrap-custom.css",
                        "~/Content/bootstrap.min.css",
                        "~/Content/bootstrap-responsive.min.css"));
        }
    }
}