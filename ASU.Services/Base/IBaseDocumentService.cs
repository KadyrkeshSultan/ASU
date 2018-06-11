using ASU.DTO.Documents;
using System;

namespace ASU.Services.Base
{
    public interface IBaseDocumentService<TDocument> : IBaseReadOnlyService<TDocument>
        where TDocument : BaseDocument
    {
        string Cancel(string doc, DateTime? change = null);
        string Confirm(string doc, DateTime? change = null);
        string Save(TDocument dto, DateTime? change = null);
    }
}
