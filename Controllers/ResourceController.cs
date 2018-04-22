using Lshp.BaseWebApi.Data.Entity;
using Lshp.BaseWebApi.Service.Resources;
using Lshp.BaseWebApi.ViewModel;
using Microsoft.AspNetCore.Mvc;

namespace Lshp.BaseWebApi.Controllers
{
    /// <summary>
    /// ResourceController
    /// </summary>
    [Route("api/[controller]")]
    public class ResourceController:Controller
    {
        private readonly IResource _resource;
        /// <summary>
        ///  Constructor
        /// </summary>
        public ResourceController(IResource resource)
        {
            this._resource=resource;
        }

        /// <summary>
        ///  GetAccessableResources
        /// </summary>
        [HttpGet("GetAccessableResources")]
        public dynamic GetAccessableResources(int UserID)
        {
            return _resource.GetTTTMyAccessableResources(UserID);
        } 
		
		/// <summary>
        ///  GetAccessableResourcesDATA12
        /// </summary>
        [HttpGet("GetAccessableResources")]
        public dynamic GetAccessableResourcesDATA12(int UserID)
        {
            return _resource.GetMyAccessableResourcesDATA12(UserID);
        } 
		
		// Bharath Reddy Testing MyResources
        /// <summary>
        ///  GetAccessableResources
        /// </summary>
        [HttpGet("GetAccessableResources")]
        public dynamic GetAccessableResourcesDATA(int UserID)
        {
            return _resource.GetMyAccessableResourcesDATA(UserID);
        } 

        /// <summary>
        ///  It'll get Resource details based on it's ID
        /// </summary>
        [HttpGet("GetResourceDetails")]
        public ResourceView GetResourceDetails(int ResourceID)
        {
            return _resource.GetResource(ResourceID);
        }

        
        /// <summary>
        ///  Update
        /// </summary>
        [HttpPut]
        public ResourceView Update([FromBody]ResourceView resourceView,int ResourceID)
        {
            return _resource.UpdateResource(resourceView,ResourceID);
        }

        /// <summary>
        ///  Deleting a Resource
        /// </summary>
        [HttpDelete]
        public int DeleteResource(int ResourceID)
        {
            return _resource.DeleteResource(ResourceID);
        }

        /// <summary>
        ///  gets MyOwnedResources
        /// </summary>        
        [HttpGet("MyOwnedResources")]
        public dynamic MyOwnedResources(int OwnerID)
        {
            return _resource.GetMyOwnResources(OwnerID);
        }
    }
}