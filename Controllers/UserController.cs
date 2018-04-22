using Lshp.BaseWebApi.Data.Entity;
using Lshp.BaseWebApi.Service.User;
using Lshp.BaseWebApi.ViewModel;
using Microsoft.AspNetCore.Mvc;
namespace Lshp.BaseWebApi.Controllers
{
    /// <summary>
    /// ShareController
    /// </summary>
    public class UserController:Controller
    {
        private readonly IUser _iuser;
        /// <summary>
        /// Constructor
        /// </summary>
        public UserController(IUser iuser)
        {
            this._iuser = iuser;
        }

        /// <summary>
        /// GetEmailbyKey will get emails based on key input
        /// </summary>
        [HttpGet("GetEmails")]
        public dynamic GetEmailbyKey(string key)
        {
            return _iuser.GetEmailsbyKey(key);
        }
    }
}