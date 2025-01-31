using MediatR;
using SMS.Admin.Application.Common.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SMS.Admin.Application.Classes.Queries.GetClasses
{
    public class GetClassesQueryHandler : IRequestHandler<GetClassesQuery, GetClassesPaggedQueryResponse>
    {
        private readonly IClassRepository _classRepository;

        public GetClassesQueryHandler(IClassRepository classRepository)
        {
            _classRepository = classRepository;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public async Task<GetClassesPaggedQueryResponse> Handle(GetClassesQuery request, CancellationToken cancellationToken)
        {
            var classes = await _classRepository.GetAsync(request.pageQuery, cancellationToken);
            var mapper = new GetClassesMapper();
            return mapper.toDTO(classes);
        }
    }
}
