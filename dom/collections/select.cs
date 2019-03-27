﻿////////////////////////////////////////////////
// © https://github.com/badhitman - @fakegov
// Описание HTML объектов позаимствовано с сайта http://htmlbook.ru
////////////////////////////////////////////////
using System.Collections.Generic;

namespace HtmlGenerator.dom.collections
{
    /// <summary>
    /// Тег [select] позволяет создать элемент интерфейса в виде раскрывающегося списка, а также список с одним или множественным выбором.
    /// Конечный вид зависит от использования атрибута [size] тега [select], который устанавливает высоту списка.
    /// Ширина списка определяется самым широким текстом, указанным в теге [option], а также может изменяться с помощью стилей.
    /// Каждый пункт создается с помощью тега [option], который должен быть вложен в контейнер [select].
    /// Если планируется отправлять данные списка на сервер, то требуется поместить элемент [select] внутрь формы.
    /// Это также необходимо, когда к данным списка идет обращение через скрипты.
    /// </summary>
    public class select : basic_html_dom
    {
        /// <summary>
        /// Атрибут [autofocus] устанавливает, что список получает фокус после загрузки страницы, при этом список становится доступным для выбора пунктов, например, с помощью клавиатуры.
        /// </summary>
        public bool autofocus = false;

        /// <summary>
        /// Блокирует доступ и изменение элементов списка. Блокированный список не может получить фокус через курсор или клавиатуру, быть изменен, значение такого списка не передается на сервер.
        /// </summary>
        public bool disabled = false;

        /// <summary>
        /// Связывает список с формой по её идентификатору. Такая связь необходима в случае, когда список располагается за пределами [form].
        /// </summary>
        public string form;

        /// <summary>
        /// Наличие атрибута [multiple] сообщает браузеру отображать содержимое элемента [select] как список множественного выбора.
        /// Конечный вид списка зависит от используемого атрибута [size] и браузера. При size="1" Firefox устанавливает высоту списка равной одному пункту,
        /// Safari и Chrome игнорируют [size], Opera превращает список в «крутилку».
        /// Для выбора нескольких значений списка применяются клавиши Ctrl и Shift совместно с курсором мыши.
        /// </summary>
        public bool multiple = false;

        /// <summary>
        /// Устанавливает список обязательным для выбора перед отправкой формы на сервер. Если пункт списка не выбран, браузер выведет сообщение,
        /// а форма отправлена не будет. Вид и содержание сообщения зависит от браузера и меняться пользователем не может.
        /// </summary>
        public bool required = false;

        /// <summary>
        /// Устанавливает высоту списка. Если значение атрибута size равно единице, то список превращается в раскрывающийся.
        /// При добавлении атрибута [multiple] к тегу [select] при size="1" список отображается как «крутилка». Во всех остальных
        /// случаях получается список с одним или множественным выбором.
        /// </summary>
        public int size = 0;

        /// <summary>
        /// Вложеные элементы списка
        /// </summary>
        public List<option> Options = new List<option>();

        public override string HTML(int deep = 0)
        {
            if (autofocus)
                SetAtribute("autofocus", null);

            if (disabled)
                SetAtribute("disabled", null);

            if (multiple)
                SetAtribute("multiple", null);

            if (required)
                SetAtribute("required", null);

            if (size > 0)
                SetAtribute("size", size.ToString());

            return base.HTML(deep);
        }
    }
}
