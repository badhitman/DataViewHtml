﻿////////////////////////////////////////////////
// https://github.com/badhitman 
////////////////////////////////////////////////

namespace HtmlGenerator.set.entities
{
    public class DataObjectItem : DataParticleItem
    {
        /// <summary>
        /// Подсказка для элемента
        /// </summary>
        public string Tooltip;

        /// <summary>
        /// Флаг того что элемент является группой
        /// </summary>
        public bool IsGroup;

        /// <summary>
        /// Флаг/признак, что элемент отключён
        /// </summary>
        public bool Disabled = false;

        /// <summary>
        /// Технический параметр для передачи дополнительных данных
        /// </summary>
        public string Tag = "";

    }
}
