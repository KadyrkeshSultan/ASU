using System;
using System.Collections.Generic;
using System.Text;

namespace ASU.DTO.Documents.Validation
{
    public class ValidationResult
    {
        public decimal Code { get; set; }
        public string String { get; set; }
        public eResult Result
        {
            get
            {
                if (this.Code == new decimal(0))
                {
                    return eResult.Ok;
                }
                if (this.Code >= new decimal(0))
                {
                    return eResult.Warning;
                }
                return eResult.Error;
            }
        }
        public ValidationResult()
        {

        }
    }
}
