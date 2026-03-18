#if NETCOREAPP
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
#else
using System.Web.Http;
using DotNetNuke.Web.Api;
#endif
using AppCode.LightSpeed;
using System.Collections.Generic;

namespace AppCode.Api
{
    [AllowAnonymous]
    public class LightSpeedExternalDataController : Custom.Hybrid.ApiTyped
    {
        [HttpGet]
        public ExternalDataSnapshot Current(string key = "default")
            => ExternalDataStore.Get(key);

        [HttpGet]
        public ExternalDataSnapshot Regenerate(string key = "default")
            => ExternalDataStore.Regenerate(key);

        [HttpGet]
        public IReadOnlyList<ExternalDataSnapshot> All()
            => ExternalDataStore.GetAll();
    }
}