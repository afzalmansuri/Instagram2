using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using RxWeb.Core;
using InstagramProjects.UnitOfWork.Main;
using InstagramProjects.Models.Main;

namespace InstagramProjects.Domain.HomeModule
{
    public class vFollowerPostDomain : IvFollowerPostDomain
    {
        public vFollowerPostDomain(IHomeUow uow) {
            this.Uow = uow;
        }

        public Task<object> GetAsync(vFollowerPost parameters)
        {
            throw new NotImplementedException();
        }

        public async Task<object> GetBy(vFollowerPost parameters)
        {
            return await Uow.Repository<vFollowerPost>().FindByAsync(t => t.FollowBy == parameters.FollowBy);

            throw new NotImplementedException();
        }
        

        public HashSet<string> AddValidation(vFollowerPost entity)
        {
            return ValidationMessages;
        }

        public async Task AddAsync(vFollowerPost entity)
        {
            await Uow.RegisterNewAsync(entity);
            await Uow.CommitAsync();
        }

        public HashSet<string> UpdateValidation(vFollowerPost entity)
        {
            return ValidationMessages;
        }

        public async Task UpdateAsync(vFollowerPost entity)
        {
            await Uow.RegisterDirtyAsync(entity);
            await Uow.CommitAsync();
        }

        public HashSet<string> DeleteValidation(vFollowerPost parameters)
        {
            return ValidationMessages;
        }

        public Task DeleteAsync(vFollowerPost parameters)
        {
            throw new NotImplementedException();
        }

        public IHomeUow Uow { get; set; }

        private HashSet<string> ValidationMessages { get; set; } = new HashSet<string>();
    }

    public interface IvFollowerPostDomain : ICoreDomain<vFollowerPost, vFollowerPost> { }
}
