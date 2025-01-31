using MediatR;
using SMS.Domain.EntityHelpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SMS.Admin.Application.Classes.Queries.GetClasses
{
    public record GetClassesQuery(PageQuery pageQuery) : IRequest<GetClassesPaggedQueryResponse>;
}
