namespace Microsoft.AspNetCore.Mvc
{
    /// <summary>
    /// Extension for Url
    /// </summary>
    public static class UrlHelperExtensions
    {
        /// <summary>
        /// Send email confirmation link
        /// </summary>
        /// <param name="urlHelper"></param>
        /// <param name="userId"></param>
        /// <param name="code"></param>
        /// <param name="scheme"></param>
        /// <returns></returns>
        public static string EmailConfirmationLink(this IUrlHelper urlHelper, string userId, string code, string scheme)
        {
            ////return urlHelper.Action(
            ////    action: nameof(AccountController.ConfirmEmail),
            ////    controller: "Account",
            ////    values: new { userId, code },
            ////    protocol: scheme);
            return string.Empty;
        }
    }
}