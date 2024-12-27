/* ------------------------------------------------------------------------------
<auto-generated>
    This file was generated by Sitefinity CLI v1.1.0.31
</auto-generated>
------------------------------------------------------------------------------ */

using ValueMomentumCMS.Mvc.Models;
using System.Web.Mvc;
using Telerik.Sitefinity.Mvc;
using Telerik.Sitefinity.Personalization;
using System;

namespace ValueMomentumCMS.Mvc.Controllers
{
	[ControllerToolboxItem(Name = "HelloWorld", Title = "Hello World 2", SectionName = "Value Momentum 2")]
	public class HelloWorldController : Controller, IPersonalizable
	{
		// GET: HelloWorld
		public ActionResult Index()
		{
			var model = new HelloWorldModel();
			model.Message = this.Message;
			return View(model);
		}
		
        protected override void HandleUnknownAction(string actionName)
        {
            this.ActionInvoker.InvokeAction(this.ControllerContext, "Index");
        }

        public string Message { get; set; }
        public bool Flag { get; set; }
        public Enumeration Enum { get; set; }
        public int Number { get; set; }
        public DateTime MyDate { get; set; }
    }
}