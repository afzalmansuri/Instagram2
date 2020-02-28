using System.Collections.Generic;
using Microsoft.Data.SqlClient;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using RxWeb.Core.Security;
using RxWeb.Core.Data;
using InstagramProjects.Models.ViewModels;
using InstagramProjects.BoundedContext.SqlContext;






namespace InstagramProjects.Api.Controllers.InstaUserModule
{
    [ApiController]
	[Route("api/[controller]")]
    public class SearchUserSearchController : ControllerBase
    {
        private IDbContextManager<MainSqlDbContext> DbContextManager { get; set; }
        public SearchUserSearchController(IDbContextManager<MainSqlDbContext> dbContextManager) {
            DbContextManager = dbContextManager;
        }

		[HttpPost]
        public async Task<IActionResult> Post([FromBody]Dictionary<string,string> searchParams)
        {
            var spParameters = new SqlParameter[1];
            spParameters[0] = new SqlParameter() { ParameterName = "username", Value = searchParams["username"] };
            var result = await DbContextManager.StoreProc<StoreProcResult>("sp_SearchUsername", spParameters);
            return Ok(result.SingleOrDefault()?.Result);
        }
    }
}
