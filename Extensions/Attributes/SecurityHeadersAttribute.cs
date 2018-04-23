﻿using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;

namespace Lshp.BaseWebApi.Extensions.Attributes
{
    /// <summary>
    /// SecurityHeadersAttribute
    /// </summary>
	
	 //   var csp = "default-src  'self' 'unsafe-inline';";
                // an example if you need client images to be displayed from twitter
                //var csp = "default-src 'self'; img-src 'self' https://url.com";
    public class SecurityHeadersAttribute : ActionFilterAttribute
    {
        /// <summary>
        /// Check and include the required headers for the view
        /// </summary>
        /// <param name="context"></param>
        public override void OnResultExecuting(ResultExecutingContext context)
        {
            var result = context.Result;
            if (result is ViewResult)
            {
                if (!context.HttpContext.Response.Headers.ContainsKey("X-Content-Type-Options"))
                {
                    context.HttpContext.Response.Headers.Add("X-Content-Type-Options", "nosniff");
                }
                if (!context.HttpContext.Response.Headers.ContainsKey("X-Frame-Options"))
                {
                    context.HttpContext.Response.Headers.Add("X-Frame-Options", "SAMEORIGIN");
                }

             //   var csp = "default-src  'self' 'unsafe-inline';";
                // an example if you need client images to be displayed from twitter
                //var csp = "default-src 'self'; img-src 'self' https://url.com";

                // once for standards compliant browsers
                //if (!context.HttpContext.Response.Headers.ContainsKey("Content-Security-Policy"))
                //{
                //    context.HttpContext.Response.Headers.Add("Content-Security-Policy", csp);
                //}
                // and once again for IE
                //if (!context.HttpContext.Response.Headers.ContainsKey("X-Content-Security-Policy"))
                //{
                //    context.HttpContext.Response.Headers.Add("X-Content-Security-Policy", csp);
                //}
            }
        }
    }
}