using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using RxWeb.Core;
using InstagramProjects.UnitOfWork.Main;
using InstagramProjects.Models.Main;

namespace InstagramProjects.Domain.ActivityLogModule
{
    public class vActivityLogDomain : IvActivityLogDomain
    {
        public vActivityLogDomain(IActivityLogUow uow) {
            this.Uow = uow;
        }

        public Task<object> GetAsync(vActivityLog parameters)
        {
            throw new NotImplementedException();
        }

        public async Task<object> GetBy(vActivityLog parameters)
        {
            return await Uow.Repository<vActivityLog>().FindByAsync(t => t.InstaUserId == parameters.InstaUserId);
            throw new NotImplementedException();
        }
        

        public HashSet<string> AddValidation(vActivityLog entity)
        {
            return ValidationMessages;
        }

        public async Task AddAsync(vActivityLog entity)
        {
            await Uow.RegisterNewAsync(entity);
            await Uow.CommitAsync();
        }

        public HashSet<string> UpdateValidation(vActivityLog entity)
        {
            return ValidationMessages;
        }

        public async Task UpdateAsync(vActivityLog entity)
        {
            await Uow.RegisterDirtyAsync(entity);
            await Uow.CommitAsync();
        }

        public HashSet<string> DeleteValidation(vActivityLog parameters)
        {
            return ValidationMessages;
        }

        public Task DeleteAsync(vActivityLog parameters)
        {
            throw new NotImplementedException();
        }

        public IActivityLogUow Uow { get; set; }

        private HashSet<string> ValidationMessages { get; set; } = new HashSet<string>();
    }

    public interface IvActivityLogDomain : ICoreDomain<vActivityLog, vActivityLog> { }
}
