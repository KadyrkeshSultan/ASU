using System.Collections.Generic;
using System.Linq;

namespace ASU.DTO.Documents
{
    public abstract class BaseGenericDetailedDocument<TDetailItem> : BaseDatedDocument
        where TDetailItem : DetailItem
    {
        public IList<TDetailItem> Details { get; set; }

        public int Count
        {
            get
            {
                if (this.Details == null)
                    return 0;
                return this.Details.Sum(p => p.Count);
            }
        }

        public BaseGenericDetailedDocument()
        {
            this.Details = new List<TDetailItem>();
        }
    }
}
