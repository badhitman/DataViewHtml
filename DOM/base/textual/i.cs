﻿////////////////////////////////////////////////
// © https://github.com/badhitman - @fakegov
// Описание HTML объектов позаимствовано с сайта http://htmlbook.ru
////////////////////////////////////////////////

namespace HtmlGenerator.DOM.textual
{
    /// <summary>
    /// Устанавливает курсивное начертание шрифта. Допустимо использовать этот тег совместно с другими тегами, которые определяют начертание текста.
    /// </summary>
    public class i : base_dom_root
    {
        public i(string inner_text)
        {
            InnerText = inner_text;
        }
    }
}