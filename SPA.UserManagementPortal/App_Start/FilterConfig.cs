﻿using System.Web;
using System.Web.Mvc;

namespace SPA.UserManagementPortal
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
