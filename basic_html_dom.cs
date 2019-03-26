﻿////////////////////////////////////////////////
// © https://github.com/badhitman - @fakegov
////////////////////////////////////////////////
using HtmlGenerator.dom;
using HtmlGenerator.dom.text;
using HtmlGenerator.set;
using System;
using System.Collections.Generic;

namespace HtmlGenerator
{
    /// <summary>
    /// События HTML.DOM
    /// </summary>
    public enum UniversalEvents
    {
        /// <summary>
        /// Потеря фокуса.
        /// </summary>
        onblur,

        /// <summary>
        /// Изменение значения элемента формы.
        /// </summary>
        onchange,

        /// <summary>
        /// Щелчок левой кнопкой мыши на элементе.
        /// </summary>
        onclick,

        /// <summary>
        /// Двойной щелчок левой кнопкой мыши на элементе.
        /// </summary>
        ondblclick,

        /// <summary>
        /// Получение фокуса
        /// </summary>
        onfocus,

        /// <summary>
        /// Клавиша нажата, но не отпущена.
        /// </summary>
        onkeydown,

        /// <summary>
        /// Клавиша нажата и отпущена.
        /// </summary>
        onkeypress,

        /// <summary>
        /// Клавиша отпущена.
        /// </summary>
        onkeyup,

        /// <summary>
        /// Документ загружен.
        /// </summary>
        onload,

        /// <summary>
        /// Нажата левая кнопка мыши.
        /// </summary>
        onmousedown,

        /// <summary>
        /// Перемещение курсора мыши.
        /// </summary>
        onmousemove,

        /// <summary>
        /// Курсор покидает элемент.
        /// </summary>
        onmouseout,

        /// <summary>
        /// Курсор наводится на элемент.
        /// </summary>
        onmouseover,

        /// <summary>
        /// Левая кнопка мыши отпущена.
        /// </summary>
        onmouseup,

        /// <summary>
        /// Форма очищена.
        /// </summary>
        onreset,

        /// <summary>
        /// Выделен текст в поле формы.
        /// </summary>
        onselect,

        /// <summary>
        /// Форма отправлена.
        /// </summary>
        onsubmit,

        /// <summary>
        /// Закрытие окна.
        /// </summary>
        onunload
    }

    public abstract class basic_html_dom
    {
        /// <summary>
        /// Ручное указание имени/типа элемента/тэга
        /// По умолчанию имя/тип определяется по имени типа класса, но в случае необходимости его можно изменить на собственный
        /// </summary>
        public string set_custom_name_tag = null;

        /// <summary>
        /// Дочерние/вложеные элементы
        /// </summary>
        public List<basic_html_dom> Childs = new List<basic_html_dom>();

        /// <summary>
        /// Пользовательские атрибуты текущего HTML элемента
        /// </summary>
        public Dictionary<string, string> CustomAtributes { get; private set; } = new Dictionary<string, string>();

        /// <summary>
        /// Идентификатор/ID элемента в DOM
        /// </summary>
        public string Id_DOM = "";

        /// <summary>
        /// Имя/Name элемента в DOM
        /// </summary>
        public string Name_DOM = "";

        /// <summary>
        /// Позволяет получить доступ к элементу с помощью заданного сочетания клавиш. Браузеры при этом используют различные комбинации клавиш.
        /// </summary>
        public string accesskey = null;

        /// <summary>
        /// Определяет имя класса, которое позволяет связать тег со стилевым оформлением.
        /// </summary>
        public string css_class = "";

        /// <summary>
        /// Определяет "style" непосредственно для элемента
        /// </summary>
        public string css_style = "";

        /// <summary>
        /// Сообщает, что элемент доступен для редактирования пользователем — можно удалять текст и вводить новый.
        /// Также работают стандартные команды вроде отмены, вставки текста из буфера и др.
        /// </summary>
        public bool contenteditable = false;

