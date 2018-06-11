using ASU.DTO.Documents;
using ASU.DTO.Documents.Validation;
using System.Collections.Generic;

namespace ASU.Services.Base
{
    public interface IBaseValidateDetailedDocumentService<TDocument, TValResult> :
        IBaseDocumentService<TDocument>,
        IBaseReadOnlyService<TDocument>
    where TDocument : BaseDatedDocument
    where TValResult : DetailItemValidationResult
    {
        IEnumerable<TValResult> Validate(string doc, string targetStateMnemo);
    }
}
