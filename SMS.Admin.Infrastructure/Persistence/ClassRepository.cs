using SMS.Admin.Application.Common.Interfaces;
using SMS.Admin.Domain.Entities;
using SMS.Domain.EntityHelpers;

namespace SMS.Admin.Infrastructure.Persistence
{
    public class ClassRepository : IClassRepository
    {
        private readonly IQueryable<Class> _classes = new List<Class>
        {
            new Class { Id = 1, Name ="1"},
            new Class { Id = 2,Name ="2"},
            new Class { Id = 3,Name ="3"},
            new Class { Id = 4,Name ="4"},
            new Class { Id = 5,Name ="5"},
            new Class { Id = 6,Name ="6"},
            new Class { Id = 7,Name ="7"},
            new Class { Id = 8,Name ="8"},
            new Class { Id = 9,Name ="9"},
            new Class { Id = 10,Name ="10"},
            new Class { Id = 11,Name ="11"},
            new Class { Id = 12,Name ="12"},
            new Class { Id = 13,Name ="13"}
        }.AsQueryable();
        public ClassRepository() { }

        public async Task<PagedList<Class>> GetAsync(PageQuery query, CancellationToken cancellationToken)
        {
            return await PagedList<Class>.CreateAsync(
            _classes, query.Page, query.Size);
        }

        public async Task<int> AddAsync(Class request, CancellationToken cancellationToken)
        {
            _classes.Append(request);
            return await Task.FromResult(request.Id);
        }

        public async Task<int> UpdateAsync(Class request, CancellationToken cancellationToken)
        {
            return await Task.FromResult(request.Id);
        }

        public async Task<int> DeleteAsync(int request, CancellationToken cancellationToken)
        {
            return await Task.FromResult(request);
        }
    }
}
