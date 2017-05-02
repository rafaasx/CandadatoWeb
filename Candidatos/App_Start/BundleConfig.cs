using System.Web;
using System.Web.Optimization;

namespace Candidatos
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

            bundles.Add(new ScriptBundle("~/bundles/modernizr").Include(
                        "~/Scripts/modernizr-*"));

            bundles.Add(new ScriptBundle("~/bundles/bootstrap").Include(
                      "~/Scripts/bootstrap.js",
                      "~/Scripts/respond.js"));

            bundles.Add(new ScriptBundle("~/bundles/angular").Include(
                      "~/Scripts/angular.js",
                      "~/Scripts/angular-sanitize.js"));

            bundles.Add(new ScriptBundle("~/bundles/controllers").Include(
                                  "~/Scripts/app/App.js",
                                  "~/Scripts/app/HomeController.js"));

            bundles.Add(new ScriptBundle("~/bundles/bootstrap-star-rating").Include(
                                  "~/Scripts/star-rating.js",
                                  "~/Scripts/star-rating_locale_pt-br"));

            bundles.Add(new ScriptBundle("~/bundles/ui-bootstrap").Include(
                                  "~/Scripts/angular-ui/ui-bootstrap-tpls.js"));

            bundles.Add(new StyleBundle("~/Content/css").Include(
                      "~/Content/bootstrap.css",
                      "~/Content/site.css",
                      "~/Content/font-awesome.css",
                      "~/Content/star-rating.css"));
        }
    }
}
