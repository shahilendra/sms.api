using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SMS.Admin.Application.Classes.Command.DeleteClasses
{
    public class DeleteClassesCommad : IRequest<Unit>
    {
        public int Id { get; set; }
    }
}
