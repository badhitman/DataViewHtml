﻿////////////////////////////////////////////////
// © https://github.com/badhitman - @fakegov
// Описание HTML объектов позаимствовано с сайта http://htmlbook.ru
////////////////////////////////////////////////

namespace HtmlGenerator.dom
{
    /// <summary>
    ///  Тег [img] предназначен для отображения на веб-странице изображений в графическом формате GIF, JPEG или PNG. Адрес файла с картинкой задаётся через атрибут [src].
    ///  Если необходимо, то рисунок можно сделать ссылкой на другой файл, поместив тег [img] в контейнер [a].
    ///  При этом вокруг изображения отображается рамка, которую можно убрать, добавив атрибут [border="0"] в тег [img].
    ///  
    ///  Рисунки также могут применяться в качестве карт-изображений, когда картинка содержит активные области, выступающие в качестве ссылок.
    ///  Такая карта по внешнему виду ничем не отличается от обычного изображения, но при этом оно может быть разбито на невидимые зоны разной формы, где каждая из областей служит ссылкой. 
    /// </summary>
    public class img : basic_html_dom
    {
        /// <summary>
        /// Путь к графическому файлу. 
        /// </summary>
        public string src = null;

        /// <summary>
        /// Альтернативный текст для изображения. 
        /// </summary>
        public string alt = null;

        public img()
        {
            inline = true;
            need_end_tag = false;
        }

        public override string HTML(int deep = 0)
        {
            Childs.Clear();

            if (!string.IsNullOrEmpty(src))
                SetAtribute("src", src);

            if (!string.IsNullOrEmpty(alt))
                SetAtribute("alt", alt);

            return base.HTML(deep);
        }
    }
}
