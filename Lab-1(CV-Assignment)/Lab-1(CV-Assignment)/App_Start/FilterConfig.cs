﻿using System.Web;
using System.Web.Mvc;

namespace Lab_1_CV_Assignment_
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
