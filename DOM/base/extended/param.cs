﻿////////////////////////////////////////////////
// © https://github.com/badhitman - @fakegov
// Описание позаимствовано с сайтов http://htmlbook.ru
////////////////////////////////////////////////

namespace HtmlGenerator.DOM.extended
{
    /// <summary>
    /// Тег [param] предназначен для передачи значений параметров Java-апплетам или объектам веб-страницы, созданным с помощью тегов [applet] или [object].
    /// Такой подход позволяет прямо в коде HTML-документа изменять характеристики апплета без его дополнительной компиляции.
    /// Количество одновременно используемых тегов [param] может быть больше одного и для каждого из них задается пара «имя/значение» через атрибуты [name] и [value].
    /// 
    /// Апплетом называется программа, которая выполняется в составе браузера или под управлением специальной программы для ее просмотра.Апплет, как правило, пишется на языке Java, поэтому часто можно встретить сочетание «Java-апплет». 
    /// </summary>
    public class param : html_dom_root
    {
        /// <summary>
        /// Задает значение. Этот атрибут не является обязательным, поскольку для апплета или объекта вполне может быть достаточно одного имени, задаваемым атрибутом name.
        /// </summary>
        public string value;
    }
}
