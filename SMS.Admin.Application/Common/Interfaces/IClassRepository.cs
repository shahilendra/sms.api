using SMS.Admin.Domain.Entities;
using SMS.Domain.EntityHelpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SMS.Admin.Application.Common.Interfaces
{
    public interface IClassRepository
    {
        Task<PagedList<Class>> GetAsync(PageQuery query, CancellationToken cancellationToken);
        Task<int> AddAsync(Class request, CancellationToken cancellationToken);
        Task<int> UpdateAsync(Class request, CancellationToken cancellationToken);
        Task<int> DeleteAsync(int request, CancellationToken cancellationToken);
    }
}
