﻿////////////////////////////////////////////////
// © https://github.com/badhitman - @fakegov 
////////////////////////////////////////////////
using HtmlGenerator.dom;
using HtmlGenerator.dom.collections;
using System.Collections.Generic;

namespace HtmlGenerator.bootstrap
{
    public class Breadcrumb
    {
        public List<BreadcrumbItem> Breadcrumbs = new List<BreadcrumbItem>();
        public void AddBreadcrumb(string in_text, string in_href = null)
        {
            Breadcrumbs.Add(new BreadcrumbItem() { text = in_text, href = in_href });
        }

        public nav GetBreadcrumb
        {
            get
            {
                ol my_ol = new ol(ol.TypesOL.None) { css_class = "breadcrumb" };

                if (Breadcrumbs.Count == 0)
                    goto end;
                else
                    Breadcrumbs[Breadcrumbs.Count - 1].href = null;

                li my_li;
                foreach (BreadcrumbItem bi in Breadcrumbs)
                {
                    my_li = new li(null) { css_class = "breadcrumb-item" };
                    if (string.IsNullOrEmpty(bi.href))
                    {
                        my_li.css_class += " active";
                        my_li.SetAtribute("aria-current", "page");
                        my_li.InnerText = bi.text;
                    }
                    else
                        my_li.Childs.Add(new a() { href = bi.href, InnerText = bi.text });

                    my_ol.Childs.Add(my_li);
                }

                end:

                nav my_nav = new nav() { css_style = "margin-top: 3px;" };
                my_nav.CustomAtributes.Add("aria-label", "breadcrumb");
                my_nav.Childs.Add(my_ol);
                return my_nav;
            }
        }

        public class BreadcrumbItem
        {
            public string text;
            public string href;
        }
    }
}