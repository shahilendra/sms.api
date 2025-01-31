using MediatR;
using Riok.Mapperly.Abstractions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SMS.Admin.Application.Classes.Command.CreateClasses
{
    public class CreateClassesCommand : IRequest<int>
    {
        public string Name { get; set; }
        public string Description { get; set; }

    }

    [Mapper(EnumMappingStrategy = EnumMappingStrategy.ByName)]
    public partial class CreateClassesMapper
    {
        [MapperIgnoreSource(nameof(Domain.Entities.Class.Id))]
        public partial Domain.Entities.Class ToData(CreateClassesCommand source);

    }
}
