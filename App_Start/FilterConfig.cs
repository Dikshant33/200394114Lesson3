﻿using System.Web;
using System.Web.Mvc;

namespace _200394114Lesson3
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
