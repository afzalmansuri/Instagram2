using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using RxWeb.Core;
using InstagramProjects.UnitOfWork.Main;
using InstagramProjects.Models.Main;
using InstagramProjects.Models.ViewModels;
using RxWeb.Core.Security.Cryptography;
using InstagramProjects.Infrastructure.Security;
using Microsoft.AspNetCore.Mvc;

namespace InstagramProjects.Domain.InstaLoginModule
{
    public class InstaLoginDomain : IInstaLoginDomain
    {
        private IApplicationTokenProvider ApplicationTokenProvider { get; set; }
        public InstaLoginDomain(IInstaUserUow uow, IPasswordHash passwordHash, IApplicationTokenProvider tokenProvider) {
            this.Uow = uow;
            PasswordHash = passwordHash;
            ApplicationTokenProvider = tokenProvider;
        }

        public Task<object> GetAsync(InstaUser1 parameters)
        {
            throw new NotImplementedException();
        }

        
        public async Task<object> GetBy(InstaUser1 parameters)
        {
            InstaUser InstaUser = new InstaUser();
            var result = await Uow.Repository<InstaUser>().SingleOrDefaultAsync(t => (t.InstaUserName == parameters.InstaUserName || t.InstaUserEmail == parameters.InstaUserName || t.InstaUserMobileNumber == parameters.InstaUserName));


            if (result != null && PasswordHash.VerifySignature(parameters.InstaUserPassword, result.InstaUserPassword, result.Salt))
            {
                result.token = await ApplicationTokenProvider.GetTokenAsync(result);
               
                return (result);
            }
            else
            {
                return ("Login Failed");
            }

            throw new NotImplementedException();
        }
        

        public HashSet<string> AddValidation(InstaUser1 entity)
        {
            return ValidationMessages;
        }

        
        public async Task AddAsync(InstaUser1 entity)
        {
            /*InstaUser InstaUser = new InstaUser();
            var result = await Uow.Repository<InstaUser>().SingleOrDefaultAsync(t => (t.InstaUserName == entity.InstaUserName || t.InstaUserEmail == entity.InstaUserName || t.InstaUserMobileNumber == entity.InstaUserName));


            if (result != null && PasswordHash.VerifySignature(entity.InstaUserPassword, result.InstaUserPassword, result.Salt))
            {
                result.token = await ApplicationTokenProvider.GetTokenAsync(result);

                return (result);
            }
            else
            {
                return ("Login Failed");
            }*/
            await Uow.RegisterNewAsync(entity);
            await Uow.CommitAsync();
        }

        public HashSet<string> UpdateValidation(InstaUser1 entity)
        {
            return ValidationMessages;
        }

        public async Task UpdateAsync(InstaUser1 entity)
        {
            await Uow.RegisterDirtyAsync(entity);
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
    }

    public interface IInstaLoginDomain : ICoreDomain<InstaUser1, InstaUser1> { }
}
