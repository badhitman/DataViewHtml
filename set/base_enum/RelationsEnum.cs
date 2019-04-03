﻿////////////////////////////////////////////////
// © https://github.com/badhitman - @fakegov
// Описание HTML объектов позаимствовано с сайта http://htmlbook.ru
////////////////////////////////////////////////

namespace HtmlGenerator.set
{
    /// <summary>
    /// Атрибут [rel] определяет отношения между текущим документом и документом, на который ведет ссылка, заданная атрибутом [href].
    /// Несмотря на то, что браузеры в большинстве своем не поддерживают атрибут [rel], на сайтах часто можно встретить код [rel="nofollow"], предназначенный для поисковых систем Google и Яндекс. Ссылки, помеченные таким образом, не передают PageRank и ТИЦ. 
    /// </summary>
    public enum RelationsEnum
    {
        /// <summary>
        /// Ссылка на файл, содержащий таблицу стилей (css) для текущего документа
        /// </summary>
        stylesheet,

        /// <summary>
        /// Ссылка на альтернативное представления текущего документа.
        /// </summary>
        alternate,

        /// <summary>
        /// Ссылка на архив сайта.
        /// </summary>
        archives,

        /// <summary>
        /// Импортирует значок для представления текущего документа.
        /// </summary>
        icon,

        /// <summary>
        /// Постоянная ссылка на раздел или запись. 
        /// </summary>
        bookmark,

        /// <summary>
        /// Ссылка на документ со справкой. 
        /// </summary>
        help,

        /// <summary>
        /// Ссылка на содержание. 
        /// </summary>
        index,

        /// <summary>
        /// Ссылка на страницу с лицензионным соглашением или авторскими правами.
        /// </summary>
        license,

        /// <summary>
        /// Ссылка на страницу об авторе на том же домене.
        /// </summary>
        author,

        /// <summary>
        /// Ссылка на страницу автора на другом домене. 
        /// </summary>
        me,

        /// <summary>
        /// Ссылка на заглавную страницу сайта
        /// </summary>
        home,

        /// <summary>
        /// Ссылка на первую страницу.
        /// </summary>
        first,

        /// <summary>
        /// Ссылка на предыдущую страницу или раздел. 
        /// </summary>
        prev,

        /// <summary>
        /// Ссылка на следующую страницу или раздел.
        /// </summary>
        next,

        /// <summary>
        /// Ссылка на последнюю страницу.
        /// </summary>
        last,

        /// <summary>
        /// Не передавать по ссылке ТИЦ и PR. 
        /// </summary>
        nofollow,

        /// <summary>
        /// Не передавать по ссылке HTTP-заголовки. 
        /// </summary>
        noreferrer,

        /// <summary>
        /// Указывает, что надо заранее кэшировать указанный ресурс. 
        /// </summary>
        prefetch,

        /// <summary>
        /// Ссылка на поиск. 
        /// </summary>
        search,

        /// <summary>
        /// Добавить ссылку в избранное браузера. 
        /// </summary>
        sidebar,

        /// <summary>
        /// Указывает, что метка (тег) имеет отношение к текущему документу. 
        /// </summary>
        tag,

        /// <summary>
        /// Ссылка на родительскую страницу. 
        /// </summary>
        up
    }
}
