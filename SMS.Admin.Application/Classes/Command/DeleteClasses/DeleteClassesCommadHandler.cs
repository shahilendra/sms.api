using MediatR;
using SMS.Admin.Application.Common.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SMS.Admin.Application.Classes.Command.DeleteClasses
{
    public class DeleteClassesCommadHandler : IRequestHandler<DeleteClassesCommad, Unit>
    {

        private readonly IClassRepository _classRepository;
        public DeleteClassesCommadHandler(IClassRepository classRepository)
        {
            _classRepository = classRepository;
        }
        public async Task<Unit> Handle(DeleteClassesCommad request, CancellationToken cancellationToken)
        {
            var result = await _classRepository.DeleteAsync(request.Id, cancellationToken);
            return new Unit();
        }
    }
}
