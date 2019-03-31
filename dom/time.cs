﻿////////////////////////////////////////////////
// © https://github.com/badhitman - @fakegov
// Описание HTML объектов позаимствовано с сайта http://htmlbook.ru
////////////////////////////////////////////////
using System;

namespace HtmlGenerator.dom
{
    /// <summary>
    /// Помечает текст внутри тега [time] как дата, время или оба значения.
    /// Может указываться непосредственно внутри контейнера [time], либо задаваться через атрибут [datetime].
    /// </summary>
    public class time : basic_html_dom
    {
        /// <summary>
        /// Задает дату, время или оба значения для текста.
        /// Устанавливает дату, время или оба значения для текста. Содержимое атрибута напрямую в браузере не отображается.
        /// </summary>
        public DateTime datetime = DateTime.MinValue;

        public override string GetHTML(int deep = 0)
        {
            if (datetime > DateTime.MinValue)
                SetAtribute("datetime", datetime.ToString("yyyy-MM-dd HH:mm:ss"));

            return base.GetHTML(deep);
        }
    }
}