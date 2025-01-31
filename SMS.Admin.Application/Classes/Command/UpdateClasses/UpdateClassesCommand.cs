using MediatR;
using Riok.Mapperly.Abstractions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SMS.Admin.Application.Classes.Command.UpdateClasses
{
    public class UpdateClassesCommand : IRequest<int>
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }

    }

    [Mapper(EnumMappingStrategy = EnumMappingStrategy.ByName)]
    public partial class UpdateClassesMapper
    {
        public partial Domain.Entities.Class ToData(UpdateClassesCommand source);

    }
}
