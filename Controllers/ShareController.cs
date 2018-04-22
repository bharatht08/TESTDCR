using Lshp.BaseWebApi.Data.Entity;
using Lshp.BaseWebApi.Service.Resources;
using Lshp.BaseWebApi.Service.ShareResources;
using Lshp.BaseWebApi.ViewModel;
using Microsoft.AspNetCore.Mvc;

namespace Lshp.BaseWebApi.Controllers
{
    /// <summary>
    /// ShareController
    /// </summary>
    [Route("api/[controller]")]

    public class ShareController:Controller
    {
        private readonly IShareResource _shareResource;
        /// <summary>
        /// ShareController
        /// </summary>
        public ShareController(IShareResource shareResource)
        {
            this._shareResource = shareResource;
        }
/// Added By Bharath
 public ShareController(IShareResource shareResource)
        {
            this._shareResource = shareResource;
        }
        /// <summary>
        ///  GetAccessableResources
        /// </summary>
        [HttpGet("GetSharedList")]
        public dynamic GetSharedList(int ResourceID)
        {
            return _shareResource.SharedList(ResourceID);
        } 

        /// <summary>
        ///  Bharah Reddy
        /// </summary>
        [HttpGet("GetSharedList")]
        public dynamic GetSharedList(int ResourceID)
        {
            return _shareResource.SharedList(ResourceID);
        }
    }
}