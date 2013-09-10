using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
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
               "~/scripts/highcharts/*.js",
               "~/scripts/graphs/*.js",
               "~/scripts/utilities/*.js"
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