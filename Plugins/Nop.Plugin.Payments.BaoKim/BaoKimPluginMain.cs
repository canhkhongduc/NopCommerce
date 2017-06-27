using Nop.Services.Payments;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Nop.Core.Domain.Orders;
using Nop.Core.Plugins;
using System.Web.Routing;
using Nop.Services.Common;

namespace Nop.Plugin.Payments.BaoKim
{
    public class BaoKimPluginMain : BasePlugin, IMiscPlugin
    {
        /// <summary>
        /// Gets a route for provider configuration
        /// </summary>
        /// <param name="actionName">Action name</param>
        /// <param name="controllerName">Controller name</param>
        /// <param name="routeValues">Route values</param>
        public void GetConfigurationRoute(out string actionName, out string controllerName, out RouteValueDictionary routeValues)
        {
            actionName = "Configure";
            controllerName = "PaymentBaoKimController";
            routeValues = new RouteValueDictionary { { "Namespaces", "Nop.Plugin.Payments.BaoKim.Controllers" }, { "area", null } };
        }
    }
}
