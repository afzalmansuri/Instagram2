using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using RxWeb.Core;
using InstagramProjects.UnitOfWork.Main;
using InstagramProjects.Models.Main;
using InstagramProjects.Models.ViewModels;
using RxWeb.Core.Security.Cryptography;
using InstagramProjects.BoundedContext.SqlContext;
using Microsoft.Data.SqlClient;
using RxWeb.Core.Data;

namespace InstagramProjects.Domain.InstaUserModule
{
    public class InstaUserDomain : IInstaUserDomain
    {
        public InstaUserDomain(IInstaUserUow uow, IDbContextManager<MainSqlDbContext> dbContextManager,IPasswordHash passwordHash) {
            this.Uow = uow;
            PasswordHash = passwordHash;
            DbContextManager = dbContextManager;
        }

        public async Task<object> GetAsync(InstaUser1 parameters)
        {
            return await Uow.Repository<InstaUser>().AllAsync();
            throw new NotImplementedException();
        }

        public async Task<object> GetBy(InstaUser1 parameters)
        {
            return await Uow.Repository<InstaUser>().FindByAsync(t => t.InstaUserId == parameters.InstaUserId);
            throw new NotImplementedException();

            /* var result= Uow.Repository<InstaUser>().FindByAsync(t => t.InstaUserId == parameters.InstaUserId);

             return await PasswordHash.ToString(result);*/
        }


        public HashSet<string> AddValidation(InstaUser1 entity)
        {
            return ValidationMessages;
        }

        public async Task AddAsync(InstaUser1 entity)
        {
            InstaUser instauser= new InstaUser();
            PasswordResult passwordResult = PasswordHash.Encrypt(entity.InstaUserPassword);
            instauser.InstaUserName = entity.InstaUserName;
            instauser.InstaUserFullName = entity.InstaUserFullName;
            instauser.InstaUserEmail = entity.InstaUserEmail;
            instauser.InstaUserMobileNumber = entity.InstaUserMobileNumber;
            instauser.InstaUserPassword = passwordResult.Signature;
            instauser.Salt = passwordResult.Salt;
            instauser.UserPrivacyId = entity.UserPrivacyId;
            instauser.InstaUserCountry = entity.InstaUserCountry;
            await Uow.RegisterNewAsync(instauser);
            await Uow.CommitAsync();

            var spParameters = new SqlParameter[2];
            spParameters[0] = new SqlParameter() { ParameterName = "username", Value = entity.InstaUserName };
            spParameters[1] = new SqlParameter() { ParameterName = "userimage", Value = entity.UserImage };
           
            await DbContextManager.StoreProc<StoreProcResult>("[dbo].forCreateUserdetailId", spParameters);
            try
            {
                await DbContextManager.CommitAsync();
            }
            catch (Exception)
            {
                DbContextManager.RollbackTransaction();
            }



        }

        public HashSet<string> UpdateValidation(InstaUser1 entity)
        {
            return ValidationMessages;
        }

        public async Task UpdateAsync(InstaUser1 entity)
        {
            InstaUser instauser = new InstaUser();
            PasswordResult passwordResult = PasswordHash.Encrypt(entity.InstaUserPassword);
            instauser.InstaUserId = entity.InstaUserId;
            instauser.InstaUserName = entity.InstaUserName;
            instauser.InstaUserFullName = entity.InstaUserFullName;
            instauser.InstaUserEmail = entity.InstaUserEmail;
            instauser.InstaUserMobileNumber = entity.InstaUserMobileNumber;
            instauser.InstaUserPassword = passwordResult.Signature;
            instauser.Salt = passwordResult.Salt;
            instauser.UserPrivacyId = entity.UserPrivacyId;
            instauser.InstaUserCountry = entity.InstaUserCountry;


            await Uow.RegisterDirtyAsync(instauser);
            await Uow.CommitAsync();
        }

        public HashSet<string> DeleteValidation(InstaUser1 parameters)
        {
            return ValidationMessages;
        }

        public Task DeleteAsync(InstaUser1 parameters)
        {
            throw new NotImplementedException();
        }

        public IInstaUserUow Uow { get; set; }

        private HashSet<string> ValidationMessages { get; set; } = new HashSet<string>();
        private IPasswordHash PasswordHash { get; set; }
        private IDbContextManager<MainSqlDbContext> DbContextManager { get; set; }
    }

    public interface IInstaUserDomain : ICoreDomain<InstaUser1, InstaUser1> { }
}
