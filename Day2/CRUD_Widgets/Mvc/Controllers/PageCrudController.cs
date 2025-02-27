/* ------------------------------------------------------------------------------
<auto-generated>
    This file was generated by Sitefinity CLI v1.1.0.31
</auto-generated>
------------------------------------------------------------------------------ */

using ValueMomentumCMS.Mvc.Models;
using System.Web.Mvc;
using Telerik.Sitefinity.Mvc;
using Telerik.Sitefinity.Personalization;
using Telerik.Sitefinity.Modules.Pages;
using System.Linq;
using Telerik.Sitefinity.GenericContent.Model;

namespace ValueMomentumCMS.Mvc.Controllers
{
	[ControllerToolboxItem(Name = "PageCrud", Title = "Page Crud", SectionName = "ValueMomentum")]
	public class PageCrudController : Controller, IPersonalizable
	{
		// GET: PageCrud
		public ActionResult Index()
		{
			PageManager pm = PageManager.GetManager();
            var pages = pm.GetPageDataList().Where(p => p.Status == ContentLifecycleStatus.Live)
                                            .Select(p => p.NavigationNode)
                                            .Where(n => !n.IsBackend && !n.IsDeleted);
            var model = new PageCrudModel(pages);
			
			return View("Index", model);
		}
		
        protected override void HandleUnknownAction(string actionName)
        {
            this.ActionInvoker.InvokeAction(this.ControllerContext, "Index");
        }
	}
}