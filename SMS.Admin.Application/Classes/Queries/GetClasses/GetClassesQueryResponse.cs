using Riok.Mapperly.Abstractions;
using SMS.Domain.EntityHelpers;

namespace SMS.Admin.Application.Classes.Queries.GetClasses
{
    public class GetClassesQueryResponse
    {

    }

    public class GetClassesPaggedQueryResponse
    {
        public GetClassesPaggedQueryResponse()
        {
            Items = new List<GetClassesQueryResponse>();
        }

        public int Page { get; set; }

        public int Size { get; set; }

        public int TotalCount { get; set; }

        public bool HasNextPage { get; set; }

        public bool HasPreviousPage { get; set; }
        public List<GetClassesQueryResponse> Items { get; set; }

    }

    [Mapper(EnumMappingStrategy = EnumMappingStrategy.ByName)]
    public partial class GetClassesMapper
    {
        public partial GetClassesPaggedQueryResponse toDTO(PagedList<Domain.Entities.Class> classes);

    }
}
