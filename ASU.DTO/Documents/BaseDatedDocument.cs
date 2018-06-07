using System;

namespace ASU.DTO.Documents
{
    public abstract class BaseDatedDocument : BaseDocument
    {
        public DateTime? Date { get; set; }

        public BaseDatedDocument()
        {

        }
    }
}
