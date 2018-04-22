using System;
using Lshp.BaseWebApi.Service.Logger;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Logging;

namespace Lshp.BaseWebApi.Extensions
{
    /// <summary>
    /// Extension for the logger
    /// </summary>
    public static class SQLLoggerFactoryExtensions
    {
        /// <summary>
        /// AddCustomlogger with logger factory
        /// </summary>
        /// <param name="factory"></param>
        /// <param name="serviceProvider"></param>
        /// <param name="contextAccessor"></param>
        /// <returns></returns>
        public static ILoggerFactory AddCustomLogger(this ILoggerFactory factory, IServiceProvider serviceProvider, IHttpContextAccessor contextAccessor)
        {
            return AddCustomLogger(factory, LogLevel.Information, serviceProvider, contextAccessor);
        }

        /// <summary>
        /// AddCustomLogger and intialize SQLLoggerProvider
        /// </summary>
        /// <param name="factory"></param>
        /// <param name="filter"></param>
        /// <param name="serviceProvider"></param>
        /// <param name="contextAccessor"></param>
        /// <returns></returns>
        public static ILoggerFactory AddCustomLogger(this ILoggerFactory factory, Func<string, LogLevel, bool> filter, IServiceProvider serviceProvider, IHttpContextAccessor contextAccessor)
        {
            factory.AddProvider(new SQLLoggerProvider(filter, serviceProvider, contextAccessor));
            return factory;
        }

        /// <summary>
        /// AddCustomLogger with the default log levels
        /// </summary>
        /// <param name="factory"></param>
        /// <param name="minLevel"></param>
        /// <param name="serviceProvider"></param>
        /// <param name="contextAccessor"></param>
        /// <returns></returns>
        public static ILoggerFactory AddCustomLogger(this ILoggerFactory factory, LogLevel minLevel, IServiceProvider serviceProvider, IHttpContextAccessor contextAccessor)
        {
            // The underscore is a convention used to name a variable which is required but not used
            return AddCustomLogger(factory, (_, logLevel) => logLevel >= minLevel, serviceProvider, contextAccessor);
        }
    }
}