﻿using Frapid.Dashboard.Extensions;
using System.Web.Mvc;

namespace MixERP.Sales.Extensions
{
    public static class PartialViewExtensions
    {
        public static MvcHtmlString PartialView(this HtmlHelper helper, string path, string tenant)
        {
            return helper.PartialView<AreaRegistration>(path, tenant);
        }

        public static MvcHtmlString PartialView(this HtmlHelper helper, string path, string tenant, object model)
        {
            return helper.PartialView<AreaRegistration>(path, tenant, model);
        }
    }
}