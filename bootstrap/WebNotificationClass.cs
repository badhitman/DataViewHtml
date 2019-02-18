﻿////////////////////////////////////////////////
// © https://github.com/badhitman 
////////////////////////////////////////////////
using DataViewHtml.dom;

namespace DataViewHtml.bootstrap
{
    /// <summary>
    /// Статусы уведомлений
    /// </summary>
    public enum StatusNote
    {
        /// <summary>
        /// Простое (серый цвет)
        /// </summary>
        Dark,
        /// <summary>
        /// Первоочередное
        /// </summary>
        Primary,
        /// <summary>
        /// Информирование
        /// </summary>
        Info,
        /// <summary>
        /// Опасно
        /// </summary>
        Danger,
        /// <summary>
        /// Внимание
        /// </summary>
        Warning,
        /// <summary>
        /// Успешно
        /// </summary>
        Success
    }

    /// <summary>
    /// Класс Web/DOM уведомления для пользователя.
    /// </summary>
    public class WebNotificationClass
    {
        //
        public StatusNote CurrStatus;
        public string Message;
        public WebNotificationClass(StatusNote s, string msg)
        {
            CurrStatus = s;
            Message = msg;
        }

        public div GetDOM()
        {
            div div = new div();
            div.css_class = "alert alert-" + CurrStatus.ToString("G").ToLower() + " alert-dismissible fade show";
            div.css_style = "min-height: 50px;";
            div.CustomAtributes.Add("role", "alert");

            button button_close = new button(null) { css_class = "close" };
            button_close.CustomAtributes.Add("data-dismiss", "alert");
            button_close.CustomAtributes.Add("aria-label", "Close");

            span my_span = new span("&times;");
            my_span.SetAtribute("aria-hidden", "true");
            button_close.Childs.Add(my_span);

            div.inner_html = Message;
            div.Childs.Add(button_close);

            return div;
        }
    }
}
