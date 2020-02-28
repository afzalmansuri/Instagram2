using Microsoft.AspNetCore.Mvc;
using System.Linq;
using InstagramProjects.UnitOfWork.Main;
using InstagramProjects.Models.Main;
using RxWeb.Core.AspNetCore;
using RxWeb.Core.Security.Authorization;

namespace InstagramProjects.Api.Controllers.InstaUserModule
{
    [ApiController]
    [Route("api/[controller]")]
	
	public class CountryLookupsController : BaseLookupController

    {
        public CountryLookupsController(IInstaUserUow uow):base(uow) {}

        #region Lookups
        		[HttpGet("CountryLookups")]
		public IQueryable<vCountryLookup> GetCountryLookups()
		{
			return Uow.Repository<vCountryLookup>().Queryable();
		}
            #endregion Lookups

    }
}
