﻿using System;
using System.Web.Optimization;

namespace Estimatorx.Web
{
    public class BundleConfig
    {
        public static void RegisterBundles(BundleCollection bundles)
        {
            bundles.Add(new StyleBundle("~/Content/css")
                .Include(
                    "~/Content/bootstrap.css",
                    "~/Content/font-awesome.css",

                    "~/Content/bootstrap-dialog.css",
                    "~/Content/bootstrap-social.css",

                    "~/Scripts/angular-ui-select/select.css",
                    "~/Content/select2.css",
                    "~/Content/select2-bootstrap.css",

                    "~/Content/site.css"
                )
            );

            bundles.Add(new ScriptBundle("~/bundles/modernizr")
                .Include(
                    "~/Scripts/modernizr-*"
                )
            );

            bundles.Add(new ScriptBundle("~/bundles/bootstrap")
                .Include(
                    "~/Scripts/jquery-{version}.js",
                    "~/Scripts/moment.js",
                    "~/Scripts/underscore.js",
                    "~/Scripts/ObjectId.js",
                    "~/Scripts/linq.js",
                    "~/Scripts/bootstrap.js",
                    "~/Scripts/bootstrap-dialog.js"
                )
            );

            bundles.Add(new ScriptBundle("~/bundles/jqueryval")
                .Include(
                    "~/Scripts/jquery.validate*"
                )
            );

            bundles.Add(new ScriptBundle("~/bundles/angular")
                .Include(
                    "~/Scripts/angular.js",
                    "~/Scripts/angular-animate.js",
                    "~/Scripts/angular-messages.js",
                    "~/Scripts/angular-resource.js",
                    "~/Scripts/angular-sanitize.js",
                    /* addon */
                    "~/Scripts/angular-moment.js",
                    "~/Scripts/ui-router/angular-ui-router.js",
                    "~/Scripts/angular-ui-select/select.js",
                    "~/Scripts/angular-ui/ui-bootstrap.js",
                    "~/Scripts/angular-ui/ui-bootstrap-tpls.js"
                )
            );


            bundles.Add(new ScriptBundle("~/bundles/estimator")
                .IncludeDirectory("~/app/common/", "*.js")

                .Include("~/app/app.js")
                
                .Include("~/app/base.js")

                .IncludeDirectory("~/app/services/", "*.js")
                .IncludeDirectory("~/app/filters/", "*.js")
                .IncludeDirectory("~/app/directives/", "*.js")

                .IncludeDirectory("~/app/organization/", "*.js")
                .IncludeDirectory("~/app/project/", "*.js")
                .IncludeDirectory("~/app/profile/", "*.js")
                .IncludeDirectory("~/app/template/", "*.js")
            );

#if !DEBUG
            BundleTable.EnableOptimizations = true;
#endif
        }
    }
}
