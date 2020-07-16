using System.Web.Optimization;

namespace STOHANZ
{
    public class BundleConfig
    {
        public static void RegisterBundles(BundleCollection bundles)
        {
            bundles.Add(new ScriptBundle("~/bundles/validation").Include("~/Scripts/jquery-{version}.js", "~/Scripts/jquery.validate.js", "~/Scripts/jquery.validate.unobtrusive.js"));
        }
    }
}