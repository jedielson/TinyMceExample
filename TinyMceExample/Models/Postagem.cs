namespace TinyMceExample.Models
{
    using System.Web.Mvc;

    public class Postagem
    {
        [AllowHtml]
        public string HtmlContent { get; set; }
    }
}