        /// <summary>
        /// Скрывает содержимое элемента от просмотра. Такой элемент не отображается на странице, но доступен через скрипты
        /// </summary>
        public bool hidden = false;

        /// <summary>
        /// Устанавливает порядок получения фокуса при переходе между элементами с помощью клавиши Tab.
        /// В случае значения по умолчанию 0 - атрибут не выводится вовсе
        /// </summary>
        public int tabindex = 0;

        /// <summary>
        /// Текст HTML подсказки/tooltip
        /// </summary>
        public string Tooltip = "";

        /// <summary>
        /// HTML Комментирование блока/элемента. Оборачивает текущий блок в два коментария (в самом начале и самом конце DOM блока).
        /// Если указать только начальный/верхний коментарий, то он же будет использоваться и в нижнем.
        /// </summary>
        public string prew_block_coment = "";
        public string post_block_coment = "";

        /// <summary>
        /// Произвольный html текст внутри DOM блока/элемента
        /// </summary>
        public string InnerText = "";

        /// <summary>
        /// Флаг/метка необходимости формировать HTML для элемента в одну строку
        /// </summary>
        public bool inline = false;

        /// <summary>
        /// Флаг/метка необходимости парного/закрывающего тега для элемента
        /// </summary>
        public bool need_end_tag = true;

        /// <summary>
        /// HtmlController -> HTML (text)
        /// </summary>
        /// <param name="deep">Глубина вложености html блока/элемента (для отступов/табуляторов)</param>
        /// <returns>Возвращает готовый html</returns>
        public virtual string HTML(int deep = 0)
        {
            /////////////////////////////////////////////
            // Вычещаем недопустимый текст из коментария  
            prew_block_coment = prew_block_coment.Replace("<", "[").Replace(">", "]");
            post_block_coment = post_block_coment.Replace("<", "[").Replace(">", "]");

            string ret_val = "";

            if (!string.IsNullOrEmpty(prew_block_coment))
                ret_val += GetTabPrefix("\t", deep) + "<!-- " + prew_block_coment + " -->";

            ret_val += GetTabPrefix("\t", deep);
            if (!(this is text))
                ret_val += "<" + (string.IsNullOrEmpty(set_custom_name_tag) ? GetType().Name.ToLower() : set_custom_name_tag);

            if (!string.IsNullOrEmpty(Id_DOM))
                SetAtribute("id", Id_DOM);

            if (!string.IsNullOrEmpty(Name_DOM))
                SetAtribute("name", Name_DOM);

            if (!string.IsNullOrEmpty(Tooltip))
                SetAtribute("title", Tooltip);

            if (!string.IsNullOrEmpty(css_class?.Trim()))
                SetAtribute("class", css_class.Trim());

            if (!string.IsNullOrEmpty(css_style))
                SetAtribute("style", css_style);

            if (!string.IsNullOrEmpty(accesskey))
                SetAtribute("accesskey", accesskey);

            if (contenteditable)
                SetAtribute("contenteditable", null);

            if (hidden)
                SetAtribute("hidden", null);

            if (tabindex != 0)
                SetAtribute("tabindex", tabindex.ToString());

            foreach (KeyValuePair<string, string> kvp in CustomAtributes)
                if (!string.IsNullOrEmpty(kvp.Key))
                    ret_val += " " + kvp.Key + (kvp.Value is null ? "" : "=\"" + kvp.Value + "\"");

            if (!need_end_tag && !(this is text))
                ret_val += " />";
            else if (this is text)
            {
                // * * *
            }
            else
                ret_val += ">";

            if (!(this is text))
                foreach (basic_html_dom h in Childs)
                    ret_val += h.HTML(deep + 1);

            if (!string.IsNullOrEmpty(InnerText))
                ret_val += (inline ? "" : GetTabPrefix("\t", deep)) + InnerText;

            if (need_end_tag && !(this is text))
                ret_val += (inline ? "" : GetTabPrefix("\t", deep)) + "</" + (string.IsNullOrEmpty(set_custom_name_tag) ? this.GetType().Name.ToLower() : set_custom_name_tag) + ">";

            post_block_coment = post_block_coment.Replace("<", "[").Replace(">", "]");

            if (!string.IsNullOrEmpty(post_block_coment))
                ret_val += GetTabPrefix("\t", deep) + "<!-- " + post_block_coment + " /-->";
            else if (!string.IsNullOrEmpty(prew_block_coment))
                ret_val += GetTabPrefix("\t", deep) + "<!-- " + prew_block_coment + " /-->";
            return ret_val;
        }

