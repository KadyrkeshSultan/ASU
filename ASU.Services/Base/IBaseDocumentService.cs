using ASU.DTO.Documents;
using System;

namespace ASU.Services.Base
{
    public interface IBaseDocumentService<TDocument> : IBaseReadOnlyService<TDocument>
        where TDocument : BaseDocument
    {
        decimal Cancel(decimal doc, DateTime? change = null);
        decimal Confirm(decimal doc, DateTime? change = null);
        decimal Save(TDocument dto, DateTime? change = null);
    }
}
