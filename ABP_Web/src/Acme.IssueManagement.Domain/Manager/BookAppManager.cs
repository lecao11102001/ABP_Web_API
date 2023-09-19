using Acme.IssueManagement.Entities;
using Acme.IssueManagement.Repository;
using Acme.IssueManagement.Specifications;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Volo.Abp.DependencyInjection;
using Volo.Abp.Domain.Services;

namespace Acme.IssueManagement.Manager
{
    public class BookAppManager : DomainService, ITransientDependency
    {
        private readonly IBookAppRepository _repository;

        public BookAppManager(IBookAppRepository repository)
        {
            _repository = repository;
        }

        public async Task<IEnumerable<Book>> GetListAsync(BookAppSpecifications specification)
        {
            var query = await _repository.GetQueryableAsync();

            return await AsyncExecuter.ToListAsync(query.Where(specification));
        }
    }
}
