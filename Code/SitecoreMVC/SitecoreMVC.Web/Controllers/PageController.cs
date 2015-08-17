using SitecoreMVC.Business.Metadata;
using SitecoreMVC.Business.Scripts;
using System.Web.Mvc;

namespace SitecoreMVC.Web.Controllers
{
    public class PageController : Controller
    {
        private readonly IMetadataLogic _metadataLogic;
        private readonly IScriptsLogic _scriptsLogic;
        private readonly ICanonicalLink _canonicalLink;

        public PageController(IMetadataLogic metadataLogic, IScriptsLogic scriptsLogic, ICanonicalLink canonicalLink)
        {
            _metadataLogic = metadataLogic;
            _scriptsLogic = scriptsLogic;
            _canonicalLink = canonicalLink;
        }

        public ActionResult GetMetadata()
        {
            return Content(_metadataLogic.GetMetatags());
        }

        public ActionResult GetHeaderScripts()
        {
            return Content(_scriptsLogic.GetHeaderScripts());
        }

        public ActionResult GetStartBodyScripts()
        {
            return Content(_scriptsLogic.GetStartBodyScripts());
        }

        public ActionResult GetEndBodyScripts()
        {
            return Content(_scriptsLogic.GetEndBodyScripts());
        }

        public ActionResult GetCanonicalLink()
        {
            return Content(_canonicalLink.GetCanonicalLink());
        }
    }
}