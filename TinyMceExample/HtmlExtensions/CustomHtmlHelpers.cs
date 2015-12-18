namespace TinyMceExample.HtmlExtensions
{
    using System;
    using System.Collections.Generic;
    using System.Linq.Expressions;
    using System.Web.Mvc;
    using System.Web.Mvc.Html;

    public static class CustomHtmlHelpers
    {
        public static MvcHtmlString TinyMceTextArea<TModel, TProperty>(this HtmlHelper<TModel> helper,
            Expression<Func<TModel, TProperty>> expression)
        {
            var htmlAttributes = new Dictionary<string, object> { { "tiny-mce-editor", true }, {"id", "tinyTextBoxArea"} };
            return helper.TextAreaFor(expression, htmlAttributes);
        }

        public static MvcHtmlString TinyMceTextArea<TModel, TProperty>(this HtmlHelper<TModel> helper,
            Expression<Func<TModel, TProperty>> expression, 
            string idTextArea)
        {
            idTextArea = idTextArea.ValidId() ? "tinyTextBoxArea" : idTextArea;

            var htmlAttributes = new Dictionary<string, object> { { "tiny-mce-editor", true }, { "id", idTextArea } };
            return helper.TextAreaFor(expression, htmlAttributes);
        }

        public static MvcHtmlString TinyMceTextArea<TModel, TProperty>(this HtmlHelper<TModel> helper,
            Expression<Func<TModel, TProperty>> expression,
            string idTextArea,
            Dictionary<string, object> htmlAttributes)
        {
            idTextArea = idTextArea.ValidId() ? "tinyTextBoxArea" : idTextArea;

            if (htmlAttributes == null)
            {
                htmlAttributes = new Dictionary<string, object>();
            }

            htmlAttributes.Add("tiny-mce-editor", true);
            htmlAttributes.Add("id", idTextArea);
        
            return helper.TextAreaFor(expression, htmlAttributes);
        }

        private static bool ValidId(this string value)
        {
            return value?.Trim().Length > 0;
        }
    }
}