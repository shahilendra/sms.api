using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SMS.Domain.EntityHelpers
{
    public class PageQuery
    {
        const int maxPageSize = 100;
        public int Page { get; set; } = 1;
        private int _size { get; set; } = 20;
        public int Size
        {
            get
            {
                return _size;
            }
            set
            {
                _size = (value > maxPageSize) ? maxPageSize : value;
            }
        }
    }
}
