using System.Collections.Generic;
using Microsoft.Data.SqlClient;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using RxWeb.Core.Security;
using RxWeb.Core.Data;
using InstagramProjects.Models.ViewModels;
using InstagramProjects.BoundedContext.SqlContext;
using Microsoft.AspNetCore.Authorization;
using InstagramProjects.Models.Main;
using System;

namespace InstagramProjects.Api.Controllers.Module
{
    [ApiController]
	[Route("api/[controller]")]
    [AllowAnonymous]
    public class SearchFindChatsDetailController : ControllerBase
    {
        private IDbContextManager<MainSqlDbContext> DbContextManager { get; set; }
        public SearchFindChatsDetailController(IDbContextManager<MainSqlDbContext> dbContextManager) {
            DbContextManager = dbContextManager;
        }

        [HttpPost]
        public async Task<IActionResult> Post([FromBody]Dictionary<string,string> parameters)
        {
            /*await Uow.Repository<Chat>().FindByAsync(a => a.SenderId == parameters.SenderId && a.RecieverId == parameters.RecieverId);*/

            await DbContextManager.BeginTransactionAsync();

            var spParameters = new SqlParameter[2];
            spParameters[0] = new SqlParameter() { ParameterName = "SenderId", Value = parameters["SenderId"] };
            spParameters[1] = new SqlParameter() { ParameterName = "RecieverId", Value = parameters["RecieverId"] };


            var result = await DbContextManager.StoreProc<StoreProcResult>("[dbo].vChats ", spParameters);

            return Ok(result.SingleOrDefault()?.Result);
            throw new NotImplementedException();
        }

    }
}
