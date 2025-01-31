using MediatR;
using SMS.Admin.Application.Common.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SMS.Admin.Application.Classes.Command.CreateClasses
{
    public class CreateClassesCommandHandler : IRequestHandler<CreateClassesCommand, int>
    {
        private readonly IClassRepository _classRepository;
        public CreateClassesCommandHandler(IClassRepository classRepository)
        {
            _classRepository = classRepository;
        }

        public async Task<int> Handle(CreateClassesCommand request, CancellationToken cancellationToken)
        {
            var result = new CreateClassesMapper().ToData(request);
            return await _classRepository.AddAsync(result, cancellationToken);
        }
    }
}
