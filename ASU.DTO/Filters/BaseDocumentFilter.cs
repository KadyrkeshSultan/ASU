using System;

namespace ASU.DTO.Filters
{
    public class BaseDocumentFilter : BaseFilter
    {
        public DateTime? Begin { get; set; }
        public DateTime? End { get; set; }

        public BaseDocumentFilter()
        {

        }
    }
}
