﻿////////////////////////////////////////////////
// https://github.com/badhitman
////////////////////////////////////////////////

namespace HtmlGenerator.html5.textual
{
    public class text : base_dom_root
    {
        public text(string i_html_text)
        {
            inline = true;
            InnerText = i_html_text;
        }

        public override string GetHTML(int deep = 0)
        {
            ////////////////////////////
            // Вложеные элементы не предусмотрены
            Childs.Clear();
            return base.GetHTML(deep);
        }
    }
}
