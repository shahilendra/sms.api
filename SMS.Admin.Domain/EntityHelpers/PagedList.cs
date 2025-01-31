using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace SMS.Domain.EntityHelpers
{
    public class PagedList<T>
    {
        private PagedList(List<T> items, int page, int size, int totalCount)
        {
            Items = items;
            Page = page;
            Size = size;
            TotalCount = totalCount;
        }

        public List<T> Items { get; }

        public int Page { get; }

        public int Size { get; }

        public int TotalCount { get; }

        public bool HasNextPage => Page * Size < TotalCount;

        public bool HasPreviousPage => Page > 1;

        public static async Task<PagedList<T>> CreateAsync(IQueryable<T> query, int page, int size)
        {
            var totalCount = await query.CountAsync();
            var items = await query.Skip((page - 1) * size).Take(size).ToListAsync();

            return new(items, page, size, totalCount);
        }
    }
}
