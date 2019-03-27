﻿////////////////////////////////////////////////
// © https://github.com/badhitman - @fakegov
// Описание HTML объектов позаимствовано с сайта http://htmlbook.ru
////////////////////////////////////////////////

namespace HtmlGenerator.dom.text
{
    /// <summary>
    /// Тег [span] предназначен для определения строчных элементов документа. В отличие от блочных элементов, таких как [table], [p] или [div],
    /// с помощью тега [span] можно выделить часть информации внутри других тегов и установить для нее свой стиль. Например,
    /// внутри абзаца (тега [p]) можно изменить цвет и размер первой буквы, если добавить начальный и конечный тег [span] и определить для него
    /// стиль текста. Чтобы не описывать каждый раз стиль внутри тега, можно выделить стиль во внешнюю таблицу стилей, а для тега добавить атрибут [class]
    /// или [id] с именем селектора.
    /// </summary>
    public class span : basic_html_dom
    {
        public span(string inner_text = null)
        {
            if (!string.IsNullOrEmpty(inner_text))
                InnerText = inner_text;
        }
    }
}