        /// <summary>
        /// Получить префикс/отступ/табулятор
        /// </summary>
        /// <param name="stamp">Символ из которого образуется префикс/отступ/табулятор</param>
        /// <param name="count">Длина префикса/отступа/табулятора</param>
        /// <param name="new_line">Требуется ли в начале перевод строки</param>
        /// <returns></returns>
        string GetTabPrefix(string stamp, int count, bool new_line = true)
        {
            string tmpl = stamp;
            stamp = "";
            for (int i = 0; i < count; i++)
                stamp += tmpl;
            return (new_line ? Environment.NewLine : "") + stamp;
        }

        /// <summary>
        /// Установить или добавить атрибут.
        /// </summary>
        /// <param name="attr_name">Имя атрибута dom объекта</param>
        /// <param name="attr_value">Если знаение атрибута IS NULL, то генератор объявит имя атрибута у объекта, но не будет указывать значение этого атрибута (т.е. будет пропущен знак = и его значение)</param>
        public void SetAtribute(string attr_name, string attr_value)
        {
            if (!CustomAtributes.ContainsKey(attr_name))
                CustomAtributes.Add(attr_name, attr_value);
            else
                CustomAtributes[attr_name] = attr_value;
        }

        /// <summary>
        /// Пакетная установка атрибутов
        /// </summary>
        public void SetAtribute(Dictionary<string, string> in_custom_atributes)
        {
            foreach (KeyValuePair<string, string> kvp in in_custom_atributes)
                SetAtribute(kvp.Key, kvp.Value);
        }

        /// <summary>
        /// Получить значение атрибута
        /// </summary>
        public string GetAtribute(string attr_name)
        {
            if (CustomAtributes.ContainsKey(attr_name))
                return CustomAtributes[attr_name];

            return null;
        }

        /// <summary>
        /// Удалить атрибу (если существует)
        /// </summary>
        public void RemoveAtribute(string attr_name)
        {
            if (CustomAtributes.ContainsKey(attr_name))
                CustomAtributes.Remove(attr_name);
        }

        /// <summary>
        /// Установить DOM элементу обработчик события.
        /// Если "event_src" IsNullOrEmpty, то событие удаляется
        /// </summary>
        public void SetEvent(UniversalEvents my_event, string event_src)
        {
            if (string.IsNullOrEmpty(event_src))
                if (CustomAtributes.ContainsKey(my_event.ToString("g")))
                    CustomAtributes.Remove(my_event.ToString("g"));
                else
                    SetAtribute(my_event.ToString("g"), event_src);
        }

        /// <summary>
        /// Получить в виде строки тип кодирования отпарвляемых данных HTML формы
        /// </summary>
        public static string GetEnctypeHtmlForm(EncTypesEnum EncType)
        {
            switch (EncType)
            {
                // Данные не кодируются. Это значение применяется при отправке файлов.
                case EncTypesEnum.MultipartFormData:
                    return "multipart/form-data";
                // Пробелы заменяются знаком +, буквы и другие символы не кодируются.
                case EncTypesEnum.Plain:
                    return "text/plain";
                // EncTypes.WwwFormUrlEncoded: Вместо пробелов ставится +, символы вроде русских букв кодируются их шестнадцатеричными значениями (например, %D0%9F%D0%B5%D1%82%D1%8F вместо Петя).
                default:
                    return "application/x-www-form-urlencoded";
            }
        }
    }
}
