using System.Web.Optimization;

//[assembly: WebActivatorEx.PostApplicationStartMethod(
//typeof($rootnamespace$.HighCharteronfig), "RegisterBundles")]

namespace AI.HighCharter.Web
{
    public static class HighCharterConfig
    {
        public static void RegisterBundles()
        {
            var bundles = BundleTable.Bundles;
            bundles.Add(new ScriptBundle("~/bundles/highcharter").Include(
                "~/scripts/highcharter/highcharts-debug/*.js",
                "~/scripts/highcharter/utilities/*.js",
                "~/scripts/highcharter/graphs/*.js"
                            ));

            var bundleOrder = new BundleFileSetOrdering("HighcharterBundleOrder");
            bundleOrder.Files.Add("highcharts*");
            bundleOrder.Files.Add("exporting*");
            bundleOrder.Files.Add("namespace*");
            bundleOrder.Files.Add("utilities.*");
            bundleOrder.Files.Add("graphs.*");

            BundleTable.Bundles.FileSetOrderList.Add(bundleOrder);
        }
    }
}