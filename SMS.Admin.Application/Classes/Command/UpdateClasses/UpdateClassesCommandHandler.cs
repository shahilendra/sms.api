using MediatR;
using SMS.Admin.Application.Common.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SMS.Admin.Application.Classes.Command.UpdateClasses
{
    public class UpdateClassesCommandHandler : IRequestHandler<UpdateClassesCommand, int>
    {

        private readonly IClassRepository _classRepository;
        public UpdateClassesCommandHandler(IClassRepository classRepository)
        {
            _classRepository = classRepository;
        }
        public async Task<int> Handle(UpdateClassesCommand request, CancellationToken cancellationToken)
        {
           return await _classRepository.UpdateAsync(new UpdateClassesMapper().ToData(request), cancellationToken);
        }
    }
}
