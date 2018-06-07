using ASU.DTO.Documents;
using ASU.DTO.Documents.Validation;

namespace ASU.Services.Base
{
    public interface IBaseValidateDocumentService<TDocument, TValResult> : 
        IBaseDocumentService<TDocument>, 
        IBaseReadOnlyService<TDocument>
    where TDocument : BaseDatedDocument
    where TValResult : ValidationResult
    {
        TValResult Validate(decimal doc, string targetStateMnemo);
    }
}
