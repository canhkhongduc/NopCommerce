using Nop.Web.Framework.Controllers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Nop.Services.Payments;
using System.Web.Mvc;

namespace Nop.Plugin.Payments.BaoKim.Controllers
{
    public class PaymentBaoKimController : BasePaymentController
    {
        // Redirect request to appropriate view
        public ActionResult Configure()
        {
            return View("~/Plugins/Payments.BaoKim/Views/Configure.cshtml");
        }

        public override ProcessPaymentRequest GetPaymentInfo(FormCollection form)
        {
            throw new NotImplementedException();
        }

        public override IList<string> ValidatePaymentForm(FormCollection form)
        {
            throw new NotImplementedException();
        }
    }
}
