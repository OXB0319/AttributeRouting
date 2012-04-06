﻿using System.Web.Http;
using System.Web.Http.Controllers;
using System.Web.Http.WebHost;
using AttributeRouting.Web;

namespace AttributeRouting.Http.WebHost {
    public class HttpAttributeRoutingConfiguration : AspNetAttributeRoutingConfiguration<IHttpController, RouteParameter>
    {
        public HttpAttributeRoutingConfiguration()
            : base(() => HttpControllerRouteHandler.Instance)
        {
        }
    }
}
