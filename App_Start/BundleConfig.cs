using System.Web.Optimization;

namespace Odn.InvoiceScraping.Yamaha.Web
{
    public class BundleConfig
    {
        public static void RegisterBundles(BundleCollection bundles)
        {
            bundles.Add(new ScriptBundle("~/bundles/js").Include(
                        "~/Scripts/jquery-{version}.js",
                        "~/Scripts/bootstrap.min.js"));

            bundles.Add(new StyleBundle("~/Content/css").Include(
                      "~/Css/bootstrap.min.css",
                      "~/Css/site.css"));
        }
    }
}
