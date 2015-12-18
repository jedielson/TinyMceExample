using System.Web.Mvc;

namespace TinyMceExample.Controllers
{
    using System.Diagnostics;

    using TinyMceExample.Models;

    public class EditorController : Controller
    {
        // GET: Editor
        public ActionResult Index()
        {
            return View();
        }

        [ValidateAntiForgeryToken]
        public ActionResult Salvar(Postagem model)
        {
            Debug.Write(model.HtmlContent);
            return RedirectToAction(nameof(Index));
        }
    }
}