﻿////////////////////////////////////////////////
// © https://github.com/badhitman
// Описание HTML объектов позаимствовано с сайта http://htmlbook.ru
////////////////////////////////////////////////
namespace DataViewHtml.dom
{
    /// <summary>
    /// Тег "ul" устанавливает маркированный список. Каждый элемент списка должен начинаться с тега "li".
    /// Если к тегу "ul" применяется таблица стилей, то элементы "li" наследуют эти свойства.
    /// </summary>
    public class ul : basic_html_dom
    {
        /// <summary>
        /// Устанавливает вид маркера.
        /// </summary>
        public enum TypesUL
        {
            disc,
            circle,
            square
        }

        public TypesUL TypeUL = TypesUL.disc;

        public ul(TypesUL in_TypeUL = TypesUL.disc)
        {
            TypeUL = in_TypeUL;
        }

        public override string HTML(int deep = 0)
        {
            SetAtribute("type", TypeUL.ToString("g"));
            return base.HTML(deep);
        }

        public li GetLi(string value, string name, string desc)
        {
            li ret_val = new li();
            ret_val.Name_DOM = name;
            ret_val.title = desc;
            ret_val.SetAtribute("type", TypeUL.ToString("g"));
            ret_val.SetAtribute("value", value);
            return ret_val;
        }
    }
}
