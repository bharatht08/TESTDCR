using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using Lshp.BaseWebApi.Data.Entity;
using Lshp.BaseWebApi.ViewModel; 

namespace Lshp.BaseWebApi.Mappings
{
    /// <summary>
    /// Map between viewmodel and entity
    /// </summary>
    public static class EntityViewModelMapping
    {
        /// <summary>
        /// Configure Automapper
        /// </summary>
        public static void IntializeMapping()
        { 
            Mapper.Initialize(mpg => {
                mpg.CreateMap<Users, UsersView>();
                mpg.CreateMap<ResourceView, Resource>();
                mpg.CreateMap<ShareResourceView,ShareResource>();
                });
            //Mapper.Initialize(mpg => {mpg.CreateMap<ResourceView, Resource>();});

        }

        ////#region client to ClientViewModel
        ////public static ClientViewModel EntityToViewModelModel(Client client)
        ////{
        ////    return AutoMapper.Mapper.Map<ClientViewModel>(client);
        ////}

        ////public static Client ViewModelModelToEntity(ClientViewModel clientViewModel)
        ////{
        ////    return AutoMapper.Mapper.Map<Client>(clientViewModel);
        ////}
        ////#endregion


        /// <summary>
        /// Bharath Map from Resource to ResourceViewModel
        /// </summary>
        #region Resource to ResourceViewModel
        public static ResourceView ResourceToResourceViewModel(Resource resource)
        {
           return AutoMapper.Mapper.Map<ResourceView>(resource);
        }
		
		/// <summary>
        /// NEW REP Bharath Map from Resource to ResourceViewModel
        /// </summary>
        #region Resource to ResourceViewModel
        public static ResourceView ResourceToResourceViewModel(Resource resource)
        {
           return BharatAutoMapper.Mapper.Map<ResourceView>(resource);
        }

        /// <summary>
        /// Map from Resource to ResourceViewModel
        /// </summary>
        #region Resource to ResourceViewModel
        public static ResourceView ResourceToResourceViewModel(Resource resource)
        {
           return AutoMapper.Mapper.Map<ResourceView>(resource);
        }

        /// <summary>
        /// Map from ResourceViewModel to Resource
        /// </summary>
        public static Resource ResourceViewModelToResource(ResourceView resourceView)
        {
           return AutoMapper.Mapper.Map<Resource>(resourceView);
        }
        #endregion

        /// <summary>
        /// Map from ShareResource to ShareResourceViewModel
        /// </summary>
        #region ShareResource to ShareResourceViewModel
        public static ShareResourceView ShareResourceToShareResourceViewModel(ShareResource shareResource)
        {
           return AutoMapper.Mapper.Map<ShareResourceView>(shareResource);
        }

        /// <summary>
        /// Map from ResourceViewModel to Resource
        /// </summary>
        public static ShareResource ShareResourceViewModelToShareResource(ShareResourceView shareResourceView)
        {
           return AutoMapper.Mapper.Map<ShareResource>(shareResourceView);
        }
        #endregion

    }
}
