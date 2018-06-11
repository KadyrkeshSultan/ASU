using System;

namespace ASU.DTO.Documents
{
    public class BaseDocument : BaseDTO
    {
        public string Code { get; set; }
        public string DocState { get; set; }
        public string DocType { get; set; }
        public DateTime? LastChange { get; set; }
        public string Number { get; set; }

        public BaseDocument()
        {

        }

        public void SetLastChange(DateTime? value)
        {
            this.LastChange = value;
        }
    }
}
