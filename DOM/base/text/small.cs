﻿////////////////////////////////////////////////
// © https://github.com/badhitman - @fakegov
// Описание HTML объектов позаимствовано с сайта http://htmlbook.ru
////////////////////////////////////////////////

namespace HtmlGenerator.DOM.text
{
    /// <summary>
    /// Тег [small] уменьшает размер шрифта на единицу по сравнению с обычным текстом. В HTML размер шрифта измеряется в условных единицах от 1 до 7,
    /// средний размер текста, используемый по умолчанию, принят 3. Таким образом, добавление тега [small] уменьшает текст на одну условную единицу.
    /// Допускается применение вложенных тегов [small], при этом размер шрифта будет меньше с каждым вложенным уровнем, но не может быть меньше, чем 1.
    /// На размер шрифта влияет не только заданный атрибут [size] тега [font], но и выбор гарнитуры шрифта. Шрифт Arial выглядит крупнее, чем шрифт Times,
    /// а шрифт Verdana чуть больше шрифта Arial. Учитывайте эту особенность при выборе шрифта и его размеров.Для более точного управления размером текста 
    /// используйте стили.
    /// </summary>
    public class small : html_dom_root
    {
        public small(string in_text)
        {
            InnerText = in_text;
        }
    }
}
